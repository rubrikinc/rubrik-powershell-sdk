// MissedSnapshot.cs
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
    #region MissedSnapshot
    public class MissedSnapshot: BaseType
    {
        #region members

        //      C# -> List<System.String>? ArchivalLocationType
        // GraphQL -> archivalLocationType: [String!]! (scalar)
        [JsonProperty("archivalLocationType")]
        public List<System.String>? ArchivalLocationType { get; set; }

        //      C# -> DateTime? MissedSnapshotTime
        // GraphQL -> missedSnapshotTime: DateTime (scalar)
        [JsonProperty("missedSnapshotTime")]
        public DateTime? MissedSnapshotTime { get; set; }

        //      C# -> List<MissedSnapshotTimeUnitConfig>? MissedSnapshotTimeUnits
        // GraphQL -> missedSnapshotTimeUnits: [MissedSnapshotTimeUnitConfig!]! (type)
        [JsonProperty("missedSnapshotTimeUnits")]
        public List<MissedSnapshotTimeUnitConfig>? MissedSnapshotTimeUnits { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MissedSnapshot";
    }

    public MissedSnapshot Set(
        List<System.String>? ArchivalLocationType = null,
        DateTime? MissedSnapshotTime = null,
        List<MissedSnapshotTimeUnitConfig>? MissedSnapshotTimeUnits = null
    ) 
    {
        if ( ArchivalLocationType != null ) {
            this.ArchivalLocationType = ArchivalLocationType;
        }
        if ( MissedSnapshotTime != null ) {
            this.MissedSnapshotTime = MissedSnapshotTime;
        }
        if ( MissedSnapshotTimeUnits != null ) {
            this.MissedSnapshotTimeUnits = MissedSnapshotTimeUnits;
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
        //      C# -> List<System.String>? ArchivalLocationType
        // GraphQL -> archivalLocationType: [String!]! (scalar)
        if (this.ArchivalLocationType != null) {
            s += ind + "archivalLocationType\n" ;
        }
        //      C# -> DateTime? MissedSnapshotTime
        // GraphQL -> missedSnapshotTime: DateTime (scalar)
        if (this.MissedSnapshotTime != null) {
            s += ind + "missedSnapshotTime\n" ;
        }
        //      C# -> List<MissedSnapshotTimeUnitConfig>? MissedSnapshotTimeUnits
        // GraphQL -> missedSnapshotTimeUnits: [MissedSnapshotTimeUnitConfig!]! (type)
        if (this.MissedSnapshotTimeUnits != null) {
            var fspec = this.MissedSnapshotTimeUnits.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "missedSnapshotTimeUnits {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? ArchivalLocationType
        // GraphQL -> archivalLocationType: [String!]! (scalar)
        if (this.ArchivalLocationType == null && Exploration.Includes(parent + ".archivalLocationType", true))
        {
            this.ArchivalLocationType = new List<System.String>();
        }
        //      C# -> DateTime? MissedSnapshotTime
        // GraphQL -> missedSnapshotTime: DateTime (scalar)
        if (this.MissedSnapshotTime == null && Exploration.Includes(parent + ".missedSnapshotTime", true))
        {
            this.MissedSnapshotTime = new DateTime();
        }
        //      C# -> List<MissedSnapshotTimeUnitConfig>? MissedSnapshotTimeUnits
        // GraphQL -> missedSnapshotTimeUnits: [MissedSnapshotTimeUnitConfig!]! (type)
        if (this.MissedSnapshotTimeUnits == null && Exploration.Includes(parent + ".missedSnapshotTimeUnits"))
        {
            this.MissedSnapshotTimeUnits = new List<MissedSnapshotTimeUnitConfig>();
            this.MissedSnapshotTimeUnits.ApplyExploratoryFieldSpec(parent + ".missedSnapshotTimeUnits");
        }
    }


    #endregion

    } // class MissedSnapshot
    
    #endregion

    public static class ListMissedSnapshotExtensions
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
            this List<MissedSnapshot> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MissedSnapshot> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MissedSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types