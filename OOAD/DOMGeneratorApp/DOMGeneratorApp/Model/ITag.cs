using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMGeneratorApp.Model
{
    public interface ITag
    {
        string Render(string htmlString);
    }
}
