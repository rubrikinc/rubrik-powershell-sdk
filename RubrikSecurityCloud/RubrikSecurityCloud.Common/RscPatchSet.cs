using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.IO;
using RubrikSecurityCloud.Types;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud
{
    public class RscPatchSet
    {
        public static List<string> BuildValidPatchStringsFor(
            string gqlReturnTypeName,
            int maxDepth = 10,
            HashSet<string>? skip = null)
        {
            var patches = ReflectionUtils.FlattenField(
                gqlReturnTypeName,
                ReflectionUtils.FlattenFieldContext.PatchContext());
            return patches;
        }

        public HashSet<string> WantedFields = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        public HashSet<string> UnwantedFields = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        public void Reset()
        {
            WantedFields.Clear();
            UnwantedFields.Clear();
        }

        public bool HasPatch()
        {
            return WantedFields.Count > 0 || UnwantedFields.Count > 0;
        }

        public bool Includes(string nodeName)
        {
            return WantedFields.Contains(nodeName);
        }

        public bool IncludesBranch(string branchName)
        {
            return WantedFields.Any(f => f.StartsWith(branchName + ".", StringComparison.OrdinalIgnoreCase));
        }

        public bool Excludes(string nodeName)
        {
            return UnwantedFields.Contains(nodeName);
        }

        public void ReadFromString(string patchString)
        {
            patchString = patchString.Trim();
            if (string.IsNullOrWhiteSpace(patchString))
            {
                return;
            }
            string[] _patches = patchString.Split(',');

            foreach (string patch in _patches)
            {
                var p = patch.Trim();
                bool want = true;
                if (p.StartsWith("+"))
                {
                    p = p.Substring(1).Trim();
                }
                else if (p.StartsWith("-") || p.StartsWith("!"))
                {
                    p = p.Substring(1).Trim();
                    want = false;
                }
                Add(p, want);
            }

        }

        public void Add(string nodeName, bool want)
        {
            if (string.IsNullOrWhiteSpace(nodeName))
            {
                return;
            }
            if (want)
            {
                WantedFields.Add(nodeName);
                if (UnwantedFields.Contains(nodeName))
                    UnwantedFields.Remove(nodeName);
            }
            else
            {
                UnwantedFields.Add(nodeName);
                if (WantedFields.Contains(nodeName))
                    WantedFields.Remove(nodeName);
            }
        }

        public void ReadFromFile(string patchFile, bool missingOk = true)
        {
            if (!string.IsNullOrWhiteSpace(patchFile) && File.Exists(patchFile))
            {
                using (StreamReader reader = new StreamReader(patchFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        ReadFromString(line);
                    }
                }
            }
            else if (!missingOk)
            {
                throw new ArgumentException($"File not found: {patchFile}");
            }
        }
        public void ReadFromArrays(
            string[]? wantedFields = null,
            string[]? unwantedFields = null)
        {
            if (wantedFields != null && wantedFields.Length > 0)
            {
                foreach (string field in wantedFields)
                {
                    Add(field, true);
                }
            }
            if (unwantedFields != null && unwantedFields.Length > 0)
            {
                foreach (var field in unwantedFields)
                {
                    Add(field, false);
                }
            }
        }

        public void ReadFieldSpecFromObject(object obj)
        {
            if (obj == null)
            {
                return;
            }
            if ( !(obj is IFieldSpec) )
            {
                throw new ArgumentException("Object must implement IFieldSpec");
            }
            var fsObj = (IFieldSpec)obj;
            var fsConfig = new FieldSpecConfig() { Flat = true };
            string fs = fsObj.AsFieldSpec(fsConfig);
            // the field spec lists the strings separated by \n
            List<string> patchStrings = fs.Trim('\n').Split('\n').ToList();
            ReadFromArrays(patchStrings.ToArray(), null);
        }

    }
}
