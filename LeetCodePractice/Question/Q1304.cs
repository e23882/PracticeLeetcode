using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1304
    {
        public int[] SumZero(int n)
        {
            int[] result = new int[n];
            Random rd = new Random();
            for (int i = 0; i < n / 2; i++)
            {
                int current = rd.Next(1, 1000);
                while (Array.IndexOf(result, current) != -1)
                    current = rd.Next(1, 1000);

                result[2 * i] = current;
                result[2 * i + 1] = -current;
            }
            
            if (n % 2 != 0)
                result[result.Length - 1] = 0;
            return result;
        }
    }
}
