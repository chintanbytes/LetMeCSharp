using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLib.LeetCode;

public class FindMedianSortedArraysLc
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var arr = new int[nums1.Length + nums2.Length];

        var i = 0;
        var j = 0;
        var k = 0;
        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] <= nums2[j])
            {
                arr[k++] = nums1[i++];
            }
            else
            {
                arr[k++] = nums2[j++];
            }
        }


        while (i < nums1.Length)
        {
            arr[k++] = nums1[i++];
        }

        while (j < nums2.Length)
        {

            arr[k++] = nums2[j++];
        }

        return arr.Length % 2 == 0 ? ((1.0) * (arr[arr.Length / 2] + arr[arr.Length / 2 - 1]) / 2) : arr[arr.Length / 2];
    }

    public double FindMedianSortedArraysBetter(int[] nums1, int[] nums2)
    {
        var i = 0;
        var j = 0;

        int GetMin()
        {
            if (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] <= nums2[j])
                {
                    return nums1[i++];
                }

                return nums2[j++];
            }

            if (i < nums1.Length)
            {
                return nums1[i++];
            }

            if (j < nums2.Length)
            {
                return nums2[j++];
            }

            return -1;
        }

        var m = nums1.Length;
        var n = nums2.Length;

        if ((m + n) % 2 == 0)
        {
            for (var k = 0; k < (m + n) / 2 - 1; k++)
            {
                GetMin();
            }

            return (double)(GetMin() + GetMin()) / 2;
        }
        else
        {
            for (var k = 0; k < (m + n) / 2; k++)
            {
                GetMin();
            }

            return GetMin();
        }

        return GetMin();
    }

    public double FindMedianSortedArraysBS(int[] nums1, int[] nums2)
    {
        var l1 = nums1.Length;  
        var l2 = nums2.Length;
        
        //Size of full array
        var n = l1 + l2;
        //size of half array
        var half = n / 2;

        if(l2 < l1)
        {
            (nums1, nums2) = (nums2, nums1);
            (l1,l2) = (l2,l1);
        }

        //Start and end indexes for both the array
        var left = 0;
        var right = l1-1;
        
        while (true)
        {
            var m1 = left > right ? -1:  left + (right - left) / 2;
            var m2 = half - m1 - 2;

            var left1Val = m1 < 0 ? int.MinValue : nums1[m1];
            var right1Val = m1+1 >= l1 ? int.MaxValue : nums1[m1+1];

            var left2Val = m2 < 0 ? int.MinValue : nums2[m2];
            var right2Val = m2 + 1 >= l2 ? int.MaxValue : nums2[m2 + 1];

            if (left1Val <= right2Val && left2Val <= right1Val)
            {
                if (n % 2 == 0)
                {
                    return (double)(Math.Max(left1Val, left2Val) + Math.Min(right1Val, right2Val)) / 2;
                }

                return Math.Min(right1Val, right2Val);
            }

            if (left1Val > right2Val)
            {
                right = m1-1;
            }
            else
            {
                left = m1+1;
            }
        }
    }
}

