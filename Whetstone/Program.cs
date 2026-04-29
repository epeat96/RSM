using Whetstone.LeetCode.Problem2;

var solution = new Solution();

var l1 = new ListNode(9,
    new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
var l2 = new ListNode(9,
    new ListNode(9, new ListNode(9, new ListNode(9))));

solution.AddTwoNumbers(l1, l2);