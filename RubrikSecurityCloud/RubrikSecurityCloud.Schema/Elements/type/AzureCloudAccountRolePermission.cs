// AzureCloudAccountRolePermission.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
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
    #region AzureCloudAccountRolePermission
    public class AzureCloudAccountRolePermission: IFragment
    {
        #region members
        //      C# -> List<System.String>? ExcludedActions
        // GraphQL -> excludedActions: [String!]! (scalar)
        [JsonProperty("excludedActions")]
        public List<System.String>? ExcludedActions { get; set; }

        //      C# -> List<System.String>? ExcludedDataActions
        // GraphQL -> excludedDataActions: [String!]! (scalar)
        [JsonProperty("excludedDataActions")]
        public List<System.String>? ExcludedDataActions { get; set; }

        //      C# -> List<System.String>? IncludedActions
        // GraphQL -> includedActions: [String!]! (scalar)
        [JsonProperty("includedActions")]
        public List<System.String>? IncludedActions { get; set; }

        //      C# -> List<System.String>? IncludedDataActions
        // GraphQL -> includedDataActions: [String!]! (scalar)
        [JsonProperty("includedDataActions")]
        public List<System.String>? IncludedDataActions { get; set; }

        #endregion

    #region methods

    public AzureCloudAccountRolePermission Set(
        List<System.String>? ExcludedActions = null,
        List<System.String>? ExcludedDataActions = null,
        List<System.String>? IncludedActions = null,
        List<System.String>? IncludedDataActions = null
    ) 
    {
        if ( ExcludedActions != null ) {
            this.ExcludedActions = ExcludedActions;
        }
        if ( ExcludedDataActions != null ) {
            this.ExcludedDataActions = ExcludedDataActions;
        }
        if ( IncludedActions != null ) {
            this.IncludedActions = IncludedActions;
        }
        if ( IncludedDataActions != null ) {
            this.IncludedDataActions = IncludedDataActions;
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
            //      C# -> List<System.String>? ExcludedActions
            // GraphQL -> excludedActions: [String!]! (scalar)
            if (this.ExcludedActions != null)
            {
                 s += ind + "excludedActions\n";

            }
            //      C# -> List<System.String>? ExcludedDataActions
            // GraphQL -> excludedDataActions: [String!]! (scalar)
            if (this.ExcludedDataActions != null)
            {
                 s += ind + "excludedDataActions\n";

            }
            //      C# -> List<System.String>? IncludedActions
            // GraphQL -> includedActions: [String!]! (scalar)
            if (this.IncludedActions != null)
            {
                 s += ind + "includedActions\n";

            }
            //      C# -> List<System.String>? IncludedDataActions
            // GraphQL -> includedDataActions: [String!]! (scalar)
            if (this.IncludedDataActions != null)
            {
                 s += ind + "includedDataActions\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? ExcludedActions
            // GraphQL -> excludedActions: [String!]! (scalar)
            if (this.ExcludedActions == null && Exploration.Includes(parent + ".excludedActions$"))
            {
                this.ExcludedActions = new List<System.String>();
            }
            //      C# -> List<System.String>? ExcludedDataActions
            // GraphQL -> excludedDataActions: [String!]! (scalar)
            if (this.ExcludedDataActions == null && Exploration.Includes(parent + ".excludedDataActions$"))
            {
                this.ExcludedDataActions = new List<System.String>();
            }
            //      C# -> List<System.String>? IncludedActions
            // GraphQL -> includedActions: [String!]! (scalar)
            if (this.IncludedActions == null && Exploration.Includes(parent + ".includedActions$"))
            {
                this.IncludedActions = new List<System.String>();
            }
            //      C# -> List<System.String>? IncludedDataActions
            // GraphQL -> includedDataActions: [String!]! (scalar)
            if (this.IncludedDataActions == null && Exploration.Includes(parent + ".includedDataActions$"))
            {
                this.IncludedDataActions = new List<System.String>();
            }
        }


    #endregion

    } // class AzureCloudAccountRolePermission
    #endregion

    public static class ListAzureCloudAccountRolePermissionExtensions
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
            this List<AzureCloudAccountRolePermission> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureCloudAccountRolePermission> list, 
            String parent = "")
        {
            var item = new AzureCloudAccountRolePermission();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types