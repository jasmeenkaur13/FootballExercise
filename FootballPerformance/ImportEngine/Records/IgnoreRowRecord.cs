using FileHelpers;

namespace FootballPerformance.ImportEngine.Records
{
    /// <summary>
    /// class to represent ignored row of -
    /// </summary>
    [FixedLengthRecord(FixedMode.AllowLessChars)]
    public class IgnoreRowRecord
    {
        [FieldOrder(1), FieldFixedLength(72)]
        [FieldTrim(TrimMode.Both)]
        public string IgnoreDelimeterHyphenAfter17Rows;
    }
}
