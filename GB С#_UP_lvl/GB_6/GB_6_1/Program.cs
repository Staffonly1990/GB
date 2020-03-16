using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_6_1
{
    delegate double Result(double x, double y, out string o);
    class Program
    {
        static double SqX(double x, double y, out string o)
        {
            o = "= Функция a*x^2";
            return y * Math.Sqrt(x);
        }
        static double SinX(double x, double y, out string o)
        {
            o = "= Функция a*sin()x";
            return (y * Math.Sin(x));
        }
        static void Write(double x, double y, Result result)
        {
            Console.WriteLine($"{Math.Round(result(x, y,out string o),3)} {o}");
        }
        static void Main(string[] args)
        {
            double x = 3.5;
            double y = 56.234;

            Write(x, y, SqX);
            Write(x, y, SinX);

            Result result = new Result(SqX);
            Console.WriteLine(result(x, y, out string o));
            result = SinX;
            Console.WriteLine(result(x, y, out string p));

            Console.ReadKey();
        }
    }
}
