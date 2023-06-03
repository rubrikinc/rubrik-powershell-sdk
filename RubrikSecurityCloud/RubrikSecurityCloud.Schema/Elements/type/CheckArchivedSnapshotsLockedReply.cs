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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region CheckArchivedSnapshotsLockedReply
    public class CheckArchivedSnapshotsLockedReply: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<System.String>? InvalidSnapshotIds
        // GraphQL -> invalidSnapshotIds: [String!]! (scalar)
        if (this.InvalidSnapshotIds != null) {
            s += ind + "invalidSnapshotIds\n" ;
        }
        //      C# -> List<System.String>? LockedSnapshotIds
        // GraphQL -> lockedSnapshotIds: [String!]! (scalar)
        if (this.LockedSnapshotIds != null) {
            s += ind + "lockedSnapshotIds\n" ;
        }
        //      C# -> List<System.String>? UnlockedSnapshotIds
        // GraphQL -> unlockedSnapshotIds: [String!]! (scalar)
        if (this.UnlockedSnapshotIds != null) {
            s += ind + "unlockedSnapshotIds\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? InvalidSnapshotIds
        // GraphQL -> invalidSnapshotIds: [String!]! (scalar)
        if (this.InvalidSnapshotIds == null && Exploration.Includes(parent + ".invalidSnapshotIds", true))
        {
            this.InvalidSnapshotIds = new List<System.String>();
        }
        //      C# -> List<System.String>? LockedSnapshotIds
        // GraphQL -> lockedSnapshotIds: [String!]! (scalar)
        if (this.LockedSnapshotIds == null && Exploration.Includes(parent + ".lockedSnapshotIds", true))
        {
            this.LockedSnapshotIds = new List<System.String>();
        }
        //      C# -> List<System.String>? UnlockedSnapshotIds
        // GraphQL -> unlockedSnapshotIds: [String!]! (scalar)
        if (this.UnlockedSnapshotIds == null && Exploration.Includes(parent + ".unlockedSnapshotIds", true))
        {
            this.UnlockedSnapshotIds = new List<System.String>();
        }
    }


    #endregion

    } // class CheckArchivedSnapshotsLockedReply
    
    #endregion

    public static class ListCheckArchivedSnapshotsLockedReplyExtensions
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
            this List<CheckArchivedSnapshotsLockedReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CheckArchivedSnapshotsLockedReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CheckArchivedSnapshotsLockedReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types