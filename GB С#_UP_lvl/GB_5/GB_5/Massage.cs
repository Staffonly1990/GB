using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace GB_5
{
    enum worc_Massage
    {
        not_5_letter,
        last_not_A,
        long_word,
        StringBuilder,
        Normal

    }
    class Massage
    {
        
        string massage { get; set; }
        public Massage(string massage,worc_Massage worc_Massage)
        {
            switch (worc_Massage)
            {
                case worc_Massage.not_5_letter:
                    this.massage = not_5_letter(massage);
                    break;
                case worc_Massage.last_not_A:
                    this.massage = last_not_A(massage);
                    break;
                case worc_Massage.long_word:
                    this.massage = long_word(massage);
                    break;
                case worc_Massage.StringBuilder:
                    this.massage = StringBuilder(massage);
                    break;
                case worc_Massage.Normal:
                    this.massage = massage;
                    break;
                default:
                    break;
            }
        }
        static string not_5_letter(string massage)
        {
            string m=null;
            StreamReader str = new StreamReader(massage);
            string it = str.ReadToEnd();
            Regex r = new Regex(@"\b\S{1,5}\b");
            Match match = r.Match(it);
            while(match.Success)
            {
                m = m + (Convert.ToString(match)+" ");
                match = match.NextMatch();
            }
            str.Close();
            return m;
        }
        static string last_not_A(string massage)
        {
            string m = null;
            StreamReader str = new StreamReader(massage);
            string it = str.ReadToEnd();
            Regex r = new Regex(@"\b\S+[^aA]\b");
            Match match = r.Match(it);
            while (match.Success)
            {
                m = m + Convert.ToString(match);
                match = match.NextMatch();
            }
            str.Close();
            return m;
        }
        static string long_word(string massage)
        {
            string ma = "";
            StreamReader str = new StreamReader(massage);
            string it = str.ReadToEnd();
            Regex r = new Regex(@"\b\S+\b");
            Match match = r.Match(it);
            while (match.Success)
            {
                if(ma.Length < match.Length)
                {
                    ma = match.ToString();
                }
                match = match.NextMatch();
            }
            str.Close();
            return ma;
        }
        static string StringBuilder(string massage)
        {
            int i = 0;
            StreamReader str = new StreamReader(massage);
            StringBuilder mB = new StringBuilder();
            string _m = str.ReadToEnd();
            Regex r = new Regex(@"\b\S+\b");
            Match match = r.Match(_m);
            while (match.Success)
            {
                if (i < match.Length)
                {
                    mB.Clear();
                    mB.Append(match.ToString());
                    i = match.Length;
                }
                else if(i == match.Length)
                {
                    mB.Append(" "+match.ToString());
                }
                match = match.NextMatch();
            }
            str.Close();
            return Convert.ToString(mB);
        }
        public void Write()
        {
            Console.WriteLine(massage);
        }
    }
}
