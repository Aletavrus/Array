using System;

public class HelloWorld
{
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = Create(N);
            Print(arr);
            Console.WriteLine(Mid(arr)); //среднее в массиве
            /*int[] arr2 = Check(arr); //удаление значений больше 100 из массива
            */
            int[] correct = unique(arr);
            Print(correct);
        }

        public static int[] Create(int N)
        {
            int[] arr = new int[N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                arr[i] = random.Next(0, 10);
            }
            return arr;
        }

        public static void Print(int[] array)
        {
            for (int h = 0; h < array.Length; h++)
            {
                Console.Write($"{array[h]} ");
            }
            Console.WriteLine();
        }

        public static double Mid(int[] arr)
        {
            double av = 0;
            foreach (int number in arr)
            {
                av += number;
            }
            return av / arr.Length;
        }

        public static int[] Check(int[] arr)
        {
            int[] arr2 = arr;
            for (int x = 0; x < arr.Length; x++)
            {
                if (Math.Abs(arr[x]) > 100)
                {
                    arr2 = new int[x];
                    for (int y = 0; y < x; y++)
                    {
                        arr2[y] = arr[y];
                    }
                }
            }
            return arr2;
        }
        public static int[] unique(int[] arr)
        {
            int newArrLength = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {

                    if (arr[i] == arr[j] && i != j)
                    {
                        newArrLength--;
                        break;
                    }
                }
            }
            int counter = 0;
            int[] newArray = new int[newArrLength];
            for (int a = 0; a < arr.Length; a++)
            {
                if (!Contain(newArray, arr[a]))
                {
                    newArray[counter] = arr[a];
                    counter++;
                }
            }
            return newArray;
        }
        public static bool Contain(int[] k, int symb)
        {
            for (int g = 0; g < k.Length; g++)
            {
                if (symb == k[g])
                {
                    return true;
                }
            }
            return false;
        }
}