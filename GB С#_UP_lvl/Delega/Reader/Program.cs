using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader read = new StreamReader("Kids_list.txt");
            StreamWriter wr = new StreamWriter("Kids.txt");
            while(!read.EndOfStream)
            {
                string i = read.ReadLine().Replace(' ',';');
                string[] o = i.Split(';');
                Console.WriteLine($"{o[0]} {o[1]} {o[2]} {o[3]} {o[4]}");
                wr.WriteLine($"{i}");
            }
            read.Close();
            wr.Close();
        }
    }
}
