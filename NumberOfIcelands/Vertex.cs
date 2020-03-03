namespace NumberOfIcelands
{
    public class GridVertex
    {
        public GridVertex(int value, int row, int column)
        {
            Value = value;
            Row = row;
            Column = column;
        }

        public int Value { get; }

        public int Row { get; }

        public int Column { get; }
    }
}
