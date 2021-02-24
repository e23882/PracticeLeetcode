using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1464
    {
        public int MaxProduct(int[] nums)
        {
            int Maxium1st = 0;
            int Maxium2nd = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > Maxium1st)
                {
                    Maxium1st = nums[i];
                }

            }
            var index = Array.FindIndex(nums, x => x == Maxium1st);
            nums[index] = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= Maxium1st && nums[i]> Maxium2nd)
                    Maxium2nd = nums[i];
            }
            return (Maxium1st - 1)*(Maxium2nd-1);
        }
    }
}
