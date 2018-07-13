using FileHelpers;

namespace FootballPerformance.ImportEngine.Records
{
    /// <summary>
    /// Class to store the data properties of file.
    /// </summary>
    [FixedLengthRecord(FixedMode.AllowLessChars)]
    public class DataRecord
    {
        [FieldOrder(1), FieldFixedLength(4)]
        [FieldTrim(TrimMode.Both)]
        public int SerialNumber;

        [FieldOrder(2), FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string IgnoredDelimeter;

        [FieldOrder(3), FieldFixedLength(16)]
        [FieldTrim(TrimMode.Both)]
        public string TeamName;

        [FieldOrder(4), FieldFixedLength(6)]
        [FieldTrim(TrimMode.Both)]
        public int P;

        [FieldOrder(5), FieldFixedLength(6)]
        [FieldTrim(TrimMode.Both)]
        public int W;

        [FieldOrder(6), FieldFixedLength(6)]
        [FieldTrim(TrimMode.Both)]
        public int L;

        [FieldOrder(7), FieldFixedLength(6)]
        [FieldTrim(TrimMode.Both)]
        public int D;

        [FieldOrder(8), FieldFixedLength(8)]
        [FieldTrim(TrimMode.Both)]
        public int F;

        [FieldOrder(9), FieldFixedLength(1)]
        [FieldTrim(TrimMode.Both)]
        public string IgnoreDelimeterHyphen;

        [FieldOrder(10), FieldFixedLength(8)]
        [FieldTrim(TrimMode.Both)]
        public int A;

        [FieldOrder(11), FieldFixedLength(8)]
        [FieldTrim(TrimMode.Both)]
        public int Pts;

    }
}
