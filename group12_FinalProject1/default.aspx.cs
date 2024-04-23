using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace group12_FinalProject1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEasy_Click(object sender, EventArgs e)
        {
            String prob118Title;
            prob118Title = "Given an integer numRows, return the first numRows of Pascal's triangle. Constraints: 1 <= numRows <= 30";
            lblProblemTitle.Text = prob118Title;
            LeetCodeProblem118 mySolution = new LeetCodeProblem118();
            //IList<IList<int>> result = LeetCodeProblem118.Generate(5);
            //string pascalTriangle;
            //pascalTriangle = Console.WriteLine("Pascal's Triangle for numRows = " + numRows + ":");
            //foreach (IList<int> row in result)
            //{
            //    Console.WriteLine("[{0}]", string.Join(",", row));
            //}

        }

        protected void btnMedium_Click(object sender, EventArgs e)
        {
            String prob371Title;
            prob371Title = " Given two integers a and b, return the sum of the two integers without using the operators + and.Test Code: a=1 b=2";
            lblProblemTitle.Text = prob371Title;
            LeetCodeProblem371 mySolution = new LeetCodeProblem371();
            String sumofTwoInt;
            sumofTwoInt = mySolution.GetSum(1, 2).ToString();
            lblSolutionDescription.Text = sumofTwoInt;
        }

        protected void btdHard_Click(object sender, EventArgs e)
        {
            String prob10Title;
            prob10Title = "Given an input string s and a pattern p, implement regular expression matching with support for '.' and '*' where: '.' Matches any single character and '*' Matches zero or more of the preceding element. The matching should cover the entire input string (not partial). Test Case: s = aa p = a";
            lblProblemTitle.Text = prob10Title;
            LeetCodeProblem_10 mySolution = new LeetCodeProblem_10();
            String expressionMatch;
            expressionMatch = mySolution.IsMatch("aa", "a").ToString();
            lblSolutionDescription.Text = expressionMatch;
        }
    }
}