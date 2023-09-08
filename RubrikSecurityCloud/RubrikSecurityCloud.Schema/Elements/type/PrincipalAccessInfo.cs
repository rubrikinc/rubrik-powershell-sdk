// PrincipalAccessInfo.cs
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
    #region PrincipalAccessInfo
    public class PrincipalAccessInfo: BaseType
    {
        #region members

        //      C# -> System.Int64? GroupCount
        // GraphQL -> groupCount: Long! (scalar)
        [JsonProperty("groupCount")]
        public System.Int64? GroupCount { get; set; }

        //      C# -> System.Int64? UserCount
        // GraphQL -> userCount: Long! (scalar)
        [JsonProperty("userCount")]
        public System.Int64? UserCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrincipalAccessInfo";
    }

    public PrincipalAccessInfo Set(
        System.Int64? GroupCount = null,
        System.Int64? UserCount = null
    ) 
    {
        if ( GroupCount != null ) {
            this.GroupCount = GroupCount;
        }
        if ( UserCount != null ) {
            this.UserCount = UserCount;
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
        //      C# -> System.Int64? GroupCount
        // GraphQL -> groupCount: Long! (scalar)
        if (this.GroupCount != null) {
            s += ind + "groupCount\n" ;
        }
        //      C# -> System.Int64? UserCount
        // GraphQL -> userCount: Long! (scalar)
        if (this.UserCount != null) {
            s += ind + "userCount\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? GroupCount
        // GraphQL -> groupCount: Long! (scalar)
        if (this.GroupCount == null && ec.Includes("groupCount",true))
        {
            this.GroupCount = new System.Int64();
        }
        //      C# -> System.Int64? UserCount
        // GraphQL -> userCount: Long! (scalar)
        if (this.UserCount == null && ec.Includes("userCount",true))
        {
            this.UserCount = new System.Int64();
        }
    }


    #endregion

    } // class PrincipalAccessInfo
    
    #endregion

    public static class ListPrincipalAccessInfoExtensions
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
            this List<PrincipalAccessInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PrincipalAccessInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrincipalAccessInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<PrincipalAccessInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types