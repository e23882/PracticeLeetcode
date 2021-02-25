using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q728
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            List<int> result = new List<int>();
            for(int i=left;i< right+1; i++)
            {
                List<bool>isMatch = new List<bool>();
                for(int j = 0; j < i.ToString().Length; j++)
                {
                    var currentDigit = int.Parse(i.ToString().Substring(j, 1));
                    if (currentDigit != 0)
                    {
                        if (i % currentDigit == 0)
                            isMatch.Add(true);
                        else
                            isMatch.Add(false);
                    }
                    else
                        isMatch.Add(false);
                }
                if(!isMatch.Any(x=>x==false))
                    result.Add(i);
            }
            return result;
        }
    }
}
