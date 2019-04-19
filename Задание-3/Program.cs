using System;

namespace Задание_3
{
    class Program
    {
        private static void OneWord(string str)
        {
            string[] arr = str.Split(' ', ',', '.', '!', '?', ';', ':', '"');       //"отрезаем" от слов знаки препинания, пробелы и тд
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                string slovo = arr[i];
                foreach (string word in arr)                                        //каждое слово прогоняем по массиву в поисках копий
                {
                    if (word == slovo)
                        count++;
                }
                if (count == 1)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            string str = "Ехал Грека через реку, видит Грека — в реке рак. Сунул Грека руку в реку, рак за руку Грека — цап!";
            OneWord(str);
            Console.ReadKey();
        }
    }

}
