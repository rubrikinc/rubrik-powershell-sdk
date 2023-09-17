// MissedSnapshotTimeUnitConfig.cs
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
    #region MissedSnapshotTimeUnitConfig
    public class MissedSnapshotTimeUnitConfig: BaseType
    {
        #region members

        //      C# -> MissedSnapshotDayOfTimeUnit? DayOfTime
        // GraphQL -> dayOfTime: MissedSnapshotDayOfTimeUnit (enum)
        [JsonProperty("dayOfTime")]
        public MissedSnapshotDayOfTimeUnit? DayOfTime { get; set; }

        //      C# -> SlaTimeUnit? TimeUnit
        // GraphQL -> timeUnit: SlaTimeUnit! (enum)
        [JsonProperty("timeUnit")]
        public SlaTimeUnit? TimeUnit { get; set; }

        //      C# -> System.Int32? Frequency
        // GraphQL -> frequency: Int! (scalar)
        [JsonProperty("frequency")]
        public System.Int32? Frequency { get; set; }

        //      C# -> System.Int32? Retention
        // GraphQL -> retention: Int! (scalar)
        [JsonProperty("retention")]
        public System.Int32? Retention { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MissedSnapshotTimeUnitConfig";
    }

    public MissedSnapshotTimeUnitConfig Set(
        MissedSnapshotDayOfTimeUnit? DayOfTime = null,
        SlaTimeUnit? TimeUnit = null,
        System.Int32? Frequency = null,
        System.Int32? Retention = null
    ) 
    {
        if ( DayOfTime != null ) {
            this.DayOfTime = DayOfTime;
        }
        if ( TimeUnit != null ) {
            this.TimeUnit = TimeUnit;
        }
        if ( Frequency != null ) {
            this.Frequency = Frequency;
        }
        if ( Retention != null ) {
            this.Retention = Retention;
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
        //      C# -> MissedSnapshotDayOfTimeUnit? DayOfTime
        // GraphQL -> dayOfTime: MissedSnapshotDayOfTimeUnit (enum)
        if (this.DayOfTime != null) {
            s += ind + "dayOfTime\n" ;
        }
        //      C# -> SlaTimeUnit? TimeUnit
        // GraphQL -> timeUnit: SlaTimeUnit! (enum)
        if (this.TimeUnit != null) {
            s += ind + "timeUnit\n" ;
        }
        //      C# -> System.Int32? Frequency
        // GraphQL -> frequency: Int! (scalar)
        if (this.Frequency != null) {
            s += ind + "frequency\n" ;
        }
        //      C# -> System.Int32? Retention
        // GraphQL -> retention: Int! (scalar)
        if (this.Retention != null) {
            s += ind + "retention\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> MissedSnapshotDayOfTimeUnit? DayOfTime
        // GraphQL -> dayOfTime: MissedSnapshotDayOfTimeUnit (enum)
        if (this.DayOfTime == null && ec.Includes("dayOfTime",true))
        {
            this.DayOfTime = new MissedSnapshotDayOfTimeUnit();
        }
        //      C# -> SlaTimeUnit? TimeUnit
        // GraphQL -> timeUnit: SlaTimeUnit! (enum)
        if (this.TimeUnit == null && ec.Includes("timeUnit",true))
        {
            this.TimeUnit = new SlaTimeUnit();
        }
        //      C# -> System.Int32? Frequency
        // GraphQL -> frequency: Int! (scalar)
        if (this.Frequency == null && ec.Includes("frequency",true))
        {
            this.Frequency = Int32.MinValue;
        }
        //      C# -> System.Int32? Retention
        // GraphQL -> retention: Int! (scalar)
        if (this.Retention == null && ec.Includes("retention",true))
        {
            this.Retention = Int32.MinValue;
        }
    }


    #endregion

    } // class MissedSnapshotTimeUnitConfig
    
    #endregion

    public static class ListMissedSnapshotTimeUnitConfigExtensions
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
            this List<MissedSnapshotTimeUnitConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MissedSnapshotTimeUnitConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MissedSnapshotTimeUnitConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MissedSnapshotTimeUnitConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types