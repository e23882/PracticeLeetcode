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
            int[] input = new int[] {1,2,3,4,5};
            Q1748 Q = new Q1748();
            
            Console.WriteLine(Q.SumOfUnique(input));
            Console.ReadLine();
        }
    }
}
