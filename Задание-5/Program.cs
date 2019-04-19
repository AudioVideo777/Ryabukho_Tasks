using System;
using System.Collections.Generic;
using System.Linq;

namespace Задание_5
{
    class Program
    {
        public static bool IsSame(char a, char b)                                       //сравнение скобок, открывающуюся, которую, берем из стека и символ закрывающей скобки 
        {
            return a == '(' && b == ')' || a == '[' && b == ']' || a == '{' && b == '}';
        }

        public static bool Check(string arr)
        {
            Stack<Char> stack = new Stack<Char>();                                      //создаем стэк
            bool Correct;                                                               //проверочное возращаемое значение true/false
            int open = 0;                                                               //подсчет открытых/закрытых скобок
            int close = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '{' || arr[i] == '(' || arr[i] == '[')                    //проверка на симол открытой скобки и засовываем в стэк
                {
                    stack.Push(arr[i]);
                    open++;
                }
                else if (stack.Count() == 0)                                            //проверка на заполненость стека, для того случая если в строке встретится дополнительная закрывающая скобка
                {
                    Correct = false;                                                    //возвращаем false
                    return Correct;
                }
                else if (arr[i] == '}' || arr[i] == ')' || arr[i] == ']')               //проверка на закрытую скобку, достаем из стека открытую скобку (которую положили ранее)
                {                                                                       // сравниваем скобки методом IsSame. Проходят дополнительную проверку так символы открывающей 
                    close++;                                                            // и закрывающей скобки должен быть одинаков, пример ( и )  [ и ]  { и }
                    if (!IsSame(stack.Pop(), arr[i]))
                    {
                        Correct = false;
                        return Correct;
                    }
                }
                else if (i >= arr.Length - 1)                                             //проверка на соседнии элементы в конце массива, к примеру без нее не работает такой ввод "()()"
                {
                    if (open != close)                                                  //сравниваем счетчики на равность открытых и закрытых скобок
                    {
                        Correct = false;
                        return Correct;
                    }
                }
            }
            Correct = true;                                                             //возвращаем true, если все тесты пройдены
            return Correct;
        }

        public static void Main(string[] args)
        {
            Console.Write("Введите скобочную последовательность: ");
            string arr = Console.ReadLine();
            bool c = Check(arr);
            if (c == true)
            {
                Console.WriteLine("Это правильная скобочная последовательность!");
            }
            else Console.WriteLine("Не правильная последовательность!!!");
            Console.ReadKey();
        }

    }

}
