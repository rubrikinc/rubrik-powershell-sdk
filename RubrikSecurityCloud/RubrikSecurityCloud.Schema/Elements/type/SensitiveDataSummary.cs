// SensitiveDataSummary.cs
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
    #region SensitiveDataSummary
    public class SensitiveDataSummary: BaseType
    {
        #region members

        //      C# -> SensitiveDataSummaryBreakdown? Breakdown
        // GraphQL -> breakdown: SensitiveDataSummaryBreakdown (type)
        [JsonProperty("breakdown")]
        public SensitiveDataSummaryBreakdown? Breakdown { get; set; }

        //      C# -> TotalRiskSummary? TotalRiskSummary
        // GraphQL -> totalRiskSummary: TotalRiskSummary (type)
        [JsonProperty("totalRiskSummary")]
        public TotalRiskSummary? TotalRiskSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SensitiveDataSummary";
    }

    public SensitiveDataSummary Set(
        SensitiveDataSummaryBreakdown? Breakdown = null,
        TotalRiskSummary? TotalRiskSummary = null
    ) 
    {
        if ( Breakdown != null ) {
            this.Breakdown = Breakdown;
        }
        if ( TotalRiskSummary != null ) {
            this.TotalRiskSummary = TotalRiskSummary;
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
        //      C# -> SensitiveDataSummaryBreakdown? Breakdown
        // GraphQL -> breakdown: SensitiveDataSummaryBreakdown (type)
        if (this.Breakdown != null) {
            var fspec = this.Breakdown.AsFieldSpec(conf.Child("breakdown"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "breakdown" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> TotalRiskSummary? TotalRiskSummary
        // GraphQL -> totalRiskSummary: TotalRiskSummary (type)
        if (this.TotalRiskSummary != null) {
            var fspec = this.TotalRiskSummary.AsFieldSpec(conf.Child("totalRiskSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "totalRiskSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> SensitiveDataSummaryBreakdown? Breakdown
        // GraphQL -> breakdown: SensitiveDataSummaryBreakdown (type)
        if (ec.Includes("breakdown",false))
        {
            if(this.Breakdown == null) {

                this.Breakdown = new SensitiveDataSummaryBreakdown();
                this.Breakdown.ApplyExploratoryFieldSpec(ec.NewChild("breakdown"));

            } else {

                this.Breakdown.ApplyExploratoryFieldSpec(ec.NewChild("breakdown"));

            }
        }
        else if (this.Breakdown != null && ec.Excludes("breakdown",false))
        {
            this.Breakdown = null;
        }
        //      C# -> TotalRiskSummary? TotalRiskSummary
        // GraphQL -> totalRiskSummary: TotalRiskSummary (type)
        if (ec.Includes("totalRiskSummary",false))
        {
            if(this.TotalRiskSummary == null) {

                this.TotalRiskSummary = new TotalRiskSummary();
                this.TotalRiskSummary.ApplyExploratoryFieldSpec(ec.NewChild("totalRiskSummary"));

            } else {

                this.TotalRiskSummary.ApplyExploratoryFieldSpec(ec.NewChild("totalRiskSummary"));

            }
        }
        else if (this.TotalRiskSummary != null && ec.Excludes("totalRiskSummary",false))
        {
            this.TotalRiskSummary = null;
        }
    }


    #endregion

    } // class SensitiveDataSummary
    
    #endregion

    public static class ListSensitiveDataSummaryExtensions
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
            this List<SensitiveDataSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SensitiveDataSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SensitiveDataSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SensitiveDataSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SensitiveDataSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types