using System;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {

            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);

            ListNode answ=removeNthFromEnd(head, 2);
        }

        public static ListNode removeNthFromEnd(ListNode head,int n)
        {
            if (head.next == null) return null;

            int counter = 1;

            ListNode current1 = new ListNode(0);
            current1 = head;

            while (current1.next != null)
            {
                current1 = current1.next;
                counter++;
            }

            int i = 1;
            
            ListNode current2 = head;

            if (n == 1)
            {
                while (i != counter - 1)
                {
                    current2 = current2.next;
                    i++;
                }
                current2.next = null;
            }
            else if (n == counter)
            {
                head = head.next;
            }
            else
            {
                while (i != counter - n)
                {
                    current2 = current2.next;
                    i++;
                }
                ListNode newRightJoin = current2.next.next;
                current2.next = newRightJoin;
            }

            return head;
        }

        public class ListNode
        {
            public int value;
            internal ListNode next;
            public ListNode(int x)
            {
                value = x;
            }
        }
    }
}
