using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002Compare
{
    /// <summary>
    /// Here we store another comparison logic
    /// </summary>
    class CarHPComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.HorsePower - y.HorsePower;
        }
    }
}
