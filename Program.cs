using System;

namespace BubbleSort
{
    class BubbleSort
    {

        static void BubbleSortInt(int[] array)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                    for (int i = 1; i < array.Length; i++)
                    {
                        if (array[i] < array[i - 1])
                        {
                            int cislo = array[i - 1];
                            array[i - 1] = array[i];
                            array[i] = cislo;
                        }
                    }
            }
          
            return;
        }

            static void Main(string[] args)
        {

            int length = 12;
            int seed = 1811;
            int max = 100;
            int[] array;

            Console.WriteLine("BubbleSort");
            array = GenerateIntArray(length, seed, max);
            PrintIntArray(array);
            BubbleSortInt(array);
            PrintIntArray(array);

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }
        static void PrintIntArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static int[] GenerateIntArray(int length, int seed, int max)
        {
            Random rng = new Random(seed);
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rng.Next(max);
            }
            return array;
        }
    }
}
