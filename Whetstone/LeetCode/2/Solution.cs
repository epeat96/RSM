namespace Whetstone.LeetCode.Problem2;

 public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
 }

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var currentNode1 = l1;
        var currentNode2 = l2;
        var carriage = 0;
        var result = new ListNode();
        var currentResult = result;
        
        while (true)
        {
            var value1 = currentNode1?.val ?? 0;
            var value2 = currentNode2?.val ?? 0;
            var sum = value1 + value2 + carriage;
            
            carriage = 0;
            
            currentResult.val = sum % 10;     
            
            if (sum > 9)
            {
                carriage++;
            }
            
            currentNode1 = currentNode1?.next ?? null;
            currentNode2 = currentNode2?.next ?? null;

            if (currentNode1 == null && currentNode2 == null && carriage == 0)
            {
                break;
            }
            
            currentResult.next = new ListNode();
            currentResult = currentResult.next;
            
            
        }
        
        return result;
    }
}
