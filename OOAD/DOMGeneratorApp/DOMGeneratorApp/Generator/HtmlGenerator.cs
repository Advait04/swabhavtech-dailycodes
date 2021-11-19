using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMGeneratorApp.Generator
{
  public class HtmlGenerator
    {
        public void GenerateHtml(string htmlString, string fileName)
        {
            if (File.Exists(fileName)) File.Delete(fileName);
            File.WriteAllText(fileName, htmlString);
        }
    }
}
