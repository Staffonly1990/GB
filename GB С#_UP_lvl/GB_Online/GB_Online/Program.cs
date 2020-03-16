using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Online
{
    class Program
    {
        static double QWE (int weight, double h)
        {
            double I = weight / h * h;
            return I;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введи фамилию БРО");
            string Fname = Console.ReadLine();
            Console.WriteLine("Введи имя БРО");
            string name = Console.ReadLine();
            Console.WriteLine("Скольеко лет БРО?");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("На сколько высок БРО?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько весишь БРО?");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{name} {Fname} в свои {years}лет вырос на {height}см, поправился на {weight}кг");
            var i = QWE (weight, height * 100);
            Console.WriteLine($"а индекс массы {i}");
            Console.WriteLine("введи ккординаты точки x1");
            var x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введи ккординаты точки y1");
            var y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введи ккординаты точки 2");
            var x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введи ккординаты точки y2");
            var y2 = Convert.ToDouble(Console.ReadLine());
            var I2 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("ты не поверишь, но расстояние между ними = {0:F2}",I2);
            Console.WriteLine("введи цифру 1");
            var namber1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введи цифру 2");
            var namber2 = Convert.ToInt32(Console.ReadLine());
            namber1 = namber1 + namber2;
            namber2 = namber1 - namber2;
            namber1 = namber1 - namber2;
            Console.WriteLine($"ОПА цифра 1 = {namber1} цифра 2 = {namber2}!!!");
            

            Console.Read();
        }
    }
}
