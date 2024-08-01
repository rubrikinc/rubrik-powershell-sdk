// ChartDataResult.cs
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
    #region ChartDataResult
    public class ChartDataResult: BaseType
    {
        #region members

        //      C# -> ChartType? ChartType
        // GraphQL -> chartType: ChartType! (enum)
        [JsonProperty("chartType")]
        public ChartType? ChartType { get; set; }

        //      C# -> List<ChartPrimaryGroupBy>? ChartData
        // GraphQL -> chartData: [ChartPrimaryGroupBy!]! (type)
        [JsonProperty("chartData")]
        public List<ChartPrimaryGroupBy>? ChartData { get; set; }

        //      C# -> List<MetadataV2>? Metadata
        // GraphQL -> metadata: [MetadataV2!]! (type)
        [JsonProperty("metadata")]
        public List<MetadataV2>? Metadata { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ChartDataResult";
    }

    public ChartDataResult Set(
        ChartType? ChartType = null,
        List<ChartPrimaryGroupBy>? ChartData = null,
        List<MetadataV2>? Metadata = null
    ) 
    {
        if ( ChartType != null ) {
            this.ChartType = ChartType;
        }
        if ( ChartData != null ) {
            this.ChartData = ChartData;
        }
        if ( Metadata != null ) {
            this.Metadata = Metadata;
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
        //      C# -> ChartType? ChartType
        // GraphQL -> chartType: ChartType! (enum)
        if (this.ChartType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "chartType\n" ;
            } else {
                s += ind + "chartType\n" ;
            }
        }
        //      C# -> List<ChartPrimaryGroupBy>? ChartData
        // GraphQL -> chartData: [ChartPrimaryGroupBy!]! (type)
        if (this.ChartData != null) {
            var fspec = this.ChartData.AsFieldSpec(conf.Child("chartData"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "chartData" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<MetadataV2>? Metadata
        // GraphQL -> metadata: [MetadataV2!]! (type)
        if (this.Metadata != null) {
            var fspec = this.Metadata.AsFieldSpec(conf.Child("metadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "metadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ChartType? ChartType
        // GraphQL -> chartType: ChartType! (enum)
        if (ec.Includes("chartType",true))
        {
            if(this.ChartType == null) {

                this.ChartType = new ChartType();

            } else {


            }
        }
        else if (this.ChartType != null && ec.Excludes("chartType",true))
        {
            this.ChartType = null;
        }
        //      C# -> List<ChartPrimaryGroupBy>? ChartData
        // GraphQL -> chartData: [ChartPrimaryGroupBy!]! (type)
        if (ec.Includes("chartData",false))
        {
            if(this.ChartData == null) {

                this.ChartData = new List<ChartPrimaryGroupBy>();
                this.ChartData.ApplyExploratoryFieldSpec(ec.NewChild("chartData"));

            } else {

                this.ChartData.ApplyExploratoryFieldSpec(ec.NewChild("chartData"));

            }
        }
        else if (this.ChartData != null && ec.Excludes("chartData",false))
        {
            this.ChartData = null;
        }
        //      C# -> List<MetadataV2>? Metadata
        // GraphQL -> metadata: [MetadataV2!]! (type)
        if (ec.Includes("metadata",false))
        {
            if(this.Metadata == null) {

                this.Metadata = new List<MetadataV2>();
                this.Metadata.ApplyExploratoryFieldSpec(ec.NewChild("metadata"));

            } else {

                this.Metadata.ApplyExploratoryFieldSpec(ec.NewChild("metadata"));

            }
        }
        else if (this.Metadata != null && ec.Excludes("metadata",false))
        {
            this.Metadata = null;
        }
    }


    #endregion

    } // class ChartDataResult
    
    #endregion

    public static class ListChartDataResultExtensions
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
            this List<ChartDataResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ChartDataResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ChartDataResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ChartDataResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ChartDataResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types