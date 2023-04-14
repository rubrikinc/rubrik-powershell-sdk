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

namespace Rubrik.SecurityCloud.Types
{
    #region MissedSnapshot
    public class MissedSnapshot: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> List<System.String>? ArchivalLocationType
            // GraphQL -> archivalLocationType: [String!]! (scalar)
            if (this.ArchivalLocationType != null)
            {
                 s += ind + "archivalLocationType\n";

            }
            //      C# -> DateTime? MissedSnapshotTime
            // GraphQL -> missedSnapshotTime: DateTime (scalar)
            if (this.MissedSnapshotTime != null)
            {
                 s += ind + "missedSnapshotTime\n";

            }
            //      C# -> List<MissedSnapshotTimeUnitConfig>? MissedSnapshotTimeUnits
            // GraphQL -> missedSnapshotTimeUnits: [MissedSnapshotTimeUnitConfig!]! (type)
            if (this.MissedSnapshotTimeUnits != null)
            {
                 s += ind + "missedSnapshotTimeUnits\n";

                 s += ind + "{\n" + 
                 this.MissedSnapshotTimeUnits.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? ArchivalLocationType
            // GraphQL -> archivalLocationType: [String!]! (scalar)
            if (this.ArchivalLocationType == null && Exploration.Includes(parent + ".archivalLocationType$"))
            {
                this.ArchivalLocationType = new List<System.String>();
            }
            //      C# -> DateTime? MissedSnapshotTime
            // GraphQL -> missedSnapshotTime: DateTime (scalar)
            if (this.MissedSnapshotTime == null && Exploration.Includes(parent + ".missedSnapshotTime$"))
            {
                this.MissedSnapshotTime = new DateTime();
            }
            //      C# -> List<MissedSnapshotTimeUnitConfig>? MissedSnapshotTimeUnits
            // GraphQL -> missedSnapshotTimeUnits: [MissedSnapshotTimeUnitConfig!]! (type)
            if (this.MissedSnapshotTimeUnits == null && Exploration.Includes(parent + ".missedSnapshotTimeUnits"))
            {
                this.MissedSnapshotTimeUnits = new List<MissedSnapshotTimeUnitConfig>();
                this.MissedSnapshotTimeUnits.ApplyExploratoryFragment(parent + ".missedSnapshotTimeUnits");
            }
        }


    #endregion

    } // class MissedSnapshot
    #endregion

    public static class ListMissedSnapshotExtensions
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
            this List<MissedSnapshot> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MissedSnapshot> list, 
            String parent = "")
        {
            var item = new MissedSnapshot();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types