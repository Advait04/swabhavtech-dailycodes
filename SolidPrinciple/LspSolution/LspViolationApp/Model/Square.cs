using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LspViolationApp.Model
{
    class Square : Rectangle
    {
        public Square(int side) : base(side, side) { }
        public override int Height
        {
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
        public override int Width
        {
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }

    }
}
