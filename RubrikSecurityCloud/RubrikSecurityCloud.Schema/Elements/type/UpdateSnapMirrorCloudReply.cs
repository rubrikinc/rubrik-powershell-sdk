// UpdateSnapMirrorCloudReply.cs
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
    #region UpdateSnapMirrorCloudReply
    public class UpdateSnapMirrorCloudReply: BaseType
    {
        #region members

        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long (scalar)
        [JsonProperty("archiveStorage")]
        public System.Int64? ArchiveStorage { get; set; }

        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long (scalar)
        [JsonProperty("localStorage")]
        public System.Int64? LocalStorage { get; set; }

        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        [JsonProperty("protectionDate")]
        public DateTime? ProtectionDate { get; set; }

        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int (scalar)
        [JsonProperty("snapshotCount")]
        public System.Int32? SnapshotCount { get; set; }

        //      C# -> CreateSnapMirrorCloudReply? SnapMirrorCloudSummary
        // GraphQL -> snapMirrorCloudSummary: CreateSnapMirrorCloudReply (type)
        [JsonProperty("snapMirrorCloudSummary")]
        public CreateSnapMirrorCloudReply? SnapMirrorCloudSummary { get; set; }


        #endregion

    #region methods

    public UpdateSnapMirrorCloudReply Set(
        System.Int64? ArchiveStorage = null,
        System.Int64? LocalStorage = null,
        DateTime? ProtectionDate = null,
        System.Int32? SnapshotCount = null,
        CreateSnapMirrorCloudReply? SnapMirrorCloudSummary = null
    ) 
    {
        if ( ArchiveStorage != null ) {
            this.ArchiveStorage = ArchiveStorage;
        }
        if ( LocalStorage != null ) {
            this.LocalStorage = LocalStorage;
        }
        if ( ProtectionDate != null ) {
            this.ProtectionDate = ProtectionDate;
        }
        if ( SnapshotCount != null ) {
            this.SnapshotCount = SnapshotCount;
        }
        if ( SnapMirrorCloudSummary != null ) {
            this.SnapMirrorCloudSummary = SnapMirrorCloudSummary;
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
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long (scalar)
        if (this.ArchiveStorage != null) {
            s += ind + "archiveStorage\n" ;
        }
        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long (scalar)
        if (this.LocalStorage != null) {
            s += ind + "localStorage\n" ;
        }
        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        if (this.ProtectionDate != null) {
            s += ind + "protectionDate\n" ;
        }
        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int (scalar)
        if (this.SnapshotCount != null) {
            s += ind + "snapshotCount\n" ;
        }
        //      C# -> CreateSnapMirrorCloudReply? SnapMirrorCloudSummary
        // GraphQL -> snapMirrorCloudSummary: CreateSnapMirrorCloudReply (type)
        if (this.SnapMirrorCloudSummary != null) {
            s += ind + "snapMirrorCloudSummary {\n" + this.SnapMirrorCloudSummary.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long (scalar)
        if (this.ArchiveStorage == null && Exploration.Includes(parent + ".archiveStorage", true))
        {
            this.ArchiveStorage = new System.Int64();
        }
        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long (scalar)
        if (this.LocalStorage == null && Exploration.Includes(parent + ".localStorage", true))
        {
            this.LocalStorage = new System.Int64();
        }
        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        if (this.ProtectionDate == null && Exploration.Includes(parent + ".protectionDate", true))
        {
            this.ProtectionDate = new DateTime();
        }
        //      C# -> System.Int32? SnapshotCount
        // GraphQL -> snapshotCount: Int (scalar)
        if (this.SnapshotCount == null && Exploration.Includes(parent + ".snapshotCount", true))
        {
            this.SnapshotCount = Int32.MinValue;
        }
        //      C# -> CreateSnapMirrorCloudReply? SnapMirrorCloudSummary
        // GraphQL -> snapMirrorCloudSummary: CreateSnapMirrorCloudReply (type)
        if (this.SnapMirrorCloudSummary == null && Exploration.Includes(parent + ".snapMirrorCloudSummary"))
        {
            this.SnapMirrorCloudSummary = new CreateSnapMirrorCloudReply();
            this.SnapMirrorCloudSummary.ApplyExploratoryFieldSpec(parent + ".snapMirrorCloudSummary");
        }
    }


    #endregion

    } // class UpdateSnapMirrorCloudReply
    
    #endregion

    public static class ListUpdateSnapMirrorCloudReplyExtensions
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
            this List<UpdateSnapMirrorCloudReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateSnapMirrorCloudReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateSnapMirrorCloudReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types