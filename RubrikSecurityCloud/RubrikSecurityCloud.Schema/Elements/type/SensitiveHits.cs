// SensitiveHits.cs
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
    #region SensitiveHits
    public class SensitiveHits: BaseType
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

        //      C# -> SummaryHits? TotalHits
        // GraphQL -> totalHits: SummaryHits (type)
        [JsonProperty("totalHits")]
        public SummaryHits? TotalHits { get; set; }


        #endregion

    #region methods

    public SensitiveHits Set(
        SummaryHits? HighRiskHits = null,
        SummaryHits? LowRiskHits = null,
        SummaryHits? MediumRiskHits = null,
        SummaryHits? TotalHits = null
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
        if ( TotalHits != null ) {
            this.TotalHits = TotalHits;
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
        //      C# -> SummaryHits? TotalHits
        // GraphQL -> totalHits: SummaryHits (type)
        if (this.TotalHits != null) {
            var fspec = this.TotalHits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "totalHits {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SummaryHits? HighRiskHits
        // GraphQL -> highRiskHits: SummaryHits (type)
        if (this.HighRiskHits == null && Exploration.Includes(parent + ".highRiskHits"))
        {
            this.HighRiskHits = new SummaryHits();
            this.HighRiskHits.ApplyExploratoryFieldSpec(parent + ".highRiskHits");
        }
        //      C# -> SummaryHits? LowRiskHits
        // GraphQL -> lowRiskHits: SummaryHits (type)
        if (this.LowRiskHits == null && Exploration.Includes(parent + ".lowRiskHits"))
        {
            this.LowRiskHits = new SummaryHits();
            this.LowRiskHits.ApplyExploratoryFieldSpec(parent + ".lowRiskHits");
        }
        //      C# -> SummaryHits? MediumRiskHits
        // GraphQL -> mediumRiskHits: SummaryHits (type)
        if (this.MediumRiskHits == null && Exploration.Includes(parent + ".mediumRiskHits"))
        {
            this.MediumRiskHits = new SummaryHits();
            this.MediumRiskHits.ApplyExploratoryFieldSpec(parent + ".mediumRiskHits");
        }
        //      C# -> SummaryHits? TotalHits
        // GraphQL -> totalHits: SummaryHits (type)
        if (this.TotalHits == null && Exploration.Includes(parent + ".totalHits"))
        {
            this.TotalHits = new SummaryHits();
            this.TotalHits.ApplyExploratoryFieldSpec(parent + ".totalHits");
        }
    }


    #endregion

    } // class SensitiveHits
    
    #endregion

    public static class ListSensitiveHitsExtensions
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
            this List<SensitiveHits> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SensitiveHits> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SensitiveHits());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types