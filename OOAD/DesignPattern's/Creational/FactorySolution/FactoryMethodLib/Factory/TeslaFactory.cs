using FactoryMethodLib.Product;
using FactoryMethodLib.Profuct1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib.Factory
{
    public class TeslaFactory:IAutoFactory
    {
        private TeslaFactory()
        {
        }
        private static TeslaFactory _teslaFactory;
        public IAuto Manufacture()
        {
            return new Tesla();
        }
        public static IAutoFactory GetInstance()
        {
            if (_teslaFactory == null) _teslaFactory = new TeslaFactory();
            return _teslaFactory;
        }
    }
}

