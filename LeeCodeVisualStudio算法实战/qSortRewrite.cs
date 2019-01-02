using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://blog.csdn.net/java_3y/article/details/79641333
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 1, 5, 23, 1, 3, 2, 4, 231, 15 };
            qsort(arr, 0, 10);
            foreach(int e in arr)
            {
                Console.Write(e + " ");
            }
            Console.ReadKey();
        }

        public static void qsort(int[] arr,int l,int r) //理解起来相对困难，使用草稿和phase,i,j值的表来模拟迭代
        {
            int i = l;
            int j = r;
            int p = arr[l];

            while(i<=j)
            {
                while (arr[i] < p) 
                i++;
                while (arr[j] > p) 
                j--;
                if(i<=j)
                {
                    int t = arr[i];
                    arr[i] = arr[j];
                    arr[j] = t;
                    i++;
                    j--;
                }
            }
            
            if(l<j) qsort(arr, l, j);
            if(i<r)qsort(arr, i, r);
        }
    
    }
}
