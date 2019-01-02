using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 2, 3, 4, 5, 6, 7, 7 };
            int numToRemove = 2;

            int ans=removeElementCount(arr, numToRemove);
            Console.WriteLine(ans);

            int[] ansArr = removeElement(arr, numToRemove);
            foreach(int e in ansArr)
            {
                Console.Write(e + " ");
            }
            Console.ReadKey();
        }

        public static int removeElementCount(int[] arr ,int value)
        {
            List<int> arrList = arr.ToList();
            int counter=0;
            for(int i=0;i<arrList.Count;i++)
            {
                if (arrList[i] == value)
                {
                    counter++;
                }
            }
            return counter;
        }

        public static int[] removeElement(int[] arr,int value)
        {
            List<int> arrList = arr.ToList();
            for (int j = 0; j < arrList.Count; j++)
            {
                for (int i = 0; i < arrList.Count; i++)
                {
                    if (arrList[i] == value)
                    {
                        arrList.Remove(arrList[i]);
                    }
                }
            }
            return arrList.ToArray();
        }
    }
}
