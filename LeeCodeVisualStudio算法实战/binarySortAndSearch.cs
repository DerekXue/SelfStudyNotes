using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 1, 5, 9, 7, 6 };
            binarySort(arr, 0, arr.Length-1);
            foreach (int e in arr)
            {
                Console.Write(e + " ");
            }

            int ans = binarySearch(arr, 9);
            Console.Write("\n"+ans);
            Console.ReadKey();
        }

        public static int binarySearch(int[] arr,int value)//不需要递归
        {
            int i = 0;
            int j = arr.Length - 1;
            while (i <= j) //需要取等不然数组中的最大值找不到
            {
                if (value == arr[(i + j) / 2]) return (i + j) / 2;
                else if (value > arr[(i + j) / 2]) i++;
                else if (value < arr[(i + j) / 2]) j--;
            }
            return -1;
        }


        public static void binarySort(int[] arr,int l,int r)
        {
            int i = l;
            int j = r;
            int p = (l + r) / 2;

            while (j > i)
            {
                while (arr[p] < arr[j]) j--;
                while (arr[p] > arr[i]) i++;
                if (j >= i)//需要取等不然进不了最后一次j--和i++
                {
                    int t = arr[j];
                    arr[j] = arr[i];
                    arr[i] = t;
                    j--;
                    i++;
                }
            }

            if (i < r) binarySort(arr, i, r);
            if (l < j) binarySort(arr, l, j);
        }
    }
}
