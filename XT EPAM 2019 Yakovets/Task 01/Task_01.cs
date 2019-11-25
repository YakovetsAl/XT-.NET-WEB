using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Task_01
    {
        
        static void Task_11()
        {
            int a, b = 0;

            do
            {
                Console.WriteLine("Task_11. Введите стороны прямоугольника для вычисления его площади:");

                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());

                    if (a > 0 && b > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Некорректный ввод!");
                        Console.WriteLine();
                    }
                }
                catch(Exception e) //На случай ввода строк\символов и нецелых чисел
                {
                    Console.WriteLine();
                    Console.WriteLine("Некорректный ввод!");
                    Console.WriteLine();
                }                
            }
            while(true);
            Console.WriteLine();

            Console.WriteLine("Площадь прямоугольника = " + (a * b));

            Console.WriteLine();

        } 

        static void Task_12_13()
        {
            int n = 0;

            do
            { 
                Console.WriteLine("Task_12_13. Введите число N:");

                try
                {
                    n = Convert.ToInt32(Console.ReadLine());

                    if (n > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Некорректный ввод!");
                        Console.WriteLine();
                    }
                }
                catch (Exception e) //На случай ввода строк\символов и нецелых чисел
                {
                    Console.WriteLine();
                    Console.WriteLine("Некорректный ввод!");
                    Console.WriteLine();
                }
            }
            while(true);
            Console.WriteLine();

            //Task_12
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine();

            //Task_13
            int m = n - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (n - (m - i) + i); j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < m - i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Task_14()
        {

            int n = 0;

            do
            {
                Console.WriteLine("Task_14. Введите число N:");

                try
                {
                    n = Convert.ToInt32(Console.ReadLine());

                    if (n > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Некорректный ввод!");
                        Console.WriteLine();
                    }
                }
                catch (Exception e) //На случай ввода строк\символов и нецелых чисел
                {
                    Console.WriteLine();
                    Console.WriteLine("Некорректный ввод!");
                    Console.WriteLine();
                }
            }
            while (true);
            Console.WriteLine();

            int N = n;
            int m = 0;
            for (int k = 0; k < N; k++)
            {
                n = k + 1;
                m = n - 1;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m - i + (N - (k + 1)); j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < (n - (m - i) + i); j++)
                    {
                        Console.Write("*");
                    }
                    for (int j = 0; j < m - i + (N - (k + 1)); j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        static void Task_15()
        {
            long sum = 0;
            for(int i = 3; i <= 1000; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine("Task_15. Ответ: " + sum);
            Console.WriteLine();
        }

        [Flags]
        enum Fond : byte
        {
            none = 0,
            bold = 1,
            italic = 2,
            underline = 3,
        }

        static void Task_16()
        {
            bool[] fond_array = new bool[4];
            bool flag;
            int input = -1;

            do
            {
                flag = false;
                Console.Write("Параметры надписи: ");
                for(int i = 0; i < fond_array.Length; i++)
                {
                    if (fond_array[i])
                    {
                        if(flag)
                        {
                            Console.Write(", ");
                        }
                        flag = true;
                        Console.Write((Fond)i);
                    }
                }
                if (!flag)
                {
                    Console.Write((Fond)0);
                }
                Console.WriteLine();

                Console.WriteLine("Введите:\n\t1: bold\n\t2: italic\n\t3: underline\n\t4: чтобы выйти");
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());

                    if (!(input >= 1 && input <= 4))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Некорректный ввод!");
                        Console.WriteLine();
                        continue;
                    }

                    if(input == 4)
                    {
                        break;
                    }

                    if(fond_array[input])
                    {
                        fond_array[input] = false;
                    }
                    else
                    {
                        fond_array[input] = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine("Некорректный ввод!");
                    Console.WriteLine();
                }
            }
            while (true);
        }

        public static void IntroSort(ref List<int> data)
        {
            int partitionSize = Partition(ref data, 0, data.Count - 1);

            if (partitionSize < 16)
            {
                InsertionSort(ref data);
            }
            else if (partitionSize > (2 * Math.Log(data.Count)))
            {
                HeapSort(ref data);
            }
            else
            {
                QuickSortRecursive(ref data, 0, data.Count - 1);
            }
        }

        private static void InsertionSort(ref List<int> data)
        {
            for (int i = 1; i < data.Count; ++i)
            {
                int j = i;

                while ((j > 0))
                {
                    if (data[j - 1] > data[j])
                    {
                        data[j - 1] ^= data[j];
                        data[j] ^= data[j - 1];
                        data[j - 1] ^= data[j];

                        --j;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private static void HeapSort(ref List<int> data)
        {
            int heapSize = data.Count;

            for (int p = (heapSize - 1) / 2; p >= 0; --p)
                MaxHeapify(ref data, heapSize, p);

            for (int i = data.Count - 1; i > 0; --i)
            {
                int temp = data[i];
                data[i] = data[0];
                data[0] = temp;

                --heapSize;
                MaxHeapify(ref data, heapSize, 0);
            }
        }

        private static void MaxHeapify(ref List<int> data, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < heapSize && data[left] > data[index])
                largest = left;
            else
                largest = index;

            if (right < heapSize && data[right] > data[largest])
                largest = right;

            if (largest != index)
            {
                int temp = data[index];
                data[index] = data[largest];
                data[largest] = temp;

                MaxHeapify(ref data, heapSize, largest);
            }
        }

        private static void QuickSortRecursive(ref List<int> data, int left, int right)
        {
            if (left < right)
            {
                int q = Partition(ref data, left, right);
                QuickSortRecursive(ref data, left, q - 1);
                QuickSortRecursive(ref data, q + 1, right);
            }
        }

        private static int Partition(ref List<int> data, int left, int right)
        {
            int pivot = data[right];
            int temp;
            int i = left;

            for (int j = left; j < right; ++j)
            {
                if (data[j] <= pivot)
                {
                    temp = data[j];
                    data[j] = data[i];
                    data[i] = temp;
                    i++;
                }
            }

            data[right] = data[i];
            data[i] = pivot;

            return i;
        }

        static void Task_17()
        {
            var rand = new Random();
            int n = 8;
            List<int> array = new List<int>(n);
            for(int i = 0; i < n; i++)
            {
                array.Add(rand.Next(1001));
            }
            Console.WriteLine("Сгенерированный массив:");

            for(int i = 0; i < array.Count - 1; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            
            IntroSort(ref array);

            Console.WriteLine("Min array: " + array[0]);
            Console.WriteLine("Max array: " + array[array.Count - 1]);
            Console.WriteLine("Отсортированный массив:");

            for (int i = 0; i < array.Count - 1; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void Task_18()
        {
            var rand = new Random();
            int[][][] array = new int[3][][];
            
            for(int i = 0; i < 3; i++)
            {
                array[i] = new int[3][];
            }

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    array[i][j] = new int[3];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for(int k = 0; k < 3; k++)
                    {
                        array[i][j][k] = rand.Next(-21, 21);
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if(array[i][j][k] > 0 )
                        {
                            array[i][j][k] = 0;
                        }
                    }
                }
            }

            Console.WriteLine("Задание Task_18 выполнено");

        }

        static void Task_19()
        {
            var rand = new Random();
            int[] array = new int[10];
            int Sum = 0;

            for(int i = 0; i < 10; i++)
            {
                array[i] = rand.Next(-21, 21);
                if(array[i] > 0)
                {
                    Sum += array[i];
                }
            }

            Console.WriteLine("Task_19. Сгенерированный массив:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Sum: " + Sum);
        }

        static void Task_110()
        {
            var rand = new Random();
            int[][] array = new int[10][];
            int Sum = 0;

            for (int i = 0; i < 10; i++)
            {
                array[i] = new int[5];
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i][j] = rand.Next(50);
                    if(((i + 1) + (j + 1)) % 2 == 0)
                    {
                        Sum += array[i][j];
                    }
                }
            }
            Console.WriteLine("Task_110. Sum:" + Sum);
        }

        static void  Task_111()
        {
            Console.WriteLine("Task_111. Введитее строку");
            string str = Console.ReadLine();

            int count_word = 0;
            int leng_word;
            int avg = 0;

            for(int i = 0; i < str.Length; i++)
            {
                leng_word = 0;
                while(i < (str.Length - 1) && Char.IsLetter(str[i]))
                {
                    leng_word++;
                    i++;
                }
                if(leng_word > 0)
                {
                    avg += leng_word;
                    count_word++;
                }
            }

            if (count_word > 0)
            {
                avg /= count_word;
            }
            else avg = 0;

            Console.WriteLine("Средняя длина слов в строке: " + avg);

        }

        static void Task_112()
        {
            Console.WriteLine("Task_112");
            Console.Write("Введитее первую строку: ");
            string str1 = Console.ReadLine().ToLower();
            Console.Write("Введитее вторую строку: ");
            string str2 = Console.ReadLine().ToLower();

            for (int i = 0; i < str2.Length; i++)
            {
                int LastIndex = str2.LastIndexOf(str2[i]);
                while (LastIndex != i)
                {
                    str2 = str2.Remove(LastIndex, 1);
                    LastIndex = str2.LastIndexOf(str2[i]);
                }
            }

            for(int i = 0; i < str2.Length; i++)
            {
                if (str1.Contains(str2[i]))
                {
                    for (int j = 0; j < str1.Length; j++)
                    {
                        if(str1[j] == str2[i])
                        {
                            str1 = str1.Insert(++j, str2.Substring(i, 1));
                        }
                    }
                }
            }

            Console.WriteLine("Результирующая строка: " + str1);
        }

        static void Main(string[] args)
        {
            Task_11();

            Task_12_13();

            Task_14();

            Task_15();

            Task_16();

            Task_17();

            Task_18();

            Task_19();

            Task_110();

            Task_111();

            Task_112();
        }
    }
}
