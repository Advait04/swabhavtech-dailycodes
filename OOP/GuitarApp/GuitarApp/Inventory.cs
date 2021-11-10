using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuitarApp
{
    class Inventory
    {
        private List<Guitar> guitars;

        public void addGuitar(string SerialNumber, double price, string builder, string model, string type, string backWood, string topWood)
        {
            Guitar guitar = new Guitar(SerialNumber, price, builder, model, type, backWood, topWood);
            guitars.Add(guitar);
        }
        public Guitar GetGuitar(string SerialNumber)
        {
            foreach (var guitar in guitars)
            {
                if (guitar.GetSerialNumber().Equals(SerialNumber))
                {
                    return guitar;
                }
            }
            return null;
        }
        public Guitar search(Guitar searchGuitar)
        {
            foreach(var guitar in guitars)
            {
                string builder = saerchGuitar.Getbuilder();
                if((builder != null )&& (!builder.Equals(""))&&(!builder.Equals(guitar.Getbuilder())))
                    continue;

                string model = saerchGuitar.GetModel();
            }
        }
}
}
