// RubrikManagedRcvAwsTarget.cs
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
    #region RubrikManagedRcvAwsTarget
 
    public class RubrikManagedRcvAwsTarget: BaseType, Target
    {
        #region members

        //      C# -> TargetEncryptionTypeEnum? EncryptionType
        // GraphQL -> encryptionType: TargetEncryptionTypeEnum! (enum)
        [JsonProperty("encryptionType")]
        public TargetEncryptionTypeEnum? EncryptionType { get; set; }

        //      C# -> ConnectionStatusType? LocationConnectionStatus
        // GraphQL -> locationConnectionStatus: ConnectionStatusType! (enum)
        [JsonProperty("locationConnectionStatus")]
        public ConnectionStatusType? LocationConnectionStatus { get; set; }

        //      C# -> LocationScope? LocationScope
        // GraphQL -> locationScope: LocationScope! (enum)
        [JsonProperty("locationScope")]
        public LocationScope? LocationScope { get; set; }

        //      C# -> ReaderRetrievalMethod? ReaderRetrievalMethod
        // GraphQL -> readerRetrievalMethod: ReaderRetrievalMethod (enum)
        [JsonProperty("readerRetrievalMethod")]
        public ReaderRetrievalMethod? ReaderRetrievalMethod { get; set; }

        //      C# -> RcvRedundancy? Redundancy
        // GraphQL -> redundancy: RcvRedundancy! (enum)
        [JsonProperty("redundancy")]
        public RcvRedundancy? Redundancy { get; set; }

        //      C# -> RcsRegionEnumType? Region
        // GraphQL -> region: RcsRegionEnumType! (enum)
        [JsonProperty("region")]
        public RcsRegionEnumType? Region { get; set; }

        //      C# -> ArchivalLocationStatus? Status
        // GraphQL -> status: ArchivalLocationStatus! (enum)
        [JsonProperty("status")]
        public ArchivalLocationStatus? Status { get; set; }

        //      C# -> TargetSyncStatus? SyncStatus
        // GraphQL -> syncStatus: TargetSyncStatus! (enum)
        [JsonProperty("syncStatus")]
        public TargetSyncStatus? SyncStatus { get; set; }

        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        [JsonProperty("targetType")]
        public TargetType? TargetType { get; set; }

        //      C# -> RcsTierEnumType? Tier
        // GraphQL -> tier: RcsTierEnumType! (enum)
        [JsonProperty("tier")]
        public RcsTierEnumType? Tier { get; set; }

        //      C# -> UpgradeStatus? UpgradeStatus
        // GraphQL -> upgradeStatus: UpgradeStatus! (enum)
        [JsonProperty("upgradeStatus")]
        public UpgradeStatus? UpgradeStatus { get; set; }

        //      C# -> System.String? Bucket
        // GraphQL -> bucket: String! (scalar)
        [JsonProperty("bucket")]
        public System.String? Bucket { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.Int64? ConsumedBytes
        // GraphQL -> consumedBytes: Long (scalar)
        [JsonProperty("consumedBytes")]
        public System.Int64? ConsumedBytes { get; set; }

        //      C# -> System.Int32? FailedTasks
        // GraphQL -> failedTasks: Int (scalar)
        [JsonProperty("failedTasks")]
        public System.Int32? FailedTasks { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        [JsonProperty("isActive")]
        public System.Boolean? IsActive { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.Boolean? IsComplianceImmutabilitySupported
        // GraphQL -> isComplianceImmutabilitySupported: Boolean! (scalar)
        [JsonProperty("isComplianceImmutabilitySupported")]
        public System.Boolean? IsComplianceImmutabilitySupported { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? RunningTasks
        // GraphQL -> runningTasks: Int (scalar)
        [JsonProperty("runningTasks")]
        public System.Int32? RunningTasks { get; set; }

        //      C# -> System.Boolean? ShouldBypassProxy
        // GraphQL -> shouldBypassProxy: Boolean! (scalar)
        [JsonProperty("shouldBypassProxy")]
        public System.Boolean? ShouldBypassProxy { get; set; }

        //      C# -> System.String? SyncFailureReason
        // GraphQL -> syncFailureReason: String! (scalar)
        [JsonProperty("syncFailureReason")]
        public System.String? SyncFailureReason { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> TargetMappingBasic? TargetMapping
        // GraphQL -> targetMapping: TargetMappingBasic (type)
        [JsonProperty("targetMapping")]
        public TargetMappingBasic? TargetMapping { get; set; }

        //      C# -> List<TargetMappingBasic>? TargetMappingBasic
        // GraphQL -> targetMappingBasic: [TargetMappingBasic!] (type)
        [JsonProperty("targetMappingBasic")]
        public List<TargetMappingBasic>? TargetMappingBasic { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RubrikManagedRcvAwsTarget";
    }

    public RubrikManagedRcvAwsTarget Set(
        TargetEncryptionTypeEnum? EncryptionType = null,
        ConnectionStatusType? LocationConnectionStatus = null,
        LocationScope? LocationScope = null,
        ReaderRetrievalMethod? ReaderRetrievalMethod = null,
        RcvRedundancy? Redundancy = null,
        RcsRegionEnumType? Region = null,
        ArchivalLocationStatus? Status = null,
        TargetSyncStatus? SyncStatus = null,
        TargetType? TargetType = null,
        RcsTierEnumType? Tier = null,
        UpgradeStatus? UpgradeStatus = null,
        System.String? Bucket = null,
        System.String? ClusterName = null,
        System.Int64? ConsumedBytes = null,
        System.Int32? FailedTasks = null,
        System.String? Id = null,
        System.Boolean? IsActive = null,
        System.Boolean? IsArchived = null,
        System.Boolean? IsComplianceImmutabilitySupported = null,
        System.String? Name = null,
        System.Int32? RunningTasks = null,
        System.Boolean? ShouldBypassProxy = null,
        System.String? SyncFailureReason = null,
        Cluster? Cluster = null,
        TargetMappingBasic? TargetMapping = null,
        List<TargetMappingBasic>? TargetMappingBasic = null
    ) 
    {
        if ( EncryptionType != null ) {
            this.EncryptionType = EncryptionType;
        }
        if ( LocationConnectionStatus != null ) {
            this.LocationConnectionStatus = LocationConnectionStatus;
        }
        if ( LocationScope != null ) {
            this.LocationScope = LocationScope;
        }
        if ( ReaderRetrievalMethod != null ) {
            this.ReaderRetrievalMethod = ReaderRetrievalMethod;
        }
        if ( Redundancy != null ) {
            this.Redundancy = Redundancy;
        }
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( SyncStatus != null ) {
            this.SyncStatus = SyncStatus;
        }
        if ( TargetType != null ) {
            this.TargetType = TargetType;
        }
        if ( Tier != null ) {
            this.Tier = Tier;
        }
        if ( UpgradeStatus != null ) {
            this.UpgradeStatus = UpgradeStatus;
        }
        if ( Bucket != null ) {
            this.Bucket = Bucket;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( ConsumedBytes != null ) {
            this.ConsumedBytes = ConsumedBytes;
        }
        if ( FailedTasks != null ) {
            this.FailedTasks = FailedTasks;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsActive != null ) {
            this.IsActive = IsActive;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( IsComplianceImmutabilitySupported != null ) {
            this.IsComplianceImmutabilitySupported = IsComplianceImmutabilitySupported;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( RunningTasks != null ) {
            this.RunningTasks = RunningTasks;
        }
        if ( ShouldBypassProxy != null ) {
            this.ShouldBypassProxy = ShouldBypassProxy;
        }
        if ( SyncFailureReason != null ) {
            this.SyncFailureReason = SyncFailureReason;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( TargetMapping != null ) {
            this.TargetMapping = TargetMapping;
        }
        if ( TargetMappingBasic != null ) {
            this.TargetMappingBasic = TargetMappingBasic;
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
        //      C# -> TargetEncryptionTypeEnum? EncryptionType
        // GraphQL -> encryptionType: TargetEncryptionTypeEnum! (enum)
        if (this.EncryptionType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "encryptionType\n" ;
            } else {
                s += ind + "encryptionType\n" ;
            }
        }
        //      C# -> ConnectionStatusType? LocationConnectionStatus
        // GraphQL -> locationConnectionStatus: ConnectionStatusType! (enum)
        if (this.LocationConnectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationConnectionStatus\n" ;
            } else {
                s += ind + "locationConnectionStatus\n" ;
            }
        }
        //      C# -> LocationScope? LocationScope
        // GraphQL -> locationScope: LocationScope! (enum)
        if (this.LocationScope != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationScope\n" ;
            } else {
                s += ind + "locationScope\n" ;
            }
        }
        //      C# -> ReaderRetrievalMethod? ReaderRetrievalMethod
        // GraphQL -> readerRetrievalMethod: ReaderRetrievalMethod (enum)
        if (this.ReaderRetrievalMethod != null) {
            if (conf.Flat) {
                s += conf.Prefix + "readerRetrievalMethod\n" ;
            } else {
                s += ind + "readerRetrievalMethod\n" ;
            }
        }
        //      C# -> RcvRedundancy? Redundancy
        // GraphQL -> redundancy: RcvRedundancy! (enum)
        if (this.Redundancy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "redundancy\n" ;
            } else {
                s += ind + "redundancy\n" ;
            }
        }
        //      C# -> RcsRegionEnumType? Region
        // GraphQL -> region: RcsRegionEnumType! (enum)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        //      C# -> ArchivalLocationStatus? Status
        // GraphQL -> status: ArchivalLocationStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> TargetSyncStatus? SyncStatus
        // GraphQL -> syncStatus: TargetSyncStatus! (enum)
        if (this.SyncStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "syncStatus\n" ;
            } else {
                s += ind + "syncStatus\n" ;
            }
        }
        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        if (this.TargetType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetType\n" ;
            } else {
                s += ind + "targetType\n" ;
            }
        }
        //      C# -> RcsTierEnumType? Tier
        // GraphQL -> tier: RcsTierEnumType! (enum)
        if (this.Tier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tier\n" ;
            } else {
                s += ind + "tier\n" ;
            }
        }
        //      C# -> UpgradeStatus? UpgradeStatus
        // GraphQL -> upgradeStatus: UpgradeStatus! (enum)
        if (this.UpgradeStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "upgradeStatus\n" ;
            } else {
                s += ind + "upgradeStatus\n" ;
            }
        }
        //      C# -> System.String? Bucket
        // GraphQL -> bucket: String! (scalar)
        if (this.Bucket != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bucket\n" ;
            } else {
                s += ind + "bucket\n" ;
            }
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String (scalar)
        if (this.ClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterName\n" ;
            } else {
                s += ind + "clusterName\n" ;
            }
        }
        //      C# -> System.Int64? ConsumedBytes
        // GraphQL -> consumedBytes: Long (scalar)
        if (this.ConsumedBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "consumedBytes\n" ;
            } else {
                s += ind + "consumedBytes\n" ;
            }
        }
        //      C# -> System.Int32? FailedTasks
        // GraphQL -> failedTasks: Int (scalar)
        if (this.FailedTasks != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failedTasks\n" ;
            } else {
                s += ind + "failedTasks\n" ;
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
        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        if (this.IsActive != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isActive\n" ;
            } else {
                s += ind + "isActive\n" ;
            }
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArchived\n" ;
            } else {
                s += ind + "isArchived\n" ;
            }
        }
        //      C# -> System.Boolean? IsComplianceImmutabilitySupported
        // GraphQL -> isComplianceImmutabilitySupported: Boolean! (scalar)
        if (this.IsComplianceImmutabilitySupported != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isComplianceImmutabilitySupported\n" ;
            } else {
                s += ind + "isComplianceImmutabilitySupported\n" ;
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
        //      C# -> System.Int32? RunningTasks
        // GraphQL -> runningTasks: Int (scalar)
        if (this.RunningTasks != null) {
            if (conf.Flat) {
                s += conf.Prefix + "runningTasks\n" ;
            } else {
                s += ind + "runningTasks\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldBypassProxy
        // GraphQL -> shouldBypassProxy: Boolean! (scalar)
        if (this.ShouldBypassProxy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldBypassProxy\n" ;
            } else {
                s += ind + "shouldBypassProxy\n" ;
            }
        }
        //      C# -> System.String? SyncFailureReason
        // GraphQL -> syncFailureReason: String! (scalar)
        if (this.SyncFailureReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "syncFailureReason\n" ;
            } else {
                s += ind + "syncFailureReason\n" ;
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> TargetMappingBasic? TargetMapping
        // GraphQL -> targetMapping: TargetMappingBasic (type)
        if (this.TargetMapping != null) {
            var fspec = this.TargetMapping.AsFieldSpec(conf.Child("targetMapping"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetMapping" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<TargetMappingBasic>? TargetMappingBasic
        // GraphQL -> targetMappingBasic: [TargetMappingBasic!] (type)
        if (this.TargetMappingBasic != null) {
            var fspec = this.TargetMappingBasic.AsFieldSpec(conf.Child("targetMappingBasic"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetMappingBasic" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> TargetEncryptionTypeEnum? EncryptionType
        // GraphQL -> encryptionType: TargetEncryptionTypeEnum! (enum)
        if (ec.Includes("encryptionType",true))
        {
            if(this.EncryptionType == null) {

                this.EncryptionType = new TargetEncryptionTypeEnum();

            } else {


            }
        }
        else if (this.EncryptionType != null && ec.Excludes("encryptionType",true))
        {
            this.EncryptionType = null;
        }
        //      C# -> ConnectionStatusType? LocationConnectionStatus
        // GraphQL -> locationConnectionStatus: ConnectionStatusType! (enum)
        if (ec.Includes("locationConnectionStatus",true))
        {
            if(this.LocationConnectionStatus == null) {

                this.LocationConnectionStatus = new ConnectionStatusType();

            } else {


            }
        }
        else if (this.LocationConnectionStatus != null && ec.Excludes("locationConnectionStatus",true))
        {
            this.LocationConnectionStatus = null;
        }
        //      C# -> LocationScope? LocationScope
        // GraphQL -> locationScope: LocationScope! (enum)
        if (ec.Includes("locationScope",true))
        {
            if(this.LocationScope == null) {

                this.LocationScope = new LocationScope();

            } else {


            }
        }
        else if (this.LocationScope != null && ec.Excludes("locationScope",true))
        {
            this.LocationScope = null;
        }
        //      C# -> ReaderRetrievalMethod? ReaderRetrievalMethod
        // GraphQL -> readerRetrievalMethod: ReaderRetrievalMethod (enum)
        if (ec.Includes("readerRetrievalMethod",true))
        {
            if(this.ReaderRetrievalMethod == null) {

                this.ReaderRetrievalMethod = new ReaderRetrievalMethod();

            } else {


            }
        }
        else if (this.ReaderRetrievalMethod != null && ec.Excludes("readerRetrievalMethod",true))
        {
            this.ReaderRetrievalMethod = null;
        }
        //      C# -> RcvRedundancy? Redundancy
        // GraphQL -> redundancy: RcvRedundancy! (enum)
        if (ec.Includes("redundancy",true))
        {
            if(this.Redundancy == null) {

                this.Redundancy = new RcvRedundancy();

            } else {


            }
        }
        else if (this.Redundancy != null && ec.Excludes("redundancy",true))
        {
            this.Redundancy = null;
        }
        //      C# -> RcsRegionEnumType? Region
        // GraphQL -> region: RcsRegionEnumType! (enum)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = new RcsRegionEnumType();

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
        //      C# -> ArchivalLocationStatus? Status
        // GraphQL -> status: ArchivalLocationStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new ArchivalLocationStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> TargetSyncStatus? SyncStatus
        // GraphQL -> syncStatus: TargetSyncStatus! (enum)
        if (ec.Includes("syncStatus",true))
        {
            if(this.SyncStatus == null) {

                this.SyncStatus = new TargetSyncStatus();

            } else {


            }
        }
        else if (this.SyncStatus != null && ec.Excludes("syncStatus",true))
        {
            this.SyncStatus = null;
        }
        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        if (ec.Includes("targetType",true))
        {
            if(this.TargetType == null) {

                this.TargetType = new TargetType();

            } else {


            }
        }
        else if (this.TargetType != null && ec.Excludes("targetType",true))
        {
            this.TargetType = null;
        }
        //      C# -> RcsTierEnumType? Tier
        // GraphQL -> tier: RcsTierEnumType! (enum)
        if (ec.Includes("tier",true))
        {
            if(this.Tier == null) {

                this.Tier = new RcsTierEnumType();

            } else {


            }
        }
        else if (this.Tier != null && ec.Excludes("tier",true))
        {
            this.Tier = null;
        }
        //      C# -> UpgradeStatus? UpgradeStatus
        // GraphQL -> upgradeStatus: UpgradeStatus! (enum)
        if (ec.Includes("upgradeStatus",true))
        {
            if(this.UpgradeStatus == null) {

                this.UpgradeStatus = new UpgradeStatus();

            } else {


            }
        }
        else if (this.UpgradeStatus != null && ec.Excludes("upgradeStatus",true))
        {
            this.UpgradeStatus = null;
        }
        //      C# -> System.String? Bucket
        // GraphQL -> bucket: String! (scalar)
        if (ec.Includes("bucket",true))
        {
            if(this.Bucket == null) {

                this.Bucket = "FETCH";

            } else {


            }
        }
        else if (this.Bucket != null && ec.Excludes("bucket",true))
        {
            this.Bucket = null;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String (scalar)
        if (ec.Includes("clusterName",true))
        {
            if(this.ClusterName == null) {

                this.ClusterName = "FETCH";

            } else {


            }
        }
        else if (this.ClusterName != null && ec.Excludes("clusterName",true))
        {
            this.ClusterName = null;
        }
        //      C# -> System.Int64? ConsumedBytes
        // GraphQL -> consumedBytes: Long (scalar)
        if (ec.Includes("consumedBytes",true))
        {
            if(this.ConsumedBytes == null) {

                this.ConsumedBytes = new System.Int64();

            } else {


            }
        }
        else if (this.ConsumedBytes != null && ec.Excludes("consumedBytes",true))
        {
            this.ConsumedBytes = null;
        }
        //      C# -> System.Int32? FailedTasks
        // GraphQL -> failedTasks: Int (scalar)
        if (ec.Includes("failedTasks",true))
        {
            if(this.FailedTasks == null) {

                this.FailedTasks = Int32.MinValue;

            } else {


            }
        }
        else if (this.FailedTasks != null && ec.Excludes("failedTasks",true))
        {
            this.FailedTasks = null;
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
        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        if (ec.Includes("isActive",true))
        {
            if(this.IsActive == null) {

                this.IsActive = true;

            } else {


            }
        }
        else if (this.IsActive != null && ec.Excludes("isActive",true))
        {
            this.IsActive = null;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (ec.Includes("isArchived",true))
        {
            if(this.IsArchived == null) {

                this.IsArchived = true;

            } else {


            }
        }
        else if (this.IsArchived != null && ec.Excludes("isArchived",true))
        {
            this.IsArchived = null;
        }
        //      C# -> System.Boolean? IsComplianceImmutabilitySupported
        // GraphQL -> isComplianceImmutabilitySupported: Boolean! (scalar)
        if (ec.Includes("isComplianceImmutabilitySupported",true))
        {
            if(this.IsComplianceImmutabilitySupported == null) {

                this.IsComplianceImmutabilitySupported = true;

            } else {


            }
        }
        else if (this.IsComplianceImmutabilitySupported != null && ec.Excludes("isComplianceImmutabilitySupported",true))
        {
            this.IsComplianceImmutabilitySupported = null;
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
        //      C# -> System.Int32? RunningTasks
        // GraphQL -> runningTasks: Int (scalar)
        if (ec.Includes("runningTasks",true))
        {
            if(this.RunningTasks == null) {

                this.RunningTasks = Int32.MinValue;

            } else {


            }
        }
        else if (this.RunningTasks != null && ec.Excludes("runningTasks",true))
        {
            this.RunningTasks = null;
        }
        //      C# -> System.Boolean? ShouldBypassProxy
        // GraphQL -> shouldBypassProxy: Boolean! (scalar)
        if (ec.Includes("shouldBypassProxy",true))
        {
            if(this.ShouldBypassProxy == null) {

                this.ShouldBypassProxy = true;

            } else {


            }
        }
        else if (this.ShouldBypassProxy != null && ec.Excludes("shouldBypassProxy",true))
        {
            this.ShouldBypassProxy = null;
        }
        //      C# -> System.String? SyncFailureReason
        // GraphQL -> syncFailureReason: String! (scalar)
        if (ec.Includes("syncFailureReason",true))
        {
            if(this.SyncFailureReason == null) {

                this.SyncFailureReason = "FETCH";

            } else {


            }
        }
        else if (this.SyncFailureReason != null && ec.Excludes("syncFailureReason",true))
        {
            this.SyncFailureReason = null;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
        //      C# -> TargetMappingBasic? TargetMapping
        // GraphQL -> targetMapping: TargetMappingBasic (type)
        if (ec.Includes("targetMapping",false))
        {
            if(this.TargetMapping == null) {

                this.TargetMapping = new TargetMappingBasic();
                this.TargetMapping.ApplyExploratoryFieldSpec(ec.NewChild("targetMapping"));

            } else {

                this.TargetMapping.ApplyExploratoryFieldSpec(ec.NewChild("targetMapping"));

            }
        }
        else if (this.TargetMapping != null && ec.Excludes("targetMapping",false))
        {
            this.TargetMapping = null;
        }
        //      C# -> List<TargetMappingBasic>? TargetMappingBasic
        // GraphQL -> targetMappingBasic: [TargetMappingBasic!] (type)
        if (ec.Includes("targetMappingBasic",false))
        {
            if(this.TargetMappingBasic == null) {

                this.TargetMappingBasic = new List<TargetMappingBasic>();
                this.TargetMappingBasic.ApplyExploratoryFieldSpec(ec.NewChild("targetMappingBasic"));

            } else {

                this.TargetMappingBasic.ApplyExploratoryFieldSpec(ec.NewChild("targetMappingBasic"));

            }
        }
        else if (this.TargetMappingBasic != null && ec.Excludes("targetMappingBasic",false))
        {
            this.TargetMappingBasic = null;
        }
    }


    #endregion

    } // class RubrikManagedRcvAwsTarget
    
    #endregion

    public static class ListRubrikManagedRcvAwsTargetExtensions
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
            this List<RubrikManagedRcvAwsTarget> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RubrikManagedRcvAwsTarget> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RubrikManagedRcvAwsTarget> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RubrikManagedRcvAwsTarget());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RubrikManagedRcvAwsTarget> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types