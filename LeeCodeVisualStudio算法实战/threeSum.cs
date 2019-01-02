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
            int[] para = { -4,-2,-2,-2,0,1,2,2,2,3,3,4,4,6,6};
            IList<List<int>> answ=threeSum(para);
            // -9,-3,1,2,4,5

        }

        public static IList<List<int>> threeSum(int[] para)
        {
            qsort(para, 0, para.Length - 1);
            IList<List<int>> answs = new List<List<int>>();
            for(int i = 0; para[i]<=0; i++)
            {
                int l = i + 1;
                int r = para.Length - 1;
                while (l < r)//需要让让双指针loop走完,不是找到一个适合条件就停止了
                {
                    if (para[i] + para[l] + para[r] == 0)
                    {
                        List<int> answ = new List<int> { para[i], para[l], para[r] };
                        if (!answs.Contains(answ))
                        {
                            answs.Add(answ);
                            l++;
                            r--;
                        }
                    }
                    else if(para[i] + para[l] + para[r] > 0)
                    {
                        r--;
                    }
                    else
                    {
                        l++;
                    }
                }
            }
            answs.Distinct();
            return answs;

        }

        public static void qsort(int[] para,int l,int r)
        {
            int i = l;
            int j = r;
            int p = para[(i + j) / 2];

            while (i < j)
            {
                while (para[i] < p) i++;
                while (para[j] > p) j--;
                if(i<=j)
                {
                    int t = para[i];
                    para[i] = para[j];
                    para[j] = t;
                    i++;
                    j--;
                }
            }
            if (l < j) qsort(para, l, j);
            if (i < r) qsort(para, i, r);
        }
    }
}
