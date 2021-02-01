using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1672
    {
        public int MaximumWealrh(int[][] accounts)
        {
            int finalResult = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                int result = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    result += accounts[i][j];
                }
                if (finalResult < result)
                    finalResult = result;
            }
            return finalResult;
        }
    }
}
