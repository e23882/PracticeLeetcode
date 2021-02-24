using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1450
    {
        public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            int result = 0;
            for(int i = 0; i < endTime.Length; i++)
            {
                if (endTime[i] >= queryTime && startTime[i]<= queryTime)
                    result++;
            }
            return result;
        }
    }
}
