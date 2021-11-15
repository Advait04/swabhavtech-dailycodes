using DIPSolutionApp.CommonModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolutionApp.LowLevelSolution
{
  
        public class FileLogger : ILogger
        {
            public void Log(string msg)
            {
                Console.WriteLine("Logging Into File\nMessage: {0}", msg);
            }
        }
}
