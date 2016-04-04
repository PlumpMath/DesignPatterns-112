﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Cat : IPet
    {
        public string petSound()
        {
            return "Meow Meow";
        }
    }
}
