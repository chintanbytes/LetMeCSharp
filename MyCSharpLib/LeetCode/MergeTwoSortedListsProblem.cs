namespace MyCSharpLib.LeetCode
{
    public class ListNode
    {
        public int Val;
        public ListNode Next;

        public ListNode(int val)
        {
            Val = val;
            Next = null;
        }
    }

    public class MergeTwoSortedListsProblem
    {
        public ListNode MergeLists(ListNode list1, ListNode list2)
        {
            if(list1 == null && list2 == null)
                return null;
            if(list1 == null)
                return list2;
            if(list2 == null)
                return list1;

            var mergedList = list1;

            while (list1 != null && list2 != null)
            {
                if (list1.Val > list2.Val)
                {
                    //Move current element of list2 before current element of list1
                    var temp = list2.Next;
                    list2.Next = list1;
                    list1 = list2;
                    list2 = temp;
                    mergedList = list1;
                }
                else
                {
                    if (list1.Next == null || list1.Next.Val > list2.Val)
                    {
                        //Move current element of list2 between current element and next element of list 1
                        var temp = list2.Next;

                        list2.Next = list1.Next;
                        list1.Next = list2;
                        list1 = list2;

                        list2 = temp;
                    }
                    else
                    {
                        //Make next element of list1 it's current element
                        list1 = list1.Next;
                    }
                }
            }    

            return mergedList;
        }
        
    }
}