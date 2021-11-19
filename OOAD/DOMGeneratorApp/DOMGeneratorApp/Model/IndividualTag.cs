using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMGeneratorApp.Model
{
    public class IndividualTag:ITag
    {
        private string _name;
        private string _type;
    
        public IndividualTag(string name, string type)
        {
            _type = type;
            _name = name;
        }
        public IndividualTag(string name) : this(name, " ") { }

        public string Render(string htmlString)
        {
              if (_name == "input") return htmlString + "<" + _name + " type=\"" + _type + "\">";
              return htmlString + "<" + _name + "/>";
        }
    }
}
