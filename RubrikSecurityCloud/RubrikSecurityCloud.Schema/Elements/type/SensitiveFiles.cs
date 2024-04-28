// SensitiveFiles.cs
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
    #region SensitiveFiles
    public class SensitiveFiles: BaseType
    {
        #region members

        //      C# -> SummaryCount? HighRiskFileCount
        // GraphQL -> highRiskFileCount: SummaryCount (type)
        [JsonProperty("highRiskFileCount")]
        public SummaryCount? HighRiskFileCount { get; set; }

        //      C# -> SummaryCount? LowRiskFileCount
        // GraphQL -> lowRiskFileCount: SummaryCount (type)
        [JsonProperty("lowRiskFileCount")]
        public SummaryCount? LowRiskFileCount { get; set; }

        //      C# -> SummaryCount? MediumRiskFileCount
        // GraphQL -> mediumRiskFileCount: SummaryCount (type)
        [JsonProperty("mediumRiskFileCount")]
        public SummaryCount? MediumRiskFileCount { get; set; }

        //      C# -> SummaryCount? TotalFileCount
        // GraphQL -> totalFileCount: SummaryCount (type)
        [JsonProperty("totalFileCount")]
        public SummaryCount? TotalFileCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SensitiveFiles";
    }

    public SensitiveFiles Set(
        SummaryCount? HighRiskFileCount = null,
        SummaryCount? LowRiskFileCount = null,
        SummaryCount? MediumRiskFileCount = null,
        SummaryCount? TotalFileCount = null
    ) 
    {
        if ( HighRiskFileCount != null ) {
            this.HighRiskFileCount = HighRiskFileCount;
        }
        if ( LowRiskFileCount != null ) {
            this.LowRiskFileCount = LowRiskFileCount;
        }
        if ( MediumRiskFileCount != null ) {
            this.MediumRiskFileCount = MediumRiskFileCount;
        }
        if ( TotalFileCount != null ) {
            this.TotalFileCount = TotalFileCount;
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
        //      C# -> SummaryCount? HighRiskFileCount
        // GraphQL -> highRiskFileCount: SummaryCount (type)
        if (this.HighRiskFileCount != null) {
            var fspec = this.HighRiskFileCount.AsFieldSpec(conf.Child("highRiskFileCount"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "highRiskFileCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SummaryCount? LowRiskFileCount
        // GraphQL -> lowRiskFileCount: SummaryCount (type)
        if (this.LowRiskFileCount != null) {
            var fspec = this.LowRiskFileCount.AsFieldSpec(conf.Child("lowRiskFileCount"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lowRiskFileCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SummaryCount? MediumRiskFileCount
        // GraphQL -> mediumRiskFileCount: SummaryCount (type)
        if (this.MediumRiskFileCount != null) {
            var fspec = this.MediumRiskFileCount.AsFieldSpec(conf.Child("mediumRiskFileCount"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mediumRiskFileCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SummaryCount? TotalFileCount
        // GraphQL -> totalFileCount: SummaryCount (type)
        if (this.TotalFileCount != null) {
            var fspec = this.TotalFileCount.AsFieldSpec(conf.Child("totalFileCount"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "totalFileCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SummaryCount? HighRiskFileCount
        // GraphQL -> highRiskFileCount: SummaryCount (type)
        if (ec.Includes("highRiskFileCount",false))
        {
            if(this.HighRiskFileCount == null) {

                this.HighRiskFileCount = new SummaryCount();
                this.HighRiskFileCount.ApplyExploratoryFieldSpec(ec.NewChild("highRiskFileCount"));

            } else {

                this.HighRiskFileCount.ApplyExploratoryFieldSpec(ec.NewChild("highRiskFileCount"));

            }
        }
        else if (this.HighRiskFileCount != null && ec.Excludes("highRiskFileCount",false))
        {
            this.HighRiskFileCount = null;
        }
        //      C# -> SummaryCount? LowRiskFileCount
        // GraphQL -> lowRiskFileCount: SummaryCount (type)
        if (ec.Includes("lowRiskFileCount",false))
        {
            if(this.LowRiskFileCount == null) {

                this.LowRiskFileCount = new SummaryCount();
                this.LowRiskFileCount.ApplyExploratoryFieldSpec(ec.NewChild("lowRiskFileCount"));

            } else {

                this.LowRiskFileCount.ApplyExploratoryFieldSpec(ec.NewChild("lowRiskFileCount"));

            }
        }
        else if (this.LowRiskFileCount != null && ec.Excludes("lowRiskFileCount",false))
        {
            this.LowRiskFileCount = null;
        }
        //      C# -> SummaryCount? MediumRiskFileCount
        // GraphQL -> mediumRiskFileCount: SummaryCount (type)
        if (ec.Includes("mediumRiskFileCount",false))
        {
            if(this.MediumRiskFileCount == null) {

                this.MediumRiskFileCount = new SummaryCount();
                this.MediumRiskFileCount.ApplyExploratoryFieldSpec(ec.NewChild("mediumRiskFileCount"));

            } else {

                this.MediumRiskFileCount.ApplyExploratoryFieldSpec(ec.NewChild("mediumRiskFileCount"));

            }
        }
        else if (this.MediumRiskFileCount != null && ec.Excludes("mediumRiskFileCount",false))
        {
            this.MediumRiskFileCount = null;
        }
        //      C# -> SummaryCount? TotalFileCount
        // GraphQL -> totalFileCount: SummaryCount (type)
        if (ec.Includes("totalFileCount",false))
        {
            if(this.TotalFileCount == null) {

                this.TotalFileCount = new SummaryCount();
                this.TotalFileCount.ApplyExploratoryFieldSpec(ec.NewChild("totalFileCount"));

            } else {

                this.TotalFileCount.ApplyExploratoryFieldSpec(ec.NewChild("totalFileCount"));

            }
        }
        else if (this.TotalFileCount != null && ec.Excludes("totalFileCount",false))
        {
            this.TotalFileCount = null;
        }
    }


    #endregion

    } // class SensitiveFiles
    
    #endregion

    public static class ListSensitiveFilesExtensions
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
            this List<SensitiveFiles> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SensitiveFiles> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SensitiveFiles> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SensitiveFiles());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SensitiveFiles> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types