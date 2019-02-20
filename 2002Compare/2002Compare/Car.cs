using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002Compare
{
    class Car : IComparable<Car>
    {

        public string Model { get; private set; }
        public int Year { get; private set; }
        public int HorsePower { get; private set; }

        public Car(string model, int year, int horsePower)
        {
            Model = model;
            Year = year;
            HorsePower = horsePower;
        }

        public override string ToString()
        {
            return $"Car Model : {Model,15}    Year : {Year,5}    Horse Power : {HorsePower,7}";
        }

        public int CompareTo(Car car)
        {
            // who is first ? this or obj?
            // if i come first then return 1+
            // if we are equal return 0
            // if obj comes first return 1-

            //Car car = obj as Car;
            /*
            if (this.Year > car.Year)
            {
                return 1;
            }
            if (this.Year == car.Year)
            {
                return 0;
            }
            return -1;
            */

            return this.Year - car.Year;
        }
    }
}
