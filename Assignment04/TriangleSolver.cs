using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    public static class TriangleSolver
    {
        static string triangleType;
        static int val1, val2, val3;
        static int longestSide;

        public static string Analyze(int val1, int val2, int val3)
        {
            TriangleSolver.val1 = val1;
            TriangleSolver.val2 = val2;
            TriangleSolver.val3 = val3;

            bool chk = isValidTriangle(val1, val2, val3);

            if (chk) {
                if (val1.Equals(val2) && val2.Equals(val3) && val3.Equals(val1))
                {
                    triangleType = "Equilateral";
                }
                else if (!val1.Equals(val2) && !val2.Equals(val3) && !val3.Equals(val1))
                {
                    triangleType = "Scalene";
                }
                else if(val1.Equals(val2) || val2.Equals(val3) || val3.Equals(val1))
                {
                    triangleType = "Isosceles";
                }
            }
            else
            {
                triangleType = "not formed";
            }

            return triangleType;
        }


        public static bool isValidTriangle(int n1, int n2, int n3)
        {
            longestSide = Math.Max(n1, Math.Max(n2, n3));
            bool check = longestSide < ((n1 + n2 + n3) - longestSide);
            return check;
        }
    }
}
