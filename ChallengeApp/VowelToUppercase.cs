// ========================================================
// Covert all vowel letters into uppercase
// ========================================================
// Input: rasanya otakku semakin keram
// Expected result
// rAsAnyA OtAkkU sEmAkIn kErAm
using System;
using System.Text;

namespace ChallengeApp
{
    public class VowelToUppercase
    {
        public static string upperVowel(string str)
        {
            var ret = new StringBuilder(str);
            ret.Replace('a', 'A');
            ret.Replace('i', 'I');
            ret.Replace('u', 'U');
            ret.Replace('e', 'E');
            ret.Replace('o', 'O');

            return ret.ToString();
        }
    }
}
