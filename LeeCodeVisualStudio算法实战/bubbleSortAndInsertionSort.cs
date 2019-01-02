using System;
using System.Collections.Generic;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 4, 5, 1, 2,100,142,44,33,22,34,35};
            insertionSort(arr);
            int[] answ = arr;
        }

        public static void bubbleSort(int[] arr)
        {
            for(int i = 0; i < arr.Length-1; i++)
            {
                int opR = arr.Length - 1;
                int opL = arr.Length - 2;
                while (opL >=i)
                {
                    if (arr[opL] > arr[opR])
                    {
                        int temp = arr[opL];
                        arr[opL] = arr[opR];
                        arr[opR] = temp;
                    }
                    opR = opL;
                    opL--;
                }
            }
        }
        
        public static void insertionSort(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Stack<int> indexes = new Stack<int>();
                int min = int.MaxValue;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        indexes.Push(j);
                    }
                }
                if (indexes.Count != 0)
                {
                    int index = indexes.Pop();
                    if (arr[i] > arr[index])
                    {
                        int temp = arr[i];
                        arr[i] = arr[index];
                        arr[index] = temp;
                    }
                }
            }
        }
    }
}
