// RubrikManagedDcaTarget.cs
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
    #region RubrikManagedDcaTarget
 
    public class RubrikManagedDcaTarget: BaseType, Target
    {
        #region members

        //      C# -> AwsRetrievalTier? AwsRetrievalTier
        // GraphQL -> awsRetrievalTier: AwsRetrievalTier! (enum)
        [JsonProperty("awsRetrievalTier")]
        public AwsRetrievalTier? AwsRetrievalTier { get; set; }

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

        //      C# -> AwsDcaRegion? Region
        // GraphQL -> region: AwsDcaRegion! (enum)
        [JsonProperty("region")]
        public AwsDcaRegion? Region { get; set; }

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

        //      C# -> System.String? Agency
        // GraphQL -> agency: String! (scalar)
        [JsonProperty("agency")]
        public System.String? Agency { get; set; }

        //      C# -> System.String? BucketName
        // GraphQL -> bucketName: String! (scalar)
        [JsonProperty("bucketName")]
        public System.String? BucketName { get; set; }

        //      C# -> System.String? CapEndpoint
        // GraphQL -> capEndpoint: String! (scalar)
        [JsonProperty("capEndpoint")]
        public System.String? CapEndpoint { get; set; }

        //      C# -> System.String? CertificateContent
        // GraphQL -> certificateContent: String! (scalar)
        [JsonProperty("certificateContent")]
        public System.String? CertificateContent { get; set; }

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

        //      C# -> System.String? KmsMasterKeyId
        // GraphQL -> kmsMasterKeyId: String! (scalar)
        [JsonProperty("kmsMasterKeyId")]
        public System.String? KmsMasterKeyId { get; set; }

        //      C# -> System.String? Mission
        // GraphQL -> mission: String! (scalar)
        [JsonProperty("mission")]
        public System.String? Mission { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? RoleName
        // GraphQL -> roleName: String! (scalar)
        [JsonProperty("roleName")]
        public System.String? RoleName { get; set; }

        //      C# -> System.String? RsaKey
        // GraphQL -> rsaKey: String! (scalar)
        [JsonProperty("rsaKey")]
        public System.String? RsaKey { get; set; }

        //      C# -> System.Int32? RunningTasks
        // GraphQL -> runningTasks: Int (scalar)
        [JsonProperty("runningTasks")]
        public System.Int32? RunningTasks { get; set; }

        //      C# -> System.String? S3Endpoint
        // GraphQL -> s3Endpoint: String! (scalar)
        [JsonProperty("s3Endpoint")]
        public System.String? S3Endpoint { get; set; }

        //      C# -> System.String? SyncFailureReason
        // GraphQL -> syncFailureReason: String! (scalar)
        [JsonProperty("syncFailureReason")]
        public System.String? SyncFailureReason { get; set; }

        //      C# -> System.Int32? TokenDuration
        // GraphQL -> tokenDuration: Int! (scalar)
        [JsonProperty("tokenDuration")]
        public System.Int32? TokenDuration { get; set; }

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
        return "RubrikManagedDcaTarget";
    }

    public RubrikManagedDcaTarget Set(
        AwsRetrievalTier? AwsRetrievalTier = null,
        ConnectionStatusType? ConnectionStatus = null,
        TargetEncryptionTypeEnum? EncryptionType = null,
        ConnectionStatusType? LocationConnectionStatus = null,
        LocationScope? LocationScope = null,
        ReaderRetrievalMethod? ReaderRetrievalMethod = null,
        AwsDcaRegion? Region = null,
        ArchivalLocationStatus? Status = null,
        AwsStorageClass? StorageClass = null,
        TargetSyncStatus? SyncStatus = null,
        TargetType? TargetType = null,
        UpgradeStatus? UpgradeStatus = null,
        System.String? Agency = null,
        System.String? BucketName = null,
        System.String? CapEndpoint = null,
        System.String? CertificateContent = null,
        System.String? ClusterName = null,
        System.Int64? ConsumedBytes = null,
        System.Int32? FailedTasks = null,
        System.String? Id = null,
        System.Boolean? IsActive = null,
        System.Boolean? IsArchived = null,
        System.String? KmsMasterKeyId = null,
        System.String? Mission = null,
        System.String? Name = null,
        System.String? RoleName = null,
        System.String? RsaKey = null,
        System.Int32? RunningTasks = null,
        System.String? S3Endpoint = null,
        System.String? SyncFailureReason = null,
        System.Int32? TokenDuration = null,
        Cluster? Cluster = null,
        TargetMappingBasic? TargetMapping = null,
        List<TargetMappingBasic>? TargetMappingBasic = null
    ) 
    {
        if ( AwsRetrievalTier != null ) {
            this.AwsRetrievalTier = AwsRetrievalTier;
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
        if ( Agency != null ) {
            this.Agency = Agency;
        }
        if ( BucketName != null ) {
            this.BucketName = BucketName;
        }
        if ( CapEndpoint != null ) {
            this.CapEndpoint = CapEndpoint;
        }
        if ( CertificateContent != null ) {
            this.CertificateContent = CertificateContent;
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
        if ( KmsMasterKeyId != null ) {
            this.KmsMasterKeyId = KmsMasterKeyId;
        }
        if ( Mission != null ) {
            this.Mission = Mission;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( RoleName != null ) {
            this.RoleName = RoleName;
        }
        if ( RsaKey != null ) {
            this.RsaKey = RsaKey;
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
        if ( TokenDuration != null ) {
            this.TokenDuration = TokenDuration;
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
        //      C# -> AwsRetrievalTier? AwsRetrievalTier
        // GraphQL -> awsRetrievalTier: AwsRetrievalTier! (enum)
        if (this.AwsRetrievalTier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awsRetrievalTier\n" ;
            } else {
                s += ind + "awsRetrievalTier\n" ;
            }
        }
        //      C# -> ConnectionStatusType? ConnectionStatus
        // GraphQL -> connectionStatus: ConnectionStatusType! (enum)
        if (this.ConnectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "connectionStatus\n" ;
            } else {
                s += ind + "connectionStatus\n" ;
            }
        }
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
        //      C# -> AwsDcaRegion? Region
        // GraphQL -> region: AwsDcaRegion! (enum)
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
        //      C# -> AwsStorageClass? StorageClass
        // GraphQL -> storageClass: AwsStorageClass! (enum)
        if (this.StorageClass != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageClass\n" ;
            } else {
                s += ind + "storageClass\n" ;
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
        //      C# -> UpgradeStatus? UpgradeStatus
        // GraphQL -> upgradeStatus: UpgradeStatus! (enum)
        if (this.UpgradeStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "upgradeStatus\n" ;
            } else {
                s += ind + "upgradeStatus\n" ;
            }
        }
        //      C# -> System.String? Agency
        // GraphQL -> agency: String! (scalar)
        if (this.Agency != null) {
            if (conf.Flat) {
                s += conf.Prefix + "agency\n" ;
            } else {
                s += ind + "agency\n" ;
            }
        }
        //      C# -> System.String? BucketName
        // GraphQL -> bucketName: String! (scalar)
        if (this.BucketName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bucketName\n" ;
            } else {
                s += ind + "bucketName\n" ;
            }
        }
        //      C# -> System.String? CapEndpoint
        // GraphQL -> capEndpoint: String! (scalar)
        if (this.CapEndpoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "capEndpoint\n" ;
            } else {
                s += ind + "capEndpoint\n" ;
            }
        }
        //      C# -> System.String? CertificateContent
        // GraphQL -> certificateContent: String! (scalar)
        if (this.CertificateContent != null) {
            if (conf.Flat) {
                s += conf.Prefix + "certificateContent\n" ;
            } else {
                s += ind + "certificateContent\n" ;
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
        //      C# -> System.String? KmsMasterKeyId
        // GraphQL -> kmsMasterKeyId: String! (scalar)
        if (this.KmsMasterKeyId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kmsMasterKeyId\n" ;
            } else {
                s += ind + "kmsMasterKeyId\n" ;
            }
        }
        //      C# -> System.String? Mission
        // GraphQL -> mission: String! (scalar)
        if (this.Mission != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mission\n" ;
            } else {
                s += ind + "mission\n" ;
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
        //      C# -> System.String? RoleName
        // GraphQL -> roleName: String! (scalar)
        if (this.RoleName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleName\n" ;
            } else {
                s += ind + "roleName\n" ;
            }
        }
        //      C# -> System.String? RsaKey
        // GraphQL -> rsaKey: String! (scalar)
        if (this.RsaKey != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rsaKey\n" ;
            } else {
                s += ind + "rsaKey\n" ;
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
        //      C# -> System.String? S3Endpoint
        // GraphQL -> s3Endpoint: String! (scalar)
        if (this.S3Endpoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "s3Endpoint\n" ;
            } else {
                s += ind + "s3Endpoint\n" ;
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
        //      C# -> System.Int32? TokenDuration
        // GraphQL -> tokenDuration: Int! (scalar)
        if (this.TokenDuration != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tokenDuration\n" ;
            } else {
                s += ind + "tokenDuration\n" ;
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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AwsRetrievalTier? AwsRetrievalTier
        // GraphQL -> awsRetrievalTier: AwsRetrievalTier! (enum)
        if (ec.Includes("awsRetrievalTier",true))
        {
            if(this.AwsRetrievalTier == null) {

                this.AwsRetrievalTier = new AwsRetrievalTier();

            } else {


            }
        }
        else if (this.AwsRetrievalTier != null && ec.Excludes("awsRetrievalTier",true))
        {
            this.AwsRetrievalTier = null;
        }
        //      C# -> ConnectionStatusType? ConnectionStatus
        // GraphQL -> connectionStatus: ConnectionStatusType! (enum)
        if (ec.Includes("connectionStatus",true))
        {
            if(this.ConnectionStatus == null) {

                this.ConnectionStatus = new ConnectionStatusType();

            } else {


            }
        }
        else if (this.ConnectionStatus != null && ec.Excludes("connectionStatus",true))
        {
            this.ConnectionStatus = null;
        }
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
        //      C# -> AwsDcaRegion? Region
        // GraphQL -> region: AwsDcaRegion! (enum)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = new AwsDcaRegion();

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
        //      C# -> AwsStorageClass? StorageClass
        // GraphQL -> storageClass: AwsStorageClass! (enum)
        if (ec.Includes("storageClass",true))
        {
            if(this.StorageClass == null) {

                this.StorageClass = new AwsStorageClass();

            } else {


            }
        }
        else if (this.StorageClass != null && ec.Excludes("storageClass",true))
        {
            this.StorageClass = null;
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
        //      C# -> System.String? Agency
        // GraphQL -> agency: String! (scalar)
        if (ec.Includes("agency",true))
        {
            if(this.Agency == null) {

                this.Agency = "FETCH";

            } else {


            }
        }
        else if (this.Agency != null && ec.Excludes("agency",true))
        {
            this.Agency = null;
        }
        //      C# -> System.String? BucketName
        // GraphQL -> bucketName: String! (scalar)
        if (ec.Includes("bucketName",true))
        {
            if(this.BucketName == null) {

                this.BucketName = "FETCH";

            } else {


            }
        }
        else if (this.BucketName != null && ec.Excludes("bucketName",true))
        {
            this.BucketName = null;
        }
        //      C# -> System.String? CapEndpoint
        // GraphQL -> capEndpoint: String! (scalar)
        if (ec.Includes("capEndpoint",true))
        {
            if(this.CapEndpoint == null) {

                this.CapEndpoint = "FETCH";

            } else {


            }
        }
        else if (this.CapEndpoint != null && ec.Excludes("capEndpoint",true))
        {
            this.CapEndpoint = null;
        }
        //      C# -> System.String? CertificateContent
        // GraphQL -> certificateContent: String! (scalar)
        if (ec.Includes("certificateContent",true))
        {
            if(this.CertificateContent == null) {

                this.CertificateContent = "FETCH";

            } else {


            }
        }
        else if (this.CertificateContent != null && ec.Excludes("certificateContent",true))
        {
            this.CertificateContent = null;
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
        //      C# -> System.String? KmsMasterKeyId
        // GraphQL -> kmsMasterKeyId: String! (scalar)
        if (ec.Includes("kmsMasterKeyId",true))
        {
            if(this.KmsMasterKeyId == null) {

                this.KmsMasterKeyId = "FETCH";

            } else {


            }
        }
        else if (this.KmsMasterKeyId != null && ec.Excludes("kmsMasterKeyId",true))
        {
            this.KmsMasterKeyId = null;
        }
        //      C# -> System.String? Mission
        // GraphQL -> mission: String! (scalar)
        if (ec.Includes("mission",true))
        {
            if(this.Mission == null) {

                this.Mission = "FETCH";

            } else {


            }
        }
        else if (this.Mission != null && ec.Excludes("mission",true))
        {
            this.Mission = null;
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
        //      C# -> System.String? RoleName
        // GraphQL -> roleName: String! (scalar)
        if (ec.Includes("roleName",true))
        {
            if(this.RoleName == null) {

                this.RoleName = "FETCH";

            } else {


            }
        }
        else if (this.RoleName != null && ec.Excludes("roleName",true))
        {
            this.RoleName = null;
        }
        //      C# -> System.String? RsaKey
        // GraphQL -> rsaKey: String! (scalar)
        if (ec.Includes("rsaKey",true))
        {
            if(this.RsaKey == null) {

                this.RsaKey = "FETCH";

            } else {


            }
        }
        else if (this.RsaKey != null && ec.Excludes("rsaKey",true))
        {
            this.RsaKey = null;
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
        //      C# -> System.String? S3Endpoint
        // GraphQL -> s3Endpoint: String! (scalar)
        if (ec.Includes("s3Endpoint",true))
        {
            if(this.S3Endpoint == null) {

                this.S3Endpoint = "FETCH";

            } else {


            }
        }
        else if (this.S3Endpoint != null && ec.Excludes("s3Endpoint",true))
        {
            this.S3Endpoint = null;
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
        //      C# -> System.Int32? TokenDuration
        // GraphQL -> tokenDuration: Int! (scalar)
        if (ec.Includes("tokenDuration",true))
        {
            if(this.TokenDuration == null) {

                this.TokenDuration = Int32.MinValue;

            } else {


            }
        }
        else if (this.TokenDuration != null && ec.Excludes("tokenDuration",true))
        {
            this.TokenDuration = null;
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

    } // class RubrikManagedDcaTarget
    
    #endregion

    public static class ListRubrikManagedDcaTargetExtensions
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
            this List<RubrikManagedDcaTarget> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RubrikManagedDcaTarget> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RubrikManagedDcaTarget> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RubrikManagedDcaTarget());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RubrikManagedDcaTarget> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types