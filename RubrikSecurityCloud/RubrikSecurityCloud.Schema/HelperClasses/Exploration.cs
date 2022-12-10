using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Rubrik.SecurityCloud.Types;

namespace Rubrik.SecurityCloud.Types
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
        public static bool Includes(string nodeName)
        {
            if (nodeName == null || nodeName == "")
            {
                return false;
            }
            string[] nodes = nodeName.Split('.');
            int depth = nodes.Length - 1;
            string lastNode = nodes[nodes.Length - 1];
            bool isLeaf = false;
            if (lastNode.EndsWith("$"))
            {
                isLeaf = true;
                lastNode = lastNode.TrimEnd('$');
            }

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
            // depth is 0 except for nodes
            if (!isLeaf) {
                return lastNode == "nodes";
            }
            // basic fields
            if ( lastNode == "id" || 
                 lastNode == "name" || 
                 lastNode == "type" ) 
            {
                return true;
            }
            // all `is-` and `has-` boolean fields
            if ( lastNode.StartsWith("is") || 
                 lastNode.StartsWith("has") ) {
                return true;
            }
            // all status fields
            if ( lastNode.ToLower().Contains("status") ) {
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
            if ( DefaultIncludes(nodes, lastNode, depth, isLeaf) || isLeaf ) {
                return true;
            }
            if ( lastNode == "roles" ) {
                return true;
            }
            return false;
        }

    }

}