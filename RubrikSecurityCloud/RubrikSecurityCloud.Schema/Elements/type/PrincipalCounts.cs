// PrincipalCounts.cs
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
    #region PrincipalCounts
    public class PrincipalCounts: BaseType
    {
        #region members

        //      C# -> SummaryCount? HighRiskCount
        // GraphQL -> highRiskCount: SummaryCount (type)
        [JsonProperty("highRiskCount")]
        public SummaryCount? HighRiskCount { get; set; }

        //      C# -> SummaryCount? LowRiskCount
        // GraphQL -> lowRiskCount: SummaryCount (type)
        [JsonProperty("lowRiskCount")]
        public SummaryCount? LowRiskCount { get; set; }

        //      C# -> SummaryCount? MediumRiskCount
        // GraphQL -> mediumRiskCount: SummaryCount (type)
        [JsonProperty("mediumRiskCount")]
        public SummaryCount? MediumRiskCount { get; set; }

        //      C# -> SummaryCount? TotalCount
        // GraphQL -> totalCount: SummaryCount (type)
        [JsonProperty("totalCount")]
        public SummaryCount? TotalCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrincipalCounts";
    }

    public PrincipalCounts Set(
        SummaryCount? HighRiskCount = null,
        SummaryCount? LowRiskCount = null,
        SummaryCount? MediumRiskCount = null,
        SummaryCount? TotalCount = null
    ) 
    {
        if ( HighRiskCount != null ) {
            this.HighRiskCount = HighRiskCount;
        }
        if ( LowRiskCount != null ) {
            this.LowRiskCount = LowRiskCount;
        }
        if ( MediumRiskCount != null ) {
            this.MediumRiskCount = MediumRiskCount;
        }
        if ( TotalCount != null ) {
            this.TotalCount = TotalCount;
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
        //      C# -> SummaryCount? HighRiskCount
        // GraphQL -> highRiskCount: SummaryCount (type)
        if (this.HighRiskCount != null) {
            var fspec = this.HighRiskCount.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "highRiskCount {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SummaryCount? LowRiskCount
        // GraphQL -> lowRiskCount: SummaryCount (type)
        if (this.LowRiskCount != null) {
            var fspec = this.LowRiskCount.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "lowRiskCount {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SummaryCount? MediumRiskCount
        // GraphQL -> mediumRiskCount: SummaryCount (type)
        if (this.MediumRiskCount != null) {
            var fspec = this.MediumRiskCount.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "mediumRiskCount {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SummaryCount? TotalCount
        // GraphQL -> totalCount: SummaryCount (type)
        if (this.TotalCount != null) {
            var fspec = this.TotalCount.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "totalCount {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SummaryCount? HighRiskCount
        // GraphQL -> highRiskCount: SummaryCount (type)
        if (this.HighRiskCount == null && ec.Includes("highRiskCount",false))
        {
            this.HighRiskCount = new SummaryCount();
            this.HighRiskCount.ApplyExploratoryFieldSpec(ec.NewChild("highRiskCount"));
        }
        //      C# -> SummaryCount? LowRiskCount
        // GraphQL -> lowRiskCount: SummaryCount (type)
        if (this.LowRiskCount == null && ec.Includes("lowRiskCount",false))
        {
            this.LowRiskCount = new SummaryCount();
            this.LowRiskCount.ApplyExploratoryFieldSpec(ec.NewChild("lowRiskCount"));
        }
        //      C# -> SummaryCount? MediumRiskCount
        // GraphQL -> mediumRiskCount: SummaryCount (type)
        if (this.MediumRiskCount == null && ec.Includes("mediumRiskCount",false))
        {
            this.MediumRiskCount = new SummaryCount();
            this.MediumRiskCount.ApplyExploratoryFieldSpec(ec.NewChild("mediumRiskCount"));
        }
        //      C# -> SummaryCount? TotalCount
        // GraphQL -> totalCount: SummaryCount (type)
        if (this.TotalCount == null && ec.Includes("totalCount",false))
        {
            this.TotalCount = new SummaryCount();
            this.TotalCount.ApplyExploratoryFieldSpec(ec.NewChild("totalCount"));
        }
    }


    #endregion

    } // class PrincipalCounts
    
    #endregion

    public static class ListPrincipalCountsExtensions
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
            this List<PrincipalCounts> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PrincipalCounts> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrincipalCounts());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PrincipalCounts> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types