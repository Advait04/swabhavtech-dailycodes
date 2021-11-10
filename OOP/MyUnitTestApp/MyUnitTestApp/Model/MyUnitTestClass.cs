using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyUnitTestApp.Model
{
    [AttributeUsage(AttributeTargets.All)]
    class MyUnitTest:Attribute 
    {
        private string name { get; set; }
    }
}
