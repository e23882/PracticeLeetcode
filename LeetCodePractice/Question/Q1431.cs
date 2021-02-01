using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1431
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> finalResult = new List<bool>();
            int maximum = candies.Max();
            for(int i = 0; i < candies.Length; i++)
            {
                if (maximum < candies[i])
                    maximum = candies[i];
            }

            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies < maximum)
                    finalResult.Add(false);
                else
                    finalResult.Add(true);
            }

            return finalResult;
        }
    }
}
