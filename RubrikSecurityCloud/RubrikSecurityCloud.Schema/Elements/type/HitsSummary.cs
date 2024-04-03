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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
                    s += ind + "deltaHitsSummary" + " " + "{\n" + fspec + ind + "}\n" ;
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
                    s += ind + "totalHitsSummary" + " " + "{\n" + fspec + ind + "}\n" ;
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
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<HitsSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
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