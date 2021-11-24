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
        
        public void MarkCell(MarkType mark)
        {
            if(!this.isEmpty())
            {
                throw new Exception("Cell Is Already Marked");
            }
            _mark = mark;
        }
        public bool isEmpty()
        {
            if (_mark == MarkType.EMPTY) return true;
         
            return false;
        }
        public MarkType Mark
        {
            get
            {
                return _mark;
            }
        }
    }
}
