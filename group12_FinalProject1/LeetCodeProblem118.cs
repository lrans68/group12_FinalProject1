using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace group12_FinalProject1
{
    public class LeetCodeProblem118
    {
         public IList<IList<int>> Generate(int numRows)
            {
                IList<IList<int>> triangle = new List<IList<int>>();

                if (numRows == 0)
                    return triangle;

                // First row
                triangle.Add(new List<int> { 1 });

                for (int rowNum = 1; rowNum < numRows; rowNum++)
                {
                    IList<int> prevRow = triangle[rowNum - 1];
                    IList<int> row = new List<int>();

                    // First element of the row
                    row.Add(1);

                    // Generate the rest of the elements
                    for (int j = 1; j < rowNum; j++)
                    {
                        row.Add(prevRow[j - 1] + prevRow[j]);
                    }

                    // Last element of the row
                    row.Add(1);

                    triangle.Add(row);
                }

                return triangle;
          }
        
    }
}