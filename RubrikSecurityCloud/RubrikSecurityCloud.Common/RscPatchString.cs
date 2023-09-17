using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.IO;

namespace RubrikSecurityCloud
{

    public class RscPatchString
    {
        private readonly string[] _patches;

        public RscPatchString(string patchString)
        {
            patchString = patchString.Trim();
            if (string.IsNullOrWhiteSpace(patchString))
            {
                _patches = new string[] { };
            }
            else
            {
                _patches = patchString.Split(',');
            }
        }

        public void Parse(ref HashSet<string> wantedFields, ref HashSet<string> unwantedFields)
        {
            if (wantedFields == null || unwantedFields == null)
            {
                throw new ArgumentNullException("Wanted and unwanted fields sets must be initialized.");
            }

            foreach (string patch in _patches)
            {
                var p = patch.Trim();
                if (p.StartsWith("+"))
                {
                    wantedFields.Add(p.Substring(1));
                }
                else if (p.StartsWith("-"))
                {
                    unwantedFields.Add(p.Substring(1));
                }
                else
                {
                    wantedFields.Add(p);
                }
            }
        }

        public static List<string> BuildValidPatchStringsFor(
            string gqlReturnTypeName,
            int maxDepth = 10,
            HashSet<string>? skip = null)
        {
            var patches = ReflectionUtils.FlattenField(gqlReturnTypeName, addClassNames: true, maxDepth: 5, skip: skip);
            if (patches.Count > 0)
            {
                patches.AddRange(patches.Select(s => "-" + s).ToList());
            }
            return patches;
        }
    }
}
