using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyUnitTestApp.Model
{
    [AttributeUsage(AttributeTargets.All)]
    class MyUnitTestMethod:Attribute 
    {
        private string name { get; set; }
    }
}
