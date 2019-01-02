using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(9);
            l1.next = new ListNode(9);
            
            
            ListNode l2 = new ListNode(1);


            ListNode answ = AddTwoNumbers(l1, l2);
        }

        public class ListNode
        {
            public int val;
            public ListNode next; //is a reference variable so it's a pointer 
            public ListNode(int x) { val = x; }
        }

        public static ListNode AddTwoNumbers(ListNode l1,ListNode l2)
        {
            List<int> answ = new List<int> { };

            int carry = 0;
            while (l1 != null || l2 != null)
            {
                int result = 0;

                if (l1 == null)
                {
                    result = l2.val + carry;
                    carry = 0;
                    if (l2.next != null)
                    {
                        l2 = l2.next;
                    }
                    else
                    {
                        if (result > 9)
                        {
                            result = result % 10;
                            carry += 1;
                        }
                        answ.Add(result);
                        break;
                    }
                    
                }

                else if (l2 == null)
                {
                    result = l1.val + carry;
                    carry = 0;
                    if (l1.next != null)
                    {
                        l1 = l1.next;
                    }
                    else
                    {
                        if (result > 9)
                        {
                            result = result % 10;
                            carry += 1;
                        }
                        answ.Add(result);
                        break;
                    }
                }

                else
                {
                    int operand1 = l1.val;
                    int operand2 = l2.val;

                    if (carry > 0)
                    {
                        result = operand1 + operand2 + carry;
                        carry = 0;
                    }
                    else
                    {
                        result = operand1 + operand2;
                        if (result > 9)
                        {
                            result = result % 10;
                            carry += 1;
                        }
                    }
                    l1 = l1.next;
                    l2 = l2.next;
                }
                answ.Add(result);
            }
            if(carry>0)
            {
                answ.Add(carry);
            }

            ListNode head = new ListNode(answ[0]);
            ListNode current = head; //shallow copy

            for (int i=1;i<answ.Count;i++)
            {
                ListNode newNode = new ListNode(0);
                newNode.val = answ[i];
                current.next = newNode;
                current = newNode;
            }
            return head;
			//for how to copy array value to linkedlist:
			//https://www.codeproject.com/Articles/1104980/Linked-List-Implementation-in-Csharp
			

            //for more info on shallow vs deepcopy :
            //https://www.youtube.com/watch?v=IRIhavLN6ss
        }
    }
}
