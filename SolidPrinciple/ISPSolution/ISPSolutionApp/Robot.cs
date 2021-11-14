using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolutionApp
{
    class Robot:IWorkable
    {
        public void StartWork()
        {
            Console.WriteLine("Robot Started Working");
        }

        public void StopWork()
        {
            Console.WriteLine("Robot Stopped Working");
        }

    }
}
