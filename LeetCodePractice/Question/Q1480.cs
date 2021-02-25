using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1480
    {
        public int[] RunningSum(int[] nums)
        {
            int[] result = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++)
            {
                int tempResult = 0;
                for(int j=0;j<= i; j++)
                {
                    tempResult += nums[j];
                }
                if (i == 0)
                    result[i] = nums[0];
                else
                    result[i] = tempResult;
            }
            return result;
        }
    }
}
