using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002HW
{
    class Flash : Human, IFlash
    {
        public Flash(string name, int age, double voltage) : base(name, age)
        {
            this.Voltage = voltage;
        }

        public override string Name {
            get;
            set;
        }

        public void ActivateSuperPowers()
        {
            FireLightning();
        }

        public void FireLightning()
        {
            Console.WriteLine($"Flash {Name} is fire lightning");
        }

        public double Voltage { get; private set; }

        public override string ToString()
        {
            return $"Flash {Voltage} " + base.ToString();
        }
    }
}
