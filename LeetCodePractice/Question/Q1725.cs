using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1725
    {
        public int CountGoodRectangles(int[][] rectangles)
        {
            int maxium = 0;
            List<int> temp = new List<int>();
            for(int i = 0; i < rectangles.Length; i++)
            {
                if(rectangles[i][0] < rectangles[i][1])
                {
                    temp.Add(rectangles[i][0]);
                    if(maxium < rectangles[i][0])
                        maxium = rectangles[i][0];
                }
                else
                {
                    temp.Add(rectangles[i][1]);
                    if (maxium < rectangles[i][1])
                        maxium = rectangles[i][1];
                }
            }
            return temp.Count(x => x == maxium);
        }
    }
}
