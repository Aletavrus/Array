using System;

namespace CW_8._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int col = int.Parse(Console.ReadLine());
            int line = int.Parse(Console.ReadLine());
            //int[,] default_array = CreateArr(col, line); Ввод через ENTER
            //int[,] array_string = CreateArrWithString(col, line); Ввод через строку
            int[,] arr = Matrix(col, line);
            PrintArr(arr);
        }

        public static int[,] CreateArr(int col, int line)
        {
            int[,] arr = new int[line, col];
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return arr;
        }
        public static int[,] CreateArrWithString(int col, int line)
        {
            int[,] arr = new int[line, col];
            for (int i = 0; i < line; i++)
            {
                string input = Console.ReadLine();
                string[] input_split = input.Split();
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = int.Parse(input_split[j]);
                }
            }
            return arr;
        }

        public static void PrintArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int y = 0; y < arr.GetLength(1); y++)
                {
                    Console.Write($"{arr[i, y]} ");
                }
                Console.WriteLine();
            }
        }
        public static int[,] Matrix(int line, int col)
        {
            int num = 1;
            int[,] matrica = new int[line, col];
            for (int i = 0; i < line; ++i)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < col; j++)
                    {
                        matrica[i, j] = num;
                        num++;
                    }
                }
                else
                {
                    for (int j = col - 1; j >= 0; j--)
                    {
                        matrica[i, j] = num;
                        num++;
                    }
                }
            }
            return matrica;
        }
    }
}
