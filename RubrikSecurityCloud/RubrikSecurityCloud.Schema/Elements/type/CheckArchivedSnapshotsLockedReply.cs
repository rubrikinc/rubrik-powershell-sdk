// CheckArchivedSnapshotsLockedReply.cs
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
    #region CheckArchivedSnapshotsLockedReply
    public class CheckArchivedSnapshotsLockedReply: IFragment
    {
        #region members
        //      C# -> List<System.String>? InvalidSnapshotIds
        // GraphQL -> invalidSnapshotIds: [String!]! (scalar)
        [JsonProperty("invalidSnapshotIds")]
        public List<System.String>? InvalidSnapshotIds { get; set; }

        //      C# -> List<System.String>? LockedSnapshotIds
        // GraphQL -> lockedSnapshotIds: [String!]! (scalar)
        [JsonProperty("lockedSnapshotIds")]
        public List<System.String>? LockedSnapshotIds { get; set; }

        //      C# -> List<System.String>? UnlockedSnapshotIds
        // GraphQL -> unlockedSnapshotIds: [String!]! (scalar)
        [JsonProperty("unlockedSnapshotIds")]
        public List<System.String>? UnlockedSnapshotIds { get; set; }

        #endregion

    #region methods

    public CheckArchivedSnapshotsLockedReply Set(
        List<System.String>? InvalidSnapshotIds = null,
        List<System.String>? LockedSnapshotIds = null,
        List<System.String>? UnlockedSnapshotIds = null
    ) 
    {
        if ( InvalidSnapshotIds != null ) {
            this.InvalidSnapshotIds = InvalidSnapshotIds;
        }
        if ( LockedSnapshotIds != null ) {
            this.LockedSnapshotIds = LockedSnapshotIds;
        }
        if ( UnlockedSnapshotIds != null ) {
            this.UnlockedSnapshotIds = UnlockedSnapshotIds;
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
            //      C# -> List<System.String>? InvalidSnapshotIds
            // GraphQL -> invalidSnapshotIds: [String!]! (scalar)
            if (this.InvalidSnapshotIds != null)
            {
                 s += ind + "invalidSnapshotIds\n";

            }
            //      C# -> List<System.String>? LockedSnapshotIds
            // GraphQL -> lockedSnapshotIds: [String!]! (scalar)
            if (this.LockedSnapshotIds != null)
            {
                 s += ind + "lockedSnapshotIds\n";

            }
            //      C# -> List<System.String>? UnlockedSnapshotIds
            // GraphQL -> unlockedSnapshotIds: [String!]! (scalar)
            if (this.UnlockedSnapshotIds != null)
            {
                 s += ind + "unlockedSnapshotIds\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? InvalidSnapshotIds
            // GraphQL -> invalidSnapshotIds: [String!]! (scalar)
            if (this.InvalidSnapshotIds == null && Exploration.Includes(parent + ".invalidSnapshotIds$"))
            {
                this.InvalidSnapshotIds = new List<System.String>();
            }
            //      C# -> List<System.String>? LockedSnapshotIds
            // GraphQL -> lockedSnapshotIds: [String!]! (scalar)
            if (this.LockedSnapshotIds == null && Exploration.Includes(parent + ".lockedSnapshotIds$"))
            {
                this.LockedSnapshotIds = new List<System.String>();
            }
            //      C# -> List<System.String>? UnlockedSnapshotIds
            // GraphQL -> unlockedSnapshotIds: [String!]! (scalar)
            if (this.UnlockedSnapshotIds == null && Exploration.Includes(parent + ".unlockedSnapshotIds$"))
            {
                this.UnlockedSnapshotIds = new List<System.String>();
            }
        }


    #endregion

    } // class CheckArchivedSnapshotsLockedReply
    #endregion

    public static class ListCheckArchivedSnapshotsLockedReplyExtensions
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
            this List<CheckArchivedSnapshotsLockedReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CheckArchivedSnapshotsLockedReply> list, 
            String parent = "")
        {
            var item = new CheckArchivedSnapshotsLockedReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types