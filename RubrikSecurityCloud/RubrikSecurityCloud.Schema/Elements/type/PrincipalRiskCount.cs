// PrincipalRiskCount.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region PrincipalRiskCount
    public class PrincipalRiskCount: BaseType
    {
        #region members

        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        [JsonProperty("count")]
        public System.Int64? Count { get; set; }

        //      C# -> System.Int64? DeltaCount
        // GraphQL -> deltaCount: Long! (scalar)
        [JsonProperty("deltaCount")]
        public System.Int64? DeltaCount { get; set; }


        #endregion

    #region methods

    public PrincipalRiskCount Set(
        System.Int64? Count = null,
        System.Int64? DeltaCount = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( DeltaCount != null ) {
            this.DeltaCount = DeltaCount;
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
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        //      C# -> System.Int64? DeltaCount
        // GraphQL -> deltaCount: Long! (scalar)
        if (this.DeltaCount != null) {
            s += ind + "deltaCount\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (this.Count == null && Exploration.Includes(parent + ".count", true))
        {
            this.Count = new System.Int64();
        }
        //      C# -> System.Int64? DeltaCount
        // GraphQL -> deltaCount: Long! (scalar)
        if (this.DeltaCount == null && Exploration.Includes(parent + ".deltaCount", true))
        {
            this.DeltaCount = new System.Int64();
        }
    }


    #endregion

    } // class PrincipalRiskCount
    
    #endregion

    public static class ListPrincipalRiskCountExtensions
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
            this List<PrincipalRiskCount> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PrincipalRiskCount> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PrincipalRiskCount());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types