using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1748
    {
        public int SumOfUnique(int[] nums)
        {
            int result = 0;
            List<int> temp = new List<int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums.Count(x => x == nums[i]) == 1)
                    temp.Add(nums[i]);
            }
            for(int i = 0; i < temp.Count; i++)
                result += temp[i];
            return result;
        }
    }
}
