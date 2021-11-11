using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPSolutionApp.Lib;

namespace OCPSolutionApp.Client
{
   public class EIDFestivalPolicy : IFestivalPolicy
    {
        public double CalculateRate()
        {
            return 0.10;
        }
    }
}
