using System;
using System.Collections.Generic;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            string digits = "23";
            IList<string> answer= letterCombinations(digits);
        }

        public static IList<string> letterCombinations(string digits)
        {
            IList<string> answs = new List<string>();
            if (digits == "") return answs;

            Dictionary<char, string> map = new Dictionary<char, string>()
            {
                {'2',"abc" },
                {'3',"def" },
                {'4',"ghi" },
                {'5',"jkl" },
                {'6',"mno" },
                {'7',"pqrs" },
                {'8',"tuv" },
                {'9',"wxyz" },
            };

            string answer = "";
            int index = 0;
            dfs(index, answer);

            //answs = bfs(index);

            return answs;

            IList<string> dfs(int currentIndex,string currentAnsw)
            {
                if(currentIndex==digits.Length)
                {
                     answs.Add(currentAnsw);
                     return answs;
                }
                foreach(char e in map[digits[currentIndex]])
                {
                        currentAnsw += e;
                        dfs(currentIndex + 1, currentAnsw);
                        currentAnsw= currentAnsw.Remove(currentAnsw.Length - 1);
                }
                return answs;
            }

            List<string> bfs(int currentIndex)
            {
                List<string> answers = new List<string>() { ""};

                while (currentIndex < digits.Length)
                {
                    List<string> currentAnswers = new List<string>();
                    foreach (char e in map[digits[currentIndex]])
                    {
                        foreach(string q in answers)
                        {
                            string newCurrent = q + e;
                            currentAnswers.Add(newCurrent);
                        }
                    }
                    answers = currentAnswers;
                    currentIndex++;
                }
                return answers;
              
            }
        }
    }
}
