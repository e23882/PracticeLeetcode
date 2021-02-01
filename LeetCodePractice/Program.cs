using LeetCodePractice.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] input = new int[][] { new int[] { 1, 1 }, new int[] { 3, 4 }, new int[] {-1,0 } };
            var q = new Q1266();
            var result = q.MinTimeToVisitAllPoints(input);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
