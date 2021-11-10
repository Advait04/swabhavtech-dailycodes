using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceConstructorApp2.Model
{
    class Child : Parent
    {
        public Child() : base(100)
        {

        }
        public Child(int num): base(num)
        {

        }
    }
}
