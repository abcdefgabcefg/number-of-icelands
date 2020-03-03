using TreeCollections;

namespace NumberOfIcelands
{
    public class IcelandNode : SerialTreeNode<IcelandNode>
    {
        public IcelandNode() { }

        public IcelandNode(int type, params IcelandNode[] children) : base(children)
        {
            Type = type;
        }

        public int Type { get; }
    }
}
