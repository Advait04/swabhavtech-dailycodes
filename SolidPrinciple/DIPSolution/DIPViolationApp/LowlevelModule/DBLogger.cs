using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp.LowlevelModule
{
    public class DBLogger
    {
        public void WriteLine(string msg)
        {
            Console.WriteLine("Logging to DAtaBAse\nMessage: {0}", msg);
        }
    }
}
