using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> answ=threeSum(nums);
            // -9,-3,1,2,4,5

        }

        public static IList<IList<int>> threeSum(int[] nums)
        {
            IList<IList<int>> answs = new List<IList<int>>();
            if (nums.Length < 3) return answs;
            if (nums.Length==3)
            {
                if (nums[0] + nums[1] + nums[2] == 0)
                {
                    answs.Add(nums);
                    return answs;
                }
                else
                {
                    return answs;
                }
            }

            qsort(nums, 0, nums.Length - 1);

            for(int i = 0; i<nums.Length-1; i++)
            {
                int l = i + 1;
                int r = nums.Length - 1;
                while (l < r)//需要让让双指针loop走完,不是找到一个适合条件就停止了
                {
                    if (nums[i] + nums[l] + nums[r] == 0)
                    {
                        List<int> answ = new List<int> { nums[i], nums[l], nums[r] };

                        answs.Add(answ);

                        bool repeat = false;

                        if (nums[l] == nums[l + 1] && nums[r] == nums[r - 1])
                        {
                            repeat = true;
                        }
                        //foreach (List<int> e in answs)
                        //{
                        //    int counter = 0;
                        //    for (int q = 0; q < e.Count() - 1; q++)
                        //    {
                        //        int p = q;
                        //        if (e.ElementAt(q) == answ.ElementAt(p))
                        //        {
                        //            counter++;
                        //        }
                        //    }
                        //    if (counter == 2)
                        //    {
                        //        repeat = true;
                        //        break;
                        //    }
                        //}

                        if (!repeat)
                        {
                            l++;
                            r--;
                        }
                        else
                        {
                            int q = 1;
                            int p = 1;
                            while (nums[l] == nums[l + q]&&l+q<nums.Length-1)
                            {
                                q++;
                            }
                            l = l + q;
                            while (nums[r] == nums[r - p]&&r-p > 0)
                            {
                                p++;
                            }
                            r = r - p;
                        }
                    }
                    else if (nums[i] + nums[l] + nums[r] > 0)
                    {
                        r--;
                    }
                    else
                    {
                        l++;
                    }
                    
                }
                if (nums[i] == nums[i + 1]) i++;
            }

            //List<int> check = new List<int>();
            //List<List<int>> final = new List<List<int>>();
            //foreach (List<int> e in answs)
            //{
            //    List<int> num = new List<int>();
            //    foreach(int n in e)
            //    {
            //        num.Add(n);
            //    }
            //    if (!final.Contains(num))
            //    {
            //        final.Add(num);
            //    }
            //}

            //int[][] arrays = answs.Select(a => a.ToArray()).ToArray();
            //arrays.Select(x => x.ToString()).Distinct();



            return answs;

        }

        public static void qsort(int[] nums,int l,int r)
        {
            int i = l;
            int j = r;
            int p = nums[(i + j) / 2];

            while (i < j)
            {
                while (nums[i] < p) i++;
                while (nums[j] > p) j--;
                if(i<=j)
                {
                    int t = nums[i];
                    nums[i] = nums[j];
                    nums[j] = t;
                    i++;
                    j--;
                }
            }
            if (l < j) qsort(nums, l, j);
            if (i < r) qsort(nums, i, r);
        }
    }
}
