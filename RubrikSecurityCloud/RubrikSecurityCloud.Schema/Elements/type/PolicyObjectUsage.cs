// PolicyObjectUsage.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:29.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region PolicyObjectUsage
    public class PolicyObjectUsage: IFragment
    {
        #region members
        //      C# -> List<ClassificationPolicySummary>? Policies
        // GraphQL -> policies: [ClassificationPolicySummary!]! (type)
        [JsonProperty("policies")]
        public List<ClassificationPolicySummary>? Policies { get; set; }

        //      C# -> HierarchyObject? HierarchyObject
        // GraphQL -> hierarchyObject: HierarchyObject! (interface)
        [JsonProperty("hierarchyObject")]
        public HierarchyObject? HierarchyObject { get; set; }

        #endregion

    #region methods

    public PolicyObjectUsage Set(
        List<ClassificationPolicySummary>? Policies = null,
        HierarchyObject? HierarchyObject = null
    ) 
    {
        if ( Policies != null ) {
            this.Policies = Policies;
        }
        if ( HierarchyObject != null ) {
            this.HierarchyObject = HierarchyObject;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> List<ClassificationPolicySummary>? Policies
            // GraphQL -> policies: [ClassificationPolicySummary!]! (type)
            if (this.Policies != null)
            {
                 s += ind + "policies\n";

                 s += ind + "{\n" + 
                 this.Policies.AsFragment(indent+1) + 
                 ind + "}\n";
            }
                        //      C# -> HierarchyObject? HierarchyObject
            // GraphQL -> hierarchyObject: HierarchyObject! (interface)
            if (this.HierarchyObject != null)
            {
                s += ind + "hierarchyObject\n";
                s += ind + "{\n";

                string typename = this.HierarchyObject.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.HierarchyObject.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<ClassificationPolicySummary>? Policies
            // GraphQL -> policies: [ClassificationPolicySummary!]! (type)
            if (this.Policies == null && Exploration.Includes(parent + ".policies"))
            {
                this.Policies = new List<ClassificationPolicySummary>();
                this.Policies.ApplyExploratoryFragment(parent + ".policies");
            }
            //      C# -> HierarchyObject? HierarchyObject
            // GraphQL -> hierarchyObject: HierarchyObject! (interface)
            if (this.HierarchyObject == null && Exploration.Includes(parent + ".hierarchyObject"))
            {
                this.HierarchyObject = (HierarchyObject)InterfaceHelper.CreateInstanceOfFirstType(typeof(HierarchyObject));
                this.HierarchyObject.ApplyExploratoryFragment(parent + ".hierarchyObject");
            }
        }


    #endregion

    } // class PolicyObjectUsage
    #endregion

    public static class ListPolicyObjectUsageExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<PolicyObjectUsage> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PolicyObjectUsage> list, 
            String parent = "")
        {
            var item = new PolicyObjectUsage();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types