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
    public class LeetCodeProblem20
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0) return false;

                    char top = stack.Pop();

                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}