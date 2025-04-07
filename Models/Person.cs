using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_foundation.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void PersonPresent()
        {
            Console.WriteLine($"Hi! My name is {Name} and I'm {Age} age.");
        }
    }
}