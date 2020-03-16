using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG_4
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int num = 0;
            int atar = 1;
            Random ran = new Random();
            int[] i = new int[20];
            foreach(int c in i)
            {
                i[num] = ran.Next(-10000, 10000);
                num++;
            }
            num = 0;
            foreach (int c in i)
            {
                Console.WriteLine(c);
            }
            foreach(int c in i)
            {
                if (atar== i.Length)
                {
                    break;
                }
                else if (c%3==0 || i[atar]%3==0)
                {
                    num++;
                }
                atar++;
            }
            Console.WriteLine("количество пар = " + num);
            Console.ReadKey();
        }
    }
}
