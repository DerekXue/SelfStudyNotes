using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://blog.csdn.net/java_3y/article/details/79641333
namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 2, 1, 4, 2, 5, 1, 5, 2, 3, 41, 23, 41,23,91992,241,1,4,14,41,4,124,241,124,124,142,124,24,124, 51, 24, 1, 41, 12442, 142 };
            int length = arr.Length;
            qsort(arr, 0, length-1);
            foreach(int e in arr)
            {
                Console.Write(e + " ");
            }
            Console.ReadKey();
        }


        public static void qsort(int[] arr ,int l,int r)
        {
            int i = l;
            int j = r;
            int p = arr[(l + r) / 2];

            while (i < j)
            {
                while (arr[i] < p) i++;
                while (arr[j] > p) j--;
                if (i <= j) //当i=j的时候进不去i++;j-- ，会造成无法break loop
                {
                    int t = arr[i];
                    arr[i] = arr[j];
                    arr[j] = t;
                    i++;
                    j--;
                }
            }

            if (l < j) qsort(arr, l, j);
            if (r > i) qsort(arr, i, r);

        }
    }
}
