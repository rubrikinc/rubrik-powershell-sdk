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

        //      C# -> System.Int32? HostLogRetention
        // GraphQL -> hostLogRetention: Int (scalar)
        [JsonProperty("hostLogRetention")]
        public System.Int32? HostLogRetention { get; set; }

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

        //      C# -> List<System.String>? UnprotectableReasonsV91
        // GraphQL -> unprotectableReasonsV91: [String!]! (scalar)
        [JsonProperty("unprotectableReasonsV91")]
        public List<System.String>? UnprotectableReasonsV91 { get; set; }

        //      C# -> List<System.String>? UnprotectableReasonsV92
        // GraphQL -> unprotectableReasonsV92: [String!]! (scalar)
        [JsonProperty("unprotectableReasonsV92")]
        public List<System.String>? UnprotectableReasonsV92 { get; set; }

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

    public override string GetGqlTypeName() {
        return "MssqlDbSummary";
    }

    public MssqlDbSummary Set(
        MssqlDbSummaryRecoveryModel? RecoveryModel = null,
        System.String? AvailabilityGroupId = null,
        System.Boolean? CopyOnly = null,
        System.Boolean? HasLogConfigFromSla = null,
        System.Boolean? HasPermissions = null,
        System.Int32? HostLogRetention = null,
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
        List<System.String>? UnprotectableReasonsV91 = null,
        List<System.String>? UnprotectableReasonsV92 = null,
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
        if ( HostLogRetention != null ) {
            this.HostLogRetention = HostLogRetention;
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
        if ( UnprotectableReasonsV91 != null ) {
            this.UnprotectableReasonsV91 = UnprotectableReasonsV91;
        }
        if ( UnprotectableReasonsV92 != null ) {
            this.UnprotectableReasonsV92 = UnprotectableReasonsV92;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> MssqlDbSummaryRecoveryModel? RecoveryModel
        // GraphQL -> recoveryModel: MssqlDbSummaryRecoveryModel (enum)
        if (this.RecoveryModel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryModel\n" ;
            } else {
                s += ind + "recoveryModel\n" ;
            }
        }
        //      C# -> System.String? AvailabilityGroupId
        // GraphQL -> availabilityGroupId: String (scalar)
        if (this.AvailabilityGroupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "availabilityGroupId\n" ;
            } else {
                s += ind + "availabilityGroupId\n" ;
            }
        }
        //      C# -> System.Boolean? CopyOnly
        // GraphQL -> copyOnly: Boolean! (scalar)
        if (this.CopyOnly != null) {
            if (conf.Flat) {
                s += conf.Prefix + "copyOnly\n" ;
            } else {
                s += ind + "copyOnly\n" ;
            }
        }
        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        if (this.HasLogConfigFromSla != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasLogConfigFromSla\n" ;
            } else {
                s += ind + "hasLogConfigFromSla\n" ;
            }
        }
        //      C# -> System.Boolean? HasPermissions
        // GraphQL -> hasPermissions: Boolean! (scalar)
        if (this.HasPermissions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasPermissions\n" ;
            } else {
                s += ind + "hasPermissions\n" ;
            }
        }
        //      C# -> System.Int32? HostLogRetention
        // GraphQL -> hostLogRetention: Int (scalar)
        if (this.HostLogRetention != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostLogRetention\n" ;
            } else {
                s += ind + "hostLogRetention\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IncludeBackupTaskInfo
        // GraphQL -> includeBackupTaskInfo: Boolean (scalar)
        if (this.IncludeBackupTaskInfo != null) {
            if (conf.Flat) {
                s += conf.Prefix + "includeBackupTaskInfo\n" ;
            } else {
                s += ind + "includeBackupTaskInfo\n" ;
            }
        }
        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String (scalar)
        if (this.InstanceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceId\n" ;
            } else {
                s += ind + "instanceId\n" ;
            }
        }
        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String (scalar)
        if (this.InstanceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceName\n" ;
            } else {
                s += ind + "instanceName\n" ;
            }
        }
        //      C# -> System.Boolean? IsInAvailabilityGroup
        // GraphQL -> isInAvailabilityGroup: Boolean! (scalar)
        if (this.IsInAvailabilityGroup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isInAvailabilityGroup\n" ;
            } else {
                s += ind + "isInAvailabilityGroup\n" ;
            }
        }
        //      C# -> System.Boolean? IsLiveMount
        // GraphQL -> isLiveMount: Boolean! (scalar)
        if (this.IsLiveMount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isLiveMount\n" ;
            } else {
                s += ind + "isLiveMount\n" ;
            }
        }
        //      C# -> System.Boolean? IsLogShippingSecondary
        // GraphQL -> isLogShippingSecondary: Boolean! (scalar)
        if (this.IsLogShippingSecondary != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isLogShippingSecondary\n" ;
            } else {
                s += ind + "isLogShippingSecondary\n" ;
            }
        }
        //      C# -> System.Boolean? IsOnline
        // GraphQL -> isOnline: Boolean! (scalar)
        if (this.IsOnline != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isOnline\n" ;
            } else {
                s += ind + "isOnline\n" ;
            }
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRelic\n" ;
            } else {
                s += ind + "isRelic\n" ;
            }
        }
        //      C# -> DateTime? LastSnapshotTime
        // GraphQL -> lastSnapshotTime: DateTime (scalar)
        if (this.LastSnapshotTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastSnapshotTime\n" ;
            } else {
                s += ind + "lastSnapshotTime\n" ;
            }
        }
        //      C# -> System.Int32? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Int! (scalar)
        if (this.LogBackupFrequencyInSeconds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logBackupFrequencyInSeconds\n" ;
            } else {
                s += ind + "logBackupFrequencyInSeconds\n" ;
            }
        }
        //      C# -> System.Int32? LogBackupRetentionHours
        // GraphQL -> logBackupRetentionHours: Int! (scalar)
        if (this.LogBackupRetentionHours != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logBackupRetentionHours\n" ;
            } else {
                s += ind + "logBackupRetentionHours\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.Int32? NumMissedSnapshot
        // GraphQL -> numMissedSnapshot: Int (scalar)
        if (this.NumMissedSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numMissedSnapshot\n" ;
            } else {
                s += ind + "numMissedSnapshot\n" ;
            }
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryClusterId\n" ;
            } else {
                s += ind + "primaryClusterId\n" ;
            }
        }
        //      C# -> System.String? State
        // GraphQL -> state: String (scalar)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        //      C# -> List<System.String>? UnprotectableReasonsV51
        // GraphQL -> unprotectableReasonsV51: [String!]! (scalar)
        if (this.UnprotectableReasonsV51 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectableReasonsV51\n" ;
            } else {
                s += ind + "unprotectableReasonsV51\n" ;
            }
        }
        //      C# -> List<System.String>? UnprotectableReasonsV52
        // GraphQL -> unprotectableReasonsV52: [String!]! (scalar)
        if (this.UnprotectableReasonsV52 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectableReasonsV52\n" ;
            } else {
                s += ind + "unprotectableReasonsV52\n" ;
            }
        }
        //      C# -> List<System.String>? UnprotectableReasonsV53
        // GraphQL -> unprotectableReasonsV53: [String!]! (scalar)
        if (this.UnprotectableReasonsV53 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectableReasonsV53\n" ;
            } else {
                s += ind + "unprotectableReasonsV53\n" ;
            }
        }
        //      C# -> List<System.String>? UnprotectableReasonsV60
        // GraphQL -> unprotectableReasonsV60: [String!]! (scalar)
        if (this.UnprotectableReasonsV60 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectableReasonsV60\n" ;
            } else {
                s += ind + "unprotectableReasonsV60\n" ;
            }
        }
        //      C# -> List<System.String>? UnprotectableReasonsV70
        // GraphQL -> unprotectableReasonsV70: [String!]! (scalar)
        if (this.UnprotectableReasonsV70 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectableReasonsV70\n" ;
            } else {
                s += ind + "unprotectableReasonsV70\n" ;
            }
        }
        //      C# -> List<System.String>? UnprotectableReasonsV80
        // GraphQL -> unprotectableReasonsV80: [String!]! (scalar)
        if (this.UnprotectableReasonsV80 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectableReasonsV80\n" ;
            } else {
                s += ind + "unprotectableReasonsV80\n" ;
            }
        }
        //      C# -> List<System.String>? UnprotectableReasonsV81
        // GraphQL -> unprotectableReasonsV81: [String!]! (scalar)
        if (this.UnprotectableReasonsV81 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectableReasonsV81\n" ;
            } else {
                s += ind + "unprotectableReasonsV81\n" ;
            }
        }
        //      C# -> List<System.String>? UnprotectableReasonsV90
        // GraphQL -> unprotectableReasonsV90: [String!]! (scalar)
        if (this.UnprotectableReasonsV90 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectableReasonsV90\n" ;
            } else {
                s += ind + "unprotectableReasonsV90\n" ;
            }
        }
        //      C# -> List<System.String>? UnprotectableReasonsV91
        // GraphQL -> unprotectableReasonsV91: [String!]! (scalar)
        if (this.UnprotectableReasonsV91 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectableReasonsV91\n" ;
            } else {
                s += ind + "unprotectableReasonsV91\n" ;
            }
        }
        //      C# -> List<System.String>? UnprotectableReasonsV92
        // GraphQL -> unprotectableReasonsV92: [String!]! (scalar)
        if (this.UnprotectableReasonsV92 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectableReasonsV92\n" ;
            } else {
                s += ind + "unprotectableReasonsV92\n" ;
            }
        }
        //      C# -> BackupTaskDiagnosticInfo? CurrentBackupTaskInfo
        // GraphQL -> currentBackupTaskInfo: BackupTaskDiagnosticInfo (type)
        if (this.CurrentBackupTaskInfo != null) {
            var fspec = this.CurrentBackupTaskInfo.AsFieldSpec(conf.Child("currentBackupTaskInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "currentBackupTaskInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (this.PendingSlaDomain != null) {
            var fspec = this.PendingSlaDomain.AsFieldSpec(conf.Child("pendingSlaDomain"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pendingSlaDomain {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<MssqlDbReplica>? Replicas
        // GraphQL -> replicas: [MssqlDbReplica!]! (type)
        if (this.Replicas != null) {
            var fspec = this.Replicas.AsFieldSpec(conf.Child("replicas"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "replicas {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MssqlRootProperties? RootProperties
        // GraphQL -> rootProperties: MssqlRootProperties (type)
        if (this.RootProperties != null) {
            var fspec = this.RootProperties.AsFieldSpec(conf.Child("rootProperties"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "rootProperties {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        if (this.Snappable != null) {
            var fspec = this.Snappable.AsFieldSpec(conf.Child("snappable"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snappable {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<MssqlUnprotectableReason>? UnprotectableReasonsV50
        // GraphQL -> unprotectableReasonsV50: [MssqlUnprotectableReason!]! (type)
        if (this.UnprotectableReasonsV50 != null) {
            var fspec = this.UnprotectableReasonsV50.AsFieldSpec(conf.Child("unprotectableReasonsV50"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "unprotectableReasonsV50 {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> MssqlDbSummaryRecoveryModel? RecoveryModel
        // GraphQL -> recoveryModel: MssqlDbSummaryRecoveryModel (enum)
        if (ec.Includes("recoveryModel",true))
        {
            if(this.RecoveryModel == null) {

                this.RecoveryModel = new MssqlDbSummaryRecoveryModel();

            } else {


            }
        }
        else if (this.RecoveryModel != null && ec.Excludes("recoveryModel",true))
        {
            this.RecoveryModel = null;
        }
        //      C# -> System.String? AvailabilityGroupId
        // GraphQL -> availabilityGroupId: String (scalar)
        if (ec.Includes("availabilityGroupId",true))
        {
            if(this.AvailabilityGroupId == null) {

                this.AvailabilityGroupId = "FETCH";

            } else {


            }
        }
        else if (this.AvailabilityGroupId != null && ec.Excludes("availabilityGroupId",true))
        {
            this.AvailabilityGroupId = null;
        }
        //      C# -> System.Boolean? CopyOnly
        // GraphQL -> copyOnly: Boolean! (scalar)
        if (ec.Includes("copyOnly",true))
        {
            if(this.CopyOnly == null) {

                this.CopyOnly = true;

            } else {


            }
        }
        else if (this.CopyOnly != null && ec.Excludes("copyOnly",true))
        {
            this.CopyOnly = null;
        }
        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        if (ec.Includes("hasLogConfigFromSla",true))
        {
            if(this.HasLogConfigFromSla == null) {

                this.HasLogConfigFromSla = true;

            } else {


            }
        }
        else if (this.HasLogConfigFromSla != null && ec.Excludes("hasLogConfigFromSla",true))
        {
            this.HasLogConfigFromSla = null;
        }
        //      C# -> System.Boolean? HasPermissions
        // GraphQL -> hasPermissions: Boolean! (scalar)
        if (ec.Includes("hasPermissions",true))
        {
            if(this.HasPermissions == null) {

                this.HasPermissions = true;

            } else {


            }
        }
        else if (this.HasPermissions != null && ec.Excludes("hasPermissions",true))
        {
            this.HasPermissions = null;
        }
        //      C# -> System.Int32? HostLogRetention
        // GraphQL -> hostLogRetention: Int (scalar)
        if (ec.Includes("hostLogRetention",true))
        {
            if(this.HostLogRetention == null) {

                this.HostLogRetention = Int32.MinValue;

            } else {


            }
        }
        else if (this.HostLogRetention != null && ec.Excludes("hostLogRetention",true))
        {
            this.HostLogRetention = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IncludeBackupTaskInfo
        // GraphQL -> includeBackupTaskInfo: Boolean (scalar)
        if (ec.Includes("includeBackupTaskInfo",true))
        {
            if(this.IncludeBackupTaskInfo == null) {

                this.IncludeBackupTaskInfo = true;

            } else {


            }
        }
        else if (this.IncludeBackupTaskInfo != null && ec.Excludes("includeBackupTaskInfo",true))
        {
            this.IncludeBackupTaskInfo = null;
        }
        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String (scalar)
        if (ec.Includes("instanceId",true))
        {
            if(this.InstanceId == null) {

                this.InstanceId = "FETCH";

            } else {


            }
        }
        else if (this.InstanceId != null && ec.Excludes("instanceId",true))
        {
            this.InstanceId = null;
        }
        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String (scalar)
        if (ec.Includes("instanceName",true))
        {
            if(this.InstanceName == null) {

                this.InstanceName = "FETCH";

            } else {


            }
        }
        else if (this.InstanceName != null && ec.Excludes("instanceName",true))
        {
            this.InstanceName = null;
        }
        //      C# -> System.Boolean? IsInAvailabilityGroup
        // GraphQL -> isInAvailabilityGroup: Boolean! (scalar)
        if (ec.Includes("isInAvailabilityGroup",true))
        {
            if(this.IsInAvailabilityGroup == null) {

                this.IsInAvailabilityGroup = true;

            } else {


            }
        }
        else if (this.IsInAvailabilityGroup != null && ec.Excludes("isInAvailabilityGroup",true))
        {
            this.IsInAvailabilityGroup = null;
        }
        //      C# -> System.Boolean? IsLiveMount
        // GraphQL -> isLiveMount: Boolean! (scalar)
        if (ec.Includes("isLiveMount",true))
        {
            if(this.IsLiveMount == null) {

                this.IsLiveMount = true;

            } else {


            }
        }
        else if (this.IsLiveMount != null && ec.Excludes("isLiveMount",true))
        {
            this.IsLiveMount = null;
        }
        //      C# -> System.Boolean? IsLogShippingSecondary
        // GraphQL -> isLogShippingSecondary: Boolean! (scalar)
        if (ec.Includes("isLogShippingSecondary",true))
        {
            if(this.IsLogShippingSecondary == null) {

                this.IsLogShippingSecondary = true;

            } else {


            }
        }
        else if (this.IsLogShippingSecondary != null && ec.Excludes("isLogShippingSecondary",true))
        {
            this.IsLogShippingSecondary = null;
        }
        //      C# -> System.Boolean? IsOnline
        // GraphQL -> isOnline: Boolean! (scalar)
        if (ec.Includes("isOnline",true))
        {
            if(this.IsOnline == null) {

                this.IsOnline = true;

            } else {


            }
        }
        else if (this.IsOnline != null && ec.Excludes("isOnline",true))
        {
            this.IsOnline = null;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (ec.Includes("isRelic",true))
        {
            if(this.IsRelic == null) {

                this.IsRelic = true;

            } else {


            }
        }
        else if (this.IsRelic != null && ec.Excludes("isRelic",true))
        {
            this.IsRelic = null;
        }
        //      C# -> DateTime? LastSnapshotTime
        // GraphQL -> lastSnapshotTime: DateTime (scalar)
        if (ec.Includes("lastSnapshotTime",true))
        {
            if(this.LastSnapshotTime == null) {

                this.LastSnapshotTime = new DateTime();

            } else {


            }
        }
        else if (this.LastSnapshotTime != null && ec.Excludes("lastSnapshotTime",true))
        {
            this.LastSnapshotTime = null;
        }
        //      C# -> System.Int32? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Int! (scalar)
        if (ec.Includes("logBackupFrequencyInSeconds",true))
        {
            if(this.LogBackupFrequencyInSeconds == null) {

                this.LogBackupFrequencyInSeconds = Int32.MinValue;

            } else {


            }
        }
        else if (this.LogBackupFrequencyInSeconds != null && ec.Excludes("logBackupFrequencyInSeconds",true))
        {
            this.LogBackupFrequencyInSeconds = null;
        }
        //      C# -> System.Int32? LogBackupRetentionHours
        // GraphQL -> logBackupRetentionHours: Int! (scalar)
        if (ec.Includes("logBackupRetentionHours",true))
        {
            if(this.LogBackupRetentionHours == null) {

                this.LogBackupRetentionHours = Int32.MinValue;

            } else {


            }
        }
        else if (this.LogBackupRetentionHours != null && ec.Excludes("logBackupRetentionHours",true))
        {
            this.LogBackupRetentionHours = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.Int32? NumMissedSnapshot
        // GraphQL -> numMissedSnapshot: Int (scalar)
        if (ec.Includes("numMissedSnapshot",true))
        {
            if(this.NumMissedSnapshot == null) {

                this.NumMissedSnapshot = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumMissedSnapshot != null && ec.Excludes("numMissedSnapshot",true))
        {
            this.NumMissedSnapshot = null;
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (ec.Includes("primaryClusterId",true))
        {
            if(this.PrimaryClusterId == null) {

                this.PrimaryClusterId = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryClusterId != null && ec.Excludes("primaryClusterId",true))
        {
            this.PrimaryClusterId = null;
        }
        //      C# -> System.String? State
        // GraphQL -> state: String (scalar)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = "FETCH";

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV51
        // GraphQL -> unprotectableReasonsV51: [String!]! (scalar)
        if (ec.Includes("unprotectableReasonsV51",true))
        {
            if(this.UnprotectableReasonsV51 == null) {

                this.UnprotectableReasonsV51 = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprotectableReasonsV51 != null && ec.Excludes("unprotectableReasonsV51",true))
        {
            this.UnprotectableReasonsV51 = null;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV52
        // GraphQL -> unprotectableReasonsV52: [String!]! (scalar)
        if (ec.Includes("unprotectableReasonsV52",true))
        {
            if(this.UnprotectableReasonsV52 == null) {

                this.UnprotectableReasonsV52 = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprotectableReasonsV52 != null && ec.Excludes("unprotectableReasonsV52",true))
        {
            this.UnprotectableReasonsV52 = null;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV53
        // GraphQL -> unprotectableReasonsV53: [String!]! (scalar)
        if (ec.Includes("unprotectableReasonsV53",true))
        {
            if(this.UnprotectableReasonsV53 == null) {

                this.UnprotectableReasonsV53 = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprotectableReasonsV53 != null && ec.Excludes("unprotectableReasonsV53",true))
        {
            this.UnprotectableReasonsV53 = null;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV60
        // GraphQL -> unprotectableReasonsV60: [String!]! (scalar)
        if (ec.Includes("unprotectableReasonsV60",true))
        {
            if(this.UnprotectableReasonsV60 == null) {

                this.UnprotectableReasonsV60 = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprotectableReasonsV60 != null && ec.Excludes("unprotectableReasonsV60",true))
        {
            this.UnprotectableReasonsV60 = null;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV70
        // GraphQL -> unprotectableReasonsV70: [String!]! (scalar)
        if (ec.Includes("unprotectableReasonsV70",true))
        {
            if(this.UnprotectableReasonsV70 == null) {

                this.UnprotectableReasonsV70 = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprotectableReasonsV70 != null && ec.Excludes("unprotectableReasonsV70",true))
        {
            this.UnprotectableReasonsV70 = null;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV80
        // GraphQL -> unprotectableReasonsV80: [String!]! (scalar)
        if (ec.Includes("unprotectableReasonsV80",true))
        {
            if(this.UnprotectableReasonsV80 == null) {

                this.UnprotectableReasonsV80 = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprotectableReasonsV80 != null && ec.Excludes("unprotectableReasonsV80",true))
        {
            this.UnprotectableReasonsV80 = null;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV81
        // GraphQL -> unprotectableReasonsV81: [String!]! (scalar)
        if (ec.Includes("unprotectableReasonsV81",true))
        {
            if(this.UnprotectableReasonsV81 == null) {

                this.UnprotectableReasonsV81 = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprotectableReasonsV81 != null && ec.Excludes("unprotectableReasonsV81",true))
        {
            this.UnprotectableReasonsV81 = null;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV90
        // GraphQL -> unprotectableReasonsV90: [String!]! (scalar)
        if (ec.Includes("unprotectableReasonsV90",true))
        {
            if(this.UnprotectableReasonsV90 == null) {

                this.UnprotectableReasonsV90 = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprotectableReasonsV90 != null && ec.Excludes("unprotectableReasonsV90",true))
        {
            this.UnprotectableReasonsV90 = null;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV91
        // GraphQL -> unprotectableReasonsV91: [String!]! (scalar)
        if (ec.Includes("unprotectableReasonsV91",true))
        {
            if(this.UnprotectableReasonsV91 == null) {

                this.UnprotectableReasonsV91 = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprotectableReasonsV91 != null && ec.Excludes("unprotectableReasonsV91",true))
        {
            this.UnprotectableReasonsV91 = null;
        }
        //      C# -> List<System.String>? UnprotectableReasonsV92
        // GraphQL -> unprotectableReasonsV92: [String!]! (scalar)
        if (ec.Includes("unprotectableReasonsV92",true))
        {
            if(this.UnprotectableReasonsV92 == null) {

                this.UnprotectableReasonsV92 = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprotectableReasonsV92 != null && ec.Excludes("unprotectableReasonsV92",true))
        {
            this.UnprotectableReasonsV92 = null;
        }
        //      C# -> BackupTaskDiagnosticInfo? CurrentBackupTaskInfo
        // GraphQL -> currentBackupTaskInfo: BackupTaskDiagnosticInfo (type)
        if (ec.Includes("currentBackupTaskInfo",false))
        {
            if(this.CurrentBackupTaskInfo == null) {

                this.CurrentBackupTaskInfo = new BackupTaskDiagnosticInfo();
                this.CurrentBackupTaskInfo.ApplyExploratoryFieldSpec(ec.NewChild("currentBackupTaskInfo"));

            } else {

                this.CurrentBackupTaskInfo.ApplyExploratoryFieldSpec(ec.NewChild("currentBackupTaskInfo"));

            }
        }
        else if (this.CurrentBackupTaskInfo != null && ec.Excludes("currentBackupTaskInfo",false))
        {
            this.CurrentBackupTaskInfo = null;
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (ec.Includes("pendingSlaDomain",false))
        {
            if(this.PendingSlaDomain == null) {

                this.PendingSlaDomain = new ManagedObjectPendingSlaInfo();
                this.PendingSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("pendingSlaDomain"));

            } else {

                this.PendingSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("pendingSlaDomain"));

            }
        }
        else if (this.PendingSlaDomain != null && ec.Excludes("pendingSlaDomain",false))
        {
            this.PendingSlaDomain = null;
        }
        //      C# -> List<MssqlDbReplica>? Replicas
        // GraphQL -> replicas: [MssqlDbReplica!]! (type)
        if (ec.Includes("replicas",false))
        {
            if(this.Replicas == null) {

                this.Replicas = new List<MssqlDbReplica>();
                this.Replicas.ApplyExploratoryFieldSpec(ec.NewChild("replicas"));

            } else {

                this.Replicas.ApplyExploratoryFieldSpec(ec.NewChild("replicas"));

            }
        }
        else if (this.Replicas != null && ec.Excludes("replicas",false))
        {
            this.Replicas = null;
        }
        //      C# -> MssqlRootProperties? RootProperties
        // GraphQL -> rootProperties: MssqlRootProperties (type)
        if (ec.Includes("rootProperties",false))
        {
            if(this.RootProperties == null) {

                this.RootProperties = new MssqlRootProperties();
                this.RootProperties.ApplyExploratoryFieldSpec(ec.NewChild("rootProperties"));

            } else {

                this.RootProperties.ApplyExploratoryFieldSpec(ec.NewChild("rootProperties"));

            }
        }
        else if (this.RootProperties != null && ec.Excludes("rootProperties",false))
        {
            this.RootProperties = null;
        }
        //      C# -> CdmWorkload? Snappable
        // GraphQL -> snappable: CdmWorkload (type)
        if (ec.Includes("snappable",false))
        {
            if(this.Snappable == null) {

                this.Snappable = new CdmWorkload();
                this.Snappable.ApplyExploratoryFieldSpec(ec.NewChild("snappable"));

            } else {

                this.Snappable.ApplyExploratoryFieldSpec(ec.NewChild("snappable"));

            }
        }
        else if (this.Snappable != null && ec.Excludes("snappable",false))
        {
            this.Snappable = null;
        }
        //      C# -> List<MssqlUnprotectableReason>? UnprotectableReasonsV50
        // GraphQL -> unprotectableReasonsV50: [MssqlUnprotectableReason!]! (type)
        if (ec.Includes("unprotectableReasonsV50",false))
        {
            if(this.UnprotectableReasonsV50 == null) {

                this.UnprotectableReasonsV50 = new List<MssqlUnprotectableReason>();
                this.UnprotectableReasonsV50.ApplyExploratoryFieldSpec(ec.NewChild("unprotectableReasonsV50"));

            } else {

                this.UnprotectableReasonsV50.ApplyExploratoryFieldSpec(ec.NewChild("unprotectableReasonsV50"));

            }
        }
        else if (this.UnprotectableReasonsV50 != null && ec.Excludes("unprotectableReasonsV50",false))
        {
            this.UnprotectableReasonsV50 = null;
        }
    }


    #endregion

    } // class MssqlDbSummary
    
    #endregion

    public static class ListMssqlDbSummaryExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<MssqlDbSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MssqlDbSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MssqlDbSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlDbSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlDbSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types