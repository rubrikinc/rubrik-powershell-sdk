// SensitivityInfo.cs
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
    #region SensitivityInfo
    public class SensitivityInfo: BaseType
    {
        #region members

        //      C# -> System.Int64? SensitiveFilesCount
        // GraphQL -> sensitiveFilesCount: Long (scalar)
        [JsonProperty("sensitiveFilesCount")]
        public System.Int64? SensitiveFilesCount { get; set; }

        //      C# -> List<AnalyzerGroupResult>? AnalyzerGroupResults
        // GraphQL -> analyzerGroupResults: [AnalyzerGroupResult!]! (type)
        [JsonProperty("analyzerGroupResults")]
        public List<AnalyzerGroupResult>? AnalyzerGroupResults { get; set; }

        //      C# -> SensitiveHits? SensitiveHits
        // GraphQL -> sensitiveHits: SensitiveHits (type)
        [JsonProperty("sensitiveHits")]
        public SensitiveHits? SensitiveHits { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SensitivityInfo";
    }

    public SensitivityInfo Set(
        System.Int64? SensitiveFilesCount = null,
        List<AnalyzerGroupResult>? AnalyzerGroupResults = null,
        SensitiveHits? SensitiveHits = null
    ) 
    {
        if ( SensitiveFilesCount != null ) {
            this.SensitiveFilesCount = SensitiveFilesCount;
        }
        if ( AnalyzerGroupResults != null ) {
            this.AnalyzerGroupResults = AnalyzerGroupResults;
        }
        if ( SensitiveHits != null ) {
            this.SensitiveHits = SensitiveHits;
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
        //      C# -> System.Int64? SensitiveFilesCount
        // GraphQL -> sensitiveFilesCount: Long (scalar)
        if (this.SensitiveFilesCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sensitiveFilesCount\n" ;
            } else {
                s += ind + "sensitiveFilesCount\n" ;
            }
        }
        //      C# -> List<AnalyzerGroupResult>? AnalyzerGroupResults
        // GraphQL -> analyzerGroupResults: [AnalyzerGroupResult!]! (type)
        if (this.AnalyzerGroupResults != null) {
            var fspec = this.AnalyzerGroupResults.AsFieldSpec(conf.Child("analyzerGroupResults"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "analyzerGroupResults" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SensitiveHits? SensitiveHits
        // GraphQL -> sensitiveHits: SensitiveHits (type)
        if (this.SensitiveHits != null) {
            var fspec = this.SensitiveHits.AsFieldSpec(conf.Child("sensitiveHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sensitiveHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? SensitiveFilesCount
        // GraphQL -> sensitiveFilesCount: Long (scalar)
        if (ec.Includes("sensitiveFilesCount",true))
        {
            if(this.SensitiveFilesCount == null) {

                this.SensitiveFilesCount = new System.Int64();

            } else {


            }
        }
        else if (this.SensitiveFilesCount != null && ec.Excludes("sensitiveFilesCount",true))
        {
            this.SensitiveFilesCount = null;
        }
        //      C# -> List<AnalyzerGroupResult>? AnalyzerGroupResults
        // GraphQL -> analyzerGroupResults: [AnalyzerGroupResult!]! (type)
        if (ec.Includes("analyzerGroupResults",false))
        {
            if(this.AnalyzerGroupResults == null) {

                this.AnalyzerGroupResults = new List<AnalyzerGroupResult>();
                this.AnalyzerGroupResults.ApplyExploratoryFieldSpec(ec.NewChild("analyzerGroupResults"));

            } else {

                this.AnalyzerGroupResults.ApplyExploratoryFieldSpec(ec.NewChild("analyzerGroupResults"));

            }
        }
        else if (this.AnalyzerGroupResults != null && ec.Excludes("analyzerGroupResults",false))
        {
            this.AnalyzerGroupResults = null;
        }
        //      C# -> SensitiveHits? SensitiveHits
        // GraphQL -> sensitiveHits: SensitiveHits (type)
        if (ec.Includes("sensitiveHits",false))
        {
            if(this.SensitiveHits == null) {

                this.SensitiveHits = new SensitiveHits();
                this.SensitiveHits.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveHits"));

            } else {

                this.SensitiveHits.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveHits"));

            }
        }
        else if (this.SensitiveHits != null && ec.Excludes("sensitiveHits",false))
        {
            this.SensitiveHits = null;
        }
    }


    #endregion

    } // class SensitivityInfo
    
    #endregion

    public static class ListSensitivityInfoExtensions
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
            this List<SensitivityInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SensitivityInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SensitivityInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SensitivityInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SensitivityInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types