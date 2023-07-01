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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<RetentionUnit>? Frequencies
        // GraphQL -> frequencies: [RetentionUnit!]! (enum)
        if (this.Frequencies != null) {
            s += ind + "frequencies\n" ;
        }
        //      C# -> RetentionUnit? ThresholdUnit
        // GraphQL -> thresholdUnit: RetentionUnit! (enum)
        if (this.ThresholdUnit != null) {
            s += ind + "thresholdUnit\n" ;
        }
        //      C# -> System.Int32? Threshold
        // GraphQL -> threshold: Int! (scalar)
        if (this.Threshold != null) {
            s += ind + "threshold\n" ;
        }
        //      C# -> List<ArchivalLocationToClusterMapping>? ArchivalLocationToClusterMapping
        // GraphQL -> archivalLocationToClusterMapping: [ArchivalLocationToClusterMapping!]! (type)
        if (this.ArchivalLocationToClusterMapping != null) {
            var fspec = this.ArchivalLocationToClusterMapping.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "archivalLocationToClusterMapping {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ArchivalTieringSpec? ArchivalTieringSpec
        // GraphQL -> archivalTieringSpec: ArchivalTieringSpec (type)
        if (this.ArchivalTieringSpec != null) {
            var fspec = this.ArchivalTieringSpec.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "archivalTieringSpec {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> TargetMapping? StorageSetting
        // GraphQL -> storageSetting: TargetMapping (type)
        if (this.StorageSetting != null) {
            var fspec = this.StorageSetting.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "storageSetting {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<RetentionUnit>? Frequencies
        // GraphQL -> frequencies: [RetentionUnit!]! (enum)
        if (this.Frequencies == null && Exploration.Includes(parent + ".frequencies", true))
        {
            this.Frequencies = new List<RetentionUnit>();
        }
        //      C# -> RetentionUnit? ThresholdUnit
        // GraphQL -> thresholdUnit: RetentionUnit! (enum)
        if (this.ThresholdUnit == null && Exploration.Includes(parent + ".thresholdUnit", true))
        {
            this.ThresholdUnit = new RetentionUnit();
        }
        //      C# -> System.Int32? Threshold
        // GraphQL -> threshold: Int! (scalar)
        if (this.Threshold == null && Exploration.Includes(parent + ".threshold", true))
        {
            this.Threshold = Int32.MinValue;
        }
        //      C# -> List<ArchivalLocationToClusterMapping>? ArchivalLocationToClusterMapping
        // GraphQL -> archivalLocationToClusterMapping: [ArchivalLocationToClusterMapping!]! (type)
        if (this.ArchivalLocationToClusterMapping == null && Exploration.Includes(parent + ".archivalLocationToClusterMapping"))
        {
            this.ArchivalLocationToClusterMapping = new List<ArchivalLocationToClusterMapping>();
            this.ArchivalLocationToClusterMapping.ApplyExploratoryFieldSpec(parent + ".archivalLocationToClusterMapping");
        }
        //      C# -> ArchivalTieringSpec? ArchivalTieringSpec
        // GraphQL -> archivalTieringSpec: ArchivalTieringSpec (type)
        if (this.ArchivalTieringSpec == null && Exploration.Includes(parent + ".archivalTieringSpec"))
        {
            this.ArchivalTieringSpec = new ArchivalTieringSpec();
            this.ArchivalTieringSpec.ApplyExploratoryFieldSpec(parent + ".archivalTieringSpec");
        }
        //      C# -> TargetMapping? StorageSetting
        // GraphQL -> storageSetting: TargetMapping (type)
        if (this.StorageSetting == null && Exploration.Includes(parent + ".storageSetting"))
        {
            this.StorageSetting = new TargetMapping();
            this.StorageSetting.ApplyExploratoryFieldSpec(parent + ".storageSetting");
        }
    }


    #endregion

    } // class ArchivalSpec
    
    #endregion

    public static class ListArchivalSpecExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<ArchivalSpec> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalSpec> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalSpec());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types