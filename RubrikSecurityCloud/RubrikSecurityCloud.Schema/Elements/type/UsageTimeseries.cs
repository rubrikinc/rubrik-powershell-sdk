// UsageTimeseries.cs
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
    #region UsageTimeseries
    public class UsageTimeseries: BaseType
    {
        #region members

        //      C# -> List<UsageDatapoint>? LicenseTimeseries
        // GraphQL -> licenseTimeseries: [UsageDatapoint!]! (type)
        [JsonProperty("licenseTimeseries")]
        public List<UsageDatapoint>? LicenseTimeseries { get; set; }

        //      C# -> List<UsageDatapoint>? UsageTimeseriesField
        // GraphQL -> usageTimeseries: [UsageDatapoint!]! (type)
        [JsonProperty("usageTimeseries")]
        public List<UsageDatapoint>? UsageTimeseriesField { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UsageTimeseries";
    }

    public UsageTimeseries Set(
        List<UsageDatapoint>? LicenseTimeseries = null,
        List<UsageDatapoint>? UsageTimeseriesField = null
    ) 
    {
        if ( LicenseTimeseries != null ) {
            this.LicenseTimeseries = LicenseTimeseries;
        }
        if ( UsageTimeseriesField != null ) {
            this.UsageTimeseriesField = UsageTimeseriesField;
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
        //      C# -> List<UsageDatapoint>? LicenseTimeseries
        // GraphQL -> licenseTimeseries: [UsageDatapoint!]! (type)
        if (this.LicenseTimeseries != null) {
            var fspec = this.LicenseTimeseries.AsFieldSpec(conf.Child("licenseTimeseries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "licenseTimeseries" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<UsageDatapoint>? UsageTimeseriesField
        // GraphQL -> usageTimeseries: [UsageDatapoint!]! (type)
        if (this.UsageTimeseriesField != null) {
            var fspec = this.UsageTimeseriesField.AsFieldSpec(conf.Child("usageTimeseries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "usageTimeseries" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<UsageDatapoint>? LicenseTimeseries
        // GraphQL -> licenseTimeseries: [UsageDatapoint!]! (type)
        if (ec.Includes("licenseTimeseries",false))
        {
            if(this.LicenseTimeseries == null) {

                this.LicenseTimeseries = new List<UsageDatapoint>();
                this.LicenseTimeseries.ApplyExploratoryFieldSpec(ec.NewChild("licenseTimeseries"));

            } else {

                this.LicenseTimeseries.ApplyExploratoryFieldSpec(ec.NewChild("licenseTimeseries"));

            }
        }
        else if (this.LicenseTimeseries != null && ec.Excludes("licenseTimeseries",false))
        {
            this.LicenseTimeseries = null;
        }
        //      C# -> List<UsageDatapoint>? UsageTimeseriesField
        // GraphQL -> usageTimeseries: [UsageDatapoint!]! (type)
        if (ec.Includes("usageTimeseries",false))
        {
            if(this.UsageTimeseriesField == null) {

                this.UsageTimeseriesField = new List<UsageDatapoint>();
                this.UsageTimeseriesField.ApplyExploratoryFieldSpec(ec.NewChild("usageTimeseries"));

            } else {

                this.UsageTimeseriesField.ApplyExploratoryFieldSpec(ec.NewChild("usageTimeseries"));

            }
        }
        else if (this.UsageTimeseriesField != null && ec.Excludes("usageTimeseries",false))
        {
            this.UsageTimeseriesField = null;
        }
    }


    #endregion

    } // class UsageTimeseries
    
    #endregion

    public static class ListUsageTimeseriesExtensions
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
            this List<UsageTimeseries> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UsageTimeseries> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UsageTimeseries> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UsageTimeseries());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UsageTimeseries> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types