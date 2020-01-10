// ========================================================
// Generate triangle
// ========================================================
//
// TriangleStars(5);
//
// Expected result
// *
// **
// ***
// ****
// *****
//
// TriangleStars(2);
//
// Expected result
// *
// **

using System;

namespace ChallengeApp
{
    public class TriangleStars
    {
        public static string Run(int n)
        {
            string ret = "";
            for(int i=1; i<=n; i++)
            {
                for(int j=1; j<=i; j++)
                    ret += '*';
                
                ret += '\n';
            }

            return ret;
            throw new NotImplementedException();
        }
    }
}
