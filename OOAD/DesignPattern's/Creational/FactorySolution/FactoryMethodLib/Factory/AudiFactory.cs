using FactoryMethodLib.Product;
using FactoryMethodLib.Profuct1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryMethodLib.Factory
{
    public class AudiFactory:IAutoFactory
    {
        private static AudiFactory _audiFactory;
        private AudiFactory()
        {
        }
        public IAuto Manufacture()
        {
            return new Audi();
        }

        public static AudiFactory GetInstance()
        {
            if (_audiFactory == null) _audiFactory = new AudiFactory();
            return _audiFactory;
        }

    }
}
