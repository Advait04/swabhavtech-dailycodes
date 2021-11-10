using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuitarApp
{

    class Guitar
    {
        private string SerialNumber, builder, model, type, backWood, topWood;
        private double price;

        public Guitar(string SerialNumber, double price, string builder, string model, string type, string backWood, string topWood)
        {
            this.SerialNumber = SerialNumber;
            this.price = price;
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
        }
        public string GetSerialNumber()
        {
            return SerialNumber;
        }
        public double Getprice()
        {
            return price;
        }
        public string Getbuilder()
        {
            return builder;
        }
        public string Getmodel()
        {
            return model;
        }
        public string Gettype()
        {
            return type;
        }
        public string GetbackWood()
        {
            return backWood;
        }
        public string GettopWood()
        {
            return topWood;
        }

            
        { 
            guitars = new List<Guitar>(); 
        }

    public void addGuitar(string SerialNumber, double price, string builder, string model, string type, string backWood, string topWood)
    {
        Guitar guitar = new Guitar(SerialNumber, price, builder, model, type, backWood, topWood);
        guitars.Add(guitar);
    }
    public Guitar GetGuitar(string SerialNumber)
    {
        foreach (var guitar in guitars)
        //for(iterator i = guiters.iterator(); i.hasNext();) 
        {
            //Guitar guitar = (Guitar).next(); 

            if (guitar.GetSerialNumber().Equals(SerialNumber))
            {
                return guitar;
            }
        }
        return null;

    }
    public Guitar search(Guitar searchGuitar)
    {
        foreach (var guitar in guitars)
        //for (iterator i = guiters.iterator(); i.hasNext();) 
        {
            //Guitar guitar = (Guitar)i.next(); 

            string builder = searchGuitar.Getbuilder();
            if ((builder != null) && (!builder.Equals("")) && (!builder.Equals(guitar.Getbuilder())))
                continue;

            string model = searchGuitar.Getmodel();
            if ((model != null) && (!model.Equals("")) && (!model.Equals(guitar.Getmodel())))
                continue;

            string type = searchGuitar.Gettype();
            if ((type != null) && (!type.Equals("")) && (!type.Equals(guitar.Gettype())))
                continue;

            string backWood = searchGuitar.GetbackWood();
            if ((backWood != null) && (!backWood.Equals("")) && (!backWood.Equals(guitar.GetbackWood())))
                continue;

            string topWood = searchGuitar.GettopWood();
            if ((topWood != null) && (!topWood.Equals("")) && (!topWood.Equals(guitar.GettopWood())))
                continue;
        }
        return null;
    }
}
