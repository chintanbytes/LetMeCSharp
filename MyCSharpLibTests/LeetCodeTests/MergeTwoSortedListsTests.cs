using MyCSharpLib.LeetCode;

namespace MyCSharpLibTests.LeetCodeTests
{
    [TestClass]
    public class MergeTwoSortedListsTests
    {
        [TestMethod]
        public void MergeTwoSortedListTest1()
        {
            ListNode list1 = new(1);
            list1.Next = new(3);
            list1.Next.Next = new(4);

            ListNode list2 = new(1);
            list2.Next = new(2);
            list2.Next.Next = new(4);

            var solution = new MergeTwoSortedListsProblem();
            solution.MergeLists(list1,list2);

            int[] array = { 1, 1, 2, 3, 4, 4 };
            var i = 0;
            while (list1 != null)
            {
                Assert.AreEqual(list1.Val, array[i]);
                i++;
                list1 = list1.Next;
            }

        }

        [TestMethod]
        public void MergeTwoSortedListTest2()
        {
            ListNode list1 = new(2);
            list1.Next = new(3);
            list1.Next.Next = new(4);

            ListNode list2 = new(1);
            list2.Next = new(5);
            list2.Next.Next = new(6);

            var solution = new MergeTwoSortedListsProblem();
            var merged = solution.MergeLists(list1, list2);

            int[] array = {1, 2, 3, 4, 5, 6};
            var i = 0;
            while (merged != null)
            {
                Assert.AreEqual(merged.Val, array[i]);
                i++;
                merged = merged.Next;
            }
        }

        [TestMethod]
        public void MergeTwoSortedListTest3()
        {
            var solution = new MergeTwoSortedListsProblem();
            var merged = solution.MergeLists(null, null);

            Assert.IsNull(merged);
        }

        [TestMethod]
        public void MergeTwoSortedListTest4()
        {
            ListNode list1 = new(2);
            ListNode list2 = new(1);

            var solution = new MergeTwoSortedListsProblem();
            var merged = solution.MergeLists(list1, list2);

            int[] array = {1, 2};
            var i = 0;
            while (merged != null)
            {
                Assert.AreEqual(merged.Val, array[i]);
                i++;
                merged = merged.Next;
            }
        }
    }
}
