using MatrixTraverser.Contracts;

namespace MatrixTraverser.Core
{
    /// <summary>Defines a tile in a 2D matrix</summary>
    public struct Tile : ITile
    {
        public Tile(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }
    }
}