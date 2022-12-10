using System;
using System.Collections;
using System.Text;
namespace Rubrik.SecurityCloud.PowerShell.Private
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
                sb.Append($"{entry.Key}={entry.Value}, ");
            }

            sb.Append("}");
            return sb.ToString();
        }
    }

}