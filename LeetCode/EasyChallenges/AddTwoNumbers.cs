﻿namespace LeetCode.EasyChallenges
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    class AddTwoNumbers
    {
        public ListNode AddTwoNumbersMethod(ListNode l1, ListNode l2)
        {
            var result = new ListNode();
            ListNode head = result;

            int sum = 0;

            while (l1 != null || l2 != null || sum > 0)
            {
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                result.next = new ListNode(sum % 10);
                sum /= 10;
                result = result.next;
            }

            return head.next;
        }
    }
}
