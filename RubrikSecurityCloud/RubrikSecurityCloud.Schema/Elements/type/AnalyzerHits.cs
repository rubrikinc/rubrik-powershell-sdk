// AnalyzerHits.cs
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
    #region AnalyzerHits
    public class AnalyzerHits: BaseType
    {
        #region members

        //      C# -> SummaryHits? HighRiskHits
        // GraphQL -> highRiskHits: SummaryHits (type)
        [JsonProperty("highRiskHits")]
        public SummaryHits? HighRiskHits { get; set; }

        //      C# -> SummaryHits? LowRiskHits
        // GraphQL -> lowRiskHits: SummaryHits (type)
        [JsonProperty("lowRiskHits")]
        public SummaryHits? LowRiskHits { get; set; }

        //      C# -> SummaryHits? MediumRiskHits
        // GraphQL -> mediumRiskHits: SummaryHits (type)
        [JsonProperty("mediumRiskHits")]
        public SummaryHits? MediumRiskHits { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AnalyzerHits";
    }

    public AnalyzerHits Set(
        SummaryHits? HighRiskHits = null,
        SummaryHits? LowRiskHits = null,
        SummaryHits? MediumRiskHits = null
    ) 
    {
        if ( HighRiskHits != null ) {
            this.HighRiskHits = HighRiskHits;
        }
        if ( LowRiskHits != null ) {
            this.LowRiskHits = LowRiskHits;
        }
        if ( MediumRiskHits != null ) {
            this.MediumRiskHits = MediumRiskHits;
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
        //      C# -> SummaryHits? HighRiskHits
        // GraphQL -> highRiskHits: SummaryHits (type)
        if (this.HighRiskHits != null) {
            var fspec = this.HighRiskHits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "highRiskHits {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SummaryHits? LowRiskHits
        // GraphQL -> lowRiskHits: SummaryHits (type)
        if (this.LowRiskHits != null) {
            var fspec = this.LowRiskHits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "lowRiskHits {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SummaryHits? MediumRiskHits
        // GraphQL -> mediumRiskHits: SummaryHits (type)
        if (this.MediumRiskHits != null) {
            var fspec = this.MediumRiskHits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "mediumRiskHits {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SummaryHits? HighRiskHits
        // GraphQL -> highRiskHits: SummaryHits (type)
        if (this.HighRiskHits == null && ec.Includes("highRiskHits",false))
        {
            this.HighRiskHits = new SummaryHits();
            this.HighRiskHits.ApplyExploratoryFieldSpec(ec.NewChild("highRiskHits"));
        }
        //      C# -> SummaryHits? LowRiskHits
        // GraphQL -> lowRiskHits: SummaryHits (type)
        if (this.LowRiskHits == null && ec.Includes("lowRiskHits",false))
        {
            this.LowRiskHits = new SummaryHits();
            this.LowRiskHits.ApplyExploratoryFieldSpec(ec.NewChild("lowRiskHits"));
        }
        //      C# -> SummaryHits? MediumRiskHits
        // GraphQL -> mediumRiskHits: SummaryHits (type)
        if (this.MediumRiskHits == null && ec.Includes("mediumRiskHits",false))
        {
            this.MediumRiskHits = new SummaryHits();
            this.MediumRiskHits.ApplyExploratoryFieldSpec(ec.NewChild("mediumRiskHits"));
        }
    }


    #endregion

    } // class AnalyzerHits
    
    #endregion

    public static class ListAnalyzerHitsExtensions
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
            this List<AnalyzerHits> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AnalyzerHits> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AnalyzerHits());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AnalyzerHits> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types