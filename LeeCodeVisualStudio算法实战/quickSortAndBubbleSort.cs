using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://blog.csdn.net/java_3y/article/details/79641333
namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 5, 67, 2, 7, 8, 6, 9, 44};

            var watch = System.Diagnostics.Stopwatch.StartNew();

            bubbleSort(arr);
            //quickSort(arr, 0, 9);

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            Console.Write(elapsedMs);
            Console.ReadKey();
        }

        public static void quickSort(int[] arr, int L, int R)
        {
            int i = L;
            int j = R;

            //支点
            int pivot = arr[R];

            //左右两端进行扫描，只要两端还没有交替，就一直扫描
            while (i <= j)
            {

                //寻找直到比支点大的数
                while (pivot > arr[i])
                    i++;

                //寻找直到比支点小的数
                while (pivot < arr[j])
                    j--;

                //此时已经分别找到了比支点小的数(右边)、比支点大的数(左边)，它们进行交换
                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }
            //上面一个while保证了第一趟排序支点的左边比支点小，支点的右边比支点大了。


            //“左边”再做排序，直到左边剩下一个数(递归出口)
            if (L < j)
                quickSort(arr, L, j);

            //“右边”再做排序，直到右边剩下一个数(递归出口)
            if (i < R)
                quickSort(arr, i, R);
        }

        public static void bubbleSort(int[] arr)
        {
            for (int i= 0; i < arr.Length; i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]>arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

            }
        }


    }
}
