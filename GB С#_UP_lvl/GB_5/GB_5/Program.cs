using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GB_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string i;
            bool ii;
            Regex reg = new Regex(@"\b\D{1}\S[a-zA-Z0-9]{0,9}\b");
            do
            {
                Console.WriteLine("придумайте логин к библиотеке");
                i = Console.ReadLine();
                ii = reg.IsMatch(i);
                Console.WriteLine(ii);
            }
            while (!ii);
            Console.WriteLine("логин = " + i);

            Console.ReadKey();
            string lit = @"C:\Users\Demin\source\repos\GB_5\GB_5\library\it.txt";
            Massage m = new Massage(lit, worc_Massage.not_5_letter);
            Console.WriteLine("\nnot_5_letter\n");
            m.Write();
            Massage mm = new Massage(lit, worc_Massage.last_not_A);
            Console.WriteLine("\nlast_not_A\n");
            mm.Write();
            Massage mmm = new Massage(lit, worc_Massage.long_word);
            Console.WriteLine("\nlong_word\n");
            mmm.Write();
            Massage mmmm = new Massage(lit, worc_Massage.StringBuilder);
            Console.WriteLine("\nStringBuilder\n");
            mmmm.Write();

            Console.ReadKey();
        }
    }
}
