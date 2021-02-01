using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1108
    {
        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }
    }
}
