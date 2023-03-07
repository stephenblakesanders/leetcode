public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class AddTwoNumbersSol {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        // interate through l1 and l2
        // while l1 != null || l2 != null
        // if l1||l2.val == null => set to 0
        // add l1 && l2 to current
        // move to next node if not exists

        ListNode ans = new ListNode();
        var pointer = ans;
        int current = 0;

        while (l1 != null|| l2 != null)
        {
            current = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + current;
            pointer.next = new ListNode(current % 10);
            pointer = pointer.next;

            current = current / 10;

            l1 = l1?.next;
            l2 = l2?.next;
        }

        if (current != 0)
        {
            pointer.next = new ListNode(current);
        }

        return ans.next;
    }

    static void Main(string[] args)
    {
        AddTwoNumbersSol i = new AddTwoNumbersSol();

        ListNode l1 = new ListNode(2);
        var pointer = l1;

        l1.next = new ListNode(4);
        pointer = l1.next;
        pointer.next = new ListNode(3);

        ListNode l2 = new ListNode(5);
        l2.next = new ListNode(6);
        pointer = l2.next;
        pointer.next = new ListNode(4);
        
        var test = i.AddTwoNumbers(l1, l2);

        pointer = test;
        while (test != null)
        {
            Console.WriteLine(test.val);
            test = test?.next;
        }
    }
}

