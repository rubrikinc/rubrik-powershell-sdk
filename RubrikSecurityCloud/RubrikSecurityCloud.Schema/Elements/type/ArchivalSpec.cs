// ArchivalSpec.cs
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
    #region ArchivalSpec
    public class ArchivalSpec: BaseType
    {
        #region members

        //      C# -> List<RetentionUnit>? Frequencies
        // GraphQL -> frequencies: [RetentionUnit!]! (enum)
        [JsonProperty("frequencies")]
        public List<RetentionUnit>? Frequencies { get; set; }

        //      C# -> RetentionUnit? ThresholdUnit
        // GraphQL -> thresholdUnit: RetentionUnit! (enum)
        [JsonProperty("thresholdUnit")]
        public RetentionUnit? ThresholdUnit { get; set; }

        //      C# -> System.Int32? Threshold
        // GraphQL -> threshold: Int! (scalar)
        [JsonProperty("threshold")]
        public System.Int32? Threshold { get; set; }

        //      C# -> List<ArchivalLocationToClusterMapping>? ArchivalLocationToClusterMapping
        // GraphQL -> archivalLocationToClusterMapping: [ArchivalLocationToClusterMapping!]! (type)
        [JsonProperty("archivalLocationToClusterMapping")]
        public List<ArchivalLocationToClusterMapping>? ArchivalLocationToClusterMapping { get; set; }

        //      C# -> ArchivalTieringSpec? ArchivalTieringSpec
        // GraphQL -> archivalTieringSpec: ArchivalTieringSpec (type)
        [JsonProperty("archivalTieringSpec")]
        public ArchivalTieringSpec? ArchivalTieringSpec { get; set; }

        //      C# -> TargetMapping? StorageSetting
        // GraphQL -> storageSetting: TargetMapping (type)
        [JsonProperty("storageSetting")]
        public TargetMapping? StorageSetting { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchivalSpec";
    }

    public ArchivalSpec Set(
        List<RetentionUnit>? Frequencies = null,
        RetentionUnit? ThresholdUnit = null,
        System.Int32? Threshold = null,
        List<ArchivalLocationToClusterMapping>? ArchivalLocationToClusterMapping = null,
        ArchivalTieringSpec? ArchivalTieringSpec = null,
        TargetMapping? StorageSetting = null
    ) 
    {
        if ( Frequencies != null ) {
            this.Frequencies = Frequencies;
        }
        if ( ThresholdUnit != null ) {
            this.ThresholdUnit = ThresholdUnit;
        }
        if ( Threshold != null ) {
            this.Threshold = Threshold;
        }
        if ( ArchivalLocationToClusterMapping != null ) {
            this.ArchivalLocationToClusterMapping = ArchivalLocationToClusterMapping;
        }
        if ( ArchivalTieringSpec != null ) {
            this.ArchivalTieringSpec = ArchivalTieringSpec;
        }
        if ( StorageSetting != null ) {
            this.StorageSetting = StorageSetting;
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
        //      C# -> System.Int32? Threshold
        // GraphQL -> threshold: Int! (scalar)
        if (this.Threshold != null) {
            if (conf.Flat) {
                s += conf.Prefix + "threshold\n" ;
            } else {
                s += ind + "threshold\n" ;
            }
        }
        //      C# -> List<ArchivalLocationToClusterMapping>? ArchivalLocationToClusterMapping
        // GraphQL -> archivalLocationToClusterMapping: [ArchivalLocationToClusterMapping!]! (type)
        if (this.ArchivalLocationToClusterMapping != null) {
            var fspec = this.ArchivalLocationToClusterMapping.AsFieldSpec(conf.Child("archivalLocationToClusterMapping"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "archivalLocationToClusterMapping" + " " + "{\n" + fspec + ind + "}\n" ;
                }
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
        //      C# -> TargetMapping? StorageSetting
        // GraphQL -> storageSetting: TargetMapping (type)
        if (this.StorageSetting != null) {
            var fspec = this.StorageSetting.AsFieldSpec(conf.Child("storageSetting"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "storageSetting" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> List<ArchivalLocationToClusterMapping>? ArchivalLocationToClusterMapping
        // GraphQL -> archivalLocationToClusterMapping: [ArchivalLocationToClusterMapping!]! (type)
        if (ec.Includes("archivalLocationToClusterMapping",false))
        {
            if(this.ArchivalLocationToClusterMapping == null) {

                this.ArchivalLocationToClusterMapping = new List<ArchivalLocationToClusterMapping>();
                this.ArchivalLocationToClusterMapping.ApplyExploratoryFieldSpec(ec.NewChild("archivalLocationToClusterMapping"));

            } else {

                this.ArchivalLocationToClusterMapping.ApplyExploratoryFieldSpec(ec.NewChild("archivalLocationToClusterMapping"));

            }
        }
        else if (this.ArchivalLocationToClusterMapping != null && ec.Excludes("archivalLocationToClusterMapping",false))
        {
            this.ArchivalLocationToClusterMapping = null;
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
        //      C# -> TargetMapping? StorageSetting
        // GraphQL -> storageSetting: TargetMapping (type)
        if (ec.Includes("storageSetting",false))
        {
            if(this.StorageSetting == null) {

                this.StorageSetting = new TargetMapping();
                this.StorageSetting.ApplyExploratoryFieldSpec(ec.NewChild("storageSetting"));

            } else {

                this.StorageSetting.ApplyExploratoryFieldSpec(ec.NewChild("storageSetting"));

            }
        }
        else if (this.StorageSetting != null && ec.Excludes("storageSetting",false))
        {
            this.StorageSetting = null;
        }
    }


    #endregion

    } // class ArchivalSpec
    
    #endregion

    public static class ListArchivalSpecExtensions
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
            this List<ArchivalSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ArchivalSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalSpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArchivalSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types