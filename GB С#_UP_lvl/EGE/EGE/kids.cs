using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EGE
{
    class kids
    {
        string[,] kid { get; set; }
        public kids(string massage)
        {
            int one = 0;
            int two = 0;
            StreamReader str = new StreamReader(massage);
            string kids_list = str.ReadLine();
            string[,] i = new string[int.Parse(kids_list),5];
            kids_list = str.ReadToEnd();
            Regex regex = new Regex(@"\b\S+\b");
            Match match = regex.Match(kids_list);
            foreach(string c in i)
            {
                if (two%5==0 && two!=0)
                {
                    one++;
                    two = 0;
                }
                i[one, two] = Convert.ToString(match);
                match = match.NextMatch();
                two++;
            }
            this.kid = i;
            str.Close();
        }
        public void Write_3()
        {
            int q;
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (int nam = 0; nam < kid.Length/5;nam++)
            {
                q = 0;
                q = (int.Parse(kid[nam, 2]) + int.Parse(kid[nam, 3]) + int.Parse(kid[nam, 4]))/3;
                dic.Add($"{kid[nam, 0]} {kid[nam, 1]}",q);
            }
            dic = dic.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            //foreach (var elem in dic)
            //{
            //    Console.WriteLine($"{elem.Key} {elem.Value}");
            //}
            Console.WriteLine($"\n{dic.ElementAt(0).Key} {dic.ElementAt(0).Value}");
            Console.WriteLine($"{dic.ElementAt(1).Key} {dic.ElementAt(1).Value}");
            Console.WriteLine($"{dic.ElementAt(2).Key} {dic.ElementAt(2).Value}");

            for (int i = 3; i < dic.LongCount(); i++)
            {
                if (dic.ElementAt(i).Value == dic.ElementAt(0).Value || dic.ElementAt(i).Value == dic.ElementAt(1).Value || dic.ElementAt(i).Value == dic.ElementAt(2).Value)
                {
                    Console.WriteLine($"{dic.ElementAt(i).Key} {dic.ElementAt(i).Value}");
                }
            }
        }
    }
}
