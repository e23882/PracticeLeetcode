using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1732
    {
        public int LargestAltitude(int[] gain)
        {
            int maxium = 0;
            int current = 0;
            for(int i = 0; i < gain.Length; i++)
            {
                current += gain[i];
                if (maxium < current)
                    maxium = current;
            }
            return maxium;
        }
    }
}
