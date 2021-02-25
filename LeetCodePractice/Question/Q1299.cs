using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1299
    {
        public int[] ReplaceElements(int[] arr)
        {
            int[] result = new int[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                int maxium = -1;
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (maxium < arr[j])
                        maxium = arr[j];
                }
                result[i] = maxium;
            }
            return result;
        }
    }
}
