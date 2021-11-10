using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrudableApp.Model
{
    public interface ICrudable
    {
        void CreateAFile();
        


       void ReadFromFile();


         void UpdateToFile();


         void DeleteFromFile();
 

}
}

