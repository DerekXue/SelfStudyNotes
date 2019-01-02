using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://leetcode.com/problems/two-sum/
namespace ConsoleApp1
{
    class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (target == nums[i] + nums[j] && i != j)
                    {
                        int[] answer = new int[] { i, j };
                        return answer;
                    }
                }          
            }
            return null;
        }

        public static void TwoSumHash(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for(int i=0;i<nums.Length;i++)
            {
                dictionary.Add(nums[i],i);
            }
            for(int j=0;j<nums.Length;j++)
            {
                int compliment = target - nums[j];
                if (dictionary.ContainsValue(compliment))
                {
                    dictionary.TryGetValue(compliment, out int q);
                    int[] answer = new int[] { q, j };
                    for (int p = 0; p < answer.Length; p++)
                    {
                        Console.Write(answer[p]);
                        Console.Write(",");
                    }
                    Console.ReadLine();
                }
            }
                Console.Write("not found");
                Console.ReadLine();
                
            

        }

            static void Main(string[] args)
            {
                int[] para = { 3,2, 5, 1 };
                int[] ans=TwoSum(para, 8);
                foreach(int i in ans)
            {
                Console.Write(i);
            }
            Console.ReadKey();
            }
        }
    }
