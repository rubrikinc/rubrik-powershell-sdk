// SummaryCount.cs
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
    #region SummaryCount
    public class SummaryCount: BaseType
    {
        #region members

        //      C# -> System.Int64? TotalCount
        // GraphQL -> totalCount: Long! (scalar)
        [JsonProperty("totalCount")]
        public System.Int64? TotalCount { get; set; }

        //      C# -> System.Int64? ViolatedCount
        // GraphQL -> violatedCount: Long! (scalar)
        [JsonProperty("violatedCount")]
        public System.Int64? ViolatedCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SummaryCount";
    }

    public SummaryCount Set(
        System.Int64? TotalCount = null,
        System.Int64? ViolatedCount = null
    ) 
    {
        if ( TotalCount != null ) {
            this.TotalCount = TotalCount;
        }
        if ( ViolatedCount != null ) {
            this.ViolatedCount = ViolatedCount;
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
        //      C# -> System.Int64? TotalCount
        // GraphQL -> totalCount: Long! (scalar)
        if (this.TotalCount != null) {
            s += ind + "totalCount\n" ;
        }
        //      C# -> System.Int64? ViolatedCount
        // GraphQL -> violatedCount: Long! (scalar)
        if (this.ViolatedCount != null) {
            s += ind + "violatedCount\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? TotalCount
        // GraphQL -> totalCount: Long! (scalar)
        if (this.TotalCount == null && Exploration.Includes(parent + ".totalCount", true))
        {
            this.TotalCount = new System.Int64();
        }
        //      C# -> System.Int64? ViolatedCount
        // GraphQL -> violatedCount: Long! (scalar)
        if (this.ViolatedCount == null && Exploration.Includes(parent + ".violatedCount", true))
        {
            this.ViolatedCount = new System.Int64();
        }
    }


    #endregion

    } // class SummaryCount
    
    #endregion

    public static class ListSummaryCountExtensions
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
            this List<SummaryCount> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SummaryCount> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SummaryCount());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types