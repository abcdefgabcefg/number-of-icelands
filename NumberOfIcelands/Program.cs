using QuickGraph;

namespace NumberOfIcelands
{
    public static class Program
    {
        public static void Main()
        {
            var grid = new int[,]
            {
                { 1, 1, 0, 0, 0 },
                { 1, 1, 0, 0, 0 },
                { 0, 0, 1, 0, 0 },
                { 0, 0, 0, 1, 1 }
            };

            var edgesData = new[]
            {
                new EdgeData(new Index(0, 0), new Index(1, 0)),
                new EdgeData(new Index(0, 0), new Index(0, 1)),
                new EdgeData(new Index(1, 0), new Index(2, 0)),
                new EdgeData(new Index(1, 0), new Index(1, 1)),
                new EdgeData(new Index(0, 1), new Index(1, 1)),
                new EdgeData(new Index(0, 1), new Index(0, 2)),
                new EdgeData(new Index(2, 0), new Index(3, 0)),
                new EdgeData(new Index(2, 0), new Index(2, 1)),
                new EdgeData(new Index(1, 1), new Index(2, 1)),
                new EdgeData(new Index(1, 1), new Index(1, 2)),
                new EdgeData(new Index(0, 2), new Index(1, 2)),
                new EdgeData(new Index(0, 2), new Index(0, 3)),
                new EdgeData(new Index(3, 0), new Index(3, 1)),
                new EdgeData(new Index(2, 1), new Index(3, 1)),
                new EdgeData(new Index(2, 1), new Index(2, 2)),
                new EdgeData(new Index(1, 2), new Index(2, 2)),
                new EdgeData(new Index(1, 2), new Index(1, 3)),
                new EdgeData(new Index(0, 3), new Index(1, 3)),
                new EdgeData(new Index(0, 3), new Index(0, 4)),
                new EdgeData(new Index(3, 1), new Index(3, 2)),
                new EdgeData(new Index(2, 2), new Index(3, 2)),
                new EdgeData(new Index(2, 2), new Index(2, 3)),
                new EdgeData(new Index(1, 3), new Index(2, 3)),
                new EdgeData(new Index(1, 3), new Index(1, 4)),
                new EdgeData(new Index(0, 4), new Index(1, 4)),
                new EdgeData(new Index(3, 2), new Index(3, 3)),
                new EdgeData(new Index(2, 3), new Index(3, 3)),
                new EdgeData(new Index(2, 3), new Index(2, 4)),
                new EdgeData(new Index(1, 4), new Index(2, 4)),
                new EdgeData(new Index(3, 3), new Index(3, 4)),
                new EdgeData(new Index(2, 4), new Index(3, 4))
            };

            var vertextComparer = new GridVertexComparer();
            var graph = new UndirectedGraph<GridVertex, IUndirectedEdge<GridVertex>>(
                false, 
                (edge, source, target) => vertextComparer.Equals(edge.Source, source) && vertextComparer.Equals(edge.Target, target),
                100,
                vertextComparer);

            foreach (var edgeData in edgesData)
            {
                var parent = new GridVertex(grid[edgeData.Parent.Row, edgeData.Parent.Column], edgeData.Parent.Row, edgeData.Parent.Column);
                var child = new GridVertex(grid[edgeData.Child.Row, edgeData.Child.Column], edgeData.Child.Row, edgeData.Child.Column);

                var edge = new UndirectedEdge<GridVertex>(parent, child);

                graph.AddVerticesAndEdge(edge);
            }
        }
    }
}
