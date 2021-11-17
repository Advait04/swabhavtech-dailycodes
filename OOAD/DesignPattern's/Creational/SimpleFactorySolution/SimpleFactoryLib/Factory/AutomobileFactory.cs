using SimpleFactoryLib.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLib.Factory
{
    public class AutomobileFactory
    {
        public static AutomobileFactory _automobileFactory;
        private AutomobileFactory() { }
        public IAuto Manufacture(Autotype auto)
        {
            if (auto == Autotype.TESLA) return new TESLA();
            else if (auto == Autotype.BMW) return new BMW();
            return new AUDI();

        }
        public static AutomobileFactory GetInstance()
        {
            if (_automobileFactory == null) _automobileFactory = new AutomobileFactory();
            return _automobileFactory;
        }
    }
}
