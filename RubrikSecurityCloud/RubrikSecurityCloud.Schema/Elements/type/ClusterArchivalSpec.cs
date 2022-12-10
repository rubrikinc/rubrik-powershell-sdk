// ClusterArchivalSpec.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:01.
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
    #region ClusterArchivalSpec
    public class ClusterArchivalSpec: IFragment
    {
        #region members
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

    public ClusterArchivalSpec Set(
        System.String? ArchivalLocationId = null,
        System.String? ArchivalLocationName = null,
        System.Int32? Threshold = null,
        ArchivalTieringSpec? ArchivalTieringSpec = null,
        List<RetentionUnit>? Frequencies = null,
        RetentionUnit? ThresholdUnit = null
    ) 
    {
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
            //      C# -> System.String? ArchivalLocationId
            // GraphQL -> archivalLocationId: String! (scalar)
            if (this.ArchivalLocationId != null)
            {
                 s += ind + "archivalLocationId\n";

            }
            //      C# -> System.String? ArchivalLocationName
            // GraphQL -> archivalLocationName: String! (scalar)
            if (this.ArchivalLocationName != null)
            {
                 s += ind + "archivalLocationName\n";

            }
            //      C# -> System.Int32? Threshold
            // GraphQL -> threshold: Int! (scalar)
            if (this.Threshold != null)
            {
                 s += ind + "threshold\n";

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
            //      C# -> System.String? ArchivalLocationId
            // GraphQL -> archivalLocationId: String! (scalar)
            if (this.ArchivalLocationId == null && Exploration.Includes(parent + ".archivalLocationId$"))
            {
                this.ArchivalLocationId = new System.String("FETCH");
            }
            //      C# -> System.String? ArchivalLocationName
            // GraphQL -> archivalLocationName: String! (scalar)
            if (this.ArchivalLocationName == null && Exploration.Includes(parent + ".archivalLocationName$"))
            {
                this.ArchivalLocationName = new System.String("FETCH");
            }
            //      C# -> System.Int32? Threshold
            // GraphQL -> threshold: Int! (scalar)
            if (this.Threshold == null && Exploration.Includes(parent + ".threshold$"))
            {
                this.Threshold = new System.Int32();
            }
            //      C# -> ArchivalTieringSpec? ArchivalTieringSpec
            // GraphQL -> archivalTieringSpec: ArchivalTieringSpec (type)
            if (this.ArchivalTieringSpec == null && Exploration.Includes(parent + ".archivalTieringSpec"))
            {
                this.ArchivalTieringSpec = new ArchivalTieringSpec();
                this.ArchivalTieringSpec.ApplyExploratoryFragment(parent + ".archivalTieringSpec");
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

    } // class ClusterArchivalSpec
    #endregion

    public static class ListClusterArchivalSpecExtensions
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
            this List<ClusterArchivalSpec> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterArchivalSpec> list, 
            String parent = "")
        {
            var item = new ClusterArchivalSpec();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types