﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesExtension
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string str) => Console.WriteLine(str);
    }
}
