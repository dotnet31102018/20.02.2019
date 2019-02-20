using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002HW
{
    abstract class Human
    {
        abstract public string Name { get; set; }

        private int age;

        public int Age {
            get
            {
                return this.age;
            }
        }

        public Human(string name, int age)
        {
            this.Name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"Human Name : {Name} Age : {Age}";
        }
    }
}
