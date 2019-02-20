using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Car honda = new Car("Honda", 2036, 110);
            Car suzuki = new Car("Suzuki", 2016, 90);
            Car mitsubishi = new Car("Mitsubishi", 2030, 150);

            Car[] cars = { honda, suzuki, mitsubishi };

            PrintCars(cars);

            Console.WriteLine("Compare by year:");
            Array.Sort(cars);
            PrintCars(cars);

            Console.WriteLine("Compare by Horse power:");
            Array.Sort(cars, new CarHPComparer());
            PrintCars(cars);

        }

        static void PrintCars(Car[] cars)
        {
            foreach (Car c in cars)
            {
                Console.WriteLine(c);
            }
        }
    }
}
