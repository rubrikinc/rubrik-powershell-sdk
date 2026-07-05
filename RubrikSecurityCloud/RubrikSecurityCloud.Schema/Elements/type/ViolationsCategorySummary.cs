// ViolationsCategorySummary.cs
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
    #region ViolationsCategorySummary
    public class ViolationsCategorySummary: BaseType
    {
        #region members

        //      C# -> List<ViolationCategorySummary>? CategorySummary
        // GraphQL -> categorySummary: [ViolationCategorySummary!]! (type)
        [JsonProperty("categorySummary")]
        public List<ViolationCategorySummary>? CategorySummary { get; set; }

        //      C# -> ViolationCategorySummary? OverallSummary
        // GraphQL -> overallSummary: ViolationCategorySummary (type)
        [JsonProperty("overallSummary")]
        public ViolationCategorySummary? OverallSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ViolationsCategorySummary";
    }

    public ViolationsCategorySummary Set(
        List<ViolationCategorySummary>? CategorySummary = null,
        ViolationCategorySummary? OverallSummary = null
    ) 
    {
        if ( CategorySummary != null ) {
            this.CategorySummary = CategorySummary;
        }
        if ( OverallSummary != null ) {
            this.OverallSummary = OverallSummary;
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
        //      C# -> List<ViolationCategorySummary>? CategorySummary
        // GraphQL -> categorySummary: [ViolationCategorySummary!]! (type)
        if (this.CategorySummary != null) {
            var fspec = this.CategorySummary.AsFieldSpec(conf.Child("categorySummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "categorySummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ViolationCategorySummary? OverallSummary
        // GraphQL -> overallSummary: ViolationCategorySummary (type)
        if (this.OverallSummary != null) {
            var fspec = this.OverallSummary.AsFieldSpec(conf.Child("overallSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "overallSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<ViolationCategorySummary>? CategorySummary
        // GraphQL -> categorySummary: [ViolationCategorySummary!]! (type)
        if (ec.Includes("categorySummary",false))
        {
            if(this.CategorySummary == null) {

                this.CategorySummary = new List<ViolationCategorySummary>();
                this.CategorySummary.ApplyExploratoryFieldSpec(ec.NewChild("categorySummary"));

            } else {

                this.CategorySummary.ApplyExploratoryFieldSpec(ec.NewChild("categorySummary"));

            }
        }
        else if (this.CategorySummary != null && ec.Excludes("categorySummary",false))
        {
            this.CategorySummary = null;
        }
        //      C# -> ViolationCategorySummary? OverallSummary
        // GraphQL -> overallSummary: ViolationCategorySummary (type)
        if (ec.Includes("overallSummary",false))
        {
            if(this.OverallSummary == null) {

                this.OverallSummary = new ViolationCategorySummary();
                this.OverallSummary.ApplyExploratoryFieldSpec(ec.NewChild("overallSummary"));

            } else {

                this.OverallSummary.ApplyExploratoryFieldSpec(ec.NewChild("overallSummary"));

            }
        }
        else if (this.OverallSummary != null && ec.Excludes("overallSummary",false))
        {
            this.OverallSummary = null;
        }
    }


    #endregion

    } // class ViolationsCategorySummary
    
    #endregion

    public static class ListViolationsCategorySummaryExtensions
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
            this List<ViolationsCategorySummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ViolationsCategorySummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ViolationsCategorySummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ViolationsCategorySummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ViolationsCategorySummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types