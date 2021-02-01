using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1678
    {
        public string Interpret(string command)
        {
            return command.Replace("(al)", "al").Replace("()", "o");
        }
    }
}
