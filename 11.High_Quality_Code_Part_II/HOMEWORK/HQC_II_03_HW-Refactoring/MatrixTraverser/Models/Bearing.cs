namespace MatrixTraverser.Models
{
    internal struct Bearing
    {
        public int x;
        public int y;

        public Bearing(int row, int col)
        {
            x = col;
            y = row;
        }
    }
}