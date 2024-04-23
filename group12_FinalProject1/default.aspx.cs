/*# Name: Sarah Mahan, Josh Klingelhafer, Lucas Ransick
# email: mahansa@mail.uc.edu, klingejo@mail.uc.edu, ransiclu@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 4/23/24
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: This project is our final project. 
# Workload: Sarah (Easy Problem, Default page, implementation, optional styling, GIT host), Lucas (Medium, testing, implementation), Josh (Hard, testing, implementation)
# Citations: AI used to solve problems: https://chat.openai.com/share/aa542af9-6d34-475b-bcfa-c4a604d5ad20, https://chat.openai.com/share/a4995f4e-6e83-4d75-8509-69dbe504eb94,https://chat.openai.com/share/721a0175-a423-427f-986e-57126ac955a6
  CSS style buttons taken from: https://getcssscan.com/css-buttons-examples
# Anything else that's relevant: Nothing, Thank you for a great semester!
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace group12_FinalProject1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEasy_Click(object sender, EventArgs e)
        {
            lblProblemTitle.Text = "20. Valid Parenthesis";
            String prob20Desc;
            prob20Desc = "Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.\r\n\r\nAn input string is valid if:\r\n\r\nOpen brackets must be closed by the same type of brackets.\r\nOpen brackets must be closed in the correct order.\r\nEvery close bracket has a corresponding open bracket of the same type.";
            lblProblemDescription.Text = prob20Desc;
            lblTestCase.Text = "Test Case: ()";
            LeetCodeProblem20 mySolution = new LeetCodeProblem20();
            String validParenthsis;
            validParenthsis = mySolution.IsValid("()").ToString();
            lblSolutionDescription.Text = validParenthsis;

        }

        protected void BtnMedium_Click(object sender, EventArgs e)
        {
            lblProblemTitle.Text = "371. Sum of Two Integers";
            String prob371Desc;
            prob371Desc = " Given two integers a and b, return the sum of the two integers without using the operators + and -.";
            lblProblemDescription.Text = prob371Desc;
            lblTestCase.Text = "Test Case: a = 1 b = 2";
            LeetCodeProblem371 mySolution = new LeetCodeProblem371();
            String sumofTwoInt;
            sumofTwoInt = mySolution.GetSum(1, 2).ToString();
            lblSolutionDescription.Text = sumofTwoInt;
        }

        protected void BtnHard_Click(object sender, EventArgs e)
        {
            lblProblemTitle.Text = "10. Regular Expression Matching";
            String prob10Desc;
            prob10Desc = "Given an input string s and a pattern p, implement regular expression matching with support for '.' and '*' where: '.' Matches any single character and '*' Matches zero or more of the preceding element. The matching should cover the entire input string (not partial).";
            lblProblemDescription.Text = prob10Desc;
            lblTestCase.Text = "Test Case: s = aa p = a";
            LeetCodeProblem_10 mySolution = new LeetCodeProblem_10();
            String expressionMatch;
            expressionMatch = mySolution.IsMatch("aa", "a").ToString();
            lblSolutionDescription.Text = expressionMatch;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            lblProblemTitle.Text = "";
            lblProblemDescription.Text = "";
            lblTestCase.Text = "";
            lblSolutionDescription.Text = "";
        }
    }
}