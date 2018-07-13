using FileHelpers;
using FileHelpers.Events;
using FootballPerformance.ImportEngine.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballPerformance.ImportEngine
{
    /// <summary>
    /// Class to import the contents of file.
    /// </summary>
    public class File72ByteImportEngine
    {
        private readonly string ColumnHeader1 = "team";
        private readonly string ColumnHeader2 = "p";
        private readonly string ColumnHeader3 = "w";
        private readonly string ColumnHeader4 = "l";
        private readonly string ColumnHeader5 = "d";
        private readonly string ColumnHeader6 = "f";
        private readonly string ColumnHeader7 = "a";
        private readonly string ColumnHeader8 = "pts";
        private readonly string ErrorMessageInvalidColumns = "Columns in file are not in proper format.";

        /// <summary>
        /// Method to import file with the help of multi record engine
        /// </summary>
        /// <param name="filePath">path where file is located</param>
        /// <returns>list of data records in the file</returns>
        public List<DataRecord> EvaluateFileContents(string filePath) {
            List<DataRecord> results = new List<DataRecord>();
            MultiRecordEngine file72ByteEngine = new MultiRecordEngine(typeof(DataRecord),
                                                typeof(ColumHeaderRecord),
                                                typeof(IgnoreRowRecord))
            {
                RecordSelector = new RecordTypeSelector(CustomSelector),
                ErrorMode = ErrorMode.ThrowException
            };

            var res = file72ByteEngine.ReadFile(filePath);

            foreach (var rec in res)
                if (rec.GetType() == typeof(DataRecord))
                {
                    results.Add((DataRecord)rec);
                    
                }
                else if (rec.GetType() == typeof(ColumHeaderRecord))
                {
                    var columnRecord = (ColumHeaderRecord)rec;
                    if (!(ColumnHeader1.Equals(columnRecord.TeamName.ToLower(), StringComparison.OrdinalIgnoreCase)
                    && ColumnHeader2.Equals(columnRecord.P.ToLower(), StringComparison.OrdinalIgnoreCase)
                    && ColumnHeader3.Equals(columnRecord.W.ToLower(), StringComparison.OrdinalIgnoreCase)
                    && ColumnHeader4.Equals(columnRecord.L.ToLower(), StringComparison.OrdinalIgnoreCase)
                    && ColumnHeader5.Equals(columnRecord.D.ToLower(), StringComparison.OrdinalIgnoreCase)
                    && ColumnHeader6.Equals(columnRecord.F.ToLower(), StringComparison.OrdinalIgnoreCase)
                    && ColumnHeader7.Equals(columnRecord.A.ToLower(), StringComparison.OrdinalIgnoreCase)
                    && ColumnHeader8.Equals(columnRecord.Pts.ToLower(), StringComparison.OrdinalIgnoreCase)))
                    {
                        throw new FormatException(ErrorMessageInvalidColumns);
                    }
                }
            return results;
        }

        /// <summary>
        /// Custom selector to switch between the type of Record formats that can be present in the class
        /// </summary>
        /// <param name="engine">engine used to reading the file</param>
        /// <param name="recordLine">current line to be processed</param>
        /// <returns>the record type for that line</returns>
        private Type CustomSelector(MultiRecordEngine engine, string recordLine)
        {
            if (recordLine.Length == 0)
                return null;

            if (recordLine[0] == '-')
                return typeof(IgnoreRowRecord);
            else if (string.IsNullOrWhiteSpace(recordLine.Substring(0, 4)))
                return typeof(ColumHeaderRecord);
            else
                return typeof(DataRecord);
        }

    }
}
