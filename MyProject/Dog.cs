using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Dog
    {

        // Instance Variables
        String name;
        int age;
        String color;

        // Constructor 
        public Dog(String name,int age, String color)
        {
            this.name = name;
            this.age = age;
            this.color = color;
        }

        public String GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public String GetColor()
        {
            return color;
        }

        public override String ToString()
        {
            return "my name is: " + name + "\nmy age is: " + age;
        }
    }

}
