namespace VexxedLib.Utils.Array
{
    public class ArrayHelper2D<T>
    {
        #region Variables

        // Variables.
        public int width;

        public int height;

        public int[] northWest;
        public int[] north;
        public int[] northEast;
        public int[] west;
        public int[] east;
        public int[] southWest;
        public int[] south;
        public int[] southEast;

        #endregion Variables

        #region Constructors

        // Constructors.
        public ArrayHelper2D(T[,] array)
        {
            this.width = array.GetLength(0);
            this.height = array.GetLength(0);

            // over, across
            this.northWest = new int[] { -1, -1 };
            this.north = new int[] { 0, -1 };
            this.northEast = new int[] { 1, -1 };
            this.west = new int[] { -1, 0 };
            this.east = new int[] { 1, 0 };
            this.southWest = new int[] { -1, 1 };
            this.south = new int[] { 0, 1 };
            this.southEast = new int[] { 1, 1 };
        }

        #endregion Constructors

        #region Private Methods

        // Private Methods.

        #endregion Private Methods

        #region Public Methods

        // Public Methods.
        /// <summary>
        /// Return all 8 cell index around cell with a given width of array.
        /// Adding each number to the current index will get the cell in that direction away.
        /// Repeat to get 2+ away.
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public int[][] GetAdjacentCellOffsets()
        {
            return new int[][]
            {
                northWest,
                north,
                northEast,
                west,
                east,
                southWest,
                south,
                southEast
            };
        }

        public int[][] GetCardinalCellOffsets()
        {
            return new int[][]
            {
                north,
                west,
                east,
                south
            };
        }

        #endregion Public Methods
    }
}