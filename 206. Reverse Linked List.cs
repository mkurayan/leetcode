public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public class SolutionRecursive
{
    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        if (head.next != null)
        {
            ListNode last = ReverseList(head.next);

            ListNode next = head.next;
            head.next = null;
            next.next = head;

            return last;
        }

        return head;
    }
}

public class SolutionIterative
{
    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        ListNode prev = null;
        ListNode current = head;
        ListNode next = null;

        while (current != null)
        {
            next = current.next;
            current.next = prev;

            prev = current;
            current = next;
        }

        return prev;
    }
}