using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_4_
{

    public class mass
    {
        string name;
        int[] mass_1;
        public mass()
        {
            Console.WriteLine("напишите длинну массива");
            int long_mass = mass.booler();
            Console.WriteLine("напишите длинну шага");
            int step = mass.booler();
            Console.WriteLine("напишите длинну начальное значение");
            int startValue = mass.booler();
            Console.WriteLine("назовите массив");
            string name = Console.ReadLine();

            int nam = 0;
            mass_1 = new int[long_mass];
            foreach (int c in mass_1)
            {
                mass_1[nam] = startValue + (step * nam);
                nam++;
            }
            this.name = name;
        }
        public void Sum_45 ()
        {
            int[] mass_0 = new int[mass_1.Length];
            int i = 0;
            foreach (int c in mass_1)
            {
                mass_0[i] = mass_1[i] + 45;
                i++;
            }
            Write(mass_0);
        }
        public int Sum()
        {
            Console.WriteLine(name);
            int i = 0;
            foreach (int c in mass_1)
            {
                i = i + c;
            }
            return i;
        }
        public void Write ()
            {
            Console.WriteLine(name);
                  foreach (int c in mass_1)
                {
                     
                     Console.Write(c + " ");
                }
                     Console.WriteLine("\n");
        }
        public void Write(int [] i)
        {
            Console.WriteLine(name);
            foreach (int c in i)
            {

                Console.Write(c + " ");
            }
            Console.WriteLine("\n");
        }
        public static int booler()
        {
            int znach;
            bool pares;
            do
            {
                pares = int.TryParse(Console.ReadLine(), out znach);
            }
            while (!pares);
            return znach;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
                mass un = new mass();
                mass pun = new mass();

            un.Write();
            pun.Write();
            Console.WriteLine("sum " + un.Sum()+"\n");
            Console.WriteLine("sum " + pun.Sum()+"\n");
            un.Sum_45();
            pun.Sum_45();
            un.Write();
            pun.Write();


            Console.ReadKey();
        }
    }
}
