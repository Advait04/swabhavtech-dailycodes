using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorApp.Model
{
    public class DogDoor
    {
        private bool _openStatus;

        public DogDoor()
        {
            this._openStatus = false;
        }
        public void Open()
        {
            _openStatus = true;
        }
        public void Close()
        {
            _openStatus = false;
        }
        public bool OpenStatus()
        { 
                return _openStatus;
            }

        }
    }

