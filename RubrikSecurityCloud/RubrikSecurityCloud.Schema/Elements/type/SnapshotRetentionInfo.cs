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

namespace Rubrik.SecurityCloud.Types
{
    #region SnapshotRetentionInfo
    public class SnapshotRetentionInfo: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> List<SnapshotLocationRetentionInfo>? ArchivalInfos
            // GraphQL -> archivalInfos: [SnapshotLocationRetentionInfo!]! (type)
            if (this.ArchivalInfos != null)
            {
                 s += ind + "archivalInfos\n";

                 s += ind + "{\n" + 
                 this.ArchivalInfos.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<SnapshotLocationRetentionInfo>? CloudNativeLocationInfo
            // GraphQL -> cloudNativeLocationInfo: [SnapshotLocationRetentionInfo!]! (type)
            if (this.CloudNativeLocationInfo != null)
            {
                 s += ind + "cloudNativeLocationInfo\n";

                 s += ind + "{\n" + 
                 this.CloudNativeLocationInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SnapshotLocationRetentionInfo? LocalInfo
            // GraphQL -> localInfo: SnapshotLocationRetentionInfo (type)
            if (this.LocalInfo != null)
            {
                 s += ind + "localInfo\n";

                 s += ind + "{\n" + 
                 this.LocalInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<SnapshotLocationRetentionInfo>? ReplicationInfos
            // GraphQL -> replicationInfos: [SnapshotLocationRetentionInfo!]! (type)
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
            //      C# -> List<SnapshotLocationRetentionInfo>? ArchivalInfos
            // GraphQL -> archivalInfos: [SnapshotLocationRetentionInfo!]! (type)
            if (this.ArchivalInfos == null && Exploration.Includes(parent + ".archivalInfos"))
            {
                this.ArchivalInfos = new List<SnapshotLocationRetentionInfo>();
                this.ArchivalInfos.ApplyExploratoryFragment(parent + ".archivalInfos");
            }
            //      C# -> List<SnapshotLocationRetentionInfo>? CloudNativeLocationInfo
            // GraphQL -> cloudNativeLocationInfo: [SnapshotLocationRetentionInfo!]! (type)
            if (this.CloudNativeLocationInfo == null && Exploration.Includes(parent + ".cloudNativeLocationInfo"))
            {
                this.CloudNativeLocationInfo = new List<SnapshotLocationRetentionInfo>();
                this.CloudNativeLocationInfo.ApplyExploratoryFragment(parent + ".cloudNativeLocationInfo");
            }
            //      C# -> SnapshotLocationRetentionInfo? LocalInfo
            // GraphQL -> localInfo: SnapshotLocationRetentionInfo (type)
            if (this.LocalInfo == null && Exploration.Includes(parent + ".localInfo"))
            {
                this.LocalInfo = new SnapshotLocationRetentionInfo();
                this.LocalInfo.ApplyExploratoryFragment(parent + ".localInfo");
            }
            //      C# -> List<SnapshotLocationRetentionInfo>? ReplicationInfos
            // GraphQL -> replicationInfos: [SnapshotLocationRetentionInfo!]! (type)
            if (this.ReplicationInfos == null && Exploration.Includes(parent + ".replicationInfos"))
            {
                this.ReplicationInfos = new List<SnapshotLocationRetentionInfo>();
                this.ReplicationInfos.ApplyExploratoryFragment(parent + ".replicationInfos");
            }
        }


    #endregion

    } // class SnapshotRetentionInfo
    #endregion

    public static class ListSnapshotRetentionInfoExtensions
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
            this List<SnapshotRetentionInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SnapshotRetentionInfo> list, 
            String parent = "")
        {
            var item = new SnapshotRetentionInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types