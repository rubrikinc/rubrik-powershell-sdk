using System;
using System.Linq;
using System.Text;

namespace RubrikSecurityCloud.Schema.Utils
{
    public class StringUtils
    {
        public static string StrictPascalCase(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                throw new ArgumentException("Input string cannot be null or empty.");
            }
            // from snake case:
            if (s.Contains("_"))
            {
                return string.Concat(
                    s.Split('_')
                        .Where(w => !string.IsNullOrEmpty(w))
                        .Select(w => char.ToUpper(w[0]) + w.Substring(1).ToLower())
                );
            }
            // from camel case:
            if (char.IsLower(s[0]))
            {
                s = char.ToUpper(s[0]) + s.Substring(1);
            }
            // Pascal case for acronyms, or any group of uppercase letters:
            var consecutiveUpper = 0;
            var ls = new StringBuilder(s);
            for (var i = 0; i < ls.Length; i++)
            {
                if (char.IsUpper(ls[i]))
                {
                    consecutiveUpper++;
                }
                else
                {
                    if (consecutiveUpper == 2)
                    {
                        ls[i - 1] = char.ToLower(ls[i - 1]);
                    }
                    else if (consecutiveUpper > 2)
                    {
                        for (var j = i - consecutiveUpper + 1; j < i - 1; j++)
                        {
                            ls[j] = char.ToLower(ls[j]);
                        }
                    }
                    consecutiveUpper = 0;
                }
            }
            if (consecutiveUpper == 2)
            {
                ls[ls.Length - 1] = char.ToLower(ls[ls.Length - 1]);
            }
            else if (consecutiveUpper > 2)
            {
                for (var j = ls.Length - consecutiveUpper + 1; j < ls.Length; j++)
                {
                    ls[j] = char.ToLower(ls[j]);
                }
            }
            return ls.ToString();
        }
    }
}
