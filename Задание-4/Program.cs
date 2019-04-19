using System;

namespace Задание_4
{
    class Program
    {
        private static int Fact(int N)                                                                      //метод подсчета факториала
        {
            if (N < 2)
                return 1;
            return N * Fact(N - 1);
        }
        private static int Factor(int N)                                                                    //еще один, но "наоборот")
        {
            int count = 1;
            for (int i = 2; i <= N; i++)
            {
                count *= i;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число N : ");
            bool res = int.TryParse(Console.ReadLine(), out int N);                                         //проверка на ввод кракозябр в консоль
            if (res && N >= 0)                                                                              //проверка на ввод положительного числа, 
            {                                                                                               //тк Факториал определён только для целых неотрицательных чисел
                Console.WriteLine("Факториал числа N равен: {0}", Fact(N));                                 //основной метод
                Console.WriteLine("Факториал числа N равен: {0}", Factor(N));                               //доп метод

            }
            else Console.WriteLine("Задайте правильный числовой формат: целое положительное число или 0 !!!");
            Console.ReadKey();
        }
    }

}
