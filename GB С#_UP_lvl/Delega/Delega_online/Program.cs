using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delega_online
{
    delegate bool isChar(char c);
    class Program
    {

        static int DelegaChar(string i, isChar isChar)
        {
            int count = 0;
            foreach (char c in i)
            {
                if (isChar(c))
                {
                    count++;
                }
            }
            return count;
        }
        static bool isRus(char c)
        {
            return c >= 'А' && c <= 'Я';
        }
        static bool isLat(char c)
        {
            return c >= 'A' && c <= 'Z';
        }
        static void Main(string[] args)
        {
            string i = "Класс словарей также, как и другие коллекции, предоставляет методы Add и Remove для добавления и удаления элементов. Только в случае словарей в метод Add передаются два параметра: ключ и значение. А метод Remove удаляет не по индексу, а по ключу.Так как в нашем примере ключами является объекты типа int, а значениями - объекты типа string, то словарь в нашем случае будет хранить объекты KeyValuePair<int, string>.В цикле foreach мы их можем получить и извлечь из них ключ и значение.Кроме того, мы можем получить отдельно коллекции ключей и значений словаря:";
            i.ToLower();
            Console.WriteLine(DelegaChar(i,isRus));
            DelegaChar(i, c => c == ',');
            Console.ReadKey();
        }
    }
}
