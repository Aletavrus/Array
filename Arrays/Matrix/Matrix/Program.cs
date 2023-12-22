using System;

namespace CW_8._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[][] arr_of_arr = CreateArrayofArrays(size);
            int[][] changed_arr = Even_Num(arr_of_arr); // пункт 2
            PrintBigArr(arr_of_arr); // вывод
        }
        public static int[][] CreateArrayofArrays(int size)
        {
            int[][] arr_of_arr = new int[size][];
            for (int i = 0; i < size; ++i)
            {
                string input = Console.ReadLine();
                string[] input_list = input.Split();
                arr_of_arr[i] = new int[input_list.Length];
                for (int y = 0; y < input_list.Length; y++)
                {
                    arr_of_arr[i][y] = int.Parse(input_list[y]);
                }
            }
            return arr_of_arr;
        }
        public static void PrintBigArr(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int y = 0; y < arr[i].Length; y++)
                {
                    Console.Write($"{arr[i][y]} ");
                }
                Console.WriteLine();
            }
        }
        public static int[][] Even_Num(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int y = 0; y < arr[i].Length; y++)
                {
                    if (arr[i][y] % 2 == 0)
                    {
                        arr[i][y] = i * y;
                    }
                }
            }
            return arr;
        }
    }
}
