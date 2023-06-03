// HypervHostSummaryListResponse.cs
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
    #region HypervHostSummaryListResponse
    public class HypervHostSummaryListResponse: BaseType
    {
        #region members

        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean (scalar)
        [JsonProperty("hasMore")]
        public System.Boolean? HasMore { get; set; }

        //      C# -> System.Int64? Total
        // GraphQL -> total: Long (scalar)
        [JsonProperty("total")]
        public System.Int64? Total { get; set; }

        //      C# -> List<HypervHostSummary>? Data
        // GraphQL -> data: [HypervHostSummary!]! (type)
        [JsonProperty("data")]
        public List<HypervHostSummary>? Data { get; set; }


        #endregion

    #region methods

    public HypervHostSummaryListResponse Set(
        System.Boolean? HasMore = null,
        System.Int64? Total = null,
        List<HypervHostSummary>? Data = null
    ) 
    {
        if ( HasMore != null ) {
            this.HasMore = HasMore;
        }
        if ( Total != null ) {
            this.Total = Total;
        }
        if ( Data != null ) {
            this.Data = Data;
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
        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean (scalar)
        if (this.HasMore != null) {
            s += ind + "hasMore\n" ;
        }
        //      C# -> System.Int64? Total
        // GraphQL -> total: Long (scalar)
        if (this.Total != null) {
            s += ind + "total\n" ;
        }
        //      C# -> List<HypervHostSummary>? Data
        // GraphQL -> data: [HypervHostSummary!]! (type)
        if (this.Data != null) {
            s += ind + "data {\n" + this.Data.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean (scalar)
        if (this.HasMore == null && Exploration.Includes(parent + ".hasMore", true))
        {
            this.HasMore = true;
        }
        //      C# -> System.Int64? Total
        // GraphQL -> total: Long (scalar)
        if (this.Total == null && Exploration.Includes(parent + ".total", true))
        {
            this.Total = new System.Int64();
        }
        //      C# -> List<HypervHostSummary>? Data
        // GraphQL -> data: [HypervHostSummary!]! (type)
        if (this.Data == null && Exploration.Includes(parent + ".data"))
        {
            this.Data = new List<HypervHostSummary>();
            this.Data.ApplyExploratoryFieldSpec(parent + ".data");
        }
    }


    #endregion

    } // class HypervHostSummaryListResponse
    
    #endregion

    public static class ListHypervHostSummaryListResponseExtensions
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
            this List<HypervHostSummaryListResponse> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HypervHostSummaryListResponse> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervHostSummaryListResponse());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types