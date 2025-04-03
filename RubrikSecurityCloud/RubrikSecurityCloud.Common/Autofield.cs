using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using RubrikSecurityCloud.Types;
using System.IO;
using System.Linq;

namespace RubrikSecurityCloud
{
    public class AutofieldContext
    {
        public string Parent { get; set; } = "";

        public AutofieldContext(string parent = "")
        {
            Parent = parent;
        }

        public bool Includes(string nodeName, bool isLeaf = false)
        {
            return Autofield.Includes(Parent + "." + nodeName, isLeaf);
        }

        public bool Excludes(string nodeName, bool isLeaf = false)
        {
            return Autofield.Excludes(Parent + "." + nodeName, isLeaf);
        }

        /// <summary>
        /// Instantiate a new AutofieldContext from a parent context
        /// and a child node name.
        /// </summary>
        public AutofieldContext NewChild(string child)
        {
            return new AutofieldContext(Parent + "." + child);
        }
    }


    public static class Autofield
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
        // [RubrikSecurityCloud.Autofield]::GlobalProfile
        public static Profile GlobalProfile = Profile.DEFAULT;

        // accessible from PowerShell with
        // [RubrikSecurityCloud.Autofield]::FieldCount
        public static int FieldCount = 0;

        public static int MaxFieldCount = 1000;

        public static List<string> IncludedFields = new List<string>();
        public static List<string> ExcludedFields = new List<string>();
        public static List<string> LoopyFields = new List<string>();
        public static RscPatchSet PatchSet = new RscPatchSet();

        public static int MaxDepth = 40;
        // --------------------------------------------------

        public static void Init(Profile profile = Profile.DEFAULT)
        {
            GlobalProfile = profile;
            FieldCount = 0;
            IncludedFields.Clear();
            ExcludedFields.Clear();
            LoopyFields.Clear();
            PatchSet.Reset();
        }

        public static bool Excludes(string nodeName, bool isLeaf = false)
        {
            if (string.IsNullOrEmpty(nodeName))
            {
                throw new ArgumentException("FieldSpec autofield: nodeName cannot be null or empty");
            }
            // strip any initial '.'
            if (nodeName.StartsWith("."))
            {
                nodeName = nodeName.Substring(1);
            }
            return PatchSet.Excludes(nodeName);
        }

        // Static method
        // a leaf is a scalar or an enum
        public static bool Includes(string nodeName, bool isLeaf = false)
        {
            if (string.IsNullOrEmpty(nodeName))
            {
                throw new ArgumentException("FieldSpec autofield: nodeName cannot be null or empty");
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
            // global cap on number of fields
            if (GlobalProfile != Profile.FULL && FieldCount > MaxFieldCount)
            {
                return false;
            }

            string[] nodes = nodeName.Split('.');
            int depth = nodes.Length - 1;
            string lastNode = nodes[nodes.Length - 1];
            string parent = string.Join(".", nodes, 0, nodes.Length - 1);
            lastNode = lastNode.ToLower();
            parent = parent.ToLower();

            if (PatchSet.Includes(nodeName))
            {
                return true;
            }
            if (PatchSet.Excludes(nodeName))
            {
                return false;
            }
            if (PatchSet.Includes(parent) && isLeaf)
            {
                return true;
            }
            if (!isLeaf)
            {
                // if any entry in the WantedFields HashSet starts with
                // nodeName + ".", then we want to include this node
                if (PatchSet.IncludesBranch(nodeName))
                {
                    return true;
                }
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
                foreach (var pattern in RubrikSecurityCloud.Config.DefaultProfileBranchPattern)
                {
                    if (Regex.IsMatch(lastNode, pattern))
                    {
                        return true;
                    }
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

            foreach (var pattern in RubrikSecurityCloud.Config.DefaultProfileLeafPatternWithExceptions)
            {
                if (Regex.IsMatch(lastNode, pattern.Key, RegexOptions.IgnoreCase))
                {
                    if (pattern.Value == null) {
                        return true;
                    }

                    // If there are exceptions, check if lastNode matches any exception
                    bool isException = pattern.Value.Any(exception => lastNode.Equals(exception, StringComparison.OrdinalIgnoreCase));
            
                    if (!isException) {
                        return true;
                    }
                }
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
            return DetailsIncludes(nodes, lastNode, depth, isLeaf, Autofield.MaxDepth);
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