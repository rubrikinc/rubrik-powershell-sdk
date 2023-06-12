// CdmSnapshotRetentionInfo.cs
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
    #region CdmSnapshotRetentionInfo
    public class CdmSnapshotRetentionInfo: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsCustomRetentionApplied
        // GraphQL -> isCustomRetentionApplied: Boolean! (scalar)
        [JsonProperty("isCustomRetentionApplied")]
        public System.Boolean? IsCustomRetentionApplied { get; set; }

        //      C# -> List<CdmSnapshotLocationRetentionInfo>? ArchivalInfos
        // GraphQL -> archivalInfos: [CdmSnapshotLocationRetentionInfo!] (type)
        [JsonProperty("archivalInfos")]
        public List<CdmSnapshotLocationRetentionInfo>? ArchivalInfos { get; set; }

        //      C# -> CdmSnapshotLocationRetentionInfo? LocalInfo
        // GraphQL -> localInfo: CdmSnapshotLocationRetentionInfo (type)
        [JsonProperty("localInfo")]
        public CdmSnapshotLocationRetentionInfo? LocalInfo { get; set; }

        //      C# -> List<CdmSnapshotLocationRetentionInfo>? ReplicationInfos
        // GraphQL -> replicationInfos: [CdmSnapshotLocationRetentionInfo!] (type)
        [JsonProperty("replicationInfos")]
        public List<CdmSnapshotLocationRetentionInfo>? ReplicationInfos { get; set; }


        #endregion

    #region methods

    public CdmSnapshotRetentionInfo Set(
        System.Boolean? IsCustomRetentionApplied = null,
        List<CdmSnapshotLocationRetentionInfo>? ArchivalInfos = null,
        CdmSnapshotLocationRetentionInfo? LocalInfo = null,
        List<CdmSnapshotLocationRetentionInfo>? ReplicationInfos = null
    ) 
    {
        if ( IsCustomRetentionApplied != null ) {
            this.IsCustomRetentionApplied = IsCustomRetentionApplied;
        }
        if ( ArchivalInfos != null ) {
            this.ArchivalInfos = ArchivalInfos;
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
        //      C# -> System.Boolean? IsCustomRetentionApplied
        // GraphQL -> isCustomRetentionApplied: Boolean! (scalar)
        if (this.IsCustomRetentionApplied != null) {
            s += ind + "isCustomRetentionApplied\n" ;
        }
        //      C# -> List<CdmSnapshotLocationRetentionInfo>? ArchivalInfos
        // GraphQL -> archivalInfos: [CdmSnapshotLocationRetentionInfo!] (type)
        if (this.ArchivalInfos != null) {
            var fspec = this.ArchivalInfos.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "archivalInfos {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmSnapshotLocationRetentionInfo? LocalInfo
        // GraphQL -> localInfo: CdmSnapshotLocationRetentionInfo (type)
        if (this.LocalInfo != null) {
            var fspec = this.LocalInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "localInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<CdmSnapshotLocationRetentionInfo>? ReplicationInfos
        // GraphQL -> replicationInfos: [CdmSnapshotLocationRetentionInfo!] (type)
        if (this.ReplicationInfos != null) {
            var fspec = this.ReplicationInfos.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "replicationInfos {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsCustomRetentionApplied
        // GraphQL -> isCustomRetentionApplied: Boolean! (scalar)
        if (this.IsCustomRetentionApplied == null && Exploration.Includes(parent + ".isCustomRetentionApplied", true))
        {
            this.IsCustomRetentionApplied = true;
        }
        //      C# -> List<CdmSnapshotLocationRetentionInfo>? ArchivalInfos
        // GraphQL -> archivalInfos: [CdmSnapshotLocationRetentionInfo!] (type)
        if (this.ArchivalInfos == null && Exploration.Includes(parent + ".archivalInfos"))
        {
            this.ArchivalInfos = new List<CdmSnapshotLocationRetentionInfo>();
            this.ArchivalInfos.ApplyExploratoryFieldSpec(parent + ".archivalInfos");
        }
        //      C# -> CdmSnapshotLocationRetentionInfo? LocalInfo
        // GraphQL -> localInfo: CdmSnapshotLocationRetentionInfo (type)
        if (this.LocalInfo == null && Exploration.Includes(parent + ".localInfo"))
        {
            this.LocalInfo = new CdmSnapshotLocationRetentionInfo();
            this.LocalInfo.ApplyExploratoryFieldSpec(parent + ".localInfo");
        }
        //      C# -> List<CdmSnapshotLocationRetentionInfo>? ReplicationInfos
        // GraphQL -> replicationInfos: [CdmSnapshotLocationRetentionInfo!] (type)
        if (this.ReplicationInfos == null && Exploration.Includes(parent + ".replicationInfos"))
        {
            this.ReplicationInfos = new List<CdmSnapshotLocationRetentionInfo>();
            this.ReplicationInfos.ApplyExploratoryFieldSpec(parent + ".replicationInfos");
        }
    }


    #endregion

    } // class CdmSnapshotRetentionInfo
    
    #endregion

    public static class ListCdmSnapshotRetentionInfoExtensions
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
            this List<CdmSnapshotRetentionInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmSnapshotRetentionInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmSnapshotRetentionInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types