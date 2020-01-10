// ========================================================
// Letter separators
// ========================================================

// new Separator("minum susu sapi")
// Expected output: m-i-n-u-m-s-u-s-u-s-a-p-i
//
// new Separator("minum susu sapi", '*')
// Expected output: m*i*n*u*m*s*u*s*u*s*a*p*i

using System;
using System.Text;

namespace ChallengeApp
{
    public class Separator
    {
        public static string Run(string str, string sep="-")
        {
            string ret = str.Replace(" ", String.Empty);
            return string.Join(sep, ret.ToCharArray());
            
            throw new NotImplementedException();
        }
    }
}
