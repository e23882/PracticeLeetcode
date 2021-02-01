using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1266
    {
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            int result = 0;

            List<Point> allPoint = new List<Point>();
            Point start = new Point() { x = points[0][0], y = points[0][1] };
            Point lastPoint = new Point() { x = points[points.Length-1][0], y = points[points.Length-1][1] };
            
            for(int i = 0; i < points.Length-1; i++)
            {
                while (start.x != points[i + 1][0] || start.y != points[i+1][1])
                {
                    if (start.x != points[i + 1][0])
                    {
                        if(start.x< points[i + 1][0])
                            start.x++;
                        else
                            start.x--;
                    }

                    if (start.y != points[i + 1][1])
                    {
                        if(start.y<points[i+1][1])
                            start.y++;
                        else
                            start.y--;
                    }
                    result++;
                }
            }
            return result;

        }

        public class Point
        {
            public int x { get; set; }
            public int y { get; set; }
        }
    }
}
