using FactoryMethodLib.Product;
using FactoryMethodLib.Profuct1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib.Factory
{
    public class BmwFactory:IAutoFactory
    {
        private static BmwFactory _bmwFactory;
        private BmwFactory() { }
        public IAuto Manufacture()
        {
            return new Bmw();
        }
        public static IAutoFactory GetInstance()
        {
            if (_bmwFactory == null) _bmwFactory = new BmwFactory();
            return _bmwFactory;
        }

    }
}
