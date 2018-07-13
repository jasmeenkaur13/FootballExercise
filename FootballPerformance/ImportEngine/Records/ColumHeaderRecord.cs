using FileHelpers;

namespace FootballPerformance.ImportEngine.Records
{
    /// <summary>
    /// Class to represent the column headers
    /// </summary>
    [FixedLengthRecord(FixedMode.AllowLessChars)]
    public class ColumHeaderRecord
    {
        [FieldOrder(1), FieldFixedLength(5)]
        [FieldTrim(TrimMode.Both)]
        public string WhiteSpaces;

        [FieldOrder(2), FieldFixedLength(16)]
        [FieldTrim(TrimMode.Both)]
        public string TeamName;

        [FieldOrder(3), FieldFixedLength(6)]
        [FieldTrim(TrimMode.Both)]
        public string P;

        [FieldOrder(4), FieldFixedLength(6)]
        [FieldTrim(TrimMode.Both)]
        public string W;

        [FieldOrder(5), FieldFixedLength(6)]
        [FieldTrim(TrimMode.Both)]
        public string L;

        [FieldOrder(6), FieldFixedLength(6)]
        [FieldTrim(TrimMode.Both)]
        public string D;

        [FieldOrder(7), FieldFixedLength(8)]
        [FieldTrim(TrimMode.Both)]
        public string F;

        [FieldOrder(8), FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string IgnoreDelimeterHyphen;

        [FieldOrder(9), FieldFixedLength(8)]
        [FieldTrim(TrimMode.Both)]
        public string A;

        [FieldOrder(10), FieldFixedLength(8)]
        [FieldTrim(TrimMode.Both)]
        public string Pts;

    }
}
