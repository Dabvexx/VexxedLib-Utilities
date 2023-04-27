namespace VexxedLib.Utils.Array
{
    public class ArrayHelper
    {
        #region Variables

        // Variables.
        public int width;

        public int height;

        public int northWest;
        public int north;
        public int northEast;
        public int west;
        public int east;
        public int southWest;
        public int south;
        public int southEast;

        #endregion Variables

        #region Constructors

        // Constructors.
        public ArrayHelper(int width, int height)
        {
            this.width = width;
            this.height = height;

            this.northWest = -width - 1;
            this.north = -width;
            this.northEast = -width + 1;
            this.west = -1;
            this.east = 1;
            this.southWest = width - 1;
            this.south = width;
            this.southEast = width + 1;
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
        public int[] GetAdjacentCellOffsets()
        {
            return new int[]
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

        public int[] GetCardinalCellOffsets()
        {
            return new int[]
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