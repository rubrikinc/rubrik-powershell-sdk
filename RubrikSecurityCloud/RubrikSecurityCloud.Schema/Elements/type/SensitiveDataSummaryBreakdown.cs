// SensitiveDataSummaryBreakdown.cs
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
    #region SensitiveDataSummaryBreakdown
    public class SensitiveDataSummaryBreakdown: BaseType
    {
        #region members

        //      C# -> List<PolicySummaryDetails>? DataCategories
        // GraphQL -> dataCategories: [PolicySummaryDetails!]! (type)
        [JsonProperty("dataCategories")]
        public List<PolicySummaryDetails>? DataCategories { get; set; }

        //      C# -> List<DataCategoryStats>? DataCategoryStats
        // GraphQL -> dataCategoryStats: [DataCategoryStats!]! (type)
        [JsonProperty("dataCategoryStats")]
        public List<DataCategoryStats>? DataCategoryStats { get; set; }

        //      C# -> List<DataTypeStats>? DataTypeStats
        // GraphQL -> dataTypeStats: [DataTypeStats!]! (type)
        [JsonProperty("dataTypeStats")]
        public List<DataTypeStats>? DataTypeStats { get; set; }

        //      C# -> List<AnalyzerResult>? DataTypes
        // GraphQL -> dataTypes: [AnalyzerResult!]! (type)
        [JsonProperty("dataTypes")]
        public List<AnalyzerResult>? DataTypes { get; set; }

        //      C# -> List<DocumentTypeSummary>? DocumentTypes
        // GraphQL -> documentTypes: [DocumentTypeSummary!]! (type)
        [JsonProperty("documentTypes")]
        public List<DocumentTypeSummary>? DocumentTypes { get; set; }

        //      C# -> List<MipLabelSummary>? MipLabels
        // GraphQL -> mipLabels: [MipLabelSummary!]! (type)
        [JsonProperty("mipLabels")]
        public List<MipLabelSummary>? MipLabels { get; set; }

        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        [JsonProperty("sensitiveFiles")]
        public SensitiveFiles? SensitiveFiles { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SensitiveDataSummaryBreakdown";
    }

    public SensitiveDataSummaryBreakdown Set(
        List<PolicySummaryDetails>? DataCategories = null,
        List<DataCategoryStats>? DataCategoryStats = null,
        List<DataTypeStats>? DataTypeStats = null,
        List<AnalyzerResult>? DataTypes = null,
        List<DocumentTypeSummary>? DocumentTypes = null,
        List<MipLabelSummary>? MipLabels = null,
        SensitiveFiles? SensitiveFiles = null
    ) 
    {
        if ( DataCategories != null ) {
            this.DataCategories = DataCategories;
        }
        if ( DataCategoryStats != null ) {
            this.DataCategoryStats = DataCategoryStats;
        }
        if ( DataTypeStats != null ) {
            this.DataTypeStats = DataTypeStats;
        }
        if ( DataTypes != null ) {
            this.DataTypes = DataTypes;
        }
        if ( DocumentTypes != null ) {
            this.DocumentTypes = DocumentTypes;
        }
        if ( MipLabels != null ) {
            this.MipLabels = MipLabels;
        }
        if ( SensitiveFiles != null ) {
            this.SensitiveFiles = SensitiveFiles;
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
        //      C# -> List<PolicySummaryDetails>? DataCategories
        // GraphQL -> dataCategories: [PolicySummaryDetails!]! (type)
        if (this.DataCategories != null) {
            var fspec = this.DataCategories.AsFieldSpec(conf.Child("dataCategories"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataCategories" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<DataCategoryStats>? DataCategoryStats
        // GraphQL -> dataCategoryStats: [DataCategoryStats!]! (type)
        if (this.DataCategoryStats != null) {
            var fspec = this.DataCategoryStats.AsFieldSpec(conf.Child("dataCategoryStats"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataCategoryStats" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<DataTypeStats>? DataTypeStats
        // GraphQL -> dataTypeStats: [DataTypeStats!]! (type)
        if (this.DataTypeStats != null) {
            var fspec = this.DataTypeStats.AsFieldSpec(conf.Child("dataTypeStats"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataTypeStats" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AnalyzerResult>? DataTypes
        // GraphQL -> dataTypes: [AnalyzerResult!]! (type)
        if (this.DataTypes != null) {
            var fspec = this.DataTypes.AsFieldSpec(conf.Child("dataTypes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataTypes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<DocumentTypeSummary>? DocumentTypes
        // GraphQL -> documentTypes: [DocumentTypeSummary!]! (type)
        if (this.DocumentTypes != null) {
            var fspec = this.DocumentTypes.AsFieldSpec(conf.Child("documentTypes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "documentTypes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<MipLabelSummary>? MipLabels
        // GraphQL -> mipLabels: [MipLabelSummary!]! (type)
        if (this.MipLabels != null) {
            var fspec = this.MipLabels.AsFieldSpec(conf.Child("mipLabels"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mipLabels" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        if (this.SensitiveFiles != null) {
            var fspec = this.SensitiveFiles.AsFieldSpec(conf.Child("sensitiveFiles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sensitiveFiles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<PolicySummaryDetails>? DataCategories
        // GraphQL -> dataCategories: [PolicySummaryDetails!]! (type)
        if (ec.Includes("dataCategories",false))
        {
            if(this.DataCategories == null) {

                this.DataCategories = new List<PolicySummaryDetails>();
                this.DataCategories.ApplyExploratoryFieldSpec(ec.NewChild("dataCategories"));

            } else {

                this.DataCategories.ApplyExploratoryFieldSpec(ec.NewChild("dataCategories"));

            }
        }
        else if (this.DataCategories != null && ec.Excludes("dataCategories",false))
        {
            this.DataCategories = null;
        }
        //      C# -> List<DataCategoryStats>? DataCategoryStats
        // GraphQL -> dataCategoryStats: [DataCategoryStats!]! (type)
        if (ec.Includes("dataCategoryStats",false))
        {
            if(this.DataCategoryStats == null) {

                this.DataCategoryStats = new List<DataCategoryStats>();
                this.DataCategoryStats.ApplyExploratoryFieldSpec(ec.NewChild("dataCategoryStats"));

            } else {

                this.DataCategoryStats.ApplyExploratoryFieldSpec(ec.NewChild("dataCategoryStats"));

            }
        }
        else if (this.DataCategoryStats != null && ec.Excludes("dataCategoryStats",false))
        {
            this.DataCategoryStats = null;
        }
        //      C# -> List<DataTypeStats>? DataTypeStats
        // GraphQL -> dataTypeStats: [DataTypeStats!]! (type)
        if (ec.Includes("dataTypeStats",false))
        {
            if(this.DataTypeStats == null) {

                this.DataTypeStats = new List<DataTypeStats>();
                this.DataTypeStats.ApplyExploratoryFieldSpec(ec.NewChild("dataTypeStats"));

            } else {

                this.DataTypeStats.ApplyExploratoryFieldSpec(ec.NewChild("dataTypeStats"));

            }
        }
        else if (this.DataTypeStats != null && ec.Excludes("dataTypeStats",false))
        {
            this.DataTypeStats = null;
        }
        //      C# -> List<AnalyzerResult>? DataTypes
        // GraphQL -> dataTypes: [AnalyzerResult!]! (type)
        if (ec.Includes("dataTypes",false))
        {
            if(this.DataTypes == null) {

                this.DataTypes = new List<AnalyzerResult>();
                this.DataTypes.ApplyExploratoryFieldSpec(ec.NewChild("dataTypes"));

            } else {

                this.DataTypes.ApplyExploratoryFieldSpec(ec.NewChild("dataTypes"));

            }
        }
        else if (this.DataTypes != null && ec.Excludes("dataTypes",false))
        {
            this.DataTypes = null;
        }
        //      C# -> List<DocumentTypeSummary>? DocumentTypes
        // GraphQL -> documentTypes: [DocumentTypeSummary!]! (type)
        if (ec.Includes("documentTypes",false))
        {
            if(this.DocumentTypes == null) {

                this.DocumentTypes = new List<DocumentTypeSummary>();
                this.DocumentTypes.ApplyExploratoryFieldSpec(ec.NewChild("documentTypes"));

            } else {

                this.DocumentTypes.ApplyExploratoryFieldSpec(ec.NewChild("documentTypes"));

            }
        }
        else if (this.DocumentTypes != null && ec.Excludes("documentTypes",false))
        {
            this.DocumentTypes = null;
        }
        //      C# -> List<MipLabelSummary>? MipLabels
        // GraphQL -> mipLabels: [MipLabelSummary!]! (type)
        if (ec.Includes("mipLabels",false))
        {
            if(this.MipLabels == null) {

                this.MipLabels = new List<MipLabelSummary>();
                this.MipLabels.ApplyExploratoryFieldSpec(ec.NewChild("mipLabels"));

            } else {

                this.MipLabels.ApplyExploratoryFieldSpec(ec.NewChild("mipLabels"));

            }
        }
        else if (this.MipLabels != null && ec.Excludes("mipLabels",false))
        {
            this.MipLabels = null;
        }
        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        if (ec.Includes("sensitiveFiles",false))
        {
            if(this.SensitiveFiles == null) {

                this.SensitiveFiles = new SensitiveFiles();
                this.SensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveFiles"));

            } else {

                this.SensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveFiles"));

            }
        }
        else if (this.SensitiveFiles != null && ec.Excludes("sensitiveFiles",false))
        {
            this.SensitiveFiles = null;
        }
    }


    #endregion

    } // class SensitiveDataSummaryBreakdown
    
    #endregion

    public static class ListSensitiveDataSummaryBreakdownExtensions
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
            this List<SensitiveDataSummaryBreakdown> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SensitiveDataSummaryBreakdown> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SensitiveDataSummaryBreakdown> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SensitiveDataSummaryBreakdown());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SensitiveDataSummaryBreakdown> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types