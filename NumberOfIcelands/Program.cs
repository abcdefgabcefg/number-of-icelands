using System.Collections.Generic;
using System.Linq;

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

            // 8
            var threeFour = new GridNode(grid[3, 4]);

            // 7
            var threeThree = new GridNode(grid[3, 3], threeFour);
            var twoFour = new GridNode(grid[2, 4], threeFour);

            // 6
            var threeTwo = new GridNode(grid[3, 2], threeThree);
            var twoThree = new GridNode(grid[2, 3], threeThree, twoFour);
            var oneFour = new GridNode(grid[1, 4], twoFour);

            // 5
            var threeOne = new GridNode(grid[3, 1], threeTwo);
            var twoTwo = new GridNode(grid[2, 2], threeTwo, twoThree);
            var oneThree = new GridNode(grid[1, 3], twoThree, oneFour);
            var zeroFour = new GridNode(grid[0, 4], oneFour);

            // 4
            var threeZero = new GridNode(grid[3, 0], threeOne);
            var twoOne = new GridNode(grid[2, 1], threeOne, twoTwo);
            var oneTwo = new GridNode(grid[1, 2], twoTwo, oneThree);
            var zeroThree = new GridNode(grid[0, 3], oneThree, zeroFour);

            // 3
            var twoZero = new GridNode(grid[2, 0], threeZero, twoOne);
            var oneOne = new GridNode(grid[1, 1], twoOne, oneTwo);
            var zeroTwo = new GridNode(grid[0, 2], oneTwo, zeroThree);

            // 2
            var oneZero = new GridNode(grid[1, 0], twoZero, oneOne);
            var zeroOne = new GridNode(grid[0, 1], oneOne, zeroTwo);

            // 1
            var root = new GridNode(grid[0, 0], oneZero, zeroOne);

            var queue = new Queue<Place>();

            Enqueue(queue, root);

            var icelandsCount = 0;
            var isPreviousZero = false;
            var wasIcelandEnded = true;
            while (queue.Any())
            {
                var place = queue.Dequeue();

                switch (place.Type)
                {
                    case 0:
                        
                        if (isPreviousZero)
                        {
                            wasIcelandEnded = true;
                        }

                        isPreviousZero = true;
                        break;
                    
                    case 1:
                        
                        if (wasIcelandEnded)
                        {
                            icelandsCount++;
                        }

                        isPreviousZero = false;
                        wasIcelandEnded = false;
                        break;
                }
            }
        }

        private static void Enqueue(Queue<Place> queue, params GridNode[] nodes)
        {
            if (!nodes.Any())
            {
                return;
            }

            foreach (var node in nodes)
            {
                queue.Enqueue(node.Place);
            }

            var nextLevel = nodes
                .SelectMany(node => node.Children)
                .Distinct()
                .ToArray();

            Enqueue(queue, nextLevel);
        }
    }
}
