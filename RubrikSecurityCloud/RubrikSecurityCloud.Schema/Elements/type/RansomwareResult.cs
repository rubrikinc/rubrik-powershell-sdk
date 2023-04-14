// RansomwareResult.cs
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
    #region RansomwareResult
    public class RansomwareResult: IFragment
    {
        #region members
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Single? EncryptionProbability
        // GraphQL -> encryptionProbability: Float! (scalar)
        [JsonProperty("encryptionProbability")]
        public System.Single? EncryptionProbability { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        [JsonProperty("isEncrypted")]
        public System.Boolean? IsEncrypted { get; set; }

        //      C# -> System.String? ManagedId
        // GraphQL -> managedId: String! (scalar)
        [JsonProperty("managedId")]
        public System.String? ManagedId { get; set; }

        //      C# -> DateTime? SnapshotData
        // GraphQL -> snapshotData: DateTime! (scalar)
        [JsonProperty("snapshotData")]
        public DateTime? SnapshotData { get; set; }

        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        #endregion

    #region methods

    public RansomwareResult Set(
        System.String? ClusterUuid = null,
        System.Single? EncryptionProbability = null,
        System.String? Id = null,
        System.Boolean? IsEncrypted = null,
        System.String? ManagedId = null,
        DateTime? SnapshotData = null,
        System.String? SnapshotFid = null,
        System.String? SnapshotId = null,
        System.String? WorkloadId = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( EncryptionProbability != null ) {
            this.EncryptionProbability = EncryptionProbability;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsEncrypted != null ) {
            this.IsEncrypted = IsEncrypted;
        }
        if ( ManagedId != null ) {
            this.ManagedId = ManagedId;
        }
        if ( SnapshotData != null ) {
            this.SnapshotData = SnapshotData;
        }
        if ( SnapshotFid != null ) {
            this.SnapshotFid = SnapshotFid;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
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
            //      C# -> System.Single? EncryptionProbability
            // GraphQL -> encryptionProbability: Float! (scalar)
            if (this.EncryptionProbability != null)
            {
                 s += ind + "encryptionProbability\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsEncrypted
            // GraphQL -> isEncrypted: Boolean! (scalar)
            if (this.IsEncrypted != null)
            {
                 s += ind + "isEncrypted\n";

            }
            //      C# -> System.String? ManagedId
            // GraphQL -> managedId: String! (scalar)
            if (this.ManagedId != null)
            {
                 s += ind + "managedId\n";

            }
            //      C# -> DateTime? SnapshotData
            // GraphQL -> snapshotData: DateTime! (scalar)
            if (this.SnapshotData != null)
            {
                 s += ind + "snapshotData\n";

            }
            //      C# -> System.String? SnapshotFid
            // GraphQL -> snapshotFid: String! (scalar)
            if (this.SnapshotFid != null)
            {
                 s += ind + "snapshotFid\n";

            }
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: String! (scalar)
            if (this.SnapshotId != null)
            {
                 s += ind + "snapshotId\n";

            }
            //      C# -> System.String? WorkloadId
            // GraphQL -> workloadId: String! (scalar)
            if (this.WorkloadId != null)
            {
                 s += ind + "workloadId\n";

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
            //      C# -> System.Single? EncryptionProbability
            // GraphQL -> encryptionProbability: Float! (scalar)
            if (this.EncryptionProbability == null && Exploration.Includes(parent + ".encryptionProbability$"))
            {
                this.EncryptionProbability = new System.Single();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsEncrypted
            // GraphQL -> isEncrypted: Boolean! (scalar)
            if (this.IsEncrypted == null && Exploration.Includes(parent + ".isEncrypted$"))
            {
                this.IsEncrypted = new System.Boolean();
            }
            //      C# -> System.String? ManagedId
            // GraphQL -> managedId: String! (scalar)
            if (this.ManagedId == null && Exploration.Includes(parent + ".managedId$"))
            {
                this.ManagedId = new System.String("FETCH");
            }
            //      C# -> DateTime? SnapshotData
            // GraphQL -> snapshotData: DateTime! (scalar)
            if (this.SnapshotData == null && Exploration.Includes(parent + ".snapshotData$"))
            {
                this.SnapshotData = new DateTime();
            }
            //      C# -> System.String? SnapshotFid
            // GraphQL -> snapshotFid: String! (scalar)
            if (this.SnapshotFid == null && Exploration.Includes(parent + ".snapshotFid$"))
            {
                this.SnapshotFid = new System.String("FETCH");
            }
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: String! (scalar)
            if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId$"))
            {
                this.SnapshotId = new System.String("FETCH");
            }
            //      C# -> System.String? WorkloadId
            // GraphQL -> workloadId: String! (scalar)
            if (this.WorkloadId == null && Exploration.Includes(parent + ".workloadId$"))
            {
                this.WorkloadId = new System.String("FETCH");
            }
        }


    #endregion

    } // class RansomwareResult
    #endregion

    public static class ListRansomwareResultExtensions
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
            this List<RansomwareResult> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RansomwareResult> list, 
            String parent = "")
        {
            var item = new RansomwareResult();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types