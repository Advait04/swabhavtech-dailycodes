using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorApp.Model
{
   public  class Remote
    {
        private DogDoor _door;
        public Remote(DogDoor door)
        {
            this._door = door;
        }
        public void PressButton()
        {
            if(_door.OpenStatus())
            {
                _door.Close();
            }
            else
            {
                _door.Open();
            }
        }
    }
}
