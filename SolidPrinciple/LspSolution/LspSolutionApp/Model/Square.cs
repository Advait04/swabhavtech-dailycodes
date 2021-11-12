using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LspSolutionApp.Model
{
    class Square
    {
        private int _side;
        public Square(int side)
        {
            _side = side;
        }
        public int Side { get { return _side; } set { _side = value; } }
        public int CalculateArea()
        {
            return _side * _side;
        }
    }
}
