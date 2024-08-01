// LicenseThresholdCapacityInsight.cs
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
    #region LicenseThresholdCapacityInsight
    public class LicenseThresholdCapacityInsight: BaseType
    {
        #region members

        //      C# -> LicenseInsightsSeverity? Severity
        // GraphQL -> severity: LicenseInsightsSeverity! (enum)
        [JsonProperty("severity")]
        public LicenseInsightsSeverity? Severity { get; set; }

        //      C# -> LicenseMeasurementUnit? Uom
        // GraphQL -> uom: LicenseMeasurementUnit! (enum)
        [JsonProperty("uom")]
        public LicenseMeasurementUnit? Uom { get; set; }

        //      C# -> System.Int64? EntitledQuantity
        // GraphQL -> entitledQuantity: Long! (scalar)
        [JsonProperty("entitledQuantity")]
        public System.Int64? EntitledQuantity { get; set; }

        //      C# -> System.String? LicenseName
        // GraphQL -> licenseName: String! (scalar)
        [JsonProperty("licenseName")]
        public System.String? LicenseName { get; set; }

        //      C# -> System.Int32? ThresholdPercentage
        // GraphQL -> thresholdPercentage: Int! (scalar)
        [JsonProperty("thresholdPercentage")]
        public System.Int32? ThresholdPercentage { get; set; }

        //      C# -> System.Int64? UsedQuantity
        // GraphQL -> usedQuantity: Long! (scalar)
        [JsonProperty("usedQuantity")]
        public System.Int64? UsedQuantity { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LicenseThresholdCapacityInsight";
    }

    public LicenseThresholdCapacityInsight Set(
        LicenseInsightsSeverity? Severity = null,
        LicenseMeasurementUnit? Uom = null,
        System.Int64? EntitledQuantity = null,
        System.String? LicenseName = null,
        System.Int32? ThresholdPercentage = null,
        System.Int64? UsedQuantity = null
    ) 
    {
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( Uom != null ) {
            this.Uom = Uom;
        }
        if ( EntitledQuantity != null ) {
            this.EntitledQuantity = EntitledQuantity;
        }
        if ( LicenseName != null ) {
            this.LicenseName = LicenseName;
        }
        if ( ThresholdPercentage != null ) {
            this.ThresholdPercentage = ThresholdPercentage;
        }
        if ( UsedQuantity != null ) {
            this.UsedQuantity = UsedQuantity;
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
        //      C# -> LicenseInsightsSeverity? Severity
        // GraphQL -> severity: LicenseInsightsSeverity! (enum)
        if (this.Severity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "severity\n" ;
            } else {
                s += ind + "severity\n" ;
            }
        }
        //      C# -> LicenseMeasurementUnit? Uom
        // GraphQL -> uom: LicenseMeasurementUnit! (enum)
        if (this.Uom != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uom\n" ;
            } else {
                s += ind + "uom\n" ;
            }
        }
        //      C# -> System.Int64? EntitledQuantity
        // GraphQL -> entitledQuantity: Long! (scalar)
        if (this.EntitledQuantity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "entitledQuantity\n" ;
            } else {
                s += ind + "entitledQuantity\n" ;
            }
        }
        //      C# -> System.String? LicenseName
        // GraphQL -> licenseName: String! (scalar)
        if (this.LicenseName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "licenseName\n" ;
            } else {
                s += ind + "licenseName\n" ;
            }
        }
        //      C# -> System.Int32? ThresholdPercentage
        // GraphQL -> thresholdPercentage: Int! (scalar)
        if (this.ThresholdPercentage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "thresholdPercentage\n" ;
            } else {
                s += ind + "thresholdPercentage\n" ;
            }
        }
        //      C# -> System.Int64? UsedQuantity
        // GraphQL -> usedQuantity: Long! (scalar)
        if (this.UsedQuantity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usedQuantity\n" ;
            } else {
                s += ind + "usedQuantity\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> LicenseInsightsSeverity? Severity
        // GraphQL -> severity: LicenseInsightsSeverity! (enum)
        if (ec.Includes("severity",true))
        {
            if(this.Severity == null) {

                this.Severity = new LicenseInsightsSeverity();

            } else {


            }
        }
        else if (this.Severity != null && ec.Excludes("severity",true))
        {
            this.Severity = null;
        }
        //      C# -> LicenseMeasurementUnit? Uom
        // GraphQL -> uom: LicenseMeasurementUnit! (enum)
        if (ec.Includes("uom",true))
        {
            if(this.Uom == null) {

                this.Uom = new LicenseMeasurementUnit();

            } else {


            }
        }
        else if (this.Uom != null && ec.Excludes("uom",true))
        {
            this.Uom = null;
        }
        //      C# -> System.Int64? EntitledQuantity
        // GraphQL -> entitledQuantity: Long! (scalar)
        if (ec.Includes("entitledQuantity",true))
        {
            if(this.EntitledQuantity == null) {

                this.EntitledQuantity = new System.Int64();

            } else {


            }
        }
        else if (this.EntitledQuantity != null && ec.Excludes("entitledQuantity",true))
        {
            this.EntitledQuantity = null;
        }
        //      C# -> System.String? LicenseName
        // GraphQL -> licenseName: String! (scalar)
        if (ec.Includes("licenseName",true))
        {
            if(this.LicenseName == null) {

                this.LicenseName = "FETCH";

            } else {


            }
        }
        else if (this.LicenseName != null && ec.Excludes("licenseName",true))
        {
            this.LicenseName = null;
        }
        //      C# -> System.Int32? ThresholdPercentage
        // GraphQL -> thresholdPercentage: Int! (scalar)
        if (ec.Includes("thresholdPercentage",true))
        {
            if(this.ThresholdPercentage == null) {

                this.ThresholdPercentage = Int32.MinValue;

            } else {


            }
        }
        else if (this.ThresholdPercentage != null && ec.Excludes("thresholdPercentage",true))
        {
            this.ThresholdPercentage = null;
        }
        //      C# -> System.Int64? UsedQuantity
        // GraphQL -> usedQuantity: Long! (scalar)
        if (ec.Includes("usedQuantity",true))
        {
            if(this.UsedQuantity == null) {

                this.UsedQuantity = new System.Int64();

            } else {


            }
        }
        else if (this.UsedQuantity != null && ec.Excludes("usedQuantity",true))
        {
            this.UsedQuantity = null;
        }
    }


    #endregion

    } // class LicenseThresholdCapacityInsight
    
    #endregion

    public static class ListLicenseThresholdCapacityInsightExtensions
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
            this List<LicenseThresholdCapacityInsight> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LicenseThresholdCapacityInsight> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LicenseThresholdCapacityInsight> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LicenseThresholdCapacityInsight());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LicenseThresholdCapacityInsight> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types