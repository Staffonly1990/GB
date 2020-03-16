using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_3_1_a
{
    class Fraction
    {
        int numerator { get; set; }
        private int Denominator;
        int denominator
        {
            get
            {
                return Denominator;
            }
            set
            {
                Denominator = value;
            }

        }

        public Fraction(int numerator, int Denominator)
        {
            this.numerator = numerator;
            denominator = Denominator;
        }
        public void Write_Fraction()
        {
            if (denominator > 0)
            {
                Console.WriteLine(numerator + "/" + denominator);
            }
            else
            {

                Console.WriteLine(numerator + "/error");
            }
            Console.ReadKey();
        }
    }
}
