using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RubrikSecurityCloud
{
    public static class StringUtils
    {
        public static string Capitalize(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return char.ToUpper(input[0]) + input.Substring(1);
        }

        public static string HashtableToString(Hashtable input)
        {
            if (input == null)
            {
                return "null";
            }

            var sb = new StringBuilder();
            sb.Append("{");
            foreach (DictionaryEntry entry in input)
            {
                sb.Append(entry.Key).Append('=').Append(entry.Value)
                    .Append(", ");
            }

            sb.Append("}");
            return sb.ToString();
        }

        public static string StrictPascalCase(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                throw new ArgumentException(
                    "StrictPascalCase: Input string cannot be null or empty.");
            }
            // from snake case:
            if (s.Contains("_"))
            {
                return string.Concat(
                    s.Split('_')
                        .Where(w => !string.IsNullOrEmpty(w))
                        .Select(
                            w => char.ToUpper(w[0]) + w.Substring(1).ToLower())
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
                for (
                    var j = ls.Length - consecutiveUpper + 1;
                    j < ls.Length;
                    j++)
                {
                    ls[j] = char.ToLower(ls[j]);
                }
            }
            return ls.ToString();
        }

        // Insert __typename field into all response objects
        public static string InsertTypeNamesInGqlQuery(string query)
        {
            const string typename = "__typename";
            // remove any existing __typename fields
            query = query.Replace(typename, string.Empty);

            // iterate through the query string and insert __typename
            var result = new StringBuilder();
            int parenthesesDepth = 0;
            bool insideString = false;

            foreach (char c in query)
            {
                if (c == '"' &&
                    (result.Length == 0 || result[result.Length - 1] != '\\'))
                {
                    insideString = !insideString;
                }

                if (!insideString)
                {
                    if (c == '(')
                    {
                        parenthesesDepth++;
                    }
                    else if (c == ')')
                    {
                        parenthesesDepth--;
                        if (parenthesesDepth < 0)
                        {
                            throw new ArgumentException(
                                "Unbalanced parentheses in query " + query);
                        }
                    }

                    if (c == '}' && parenthesesDepth == 0)
                    {
                        result.Append(" " + typename + " }");
                        continue;
                    }
                }

                result.Append(c);
            }

            if (parenthesesDepth != 0 || insideString)
            {
                throw new ArgumentException(
                    "Unbalanced parentheses or unclosed string in query " +
                    query);
            }

            return result.ToString();
        }
    }
}
