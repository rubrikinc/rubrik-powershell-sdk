using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using RubrikSecurityCloud.Types;

namespace RubrikSecurityCloud
{
    public static class Exploration
    {
        // Enum for Profile
        public enum Profile
        {
            DEFAULT,
            DETAILS
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
        // --------------------------------------------------

        public static void Init(Profile profile=Profile.DEFAULT)
        {
            GlobalProfile = profile;
            FieldCount = 0;
        }

        // Static method
        // a leaf is a scalar or an enum
        public static bool Includes(string nodeName, bool isLeaf=false)
        {
            if ( FieldCount > MaxFieldCount ) {
                return false ;
            }

            if (string.IsNullOrEmpty(nodeName))
            {
                return false;
            }
            // strip any initial '.'
            if (nodeName.StartsWith("."))
            {
                nodeName = nodeName.Substring(1);
            }
            // split on '.'
            string[] nodes = nodeName.Split('.');
            int depth = nodes.Length - 1;
            string lastNode = nodes[nodes.Length - 1];

            lastNode = lastNode.ToLower();
            bool included;
            switch (GlobalProfile)
            {
                case Profile.DEFAULT:
                    included = DefaultIncludes(nodes, lastNode, depth, isLeaf);
                    break;

                case Profile.DETAILS:
                    included = DetailsIncludes(nodes, lastNode, depth, isLeaf);
                    break;

                default:
                    return false;
            }
            if (included)
            {
                FieldCount++;
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
            if (!isLeaf) {
                if (lastNode == "nodes" || lastNode == "pageinfo" )
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
                        return false;
                    }
                    return true;
                }
                return false;
            }

            if ( lastNode == "id" || 
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
                 lastNode == "count" )
            {
                return true;
            }
            // all `is-` and `has-` boolean fields
            if ( lastNode.StartsWith("is") || 
                 lastNode.StartsWith("has") ) {
                return true;
            }
            // all status and state fields
            if ( lastNode.Contains("status") || 
                 lastNode.Contains("state") ) {
                return true;
            }
            return false ;
        }

        // Static method
        public static bool DetailsIncludes(
            string[] nodes, 
            string lastNode, 
            int depth,
            bool isLeaf)
        {
            // start with default includes
            if ( DefaultIncludes(nodes, lastNode, depth, isLeaf) ) {
                return true;
            }
            // we use nodes, not edges
            if ( lastNode == "edges" ) {
                return false;
            }
            // WORKAROUND for api server bug
            // TODO: SPARK-230377
            if ( lastNode == "datagovautoenablepolicyconfig")
            {
                return false ;
            }
            // try to avoid loops
            int firstIndex = Array.IndexOf(nodes, nodes[nodes.Length - 1]);
            if (firstIndex != nodes.Length - 1)
            {
                // The value of lastNode is elsewhere in nodes
                // => probably a loop
                return false;
            }
            return isLeaf || depth <= 1 ;
        }

    }

}