using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1365
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] result = new int[nums.Length];

            for(int i = 0; i < nums.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j] && i!=j)
                        counter++;
                }
                result[i] = counter;
            }

            return result;
        }
    }
}
