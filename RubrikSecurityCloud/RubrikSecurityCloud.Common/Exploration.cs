using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using RubrikSecurityCloud.Types;
using System.IO;

namespace RubrikSecurityCloud
{
    public static class Exploration
    {
        // Enum for Profile
        public enum Profile
        {
            UNSET,
            EMPTY,
            DEFAULT,
            DETAIL,
            FULL,
            CUSTOM
        }

        // --------------------------------------------------
        // CAVEAT:
        // These global fields are possibly shared among
        // multiple PowerShell sessions; if so,
        // we'll need them to be defined with each cmdlet invocation.

        // accessible from PowerShell with
        // [RubrikSecurityCloud.Exploration]::GlobalProfile
        public static Profile GlobalProfile = Profile.DEFAULT;

        // accessible from PowerShell with
        // [RubrikSecurityCloud.Exploration]::FieldCount
        public static int FieldCount = 0;

        public static int MaxFieldCount = 1000;

        public static List<string> IncludedFields = new List<string>();
        public static List<string> ExcludedFields = new List<string>();
        public static List<string> LoopyFields = new List<string>();
        public static HashSet<string> WantedFields = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        public static HashSet<string> UnwantedFields = new HashSet<string>(StringComparer.OrdinalIgnoreCase);


        public static int MaxDepth = 40;
        // --------------------------------------------------

        public static void Init(Profile profile = Profile.DEFAULT)
        {
            GlobalProfile = profile;
            FieldCount = 0;
            IncludedFields.Clear();
            ExcludedFields.Clear();
            LoopyFields.Clear();
            WantedFields.Clear();
            UnwantedFields.Clear();
        }

        public static void ReadPatchFromFile(string patchFile, bool missingOk = true)
        {
            if (File.Exists(patchFile))
            {
                var patch = new RscPatchFile(patchFile);
                patch.Parse(ref WantedFields, ref UnwantedFields);
            }
            else if (!missingOk)
            {
                throw new ArgumentException($"File not found: {patchFile}");
            }
        }

        public static void ReadPatchFromString(string patchString)
        {
            var patch = new RscPatchString(patchString);
            patch.Parse(ref WantedFields, ref UnwantedFields);
        }

        // Static method
        // a leaf is a scalar or an enum
        public static bool Includes(string nodeName, bool isLeaf = false)
        {
            if (string.IsNullOrEmpty(nodeName))
            {
                throw new ArgumentException("FieldSpec exploration: nodeName cannot be null or empty");
            }
            // strip any initial '.'
            if (nodeName.StartsWith("."))
            {
                nodeName = nodeName.Substring(1);
            }
            bool included = _Includes(nodeName, isLeaf);
            if (included)
            {
                IncludedFields.Add(nodeName);
                FieldCount++;
            }
            else
            {
                ExcludedFields.Add(nodeName);
            }
            return included;
        }

        private static bool _Includes(string nodeName, bool isLeaf = false)
        {
            string[] nodes = nodeName.Split('.');
            int depth = nodes.Length - 1;
            string lastNode = nodes[nodes.Length - 1];
            string parent = string.Join(".", nodes, 0, nodes.Length - 1);
            lastNode = lastNode.ToLower();
            parent = parent.ToLower();

            if (WantedFields.Contains(nodeName))
            {
                return true;
            }
            if (UnwantedFields.Contains(nodeName))
            {
                return false;
            }
            if (GlobalProfile != Profile.FULL && FieldCount > MaxFieldCount)
            {
                return false;
            }
            if (WantedFields.Contains(parent) && isLeaf)
            {
                return true;
            }

            bool included;
            switch (GlobalProfile)
            {
                case Profile.EMPTY:
                    included = false;
                    break;

                case Profile.CUSTOM:
                case Profile.DEFAULT:
                    included = DefaultIncludes(nodes, lastNode, depth, isLeaf);
                    break;

                case Profile.FULL:
                    included = FullIncludes(nodes, lastNode, depth, isLeaf);
                    break;

                case Profile.DETAIL:
                    included = DetailsIncludes(nodes, lastNode, depth, isLeaf);
                    break;

                default:
                    return false;
            }
            return included;
        }

        // Static method
        public static bool DefaultIncludes(
            string[] nodes,
            string lastNode,
            int depth,
            bool isLeaf)
        {
            if (!isLeaf)
            {
                if (lastNode == "nodes" || lastNode == "pageinfo")
                {
                    return true;
                }
                if (lastNode == "physicalchildconnection" ||
                    lastNode == "effectivesladomain")
                {
                    int firstIndex = Array.IndexOf(nodes, nodes[nodes.Length - 1]);
                    if (firstIndex != nodes.Length - 1)
                    {
                        // The value of lastNode is elsewhere in nodes
                        // => probably a loop
                        LoopyFields.Add(string.Join(".", nodes));
                        return false;
                    }
                    return true;
                }
                return false;
            }

            if (lastNode == "id" ||
                 lastNode == "name" ||
                 lastNode == "description" ||
                 lastNode == "version" ||
                 lastNode == "email" ||
                 lastNode == "username" ||
                 lastNode == "type" ||
                 lastNode == "objecttype" ||
                 lastNode == "slaassignment" ||
                 lastNode == "numworkloaddescendants" ||
                 lastNode == "startcursor" ||
                 lastNode == "endcursor" ||
                 lastNode == "count")
            {
                return true;
            }
            // all `is-` and `has-` boolean fields
            if (lastNode.StartsWith("is") ||
                 lastNode.StartsWith("has"))
            {
                return true;
            }
            // all status and state fields
            if (lastNode.Contains("status") ||
                 lastNode.Contains("state"))
            {
                return true;
            }
            return false;
        }

        // Static method
        public static bool FullIncludes(
            string[] nodes,
            string lastNode,
            int depth,
            bool isLeaf)
        {
            return DetailsIncludes(nodes, lastNode, depth, isLeaf, Exploration.MaxDepth);
        }

        // Static method
        public static bool DetailsIncludes(
            string[] nodes,
            string lastNode,
            int depth,
            bool isLeaf,
            int maxDepth = 1)
        {
            // start with default includes
            if (DefaultIncludes(nodes, lastNode, depth, isLeaf))
            {
                return true;
            }
            // we use nodes, not edges
            if (lastNode == "edges")
            {
                return false;
            }
            // WORKAROUND for api server bug
            // TODO: SPARK-230377
            if (lastNode == "datagovautoenablepolicyconfig")
            {
                return false;
            }
            // try to avoid loops
            int firstIndex = Array.IndexOf(nodes, nodes[nodes.Length - 1]);
            if (firstIndex != nodes.Length - 1)
            {
                // The value of lastNode is elsewhere in nodes
                // => probably a loop
                LoopyFields.Add(string.Join(".", nodes));
                return false;
            }
            return isLeaf || depth <= maxDepth;
        }

    }

}