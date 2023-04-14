// CdmMssqlDbReplica.cs
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
    #region CdmMssqlDbReplica
    public class CdmMssqlDbReplica: IFragment
    {
        #region members
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Boolean? HasPermissions
        // GraphQL -> hasPermissions: Boolean! (scalar)
        [JsonProperty("hasPermissions")]
        public System.Boolean? HasPermissions { get; set; }

        //      C# -> System.String? InstanceRootId
        // GraphQL -> instanceRootId: String! (scalar)
        [JsonProperty("instanceRootId")]
        public System.String? InstanceRootId { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.Boolean? IsStandBy
        // GraphQL -> isStandBy: Boolean! (scalar)
        [JsonProperty("isStandBy")]
        public System.Boolean? IsStandBy { get; set; }

        //      C# -> System.String? RecoveryModel
        // GraphQL -> recoveryModel: String! (scalar)
        [JsonProperty("recoveryModel")]
        public System.String? RecoveryModel { get; set; }

        //      C# -> System.Boolean? SnapshotNeeded
        // GraphQL -> snapshotNeeded: Boolean! (scalar)
        [JsonProperty("snapshotNeeded")]
        public System.Boolean? SnapshotNeeded { get; set; }

        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        [JsonProperty("state")]
        public System.String? State { get; set; }

        //      C# -> CdmMssqlDbReplicaAvailabilityInfo? AvailabilityInfo
        // GraphQL -> availabilityInfo: CdmMssqlDbReplicaAvailabilityInfo (type)
        [JsonProperty("availabilityInfo")]
        public CdmMssqlDbReplicaAvailabilityInfo? AvailabilityInfo { get; set; }

        //      C# -> MssqlInstance? Instance
        // GraphQL -> instance: MssqlInstance (type)
        [JsonProperty("instance")]
        public MssqlInstance? Instance { get; set; }

        #endregion

    #region methods

    public CdmMssqlDbReplica Set(
        System.String? ClusterUuid = null,
        System.Boolean? HasPermissions = null,
        System.String? InstanceRootId = null,
        System.Boolean? IsArchived = null,
        System.Boolean? IsStandBy = null,
        System.String? RecoveryModel = null,
        System.Boolean? SnapshotNeeded = null,
        System.String? State = null,
        CdmMssqlDbReplicaAvailabilityInfo? AvailabilityInfo = null,
        MssqlInstance? Instance = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( HasPermissions != null ) {
            this.HasPermissions = HasPermissions;
        }
        if ( InstanceRootId != null ) {
            this.InstanceRootId = InstanceRootId;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( IsStandBy != null ) {
            this.IsStandBy = IsStandBy;
        }
        if ( RecoveryModel != null ) {
            this.RecoveryModel = RecoveryModel;
        }
        if ( SnapshotNeeded != null ) {
            this.SnapshotNeeded = SnapshotNeeded;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( AvailabilityInfo != null ) {
            this.AvailabilityInfo = AvailabilityInfo;
        }
        if ( Instance != null ) {
            this.Instance = Instance;
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
            //      C# -> System.Boolean? HasPermissions
            // GraphQL -> hasPermissions: Boolean! (scalar)
            if (this.HasPermissions != null)
            {
                 s += ind + "hasPermissions\n";

            }
            //      C# -> System.String? InstanceRootId
            // GraphQL -> instanceRootId: String! (scalar)
            if (this.InstanceRootId != null)
            {
                 s += ind + "instanceRootId\n";

            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean! (scalar)
            if (this.IsArchived != null)
            {
                 s += ind + "isArchived\n";

            }
            //      C# -> System.Boolean? IsStandBy
            // GraphQL -> isStandBy: Boolean! (scalar)
            if (this.IsStandBy != null)
            {
                 s += ind + "isStandBy\n";

            }
            //      C# -> System.String? RecoveryModel
            // GraphQL -> recoveryModel: String! (scalar)
            if (this.RecoveryModel != null)
            {
                 s += ind + "recoveryModel\n";

            }
            //      C# -> System.Boolean? SnapshotNeeded
            // GraphQL -> snapshotNeeded: Boolean! (scalar)
            if (this.SnapshotNeeded != null)
            {
                 s += ind + "snapshotNeeded\n";

            }
            //      C# -> System.String? State
            // GraphQL -> state: String! (scalar)
            if (this.State != null)
            {
                 s += ind + "state\n";

            }
            //      C# -> CdmMssqlDbReplicaAvailabilityInfo? AvailabilityInfo
            // GraphQL -> availabilityInfo: CdmMssqlDbReplicaAvailabilityInfo (type)
            if (this.AvailabilityInfo != null)
            {
                 s += ind + "availabilityInfo\n";

                 s += ind + "{\n" + 
                 this.AvailabilityInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> MssqlInstance? Instance
            // GraphQL -> instance: MssqlInstance (type)
            if (this.Instance != null)
            {
                 s += ind + "instance\n";

                 s += ind + "{\n" + 
                 this.Instance.AsFragment(indent+1) + 
                 ind + "}\n";
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
            //      C# -> System.Boolean? HasPermissions
            // GraphQL -> hasPermissions: Boolean! (scalar)
            if (this.HasPermissions == null && Exploration.Includes(parent + ".hasPermissions$"))
            {
                this.HasPermissions = new System.Boolean();
            }
            //      C# -> System.String? InstanceRootId
            // GraphQL -> instanceRootId: String! (scalar)
            if (this.InstanceRootId == null && Exploration.Includes(parent + ".instanceRootId$"))
            {
                this.InstanceRootId = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean! (scalar)
            if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived$"))
            {
                this.IsArchived = new System.Boolean();
            }
            //      C# -> System.Boolean? IsStandBy
            // GraphQL -> isStandBy: Boolean! (scalar)
            if (this.IsStandBy == null && Exploration.Includes(parent + ".isStandBy$"))
            {
                this.IsStandBy = new System.Boolean();
            }
            //      C# -> System.String? RecoveryModel
            // GraphQL -> recoveryModel: String! (scalar)
            if (this.RecoveryModel == null && Exploration.Includes(parent + ".recoveryModel$"))
            {
                this.RecoveryModel = new System.String("FETCH");
            }
            //      C# -> System.Boolean? SnapshotNeeded
            // GraphQL -> snapshotNeeded: Boolean! (scalar)
            if (this.SnapshotNeeded == null && Exploration.Includes(parent + ".snapshotNeeded$"))
            {
                this.SnapshotNeeded = new System.Boolean();
            }
            //      C# -> System.String? State
            // GraphQL -> state: String! (scalar)
            if (this.State == null && Exploration.Includes(parent + ".state$"))
            {
                this.State = new System.String("FETCH");
            }
            //      C# -> CdmMssqlDbReplicaAvailabilityInfo? AvailabilityInfo
            // GraphQL -> availabilityInfo: CdmMssqlDbReplicaAvailabilityInfo (type)
            if (this.AvailabilityInfo == null && Exploration.Includes(parent + ".availabilityInfo"))
            {
                this.AvailabilityInfo = new CdmMssqlDbReplicaAvailabilityInfo();
                this.AvailabilityInfo.ApplyExploratoryFragment(parent + ".availabilityInfo");
            }
            //      C# -> MssqlInstance? Instance
            // GraphQL -> instance: MssqlInstance (type)
            if (this.Instance == null && Exploration.Includes(parent + ".instance"))
            {
                this.Instance = new MssqlInstance();
                this.Instance.ApplyExploratoryFragment(parent + ".instance");
            }
        }


    #endregion

    } // class CdmMssqlDbReplica
    #endregion

    public static class ListCdmMssqlDbReplicaExtensions
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
            this List<CdmMssqlDbReplica> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CdmMssqlDbReplica> list, 
            String parent = "")
        {
            var item = new CdmMssqlDbReplica();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types