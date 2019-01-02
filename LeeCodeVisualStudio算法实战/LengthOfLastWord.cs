using System;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            string para = "bbutshit";
            int answ=LengthOfLastWord(para);

                Console.WriteLine(answ);
            
            Console.ReadKey();
        }

        public static int LengthOfLastWord(string s)
        {
            string answ=s.Trim();
            string[] answs= answ.Split(' ');
            if (answs.Length == 0) return 0;
            else
            {
                return answs[answs.Length - 1].Length;
            }
        }

    }
}
