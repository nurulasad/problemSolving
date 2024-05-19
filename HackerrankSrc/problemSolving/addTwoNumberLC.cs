using System;
using System.Collections.Generic;
using System.Linq;

public class AddTwoNumberLC
{

    //https://leetcode.com/problems/add-two-numbers/
    //accepted


    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var head = default(ListNode);
        var current = default(ListNode);


        int[] res = new int[] { 0, 0 };
        bool first = true;
        while (true)
        {
            if (l1 == null && l2 == null)
                return head;


            res = SumANode(l1, l2, res[0]);

            var temp = new ListNode();
            temp.val = res[1];

            if (first)
            {
                head = temp;
                current = temp;
                first = false;
            }
            else
            {
                current.next = temp;
                current = current.next;
            }

            if (l1 != null)
                l1 = l1.next;
            if (l2 != null)
                l2 = l2.next;

            if (l1 == null && l2 == null)
            {
                //no more next, place the quotient

                if (res[0] != 0)
                {
                    temp = new ListNode();
                    temp.val = res[0];

                    current.next = temp;
                    current = current.next;
                }


            }
        }

    }

    public int ToNumber(ListNode listNode)
    {
        //it is a reversed order number as per the problem statement , LSB at beginning , e.g number 807 will be 708
        string s = "";
        while (listNode != null)
        {
            s += listNode.val;
            listNode = listNode.next;
        }
        return int.Parse(s);
    }


    private int[] SumANode(ListNode l1, ListNode l2, int quotient)
    {
        int d1 = 0;
        int d2 = 0;

        if (l1 != null)
            d1 = l1.val;
        if (l2 != null)
            d2 = l2.val;

        int sum = d1 + d2 + quotient;

        quotient = sum / 10;
        var reminder = sum % 10;

        return new int[] { quotient, reminder };
    }
}
