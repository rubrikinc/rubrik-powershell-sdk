// MissedSnapshotTimeUnitConfig.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:46.
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
    #region MissedSnapshotTimeUnitConfig
    public class MissedSnapshotTimeUnitConfig: IFragment
    {
        #region members
        //      C# -> System.Int32? Frequency
        // GraphQL -> frequency: Int! (scalar)
        [JsonProperty("frequency")]
        public System.Int32? Frequency { get; set; }

        //      C# -> System.Int32? Retention
        // GraphQL -> retention: Int! (scalar)
        [JsonProperty("retention")]
        public System.Int32? Retention { get; set; }

        //      C# -> MissedSnapshotDayOfTimeUnit? DayOfTime
        // GraphQL -> dayOfTime: MissedSnapshotDayOfTimeUnit (enum)
        [JsonProperty("dayOfTime")]
        public MissedSnapshotDayOfTimeUnit? DayOfTime { get; set; }

        //      C# -> SlaTimeUnit? TimeUnit
        // GraphQL -> timeUnit: SlaTimeUnit! (enum)
        [JsonProperty("timeUnit")]
        public SlaTimeUnit? TimeUnit { get; set; }

        #endregion

    #region methods

    public MissedSnapshotTimeUnitConfig Set(
        System.Int32? Frequency = null,
        System.Int32? Retention = null,
        MissedSnapshotDayOfTimeUnit? DayOfTime = null,
        SlaTimeUnit? TimeUnit = null
    ) 
    {
        if ( Frequency != null ) {
            this.Frequency = Frequency;
        }
        if ( Retention != null ) {
            this.Retention = Retention;
        }
        if ( DayOfTime != null ) {
            this.DayOfTime = DayOfTime;
        }
        if ( TimeUnit != null ) {
            this.TimeUnit = TimeUnit;
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
            //      C# -> System.Int32? Frequency
            // GraphQL -> frequency: Int! (scalar)
            if (this.Frequency != null)
            {
                 s += ind + "frequency\n";

            }
            //      C# -> System.Int32? Retention
            // GraphQL -> retention: Int! (scalar)
            if (this.Retention != null)
            {
                 s += ind + "retention\n";

            }
            //      C# -> MissedSnapshotDayOfTimeUnit? DayOfTime
            // GraphQL -> dayOfTime: MissedSnapshotDayOfTimeUnit (enum)
            if (this.DayOfTime != null)
            {
                 s += ind + "dayOfTime\n";

            }
            //      C# -> SlaTimeUnit? TimeUnit
            // GraphQL -> timeUnit: SlaTimeUnit! (enum)
            if (this.TimeUnit != null)
            {
                 s += ind + "timeUnit\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? Frequency
            // GraphQL -> frequency: Int! (scalar)
            if (this.Frequency == null && Exploration.Includes(parent + ".frequency$"))
            {
                this.Frequency = new System.Int32();
            }
            //      C# -> System.Int32? Retention
            // GraphQL -> retention: Int! (scalar)
            if (this.Retention == null && Exploration.Includes(parent + ".retention$"))
            {
                this.Retention = new System.Int32();
            }
            //      C# -> MissedSnapshotDayOfTimeUnit? DayOfTime
            // GraphQL -> dayOfTime: MissedSnapshotDayOfTimeUnit (enum)
            if (this.DayOfTime == null && Exploration.Includes(parent + ".dayOfTime$"))
            {
                this.DayOfTime = new MissedSnapshotDayOfTimeUnit();
            }
            //      C# -> SlaTimeUnit? TimeUnit
            // GraphQL -> timeUnit: SlaTimeUnit! (enum)
            if (this.TimeUnit == null && Exploration.Includes(parent + ".timeUnit$"))
            {
                this.TimeUnit = new SlaTimeUnit();
            }
        }


    #endregion

    } // class MissedSnapshotTimeUnitConfig
    #endregion

    public static class ListMissedSnapshotTimeUnitConfigExtensions
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
            this List<MissedSnapshotTimeUnitConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MissedSnapshotTimeUnitConfig> list, 
            String parent = "")
        {
            var item = new MissedSnapshotTimeUnitConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types