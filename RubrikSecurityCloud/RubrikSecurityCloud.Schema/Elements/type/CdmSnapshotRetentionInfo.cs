// CdmSnapshotRetentionInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:05.
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
    #region CdmSnapshotRetentionInfo
    public class CdmSnapshotRetentionInfo: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Boolean? IsCustomRetentionApplied
            // GraphQL -> isCustomRetentionApplied: Boolean! (scalar)
            if (this.IsCustomRetentionApplied != null)
            {
                 s += ind + "isCustomRetentionApplied\n";

            }
            //      C# -> List<CdmSnapshotLocationRetentionInfo>? ArchivalInfos
            // GraphQL -> archivalInfos: [CdmSnapshotLocationRetentionInfo!] (type)
            if (this.ArchivalInfos != null)
            {
                 s += ind + "archivalInfos\n";

                 s += ind + "{\n" + 
                 this.ArchivalInfos.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmSnapshotLocationRetentionInfo? LocalInfo
            // GraphQL -> localInfo: CdmSnapshotLocationRetentionInfo (type)
            if (this.LocalInfo != null)
            {
                 s += ind + "localInfo\n";

                 s += ind + "{\n" + 
                 this.LocalInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<CdmSnapshotLocationRetentionInfo>? ReplicationInfos
            // GraphQL -> replicationInfos: [CdmSnapshotLocationRetentionInfo!] (type)
            if (this.ReplicationInfos != null)
            {
                 s += ind + "replicationInfos\n";

                 s += ind + "{\n" + 
                 this.ReplicationInfos.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsCustomRetentionApplied
            // GraphQL -> isCustomRetentionApplied: Boolean! (scalar)
            if (this.IsCustomRetentionApplied == null && Exploration.Includes(parent + ".isCustomRetentionApplied$"))
            {
                this.IsCustomRetentionApplied = new System.Boolean();
            }
            //      C# -> List<CdmSnapshotLocationRetentionInfo>? ArchivalInfos
            // GraphQL -> archivalInfos: [CdmSnapshotLocationRetentionInfo!] (type)
            if (this.ArchivalInfos == null && Exploration.Includes(parent + ".archivalInfos"))
            {
                this.ArchivalInfos = new List<CdmSnapshotLocationRetentionInfo>();
                this.ArchivalInfos.ApplyExploratoryFragment(parent + ".archivalInfos");
            }
            //      C# -> CdmSnapshotLocationRetentionInfo? LocalInfo
            // GraphQL -> localInfo: CdmSnapshotLocationRetentionInfo (type)
            if (this.LocalInfo == null && Exploration.Includes(parent + ".localInfo"))
            {
                this.LocalInfo = new CdmSnapshotLocationRetentionInfo();
                this.LocalInfo.ApplyExploratoryFragment(parent + ".localInfo");
            }
            //      C# -> List<CdmSnapshotLocationRetentionInfo>? ReplicationInfos
            // GraphQL -> replicationInfos: [CdmSnapshotLocationRetentionInfo!] (type)
            if (this.ReplicationInfos == null && Exploration.Includes(parent + ".replicationInfos"))
            {
                this.ReplicationInfos = new List<CdmSnapshotLocationRetentionInfo>();
                this.ReplicationInfos.ApplyExploratoryFragment(parent + ".replicationInfos");
            }
        }


    #endregion

    } // class CdmSnapshotRetentionInfo
    #endregion

    public static class ListCdmSnapshotRetentionInfoExtensions
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
            this List<CdmSnapshotRetentionInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CdmSnapshotRetentionInfo> list, 
            String parent = "")
        {
            var item = new CdmSnapshotRetentionInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types