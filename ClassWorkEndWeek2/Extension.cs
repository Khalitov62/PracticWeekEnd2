using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWorkEndWeek2
{
   static class Extension
    {
        public static stron Capitalized(this string word)
        {
            if (char.ToUpper(word[0]))
            {
                for (int i = 1; i < word.Length; i++)
                {
                    if (!char.IsLower(word[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
