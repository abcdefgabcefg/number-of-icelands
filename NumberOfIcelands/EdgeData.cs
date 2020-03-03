namespace NumberOfIcelands
{
    public class EdgeData
    {
        public Index Parent { get; }

        public Index Child { get; }

        public EdgeData(Index parent, Index child)
        {
            Parent = parent;
            Child = child;
        }
    }
}
