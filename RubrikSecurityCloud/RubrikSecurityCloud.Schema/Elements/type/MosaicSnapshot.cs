// MosaicSnapshot.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:17.
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
    #region MosaicSnapshot
    public class MosaicSnapshot: IFragment
    {
        #region members
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? DbInfo
        // GraphQL -> dbInfo: String (scalar)
        [JsonProperty("dbInfo")]
        public System.String? DbInfo { get; set; }

        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        [JsonProperty("expirationTime")]
        public DateTime? ExpirationTime { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int32? JobDuration
        // GraphQL -> jobDuration: Int (scalar)
        [JsonProperty("jobDuration")]
        public System.Int32? JobDuration { get; set; }

        //      C# -> DateTime? Version
        // GraphQL -> version: DateTime! (scalar)
        [JsonProperty("version")]
        public DateTime? Version { get; set; }

        //      C# -> System.String? VersionState
        // GraphQL -> versionState: String (scalar)
        [JsonProperty("versionState")]
        public System.String? VersionState { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> MosaicSnapshotType? SnapshotType
        // GraphQL -> snapshotType: MosaicSnapshotType! (enum)
        [JsonProperty("snapshotType")]
        public MosaicSnapshotType? SnapshotType { get; set; }

        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        [JsonProperty("slaDomain")]
        public SlaDomain? SlaDomain { get; set; }

        #endregion

    #region methods

    public MosaicSnapshot Set(
        System.String? ClusterUuid = null,
        System.String? DbInfo = null,
        DateTime? ExpirationTime = null,
        System.String? Id = null,
        System.Int32? JobDuration = null,
        DateTime? Version = null,
        System.String? VersionState = null,
        System.String? WorkloadId = null,
        MosaicSnapshotType? SnapshotType = null,
        SlaDomain? SlaDomain = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( DbInfo != null ) {
            this.DbInfo = DbInfo;
        }
        if ( ExpirationTime != null ) {
            this.ExpirationTime = ExpirationTime;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( JobDuration != null ) {
            this.JobDuration = JobDuration;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( VersionState != null ) {
            this.VersionState = VersionState;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
        }
        if ( SnapshotType != null ) {
            this.SnapshotType = SnapshotType;
        }
        if ( SlaDomain != null ) {
            this.SlaDomain = SlaDomain;
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
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: UUID! (scalar)
            if (this.ClusterUuid != null)
            {
                 s += ind + "clusterUuid\n";

            }
            //      C# -> System.String? DbInfo
            // GraphQL -> dbInfo: String (scalar)
            if (this.DbInfo != null)
            {
                 s += ind + "dbInfo\n";

            }
            //      C# -> DateTime? ExpirationTime
            // GraphQL -> expirationTime: DateTime (scalar)
            if (this.ExpirationTime != null)
            {
                 s += ind + "expirationTime\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Int32? JobDuration
            // GraphQL -> jobDuration: Int (scalar)
            if (this.JobDuration != null)
            {
                 s += ind + "jobDuration\n";

            }
            //      C# -> DateTime? Version
            // GraphQL -> version: DateTime! (scalar)
            if (this.Version != null)
            {
                 s += ind + "version\n";

            }
            //      C# -> System.String? VersionState
            // GraphQL -> versionState: String (scalar)
            if (this.VersionState != null)
            {
                 s += ind + "versionState\n";

            }
            //      C# -> System.String? WorkloadId
            // GraphQL -> workloadId: String! (scalar)
            if (this.WorkloadId != null)
            {
                 s += ind + "workloadId\n";

            }
            //      C# -> MosaicSnapshotType? SnapshotType
            // GraphQL -> snapshotType: MosaicSnapshotType! (enum)
            if (this.SnapshotType != null)
            {
                 s += ind + "snapshotType\n";

            }
                        //      C# -> SlaDomain? SlaDomain
            // GraphQL -> slaDomain: SlaDomain (interface)
            if (this.SlaDomain != null)
            {
                s += ind + "slaDomain\n";
                s += ind + "{\n";

                string typename = this.SlaDomain.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.SlaDomain.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: UUID! (scalar)
            if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid$"))
            {
                this.ClusterUuid = new System.String("FETCH");
            }
            //      C# -> System.String? DbInfo
            // GraphQL -> dbInfo: String (scalar)
            if (this.DbInfo == null && Exploration.Includes(parent + ".dbInfo$"))
            {
                this.DbInfo = new System.String("FETCH");
            }
            //      C# -> DateTime? ExpirationTime
            // GraphQL -> expirationTime: DateTime (scalar)
            if (this.ExpirationTime == null && Exploration.Includes(parent + ".expirationTime$"))
            {
                this.ExpirationTime = new DateTime();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Int32? JobDuration
            // GraphQL -> jobDuration: Int (scalar)
            if (this.JobDuration == null && Exploration.Includes(parent + ".jobDuration$"))
            {
                this.JobDuration = new System.Int32();
            }
            //      C# -> DateTime? Version
            // GraphQL -> version: DateTime! (scalar)
            if (this.Version == null && Exploration.Includes(parent + ".version$"))
            {
                this.Version = new DateTime();
            }
            //      C# -> System.String? VersionState
            // GraphQL -> versionState: String (scalar)
            if (this.VersionState == null && Exploration.Includes(parent + ".versionState$"))
            {
                this.VersionState = new System.String("FETCH");
            }
            //      C# -> System.String? WorkloadId
            // GraphQL -> workloadId: String! (scalar)
            if (this.WorkloadId == null && Exploration.Includes(parent + ".workloadId$"))
            {
                this.WorkloadId = new System.String("FETCH");
            }
            //      C# -> MosaicSnapshotType? SnapshotType
            // GraphQL -> snapshotType: MosaicSnapshotType! (enum)
            if (this.SnapshotType == null && Exploration.Includes(parent + ".snapshotType$"))
            {
                this.SnapshotType = new MosaicSnapshotType();
            }
            //      C# -> SlaDomain? SlaDomain
            // GraphQL -> slaDomain: SlaDomain (interface)
            if (this.SlaDomain == null && Exploration.Includes(parent + ".slaDomain"))
            {
                this.SlaDomain = (SlaDomain)InterfaceHelper.CreateInstanceOfFirstType(typeof(SlaDomain));
                this.SlaDomain.ApplyExploratoryFragment(parent + ".slaDomain");
            }
        }


    #endregion

    } // class MosaicSnapshot
    #endregion

    public static class ListMosaicSnapshotExtensions
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
            this List<MosaicSnapshot> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MosaicSnapshot> list, 
            String parent = "")
        {
            var item = new MosaicSnapshot();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types