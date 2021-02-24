using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1021
    {
        public string RemoveOuterParentheses(string S)
        {
            string result = string.Empty;
            // (()())(())(()(()))
            int leftCounter = 0;
            int rightCounter = 0;
            string currentValue = "";
            for (int i = 0; i < S.Length; i++)
            {
                var current = S.Substring(i, 1);
                currentValue += current;
                if (current == "(")
                    leftCounter++;
                else
                    rightCounter++;

            }
      

            //()()()()(())
            return result;
        }
    }
}
