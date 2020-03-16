using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_3_1_a
{
    class Complex
    {
        double x { get; set; }
        double y { get; set; }
        public Complex(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public static double lon_g(Complex A, Complex B)
        {
            return Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2));
        }
        public static Complex sum (Complex A, Complex B)
        {
            return new Complex(A.x + B.x, A.y + B.y);
        }
        public void Write()
        {
            Console.WriteLine("x = " + x + " y = " + y);
            Console.ReadKey();
        }

    }
}
