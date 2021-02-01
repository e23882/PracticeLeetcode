using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1512
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int result = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i!=j)
                        result++;
                }
            }
            return result;
        }
    }
}
