using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1281
    {
        public int SubtractProductAndSum(int n)
        {
            int crossResult = 1;
            int plusResult = 0;
            for(int i = 0; i < n.ToString().Length; i++)
            {
                int currentDigit = int.Parse(n.ToString().Substring(i, 1));
                crossResult = currentDigit * crossResult;
                plusResult += currentDigit;    
            }
            return crossResult- plusResult;
        }
    }
}
