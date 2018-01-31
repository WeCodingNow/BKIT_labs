using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WagnerFisher
{
    public static class MinDistance
    {
        public static int Calculate(string M, string N)
        {
            if ((M == null) || (N == null)) return -1;

            int str1Len = M.Length;
            int str2Len = N.Length;

            if ((str1Len == 0) && (str2Len == 0)) return 0;
            if (str1Len == 0) return str2Len;
            if (str2Len == 0) return str1Len;

            string str1 = M.ToUpper();
            string str2 = N.ToUpper();

            int[,] matrix = new int[str1Len + 1, str2Len + 1];

            for (int i = 0; i <= str1Len; i++) matrix[i, 0] = i;
            for (int j = 0; j <= str2Len; j++) matrix[0, j] = j;

            for (int i = 1; i <= str1Len; i++)
            {
                for (int j = 1; j <= str2Len; j++)
                {
                    int symbEqual = (
                    (str1.Substring(i - 1, 1) ==
                    str2.Substring(j - 1, 1)) ? 0 : 1);
                    int ins = matrix[i, j - 1] + 1; 
                    int del = matrix[i - 1, j] + 1; 
                    int subst = matrix[i - 1, j - 1] + symbEqual; 
                    matrix[i, j] = Math.Min(Math.Min(ins, del), subst);

                    if ((i > 1) && (j > 1) &&
                    (str1.Substring(i - 1, 1) == str2.Substring(j - 2, 1)) &&
                    (str1.Substring(i - 2, 1) == str2.Substring(j - 1, 1)))
                    {
                        matrix[i, j] = Math.Min(matrix[i, j], matrix[i - 2, j - 2] + symbEqual);
                    }
                }
            }
            return matrix[str1Len, str2Len];
        }
    }
}
