// ClusterArchivalSpec.cs
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
    #region ClusterArchivalSpec
    public class ClusterArchivalSpec: BaseType
    {
        #region members

        //      C# -> TargetType? ArchivalLocationType
        // GraphQL -> archivalLocationType: TargetType! (enum)
        [JsonProperty("archivalLocationType")]
        public TargetType? ArchivalLocationType { get; set; }

        //      C# -> List<RetentionUnit>? Frequencies
        // GraphQL -> frequencies: [RetentionUnit!]! (enum)
        [JsonProperty("frequencies")]
        public List<RetentionUnit>? Frequencies { get; set; }

        //      C# -> RetentionUnit? ThresholdUnit
        // GraphQL -> thresholdUnit: RetentionUnit! (enum)
        [JsonProperty("thresholdUnit")]
        public RetentionUnit? ThresholdUnit { get; set; }

        //      C# -> System.String? ArchivalLocationId
        // GraphQL -> archivalLocationId: String! (scalar)
        [JsonProperty("archivalLocationId")]
        public System.String? ArchivalLocationId { get; set; }

        //      C# -> System.String? ArchivalLocationName
        // GraphQL -> archivalLocationName: String! (scalar)
        [JsonProperty("archivalLocationName")]
        public System.String? ArchivalLocationName { get; set; }

        //      C# -> System.Int32? Threshold
        // GraphQL -> threshold: Int! (scalar)
        [JsonProperty("threshold")]
        public System.Int32? Threshold { get; set; }

        //      C# -> ArchivalTieringSpec? ArchivalTieringSpec
        // GraphQL -> archivalTieringSpec: ArchivalTieringSpec (type)
        [JsonProperty("archivalTieringSpec")]
        public ArchivalTieringSpec? ArchivalTieringSpec { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterArchivalSpec";
    }

    public ClusterArchivalSpec Set(
        TargetType? ArchivalLocationType = null,
        List<RetentionUnit>? Frequencies = null,
        RetentionUnit? ThresholdUnit = null,
        System.String? ArchivalLocationId = null,
        System.String? ArchivalLocationName = null,
        System.Int32? Threshold = null,
        ArchivalTieringSpec? ArchivalTieringSpec = null
    ) 
    {
        if ( ArchivalLocationType != null ) {
            this.ArchivalLocationType = ArchivalLocationType;
        }
        if ( Frequencies != null ) {
            this.Frequencies = Frequencies;
        }
        if ( ThresholdUnit != null ) {
            this.ThresholdUnit = ThresholdUnit;
        }
        if ( ArchivalLocationId != null ) {
            this.ArchivalLocationId = ArchivalLocationId;
        }
        if ( ArchivalLocationName != null ) {
            this.ArchivalLocationName = ArchivalLocationName;
        }
        if ( Threshold != null ) {
            this.Threshold = Threshold;
        }
        if ( ArchivalTieringSpec != null ) {
            this.ArchivalTieringSpec = ArchivalTieringSpec;
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
        //      C# -> TargetType? ArchivalLocationType
        // GraphQL -> archivalLocationType: TargetType! (enum)
        if (this.ArchivalLocationType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archivalLocationType\n" ;
            } else {
                s += ind + "archivalLocationType\n" ;
            }
        }
        //      C# -> List<RetentionUnit>? Frequencies
        // GraphQL -> frequencies: [RetentionUnit!]! (enum)
        if (this.Frequencies != null) {
            if (conf.Flat) {
                s += conf.Prefix + "frequencies\n" ;
            } else {
                s += ind + "frequencies\n" ;
            }
        }
        //      C# -> RetentionUnit? ThresholdUnit
        // GraphQL -> thresholdUnit: RetentionUnit! (enum)
        if (this.ThresholdUnit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "thresholdUnit\n" ;
            } else {
                s += ind + "thresholdUnit\n" ;
            }
        }
        //      C# -> System.String? ArchivalLocationId
        // GraphQL -> archivalLocationId: String! (scalar)
        if (this.ArchivalLocationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archivalLocationId\n" ;
            } else {
                s += ind + "archivalLocationId\n" ;
            }
        }
        //      C# -> System.String? ArchivalLocationName
        // GraphQL -> archivalLocationName: String! (scalar)
        if (this.ArchivalLocationName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archivalLocationName\n" ;
            } else {
                s += ind + "archivalLocationName\n" ;
            }
        }
        //      C# -> System.Int32? Threshold
        // GraphQL -> threshold: Int! (scalar)
        if (this.Threshold != null) {
            if (conf.Flat) {
                s += conf.Prefix + "threshold\n" ;
            } else {
                s += ind + "threshold\n" ;
            }
        }
        //      C# -> ArchivalTieringSpec? ArchivalTieringSpec
        // GraphQL -> archivalTieringSpec: ArchivalTieringSpec (type)
        if (this.ArchivalTieringSpec != null) {
            var fspec = this.ArchivalTieringSpec.AsFieldSpec(conf.Child("archivalTieringSpec"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "archivalTieringSpec" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> TargetType? ArchivalLocationType
        // GraphQL -> archivalLocationType: TargetType! (enum)
        if (ec.Includes("archivalLocationType",true))
        {
            if(this.ArchivalLocationType == null) {

                this.ArchivalLocationType = new TargetType();

            } else {


            }
        }
        else if (this.ArchivalLocationType != null && ec.Excludes("archivalLocationType",true))
        {
            this.ArchivalLocationType = null;
        }
        //      C# -> List<RetentionUnit>? Frequencies
        // GraphQL -> frequencies: [RetentionUnit!]! (enum)
        if (ec.Includes("frequencies",true))
        {
            if(this.Frequencies == null) {

                this.Frequencies = new List<RetentionUnit>();

            } else {


            }
        }
        else if (this.Frequencies != null && ec.Excludes("frequencies",true))
        {
            this.Frequencies = null;
        }
        //      C# -> RetentionUnit? ThresholdUnit
        // GraphQL -> thresholdUnit: RetentionUnit! (enum)
        if (ec.Includes("thresholdUnit",true))
        {
            if(this.ThresholdUnit == null) {

                this.ThresholdUnit = new RetentionUnit();

            } else {


            }
        }
        else if (this.ThresholdUnit != null && ec.Excludes("thresholdUnit",true))
        {
            this.ThresholdUnit = null;
        }
        //      C# -> System.String? ArchivalLocationId
        // GraphQL -> archivalLocationId: String! (scalar)
        if (ec.Includes("archivalLocationId",true))
        {
            if(this.ArchivalLocationId == null) {

                this.ArchivalLocationId = "FETCH";

            } else {


            }
        }
        else if (this.ArchivalLocationId != null && ec.Excludes("archivalLocationId",true))
        {
            this.ArchivalLocationId = null;
        }
        //      C# -> System.String? ArchivalLocationName
        // GraphQL -> archivalLocationName: String! (scalar)
        if (ec.Includes("archivalLocationName",true))
        {
            if(this.ArchivalLocationName == null) {

                this.ArchivalLocationName = "FETCH";

            } else {


            }
        }
        else if (this.ArchivalLocationName != null && ec.Excludes("archivalLocationName",true))
        {
            this.ArchivalLocationName = null;
        }
        //      C# -> System.Int32? Threshold
        // GraphQL -> threshold: Int! (scalar)
        if (ec.Includes("threshold",true))
        {
            if(this.Threshold == null) {

                this.Threshold = Int32.MinValue;

            } else {


            }
        }
        else if (this.Threshold != null && ec.Excludes("threshold",true))
        {
            this.Threshold = null;
        }
        //      C# -> ArchivalTieringSpec? ArchivalTieringSpec
        // GraphQL -> archivalTieringSpec: ArchivalTieringSpec (type)
        if (ec.Includes("archivalTieringSpec",false))
        {
            if(this.ArchivalTieringSpec == null) {

                this.ArchivalTieringSpec = new ArchivalTieringSpec();
                this.ArchivalTieringSpec.ApplyExploratoryFieldSpec(ec.NewChild("archivalTieringSpec"));

            } else {

                this.ArchivalTieringSpec.ApplyExploratoryFieldSpec(ec.NewChild("archivalTieringSpec"));

            }
        }
        else if (this.ArchivalTieringSpec != null && ec.Excludes("archivalTieringSpec",false))
        {
            this.ArchivalTieringSpec = null;
        }
    }


    #endregion

    } // class ClusterArchivalSpec
    
    #endregion

    public static class ListClusterArchivalSpecExtensions
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
            this List<ClusterArchivalSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterArchivalSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterArchivalSpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterArchivalSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterArchivalSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types