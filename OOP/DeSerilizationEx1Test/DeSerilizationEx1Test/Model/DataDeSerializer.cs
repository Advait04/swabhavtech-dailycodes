using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DeSerilizationEx1Test.Model
{
    class DataDeSerializer
    {
        public Object BinaryDeserialize(string filePath)
        {
            object obj = null;
          

            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if(File.Exists(filePath))
            {
                fileStream = File.OpenRead(filePath);
                obj = bf.Deserialize(fileStream);
                fileStream.Close();
            }
            return obj;

        }
    }
}
