using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGE
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            string massage = @"Kids_list.txt";
            kids kid = new kids(massage);
            kid.Write_3();

            Console.ReadKey();
        }
    }
}
