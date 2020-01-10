// ========================================================
// Generate triangle
// ========================================================
//
// TriangleStars(4);
//
// Expected result
// 1
// 12
// 123
// 1234
//
// TriangleStars(2);
//
// Expected result
// 1
// 12

using System;
using System.Text;

namespace ChallengeApp
{
    public class TriangleOfNumbers
    {
        public static string Run(int n)
        {
            string ret = "";
            for(int i=1; i<=n; i++)
            {
                for(int j=1; j<=i; j++)
                    ret += Convert.ToString(j);
                
                ret += '\n';
            }

            return ret;
            throw new NotImplementedException();
        }
    }
}
