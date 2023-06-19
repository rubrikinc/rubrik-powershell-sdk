// MssqlDbSummary.cs
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
    #region MssqlDbSummary
    public class MssqlDbSummary: BaseType
    {
        #region members

        //      C# -> MssqlDbSummaryRecoveryModel? RecoveryModel
        // GraphQL -> recoveryModel: MssqlDbSummaryRecoveryModel (enum)
        [JsonProperty("recoveryModel")]
        public MssqlDbSummaryRecoveryModel? RecoveryModel { get; set; }

        //      C# -> System.String? AvailabilityGroupId
        // GraphQL -> availabilityGroupId: String (scalar)
        [JsonProperty("availabilityGroupId")]
        public System.String? AvailabilityGroupId { get; set; }

        //      C# -> System.Boolean? CopyOnly
        // GraphQL -> copyOnly: Boolean! (scalar)
        [JsonProperty("copyOnly")]
        public System.Boolean? CopyOnly { get; set; }

        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        [JsonProperty("hasLogConfigFromSla")]
        public System.Boolean? HasLogConfigFromSla { get; set; }

        //      C# -> System.Boolean? HasPermissions
        // GraphQL -> hasPermissions: Boolean! (scalar)
        [JsonProperty("hasPermissions")]
        public System.Boolean? HasPermissions { get; set; }

        //      C# -> System.Int32? HostLogRetentionInSeconds
        // GraphQL -> hostLogRetentionInSeconds: Int (scalar)
        [JsonProperty("hostLogRetentionInSeconds")]
        public System.Int32? HostLogRetentionInSeconds { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IncludeBackupTaskInfo
        // GraphQL -> includeBackupTaskInfo: Boolean (scalar)
        [JsonProperty("includeBackupTaskInfo")]
        public System.Boolean? IncludeBackupTaskInfo { get; set; }

        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String (scalar)
        [JsonProperty("instanceId")]
        public System.String? InstanceId { get; set; }

        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String (scalar)
        [JsonProperty("instanceName")]
        public System.String? InstanceName { get; set; }

        //      C# -> System.Boolean? IsInAvailabilityGroup
        // GraphQL -> isInAvailabilityGroup: Boolean! (scalar)
        [JsonProperty("isInAvailabilityGroup")]
        public System.Boolean? IsInAvailabilityGroup { get; set; }

        //      C# -> System.Boolean? IsLiveMount
        // GraphQL -> isLiveMount: Boolean! (scalar)
        [JsonProperty("isLiveMount")]
        public System.Boolean? IsLiveMount { get; set; }

        //      C# -> System.Boolean? IsLogShippingSecondary
        // GraphQL -> isLogShippingSecondary: Boolean! (scalar)
        [JsonProperty("isLogShippingSecondary")]
        public System.Boolean? IsLogShippingSecondary { get; set; }

        //      C# -> System.Boolean? IsOnline
        // GraphQL -> isOnline: Boolean! (scalar)
        [JsonProperty("isOnline")]
        public System.Boolean? IsOnline { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> DateTime? LastSnapshotTime
        // GraphQL -> lastSnapshotTime: DateTime (scalar)
        [JsonProperty("lastSnapshotTime")]
        public DateTime? LastSnapshotTime { get; set; }

        //      C# -> System.Int32? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Int! (scalar)
        [JsonProperty("logBackupFrequencyInSeconds")]
        public System.Int32? LogBackupFrequencyInSeconds { get; set; }

        //      C# -> System.Int32? LogBackupRetentionHours
        // GraphQL -> logBackupRetentionHours: Int! (scalar)
        [JsonProperty("logBackupRetentionHours")]
        public System.Int32? LogBackupRetentionHours { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumMissedSnapshot
        // GraphQL -> numMissedSnapshot: Int (scalar)
        [JsonProperty("numMissedSnapshot")]
        public System.Int32? NumMissedSnapshot { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }

        //      C# -> System.String? State
        // GraphQL -> state: String (scalar)
        [JsonProperty("state")]
        public System.String? State { get; set; }

        //      C# -> List<System.String>? UnprotectableReasonsV51
        // GraphQL -> unprotectableReasonsV51: [String!]! (scalar)
        [JsonProperty("unprotectableReasonsV51")]
        public List<System.String>? UnprotectableReasonsV51 { get; set; }

        //      C# -> List<System.String>? UnprotectableReasonsV52
        // GraphQL -> unprotectableReasonsV52: [String!]! (scalar)
        [JsonProperty("unprotectableReasonsV52")]
        public List<System.String>? UnprotectableReasonsV52 { get; set; }

        //      C# -> List<System.String>? UnprotectableReasonsV53
        // GraphQL -> unprotectableReasonsV53: [String!]! (scalar)
        [JsonProperty("unprotectableReasonsV53")]
        public List<System.String>? UnprotectableReasonsV53 { get; set; }

        //      C# -> List<System.String>? UnprotectableReasonsV60
        // GraphQL -> unprotectableReasonsV60: [String!]! (scalar)
        [JsonProperty("unprotectableReasonsV60")]
        public List<System.String>? UnprotectableReasonsV60 { get; set; }

        //      C# -> List<System.String>? UnprotectableReasonsV70
        // GraphQL -> unprotectableReasonsV70: [String!]! (scalar)
        [JsonProperty("unprotectableReasonsV70")]
        public List<System.String>? UnprotectableReasonsV70 { get; set; }

        //      C# -> List<System.String>? UnprotectableReasonsV80
        // GraphQL -> unprotectableReasonsV80: [String!]! (scalar)
        [JsonProperty("unprotectableReasonsV80")]
        public List<System.String>? UnprotectableReasonsV80 { get; set; }

        //      C# -> List<System.String>? UnprotectableReasonsV81
        // GraphQL -> unprotectableReasonsV81: [String!]! (scalar)
        [JsonProperty("unprotectableReasonsV81")]
        public List<System.String>? UnprotectableReasonsV81 { get; set; }

        //      C# -> List<System.String>? UnprotectableReasonsV90
        // GraphQL -> unprotectableReasonsV90: [String!]! (scalar)
        [JsonProperty("unprotectableReasonsV90")]
        public List<System.String>? UnprotectableReasonsV90 { get; set; }

        //      C# -> BackupTaskDiagnosticInfo? CurrentBackupTaskInfo
        // GraphQL -> currentBackupTaskInfo: BackupTaskDiagnosticInfo (type)
        [JsonProperty("currentBackupTaskInfo")]
        public BackupTaskDiagnosticInfo? CurrentBackupTaskInfo { get; set; }

        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        [JsonProperty("pendingSlaDomain")]
        public ManagedObjectPendingSlaInfo? PendingSlaDomain { get; set; }

        //      C# -> List<MssqlDbReplica>? Replicas
        // GraphQL -> replicas: [MssqlDbReplica!]! (type)
        [JsonProperty("replicas")]
        public List<MssqlDbReplica>? Replicas { get; set; }

        //      C# -> MssqlRootProperties? RootProperties
        // GraphQL -> rootProperties: MssqlRootProperties (type)
        [JsonProperty("rootProperties")]
        public MssqlRootProperties? RootProperties { get; set; }

        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        [JsonProperty("snappable")]
        public CdmWorkload? Snappable { get; set; }

        //      C# -> List<MssqlUnprotectableReason>? UnprotectableReasonsV50
        // GraphQL -> unprotectableReasonsV50: [MssqlUnprotectableReason!]! (type)
        [JsonProperty("unprotectableReasonsV50")]
        public List<MssqlUnprotectableReason>? UnprotectableReasonsV50 { get; set; }


        #endregion

    #region methods

    public MssqlDbSummary Set(
        MssqlDbSummaryRecoveryModel? RecoveryModel = null,
        System.String? AvailabilityGroupId = null,
        System.Boolean? CopyOnly = null,
        System.Boolean? HasLogConfigFromSla = null,
        System.Boolean? HasPermissions = null,
        System.Int32? HostLogRetentionInSeconds = null,
        System.String? Id = null,
        System.Boolean? IncludeBackupTaskInfo = null,
        System.String? InstanceId = null,
        System.String? InstanceName = null,
        System.Boolean? IsInAvailabilityGroup = null,
        System.Boolean? IsLiveMount = null,
        System.Boolean? IsLogShippingSecondary = null,
        System.Boolean? IsOnline = null,
        System.Boolean? IsRelic = null,
        DateTime? LastSnapshotTime = null,
        System.Int32? LogBackupFrequencyInSeconds = null,
        System.Int32? LogBackupRetentionHours = null,
        System.String? Name = null,
        System.Int32? NumMissedSnapshot = null,
        System.String? PrimaryClusterId = null,
        System.String? State = null,
        List<System.String>? UnprotectableReasonsV51 = null,
        List<System.String>? UnprotectableReasonsV52 = null,
        List<System.String>? UnprotectableReasonsV53 = null,
        List<System.String>? UnprotectableReasonsV60 = null,
        List<System.String>? UnprotectableReasonsV70 = null,
        List<System.String>? UnprotectableReasonsV80 = null,
        List<System.String>? UnprotectableReasonsV81 = null,
        List<System.String>? UnprotectableReasonsV90 = null,
        BackupTaskDiagnosticInfo? CurrentBackupTaskInfo = null,
        ManagedObjectPendingSlaInfo? PendingSlaDomain = null,
        List<MssqlDbReplica>? Replicas = null,
        MssqlRootProperties? RootProperties = null,
        CdmWorkload? Snappable = null,
        List<MssqlUnprotectableReason>? UnprotectableReasonsV50 = null
    ) 
    {
        if ( RecoveryModel != null ) {
            this.RecoveryModel = RecoveryModel;
        }
        if ( AvailabilityGroupId != null ) {
            this.AvailabilityGroupId = AvailabilityGroupId;
        }
        if ( CopyOnly != null ) {
            this.CopyOnly = CopyOnly;
        }
        if ( HasLogConfigFromSla != null ) {
            this.HasLogConfigFromSla = HasLogConfigFromSla;
        }
        if ( HasPermissions != null ) {
            this.HasPermissions = HasPermissions;
        }
        if ( HostLogRetentionInSeconds != null ) {
            this.HostLogRetentionInSeconds = HostLogRetentionInSeconds;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IncludeBackupTaskInfo != null ) {
            this.IncludeBackupTaskInfo = IncludeBackupTaskInfo;
        }
        if ( InstanceId != null ) {
            this.InstanceId = InstanceId;
        }
        if ( InstanceName != null ) {
            this.InstanceName = InstanceName;
        }
        if ( IsInAvailabilityGroup != null ) {
            this.IsInAvailabilityGroup = IsInAvailabilityGroup;
        }
        if ( IsLiveMount != null ) {
            this.IsLiveMount = IsLiveMount;
        }
        if ( IsLogShippingSecondary != null ) {
            this.IsLogShippingSecondary = IsLogShippingSecondary;
        }
        if ( IsOnline != null ) {
            this.IsOnline = IsOnline;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( LastSnapshotTime != null ) {
            this.LastSnapshotTime = LastSnapshotTime;
        }
        if ( LogBackupFrequencyInSeconds != null ) {
            this.LogBackupFrequencyInSeconds = LogBackupFrequencyInSeconds;
        }
        if ( LogBackupRetentionHours != null ) {
            this.LogBackupRetentionHours = LogBackupRetentionHours;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumMissedSnapshot != null ) {
            this.NumMissedSnapshot = NumMissedSnapshot;
        }
        if ( PrimaryClusterId != null ) {
            this.PrimaryClusterId = PrimaryClusterId;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( UnprotectableReasonsV51 != null ) {
            this.UnprotectableReasonsV51 = UnprotectableReasonsV51;
        }
        if ( UnprotectableReasonsV52 != null ) {
            this.UnprotectableReasonsV52 = UnprotectableReasonsV52;
        }
        if ( UnprotectableReasonsV53 != null ) {
            this.UnprotectableReasonsV53 = UnprotectableReasonsV53;
        }
        if ( UnprotectableReasonsV60 != null ) {
            this.UnprotectableReasonsV60 = UnprotectableReasonsV60;
        }
        if ( UnprotectableReasonsV70 != null ) {
            this.UnprotectableReasonsV70 = UnprotectableReasonsV70;
        }
        if ( UnprotectableReasonsV80 != null ) {
            this.UnprotectableReasonsV80 = UnprotectableReasonsV80;
        }
        if ( UnprotectableReasonsV81 != null ) {
            this.UnprotectableReasonsV81 = UnprotectableReasonsV81;
        }
        if ( UnprotectableReasonsV90 != null ) {
            this.UnprotectableReasonsV90 = UnprotectableReasonsV90;
        }
        if ( CurrentBackupTaskInfo != null ) {
            this.CurrentBackupTaskInfo = CurrentBackupTaskInfo;
        }
        if ( PendingSlaDomain != null ) {
            this.PendingSlaDomain = PendingSlaDomain;
        }
        if ( Replicas != null ) {
            this.Replicas = Replicas;
        }
        if ( RootProperties != null ) {
            this.RootProperties = RootProperties;
        }
        if ( Snappable != null ) {
            this.Snappable = Snappable;
        }
        if ( UnprotectableReasonsV50 != null ) {
            this.UnprotectableReasonsV50 = UnprotectableReasonsV50;
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
        //      C# -> MssqlDbSummaryRecoveryModel? RecoveryModel
        // GraphQL -> recoveryModel: MssqlDbSummaryRecoveryModel (enum)
        if (this.RecoveryModel != null) {
            s += ind + "recoveryModel\n" ;
        }
        //      C# -> System.String? AvailabilityGroupId
        // GraphQL -> availabilityGroupId: String (scalar)
        if (this.AvailabilityGroupId != null) {
            s += ind + "availabilityGroupId\n" ;
        }
        //      C# -> System.Boolean? CopyOnly
        // GraphQL -> copyOnly: Boolean! (scalar)
        if (this.CopyOnly != null) {
            s += ind + "copyOnly\n" ;
        }
        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        if (this.HasLogConfigFromSla != null) {
            s += ind + "hasLogConfigFromSla\n" ;
        }
        //      C# -> System.Boolean? HasPermissions
        // GraphQL -> hasPermissions: Boolean! (scalar)
        if (this.HasPermissions != null) {
            s += ind + "hasPermissions\n" ;
        }
        //      C# -> System.Int32? HostLogRetentionInSeconds
        // GraphQL -> hostLogRetentionInSeconds: Int (scalar)
        if (this.HostLogRetentionInSeconds != null) {
            s += ind + "hostLogRetentionInSeconds\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IncludeBackupTaskInfo
        // GraphQL -> includeBackupTaskInfo: Boolean (scalar)
        if (this.IncludeBackupTaskInfo != null) {
            s += ind + "includeBackupTaskInfo\n" ;
        }
        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String (scalar)
        if (this.InstanceId != null) {
            s += ind + "instanceId\n" ;
        }
        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String (scalar)
        if (this.InstanceName != null) {
            s += ind + "instanceName\n" ;
        }
        //      C# -> System.Boolean? IsInAvailabilityGroup
        // GraphQL -> isInAvailabilityGroup: Boolean! (scalar)
        if (this.IsInAvailabilityGroup != null) {
            s += ind + "isInAvailabilityGroup\n" ;
        }
        //      C# -> System.Boolean? IsLiveMount
        // GraphQL -> isLiveMount: Boolean! (scalar)
        if (this.IsLiveMount != null) {
            s += ind + "isLiveMount\n" ;
        }
        //      C# -> System.Boolean? IsLogShippingSecondary
        // GraphQL -> isLogShippingSecondary: Boolean! (scalar)
        if (this.IsLogShippingSecondary != null) {
            s += ind + "isLogShippingSecondary\n" ;
        }
        //      C# -> System.Boolean? IsOnline
        // GraphQL -> isOnline: Boolean! (scalar)
        if (this.IsOnline != null) {
            s += ind + "isOnline\n" ;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            s += ind + "isRelic\n" ;
        }
        //      C# -> DateTime? LastSnapshotTime
        // GraphQL -> lastSnapshotTime: DateTime (scalar)
        if (this.LastSnapshotTime != null) {
            s += ind + "lastSnapshotTime\n" ;
        }
        //      C# -> System.Int32? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Int! (scalar)
        if (this.LogBackupFrequencyInSeconds != null) {
            s += ind + "logBackupFrequencyInSeconds\n" ;
        }
        //      C# -> System.Int32? LogBackupRetentionHours
        // GraphQL -> logBackupRetentionHours: Int! (scalar)
        if (this.LogBackupRetentionHours != null) {
            s += ind + "logBackupRetentionHours\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.Int32? NumMissedSnapshot
        // GraphQL -> numMissedSnapshot: Int (scalar)
        if (this.NumMissedSnapshot != null) {
            s += ind + "numMissedSnapshot\n" ;
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId != null) {
            s += ind + "primaryClusterId\n" ;
        }
        //      C# -> System.String? State
        // GraphQL -> state: String (scalar)
        if (this.State != null) {
            s += ind + "state\n" ;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV51
        // GraphQL -> unprotectableReasonsV51: [String!]! (scalar)
        if (this.UnprotectableReasonsV51 != null) {
            s += ind + "unprotectableReasonsV51\n" ;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV52
        // GraphQL -> unprotectableReasonsV52: [String!]! (scalar)
        if (this.UnprotectableReasonsV52 != null) {
            s += ind + "unprotectableReasonsV52\n" ;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV53
        // GraphQL -> unprotectableReasonsV53: [String!]! (scalar)
        if (this.UnprotectableReasonsV53 != null) {
            s += ind + "unprotectableReasonsV53\n" ;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV60
        // GraphQL -> unprotectableReasonsV60: [String!]! (scalar)
        if (this.UnprotectableReasonsV60 != null) {
            s += ind + "unprotectableReasonsV60\n" ;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV70
        // GraphQL -> unprotectableReasonsV70: [String!]! (scalar)
        if (this.UnprotectableReasonsV70 != null) {
            s += ind + "unprotectableReasonsV70\n" ;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV80
        // GraphQL -> unprotectableReasonsV80: [String!]! (scalar)
        if (this.UnprotectableReasonsV80 != null) {
            s += ind + "unprotectableReasonsV80\n" ;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV81
        // GraphQL -> unprotectableReasonsV81: [String!]! (scalar)
        if (this.UnprotectableReasonsV81 != null) {
            s += ind + "unprotectableReasonsV81\n" ;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV90
        // GraphQL -> unprotectableReasonsV90: [String!]! (scalar)
        if (this.UnprotectableReasonsV90 != null) {
            s += ind + "unprotectableReasonsV90\n" ;
        }
        //      C# -> BackupTaskDiagnosticInfo? CurrentBackupTaskInfo
        // GraphQL -> currentBackupTaskInfo: BackupTaskDiagnosticInfo (type)
        if (this.CurrentBackupTaskInfo != null) {
            var fspec = this.CurrentBackupTaskInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "currentBackupTaskInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (this.PendingSlaDomain != null) {
            var fspec = this.PendingSlaDomain.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pendingSlaDomain {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<MssqlDbReplica>? Replicas
        // GraphQL -> replicas: [MssqlDbReplica!]! (type)
        if (this.Replicas != null) {
            var fspec = this.Replicas.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "replicas {\n" + fspec + ind + "}\n" ;
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
        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        if (this.Snappable != null) {
            var fspec = this.Snappable.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snappable {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<MssqlUnprotectableReason>? UnprotectableReasonsV50
        // GraphQL -> unprotectableReasonsV50: [MssqlUnprotectableReason!]! (type)
        if (this.UnprotectableReasonsV50 != null) {
            var fspec = this.UnprotectableReasonsV50.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "unprotectableReasonsV50 {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> MssqlDbSummaryRecoveryModel? RecoveryModel
        // GraphQL -> recoveryModel: MssqlDbSummaryRecoveryModel (enum)
        if (this.RecoveryModel == null && Exploration.Includes(parent + ".recoveryModel", true))
        {
            this.RecoveryModel = new MssqlDbSummaryRecoveryModel();
        }
        //      C# -> System.String? AvailabilityGroupId
        // GraphQL -> availabilityGroupId: String (scalar)
        if (this.AvailabilityGroupId == null && Exploration.Includes(parent + ".availabilityGroupId", true))
        {
            this.AvailabilityGroupId = "FETCH";
        }
        //      C# -> System.Boolean? CopyOnly
        // GraphQL -> copyOnly: Boolean! (scalar)
        if (this.CopyOnly == null && Exploration.Includes(parent + ".copyOnly", true))
        {
            this.CopyOnly = true;
        }
        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        if (this.HasLogConfigFromSla == null && Exploration.Includes(parent + ".hasLogConfigFromSla", true))
        {
            this.HasLogConfigFromSla = true;
        }
        //      C# -> System.Boolean? HasPermissions
        // GraphQL -> hasPermissions: Boolean! (scalar)
        if (this.HasPermissions == null && Exploration.Includes(parent + ".hasPermissions", true))
        {
            this.HasPermissions = true;
        }
        //      C# -> System.Int32? HostLogRetentionInSeconds
        // GraphQL -> hostLogRetentionInSeconds: Int (scalar)
        if (this.HostLogRetentionInSeconds == null && Exploration.Includes(parent + ".hostLogRetentionInSeconds", true))
        {
            this.HostLogRetentionInSeconds = Int32.MinValue;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IncludeBackupTaskInfo
        // GraphQL -> includeBackupTaskInfo: Boolean (scalar)
        if (this.IncludeBackupTaskInfo == null && Exploration.Includes(parent + ".includeBackupTaskInfo", true))
        {
            this.IncludeBackupTaskInfo = true;
        }
        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String (scalar)
        if (this.InstanceId == null && Exploration.Includes(parent + ".instanceId", true))
        {
            this.InstanceId = "FETCH";
        }
        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String (scalar)
        if (this.InstanceName == null && Exploration.Includes(parent + ".instanceName", true))
        {
            this.InstanceName = "FETCH";
        }
        //      C# -> System.Boolean? IsInAvailabilityGroup
        // GraphQL -> isInAvailabilityGroup: Boolean! (scalar)
        if (this.IsInAvailabilityGroup == null && Exploration.Includes(parent + ".isInAvailabilityGroup", true))
        {
            this.IsInAvailabilityGroup = true;
        }
        //      C# -> System.Boolean? IsLiveMount
        // GraphQL -> isLiveMount: Boolean! (scalar)
        if (this.IsLiveMount == null && Exploration.Includes(parent + ".isLiveMount", true))
        {
            this.IsLiveMount = true;
        }
        //      C# -> System.Boolean? IsLogShippingSecondary
        // GraphQL -> isLogShippingSecondary: Boolean! (scalar)
        if (this.IsLogShippingSecondary == null && Exploration.Includes(parent + ".isLogShippingSecondary", true))
        {
            this.IsLogShippingSecondary = true;
        }
        //      C# -> System.Boolean? IsOnline
        // GraphQL -> isOnline: Boolean! (scalar)
        if (this.IsOnline == null && Exploration.Includes(parent + ".isOnline", true))
        {
            this.IsOnline = true;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic", true))
        {
            this.IsRelic = true;
        }
        //      C# -> DateTime? LastSnapshotTime
        // GraphQL -> lastSnapshotTime: DateTime (scalar)
        if (this.LastSnapshotTime == null && Exploration.Includes(parent + ".lastSnapshotTime", true))
        {
            this.LastSnapshotTime = new DateTime();
        }
        //      C# -> System.Int32? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Int! (scalar)
        if (this.LogBackupFrequencyInSeconds == null && Exploration.Includes(parent + ".logBackupFrequencyInSeconds", true))
        {
            this.LogBackupFrequencyInSeconds = Int32.MinValue;
        }
        //      C# -> System.Int32? LogBackupRetentionHours
        // GraphQL -> logBackupRetentionHours: Int! (scalar)
        if (this.LogBackupRetentionHours == null && Exploration.Includes(parent + ".logBackupRetentionHours", true))
        {
            this.LogBackupRetentionHours = Int32.MinValue;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.Int32? NumMissedSnapshot
        // GraphQL -> numMissedSnapshot: Int (scalar)
        if (this.NumMissedSnapshot == null && Exploration.Includes(parent + ".numMissedSnapshot", true))
        {
            this.NumMissedSnapshot = Int32.MinValue;
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId == null && Exploration.Includes(parent + ".primaryClusterId", true))
        {
            this.PrimaryClusterId = "FETCH";
        }
        //      C# -> System.String? State
        // GraphQL -> state: String (scalar)
        if (this.State == null && Exploration.Includes(parent + ".state", true))
        {
            this.State = "FETCH";
        }
        //      C# -> List<System.String>? UnprotectableReasonsV51
        // GraphQL -> unprotectableReasonsV51: [String!]! (scalar)
        if (this.UnprotectableReasonsV51 == null && Exploration.Includes(parent + ".unprotectableReasonsV51", true))
        {
            this.UnprotectableReasonsV51 = new List<System.String>();
        }
        //      C# -> List<System.String>? UnprotectableReasonsV52
        // GraphQL -> unprotectableReasonsV52: [String!]! (scalar)
        if (this.UnprotectableReasonsV52 == null && Exploration.Includes(parent + ".unprotectableReasonsV52", true))
        {
            this.UnprotectableReasonsV52 = new List<System.String>();
        }
        //      C# -> List<System.String>? UnprotectableReasonsV53
        // GraphQL -> unprotectableReasonsV53: [String!]! (scalar)
        if (this.UnprotectableReasonsV53 == null && Exploration.Includes(parent + ".unprotectableReasonsV53", true))
        {
            this.UnprotectableReasonsV53 = new List<System.String>();
        }
        //      C# -> List<System.String>? UnprotectableReasonsV60
        // GraphQL -> unprotectableReasonsV60: [String!]! (scalar)
        if (this.UnprotectableReasonsV60 == null && Exploration.Includes(parent + ".unprotectableReasonsV60", true))
        {
            this.UnprotectableReasonsV60 = new List<System.String>();
        }
        //      C# -> List<System.String>? UnprotectableReasonsV70
        // GraphQL -> unprotectableReasonsV70: [String!]! (scalar)
        if (this.UnprotectableReasonsV70 == null && Exploration.Includes(parent + ".unprotectableReasonsV70", true))
        {
            this.UnprotectableReasonsV70 = new List<System.String>();
        }
        //      C# -> List<System.String>? UnprotectableReasonsV80
        // GraphQL -> unprotectableReasonsV80: [String!]! (scalar)
        if (this.UnprotectableReasonsV80 == null && Exploration.Includes(parent + ".unprotectableReasonsV80", true))
        {
            this.UnprotectableReasonsV80 = new List<System.String>();
        }
        //      C# -> List<System.String>? UnprotectableReasonsV81
        // GraphQL -> unprotectableReasonsV81: [String!]! (scalar)
        if (this.UnprotectableReasonsV81 == null && Exploration.Includes(parent + ".unprotectableReasonsV81", true))
        {
            this.UnprotectableReasonsV81 = new List<System.String>();
        }
        //      C# -> List<System.String>? UnprotectableReasonsV90
        // GraphQL -> unprotectableReasonsV90: [String!]! (scalar)
        if (this.UnprotectableReasonsV90 == null && Exploration.Includes(parent + ".unprotectableReasonsV90", true))
        {
            this.UnprotectableReasonsV90 = new List<System.String>();
        }
        //      C# -> BackupTaskDiagnosticInfo? CurrentBackupTaskInfo
        // GraphQL -> currentBackupTaskInfo: BackupTaskDiagnosticInfo (type)
        if (this.CurrentBackupTaskInfo == null && Exploration.Includes(parent + ".currentBackupTaskInfo"))
        {
            this.CurrentBackupTaskInfo = new BackupTaskDiagnosticInfo();
            this.CurrentBackupTaskInfo.ApplyExploratoryFieldSpec(parent + ".currentBackupTaskInfo");
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (this.PendingSlaDomain == null && Exploration.Includes(parent + ".pendingSlaDomain"))
        {
            this.PendingSlaDomain = new ManagedObjectPendingSlaInfo();
            this.PendingSlaDomain.ApplyExploratoryFieldSpec(parent + ".pendingSlaDomain");
        }
        //      C# -> List<MssqlDbReplica>? Replicas
        // GraphQL -> replicas: [MssqlDbReplica!]! (type)
        if (this.Replicas == null && Exploration.Includes(parent + ".replicas"))
        {
            this.Replicas = new List<MssqlDbReplica>();
            this.Replicas.ApplyExploratoryFieldSpec(parent + ".replicas");
        }
        //      C# -> MssqlRootProperties? RootProperties
        // GraphQL -> rootProperties: MssqlRootProperties (type)
        if (this.RootProperties == null && Exploration.Includes(parent + ".rootProperties"))
        {
            this.RootProperties = new MssqlRootProperties();
            this.RootProperties.ApplyExploratoryFieldSpec(parent + ".rootProperties");
        }
        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        if (this.Snappable == null && Exploration.Includes(parent + ".snappable"))
        {
            this.Snappable = new CdmWorkload();
            this.Snappable.ApplyExploratoryFieldSpec(parent + ".snappable");
        }
        //      C# -> List<MssqlUnprotectableReason>? UnprotectableReasonsV50
        // GraphQL -> unprotectableReasonsV50: [MssqlUnprotectableReason!]! (type)
        if (this.UnprotectableReasonsV50 == null && Exploration.Includes(parent + ".unprotectableReasonsV50"))
        {
            this.UnprotectableReasonsV50 = new List<MssqlUnprotectableReason>();
            this.UnprotectableReasonsV50.ApplyExploratoryFieldSpec(parent + ".unprotectableReasonsV50");
        }
    }


    #endregion

    } // class MssqlDbSummary
    
    #endregion

    public static class ListMssqlDbSummaryExtensions
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
            this List<MssqlDbSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MssqlDbSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlDbSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types