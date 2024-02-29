﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> list;
        private int index = 0;

        public ListyIterator(List<T> list)
        {
            this.list = list;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }

        public bool HasNext()
        {
            return index < list.Count - 1;
        }
        public bool Move()
        {
            if (HasNext())
            {
                index++;
                return true;
            }
            return false;
        }
        public void Print()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException();
            }
            Console.WriteLine(list[index]);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
