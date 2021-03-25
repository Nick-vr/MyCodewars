using System;
using System.Linq;

namespace Codewars
{
    public class Codewars
    {
        public string Longest(string s1, string s2)
        {
            //Take 2 strings s1 and s2 including only letters from a to z.
            //Return a new sorted string, the longest possible,
            //distinct letters - each taken only once - coming from s1 or s2.

            var str = s1 + s2;
            var result = new string(str.OrderBy(x => x).Distinct().ToArray());
            return result;
        }
    }
}