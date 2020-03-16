using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delega
{
    enum Wor
    {
        Russ,
        Latin
    }
    class Program
    {
        static int Count_all(string s, Wor wor)
        {
            char wor_fer =' ';
            char wor_last =' ';
            switch (wor)
            {
                case Wor.Russ:
                    wor_fer = 'а';
                    wor_last = 'я';
                    break;
                case Wor.Latin:
                    wor_fer = 'a';
                    wor_last = 'z';
                    break;
                default:
                    break;
            }

            int count = 0;
            foreach(char i in s)
            {
                if(i >=wor_fer && i <= wor_last)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            string i = "Класс словарей также, как и другие коллекции, предоставляет методы Add и Remove для добавления и удаления элементов. Только в случае словарей в метод Add передаются два параметра: ключ и значение. А метод Remove удаляет не по индексу, а по ключу.Так как в нашем примере ключами является объекты типа int, а значениями - объекты типа string, то словарь в нашем случае будет хранить объекты KeyValuePair<int, string>.В цикле foreach мы их можем получить и извлечь из них ключ и значение.Кроме того, мы можем получить отдельно коллекции ключей и значений словаря:";
            i.ToLower();
            Console.WriteLine(Count_all(i,Wor.Latin));
            Console.ReadKey();
        }
    }
}
