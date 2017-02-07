using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte1.Functions
{
    public class ChangeString
    {
        public static string build(string input)
        {
            string output = "";
            char[] arr = input.ToCharArray();

            foreach (char c in arr)
            {
                char s = c;
                if (Char.IsLetter(s))
                {
                    if (s == 'z')
                    { s = 'a'; }
                    else
                    {
                        if (s == 'Z')
                        { s = 'A'; }
                        else
                        { s = (char)((int)s + 1); }
                    }
                }
                output += s;
            }

            return output;
        }
    }
}
