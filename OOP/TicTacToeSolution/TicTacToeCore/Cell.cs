using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCore
{
   public class Cell
    {
        private MarkType _mark;

        public Cell()
        {
            _mark = MarkType.EMPTY;
        }
        public MarkType Mark
        {
            get
            {
                return _mark;
            }
        }
        public void MarkCell(MarkType mark)
        {
            if(!this.isEmpty())
            {
                throw new Exception("Cell Is Already Marked");
            }
        }
        public bool isEmpty()
        {
            if (_mark == MarkType.EMPTY) return true;
         
            return false;
        }
    }
}
