using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GB_4__
{
    class Account
    {

        string Login { get; set; }
        string Password { get; set; }
        string[,] m;
        public Account (string filename)
        {
            int long_sr = 0;
            string i;
            StreamReader sr = new StreamReader(filename);
            while (sr.ReadLine()!= null)
            {
                long_sr++;
            }
            string[,] m = new string[long_sr, 2];
            this.m = m;
            sr.BaseStream.Position = 0;
            long_sr = 0;
            int pas_ =0;
            while ((i = sr.ReadLine()) != null)
            {
                if(long_sr%2==0)
                {
                    this.Login = i;
                }
                else
                {
                    this.Password = i;
                    this.m[pas_, 0] = Login;
                    this.m[pas_, 1] = Password;
                    pas_++;
                }
                long_sr++;
            }
            sr.Close();
        }
        public void Write()
        {
            int o = 0;
            foreach (string c in m)
            {
                if (o %2 == 0)
                {
                    Console.Write(c + " ");
                }
                else
                {
                    Console.WriteLine(c);
                }
                o++;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account my = new Account(@"C:\Users\Demin\Desktop\GB\1.txt");
            my.Write();

            Console.ReadKey();
        }
    }
}
