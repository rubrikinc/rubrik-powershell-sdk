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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region MssqlDbReplica
    public class MssqlDbReplica: BaseType
    {
        #region members

        //      C# -> MssqlDbReplicaRecoveryModel? RecoveryModel
        // GraphQL -> recoveryModel: MssqlDbReplicaRecoveryModel! (enum)
        [JsonProperty("recoveryModel")]
        public MssqlDbReplicaRecoveryModel? RecoveryModel { get; set; }

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlDbReplica";
    }

    public MssqlDbReplica Set(
        MssqlDbReplicaRecoveryModel? RecoveryModel = null,
        System.Boolean? HasPermissions = null,
        System.String? InstanceId = null,
        System.String? InstanceName = null,
        System.Boolean? IsArchived = null,
        System.Boolean? IsDeleted = null,
        System.Boolean? IsStandby = null,
        System.String? RecoveryForkGuid = null,
        System.String? State = null,
        MssqlDbReplicaAvailabilityInfo? AvailabilityInfo = null,
        MssqlRootProperties? RootProperties = null
    ) 
    {
        if ( RecoveryModel != null ) {
            this.RecoveryModel = RecoveryModel;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> MssqlDbReplicaRecoveryModel? RecoveryModel
        // GraphQL -> recoveryModel: MssqlDbReplicaRecoveryModel! (enum)
        if (this.RecoveryModel != null) {
            s += ind + "recoveryModel\n" ;
        }
        //      C# -> System.Boolean? HasPermissions
        // GraphQL -> hasPermissions: Boolean! (scalar)
        if (this.HasPermissions != null) {
            s += ind + "hasPermissions\n" ;
        }
        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        if (this.InstanceId != null) {
            s += ind + "instanceId\n" ;
        }
        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        if (this.InstanceName != null) {
            s += ind + "instanceName\n" ;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            s += ind + "isArchived\n" ;
        }
        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        if (this.IsDeleted != null) {
            s += ind + "isDeleted\n" ;
        }
        //      C# -> System.Boolean? IsStandby
        // GraphQL -> isStandby: Boolean! (scalar)
        if (this.IsStandby != null) {
            s += ind + "isStandby\n" ;
        }
        //      C# -> System.String? RecoveryForkGuid
        // GraphQL -> recoveryForkGuid: String (scalar)
        if (this.RecoveryForkGuid != null) {
            s += ind + "recoveryForkGuid\n" ;
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (this.State != null) {
            s += ind + "state\n" ;
        }
        //      C# -> MssqlDbReplicaAvailabilityInfo? AvailabilityInfo
        // GraphQL -> availabilityInfo: MssqlDbReplicaAvailabilityInfo (type)
        if (this.AvailabilityInfo != null) {
            var fspec = this.AvailabilityInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "availabilityInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> MssqlRootProperties? RootProperties
        // GraphQL -> rootProperties: MssqlRootProperties (type)
        if (this.RootProperties != null) {
            var fspec = this.RootProperties.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "rootProperties {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> MssqlDbReplicaRecoveryModel? RecoveryModel
        // GraphQL -> recoveryModel: MssqlDbReplicaRecoveryModel! (enum)
        if (this.RecoveryModel == null && ec.Includes("recoveryModel",true))
        {
            this.RecoveryModel = new MssqlDbReplicaRecoveryModel();
        }
        //      C# -> System.Boolean? HasPermissions
        // GraphQL -> hasPermissions: Boolean! (scalar)
        if (this.HasPermissions == null && ec.Includes("hasPermissions",true))
        {
            this.HasPermissions = true;
        }
        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        if (this.InstanceId == null && ec.Includes("instanceId",true))
        {
            this.InstanceId = "FETCH";
        }
        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        if (this.InstanceName == null && ec.Includes("instanceName",true))
        {
            this.InstanceName = "FETCH";
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived == null && ec.Includes("isArchived",true))
        {
            this.IsArchived = true;
        }
        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        if (this.IsDeleted == null && ec.Includes("isDeleted",true))
        {
            this.IsDeleted = true;
        }
        //      C# -> System.Boolean? IsStandby
        // GraphQL -> isStandby: Boolean! (scalar)
        if (this.IsStandby == null && ec.Includes("isStandby",true))
        {
            this.IsStandby = true;
        }
        //      C# -> System.String? RecoveryForkGuid
        // GraphQL -> recoveryForkGuid: String (scalar)
        if (this.RecoveryForkGuid == null && ec.Includes("recoveryForkGuid",true))
        {
            this.RecoveryForkGuid = "FETCH";
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (this.State == null && ec.Includes("state",true))
        {
            this.State = "FETCH";
        }
        //      C# -> MssqlDbReplicaAvailabilityInfo? AvailabilityInfo
        // GraphQL -> availabilityInfo: MssqlDbReplicaAvailabilityInfo (type)
        if (this.AvailabilityInfo == null && ec.Includes("availabilityInfo",false))
        {
            this.AvailabilityInfo = new MssqlDbReplicaAvailabilityInfo();
            this.AvailabilityInfo.ApplyExploratoryFieldSpec(ec.NewChild("availabilityInfo"));
        }
        //      C# -> MssqlRootProperties? RootProperties
        // GraphQL -> rootProperties: MssqlRootProperties (type)
        if (this.RootProperties == null && ec.Includes("rootProperties",false))
        {
            this.RootProperties = new MssqlRootProperties();
            this.RootProperties.ApplyExploratoryFieldSpec(ec.NewChild("rootProperties"));
        }
    }


    #endregion

    } // class MssqlDbReplica
    
    #endregion

    public static class ListMssqlDbReplicaExtensions
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
            this List<MssqlDbReplica> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MssqlDbReplica> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlDbReplica());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlDbReplica> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types