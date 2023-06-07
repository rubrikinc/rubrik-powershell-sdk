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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region ClusterArchivalSpec
    public class ClusterArchivalSpec: BaseType
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

    public ClusterArchivalSpec Set(
        List<RetentionUnit>? Frequencies = null,
        RetentionUnit? ThresholdUnit = null,
        System.String? ArchivalLocationId = null,
        System.String? ArchivalLocationName = null,
        System.Int32? Threshold = null,
        ArchivalTieringSpec? ArchivalTieringSpec = null
    ) 
    {
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
        //      C# -> System.String? ArchivalLocationId
        // GraphQL -> archivalLocationId: String! (scalar)
        if (this.ArchivalLocationId != null) {
            s += ind + "archivalLocationId\n" ;
        }
        //      C# -> System.String? ArchivalLocationName
        // GraphQL -> archivalLocationName: String! (scalar)
        if (this.ArchivalLocationName != null) {
            s += ind + "archivalLocationName\n" ;
        }
        //      C# -> System.Int32? Threshold
        // GraphQL -> threshold: Int! (scalar)
        if (this.Threshold != null) {
            s += ind + "threshold\n" ;
        }
        //      C# -> ArchivalTieringSpec? ArchivalTieringSpec
        // GraphQL -> archivalTieringSpec: ArchivalTieringSpec (type)
        if (this.ArchivalTieringSpec != null) {
            s += ind + "archivalTieringSpec {\n" + this.ArchivalTieringSpec.AsFieldSpec(indent+1) + ind + "}\n" ;
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
        //      C# -> System.String? ArchivalLocationId
        // GraphQL -> archivalLocationId: String! (scalar)
        if (this.ArchivalLocationId == null && Exploration.Includes(parent + ".archivalLocationId", true))
        {
            this.ArchivalLocationId = "FETCH";
        }
        //      C# -> System.String? ArchivalLocationName
        // GraphQL -> archivalLocationName: String! (scalar)
        if (this.ArchivalLocationName == null && Exploration.Includes(parent + ".archivalLocationName", true))
        {
            this.ArchivalLocationName = "FETCH";
        }
        //      C# -> System.Int32? Threshold
        // GraphQL -> threshold: Int! (scalar)
        if (this.Threshold == null && Exploration.Includes(parent + ".threshold", true))
        {
            this.Threshold = Int32.MinValue;
        }
        //      C# -> ArchivalTieringSpec? ArchivalTieringSpec
        // GraphQL -> archivalTieringSpec: ArchivalTieringSpec (type)
        if (this.ArchivalTieringSpec == null && Exploration.Includes(parent + ".archivalTieringSpec"))
        {
            this.ArchivalTieringSpec = new ArchivalTieringSpec();
            this.ArchivalTieringSpec.ApplyExploratoryFieldSpec(parent + ".archivalTieringSpec");
        }
    }


    #endregion

    } // class ClusterArchivalSpec
    
    #endregion

    public static class ListClusterArchivalSpecExtensions
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
            this List<ClusterArchivalSpec> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterArchivalSpec> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterArchivalSpec());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types