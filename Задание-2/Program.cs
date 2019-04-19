using System;

namespace Задание_2
{
    class Program
    {
        private static int Search(int[] arr, int toFound)               //метод бинарного поиска, работает для отсортированного массива
        {
            int left = 0;
            int right = arr.Length;
            int mid;                                                    //индыксы по краям массива и по середине
            while (!(left >= right))
            {
                mid = (left + right) / 2;                               //индекс среднего элемента
                if (arr[mid] == toFound)
                    return mid;
                if (arr[mid] > toFound)                                 //сдвигаем поиск "в лево" от середины массива
                    right = mid;
                else
                    left = mid + 1;                                     // сдвигаем поиск "в право" от середины отбрасывая индекс mid и все что до него
            }
            return mid = -1;                                              //если честно, не знаю как кинуть тут исключение! поэтому -1 (индекс не может быть -1 и менее)
        }

        static void Main(string[] args)
        {
            int[] arr = new int[10] { 55, 56, 57, 58, 59, 60, 61, 62, 63, 64 };
            //{[0],[1],[2],[3],[4],[5],[6],[7],[8],[9] };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] ", arr[i]);
            }
            Console.WriteLine();
            Console.Write("Введите значение для поиска его индекса: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (Search(arr, N) == -1)
            {
                Console.WriteLine("Такого значения нет в данном массиве. Индекс не найден!");
            }
            else Console.WriteLine("Значение находится по индексу: [{0}]", Search(arr, N));

            int s = Array.BinarySearch(arr, N);                        // готовый метод для работы с массивами
            Console.WriteLine("Значение находится по индексу: [{0}] (c использованием готового метода)", s);
            Console.ReadKey();
        }
    }
}
