using System;
using System.Collections.Generic;

namespace ConsoleApp43
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //    int[] arr1 = { };
        //    int[] arr2 = { 2, 4, 5,7,8,9 };
        //    int[] answ=mergeTwoSortedArr(arr1, arr2);
        //}

        public static int[] mergeTwoSortedArr(int[] arr1, int[] arr2)
        {
            List<int> arr3 = new List<int>();
            int arr1P = 0;
            int arr2P = 0;
            while (arr1P < arr1.Length && arr2P < arr2.Length)
            {
                if (arr1[arr1P] < arr2[arr2P])
                {
                    arr3.Add(arr1[arr1P]);
                    arr1P++;
                }
                else if(arr1[arr1P] > arr2[arr2P])
                {
                    arr3.Add(arr2[arr2P]);
                    arr2P++;
                }
                else
                {
                    arr3.Add(arr1[arr1P]);
                    arr3.Add(arr2[arr2P]);
                    arr1P++;
                    arr2P++;
                }
            }
            if (arr1P == arr1.Length)
            {
                List<int> newList = new List<int>();
                for(int i = arr2P; i < arr2.Length; i++)
                {
                    newList.Add(arr2[i]);
                }
                arr3.AddRange(newList);
            }
            else
            {
                List<int> newList = new List<int>();
                for (int i = arr1P; i < arr1.Length; i++)
                {
                    newList.Add(arr1[i]);
                }
                arr3.AddRange(newList);
            }
            return arr3.ToArray();
        }
    }
}
