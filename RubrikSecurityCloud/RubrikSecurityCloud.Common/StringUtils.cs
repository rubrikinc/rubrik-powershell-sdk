using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using RubrikSecurityCloud.Types;

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

        public static List<string> FieldSpecStringToList(string s)
        {
            return s.Split(new[] { '\n', '\r' },
                        StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => StringUtils.StrictPascalCase(s))
                    .Where(s => !string.IsNullOrEmpty(s))
                    .ToList().OrderBy(s => s).ToList();
        }

        public static List<string> FlattenFieldToFieldSpecList(
            List<string> flat)
        {
            return flat.Select(s => StringUtils.StrictPascalCase(s))
                .Where(s => !string.IsNullOrEmpty(s))
                .ToList().OrderBy(s => s).ToList();
        }

        public static List<string> BuildUnselectedList(
            List<string> allFields, List<string> selectedFields)
        {
            if (allFields.Count == 0)
            {
                return new List<string>();
            }
            // If there are no selected fields, return all fields
            if (selectedFields.Count == 0)
            {
                return allFields;
            }
            // If all fields are selected, return empty list
            if (allFields.Count == selectedFields.Count)
            {
                return new List<string>();
            }
            var allFieldsSet = new HashSet<string>(allFields);
            var selectedFieldsSet = new HashSet<string>(selectedFields);

            // Subtract selected fields from all fields
            allFieldsSet.ExceptWith(selectedFieldsSet);

            // Sort it
            return allFieldsSet.ToList().OrderBy(s => s).ToList();
        }

        public static string StrictPascalCase(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                throw new ArgumentException(
                    "StrictPascalCase: Input string cannot be null or empty.");
            }

            // Split by dots
            string[] parts = s.Split('.');

            // Convert each part to PascalCase
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i] = _StrictPascalCase(parts[i]);
            }

            // Join back together with dots
            return string.Join(".", parts);
        }

        internal static string _StrictPascalCase(string s)
        {

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

        public static string GqlTypeToType(string gqlType, bool convertListToScalar = true)
        {
            if (string.IsNullOrEmpty(gqlType))
            {
                return "";
            }
            var t = gqlType.Replace("!", "");
            if (convertListToScalar)
            {
                t = t.Replace("[", "").Replace("]", "");
            }
            else
            {
                if (t.StartsWith("["))
                {
                    t = "List<" + t.Substring(1, t.Length - 2) + ">";
                }
            }
            return t;
        }

        /// <summary>
        /// Return documentation links for a GQL type name.
        /// </summary>
        /// <param name="gqlType">
        /// Type name, can be null or empty, can have ! or [].
        /// e.g. "[ClusterConnection!]!" returns
        /// https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/clusterconnection.doc.html
        /// </param>
        public static string DocLinkForGqlType(string gqlType)
        {
            var url = "https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/";
            if (string.IsNullOrEmpty(gqlType))
            {
                return url;
            }

            if (gqlType.StartsWith("List<"))
            {
                gqlType = gqlType.Substring(5, gqlType.Length - 6);
            }
            var t = gqlType.Replace("!", "").Replace("[", "").Replace("]", "").ToLower().Replace("system.", "").Trim();
            if (t == "int" || t == "string" || t == "boolean" || t == "bool" || t == "float" || t == "double" || t == "id" || t == "datetime")
            {
                return gqlType;
            }
            return url + t + ".doc.html";
        }

        /// <summary>
        /// Return the type name for an object,
        /// with generic type parameters.
        /// </summary>
        public static string GetGenericType(object obj)
        {
            if (obj == null)
            {
                return "";
            }
            var type = obj.GetType();
            string typeName;
            if (!type.IsGenericType)
            {
                typeName = type.ToString();
            }
            else
            {
                var genericArgs = type.GetGenericArguments();
                typeName = $"{type.Name.Split('`')[0]}<{string.Join(", ", genericArgs.Select(t => t.Name))}>";
            }
            return typeName.Replace("System.", "").Replace("Collections.", "").Replace("Management.Automation.", "");
        }

        /// <summary>
        /// Format an object for logging.
        /// </summary>
        public static string FormatObjectForLogging(object? obj, bool showType = true)
        {
            if (obj == null)
            {
                return "null";
            }

            string type = showType ? $"[{GetGenericType(obj)}]" : "";

            // Check for string type first
            if (obj is string str)
            {
                return $"\"{str}\"";
            }
            else if (obj is int iObj)
            {
                return $"{iObj}";
            }
            else if (obj is bool bObj)
            {
                return $"{bObj}";
            }
            else if (obj is IFieldSpec fsObj)
            {
                return fsObj.AsFieldSpec().Replace("\n", " ");
            }
            else if (obj is VarDict vdObj)
            {
                return vdObj.ToString();
            }
            else if (obj is Hashtable hObj)
            {
                var sb = new StringBuilder();
                sb.Append(type + "@{");
                foreach (DictionaryEntry entry in hObj)
                {
                    sb.Append(entry.Key).Append('=').Append(FormatObjectForLogging(entry.Value))
                        .Append(", ");
                }

                sb.Append("}");
                return sb.ToString();
            }
            else if (obj is IEnumerable collection)
            {
                try
                {
                    var col = collection.Cast<object>().Select<object, string>(item => FormatObjectForLogging(item));
                    return type + "{" + string.Join(", ", col) + "}";
                }
                catch (Exception)
                {
                    return type + obj?.ToString();
                }
            }
            else
            {
                return type + obj?.ToString();
            }
        }

        public static (string, string) ParseGqlAndVarString(string query)
        {
            // Regular expression to match the /**/ block
            var regex = new Regex(@"/\*(.*?)\*/", RegexOptions.Singleline);

            var match = regex.Match(query);

            if (match.Success)
            {
                string vars = match.Groups[1].Value.Trim();
                vars = vars.Replace("Variables:", "");
                string q = query.Substring(match.Index + match.Length).Trim();
                return (vars, q);
            }
            else
            {
                // If no match is found, return "" and the whole string
                return ("", query);
            }
        }


    }
}
