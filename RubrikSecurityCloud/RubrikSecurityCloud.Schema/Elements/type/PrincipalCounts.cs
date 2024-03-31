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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> SummaryCount? HighRiskCount
        // GraphQL -> highRiskCount: SummaryCount (type)
        if (this.HighRiskCount != null) {
            var fspec = this.HighRiskCount.AsFieldSpec(conf.Child("highRiskCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "highRiskCount {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SummaryCount? LowRiskCount
        // GraphQL -> lowRiskCount: SummaryCount (type)
        if (this.LowRiskCount != null) {
            var fspec = this.LowRiskCount.AsFieldSpec(conf.Child("lowRiskCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lowRiskCount {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SummaryCount? MediumRiskCount
        // GraphQL -> mediumRiskCount: SummaryCount (type)
        if (this.MediumRiskCount != null) {
            var fspec = this.MediumRiskCount.AsFieldSpec(conf.Child("mediumRiskCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mediumRiskCount {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SummaryCount? TotalCount
        // GraphQL -> totalCount: SummaryCount (type)
        if (this.TotalCount != null) {
            var fspec = this.TotalCount.AsFieldSpec(conf.Child("totalCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "totalCount {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SummaryCount? HighRiskCount
        // GraphQL -> highRiskCount: SummaryCount (type)
        if (ec.Includes("highRiskCount",false))
        {
            if(this.HighRiskCount == null) {

                this.HighRiskCount = new SummaryCount();
                this.HighRiskCount.ApplyExploratoryFieldSpec(ec.NewChild("highRiskCount"));

            } else {

                this.HighRiskCount.ApplyExploratoryFieldSpec(ec.NewChild("highRiskCount"));

            }
        }
        else if (this.HighRiskCount != null && ec.Excludes("highRiskCount",false))
        {
            this.HighRiskCount = null;
        }
        //      C# -> SummaryCount? LowRiskCount
        // GraphQL -> lowRiskCount: SummaryCount (type)
        if (ec.Includes("lowRiskCount",false))
        {
            if(this.LowRiskCount == null) {

                this.LowRiskCount = new SummaryCount();
                this.LowRiskCount.ApplyExploratoryFieldSpec(ec.NewChild("lowRiskCount"));

            } else {

                this.LowRiskCount.ApplyExploratoryFieldSpec(ec.NewChild("lowRiskCount"));

            }
        }
        else if (this.LowRiskCount != null && ec.Excludes("lowRiskCount",false))
        {
            this.LowRiskCount = null;
        }
        //      C# -> SummaryCount? MediumRiskCount
        // GraphQL -> mediumRiskCount: SummaryCount (type)
        if (ec.Includes("mediumRiskCount",false))
        {
            if(this.MediumRiskCount == null) {

                this.MediumRiskCount = new SummaryCount();
                this.MediumRiskCount.ApplyExploratoryFieldSpec(ec.NewChild("mediumRiskCount"));

            } else {

                this.MediumRiskCount.ApplyExploratoryFieldSpec(ec.NewChild("mediumRiskCount"));

            }
        }
        else if (this.MediumRiskCount != null && ec.Excludes("mediumRiskCount",false))
        {
            this.MediumRiskCount = null;
        }
        //      C# -> SummaryCount? TotalCount
        // GraphQL -> totalCount: SummaryCount (type)
        if (ec.Includes("totalCount",false))
        {
            if(this.TotalCount == null) {

                this.TotalCount = new SummaryCount();
                this.TotalCount.ApplyExploratoryFieldSpec(ec.NewChild("totalCount"));

            } else {

                this.TotalCount.ApplyExploratoryFieldSpec(ec.NewChild("totalCount"));

            }
        }
        else if (this.TotalCount != null && ec.Excludes("totalCount",false))
        {
            this.TotalCount = null;
        }
    }


    #endregion

    } // class PrincipalCounts
    
    #endregion

    public static class ListPrincipalCountsExtensions
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
            this List<PrincipalCounts> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PrincipalCounts> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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