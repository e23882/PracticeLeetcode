using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1528
    {
        public string RestoreString(string s, int[] indices)
        {
            string result = string.Empty;
            List<Type> temp = new List<Type>();
            for(int i = 0; i < s.Length; i++)
                temp.Add(new Type { Index = indices[i], Mappin = s.Substring(i, 1) });
            foreach(var item in temp.OrderBy(x => x.Index))
                result += item.Mappin;
            return result;
        }
        public class Type
        {
            public int Index { get; set; }
            public string Mappin { get; set; }
        }
    }
}
