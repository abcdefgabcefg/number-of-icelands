using TreeCollections;

namespace NumberOfIcelands
{
    public class GridNode : SerialTreeNode<GridNode>
    {
        public Place Place { get; }

        public GridNode() { }

        public GridNode(int type, params GridNode[] children) : base(children)
        {
            Place = new Place(type);
        }
    }
}
