using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropertySyntaxApp.Model
{
    class Foo
    {
        private int _bar;

        public int Bar
        {
            get
            {
                return _bar;

            }
            set
            {
                if (value > 0)
                {
                    _bar = value;
                }
            }



        }
    }
}

