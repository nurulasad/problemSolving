

using System.Collections.Generic;

namespace HackerrankSrc
{

    public class RegularExpresionMatch
    {

        private Dictionary<string, bool> _cache = new Dictionary<string, bool>();


        //https://leetcode.com/problems/regular-expression-matching/

        /*
         * Example 1:

    Input: s = "aa", p = "a"
    Output: false
    Explanation: "a" does not match the entire string "aa".
    Example 2:

    Input: s = "aa", p = "a*"
    Output: true
    Explanation: '*' means zero or more of the preceding element, 'a'. Therefore, by repeating 'a' once, it becomes "aa".
    Example 3:

    Input: s = "ab", p = ".*"
    Output: true
    Explanation: ".*" means "zero or more (*) of any character (.)".
         */
        public bool IsMatch(string s, string p)
        {
            var match = Backtrack(0, 0, s, p);
            return match;
        }
        
        public bool Backtrack(int i, int j, string s, string p)
        {
            if (_cache.ContainsKey($"{i}_{j}"))
            {
                return _cache[$"{i}_{j}"];
            }
            if (i >= s.Length && j >= p.Length) //complete both input and pattern
                return true;

            if (j >= p.Length)  //pattern ends but input still not finihed
                return false;

            var match = i < s.Length && (s[i] == p[j] || p[j] == '.');

            if (j + 1 < p.Length && p[j + 1] == '*')
            {
                var res1 = Backtrack(i, j + 2, s, p) || (match && Backtrack(i + 1, j, s, p));
                _cache.Add($"{i}_{j}", res1);
                return _cache[$"{i}_{j}"];
            }

            if (match)
            {
                var res2 = Backtrack(i + 1, j + 1, s, p);
                _cache.Add($"{i}_{j}", res2);
                return _cache[$"{i}_{j}"];
            }

            _cache.Add($"{i}_{j}", false);

            return _cache[$"{i}_{j}"];
        }



    }
}