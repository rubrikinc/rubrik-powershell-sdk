// MssqlDbReplica.cs
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
    #region MssqlDbReplica
    public class MssqlDbReplica: IFragment
    {
        #region members
        //      C# -> System.Boolean? HasPermissions
        // GraphQL -> hasPermissions: Boolean! (scalar)
        [JsonProperty("hasPermissions")]
        public System.Boolean? HasPermissions { get; set; }

        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        [JsonProperty("instanceId")]
        public System.String? InstanceId { get; set; }

        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        [JsonProperty("instanceName")]
        public System.String? InstanceName { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        [JsonProperty("isDeleted")]
        public System.Boolean? IsDeleted { get; set; }

        //      C# -> System.Boolean? IsStandby
        // GraphQL -> isStandby: Boolean! (scalar)
        [JsonProperty("isStandby")]
        public System.Boolean? IsStandby { get; set; }

        //      C# -> System.String? RecoveryForkGuid
        // GraphQL -> recoveryForkGuid: String (scalar)
        [JsonProperty("recoveryForkGuid")]
        public System.String? RecoveryForkGuid { get; set; }

        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        [JsonProperty("state")]
        public System.String? State { get; set; }

        //      C# -> MssqlDbReplicaAvailabilityInfo? AvailabilityInfo
        // GraphQL -> availabilityInfo: MssqlDbReplicaAvailabilityInfo (type)
        [JsonProperty("availabilityInfo")]
        public MssqlDbReplicaAvailabilityInfo? AvailabilityInfo { get; set; }

        //      C# -> MssqlRootProperties? RootProperties
        // GraphQL -> rootProperties: MssqlRootProperties (type)
        [JsonProperty("rootProperties")]
        public MssqlRootProperties? RootProperties { get; set; }

        //      C# -> MssqlDbReplicaRecoveryModel? RecoveryModel
        // GraphQL -> recoveryModel: MssqlDbReplicaRecoveryModel! (enum)
        [JsonProperty("recoveryModel")]
        public MssqlDbReplicaRecoveryModel? RecoveryModel { get; set; }

        #endregion

    #region methods

    public MssqlDbReplica Set(
        System.Boolean? HasPermissions = null,
        System.String? InstanceId = null,
        System.String? InstanceName = null,
        System.Boolean? IsArchived = null,
        System.Boolean? IsDeleted = null,
        System.Boolean? IsStandby = null,
        System.String? RecoveryForkGuid = null,
        System.String? State = null,
        MssqlDbReplicaAvailabilityInfo? AvailabilityInfo = null,
        MssqlRootProperties? RootProperties = null,
        MssqlDbReplicaRecoveryModel? RecoveryModel = null
    ) 
    {
        if ( HasPermissions != null ) {
            this.HasPermissions = HasPermissions;
        }
        if ( InstanceId != null ) {
            this.InstanceId = InstanceId;
        }
        if ( InstanceName != null ) {
            this.InstanceName = InstanceName;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( IsDeleted != null ) {
            this.IsDeleted = IsDeleted;
        }
        if ( IsStandby != null ) {
            this.IsStandby = IsStandby;
        }
        if ( RecoveryForkGuid != null ) {
            this.RecoveryForkGuid = RecoveryForkGuid;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( AvailabilityInfo != null ) {
            this.AvailabilityInfo = AvailabilityInfo;
        }
        if ( RootProperties != null ) {
            this.RootProperties = RootProperties;
        }
        if ( RecoveryModel != null ) {
            this.RecoveryModel = RecoveryModel;
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
            //      C# -> System.Boolean? HasPermissions
            // GraphQL -> hasPermissions: Boolean! (scalar)
            if (this.HasPermissions != null)
            {
                 s += ind + "hasPermissions\n";

            }
            //      C# -> System.String? InstanceId
            // GraphQL -> instanceId: String! (scalar)
            if (this.InstanceId != null)
            {
                 s += ind + "instanceId\n";

            }
            //      C# -> System.String? InstanceName
            // GraphQL -> instanceName: String! (scalar)
            if (this.InstanceName != null)
            {
                 s += ind + "instanceName\n";

            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean! (scalar)
            if (this.IsArchived != null)
            {
                 s += ind + "isArchived\n";

            }
            //      C# -> System.Boolean? IsDeleted
            // GraphQL -> isDeleted: Boolean! (scalar)
            if (this.IsDeleted != null)
            {
                 s += ind + "isDeleted\n";

            }
            //      C# -> System.Boolean? IsStandby
            // GraphQL -> isStandby: Boolean! (scalar)
            if (this.IsStandby != null)
            {
                 s += ind + "isStandby\n";

            }
            //      C# -> System.String? RecoveryForkGuid
            // GraphQL -> recoveryForkGuid: String (scalar)
            if (this.RecoveryForkGuid != null)
            {
                 s += ind + "recoveryForkGuid\n";

            }
            //      C# -> System.String? State
            // GraphQL -> state: String! (scalar)
            if (this.State != null)
            {
                 s += ind + "state\n";

            }
            //      C# -> MssqlDbReplicaAvailabilityInfo? AvailabilityInfo
            // GraphQL -> availabilityInfo: MssqlDbReplicaAvailabilityInfo (type)
            if (this.AvailabilityInfo != null)
            {
                 s += ind + "availabilityInfo\n";

                 s += ind + "{\n" + 
                 this.AvailabilityInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> MssqlRootProperties? RootProperties
            // GraphQL -> rootProperties: MssqlRootProperties (type)
            if (this.RootProperties != null)
            {
                 s += ind + "rootProperties\n";

                 s += ind + "{\n" + 
                 this.RootProperties.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> MssqlDbReplicaRecoveryModel? RecoveryModel
            // GraphQL -> recoveryModel: MssqlDbReplicaRecoveryModel! (enum)
            if (this.RecoveryModel != null)
            {
                 s += ind + "recoveryModel\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? HasPermissions
            // GraphQL -> hasPermissions: Boolean! (scalar)
            if (this.HasPermissions == null && Exploration.Includes(parent + ".hasPermissions$"))
            {
                this.HasPermissions = new System.Boolean();
            }
            //      C# -> System.String? InstanceId
            // GraphQL -> instanceId: String! (scalar)
            if (this.InstanceId == null && Exploration.Includes(parent + ".instanceId$"))
            {
                this.InstanceId = new System.String("FETCH");
            }
            //      C# -> System.String? InstanceName
            // GraphQL -> instanceName: String! (scalar)
            if (this.InstanceName == null && Exploration.Includes(parent + ".instanceName$"))
            {
                this.InstanceName = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean! (scalar)
            if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived$"))
            {
                this.IsArchived = new System.Boolean();
            }
            //      C# -> System.Boolean? IsDeleted
            // GraphQL -> isDeleted: Boolean! (scalar)
            if (this.IsDeleted == null && Exploration.Includes(parent + ".isDeleted$"))
            {
                this.IsDeleted = new System.Boolean();
            }
            //      C# -> System.Boolean? IsStandby
            // GraphQL -> isStandby: Boolean! (scalar)
            if (this.IsStandby == null && Exploration.Includes(parent + ".isStandby$"))
            {
                this.IsStandby = new System.Boolean();
            }
            //      C# -> System.String? RecoveryForkGuid
            // GraphQL -> recoveryForkGuid: String (scalar)
            if (this.RecoveryForkGuid == null && Exploration.Includes(parent + ".recoveryForkGuid$"))
            {
                this.RecoveryForkGuid = new System.String("FETCH");
            }
            //      C# -> System.String? State
            // GraphQL -> state: String! (scalar)
            if (this.State == null && Exploration.Includes(parent + ".state$"))
            {
                this.State = new System.String("FETCH");
            }
            //      C# -> MssqlDbReplicaAvailabilityInfo? AvailabilityInfo
            // GraphQL -> availabilityInfo: MssqlDbReplicaAvailabilityInfo (type)
            if (this.AvailabilityInfo == null && Exploration.Includes(parent + ".availabilityInfo"))
            {
                this.AvailabilityInfo = new MssqlDbReplicaAvailabilityInfo();
                this.AvailabilityInfo.ApplyExploratoryFragment(parent + ".availabilityInfo");
            }
            //      C# -> MssqlRootProperties? RootProperties
            // GraphQL -> rootProperties: MssqlRootProperties (type)
            if (this.RootProperties == null && Exploration.Includes(parent + ".rootProperties"))
            {
                this.RootProperties = new MssqlRootProperties();
                this.RootProperties.ApplyExploratoryFragment(parent + ".rootProperties");
            }
            //      C# -> MssqlDbReplicaRecoveryModel? RecoveryModel
            // GraphQL -> recoveryModel: MssqlDbReplicaRecoveryModel! (enum)
            if (this.RecoveryModel == null && Exploration.Includes(parent + ".recoveryModel$"))
            {
                this.RecoveryModel = new MssqlDbReplicaRecoveryModel();
            }
        }


    #endregion

    } // class MssqlDbReplica
    #endregion

    public static class ListMssqlDbReplicaExtensions
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
            this List<MssqlDbReplica> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MssqlDbReplica> list, 
            String parent = "")
        {
            var item = new MssqlDbReplica();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types