using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternFolderApp
{
    public class Folder:IStorageItem
    {
        private string _name;
        private List<IStorageItem> _children = new List<IStorageItem>();

        public Folder(string name)
        {
            _name = name;
        }
        public void AddItem(IStorageItem item)
        {
            _children.Add(item);
        }

         public void Display()
        {
            Console.WriteLine("Name:" + _name);
            foreach (var items in _children) items.Display();
        }
    }
}
