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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region AzureCloudAccountRolePermission
    public class AzureCloudAccountRolePermission: BaseType
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

    public override string GetGqlTypeName() {
        return "AzureCloudAccountRolePermission";
    }

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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<System.String>? ExcludedActions
        // GraphQL -> excludedActions: [String!]! (scalar)
        if (this.ExcludedActions != null) {
            s += ind + "excludedActions\n" ;
        }
        //      C# -> List<System.String>? ExcludedDataActions
        // GraphQL -> excludedDataActions: [String!]! (scalar)
        if (this.ExcludedDataActions != null) {
            s += ind + "excludedDataActions\n" ;
        }
        //      C# -> List<System.String>? IncludedActions
        // GraphQL -> includedActions: [String!]! (scalar)
        if (this.IncludedActions != null) {
            s += ind + "includedActions\n" ;
        }
        //      C# -> List<System.String>? IncludedDataActions
        // GraphQL -> includedDataActions: [String!]! (scalar)
        if (this.IncludedDataActions != null) {
            s += ind + "includedDataActions\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? ExcludedActions
        // GraphQL -> excludedActions: [String!]! (scalar)
        if (this.ExcludedActions == null && Exploration.Includes(parent + ".excludedActions", true))
        {
            this.ExcludedActions = new List<System.String>();
        }
        //      C# -> List<System.String>? ExcludedDataActions
        // GraphQL -> excludedDataActions: [String!]! (scalar)
        if (this.ExcludedDataActions == null && Exploration.Includes(parent + ".excludedDataActions", true))
        {
            this.ExcludedDataActions = new List<System.String>();
        }
        //      C# -> List<System.String>? IncludedActions
        // GraphQL -> includedActions: [String!]! (scalar)
        if (this.IncludedActions == null && Exploration.Includes(parent + ".includedActions", true))
        {
            this.IncludedActions = new List<System.String>();
        }
        //      C# -> List<System.String>? IncludedDataActions
        // GraphQL -> includedDataActions: [String!]! (scalar)
        if (this.IncludedDataActions == null && Exploration.Includes(parent + ".includedDataActions", true))
        {
            this.IncludedDataActions = new List<System.String>();
        }
    }


    #endregion

    } // class AzureCloudAccountRolePermission
    
    #endregion

    public static class ListAzureCloudAccountRolePermissionExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<AzureCloudAccountRolePermission> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureCloudAccountRolePermission> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureCloudAccountRolePermission());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types