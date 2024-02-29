﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        private List<T> list;

        public Box() 
        {
            list = new List<T>();
        }
        public void Add(T item) 
        {
            list.Add(item);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in list) 
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
