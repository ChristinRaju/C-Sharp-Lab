using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEncapsulation
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0 && value < 100)
                    age = value;
                else
                    Console.WriteLine("Invalid age. Age must be between 1 and 100.");
            }
        }
    }
}
// This code defines a Person class with properties for Name and Age.
