﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.EventImplementation
{
    public class NameChangeEventArgs : EventArgs
    {
        public NameChangeEventArgs(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }
    }
}
