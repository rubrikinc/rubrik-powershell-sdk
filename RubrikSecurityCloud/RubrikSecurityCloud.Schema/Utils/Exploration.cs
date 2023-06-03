using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Rubrik.SecurityCloud.Types;

namespace RubrikSecurityCloud.Schema.Utils
{
    public static class Exploration
    {
        // Enum for Profile
        public enum Profile
        {
            DEFAULT,
            DETAILS
        }

        // Static field
        public static Profile GlobalProfile = Profile.DEFAULT;

        // Static method
        // a leaf is a scalar or an enum
        public static bool Includes(string nodeName, bool isLeaf=false)
        {
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
            switch (GlobalProfile)
            {
                case Profile.DEFAULT:
                    return DefaultIncludes(nodes, lastNode, depth, isLeaf);

                case Profile.DETAILS:
                    return DetailsIncludes(nodes, lastNode, depth, isLeaf);

                default:
                    return false;
            }
        }

        // Static method
        public static bool DefaultIncludes(
            string[] nodes,
            string lastNode, 
            int depth, 
            bool isLeaf)
        {
            // depth is 0 except for "nodes"
            // that is: we only explore fields at the root level
            // except for "nodes", in which we go down one level.
            if (!isLeaf) {
                return lastNode == "nodes";
            }
            // basic fields
            if ( lastNode == "id" || 
                 lastNode == "name" ||
                 lastNode == "email" ||
                 lastNode == "username" ||
                 lastNode == "type" ) 
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
            return isLeaf || depth <= 1 ;
        }

    }

}