// MissedSnapshotCommon.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:06.
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
    #region MissedSnapshotCommon
    public class MissedSnapshotCommon: IFragment
    {
        #region members
        //      C# -> List<System.String>? ArchivalLocationType
        // GraphQL -> archivalLocationType: [String!]! (scalar)
        [JsonProperty("archivalLocationType")]
        public List<System.String>? ArchivalLocationType { get; set; }

        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        #endregion

    #region methods

    public MissedSnapshotCommon Set(
        List<System.String>? ArchivalLocationType = null,
        DateTime? Date = null
    ) 
    {
        if ( ArchivalLocationType != null ) {
            this.ArchivalLocationType = ArchivalLocationType;
        }
        if ( Date != null ) {
            this.Date = Date;
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
            //      C# -> DateTime? Date
            // GraphQL -> date: DateTime! (scalar)
            if (this.Date != null)
            {
                 s += ind + "date\n";

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
            //      C# -> DateTime? Date
            // GraphQL -> date: DateTime! (scalar)
            if (this.Date == null && Exploration.Includes(parent + ".date$"))
            {
                this.Date = new DateTime();
            }
        }


    #endregion

    } // class MissedSnapshotCommon
    #endregion

    public static class ListMissedSnapshotCommonExtensions
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
            this List<MissedSnapshotCommon> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MissedSnapshotCommon> list, 
            String parent = "")
        {
            var item = new MissedSnapshotCommon();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types