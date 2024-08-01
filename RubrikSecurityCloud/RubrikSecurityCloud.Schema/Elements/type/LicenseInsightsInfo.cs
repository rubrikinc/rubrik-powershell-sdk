// LicenseInsightsInfo.cs
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
    #region LicenseInsightsInfo
    public class LicenseInsightsInfo: BaseType
    {
        #region members

        //      C# -> LicenseProduct? Product
        // GraphQL -> product: LicenseProduct! (enum)
        [JsonProperty("product")]
        public LicenseProduct? Product { get; set; }

        //      C# -> LicenseErrorInfo? ErrorInfo
        // GraphQL -> errorInfo: LicenseErrorInfo (type)
        [JsonProperty("errorInfo")]
        public LicenseErrorInfo? ErrorInfo { get; set; }

        //      C# -> List<LicenseExpiryInsight>? LicenseExpiryInsights
        // GraphQL -> licenseExpiryInsights: [LicenseExpiryInsight!]! (type)
        [JsonProperty("licenseExpiryInsights")]
        public List<LicenseExpiryInsight>? LicenseExpiryInsights { get; set; }

        //      C# -> List<LicenseOverageInsight>? LicenseOverageInsights
        // GraphQL -> licenseOverageInsights: [LicenseOverageInsight!]! (type)
        [JsonProperty("licenseOverageInsights")]
        public List<LicenseOverageInsight>? LicenseOverageInsights { get; set; }

        //      C# -> List<LicenseThresholdCapacityInsight>? LicenseThresholdCapacityInsights
        // GraphQL -> licenseThresholdCapacityInsights: [LicenseThresholdCapacityInsight!]! (type)
        [JsonProperty("licenseThresholdCapacityInsights")]
        public List<LicenseThresholdCapacityInsight>? LicenseThresholdCapacityInsights { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LicenseInsightsInfo";
    }

    public LicenseInsightsInfo Set(
        LicenseProduct? Product = null,
        LicenseErrorInfo? ErrorInfo = null,
        List<LicenseExpiryInsight>? LicenseExpiryInsights = null,
        List<LicenseOverageInsight>? LicenseOverageInsights = null,
        List<LicenseThresholdCapacityInsight>? LicenseThresholdCapacityInsights = null
    ) 
    {
        if ( Product != null ) {
            this.Product = Product;
        }
        if ( ErrorInfo != null ) {
            this.ErrorInfo = ErrorInfo;
        }
        if ( LicenseExpiryInsights != null ) {
            this.LicenseExpiryInsights = LicenseExpiryInsights;
        }
        if ( LicenseOverageInsights != null ) {
            this.LicenseOverageInsights = LicenseOverageInsights;
        }
        if ( LicenseThresholdCapacityInsights != null ) {
            this.LicenseThresholdCapacityInsights = LicenseThresholdCapacityInsights;
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
        //      C# -> LicenseProduct? Product
        // GraphQL -> product: LicenseProduct! (enum)
        if (this.Product != null) {
            if (conf.Flat) {
                s += conf.Prefix + "product\n" ;
            } else {
                s += ind + "product\n" ;
            }
        }
        //      C# -> LicenseErrorInfo? ErrorInfo
        // GraphQL -> errorInfo: LicenseErrorInfo (type)
        if (this.ErrorInfo != null) {
            var fspec = this.ErrorInfo.AsFieldSpec(conf.Child("errorInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "errorInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<LicenseExpiryInsight>? LicenseExpiryInsights
        // GraphQL -> licenseExpiryInsights: [LicenseExpiryInsight!]! (type)
        if (this.LicenseExpiryInsights != null) {
            var fspec = this.LicenseExpiryInsights.AsFieldSpec(conf.Child("licenseExpiryInsights"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "licenseExpiryInsights" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<LicenseOverageInsight>? LicenseOverageInsights
        // GraphQL -> licenseOverageInsights: [LicenseOverageInsight!]! (type)
        if (this.LicenseOverageInsights != null) {
            var fspec = this.LicenseOverageInsights.AsFieldSpec(conf.Child("licenseOverageInsights"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "licenseOverageInsights" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<LicenseThresholdCapacityInsight>? LicenseThresholdCapacityInsights
        // GraphQL -> licenseThresholdCapacityInsights: [LicenseThresholdCapacityInsight!]! (type)
        if (this.LicenseThresholdCapacityInsights != null) {
            var fspec = this.LicenseThresholdCapacityInsights.AsFieldSpec(conf.Child("licenseThresholdCapacityInsights"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "licenseThresholdCapacityInsights" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> LicenseProduct? Product
        // GraphQL -> product: LicenseProduct! (enum)
        if (ec.Includes("product",true))
        {
            if(this.Product == null) {

                this.Product = new LicenseProduct();

            } else {


            }
        }
        else if (this.Product != null && ec.Excludes("product",true))
        {
            this.Product = null;
        }
        //      C# -> LicenseErrorInfo? ErrorInfo
        // GraphQL -> errorInfo: LicenseErrorInfo (type)
        if (ec.Includes("errorInfo",false))
        {
            if(this.ErrorInfo == null) {

                this.ErrorInfo = new LicenseErrorInfo();
                this.ErrorInfo.ApplyExploratoryFieldSpec(ec.NewChild("errorInfo"));

            } else {

                this.ErrorInfo.ApplyExploratoryFieldSpec(ec.NewChild("errorInfo"));

            }
        }
        else if (this.ErrorInfo != null && ec.Excludes("errorInfo",false))
        {
            this.ErrorInfo = null;
        }
        //      C# -> List<LicenseExpiryInsight>? LicenseExpiryInsights
        // GraphQL -> licenseExpiryInsights: [LicenseExpiryInsight!]! (type)
        if (ec.Includes("licenseExpiryInsights",false))
        {
            if(this.LicenseExpiryInsights == null) {

                this.LicenseExpiryInsights = new List<LicenseExpiryInsight>();
                this.LicenseExpiryInsights.ApplyExploratoryFieldSpec(ec.NewChild("licenseExpiryInsights"));

            } else {

                this.LicenseExpiryInsights.ApplyExploratoryFieldSpec(ec.NewChild("licenseExpiryInsights"));

            }
        }
        else if (this.LicenseExpiryInsights != null && ec.Excludes("licenseExpiryInsights",false))
        {
            this.LicenseExpiryInsights = null;
        }
        //      C# -> List<LicenseOverageInsight>? LicenseOverageInsights
        // GraphQL -> licenseOverageInsights: [LicenseOverageInsight!]! (type)
        if (ec.Includes("licenseOverageInsights",false))
        {
            if(this.LicenseOverageInsights == null) {

                this.LicenseOverageInsights = new List<LicenseOverageInsight>();
                this.LicenseOverageInsights.ApplyExploratoryFieldSpec(ec.NewChild("licenseOverageInsights"));

            } else {

                this.LicenseOverageInsights.ApplyExploratoryFieldSpec(ec.NewChild("licenseOverageInsights"));

            }
        }
        else if (this.LicenseOverageInsights != null && ec.Excludes("licenseOverageInsights",false))
        {
            this.LicenseOverageInsights = null;
        }
        //      C# -> List<LicenseThresholdCapacityInsight>? LicenseThresholdCapacityInsights
        // GraphQL -> licenseThresholdCapacityInsights: [LicenseThresholdCapacityInsight!]! (type)
        if (ec.Includes("licenseThresholdCapacityInsights",false))
        {
            if(this.LicenseThresholdCapacityInsights == null) {

                this.LicenseThresholdCapacityInsights = new List<LicenseThresholdCapacityInsight>();
                this.LicenseThresholdCapacityInsights.ApplyExploratoryFieldSpec(ec.NewChild("licenseThresholdCapacityInsights"));

            } else {

                this.LicenseThresholdCapacityInsights.ApplyExploratoryFieldSpec(ec.NewChild("licenseThresholdCapacityInsights"));

            }
        }
        else if (this.LicenseThresholdCapacityInsights != null && ec.Excludes("licenseThresholdCapacityInsights",false))
        {
            this.LicenseThresholdCapacityInsights = null;
        }
    }


    #endregion

    } // class LicenseInsightsInfo
    
    #endregion

    public static class ListLicenseInsightsInfoExtensions
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
            this List<LicenseInsightsInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LicenseInsightsInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LicenseInsightsInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LicenseInsightsInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LicenseInsightsInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types