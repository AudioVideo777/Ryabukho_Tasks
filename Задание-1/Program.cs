using System;

namespace Задание_1
{
    class Program
    {
        private static void SortInsert(int[] arr)                   //сортировка вставками
        {
            int i, j, check;
            for (i = 0; i < arr.Length; i++)                        //цикл проходов, i - номер прохода
            {
                check = arr[i];
                for (j = i - 1; j >= 0 && arr[j] > check; j--)      //поиск места элемента в готовой последовательности 
                {
                    arr[j + 1] = arr[j];                            //сдвигаем элемент направо, пока не дошли
                }
                arr[j + 1] = check;                                 //место найдено, вставить элемент    
            }
        }
        private static void SortSelect(int[] arr)                   //cортировка выбором
        {
            int i, j, pos, check;
            for (i = 0; i < arr.Length; i++)                        //номер текущего шага в массиве
            {
                pos = i;
                check = arr[i];
                for (j = i + 1; j < arr.Length; j++)                //цикл выбора наименьшего элемента
                {
                    if (arr[j] < check)
                    {
                        pos = j;
                        check = arr[j];
                    }
                }
                arr[pos] = arr[i];
                arr[i] = check;                                     //меняем местами наименьший и ставим его в конец массива
            }
        }
        private static void SortBubble(int[] arr)                   //сортировка пузырьком
        {
            for (int i = 0; i < arr.Length; i++)                    //номер текущего шага в массиве
            {
                for (int j = 0; j < arr.Length - 1; j++)              //цикл поочередного перебора и сравнения значений в соседних индексах, какое значение больше - переходит на индекс выше
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int x = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = x;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[25];
            Random r = new Random();
            Console.Write("Исходный сгенерированный массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 200);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($" " + arr[i]);
            }
            Console.WriteLine();
            //SortInsert(arr);
            SortBubble(arr);                                          // один из не используемых методов можно закоменьтить для проверки
            //SortSelect(arr);
            //Array.Sort(arr);                                        //-если использовать готовый метод сортировки по возрастанию
            Console.Write("Массив после сортировки: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($" " + arr[i]);
            }
            Console.ReadKey();
        }
    }

}
