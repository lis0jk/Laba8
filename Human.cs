using System;
using System.Collections.Generic;
using System.Text;

namespace L8
{
    abstract class Human
    {
        public string Name { get; }
        public Human(string name)
        {
            Name = name;
        }
    }
}
