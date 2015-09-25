using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solver
{
    public class Puzzle
    {
        private const int Any = 0x1f;
        public Cell[] Cells { get; set; }

        public Puzzle()
        {
            Cells = new Cell[27];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    var index = (i*9) + j;
                    var sector = ((i/3)*3) + (j/3);
                    Cells[index] = new Cell
                    {
                        Row = i,
                        Column = j,
                        Sector = sector,
                        Value = 0,
                        CanBeInRow = Any,
                        CanBeInColumn = Any,
                        CanBeInSector = Any
                    };

                    Cells[index].PropertyChanged += OnPropertyChanged;
                }
            }
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            var cell = sender as Cell;
            switch (propertyChangedEventArgs.PropertyName)
            {
                case "Value":
                    break;
                case "CanBeInRow":
                    break;
                case "CanBeInColumn":
                    break;
                case "CanBeInSector":
                    break;
            }
        }
    }
}
