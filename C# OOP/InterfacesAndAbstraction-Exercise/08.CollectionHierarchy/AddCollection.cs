using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CollectionHierarchy
{
    public class AddCollection : IAddElements
    {
        protected List<string> _collection;

        public AddCollection()
        {
            _collection = new List<string>();
        }

        public virtual int Add(string input)
        {
            _collection.Add(input);
            return _collection.Count - 1;
        }
    }
}

