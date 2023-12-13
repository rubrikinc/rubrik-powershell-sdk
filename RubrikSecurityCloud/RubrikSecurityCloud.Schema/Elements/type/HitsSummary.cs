// HitsSummary.cs
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
    #region HitsSummary
    public class HitsSummary: BaseType
    {
        #region members

        //      C# -> TotalRiskSummary? DeltaHitsSummary
        // GraphQL -> deltaHitsSummary: TotalRiskSummary (type)
        [JsonProperty("deltaHitsSummary")]
        public TotalRiskSummary? DeltaHitsSummary { get; set; }

        //      C# -> TotalRiskSummary? TotalHitsSummary
        // GraphQL -> totalHitsSummary: TotalRiskSummary (type)
        [JsonProperty("totalHitsSummary")]
        public TotalRiskSummary? TotalHitsSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HitsSummary";
    }

    public HitsSummary Set(
        TotalRiskSummary? DeltaHitsSummary = null,
        TotalRiskSummary? TotalHitsSummary = null
    ) 
    {
        if ( DeltaHitsSummary != null ) {
            this.DeltaHitsSummary = DeltaHitsSummary;
        }
        if ( TotalHitsSummary != null ) {
            this.TotalHitsSummary = TotalHitsSummary;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> TotalRiskSummary? DeltaHitsSummary
        // GraphQL -> deltaHitsSummary: TotalRiskSummary (type)
        if (this.DeltaHitsSummary != null) {
            var fspec = this.DeltaHitsSummary.AsFieldSpec(conf.Child("deltaHitsSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "deltaHitsSummary {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> TotalRiskSummary? TotalHitsSummary
        // GraphQL -> totalHitsSummary: TotalRiskSummary (type)
        if (this.TotalHitsSummary != null) {
            var fspec = this.TotalHitsSummary.AsFieldSpec(conf.Child("totalHitsSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "totalHitsSummary {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TotalRiskSummary? DeltaHitsSummary
        // GraphQL -> deltaHitsSummary: TotalRiskSummary (type)
        if (ec.Includes("deltaHitsSummary",false))
        {
            if(this.DeltaHitsSummary == null) {

                this.DeltaHitsSummary = new TotalRiskSummary();
                this.DeltaHitsSummary.ApplyExploratoryFieldSpec(ec.NewChild("deltaHitsSummary"));

            } else {

                this.DeltaHitsSummary.ApplyExploratoryFieldSpec(ec.NewChild("deltaHitsSummary"));

            }
        }
        else if (this.DeltaHitsSummary != null && ec.Excludes("deltaHitsSummary",false))
        {
            this.DeltaHitsSummary = null;
        }
        //      C# -> TotalRiskSummary? TotalHitsSummary
        // GraphQL -> totalHitsSummary: TotalRiskSummary (type)
        if (ec.Includes("totalHitsSummary",false))
        {
            if(this.TotalHitsSummary == null) {

                this.TotalHitsSummary = new TotalRiskSummary();
                this.TotalHitsSummary.ApplyExploratoryFieldSpec(ec.NewChild("totalHitsSummary"));

            } else {

                this.TotalHitsSummary.ApplyExploratoryFieldSpec(ec.NewChild("totalHitsSummary"));

            }
        }
        else if (this.TotalHitsSummary != null && ec.Excludes("totalHitsSummary",false))
        {
            this.TotalHitsSummary = null;
        }
    }


    #endregion

    } // class HitsSummary
    
    #endregion

    public static class ListHitsSummaryExtensions
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
            this List<HitsSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<HitsSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HitsSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HitsSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HitsSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types