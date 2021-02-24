using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q832
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            for(int i=0;i< A.Length; i++)
            {
                for(int j=0;j< A[i].Length; j++)
                {
                    A[i].Reverse();
                    if (A[i][j] == 0)
                        A[i][j] = 1;
                    else
                        A[i][j] = 0;
                }
                
            }
            return A;
        }
    }
}
