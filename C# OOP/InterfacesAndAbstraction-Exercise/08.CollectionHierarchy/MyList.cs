using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CollectionHierarchy
{
    public class MyList : AddRemoveCollection
    {
        public ICollection<string> Used { get; set; }
        public MyList()
        {

            Used = new List<string>();

        }
        public override string Remove()
        {
            string removedItem = _collection[0];
            _collection.RemoveAt(0);
            Used.Add(removedItem);
            return removedItem;
        }

    }
}
