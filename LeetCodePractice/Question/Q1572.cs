using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1572
    {
        public int DiagonalSum(int[][] mat)
        {
            int result = 0;
            for(int i = 0; i < mat.Length; i++)
            {
                result += mat[i][i];
                result += mat[mat.Length-1][i];
            }

            return result;
        }
    }
}
