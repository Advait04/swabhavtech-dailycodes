using DIPSolutionApp.CommonModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolutionApp.LowLevelSolution
{
   public  class DBLogger:ILogger
    {
        public void Log(string msg)
        {
          Console.WriteLine("Logging Into DB", msg);
        }
    }
}
