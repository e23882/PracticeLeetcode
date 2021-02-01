using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1342
    {
        public int NumberOfSteps(int num)
        {
            int result = 0;
            while (num>0)
            {
                result++;
                if (num % 2 == 0)
                    num = num / 2;
                else
                    num--;
            }
            return result;
        }
    }
}
