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

namespace Rubrik.SecurityCloud.Types
{
    #region ArchivalSpec
    public class ArchivalSpec: IFragment
    {
        #region members
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

        //      C# -> List<RetentionUnit>? Frequencies
        // GraphQL -> frequencies: [RetentionUnit!]! (enum)
        [JsonProperty("frequencies")]
        public List<RetentionUnit>? Frequencies { get; set; }

        //      C# -> RetentionUnit? ThresholdUnit
        // GraphQL -> thresholdUnit: RetentionUnit! (enum)
        [JsonProperty("thresholdUnit")]
        public RetentionUnit? ThresholdUnit { get; set; }

        #endregion

    #region methods

    public ArchivalSpec Set(
        System.Int32? Threshold = null,
        List<ArchivalLocationToClusterMapping>? ArchivalLocationToClusterMapping = null,
        ArchivalTieringSpec? ArchivalTieringSpec = null,
        TargetMapping? StorageSetting = null,
        List<RetentionUnit>? Frequencies = null,
        RetentionUnit? ThresholdUnit = null
    ) 
    {
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
        if ( Frequencies != null ) {
            this.Frequencies = Frequencies;
        }
        if ( ThresholdUnit != null ) {
            this.ThresholdUnit = ThresholdUnit;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Int32? Threshold
            // GraphQL -> threshold: Int! (scalar)
            if (this.Threshold != null)
            {
                 s += ind + "threshold\n";

            }
            //      C# -> List<ArchivalLocationToClusterMapping>? ArchivalLocationToClusterMapping
            // GraphQL -> archivalLocationToClusterMapping: [ArchivalLocationToClusterMapping!]! (type)
            if (this.ArchivalLocationToClusterMapping != null)
            {
                 s += ind + "archivalLocationToClusterMapping\n";

                 s += ind + "{\n" + 
                 this.ArchivalLocationToClusterMapping.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ArchivalTieringSpec? ArchivalTieringSpec
            // GraphQL -> archivalTieringSpec: ArchivalTieringSpec (type)
            if (this.ArchivalTieringSpec != null)
            {
                 s += ind + "archivalTieringSpec\n";

                 s += ind + "{\n" + 
                 this.ArchivalTieringSpec.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> TargetMapping? StorageSetting
            // GraphQL -> storageSetting: TargetMapping (type)
            if (this.StorageSetting != null)
            {
                 s += ind + "storageSetting\n";

                 s += ind + "{\n" + 
                 this.StorageSetting.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<RetentionUnit>? Frequencies
            // GraphQL -> frequencies: [RetentionUnit!]! (enum)
            if (this.Frequencies != null)
            {
                 s += ind + "frequencies\n";

            }
            //      C# -> RetentionUnit? ThresholdUnit
            // GraphQL -> thresholdUnit: RetentionUnit! (enum)
            if (this.ThresholdUnit != null)
            {
                 s += ind + "thresholdUnit\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? Threshold
            // GraphQL -> threshold: Int! (scalar)
            if (this.Threshold == null && Exploration.Includes(parent + ".threshold$"))
            {
                this.Threshold = new System.Int32();
            }
            //      C# -> List<ArchivalLocationToClusterMapping>? ArchivalLocationToClusterMapping
            // GraphQL -> archivalLocationToClusterMapping: [ArchivalLocationToClusterMapping!]! (type)
            if (this.ArchivalLocationToClusterMapping == null && Exploration.Includes(parent + ".archivalLocationToClusterMapping"))
            {
                this.ArchivalLocationToClusterMapping = new List<ArchivalLocationToClusterMapping>();
                this.ArchivalLocationToClusterMapping.ApplyExploratoryFragment(parent + ".archivalLocationToClusterMapping");
            }
            //      C# -> ArchivalTieringSpec? ArchivalTieringSpec
            // GraphQL -> archivalTieringSpec: ArchivalTieringSpec (type)
            if (this.ArchivalTieringSpec == null && Exploration.Includes(parent + ".archivalTieringSpec"))
            {
                this.ArchivalTieringSpec = new ArchivalTieringSpec();
                this.ArchivalTieringSpec.ApplyExploratoryFragment(parent + ".archivalTieringSpec");
            }
            //      C# -> TargetMapping? StorageSetting
            // GraphQL -> storageSetting: TargetMapping (type)
            if (this.StorageSetting == null && Exploration.Includes(parent + ".storageSetting"))
            {
                this.StorageSetting = new TargetMapping();
                this.StorageSetting.ApplyExploratoryFragment(parent + ".storageSetting");
            }
            //      C# -> List<RetentionUnit>? Frequencies
            // GraphQL -> frequencies: [RetentionUnit!]! (enum)
            if (this.Frequencies == null && Exploration.Includes(parent + ".frequencies$"))
            {
                this.Frequencies = new List<RetentionUnit>();
            }
            //      C# -> RetentionUnit? ThresholdUnit
            // GraphQL -> thresholdUnit: RetentionUnit! (enum)
            if (this.ThresholdUnit == null && Exploration.Includes(parent + ".thresholdUnit$"))
            {
                this.ThresholdUnit = new RetentionUnit();
            }
        }


    #endregion

    } // class ArchivalSpec
    #endregion

    public static class ListArchivalSpecExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<ArchivalSpec> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ArchivalSpec> list, 
            String parent = "")
        {
            var item = new ArchivalSpec();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types