using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RubrikSecurityCloud
{
    public class VarInfo
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// Create a new VarInfo object.
        /// </summary>
        public VarInfo(string name, string type, string description)
        {
            this.Name = name;
            this.Type = type;
            this.Description = description;
        }

        public override string ToString()
        {
            return $"VarInfo({Name}, {Type}, {Description})";
        }

    }

    /// <summary>
    /// A case-insensitive dictionary of variables.
    /// </summary>
    public class VarDict : Dictionary<string, object>
    {
        /// <summary>
        /// Create a new empty VarDict.
        /// </summary>
        public VarDict() : base(StringComparer.OrdinalIgnoreCase)
        {
        }

        /// <summary>
        /// Create a new VarDict from a hashtable.
        /// If the hashtable contains nested hashtables, they will be converted to VarDicts.
        /// </summary>
        /// <param name="hashtable"></param>
        /// <exception cref="ArgumentException"></exception>
        public VarDict(Hashtable hashtable) : base(StringComparer.OrdinalIgnoreCase)
        {
            if (hashtable == null)
            {
                return;
            }

            foreach (DictionaryEntry entry in hashtable)
            {
                if (entry.Key is string key)
                {
                    if (entry.Value is Hashtable hVal)
                    {
                        this[key] = new VarDict(hVal);
                    }
                    else
                    {
                        this[key] = entry.Value;
                    }
                }
                else
                {
                    throw new ArgumentException("Hashtable contains non-string key.", nameof(hashtable));
                }
            }
        }

        
        /// <summary>
        /// Add values from a dictionary.
        /// </summary>
        public VarDict AddFromDictionary(Dictionary<string, object> dict)
        {
            if (dict != null && dict.Count > 0)
            {
                foreach (var entry in dict)
                {
                    this[entry.Key] = entry.Value;
                }
            }
            return this;
        }

        /// <summary>
        /// Add values from a tuple array.
        /// </summary>
        /// <param name="vars"></param>
        public void AddFromTuple(Tuple<String, String>[] vars)
        {
            if (vars != null && vars.Length > 0)
            {
                foreach (var v in vars)
                {
                    this.Add(v.Item1, v.Item2);
                }
            }
        }

        /// <summary>
        /// Add values from a comma-separated key-value string.
        /// </summary>
        public void AddFromCskvString(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return;
            }

            var pairs = s.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var pair in pairs)
            {
                var kv = pair.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                if (kv.Length == 2)
                {
                    this.Add(kv[0], kv[1]);
                }
                else
                {
                    throw new ArgumentException($"Invalid key-value pair: {pair}");
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("[vardict]{");
            foreach(KeyValuePair<string, object> entry in this)
            {
                sb.Append(entry.Key).Append('=').Append(
                    StringUtils.FormatObjectForLogging(entry.Value))
                    .Append(", ");
            }
            sb.Append("}");
            return sb.ToString();
        }

    }
}
