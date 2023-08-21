using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.IO;

namespace RubrikSecurityCloud
{

    public class RscPatchFile
    {
        private readonly string _filePath;

        public RscPatchFile(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
            {
                throw new ArgumentException("File path must be valid and point to an existing file.", nameof(filePath));
            }

            _filePath = filePath;
        }

        public void Parse(ref HashSet<string> wantedFields, ref HashSet<string> unwantedFields)
        {
            if (wantedFields == null || unwantedFields == null)
            {
                throw new ArgumentNullException("Wanted and unwanted fields sets must be initialized.");
            }

            using (StreamReader reader = new StreamReader(_filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Trim();
                    if (line.StartsWith("+"))
                    {
                        wantedFields.Add(line.Substring(1).Trim());
                    }
                    else if (line.StartsWith("-"))
                    {
                        unwantedFields.Add(line.Substring(1).Trim());
                    }
                    else
                    {
                        wantedFields.Add(line.Trim());
                    }
                }
            }
        }
    }
}