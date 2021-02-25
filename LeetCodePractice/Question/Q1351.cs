using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1351
    {
        public int CountNegatives(int[][] grid)
        {
            int result = 0;
            for(int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] < 0)
                        result++;
                }
            }
            return result;
        }
    }
}
