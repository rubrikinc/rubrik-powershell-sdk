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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "CheckArchivedSnapshotsLockedReply";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<System.String>? InvalidSnapshotIds
        // GraphQL -> invalidSnapshotIds: [String!]! (scalar)
        if (this.InvalidSnapshotIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "invalidSnapshotIds\n" ;
            } else {
                s += ind + "invalidSnapshotIds\n" ;
            }
        }
        //      C# -> List<System.String>? LockedSnapshotIds
        // GraphQL -> lockedSnapshotIds: [String!]! (scalar)
        if (this.LockedSnapshotIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lockedSnapshotIds\n" ;
            } else {
                s += ind + "lockedSnapshotIds\n" ;
            }
        }
        //      C# -> List<System.String>? UnlockedSnapshotIds
        // GraphQL -> unlockedSnapshotIds: [String!]! (scalar)
        if (this.UnlockedSnapshotIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unlockedSnapshotIds\n" ;
            } else {
                s += ind + "unlockedSnapshotIds\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? InvalidSnapshotIds
        // GraphQL -> invalidSnapshotIds: [String!]! (scalar)
        if (ec.Includes("invalidSnapshotIds",true))
        {
            if(this.InvalidSnapshotIds == null) {

                this.InvalidSnapshotIds = new List<System.String>();

            } else {


            }
        }
        else if (this.InvalidSnapshotIds != null && ec.Excludes("invalidSnapshotIds",true))
        {
            this.InvalidSnapshotIds = null;
        }
        //      C# -> List<System.String>? LockedSnapshotIds
        // GraphQL -> lockedSnapshotIds: [String!]! (scalar)
        if (ec.Includes("lockedSnapshotIds",true))
        {
            if(this.LockedSnapshotIds == null) {

                this.LockedSnapshotIds = new List<System.String>();

            } else {


            }
        }
        else if (this.LockedSnapshotIds != null && ec.Excludes("lockedSnapshotIds",true))
        {
            this.LockedSnapshotIds = null;
        }
        //      C# -> List<System.String>? UnlockedSnapshotIds
        // GraphQL -> unlockedSnapshotIds: [String!]! (scalar)
        if (ec.Includes("unlockedSnapshotIds",true))
        {
            if(this.UnlockedSnapshotIds == null) {

                this.UnlockedSnapshotIds = new List<System.String>();

            } else {


            }
        }
        else if (this.UnlockedSnapshotIds != null && ec.Excludes("unlockedSnapshotIds",true))
        {
            this.UnlockedSnapshotIds = null;
        }
    }


    #endregion

    } // class CheckArchivedSnapshotsLockedReply
    
    #endregion

    public static class ListCheckArchivedSnapshotsLockedReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<CheckArchivedSnapshotsLockedReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CheckArchivedSnapshotsLockedReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CheckArchivedSnapshotsLockedReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CheckArchivedSnapshotsLockedReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CheckArchivedSnapshotsLockedReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types