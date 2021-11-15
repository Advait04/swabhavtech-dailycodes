using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JukeBoxApp
{
    class JukeBox
    {
        private ArrayList _songs = new ArrayList();
        public void ReadSongsFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
                _songs.Add(line.Split('/')[0]);
        }
        public ArrayList Songs
        {
            get
            {
                return _songs;
            }
        }
    }
}
