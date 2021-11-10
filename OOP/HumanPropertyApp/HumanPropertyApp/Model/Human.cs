using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanPropertyApp.Model
{
    class Human
    {
        private string _name;
        private float _heigth, _weight;
        private GenderType _gender;



        public Human(string name, float height, float weight, GenderType gender)
        {
            this._name = name;
            this._heigth = height;
            this._weight = weight;
            this._gender = gender;
        }

        public void Eat()
        {
            _weight += _weight * 20 / 100;


        }

        public void Workout()
        {
            _weight -= _weight * 10 / 100;

            _heigth += _heigth * 5 / 100;



        }

        public GenderType Gender
        {
            get
            {
                return _gender;

            }
        }

        public float Weight

        {
            get
            {
                return _weight;
            }
        }

        public float Heigth
        {
            get
            {
                return _heigth;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }


    }
}
