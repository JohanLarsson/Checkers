namespace Checkers
{
    using System.Collections.Generic;

    public class Vm
    {
        public Vm()
        {
            var cells = new List<CellVm>();
            for (var r = 0; r < 8; r++)
            {
                for (var c = 0; c < 8; c++)
                {
                    cells.Add(new CellVm(r,c));
                }
            }

            this.Cells = cells;
        }

        public IReadOnlyList<CellVm> Cells { get;  }
    }
}
