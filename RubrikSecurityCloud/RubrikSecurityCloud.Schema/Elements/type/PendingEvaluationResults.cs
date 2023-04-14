// PendingEvaluationResults.cs
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
    #region PendingEvaluationResults
    public class PendingEvaluationResults: IFragment
    {
        #region members
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.String? Info
        // GraphQL -> info: String! (scalar)
        [JsonProperty("info")]
        public System.String? Info { get; set; }

        //      C# -> System.Boolean? IsCompleted
        // GraphQL -> isCompleted: Boolean! (scalar)
        [JsonProperty("isCompleted")]
        public System.Boolean? IsCompleted { get; set; }

        //      C# -> System.String? ManagedId
        // GraphQL -> managedId: String! (scalar)
        [JsonProperty("managedId")]
        public System.String? ManagedId { get; set; }

        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        [JsonProperty("snapshotDate")]
        public DateTime? SnapshotDate { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String! (scalar)
        [JsonProperty("workloadName")]
        public System.String? WorkloadName { get; set; }

        //      C# -> System.String? WorkloadType
        // GraphQL -> workloadType: String! (scalar)
        [JsonProperty("workloadType")]
        public System.String? WorkloadType { get; set; }

        #endregion

    #region methods

    public PendingEvaluationResults Set(
        System.String? ClusterUuid = null,
        DateTime? CreatedAt = null,
        System.String? Info = null,
        System.Boolean? IsCompleted = null,
        System.String? ManagedId = null,
        DateTime? SnapshotDate = null,
        System.String? SnapshotId = null,
        DateTime? UpdatedAt = null,
        System.String? WorkloadId = null,
        System.String? WorkloadName = null,
        System.String? WorkloadType = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( Info != null ) {
            this.Info = Info;
        }
        if ( IsCompleted != null ) {
            this.IsCompleted = IsCompleted;
        }
        if ( ManagedId != null ) {
            this.ManagedId = ManagedId;
        }
        if ( SnapshotDate != null ) {
            this.SnapshotDate = SnapshotDate;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( UpdatedAt != null ) {
            this.UpdatedAt = UpdatedAt;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
        }
        if ( WorkloadName != null ) {
            this.WorkloadName = WorkloadName;
        }
        if ( WorkloadType != null ) {
            this.WorkloadType = WorkloadType;
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
            // GraphQL -> clusterUuid: String! (scalar)
            if (this.ClusterUuid != null)
            {
                 s += ind + "clusterUuid\n";

            }
            //      C# -> DateTime? CreatedAt
            // GraphQL -> createdAt: DateTime (scalar)
            if (this.CreatedAt != null)
            {
                 s += ind + "createdAt\n";

            }
            //      C# -> System.String? Info
            // GraphQL -> info: String! (scalar)
            if (this.Info != null)
            {
                 s += ind + "info\n";

            }
            //      C# -> System.Boolean? IsCompleted
            // GraphQL -> isCompleted: Boolean! (scalar)
            if (this.IsCompleted != null)
            {
                 s += ind + "isCompleted\n";

            }
            //      C# -> System.String? ManagedId
            // GraphQL -> managedId: String! (scalar)
            if (this.ManagedId != null)
            {
                 s += ind + "managedId\n";

            }
            //      C# -> DateTime? SnapshotDate
            // GraphQL -> snapshotDate: DateTime (scalar)
            if (this.SnapshotDate != null)
            {
                 s += ind + "snapshotDate\n";

            }
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: String! (scalar)
            if (this.SnapshotId != null)
            {
                 s += ind + "snapshotId\n";

            }
            //      C# -> DateTime? UpdatedAt
            // GraphQL -> updatedAt: DateTime (scalar)
            if (this.UpdatedAt != null)
            {
                 s += ind + "updatedAt\n";

            }
            //      C# -> System.String? WorkloadId
            // GraphQL -> workloadId: String! (scalar)
            if (this.WorkloadId != null)
            {
                 s += ind + "workloadId\n";

            }
            //      C# -> System.String? WorkloadName
            // GraphQL -> workloadName: String! (scalar)
            if (this.WorkloadName != null)
            {
                 s += ind + "workloadName\n";

            }
            //      C# -> System.String? WorkloadType
            // GraphQL -> workloadType: String! (scalar)
            if (this.WorkloadType != null)
            {
                 s += ind + "workloadType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: String! (scalar)
            if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid$"))
            {
                this.ClusterUuid = new System.String("FETCH");
            }
            //      C# -> DateTime? CreatedAt
            // GraphQL -> createdAt: DateTime (scalar)
            if (this.CreatedAt == null && Exploration.Includes(parent + ".createdAt$"))
            {
                this.CreatedAt = new DateTime();
            }
            //      C# -> System.String? Info
            // GraphQL -> info: String! (scalar)
            if (this.Info == null && Exploration.Includes(parent + ".info$"))
            {
                this.Info = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsCompleted
            // GraphQL -> isCompleted: Boolean! (scalar)
            if (this.IsCompleted == null && Exploration.Includes(parent + ".isCompleted$"))
            {
                this.IsCompleted = new System.Boolean();
            }
            //      C# -> System.String? ManagedId
            // GraphQL -> managedId: String! (scalar)
            if (this.ManagedId == null && Exploration.Includes(parent + ".managedId$"))
            {
                this.ManagedId = new System.String("FETCH");
            }
            //      C# -> DateTime? SnapshotDate
            // GraphQL -> snapshotDate: DateTime (scalar)
            if (this.SnapshotDate == null && Exploration.Includes(parent + ".snapshotDate$"))
            {
                this.SnapshotDate = new DateTime();
            }
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: String! (scalar)
            if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId$"))
            {
                this.SnapshotId = new System.String("FETCH");
            }
            //      C# -> DateTime? UpdatedAt
            // GraphQL -> updatedAt: DateTime (scalar)
            if (this.UpdatedAt == null && Exploration.Includes(parent + ".updatedAt$"))
            {
                this.UpdatedAt = new DateTime();
            }
            //      C# -> System.String? WorkloadId
            // GraphQL -> workloadId: String! (scalar)
            if (this.WorkloadId == null && Exploration.Includes(parent + ".workloadId$"))
            {
                this.WorkloadId = new System.String("FETCH");
            }
            //      C# -> System.String? WorkloadName
            // GraphQL -> workloadName: String! (scalar)
            if (this.WorkloadName == null && Exploration.Includes(parent + ".workloadName$"))
            {
                this.WorkloadName = new System.String("FETCH");
            }
            //      C# -> System.String? WorkloadType
            // GraphQL -> workloadType: String! (scalar)
            if (this.WorkloadType == null && Exploration.Includes(parent + ".workloadType$"))
            {
                this.WorkloadType = new System.String("FETCH");
            }
        }


    #endregion

    } // class PendingEvaluationResults
    #endregion

    public static class ListPendingEvaluationResultsExtensions
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
            this List<PendingEvaluationResults> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PendingEvaluationResults> list, 
            String parent = "")
        {
            var item = new PendingEvaluationResults();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types