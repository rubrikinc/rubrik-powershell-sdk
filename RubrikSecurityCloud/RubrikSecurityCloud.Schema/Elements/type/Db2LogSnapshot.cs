// Db2LogSnapshot.cs
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
    #region Db2LogSnapshot
    public class Db2LogSnapshot: IFragment
    {
        #region members
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.Int64? InternalTimestamp
        // GraphQL -> internalTimestamp: Long! (scalar)
        [JsonProperty("internalTimestamp")]
        public System.Int64? InternalTimestamp { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> System.String? WorkloadType
        // GraphQL -> workloadType: String! (scalar)
        [JsonProperty("workloadType")]
        public System.String? WorkloadType { get; set; }

        //      C# -> Db2LogSnapshotAppMetadata? AppMetadata
        // GraphQL -> appMetadata: Db2LogSnapshotAppMetadata (type)
        [JsonProperty("appMetadata")]
        public Db2LogSnapshotAppMetadata? AppMetadata { get; set; }

        #endregion

    #region methods

    public Db2LogSnapshot Set(
        System.String? CdmId = null,
        System.String? ClusterUuid = null,
        DateTime? Date = null,
        System.String? Fid = null,
        System.Int64? InternalTimestamp = null,
        System.Boolean? IsArchived = null,
        System.String? WorkloadId = null,
        System.String? WorkloadType = null,
        Db2LogSnapshotAppMetadata? AppMetadata = null
    ) 
    {
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( Date != null ) {
            this.Date = Date;
        }
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( InternalTimestamp != null ) {
            this.InternalTimestamp = InternalTimestamp;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
        }
        if ( WorkloadType != null ) {
            this.WorkloadType = WorkloadType;
        }
        if ( AppMetadata != null ) {
            this.AppMetadata = AppMetadata;
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
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: String! (scalar)
            if (this.CdmId != null)
            {
                 s += ind + "cdmId\n";

            }
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: UUID! (scalar)
            if (this.ClusterUuid != null)
            {
                 s += ind + "clusterUuid\n";

            }
            //      C# -> DateTime? Date
            // GraphQL -> date: DateTime (scalar)
            if (this.Date != null)
            {
                 s += ind + "date\n";

            }
            //      C# -> System.String? Fid
            // GraphQL -> fid: String! (scalar)
            if (this.Fid != null)
            {
                 s += ind + "fid\n";

            }
            //      C# -> System.Int64? InternalTimestamp
            // GraphQL -> internalTimestamp: Long! (scalar)
            if (this.InternalTimestamp != null)
            {
                 s += ind + "internalTimestamp\n";

            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean! (scalar)
            if (this.IsArchived != null)
            {
                 s += ind + "isArchived\n";

            }
            //      C# -> System.String? WorkloadId
            // GraphQL -> workloadId: String! (scalar)
            if (this.WorkloadId != null)
            {
                 s += ind + "workloadId\n";

            }
            //      C# -> System.String? WorkloadType
            // GraphQL -> workloadType: String! (scalar)
            if (this.WorkloadType != null)
            {
                 s += ind + "workloadType\n";

            }
            //      C# -> Db2LogSnapshotAppMetadata? AppMetadata
            // GraphQL -> appMetadata: Db2LogSnapshotAppMetadata (type)
            if (this.AppMetadata != null)
            {
                 s += ind + "appMetadata\n";

                 s += ind + "{\n" + 
                 this.AppMetadata.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: String! (scalar)
            if (this.CdmId == null && Exploration.Includes(parent + ".cdmId$"))
            {
                this.CdmId = new System.String("FETCH");
            }
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: UUID! (scalar)
            if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid$"))
            {
                this.ClusterUuid = new System.String("FETCH");
            }
            //      C# -> DateTime? Date
            // GraphQL -> date: DateTime (scalar)
            if (this.Date == null && Exploration.Includes(parent + ".date$"))
            {
                this.Date = new DateTime();
            }
            //      C# -> System.String? Fid
            // GraphQL -> fid: String! (scalar)
            if (this.Fid == null && Exploration.Includes(parent + ".fid$"))
            {
                this.Fid = new System.String("FETCH");
            }
            //      C# -> System.Int64? InternalTimestamp
            // GraphQL -> internalTimestamp: Long! (scalar)
            if (this.InternalTimestamp == null && Exploration.Includes(parent + ".internalTimestamp$"))
            {
                this.InternalTimestamp = new System.Int64();
            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean! (scalar)
            if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived$"))
            {
                this.IsArchived = new System.Boolean();
            }
            //      C# -> System.String? WorkloadId
            // GraphQL -> workloadId: String! (scalar)
            if (this.WorkloadId == null && Exploration.Includes(parent + ".workloadId$"))
            {
                this.WorkloadId = new System.String("FETCH");
            }
            //      C# -> System.String? WorkloadType
            // GraphQL -> workloadType: String! (scalar)
            if (this.WorkloadType == null && Exploration.Includes(parent + ".workloadType$"))
            {
                this.WorkloadType = new System.String("FETCH");
            }
            //      C# -> Db2LogSnapshotAppMetadata? AppMetadata
            // GraphQL -> appMetadata: Db2LogSnapshotAppMetadata (type)
            if (this.AppMetadata == null && Exploration.Includes(parent + ".appMetadata"))
            {
                this.AppMetadata = new Db2LogSnapshotAppMetadata();
                this.AppMetadata.ApplyExploratoryFragment(parent + ".appMetadata");
            }
        }


    #endregion

    } // class Db2LogSnapshot
    #endregion

    public static class ListDb2LogSnapshotExtensions
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
            this List<Db2LogSnapshot> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Db2LogSnapshot> list, 
            String parent = "")
        {
            var item = new Db2LogSnapshot();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types