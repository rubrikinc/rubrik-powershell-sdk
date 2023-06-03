// SnapshotRetentionInfo.cs
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
    #region SnapshotRetentionInfo
    public class SnapshotRetentionInfo: BaseType
    {
        #region members

        //      C# -> List<SnapshotLocationRetentionInfo>? ArchivalInfos
        // GraphQL -> archivalInfos: [SnapshotLocationRetentionInfo!]! (type)
        [JsonProperty("archivalInfos")]
        public List<SnapshotLocationRetentionInfo>? ArchivalInfos { get; set; }

        //      C# -> List<SnapshotLocationRetentionInfo>? CloudNativeLocationInfo
        // GraphQL -> cloudNativeLocationInfo: [SnapshotLocationRetentionInfo!]! (type)
        [JsonProperty("cloudNativeLocationInfo")]
        public List<SnapshotLocationRetentionInfo>? CloudNativeLocationInfo { get; set; }

        //      C# -> SnapshotLocationRetentionInfo? LocalInfo
        // GraphQL -> localInfo: SnapshotLocationRetentionInfo (type)
        [JsonProperty("localInfo")]
        public SnapshotLocationRetentionInfo? LocalInfo { get; set; }

        //      C# -> List<SnapshotLocationRetentionInfo>? ReplicationInfos
        // GraphQL -> replicationInfos: [SnapshotLocationRetentionInfo!]! (type)
        [JsonProperty("replicationInfos")]
        public List<SnapshotLocationRetentionInfo>? ReplicationInfos { get; set; }


        #endregion

    #region methods

    public SnapshotRetentionInfo Set(
        List<SnapshotLocationRetentionInfo>? ArchivalInfos = null,
        List<SnapshotLocationRetentionInfo>? CloudNativeLocationInfo = null,
        SnapshotLocationRetentionInfo? LocalInfo = null,
        List<SnapshotLocationRetentionInfo>? ReplicationInfos = null
    ) 
    {
        if ( ArchivalInfos != null ) {
            this.ArchivalInfos = ArchivalInfos;
        }
        if ( CloudNativeLocationInfo != null ) {
            this.CloudNativeLocationInfo = CloudNativeLocationInfo;
        }
        if ( LocalInfo != null ) {
            this.LocalInfo = LocalInfo;
        }
        if ( ReplicationInfos != null ) {
            this.ReplicationInfos = ReplicationInfos;
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
        //      C# -> List<SnapshotLocationRetentionInfo>? ArchivalInfos
        // GraphQL -> archivalInfos: [SnapshotLocationRetentionInfo!]! (type)
        if (this.ArchivalInfos != null) {
            s += ind + "archivalInfos {\n" + this.ArchivalInfos.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<SnapshotLocationRetentionInfo>? CloudNativeLocationInfo
        // GraphQL -> cloudNativeLocationInfo: [SnapshotLocationRetentionInfo!]! (type)
        if (this.CloudNativeLocationInfo != null) {
            s += ind + "cloudNativeLocationInfo {\n" + this.CloudNativeLocationInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SnapshotLocationRetentionInfo? LocalInfo
        // GraphQL -> localInfo: SnapshotLocationRetentionInfo (type)
        if (this.LocalInfo != null) {
            s += ind + "localInfo {\n" + this.LocalInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<SnapshotLocationRetentionInfo>? ReplicationInfos
        // GraphQL -> replicationInfos: [SnapshotLocationRetentionInfo!]! (type)
        if (this.ReplicationInfos != null) {
            s += ind + "replicationInfos {\n" + this.ReplicationInfos.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<SnapshotLocationRetentionInfo>? ArchivalInfos
        // GraphQL -> archivalInfos: [SnapshotLocationRetentionInfo!]! (type)
        if (this.ArchivalInfos == null && Exploration.Includes(parent + ".archivalInfos"))
        {
            this.ArchivalInfos = new List<SnapshotLocationRetentionInfo>();
            this.ArchivalInfos.ApplyExploratoryFieldSpec(parent + ".archivalInfos");
        }
        //      C# -> List<SnapshotLocationRetentionInfo>? CloudNativeLocationInfo
        // GraphQL -> cloudNativeLocationInfo: [SnapshotLocationRetentionInfo!]! (type)
        if (this.CloudNativeLocationInfo == null && Exploration.Includes(parent + ".cloudNativeLocationInfo"))
        {
            this.CloudNativeLocationInfo = new List<SnapshotLocationRetentionInfo>();
            this.CloudNativeLocationInfo.ApplyExploratoryFieldSpec(parent + ".cloudNativeLocationInfo");
        }
        //      C# -> SnapshotLocationRetentionInfo? LocalInfo
        // GraphQL -> localInfo: SnapshotLocationRetentionInfo (type)
        if (this.LocalInfo == null && Exploration.Includes(parent + ".localInfo"))
        {
            this.LocalInfo = new SnapshotLocationRetentionInfo();
            this.LocalInfo.ApplyExploratoryFieldSpec(parent + ".localInfo");
        }
        //      C# -> List<SnapshotLocationRetentionInfo>? ReplicationInfos
        // GraphQL -> replicationInfos: [SnapshotLocationRetentionInfo!]! (type)
        if (this.ReplicationInfos == null && Exploration.Includes(parent + ".replicationInfos"))
        {
            this.ReplicationInfos = new List<SnapshotLocationRetentionInfo>();
            this.ReplicationInfos.ApplyExploratoryFieldSpec(parent + ".replicationInfos");
        }
    }


    #endregion

    } // class SnapshotRetentionInfo
    
    #endregion

    public static class ListSnapshotRetentionInfoExtensions
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
            this List<SnapshotRetentionInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotRetentionInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotRetentionInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types