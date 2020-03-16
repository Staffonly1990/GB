using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_3_1_a
{
    class Program
    {
        public static void three()
        {
            Console.WriteLine("введи числитель");
            int.TryParse(Console.ReadLine(),out int numerator);
            Console.WriteLine("введи знаменатель");
            int.TryParse(Console.ReadLine(), out int denominator);
            Fraction fraction = new Fraction(numerator, denominator);
            fraction.Write_Fraction();
        }
        static void funkt(bool p)
        {
            if(p == false)
            {
                Console.WriteLine("Вы ввели не корректные данные");
            }
        }
        static void two()
        {
            double sum_i = 0;
            bool p;
            double i;
            do
            {
                Console.WriteLine("введите 0");
                p = double.TryParse(Console.ReadLine(), out i);
                if(!(i%2==0) && i>0)
                {
                    sum_i = sum_i + i;
                }
                funkt(p);
            }
            while (!(i == 0) || p==false);
            Console.WriteLine("sum i = " + sum_i);
            Console.ReadKey();
        }
        static void one()
        {
            Console.WriteLine("Дописать структуру Complex, " +
                                "добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры\nСоздай первую точнку на карте:");
            Console.WriteLine("укажи x");
            double x_A = double.Parse(Console.ReadLine());
            Console.WriteLine("укажи y");
            double y_A = double.Parse(Console.ReadLine());
            Complex A = new Complex(x_A, y_A);
            Console.WriteLine("Создай вторую точнку на карте:");
            Console.WriteLine("укажи x");
            double x_B = double.Parse(Console.ReadLine());
            Console.WriteLine("укажи y");
            double y_B = double.Parse(Console.ReadLine());
            Complex B = new Complex(x_B, y_B);
            Console.WriteLine("А теперь вычислим расстояние между ними и выведем на экран");
            double i = Complex.lon_g(A, B);
            Console.WriteLine(i);
            Console.WriteLine("Можем просто их сложить и так же вывести на экран");
            Complex Q = Complex.sum(A, B);
            Q.Write();
        }
        
        static void Main(string[] args)
        {
            int namberb;
            bool ii;
            do
            {
                Console.WriteLine("Привет мой друг, куда пойдем?\n1\n2\n3");
                ii = int.TryParse(Console.ReadLine(), out namberb);
                switch (namberb)
                {
                    case 1:
                        one();
                        break;
                    case 2:
                        two();
                        break;
                    case 3:
                        three();
                        break;
                }
            }
            while (ii == false || namberb > 3 || namberb < 1);
        }
    }
}
