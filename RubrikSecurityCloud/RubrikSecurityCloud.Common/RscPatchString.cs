using System;
using System.Collections;
using System.Collections.Generic;
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
    }
}
