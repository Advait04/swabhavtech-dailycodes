using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspViolationApp
{
    class Robot:IWorker
    {
        public void StartEat()
        {
            throw new Exception("Robot Can't eat");
        }

        public void StartWork()
        {
            Console.WriteLine("Robot Started Working");
        }

        public void StopEat()
        {
            throw new Exception("Robot Can't Eat");
        }

        public void StopWork()
        {
            Console.WriteLine("Robot stopped working");
        }
    }
}
