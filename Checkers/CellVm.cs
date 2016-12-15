namespace Checkers
{
    public class CellVm
    {
        public CellVm(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row { get; }
        public int Col { get; }
    }
}