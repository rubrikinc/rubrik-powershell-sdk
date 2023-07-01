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
            if (!isLeaf) {
                if (lastNode == "nodes")
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
                 lastNode == "numworkloaddescendants") 
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
            if ( lastNode == "edges" ) {
                return false; // we use nodes, not edges.
            }
            // WORKAROUND for api server bug
            // TODO: SPARK-230377
            if ( lastNode == "datagovautoenablepolicyconfig")
            {
                return false ;
            }
            return isLeaf || depth <= 1 || lastNode == "nodes";
        }

    }

}