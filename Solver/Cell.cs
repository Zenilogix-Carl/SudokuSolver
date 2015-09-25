using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Solver
{
    public class Cell : INotifyPropertyChanged
    {

        private int _canBeInRow;
        private int _canBeInColumn;
        private int _canBeInSector;
        private int _row;
        private int _column;
        private int _sector;
        private int _value;

        public int CanBeInRow
        {
            get { return _canBeInRow; }
            set { _canBeInRow = value; NotifyPropertyChanged();}
        }

        public int CanBeInColumn
        {
            get { return _canBeInColumn; }
            set { _canBeInColumn = value; NotifyPropertyChanged(); }
        }

        public int CanBeInSector
        {
            get { return _canBeInSector; }
            set { _canBeInSector = value; NotifyPropertyChanged(); }
        }

        public int Row
        {
            get { return _row; }
            set { _row = value; NotifyPropertyChanged(); }
        }

        public int Column
        {
            get { return _column; }
            set { _column = value; NotifyPropertyChanged(); }
        }

        public int Sector
        {
            get { return _sector; }
            set
            { 
                _sector = value;
                NotifyPropertyChanged(); 
            }
        }

        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
