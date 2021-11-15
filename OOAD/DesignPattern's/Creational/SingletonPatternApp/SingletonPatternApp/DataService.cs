using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternApp
{
   public class DataService
    {
       private static DataService bucket;
        private  DataService()
        {
            
            Console.WriteLine("DataService Created");
        }

        public void DoSomething()
        {
            Console.WriteLine("Work Done By" + this.GetHashCode());
        }

       public static DataService GetInstance()
        {
            if (bucket == null)
                bucket = new DataService();
            return bucket;
        }

    }
}
