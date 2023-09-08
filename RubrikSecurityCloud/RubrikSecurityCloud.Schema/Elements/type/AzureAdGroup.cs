// AzureAdGroup.cs
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
    #region AzureAdGroup
    public class AzureAdGroup: BaseType
    {
        #region members

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.String? GroupType
        // GraphQL -> groupType: String! (scalar)
        [JsonProperty("groupType")]
        public System.String? GroupType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdGroup";
    }

    public AzureAdGroup Set(
        System.String? DisplayName = null,
        System.String? GroupType = null
    ) 
    {
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( GroupType != null ) {
            this.GroupType = GroupType;
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
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            s += ind + "displayName\n" ;
        }
        //      C# -> System.String? GroupType
        // GraphQL -> groupType: String! (scalar)
        if (this.GroupType != null) {
            s += ind + "groupType\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName == null && ec.Includes("displayName",true))
        {
            this.DisplayName = "FETCH";
        }
        //      C# -> System.String? GroupType
        // GraphQL -> groupType: String! (scalar)
        if (this.GroupType == null && ec.Includes("groupType",true))
        {
            this.GroupType = "FETCH";
        }
    }


    #endregion

    } // class AzureAdGroup
    
    #endregion

    public static class ListAzureAdGroupExtensions
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
            this List<AzureAdGroup> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdGroup> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdGroup());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AzureAdGroup> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types