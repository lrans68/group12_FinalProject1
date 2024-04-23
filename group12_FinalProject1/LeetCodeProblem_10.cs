/*# Name: Sarah Mahan, Josh Klingelhafer, Lucas Ransick
# email: mahansa@mail.uc.edu, klingejo@mail.uc.edu, ransiclu@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 4/23/24
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: This project is our final project. 
# Workload: Sarah (Easy Problem, Default page, implementation, optional styling, GIT host), Lucas (Medium, testing, implementation), Josh (Hard, testing, implementation)
# Citations: AI used to solve problems: https://chat.openai.com/share/aa542af9-6d34-475b-bcfa-c4a604d5ad20, https://chat.openai.com/share/a4995f4e-6e83-4d75-8509-69dbe504eb94,https://chat.openai.com/share/721a0175-a423-427f-986e-57126ac955a6
# CSS style buttons taken from: https://getcssscan.com/css-buttons-examples
# Anything else that's relevant: Nothing, Thank you for a great semester!
*/
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