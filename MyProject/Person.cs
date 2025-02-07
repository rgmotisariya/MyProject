using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class Person
    {
        public string name { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is { name }");
        }
    }
}
