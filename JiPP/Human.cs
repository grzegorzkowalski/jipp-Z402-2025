﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiPP
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayHello()
        {
            Console.WriteLine($"{FirstName} {LastName} says hello.");
        }
    }
}
