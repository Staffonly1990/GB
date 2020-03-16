using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pop
{
    class Program
    {
        static void Main(string[] args)
        {
            string i = "потоп";
            Dictionary<char, int> list = new Dictionary<char, int>();
            foreach(char c in i)
            {
                if(!list.ContainsKey(c))
                {
                    list.Add(c, 1);
                }
                else
                {
                    list[c]++;
                }
            }
            string newS = "";
            foreach (char c in i)
            {
                if (list[c] > 1)
                {
                    newS = "<" + newS;
                }
                else
                {
                    newS = ">" + newS;
                }
            }
            Console.WriteLine(newS);
            Console.ReadKey();
        }
    }
}
