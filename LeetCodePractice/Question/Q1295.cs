using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1295
    {
        public int FindNumbers(int[] nums)
        {
            int result = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i].ToString().Length % 2 == 0)
                    result++;
            }
            return result;
        }
    }
}
