using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersLibrary
{
    public class SquareBoard
    {
        #region Поля

        private int row;
        private int column;
        private bool isBlack;

        #endregion

        #region Свойства

        public int Row
        {
            get
            {
                return row;
            }
            set
            {
                if (value >= 1 && value <= 8)
                    row = value;
            }
        }

        public int Column
        {
            get
            {
                return column;
            }
            set
            {
                if(value >=1 && value <= 8)
                    column = value;
            }
        }

        public bool IsBlack
        {
            get
            {
                return isBlack;
            }
            set
            {
                isBlack = value;
            }
        }

        #endregion

        #region Конструкторы

        public SquareBoard(int row, int column)
        {
            Row = row;
            Column = column;
            IsBlack = (Row + Column) % 2 == 1;
        }

        #endregion

        #region Методы



        #endregion
    }
}
