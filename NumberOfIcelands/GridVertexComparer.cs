using System.Collections.Generic;

namespace NumberOfIcelands
{
    public class GridVertexComparer : IEqualityComparer<GridVertex>
    {
        public bool Equals(GridVertex x, GridVertex y)
        {
            return x.Value == y.Value
                && x.Row == y.Row
                && x.Column == y.Column;
        }

        public int GetHashCode(GridVertex obj)
        {
            return (obj.Value - obj.Column * obj.Row).GetHashCode();
        }
    }
}
