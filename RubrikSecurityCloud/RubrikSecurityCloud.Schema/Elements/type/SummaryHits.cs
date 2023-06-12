// SummaryHits.cs
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
    #region SummaryHits
    public class SummaryHits: BaseType
    {
        #region members

        //      C# -> System.Int64? TotalHits
        // GraphQL -> totalHits: Long! (scalar)
        [JsonProperty("totalHits")]
        public System.Int64? TotalHits { get; set; }

        //      C# -> System.Int64? ViolatedHits
        // GraphQL -> violatedHits: Long! (scalar)
        [JsonProperty("violatedHits")]
        public System.Int64? ViolatedHits { get; set; }


        #endregion

    #region methods

    public SummaryHits Set(
        System.Int64? TotalHits = null,
        System.Int64? ViolatedHits = null
    ) 
    {
        if ( TotalHits != null ) {
            this.TotalHits = TotalHits;
        }
        if ( ViolatedHits != null ) {
            this.ViolatedHits = ViolatedHits;
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
        //      C# -> System.Int64? TotalHits
        // GraphQL -> totalHits: Long! (scalar)
        if (this.TotalHits != null) {
            s += ind + "totalHits\n" ;
        }
        //      C# -> System.Int64? ViolatedHits
        // GraphQL -> violatedHits: Long! (scalar)
        if (this.ViolatedHits != null) {
            s += ind + "violatedHits\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? TotalHits
        // GraphQL -> totalHits: Long! (scalar)
        if (this.TotalHits == null && Exploration.Includes(parent + ".totalHits", true))
        {
            this.TotalHits = new System.Int64();
        }
        //      C# -> System.Int64? ViolatedHits
        // GraphQL -> violatedHits: Long! (scalar)
        if (this.ViolatedHits == null && Exploration.Includes(parent + ".violatedHits", true))
        {
            this.ViolatedHits = new System.Int64();
        }
    }


    #endregion

    } // class SummaryHits
    
    #endregion

    public static class ListSummaryHitsExtensions
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
            this List<SummaryHits> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SummaryHits> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SummaryHits());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types