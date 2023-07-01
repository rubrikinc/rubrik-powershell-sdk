// RubrikManagedAwsTarget.cs
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
    #region RubrikManagedAwsTarget
 
    public class RubrikManagedAwsTarget: BaseType, Target
    {
        #region members

        //      C# -> AwsRetrievalTier? AwsRetrievalTier
        // GraphQL -> awsRetrievalTier: AwsRetrievalTier! (enum)
        [JsonProperty("awsRetrievalTier")]
        public AwsRetrievalTier? AwsRetrievalTier { get; set; }

        //      C# -> CloudNativeLocTemplateType? CloudNativeLocTemplateType
        // GraphQL -> cloudNativeLocTemplateType: CloudNativeLocTemplateType! (enum)
        [JsonProperty("cloudNativeLocTemplateType")]
        public CloudNativeLocTemplateType? CloudNativeLocTemplateType { get; set; }

        //      C# -> ConnectionStatusType? ConnectionStatus
        // GraphQL -> connectionStatus: ConnectionStatusType! (enum)
        [JsonProperty("connectionStatus")]
        public ConnectionStatusType? ConnectionStatus { get; set; }

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

        //      C# -> AwsRegion? Region
        // GraphQL -> region: AwsRegion! (enum)
        [JsonProperty("region")]
        public AwsRegion? Region { get; set; }

        //      C# -> ArchivalLocationStatus? Status
        // GraphQL -> status: ArchivalLocationStatus! (enum)
        [JsonProperty("status")]
        public ArchivalLocationStatus? Status { get; set; }

        //      C# -> AwsStorageClass? StorageClass
        // GraphQL -> storageClass: AwsStorageClass! (enum)
        [JsonProperty("storageClass")]
        public AwsStorageClass? StorageClass { get; set; }

        //      C# -> TargetSyncStatus? SyncStatus
        // GraphQL -> syncStatus: TargetSyncStatus! (enum)
        [JsonProperty("syncStatus")]
        public TargetSyncStatus? SyncStatus { get; set; }

        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        [JsonProperty("targetType")]
        public TargetType? TargetType { get; set; }

        //      C# -> UpgradeStatus? UpgradeStatus
        // GraphQL -> upgradeStatus: UpgradeStatus! (enum)
        [JsonProperty("upgradeStatus")]
        public UpgradeStatus? UpgradeStatus { get; set; }

        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount! (interface)
        [JsonProperty("cloudAccount")]
        public CloudAccount? CloudAccount { get; set; }

        //      C# -> System.String? Bucket
        // GraphQL -> bucket: String! (scalar)
        [JsonProperty("bucket")]
        public System.String? Bucket { get; set; }

        //      C# -> System.Boolean? BypassProxy
        // GraphQL -> bypassProxy: Boolean! (scalar)
        [JsonProperty("bypassProxy")]
        public System.Boolean? BypassProxy { get; set; }

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

        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean! (scalar)
        [JsonProperty("isConsolidationEnabled")]
        public System.Boolean? IsConsolidationEnabled { get; set; }

        //      C# -> System.String? KmsEndpoint
        // GraphQL -> kmsEndpoint: String (scalar)
        [JsonProperty("kmsEndpoint")]
        public System.String? KmsEndpoint { get; set; }

        //      C# -> System.String? KmsMasterKeyId
        // GraphQL -> kmsMasterKeyId: String! (scalar)
        [JsonProperty("kmsMasterKeyId")]
        public System.String? KmsMasterKeyId { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? RunningTasks
        // GraphQL -> runningTasks: Int (scalar)
        [JsonProperty("runningTasks")]
        public System.Int32? RunningTasks { get; set; }

        //      C# -> System.String? S3Endpoint
        // GraphQL -> s3Endpoint: String (scalar)
        [JsonProperty("s3Endpoint")]
        public System.String? S3Endpoint { get; set; }

        //      C# -> System.String? SyncFailureReason
        // GraphQL -> syncFailureReason: String! (scalar)
        [JsonProperty("syncFailureReason")]
        public System.String? SyncFailureReason { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> AwsComputeSettings? ComputeSettings
        // GraphQL -> computeSettings: AwsComputeSettings (type)
        [JsonProperty("computeSettings")]
        public AwsComputeSettings? ComputeSettings { get; set; }

        //      C# -> AwsImmutabilitySettingsType? ImmutabilitySettings
        // GraphQL -> immutabilitySettings: AwsImmutabilitySettingsType (type)
        [JsonProperty("immutabilitySettings")]
        public AwsImmutabilitySettingsType? ImmutabilitySettings { get; set; }

        //      C# -> ProxySettings? ProxySettings
        // GraphQL -> proxySettings: ProxySettings (type)
        [JsonProperty("proxySettings")]
        public ProxySettings? ProxySettings { get; set; }

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
        return "RubrikManagedAwsTarget";
    }

    public RubrikManagedAwsTarget Set(
        AwsRetrievalTier? AwsRetrievalTier = null,
        CloudNativeLocTemplateType? CloudNativeLocTemplateType = null,
        ConnectionStatusType? ConnectionStatus = null,
        TargetEncryptionTypeEnum? EncryptionType = null,
        ConnectionStatusType? LocationConnectionStatus = null,
        LocationScope? LocationScope = null,
        ReaderRetrievalMethod? ReaderRetrievalMethod = null,
        AwsRegion? Region = null,
        ArchivalLocationStatus? Status = null,
        AwsStorageClass? StorageClass = null,
        TargetSyncStatus? SyncStatus = null,
        TargetType? TargetType = null,
        UpgradeStatus? UpgradeStatus = null,
        CloudAccount? CloudAccount = null,
        System.String? Bucket = null,
        System.Boolean? BypassProxy = null,
        System.String? ClusterName = null,
        System.Int64? ConsumedBytes = null,
        System.Int32? FailedTasks = null,
        System.String? Id = null,
        System.Boolean? IsActive = null,
        System.Boolean? IsArchived = null,
        System.Boolean? IsConsolidationEnabled = null,
        System.String? KmsEndpoint = null,
        System.String? KmsMasterKeyId = null,
        System.String? Name = null,
        System.Int32? RunningTasks = null,
        System.String? S3Endpoint = null,
        System.String? SyncFailureReason = null,
        Cluster? Cluster = null,
        AwsComputeSettings? ComputeSettings = null,
        AwsImmutabilitySettingsType? ImmutabilitySettings = null,
        ProxySettings? ProxySettings = null,
        TargetMappingBasic? TargetMapping = null,
        List<TargetMappingBasic>? TargetMappingBasic = null
    ) 
    {
        if ( AwsRetrievalTier != null ) {
            this.AwsRetrievalTier = AwsRetrievalTier;
        }
        if ( CloudNativeLocTemplateType != null ) {
            this.CloudNativeLocTemplateType = CloudNativeLocTemplateType;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
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
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( StorageClass != null ) {
            this.StorageClass = StorageClass;
        }
        if ( SyncStatus != null ) {
            this.SyncStatus = SyncStatus;
        }
        if ( TargetType != null ) {
            this.TargetType = TargetType;
        }
        if ( UpgradeStatus != null ) {
            this.UpgradeStatus = UpgradeStatus;
        }
        if ( CloudAccount != null ) {
            this.CloudAccount = CloudAccount;
        }
        if ( Bucket != null ) {
            this.Bucket = Bucket;
        }
        if ( BypassProxy != null ) {
            this.BypassProxy = BypassProxy;
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
        if ( IsConsolidationEnabled != null ) {
            this.IsConsolidationEnabled = IsConsolidationEnabled;
        }
        if ( KmsEndpoint != null ) {
            this.KmsEndpoint = KmsEndpoint;
        }
        if ( KmsMasterKeyId != null ) {
            this.KmsMasterKeyId = KmsMasterKeyId;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( RunningTasks != null ) {
            this.RunningTasks = RunningTasks;
        }
        if ( S3Endpoint != null ) {
            this.S3Endpoint = S3Endpoint;
        }
        if ( SyncFailureReason != null ) {
            this.SyncFailureReason = SyncFailureReason;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( ComputeSettings != null ) {
            this.ComputeSettings = ComputeSettings;
        }
        if ( ImmutabilitySettings != null ) {
            this.ImmutabilitySettings = ImmutabilitySettings;
        }
        if ( ProxySettings != null ) {
            this.ProxySettings = ProxySettings;
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> AwsRetrievalTier? AwsRetrievalTier
        // GraphQL -> awsRetrievalTier: AwsRetrievalTier! (enum)
        if (this.AwsRetrievalTier != null) {
            s += ind + "awsRetrievalTier\n" ;
        }
        //      C# -> CloudNativeLocTemplateType? CloudNativeLocTemplateType
        // GraphQL -> cloudNativeLocTemplateType: CloudNativeLocTemplateType! (enum)
        if (this.CloudNativeLocTemplateType != null) {
            s += ind + "cloudNativeLocTemplateType\n" ;
        }
        //      C# -> ConnectionStatusType? ConnectionStatus
        // GraphQL -> connectionStatus: ConnectionStatusType! (enum)
        if (this.ConnectionStatus != null) {
            s += ind + "connectionStatus\n" ;
        }
        //      C# -> TargetEncryptionTypeEnum? EncryptionType
        // GraphQL -> encryptionType: TargetEncryptionTypeEnum! (enum)
        if (this.EncryptionType != null) {
            s += ind + "encryptionType\n" ;
        }
        //      C# -> ConnectionStatusType? LocationConnectionStatus
        // GraphQL -> locationConnectionStatus: ConnectionStatusType! (enum)
        if (this.LocationConnectionStatus != null) {
            s += ind + "locationConnectionStatus\n" ;
        }
        //      C# -> LocationScope? LocationScope
        // GraphQL -> locationScope: LocationScope! (enum)
        if (this.LocationScope != null) {
            s += ind + "locationScope\n" ;
        }
        //      C# -> ReaderRetrievalMethod? ReaderRetrievalMethod
        // GraphQL -> readerRetrievalMethod: ReaderRetrievalMethod (enum)
        if (this.ReaderRetrievalMethod != null) {
            s += ind + "readerRetrievalMethod\n" ;
        }
        //      C# -> AwsRegion? Region
        // GraphQL -> region: AwsRegion! (enum)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> ArchivalLocationStatus? Status
        // GraphQL -> status: ArchivalLocationStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> AwsStorageClass? StorageClass
        // GraphQL -> storageClass: AwsStorageClass! (enum)
        if (this.StorageClass != null) {
            s += ind + "storageClass\n" ;
        }
        //      C# -> TargetSyncStatus? SyncStatus
        // GraphQL -> syncStatus: TargetSyncStatus! (enum)
        if (this.SyncStatus != null) {
            s += ind + "syncStatus\n" ;
        }
        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        if (this.TargetType != null) {
            s += ind + "targetType\n" ;
        }
        //      C# -> UpgradeStatus? UpgradeStatus
        // GraphQL -> upgradeStatus: UpgradeStatus! (enum)
        if (this.UpgradeStatus != null) {
            s += ind + "upgradeStatus\n" ;
        }
        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount! (interface)
        if (this.CloudAccount != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.CloudAccount).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cloudAccount {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.String? Bucket
        // GraphQL -> bucket: String! (scalar)
        if (this.Bucket != null) {
            s += ind + "bucket\n" ;
        }
        //      C# -> System.Boolean? BypassProxy
        // GraphQL -> bypassProxy: Boolean! (scalar)
        if (this.BypassProxy != null) {
            s += ind + "bypassProxy\n" ;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String (scalar)
        if (this.ClusterName != null) {
            s += ind + "clusterName\n" ;
        }
        //      C# -> System.Int64? ConsumedBytes
        // GraphQL -> consumedBytes: Long (scalar)
        if (this.ConsumedBytes != null) {
            s += ind + "consumedBytes\n" ;
        }
        //      C# -> System.Int32? FailedTasks
        // GraphQL -> failedTasks: Int (scalar)
        if (this.FailedTasks != null) {
            s += ind + "failedTasks\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        if (this.IsActive != null) {
            s += ind + "isActive\n" ;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            s += ind + "isArchived\n" ;
        }
        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean! (scalar)
        if (this.IsConsolidationEnabled != null) {
            s += ind + "isConsolidationEnabled\n" ;
        }
        //      C# -> System.String? KmsEndpoint
        // GraphQL -> kmsEndpoint: String (scalar)
        if (this.KmsEndpoint != null) {
            s += ind + "kmsEndpoint\n" ;
        }
        //      C# -> System.String? KmsMasterKeyId
        // GraphQL -> kmsMasterKeyId: String! (scalar)
        if (this.KmsMasterKeyId != null) {
            s += ind + "kmsMasterKeyId\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.Int32? RunningTasks
        // GraphQL -> runningTasks: Int (scalar)
        if (this.RunningTasks != null) {
            s += ind + "runningTasks\n" ;
        }
        //      C# -> System.String? S3Endpoint
        // GraphQL -> s3Endpoint: String (scalar)
        if (this.S3Endpoint != null) {
            s += ind + "s3Endpoint\n" ;
        }
        //      C# -> System.String? SyncFailureReason
        // GraphQL -> syncFailureReason: String! (scalar)
        if (this.SyncFailureReason != null) {
            s += ind + "syncFailureReason\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AwsComputeSettings? ComputeSettings
        // GraphQL -> computeSettings: AwsComputeSettings (type)
        if (this.ComputeSettings != null) {
            var fspec = this.ComputeSettings.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "computeSettings {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AwsImmutabilitySettingsType? ImmutabilitySettings
        // GraphQL -> immutabilitySettings: AwsImmutabilitySettingsType (type)
        if (this.ImmutabilitySettings != null) {
            var fspec = this.ImmutabilitySettings.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "immutabilitySettings {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ProxySettings? ProxySettings
        // GraphQL -> proxySettings: ProxySettings (type)
        if (this.ProxySettings != null) {
            var fspec = this.ProxySettings.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "proxySettings {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> TargetMappingBasic? TargetMapping
        // GraphQL -> targetMapping: TargetMappingBasic (type)
        if (this.TargetMapping != null) {
            var fspec = this.TargetMapping.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "targetMapping {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<TargetMappingBasic>? TargetMappingBasic
        // GraphQL -> targetMappingBasic: [TargetMappingBasic!] (type)
        if (this.TargetMappingBasic != null) {
            var fspec = this.TargetMappingBasic.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "targetMappingBasic {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AwsRetrievalTier? AwsRetrievalTier
        // GraphQL -> awsRetrievalTier: AwsRetrievalTier! (enum)
        if (this.AwsRetrievalTier == null && Exploration.Includes(parent + ".awsRetrievalTier", true))
        {
            this.AwsRetrievalTier = new AwsRetrievalTier();
        }
        //      C# -> CloudNativeLocTemplateType? CloudNativeLocTemplateType
        // GraphQL -> cloudNativeLocTemplateType: CloudNativeLocTemplateType! (enum)
        if (this.CloudNativeLocTemplateType == null && Exploration.Includes(parent + ".cloudNativeLocTemplateType", true))
        {
            this.CloudNativeLocTemplateType = new CloudNativeLocTemplateType();
        }
        //      C# -> ConnectionStatusType? ConnectionStatus
        // GraphQL -> connectionStatus: ConnectionStatusType! (enum)
        if (this.ConnectionStatus == null && Exploration.Includes(parent + ".connectionStatus", true))
        {
            this.ConnectionStatus = new ConnectionStatusType();
        }
        //      C# -> TargetEncryptionTypeEnum? EncryptionType
        // GraphQL -> encryptionType: TargetEncryptionTypeEnum! (enum)
        if (this.EncryptionType == null && Exploration.Includes(parent + ".encryptionType", true))
        {
            this.EncryptionType = new TargetEncryptionTypeEnum();
        }
        //      C# -> ConnectionStatusType? LocationConnectionStatus
        // GraphQL -> locationConnectionStatus: ConnectionStatusType! (enum)
        if (this.LocationConnectionStatus == null && Exploration.Includes(parent + ".locationConnectionStatus", true))
        {
            this.LocationConnectionStatus = new ConnectionStatusType();
        }
        //      C# -> LocationScope? LocationScope
        // GraphQL -> locationScope: LocationScope! (enum)
        if (this.LocationScope == null && Exploration.Includes(parent + ".locationScope", true))
        {
            this.LocationScope = new LocationScope();
        }
        //      C# -> ReaderRetrievalMethod? ReaderRetrievalMethod
        // GraphQL -> readerRetrievalMethod: ReaderRetrievalMethod (enum)
        if (this.ReaderRetrievalMethod == null && Exploration.Includes(parent + ".readerRetrievalMethod", true))
        {
            this.ReaderRetrievalMethod = new ReaderRetrievalMethod();
        }
        //      C# -> AwsRegion? Region
        // GraphQL -> region: AwsRegion! (enum)
        if (this.Region == null && Exploration.Includes(parent + ".region", true))
        {
            this.Region = new AwsRegion();
        }
        //      C# -> ArchivalLocationStatus? Status
        // GraphQL -> status: ArchivalLocationStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new ArchivalLocationStatus();
        }
        //      C# -> AwsStorageClass? StorageClass
        // GraphQL -> storageClass: AwsStorageClass! (enum)
        if (this.StorageClass == null && Exploration.Includes(parent + ".storageClass", true))
        {
            this.StorageClass = new AwsStorageClass();
        }
        //      C# -> TargetSyncStatus? SyncStatus
        // GraphQL -> syncStatus: TargetSyncStatus! (enum)
        if (this.SyncStatus == null && Exploration.Includes(parent + ".syncStatus", true))
        {
            this.SyncStatus = new TargetSyncStatus();
        }
        //      C# -> TargetType? TargetType
        // GraphQL -> targetType: TargetType! (enum)
        if (this.TargetType == null && Exploration.Includes(parent + ".targetType", true))
        {
            this.TargetType = new TargetType();
        }
        //      C# -> UpgradeStatus? UpgradeStatus
        // GraphQL -> upgradeStatus: UpgradeStatus! (enum)
        if (this.UpgradeStatus == null && Exploration.Includes(parent + ".upgradeStatus", true))
        {
            this.UpgradeStatus = new UpgradeStatus();
        }
        //      C# -> CloudAccount? CloudAccount
        // GraphQL -> cloudAccount: CloudAccount! (interface)
        if (this.CloudAccount == null && Exploration.Includes(parent + ".cloudAccount"))
        {
            var impls = new List<CloudAccount>();
            impls.ApplyExploratoryFieldSpec(parent + ".cloudAccount");
            this.CloudAccount = (CloudAccount)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.String? Bucket
        // GraphQL -> bucket: String! (scalar)
        if (this.Bucket == null && Exploration.Includes(parent + ".bucket", true))
        {
            this.Bucket = "FETCH";
        }
        //      C# -> System.Boolean? BypassProxy
        // GraphQL -> bypassProxy: Boolean! (scalar)
        if (this.BypassProxy == null && Exploration.Includes(parent + ".bypassProxy", true))
        {
            this.BypassProxy = true;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String (scalar)
        if (this.ClusterName == null && Exploration.Includes(parent + ".clusterName", true))
        {
            this.ClusterName = "FETCH";
        }
        //      C# -> System.Int64? ConsumedBytes
        // GraphQL -> consumedBytes: Long (scalar)
        if (this.ConsumedBytes == null && Exploration.Includes(parent + ".consumedBytes", true))
        {
            this.ConsumedBytes = new System.Int64();
        }
        //      C# -> System.Int32? FailedTasks
        // GraphQL -> failedTasks: Int (scalar)
        if (this.FailedTasks == null && Exploration.Includes(parent + ".failedTasks", true))
        {
            this.FailedTasks = Int32.MinValue;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        if (this.IsActive == null && Exploration.Includes(parent + ".isActive", true))
        {
            this.IsActive = true;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived", true))
        {
            this.IsArchived = true;
        }
        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean! (scalar)
        if (this.IsConsolidationEnabled == null && Exploration.Includes(parent + ".isConsolidationEnabled", true))
        {
            this.IsConsolidationEnabled = true;
        }
        //      C# -> System.String? KmsEndpoint
        // GraphQL -> kmsEndpoint: String (scalar)
        if (this.KmsEndpoint == null && Exploration.Includes(parent + ".kmsEndpoint", true))
        {
            this.KmsEndpoint = "FETCH";
        }
        //      C# -> System.String? KmsMasterKeyId
        // GraphQL -> kmsMasterKeyId: String! (scalar)
        if (this.KmsMasterKeyId == null && Exploration.Includes(parent + ".kmsMasterKeyId", true))
        {
            this.KmsMasterKeyId = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.Int32? RunningTasks
        // GraphQL -> runningTasks: Int (scalar)
        if (this.RunningTasks == null && Exploration.Includes(parent + ".runningTasks", true))
        {
            this.RunningTasks = Int32.MinValue;
        }
        //      C# -> System.String? S3Endpoint
        // GraphQL -> s3Endpoint: String (scalar)
        if (this.S3Endpoint == null && Exploration.Includes(parent + ".s3Endpoint", true))
        {
            this.S3Endpoint = "FETCH";
        }
        //      C# -> System.String? SyncFailureReason
        // GraphQL -> syncFailureReason: String! (scalar)
        if (this.SyncFailureReason == null && Exploration.Includes(parent + ".syncFailureReason", true))
        {
            this.SyncFailureReason = "FETCH";
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
        //      C# -> AwsComputeSettings? ComputeSettings
        // GraphQL -> computeSettings: AwsComputeSettings (type)
        if (this.ComputeSettings == null && Exploration.Includes(parent + ".computeSettings"))
        {
            this.ComputeSettings = new AwsComputeSettings();
            this.ComputeSettings.ApplyExploratoryFieldSpec(parent + ".computeSettings");
        }
        //      C# -> AwsImmutabilitySettingsType? ImmutabilitySettings
        // GraphQL -> immutabilitySettings: AwsImmutabilitySettingsType (type)
        if (this.ImmutabilitySettings == null && Exploration.Includes(parent + ".immutabilitySettings"))
        {
            this.ImmutabilitySettings = new AwsImmutabilitySettingsType();
            this.ImmutabilitySettings.ApplyExploratoryFieldSpec(parent + ".immutabilitySettings");
        }
        //      C# -> ProxySettings? ProxySettings
        // GraphQL -> proxySettings: ProxySettings (type)
        if (this.ProxySettings == null && Exploration.Includes(parent + ".proxySettings"))
        {
            this.ProxySettings = new ProxySettings();
            this.ProxySettings.ApplyExploratoryFieldSpec(parent + ".proxySettings");
        }
        //      C# -> TargetMappingBasic? TargetMapping
        // GraphQL -> targetMapping: TargetMappingBasic (type)
        if (this.TargetMapping == null && Exploration.Includes(parent + ".targetMapping"))
        {
            this.TargetMapping = new TargetMappingBasic();
            this.TargetMapping.ApplyExploratoryFieldSpec(parent + ".targetMapping");
        }
        //      C# -> List<TargetMappingBasic>? TargetMappingBasic
        // GraphQL -> targetMappingBasic: [TargetMappingBasic!] (type)
        if (this.TargetMappingBasic == null && Exploration.Includes(parent + ".targetMappingBasic"))
        {
            this.TargetMappingBasic = new List<TargetMappingBasic>();
            this.TargetMappingBasic.ApplyExploratoryFieldSpec(parent + ".targetMappingBasic");
        }
    }


    #endregion

    } // class RubrikManagedAwsTarget
    
    #endregion

    public static class ListRubrikManagedAwsTargetExtensions
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
            this List<RubrikManagedAwsTarget> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RubrikManagedAwsTarget> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RubrikManagedAwsTarget());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types