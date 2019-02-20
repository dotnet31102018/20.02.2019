using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r2 = null;

            Console.WriteLine(r2.Igul);
            foo(new Rectangle());

        }

        static void foo(Shape s)
        {
            // 1
            Circle c = s as Circle;
            if (c != null)
            {

            }

            // 2
            if (s is Circle)
            {
                Circle c2 = s as Circle;
                Circle c4 = (Circle)s;
            }

            // 3 - casting
            Circle c3 = (Circle)s; // crash if s is not Circle
            
            Console.WriteLine();

        }
    }
}
