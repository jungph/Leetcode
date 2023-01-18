using Utils;
using Models;

namespace Solutions
{
    public class AddTwoNumbers : ISolution
    {
        public AddTwoNumbers()
        {
            Console.WriteLine("Init " + this.GetType().Name);
        }

        public ListNode AddTwoNumbersImpl(ListNode l1, ListNode l2) {

            var ans = new ListNode();
            var ansPtr = ans;
            var carry = 0;
            
            while (l1 != null || l2 != null || carry != 0)
            {
                var sum = (((l1 != null) ? l1.val : 0) + ((l2 != null) ? l2.val : 0) + carry) % 10;
                carry = (((l1 != null) ? l1.val : 0) + ((l2 != null) ? l2.val : 0) + carry) / 10;

                l1 = l1 == null ? l1 : l1.next;
                l2 = l2 == null ? l2 : l2.next;
                
                ansPtr.next = new ListNode(sum);
                ansPtr = ansPtr.next;
            }

            return ans.next;
        }

        public void run()
        {
            // test case
            var L1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var L2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            var ans = AddTwoNumbersImpl(L1, L2);
            OutputUtils.Print(ans);
        }

    }

}