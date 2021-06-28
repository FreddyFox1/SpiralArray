using System;

namespace SpiralArray
{
    class Program
    {
        public static int n = 6;
        public static int numb = 0;
        static void Main(string[] args)
        {
            int[,] arr = {
                { 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0 }
            };

            PrintArr(arr);
            Console.Write("\n\n");
            FillArr(arr);
            Console.Write("\n\n");
            PrintArr(arr);
            Console.ReadLine();
        }

        static void PrintArr(int[,] _arr)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(_arr[i, j] + "\t");
                }
                Console.Write("\n\n");
            }
        }

        static void FillArr(int[,] _arr)
        {
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < n - i; j++)
                    _arr[i, j] = numb++;

                for (int k = i + 1; k < n - i; k++)
                    _arr[k, n - 1 - i] = numb++;

                for (int j = n - i - 2; j >= i; j--)
                    _arr[n - 1 - i, j] = numb++;

                for (int k = n - 1 - i; k > i; k--)
                    _arr[k, i] = numb++;
            }
        }
    }
}
