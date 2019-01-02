using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l1 = new int[] { 2, 3, 112, 113, 114 }.ToList(); 
            List<int> l2 = new int[] {  21, 23, 32, 45, 67 }.ToList();
            mergeTwoSortedArray(l1, l2);
            
            foreach(int e in l1)
            {
                Console.Write(e+" ");
            }
            Console.ReadKey();

            //List<string> words = new string[] { "Hello", "world" }.ToList();


            //words.insert(0, "well");
            //foreach (string e in words)
            //{

            //    console.write(e);

            //}
            //console.readkey();
        }

        public static void mergeTwoSortedArray(List<int> l1, List<int> l2)
        {
            int l1length = l1.Count;
            int l2length = l2.Count;
            
            
            for(int i = 0; i < l2.Count; i++)
            {
                    for (int j = i; j < l1.Count-1;)
                    {
                        
                        if (l2[i] >= l1[j] && l2[i] <= l1[j + 1])
                        {
                            l1.Insert(j + 1, l2[i]);
                            l2.Remove(l2[i]);
                            break;
                        }
                        else
                        {
                            j++;
                        }
                    }
            }
            l1.AddRange(l2);

        }
    }
}
