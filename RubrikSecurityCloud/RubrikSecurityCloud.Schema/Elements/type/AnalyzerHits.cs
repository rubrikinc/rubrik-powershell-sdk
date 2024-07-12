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

        //      C# -> SummaryHits? NoRiskHits
        // GraphQL -> noRiskHits: SummaryHits (type)
        [JsonProperty("noRiskHits")]
        public SummaryHits? NoRiskHits { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AnalyzerHits";
    }

    public AnalyzerHits Set(
        SummaryHits? HighRiskHits = null,
        SummaryHits? LowRiskHits = null,
        SummaryHits? MediumRiskHits = null,
        SummaryHits? NoRiskHits = null
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
        if ( NoRiskHits != null ) {
            this.NoRiskHits = NoRiskHits;
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
        //      C# -> SummaryHits? HighRiskHits
        // GraphQL -> highRiskHits: SummaryHits (type)
        if (this.HighRiskHits != null) {
            var fspec = this.HighRiskHits.AsFieldSpec(conf.Child("highRiskHits"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "highRiskHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SummaryHits? LowRiskHits
        // GraphQL -> lowRiskHits: SummaryHits (type)
        if (this.LowRiskHits != null) {
            var fspec = this.LowRiskHits.AsFieldSpec(conf.Child("lowRiskHits"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lowRiskHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SummaryHits? MediumRiskHits
        // GraphQL -> mediumRiskHits: SummaryHits (type)
        if (this.MediumRiskHits != null) {
            var fspec = this.MediumRiskHits.AsFieldSpec(conf.Child("mediumRiskHits"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mediumRiskHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SummaryHits? NoRiskHits
        // GraphQL -> noRiskHits: SummaryHits (type)
        if (this.NoRiskHits != null) {
            var fspec = this.NoRiskHits.AsFieldSpec(conf.Child("noRiskHits"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "noRiskHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SummaryHits? HighRiskHits
        // GraphQL -> highRiskHits: SummaryHits (type)
        if (ec.Includes("highRiskHits",false))
        {
            if(this.HighRiskHits == null) {

                this.HighRiskHits = new SummaryHits();
                this.HighRiskHits.ApplyExploratoryFieldSpec(ec.NewChild("highRiskHits"));

            } else {

                this.HighRiskHits.ApplyExploratoryFieldSpec(ec.NewChild("highRiskHits"));

            }
        }
        else if (this.HighRiskHits != null && ec.Excludes("highRiskHits",false))
        {
            this.HighRiskHits = null;
        }
        //      C# -> SummaryHits? LowRiskHits
        // GraphQL -> lowRiskHits: SummaryHits (type)
        if (ec.Includes("lowRiskHits",false))
        {
            if(this.LowRiskHits == null) {

                this.LowRiskHits = new SummaryHits();
                this.LowRiskHits.ApplyExploratoryFieldSpec(ec.NewChild("lowRiskHits"));

            } else {

                this.LowRiskHits.ApplyExploratoryFieldSpec(ec.NewChild("lowRiskHits"));

            }
        }
        else if (this.LowRiskHits != null && ec.Excludes("lowRiskHits",false))
        {
            this.LowRiskHits = null;
        }
        //      C# -> SummaryHits? MediumRiskHits
        // GraphQL -> mediumRiskHits: SummaryHits (type)
        if (ec.Includes("mediumRiskHits",false))
        {
            if(this.MediumRiskHits == null) {

                this.MediumRiskHits = new SummaryHits();
                this.MediumRiskHits.ApplyExploratoryFieldSpec(ec.NewChild("mediumRiskHits"));

            } else {

                this.MediumRiskHits.ApplyExploratoryFieldSpec(ec.NewChild("mediumRiskHits"));

            }
        }
        else if (this.MediumRiskHits != null && ec.Excludes("mediumRiskHits",false))
        {
            this.MediumRiskHits = null;
        }
        //      C# -> SummaryHits? NoRiskHits
        // GraphQL -> noRiskHits: SummaryHits (type)
        if (ec.Includes("noRiskHits",false))
        {
            if(this.NoRiskHits == null) {

                this.NoRiskHits = new SummaryHits();
                this.NoRiskHits.ApplyExploratoryFieldSpec(ec.NewChild("noRiskHits"));

            } else {

                this.NoRiskHits.ApplyExploratoryFieldSpec(ec.NewChild("noRiskHits"));

            }
        }
        else if (this.NoRiskHits != null && ec.Excludes("noRiskHits",false))
        {
            this.NoRiskHits = null;
        }
    }


    #endregion

    } // class AnalyzerHits
    
    #endregion

    public static class ListAnalyzerHitsExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AnalyzerHits> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AnalyzerHits> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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