using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_00
{
    class Task_00
    {

        static void Task_01(long n)
        {

            Console.Write("N=" + n + ": ");
            for (int i = 1; i <= n; i++)
            {
                if (i != n)
                    Console.Write(i + ", ");
                else
                    Console.WriteLine(i);

            }
        }

        static bool Task_02(long x)
        {
            if (x == 2)
                return true;

            var rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                long a = (rand.Next() % (x - 2)) + 2;

                if (gcd(a, x) != 1)
                    return false;

                if (pows(a, x - 1, x) != 1)
                    return false;
            }
            return true;
        }

        static long gcd(long a, long b)
        {
            if (b == 0)
                return a;
            return gcd(b, a % b);
        }

        static long mul(long a, long b, long m)
        {
            if (b == 1)
                return a;
            if (b % 2 == 0)
            {
                long t = mul(a, b / 2, m);
                return (2 * t) % m;
            }
            return (mul(a, b - 1, m) + a) % m;
        }

        static long pows(long a, long b, long m)
        {
            if (b == 0)
                return 1;
            if (b % 2 == 0)
            {
                long t = pows(a, b / 2, m);
                return mul(t, t, m) % m;
            }
            return (mul(pows(a, b - 1, m), a, m)) % m;
        }

        static void Task_03(long n)
        {
            for (long i = 0; i < n; i++)
            {
                for (long j = 0; j < n; j++)
                {
                    if ((i + 1 == ((n / 2) + 1)) && (j + 1 == ((n / 2) + 1)))
                        Console.Write(' ');
                    else Console.Write('*');
                }
                Console.Write('\n');
            }
        }

        static void Task_04(List<List<int>> arr)
        {
            Console.WriteLine("Вывод исходного массива:");
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Count; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.Write('\n');
            }
            Console.Write('\n');

            sortArr(arr);
        }

        static void sortArr(List<List<int>> arr)
        {
            List<int> tmpArr = new List<int>();

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Count; j++)
                {
                    tmpArr.Add(arr[i][j]);
                }
            }

            tmpArr.Sort();

            Console.WriteLine("Вывод отсортированного массива:");
            int tmpArrIter = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Count; j++)
                {
                    Console.Write(tmpArr[tmpArrIter] + " ");
                    tmpArrIter++;
                }
                Console.Write('\n');
            }
            Console.Write('\n');

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Task 01:\nВведите положительное число N:");
            long n = Convert.ToInt64(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Task 01:\nВведите положительное число N:");
                n = Convert.ToInt64(Console.ReadLine());
            }
            Task_01(n);
            Console.Write('\n');

            Console.WriteLine("Task 02:\nВведите положительное число N:");
            n = Convert.ToInt64(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Task 02:\nВведите положительное число N:");
                n = Convert.ToInt64(Console.ReadLine());
            }
            Console.WriteLine(Task_02(n));
            Console.Write('\n');

            Console.WriteLine("Task 03:\nВведите положительное нечетное число N:");
            n = Convert.ToInt64(Console.ReadLine());
            while ((n <= 0) || (n % 2 != 1))
            {
                Console.WriteLine("Task 03:\nВведите положительное нечетное число N:");
                n = Convert.ToInt64(Console.ReadLine());
            }
            Task_03(n);
            Console.Write('\n');

            Console.WriteLine("Task 04:\nВведите положительное число N:");
            int len_array = Convert.ToInt32(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Task 04:\nВведите положительное число N:");
                len_array = Convert.ToInt32(Console.ReadLine());
            }

            List<List<int>> array = new List<List<int>>();

            var rand = new Random();

            for (int i = 0; i < len_array; i++)
            {
                int tmp = Convert.ToInt32(Console.ReadLine());
                array.Add(new List<int>());
                for (int j = 0; j < tmp; j++)
                {
                    array[i].Add(rand.Next(101));
                }
            }
            Console.Write('\n');

            Task_04(array);
        }
    }
}
