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
            var threeFour = new IcelandNode(grid[3, 4]);

            // 7
            var threeThree = new IcelandNode(grid[3, 3], threeFour);
            var twoFour = new IcelandNode(grid[2, 4], threeFour);

            // 6
            var threeTwo = new IcelandNode(grid[3, 2], threeThree);
            var twoThree = new IcelandNode(grid[2, 3], threeThree, twoFour);
            var oneFour = new IcelandNode(grid[1, 4], twoFour);

            // 5
            var threeOne = new IcelandNode(grid[3, 1], threeTwo);
            var twoTwo = new IcelandNode(grid[2, 2], threeTwo, twoThree);
            var oneThree = new IcelandNode(grid[1, 3], twoThree, oneFour);
            var zeroFour = new IcelandNode(grid[0, 4], oneFour);

            // 4
            var threeZero = new IcelandNode(grid[3, 0], threeOne);
            var twoOne = new IcelandNode(grid[2, 1], threeOne, twoTwo);
            var oneTwo = new IcelandNode(grid[1, 2], twoTwo, oneThree);
            var zeroThree = new IcelandNode(grid[0, 3], oneThree, zeroFour);

            // 3
            var twoZero = new IcelandNode(grid[2, 0], threeZero, twoOne);
            var oneOne = new IcelandNode(grid[1, 1], twoOne, oneTwo);
            var zeroTwo = new IcelandNode(grid[0, 2], oneTwo, zeroThree);

            // 2
            var oneZero = new IcelandNode(grid[1, 0], twoZero, oneOne);
            var zeroOne = new IcelandNode(grid[0, 1], oneOne, zeroTwo);

            // 1
            var root = new IcelandNode(grid[0, 0], oneZero, zeroOne);
        }
    }
}
