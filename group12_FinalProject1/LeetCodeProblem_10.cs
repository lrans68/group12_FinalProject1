using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace group12_FinalProject1
{
    public class LeetCodeProblem_10
    {
        public bool IsMatch(string s, string p)
        {
            return MatchHelper(s, p, s.Length - 1, p.Length - 1, new Dictionary<string, bool>());
        }

        private bool MatchHelper(string s, string p, int i, int j, Dictionary<string, bool> memo)
        {
            if (i == -1 && j == -1)
            {
                return true;
            }

            if (j == -1)
            {
                return false;
            }

            if (i == -1)
            {
                for (int k = j; k >= 0; k--)
                {
                    if (p[k] == '*')
                    {
                        k--; // Move 2 characters back (skip preceding character)
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }

            if (!memo.ContainsKey(i + ":" + j))
            {
                bool match = false;

                if (s[i] == p[j] || p[j] == '.')
                {
                    match = MatchHelper(s, p, i - 1, j - 1, memo);
                }
                else if (p[j] == '*')
                {
                    match = MatchHelper(s, p, i, j - 2, memo); // Zero instances of preceding character
                    if (!match && (s[i] == p[j - 1] || p[j - 1] == '.'))
                    {
                        match = MatchHelper(s, p, i - 1, j, memo); // One or more instances of preceding character
                    }
                }

                memo[i + ":" + j] = match;
            }

            return memo[i + ":" + j];
        }

    }
}