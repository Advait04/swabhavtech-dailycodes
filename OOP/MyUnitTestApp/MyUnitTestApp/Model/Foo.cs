using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyUnitTestApp.Model
{
  [MyUnitTest]
    class Foo
    {
        [MyUnitTestMethod ()]
        public bool F1()
        {
            return true;
        }
        public bool F2()
        {
            return true;
        }
        [MyUnitTestMethod()]
        public bool F3()
        {
            return true;
        }
    }
}
