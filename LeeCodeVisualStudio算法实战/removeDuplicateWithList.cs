using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] para = { 1, 1, 2,2, 3,4,4,5,6,7,8,9 ,10,10,11,11,12};
            int[] answ=removeDuplicate(para);
            foreach (int i in answ)
            {
                Console.Write(i+" ");
            }
            int count = answ.Length;
            Console.Write("\n" + count);
            Console.ReadKey();
        }

        private static int[] removeDuplicate(int[] arr)
        {
            List<int> newArray=new List<int>();
            newArray.Add(arr[0]);
            
            for(int i=0;i<arr.Length-1;i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    continue;
                }
                else
                {
                    newArray.Add(arr[i + 1]);    
                }
            }
            int[] answer=newArray.ToArray();
            return answer;
        }
    }
}
