// Cluster.cs
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
    #region Cluster
 
    public class Cluster: BaseType, AnomalyResultGroupByInfo, NfAnomalyResultGroupByInfo, RansomwareResultGroupByInfo, SnappableGroupByInfo, TaskDetailGroupByInfo
    {
        #region members

        //      C# -> List<Product>? LicensedProducts
        // GraphQL -> licensedProducts: [Product!]! (enum)
        [JsonProperty("licensedProducts")]
        public List<Product>? LicensedProducts { get; set; }

        //      C# -> ClusterPauseStatus? PauseStatus
        // GraphQL -> pauseStatus: ClusterPauseStatus (enum)
        [JsonProperty("pauseStatus")]
        public ClusterPauseStatus? PauseStatus { get; set; }

        //      C# -> ClusterProductEnum? ProductType
        // GraphQL -> productType: ClusterProductEnum (enum)
        [JsonProperty("productType")]
        public ClusterProductEnum? ProductType { get; set; }

        //      C# -> ClusterRegistrationMode? RegisteredMode
        // GraphQL -> registeredMode: ClusterRegistrationMode (enum)
        [JsonProperty("registeredMode")]
        public ClusterRegistrationMode? RegisteredMode { get; set; }

        //      C# -> ClusterStatus? Status
        // GraphQL -> status: ClusterStatus! (enum)
        [JsonProperty("status")]
        public ClusterStatus? Status { get; set; }

        //      C# -> ClusterSubStatus? SubStatus
        // GraphQL -> subStatus: ClusterSubStatus! (enum)
        [JsonProperty("subStatus")]
        public ClusterSubStatus? SubStatus { get; set; }

        //      C# -> ClusterSystemStatus? SystemStatus
        // GraphQL -> systemStatus: ClusterSystemStatus (enum)
        [JsonProperty("systemStatus")]
        public ClusterSystemStatus? SystemStatus { get; set; }

        //      C# -> ClusterTypeEnum? Type
        // GraphQL -> type: ClusterTypeEnum! (enum)
        [JsonProperty("type")]
        public ClusterTypeEnum? Type { get; set; }

        //      C# -> DateTime? ConnectivityLastUpdated
        // GraphQL -> connectivityLastUpdated: DateTime (scalar)
        [JsonProperty("connectivityLastUpdated")]
        public DateTime? ConnectivityLastUpdated { get; set; }

        //      C# -> System.String? DefaultAddress
        // GraphQL -> defaultAddress: String (scalar)
        [JsonProperty("defaultAddress")]
        public System.String? DefaultAddress { get; set; }

        //      C# -> System.Int32? DefaultPort
        // GraphQL -> defaultPort: Int (scalar)
        [JsonProperty("defaultPort")]
        public System.Int32? DefaultPort { get; set; }

        //      C# -> System.Boolean? EncryptionEnabled
        // GraphQL -> encryptionEnabled: Boolean! (scalar)
        [JsonProperty("encryptionEnabled")]
        public System.Boolean? EncryptionEnabled { get; set; }

        //      C# -> System.Int64? EstimatedRunway
        // GraphQL -> estimatedRunway: Long! (scalar)
        [JsonProperty("estimatedRunway")]
        public System.Int64? EstimatedRunway { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsHealthy
        // GraphQL -> isHealthy: Boolean! (scalar)
        [JsonProperty("isHealthy")]
        public System.Boolean? IsHealthy { get; set; }

        //      C# -> DateTime? LastConnectionTime
        // GraphQL -> lastConnectionTime: DateTime (scalar)
        [JsonProperty("lastConnectionTime")]
        public DateTime? LastConnectionTime { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NoSqlWorkloadCount
        // GraphQL -> noSqlWorkloadCount: Int! (scalar)
        [JsonProperty("noSqlWorkloadCount")]
        public System.Int32? NoSqlWorkloadCount { get; set; }

        //      C# -> System.Boolean? PassesConnectivityCheck
        // GraphQL -> passesConnectivityCheck: Boolean (scalar)
        [JsonProperty("passesConnectivityCheck")]
        public System.Boolean? PassesConnectivityCheck { get; set; }

        //      C# -> DateTime? RegistrationTime
        // GraphQL -> registrationTime: DateTime! (scalar)
        [JsonProperty("registrationTime")]
        public DateTime? RegistrationTime { get; set; }

        //      C# -> System.Int64? SnapshotCount
        // GraphQL -> snapshotCount: Long! (scalar)
        [JsonProperty("snapshotCount")]
        public System.Int64? SnapshotCount { get; set; }

        //      C# -> System.String? SystemStatusMessage
        // GraphQL -> systemStatusMessage: String (scalar)
        [JsonProperty("systemStatusMessage")]
        public System.String? SystemStatusMessage { get; set; }

        //      C# -> System.String? Timezone
        // GraphQL -> timezone: String (scalar)
        [JsonProperty("timezone")]
        public System.String? Timezone { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> ActivitySeriesConnection? ActivitySeriesConnection
        // GraphQL -> activitySeriesConnection: ActivitySeriesConnection! (type)
        [JsonProperty("activitySeriesConnection")]
        public ActivitySeriesConnection? ActivitySeriesConnection { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        [JsonProperty("authorizedOperations")]
        public AuthorizedOperations? AuthorizedOperations { get; set; }

        //      C# -> CcprovisionInfo? CcprovisionInfo
        // GraphQL -> ccprovisionInfo: CcprovisionInfo (type)
        [JsonProperty("ccprovisionInfo")]
        public CcprovisionInfo? CcprovisionInfo { get; set; }

        //      C# -> List<CdmNodeDetail>? CdmClusterNodeDetails
        // GraphQL -> cdmClusterNodeDetails: [CdmNodeDetail!]! (type)
        [JsonProperty("cdmClusterNodeDetails")]
        public List<CdmNodeDetail>? CdmClusterNodeDetails { get; set; }

        //      C# -> NotificationSettingSummaryListResponse? CdmNotificationSettings
        // GraphQL -> cdmNotificationSettings: NotificationSettingSummaryListResponse! (type)
        [JsonProperty("cdmNotificationSettings")]
        public NotificationSettingSummaryListResponse? CdmNotificationSettings { get; set; }

        //      C# -> CdmUpgradeInfo? CdmUpgradeInfo
        // GraphQL -> cdmUpgradeInfo: CdmUpgradeInfo (type)
        [JsonProperty("cdmUpgradeInfo")]
        public CdmUpgradeInfo? CdmUpgradeInfo { get; set; }

        //      C# -> CcWithCloudInfo? CloudInfo
        // GraphQL -> cloudInfo: CcWithCloudInfo (type)
        [JsonProperty("cloudInfo")]
        public CcWithCloudInfo? CloudInfo { get; set; }

        //      C# -> ClusterDiskConnection? ClusterDiskConnection
        // GraphQL -> clusterDiskConnection: ClusterDiskConnection! (type)
        [JsonProperty("clusterDiskConnection")]
        public ClusterDiskConnection? ClusterDiskConnection { get; set; }

        //      C# -> ClusterNodeConnection? ClusterNodeConnection
        // GraphQL -> clusterNodeConnection: ClusterNodeConnection! (type)
        [JsonProperty("clusterNodeConnection")]
        public ClusterNodeConnection? ClusterNodeConnection { get; set; }

        //      C# -> List<ClusterNodeStats>? ClusterNodeStats
        // GraphQL -> clusterNodeStats: [ClusterNodeStats!]! (type)
        [JsonProperty("clusterNodeStats")]
        public List<ClusterNodeStats>? ClusterNodeStats { get; set; }

        //      C# -> ConfigProtectionInfo? ConfigProtectionInfo
        // GraphQL -> configProtectionInfo: ConfigProtectionInfo (type)
        [JsonProperty("configProtectionInfo")]
        public ConfigProtectionInfo? ConfigProtectionInfo { get; set; }

        //      C# -> AutoEnablePolicyClusterConfigReply? DatagovAutoEnablePolicyConfig
        // GraphQL -> datagovAutoEnablePolicyConfig: AutoEnablePolicyClusterConfigReply! (type)
        [JsonProperty("datagovAutoEnablePolicyConfig")]
        public AutoEnablePolicyClusterConfigReply? DatagovAutoEnablePolicyConfig { get; set; }

        //      C# -> PreviewerClusterConfig? DatagovPreviewerConfig
        // GraphQL -> datagovPreviewerConfig: PreviewerClusterConfig! (type)
        [JsonProperty("datagovPreviewerConfig")]
        public PreviewerClusterConfig? DatagovPreviewerConfig { get; set; }

        //      C# -> GeoLocation? GeoLocation
        // GraphQL -> geoLocation: GeoLocation (type)
        [JsonProperty("geoLocation")]
        public GeoLocation? GeoLocation { get; set; }

        //      C# -> GlobalManagerConnectivity? GlobalManagerConnectivityStatus
        // GraphQL -> globalManagerConnectivityStatus: GlobalManagerConnectivity (type)
        [JsonProperty("globalManagerConnectivityStatus")]
        public GlobalManagerConnectivity? GlobalManagerConnectivityStatus { get; set; }

        //      C# -> GetLambdaConfigReply? LambdaConfig
        // GraphQL -> lambdaConfig: GetLambdaConfigReply (type)
        [JsonProperty("lambdaConfig")]
        public GetLambdaConfigReply? LambdaConfig { get; set; }

        //      C# -> LambdaFeatureHistory? LambdaFeatureHistory
        // GraphQL -> lambdaFeatureHistory: LambdaFeatureHistory (type)
        [JsonProperty("lambdaFeatureHistory")]
        public LambdaFeatureHistory? LambdaFeatureHistory { get; set; }

        //      C# -> JobsReply? MetadataPullScheduler
        // GraphQL -> metadataPullScheduler: JobsReply (type)
        [JsonProperty("metadataPullScheduler")]
        public JobsReply? MetadataPullScheduler { get; set; }

        //      C# -> ClusterMetric? Metric
        // GraphQL -> metric: ClusterMetric (type)
        [JsonProperty("metric")]
        public ClusterMetric? Metric { get; set; }

        //      C# -> List<MetricTimeSeries>? MetricTimeSeries
        // GraphQL -> metricTimeSeries: [metricTimeSeries!]! (type)
        [JsonProperty("metricTimeSeries")]
        public List<MetricTimeSeries>? MetricTimeSeries { get; set; }

        //      C# -> List<ReplicationSource>? ReplicationSources
        // GraphQL -> replicationSources: [ReplicationSource!]! (type)
        [JsonProperty("replicationSources")]
        public List<ReplicationSource>? ReplicationSources { get; set; }

        //      C# -> List<ReplicationTarget>? ReplicationTargets
        // GraphQL -> replicationTargets: [ReplicationTarget!]! (type)
        [JsonProperty("replicationTargets")]
        public List<ReplicationTarget>? ReplicationTargets { get; set; }

        //      C# -> RubrikSyncStatus? RubrikSyncStatus
        // GraphQL -> rubrikSyncStatus: RubrikSyncStatus! (type)
        [JsonProperty("rubrikSyncStatus")]
        public RubrikSyncStatus? RubrikSyncStatus { get; set; }

        //      C# -> SnappableConnection? SnappableConnection
        // GraphQL -> snappableConnection: SnappableConnection! (type)
        [JsonProperty("snappableConnection")]
        public SnappableConnection? SnappableConnection { get; set; }

        //      C# -> ClusterState? State
        // GraphQL -> state: clusterState! (type)
        [JsonProperty("state")]
        public ClusterState? State { get; set; }

        //      C# -> List<ClusterNode>? SystemStatusAffectedNodes
        // GraphQL -> systemStatusAffectedNodes: [ClusterNode!] (type)
        [JsonProperty("systemStatusAffectedNodes")]
        public List<ClusterNode>? SystemStatusAffectedNodes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Cluster";
    }

    public Cluster Set(
        List<Product>? LicensedProducts = null,
        ClusterPauseStatus? PauseStatus = null,
        ClusterProductEnum? ProductType = null,
        ClusterRegistrationMode? RegisteredMode = null,
        ClusterStatus? Status = null,
        ClusterSubStatus? SubStatus = null,
        ClusterSystemStatus? SystemStatus = null,
        ClusterTypeEnum? Type = null,
        DateTime? ConnectivityLastUpdated = null,
        System.String? DefaultAddress = null,
        System.Int32? DefaultPort = null,
        System.Boolean? EncryptionEnabled = null,
        System.Int64? EstimatedRunway = null,
        System.String? Id = null,
        System.Boolean? IsHealthy = null,
        DateTime? LastConnectionTime = null,
        System.String? Name = null,
        System.Int32? NoSqlWorkloadCount = null,
        System.Boolean? PassesConnectivityCheck = null,
        DateTime? RegistrationTime = null,
        System.Int64? SnapshotCount = null,
        System.String? SystemStatusMessage = null,
        System.String? Timezone = null,
        System.String? Version = null,
        ActivitySeriesConnection? ActivitySeriesConnection = null,
        List<Org>? AllOrgs = null,
        AuthorizedOperations? AuthorizedOperations = null,
        CcprovisionInfo? CcprovisionInfo = null,
        List<CdmNodeDetail>? CdmClusterNodeDetails = null,
        NotificationSettingSummaryListResponse? CdmNotificationSettings = null,
        CdmUpgradeInfo? CdmUpgradeInfo = null,
        CcWithCloudInfo? CloudInfo = null,
        ClusterDiskConnection? ClusterDiskConnection = null,
        ClusterNodeConnection? ClusterNodeConnection = null,
        List<ClusterNodeStats>? ClusterNodeStats = null,
        ConfigProtectionInfo? ConfigProtectionInfo = null,
        AutoEnablePolicyClusterConfigReply? DatagovAutoEnablePolicyConfig = null,
        PreviewerClusterConfig? DatagovPreviewerConfig = null,
        GeoLocation? GeoLocation = null,
        GlobalManagerConnectivity? GlobalManagerConnectivityStatus = null,
        GetLambdaConfigReply? LambdaConfig = null,
        LambdaFeatureHistory? LambdaFeatureHistory = null,
        JobsReply? MetadataPullScheduler = null,
        ClusterMetric? Metric = null,
        List<MetricTimeSeries>? MetricTimeSeries = null,
        List<ReplicationSource>? ReplicationSources = null,
        List<ReplicationTarget>? ReplicationTargets = null,
        RubrikSyncStatus? RubrikSyncStatus = null,
        SnappableConnection? SnappableConnection = null,
        ClusterState? State = null,
        List<ClusterNode>? SystemStatusAffectedNodes = null
    ) 
    {
        if ( LicensedProducts != null ) {
            this.LicensedProducts = LicensedProducts;
        }
        if ( PauseStatus != null ) {
            this.PauseStatus = PauseStatus;
        }
        if ( ProductType != null ) {
            this.ProductType = ProductType;
        }
        if ( RegisteredMode != null ) {
            this.RegisteredMode = RegisteredMode;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( SubStatus != null ) {
            this.SubStatus = SubStatus;
        }
        if ( SystemStatus != null ) {
            this.SystemStatus = SystemStatus;
        }
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( ConnectivityLastUpdated != null ) {
            this.ConnectivityLastUpdated = ConnectivityLastUpdated;
        }
        if ( DefaultAddress != null ) {
            this.DefaultAddress = DefaultAddress;
        }
        if ( DefaultPort != null ) {
            this.DefaultPort = DefaultPort;
        }
        if ( EncryptionEnabled != null ) {
            this.EncryptionEnabled = EncryptionEnabled;
        }
        if ( EstimatedRunway != null ) {
            this.EstimatedRunway = EstimatedRunway;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsHealthy != null ) {
            this.IsHealthy = IsHealthy;
        }
        if ( LastConnectionTime != null ) {
            this.LastConnectionTime = LastConnectionTime;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NoSqlWorkloadCount != null ) {
            this.NoSqlWorkloadCount = NoSqlWorkloadCount;
        }
        if ( PassesConnectivityCheck != null ) {
            this.PassesConnectivityCheck = PassesConnectivityCheck;
        }
        if ( RegistrationTime != null ) {
            this.RegistrationTime = RegistrationTime;
        }
        if ( SnapshotCount != null ) {
            this.SnapshotCount = SnapshotCount;
        }
        if ( SystemStatusMessage != null ) {
            this.SystemStatusMessage = SystemStatusMessage;
        }
        if ( Timezone != null ) {
            this.Timezone = Timezone;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( ActivitySeriesConnection != null ) {
            this.ActivitySeriesConnection = ActivitySeriesConnection;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( CcprovisionInfo != null ) {
            this.CcprovisionInfo = CcprovisionInfo;
        }
        if ( CdmClusterNodeDetails != null ) {
            this.CdmClusterNodeDetails = CdmClusterNodeDetails;
        }
        if ( CdmNotificationSettings != null ) {
            this.CdmNotificationSettings = CdmNotificationSettings;
        }
        if ( CdmUpgradeInfo != null ) {
            this.CdmUpgradeInfo = CdmUpgradeInfo;
        }
        if ( CloudInfo != null ) {
            this.CloudInfo = CloudInfo;
        }
        if ( ClusterDiskConnection != null ) {
            this.ClusterDiskConnection = ClusterDiskConnection;
        }
        if ( ClusterNodeConnection != null ) {
            this.ClusterNodeConnection = ClusterNodeConnection;
        }
        if ( ClusterNodeStats != null ) {
            this.ClusterNodeStats = ClusterNodeStats;
        }
        if ( ConfigProtectionInfo != null ) {
            this.ConfigProtectionInfo = ConfigProtectionInfo;
        }
        if ( DatagovAutoEnablePolicyConfig != null ) {
            this.DatagovAutoEnablePolicyConfig = DatagovAutoEnablePolicyConfig;
        }
        if ( DatagovPreviewerConfig != null ) {
            this.DatagovPreviewerConfig = DatagovPreviewerConfig;
        }
        if ( GeoLocation != null ) {
            this.GeoLocation = GeoLocation;
        }
        if ( GlobalManagerConnectivityStatus != null ) {
            this.GlobalManagerConnectivityStatus = GlobalManagerConnectivityStatus;
        }
        if ( LambdaConfig != null ) {
            this.LambdaConfig = LambdaConfig;
        }
        if ( LambdaFeatureHistory != null ) {
            this.LambdaFeatureHistory = LambdaFeatureHistory;
        }
        if ( MetadataPullScheduler != null ) {
            this.MetadataPullScheduler = MetadataPullScheduler;
        }
        if ( Metric != null ) {
            this.Metric = Metric;
        }
        if ( MetricTimeSeries != null ) {
            this.MetricTimeSeries = MetricTimeSeries;
        }
        if ( ReplicationSources != null ) {
            this.ReplicationSources = ReplicationSources;
        }
        if ( ReplicationTargets != null ) {
            this.ReplicationTargets = ReplicationTargets;
        }
        if ( RubrikSyncStatus != null ) {
            this.RubrikSyncStatus = RubrikSyncStatus;
        }
        if ( SnappableConnection != null ) {
            this.SnappableConnection = SnappableConnection;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( SystemStatusAffectedNodes != null ) {
            this.SystemStatusAffectedNodes = SystemStatusAffectedNodes;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<Product>? LicensedProducts
        // GraphQL -> licensedProducts: [Product!]! (enum)
        if (this.LicensedProducts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "licensedProducts\n" ;
            } else {
                s += ind + "licensedProducts\n" ;
            }
        }
        //      C# -> ClusterPauseStatus? PauseStatus
        // GraphQL -> pauseStatus: ClusterPauseStatus (enum)
        if (this.PauseStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pauseStatus\n" ;
            } else {
                s += ind + "pauseStatus\n" ;
            }
        }
        //      C# -> ClusterProductEnum? ProductType
        // GraphQL -> productType: ClusterProductEnum (enum)
        if (this.ProductType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "productType\n" ;
            } else {
                s += ind + "productType\n" ;
            }
        }
        //      C# -> ClusterRegistrationMode? RegisteredMode
        // GraphQL -> registeredMode: ClusterRegistrationMode (enum)
        if (this.RegisteredMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "registeredMode\n" ;
            } else {
                s += ind + "registeredMode\n" ;
            }
        }
        //      C# -> ClusterStatus? Status
        // GraphQL -> status: ClusterStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> ClusterSubStatus? SubStatus
        // GraphQL -> subStatus: ClusterSubStatus! (enum)
        if (this.SubStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subStatus\n" ;
            } else {
                s += ind + "subStatus\n" ;
            }
        }
        //      C# -> ClusterSystemStatus? SystemStatus
        // GraphQL -> systemStatus: ClusterSystemStatus (enum)
        if (this.SystemStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "systemStatus\n" ;
            } else {
                s += ind + "systemStatus\n" ;
            }
        }
        //      C# -> ClusterTypeEnum? Type
        // GraphQL -> type: ClusterTypeEnum! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> DateTime? ConnectivityLastUpdated
        // GraphQL -> connectivityLastUpdated: DateTime (scalar)
        if (this.ConnectivityLastUpdated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "connectivityLastUpdated\n" ;
            } else {
                s += ind + "connectivityLastUpdated\n" ;
            }
        }
        //      C# -> System.String? DefaultAddress
        // GraphQL -> defaultAddress: String (scalar)
        if (this.DefaultAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "defaultAddress\n" ;
            } else {
                s += ind + "defaultAddress\n" ;
            }
        }
        //      C# -> System.Int32? DefaultPort
        // GraphQL -> defaultPort: Int (scalar)
        if (this.DefaultPort != null) {
            if (conf.Flat) {
                s += conf.Prefix + "defaultPort\n" ;
            } else {
                s += ind + "defaultPort\n" ;
            }
        }
        //      C# -> System.Boolean? EncryptionEnabled
        // GraphQL -> encryptionEnabled: Boolean! (scalar)
        if (this.EncryptionEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "encryptionEnabled\n" ;
            } else {
                s += ind + "encryptionEnabled\n" ;
            }
        }
        //      C# -> System.Int64? EstimatedRunway
        // GraphQL -> estimatedRunway: Long! (scalar)
        if (this.EstimatedRunway != null) {
            if (conf.Flat) {
                s += conf.Prefix + "estimatedRunway\n" ;
            } else {
                s += ind + "estimatedRunway\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsHealthy
        // GraphQL -> isHealthy: Boolean! (scalar)
        if (this.IsHealthy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isHealthy\n" ;
            } else {
                s += ind + "isHealthy\n" ;
            }
        }
        //      C# -> DateTime? LastConnectionTime
        // GraphQL -> lastConnectionTime: DateTime (scalar)
        if (this.LastConnectionTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastConnectionTime\n" ;
            } else {
                s += ind + "lastConnectionTime\n" ;
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
        //      C# -> System.Int32? NoSqlWorkloadCount
        // GraphQL -> noSqlWorkloadCount: Int! (scalar)
        if (this.NoSqlWorkloadCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "noSqlWorkloadCount\n" ;
            } else {
                s += ind + "noSqlWorkloadCount\n" ;
            }
        }
        //      C# -> System.Boolean? PassesConnectivityCheck
        // GraphQL -> passesConnectivityCheck: Boolean (scalar)
        if (this.PassesConnectivityCheck != null) {
            if (conf.Flat) {
                s += conf.Prefix + "passesConnectivityCheck\n" ;
            } else {
                s += ind + "passesConnectivityCheck\n" ;
            }
        }
        //      C# -> DateTime? RegistrationTime
        // GraphQL -> registrationTime: DateTime! (scalar)
        if (this.RegistrationTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "registrationTime\n" ;
            } else {
                s += ind + "registrationTime\n" ;
            }
        }
        //      C# -> System.Int64? SnapshotCount
        // GraphQL -> snapshotCount: Long! (scalar)
        if (this.SnapshotCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotCount\n" ;
            } else {
                s += ind + "snapshotCount\n" ;
            }
        }
        //      C# -> System.String? SystemStatusMessage
        // GraphQL -> systemStatusMessage: String (scalar)
        if (this.SystemStatusMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "systemStatusMessage\n" ;
            } else {
                s += ind + "systemStatusMessage\n" ;
            }
        }
        //      C# -> System.String? Timezone
        // GraphQL -> timezone: String (scalar)
        if (this.Timezone != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timezone\n" ;
            } else {
                s += ind + "timezone\n" ;
            }
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> ActivitySeriesConnection? ActivitySeriesConnection
        // GraphQL -> activitySeriesConnection: ActivitySeriesConnection! (type)
        if (this.ActivitySeriesConnection != null) {
            var fspec = this.ActivitySeriesConnection.AsFieldSpec(conf.Child("activitySeriesConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "activitySeriesConnection {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            var fspec = this.AllOrgs.AsFieldSpec(conf.Child("allOrgs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allOrgs {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        if (this.AuthorizedOperations != null) {
            var fspec = this.AuthorizedOperations.AsFieldSpec(conf.Child("authorizedOperations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "authorizedOperations {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CcprovisionInfo? CcprovisionInfo
        // GraphQL -> ccprovisionInfo: CcprovisionInfo (type)
        if (this.CcprovisionInfo != null) {
            var fspec = this.CcprovisionInfo.AsFieldSpec(conf.Child("ccprovisionInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ccprovisionInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<CdmNodeDetail>? CdmClusterNodeDetails
        // GraphQL -> cdmClusterNodeDetails: [CdmNodeDetail!]! (type)
        if (this.CdmClusterNodeDetails != null) {
            var fspec = this.CdmClusterNodeDetails.AsFieldSpec(conf.Child("cdmClusterNodeDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cdmClusterNodeDetails {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> NotificationSettingSummaryListResponse? CdmNotificationSettings
        // GraphQL -> cdmNotificationSettings: NotificationSettingSummaryListResponse! (type)
        if (this.CdmNotificationSettings != null) {
            var fspec = this.CdmNotificationSettings.AsFieldSpec(conf.Child("cdmNotificationSettings"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cdmNotificationSettings {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmUpgradeInfo? CdmUpgradeInfo
        // GraphQL -> cdmUpgradeInfo: CdmUpgradeInfo (type)
        if (this.CdmUpgradeInfo != null) {
            var fspec = this.CdmUpgradeInfo.AsFieldSpec(conf.Child("cdmUpgradeInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cdmUpgradeInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CcWithCloudInfo? CloudInfo
        // GraphQL -> cloudInfo: CcWithCloudInfo (type)
        if (this.CloudInfo != null) {
            var fspec = this.CloudInfo.AsFieldSpec(conf.Child("cloudInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ClusterDiskConnection? ClusterDiskConnection
        // GraphQL -> clusterDiskConnection: ClusterDiskConnection! (type)
        if (this.ClusterDiskConnection != null) {
            var fspec = this.ClusterDiskConnection.AsFieldSpec(conf.Child("clusterDiskConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterDiskConnection {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ClusterNodeConnection? ClusterNodeConnection
        // GraphQL -> clusterNodeConnection: ClusterNodeConnection! (type)
        if (this.ClusterNodeConnection != null) {
            var fspec = this.ClusterNodeConnection.AsFieldSpec(conf.Child("clusterNodeConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterNodeConnection {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ClusterNodeStats>? ClusterNodeStats
        // GraphQL -> clusterNodeStats: [ClusterNodeStats!]! (type)
        if (this.ClusterNodeStats != null) {
            var fspec = this.ClusterNodeStats.AsFieldSpec(conf.Child("clusterNodeStats"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterNodeStats {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ConfigProtectionInfo? ConfigProtectionInfo
        // GraphQL -> configProtectionInfo: ConfigProtectionInfo (type)
        if (this.ConfigProtectionInfo != null) {
            var fspec = this.ConfigProtectionInfo.AsFieldSpec(conf.Child("configProtectionInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "configProtectionInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AutoEnablePolicyClusterConfigReply? DatagovAutoEnablePolicyConfig
        // GraphQL -> datagovAutoEnablePolicyConfig: AutoEnablePolicyClusterConfigReply! (type)
        if (this.DatagovAutoEnablePolicyConfig != null) {
            var fspec = this.DatagovAutoEnablePolicyConfig.AsFieldSpec(conf.Child("datagovAutoEnablePolicyConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "datagovAutoEnablePolicyConfig {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PreviewerClusterConfig? DatagovPreviewerConfig
        // GraphQL -> datagovPreviewerConfig: PreviewerClusterConfig! (type)
        if (this.DatagovPreviewerConfig != null) {
            var fspec = this.DatagovPreviewerConfig.AsFieldSpec(conf.Child("datagovPreviewerConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "datagovPreviewerConfig {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> GeoLocation? GeoLocation
        // GraphQL -> geoLocation: GeoLocation (type)
        if (this.GeoLocation != null) {
            var fspec = this.GeoLocation.AsFieldSpec(conf.Child("geoLocation"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "geoLocation {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> GlobalManagerConnectivity? GlobalManagerConnectivityStatus
        // GraphQL -> globalManagerConnectivityStatus: GlobalManagerConnectivity (type)
        if (this.GlobalManagerConnectivityStatus != null) {
            var fspec = this.GlobalManagerConnectivityStatus.AsFieldSpec(conf.Child("globalManagerConnectivityStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "globalManagerConnectivityStatus {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> GetLambdaConfigReply? LambdaConfig
        // GraphQL -> lambdaConfig: GetLambdaConfigReply (type)
        if (this.LambdaConfig != null) {
            var fspec = this.LambdaConfig.AsFieldSpec(conf.Child("lambdaConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lambdaConfig {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> LambdaFeatureHistory? LambdaFeatureHistory
        // GraphQL -> lambdaFeatureHistory: LambdaFeatureHistory (type)
        if (this.LambdaFeatureHistory != null) {
            var fspec = this.LambdaFeatureHistory.AsFieldSpec(conf.Child("lambdaFeatureHistory"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lambdaFeatureHistory {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> JobsReply? MetadataPullScheduler
        // GraphQL -> metadataPullScheduler: JobsReply (type)
        if (this.MetadataPullScheduler != null) {
            var fspec = this.MetadataPullScheduler.AsFieldSpec(conf.Child("metadataPullScheduler"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "metadataPullScheduler {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ClusterMetric? Metric
        // GraphQL -> metric: ClusterMetric (type)
        if (this.Metric != null) {
            var fspec = this.Metric.AsFieldSpec(conf.Child("metric"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "metric {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<MetricTimeSeries>? MetricTimeSeries
        // GraphQL -> metricTimeSeries: [metricTimeSeries!]! (type)
        if (this.MetricTimeSeries != null) {
            var fspec = this.MetricTimeSeries.AsFieldSpec(conf.Child("metricTimeSeries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "metricTimeSeries {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ReplicationSource>? ReplicationSources
        // GraphQL -> replicationSources: [ReplicationSource!]! (type)
        if (this.ReplicationSources != null) {
            var fspec = this.ReplicationSources.AsFieldSpec(conf.Child("replicationSources"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "replicationSources {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ReplicationTarget>? ReplicationTargets
        // GraphQL -> replicationTargets: [ReplicationTarget!]! (type)
        if (this.ReplicationTargets != null) {
            var fspec = this.ReplicationTargets.AsFieldSpec(conf.Child("replicationTargets"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "replicationTargets {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RubrikSyncStatus? RubrikSyncStatus
        // GraphQL -> rubrikSyncStatus: RubrikSyncStatus! (type)
        if (this.RubrikSyncStatus != null) {
            var fspec = this.RubrikSyncStatus.AsFieldSpec(conf.Child("rubrikSyncStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "rubrikSyncStatus {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SnappableConnection? SnappableConnection
        // GraphQL -> snappableConnection: SnappableConnection! (type)
        if (this.SnappableConnection != null) {
            var fspec = this.SnappableConnection.AsFieldSpec(conf.Child("snappableConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snappableConnection {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ClusterState? State
        // GraphQL -> state: clusterState! (type)
        if (this.State != null) {
            var fspec = this.State.AsFieldSpec(conf.Child("state"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "state {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ClusterNode>? SystemStatusAffectedNodes
        // GraphQL -> systemStatusAffectedNodes: [ClusterNode!] (type)
        if (this.SystemStatusAffectedNodes != null) {
            var fspec = this.SystemStatusAffectedNodes.AsFieldSpec(conf.Child("systemStatusAffectedNodes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "systemStatusAffectedNodes {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<Product>? LicensedProducts
        // GraphQL -> licensedProducts: [Product!]! (enum)
        if (ec.Includes("licensedProducts",true))
        {
            if(this.LicensedProducts == null) {

                this.LicensedProducts = new List<Product>();

            } else {


            }
        }
        else if (this.LicensedProducts != null && ec.Excludes("licensedProducts",true))
        {
            this.LicensedProducts = null;
        }
        //      C# -> ClusterPauseStatus? PauseStatus
        // GraphQL -> pauseStatus: ClusterPauseStatus (enum)
        if (ec.Includes("pauseStatus",true))
        {
            if(this.PauseStatus == null) {

                this.PauseStatus = new ClusterPauseStatus();

            } else {


            }
        }
        else if (this.PauseStatus != null && ec.Excludes("pauseStatus",true))
        {
            this.PauseStatus = null;
        }
        //      C# -> ClusterProductEnum? ProductType
        // GraphQL -> productType: ClusterProductEnum (enum)
        if (ec.Includes("productType",true))
        {
            if(this.ProductType == null) {

                this.ProductType = new ClusterProductEnum();

            } else {


            }
        }
        else if (this.ProductType != null && ec.Excludes("productType",true))
        {
            this.ProductType = null;
        }
        //      C# -> ClusterRegistrationMode? RegisteredMode
        // GraphQL -> registeredMode: ClusterRegistrationMode (enum)
        if (ec.Includes("registeredMode",true))
        {
            if(this.RegisteredMode == null) {

                this.RegisteredMode = new ClusterRegistrationMode();

            } else {


            }
        }
        else if (this.RegisteredMode != null && ec.Excludes("registeredMode",true))
        {
            this.RegisteredMode = null;
        }
        //      C# -> ClusterStatus? Status
        // GraphQL -> status: ClusterStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new ClusterStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> ClusterSubStatus? SubStatus
        // GraphQL -> subStatus: ClusterSubStatus! (enum)
        if (ec.Includes("subStatus",true))
        {
            if(this.SubStatus == null) {

                this.SubStatus = new ClusterSubStatus();

            } else {


            }
        }
        else if (this.SubStatus != null && ec.Excludes("subStatus",true))
        {
            this.SubStatus = null;
        }
        //      C# -> ClusterSystemStatus? SystemStatus
        // GraphQL -> systemStatus: ClusterSystemStatus (enum)
        if (ec.Includes("systemStatus",true))
        {
            if(this.SystemStatus == null) {

                this.SystemStatus = new ClusterSystemStatus();

            } else {


            }
        }
        else if (this.SystemStatus != null && ec.Excludes("systemStatus",true))
        {
            this.SystemStatus = null;
        }
        //      C# -> ClusterTypeEnum? Type
        // GraphQL -> type: ClusterTypeEnum! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new ClusterTypeEnum();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> DateTime? ConnectivityLastUpdated
        // GraphQL -> connectivityLastUpdated: DateTime (scalar)
        if (ec.Includes("connectivityLastUpdated",true))
        {
            if(this.ConnectivityLastUpdated == null) {

                this.ConnectivityLastUpdated = new DateTime();

            } else {


            }
        }
        else if (this.ConnectivityLastUpdated != null && ec.Excludes("connectivityLastUpdated",true))
        {
            this.ConnectivityLastUpdated = null;
        }
        //      C# -> System.String? DefaultAddress
        // GraphQL -> defaultAddress: String (scalar)
        if (ec.Includes("defaultAddress",true))
        {
            if(this.DefaultAddress == null) {

                this.DefaultAddress = "FETCH";

            } else {


            }
        }
        else if (this.DefaultAddress != null && ec.Excludes("defaultAddress",true))
        {
            this.DefaultAddress = null;
        }
        //      C# -> System.Int32? DefaultPort
        // GraphQL -> defaultPort: Int (scalar)
        if (ec.Includes("defaultPort",true))
        {
            if(this.DefaultPort == null) {

                this.DefaultPort = Int32.MinValue;

            } else {


            }
        }
        else if (this.DefaultPort != null && ec.Excludes("defaultPort",true))
        {
            this.DefaultPort = null;
        }
        //      C# -> System.Boolean? EncryptionEnabled
        // GraphQL -> encryptionEnabled: Boolean! (scalar)
        if (ec.Includes("encryptionEnabled",true))
        {
            if(this.EncryptionEnabled == null) {

                this.EncryptionEnabled = true;

            } else {


            }
        }
        else if (this.EncryptionEnabled != null && ec.Excludes("encryptionEnabled",true))
        {
            this.EncryptionEnabled = null;
        }
        //      C# -> System.Int64? EstimatedRunway
        // GraphQL -> estimatedRunway: Long! (scalar)
        if (ec.Includes("estimatedRunway",true))
        {
            if(this.EstimatedRunway == null) {

                this.EstimatedRunway = new System.Int64();

            } else {


            }
        }
        else if (this.EstimatedRunway != null && ec.Excludes("estimatedRunway",true))
        {
            this.EstimatedRunway = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
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
        //      C# -> System.Boolean? IsHealthy
        // GraphQL -> isHealthy: Boolean! (scalar)
        if (ec.Includes("isHealthy",true))
        {
            if(this.IsHealthy == null) {

                this.IsHealthy = true;

            } else {


            }
        }
        else if (this.IsHealthy != null && ec.Excludes("isHealthy",true))
        {
            this.IsHealthy = null;
        }
        //      C# -> DateTime? LastConnectionTime
        // GraphQL -> lastConnectionTime: DateTime (scalar)
        if (ec.Includes("lastConnectionTime",true))
        {
            if(this.LastConnectionTime == null) {

                this.LastConnectionTime = new DateTime();

            } else {


            }
        }
        else if (this.LastConnectionTime != null && ec.Excludes("lastConnectionTime",true))
        {
            this.LastConnectionTime = null;
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
        //      C# -> System.Int32? NoSqlWorkloadCount
        // GraphQL -> noSqlWorkloadCount: Int! (scalar)
        if (ec.Includes("noSqlWorkloadCount",true))
        {
            if(this.NoSqlWorkloadCount == null) {

                this.NoSqlWorkloadCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.NoSqlWorkloadCount != null && ec.Excludes("noSqlWorkloadCount",true))
        {
            this.NoSqlWorkloadCount = null;
        }
        //      C# -> System.Boolean? PassesConnectivityCheck
        // GraphQL -> passesConnectivityCheck: Boolean (scalar)
        if (ec.Includes("passesConnectivityCheck",true))
        {
            if(this.PassesConnectivityCheck == null) {

                this.PassesConnectivityCheck = true;

            } else {


            }
        }
        else if (this.PassesConnectivityCheck != null && ec.Excludes("passesConnectivityCheck",true))
        {
            this.PassesConnectivityCheck = null;
        }
        //      C# -> DateTime? RegistrationTime
        // GraphQL -> registrationTime: DateTime! (scalar)
        if (ec.Includes("registrationTime",true))
        {
            if(this.RegistrationTime == null) {

                this.RegistrationTime = new DateTime();

            } else {


            }
        }
        else if (this.RegistrationTime != null && ec.Excludes("registrationTime",true))
        {
            this.RegistrationTime = null;
        }
        //      C# -> System.Int64? SnapshotCount
        // GraphQL -> snapshotCount: Long! (scalar)
        if (ec.Includes("snapshotCount",true))
        {
            if(this.SnapshotCount == null) {

                this.SnapshotCount = new System.Int64();

            } else {


            }
        }
        else if (this.SnapshotCount != null && ec.Excludes("snapshotCount",true))
        {
            this.SnapshotCount = null;
        }
        //      C# -> System.String? SystemStatusMessage
        // GraphQL -> systemStatusMessage: String (scalar)
        if (ec.Includes("systemStatusMessage",true))
        {
            if(this.SystemStatusMessage == null) {

                this.SystemStatusMessage = "FETCH";

            } else {


            }
        }
        else if (this.SystemStatusMessage != null && ec.Excludes("systemStatusMessage",true))
        {
            this.SystemStatusMessage = null;
        }
        //      C# -> System.String? Timezone
        // GraphQL -> timezone: String (scalar)
        if (ec.Includes("timezone",true))
        {
            if(this.Timezone == null) {

                this.Timezone = "FETCH";

            } else {


            }
        }
        else if (this.Timezone != null && ec.Excludes("timezone",true))
        {
            this.Timezone = null;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> ActivitySeriesConnection? ActivitySeriesConnection
        // GraphQL -> activitySeriesConnection: ActivitySeriesConnection! (type)
        if (ec.Includes("activitySeriesConnection",false))
        {
            if(this.ActivitySeriesConnection == null) {

                this.ActivitySeriesConnection = new ActivitySeriesConnection();
                this.ActivitySeriesConnection.ApplyExploratoryFieldSpec(ec.NewChild("activitySeriesConnection"));

            } else {

                this.ActivitySeriesConnection.ApplyExploratoryFieldSpec(ec.NewChild("activitySeriesConnection"));

            }
        }
        else if (this.ActivitySeriesConnection != null && ec.Excludes("activitySeriesConnection",false))
        {
            this.ActivitySeriesConnection = null;
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (ec.Includes("allOrgs",false))
        {
            if(this.AllOrgs == null) {

                this.AllOrgs = new List<Org>();
                this.AllOrgs.ApplyExploratoryFieldSpec(ec.NewChild("allOrgs"));

            } else {

                this.AllOrgs.ApplyExploratoryFieldSpec(ec.NewChild("allOrgs"));

            }
        }
        else if (this.AllOrgs != null && ec.Excludes("allOrgs",false))
        {
            this.AllOrgs = null;
        }
        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        if (ec.Includes("authorizedOperations",false))
        {
            if(this.AuthorizedOperations == null) {

                this.AuthorizedOperations = new AuthorizedOperations();
                this.AuthorizedOperations.ApplyExploratoryFieldSpec(ec.NewChild("authorizedOperations"));

            } else {

                this.AuthorizedOperations.ApplyExploratoryFieldSpec(ec.NewChild("authorizedOperations"));

            }
        }
        else if (this.AuthorizedOperations != null && ec.Excludes("authorizedOperations",false))
        {
            this.AuthorizedOperations = null;
        }
        //      C# -> CcprovisionInfo? CcprovisionInfo
        // GraphQL -> ccprovisionInfo: CcprovisionInfo (type)
        if (ec.Includes("ccprovisionInfo",false))
        {
            if(this.CcprovisionInfo == null) {

                this.CcprovisionInfo = new CcprovisionInfo();
                this.CcprovisionInfo.ApplyExploratoryFieldSpec(ec.NewChild("ccprovisionInfo"));

            } else {

                this.CcprovisionInfo.ApplyExploratoryFieldSpec(ec.NewChild("ccprovisionInfo"));

            }
        }
        else if (this.CcprovisionInfo != null && ec.Excludes("ccprovisionInfo",false))
        {
            this.CcprovisionInfo = null;
        }
        //      C# -> List<CdmNodeDetail>? CdmClusterNodeDetails
        // GraphQL -> cdmClusterNodeDetails: [CdmNodeDetail!]! (type)
        if (ec.Includes("cdmClusterNodeDetails",false))
        {
            if(this.CdmClusterNodeDetails == null) {

                this.CdmClusterNodeDetails = new List<CdmNodeDetail>();
                this.CdmClusterNodeDetails.ApplyExploratoryFieldSpec(ec.NewChild("cdmClusterNodeDetails"));

            } else {

                this.CdmClusterNodeDetails.ApplyExploratoryFieldSpec(ec.NewChild("cdmClusterNodeDetails"));

            }
        }
        else if (this.CdmClusterNodeDetails != null && ec.Excludes("cdmClusterNodeDetails",false))
        {
            this.CdmClusterNodeDetails = null;
        }
        //      C# -> NotificationSettingSummaryListResponse? CdmNotificationSettings
        // GraphQL -> cdmNotificationSettings: NotificationSettingSummaryListResponse! (type)
        if (ec.Includes("cdmNotificationSettings",false))
        {
            if(this.CdmNotificationSettings == null) {

                this.CdmNotificationSettings = new NotificationSettingSummaryListResponse();
                this.CdmNotificationSettings.ApplyExploratoryFieldSpec(ec.NewChild("cdmNotificationSettings"));

            } else {

                this.CdmNotificationSettings.ApplyExploratoryFieldSpec(ec.NewChild("cdmNotificationSettings"));

            }
        }
        else if (this.CdmNotificationSettings != null && ec.Excludes("cdmNotificationSettings",false))
        {
            this.CdmNotificationSettings = null;
        }
        //      C# -> CdmUpgradeInfo? CdmUpgradeInfo
        // GraphQL -> cdmUpgradeInfo: CdmUpgradeInfo (type)
        if (ec.Includes("cdmUpgradeInfo",false))
        {
            if(this.CdmUpgradeInfo == null) {

                this.CdmUpgradeInfo = new CdmUpgradeInfo();
                this.CdmUpgradeInfo.ApplyExploratoryFieldSpec(ec.NewChild("cdmUpgradeInfo"));

            } else {

                this.CdmUpgradeInfo.ApplyExploratoryFieldSpec(ec.NewChild("cdmUpgradeInfo"));

            }
        }
        else if (this.CdmUpgradeInfo != null && ec.Excludes("cdmUpgradeInfo",false))
        {
            this.CdmUpgradeInfo = null;
        }
        //      C# -> CcWithCloudInfo? CloudInfo
        // GraphQL -> cloudInfo: CcWithCloudInfo (type)
        if (ec.Includes("cloudInfo",false))
        {
            if(this.CloudInfo == null) {

                this.CloudInfo = new CcWithCloudInfo();
                this.CloudInfo.ApplyExploratoryFieldSpec(ec.NewChild("cloudInfo"));

            } else {

                this.CloudInfo.ApplyExploratoryFieldSpec(ec.NewChild("cloudInfo"));

            }
        }
        else if (this.CloudInfo != null && ec.Excludes("cloudInfo",false))
        {
            this.CloudInfo = null;
        }
        //      C# -> ClusterDiskConnection? ClusterDiskConnection
        // GraphQL -> clusterDiskConnection: ClusterDiskConnection! (type)
        if (ec.Includes("clusterDiskConnection",false))
        {
            if(this.ClusterDiskConnection == null) {

                this.ClusterDiskConnection = new ClusterDiskConnection();
                this.ClusterDiskConnection.ApplyExploratoryFieldSpec(ec.NewChild("clusterDiskConnection"));

            } else {

                this.ClusterDiskConnection.ApplyExploratoryFieldSpec(ec.NewChild("clusterDiskConnection"));

            }
        }
        else if (this.ClusterDiskConnection != null && ec.Excludes("clusterDiskConnection",false))
        {
            this.ClusterDiskConnection = null;
        }
        //      C# -> ClusterNodeConnection? ClusterNodeConnection
        // GraphQL -> clusterNodeConnection: ClusterNodeConnection! (type)
        if (ec.Includes("clusterNodeConnection",false))
        {
            if(this.ClusterNodeConnection == null) {

                this.ClusterNodeConnection = new ClusterNodeConnection();
                this.ClusterNodeConnection.ApplyExploratoryFieldSpec(ec.NewChild("clusterNodeConnection"));

            } else {

                this.ClusterNodeConnection.ApplyExploratoryFieldSpec(ec.NewChild("clusterNodeConnection"));

            }
        }
        else if (this.ClusterNodeConnection != null && ec.Excludes("clusterNodeConnection",false))
        {
            this.ClusterNodeConnection = null;
        }
        //      C# -> List<ClusterNodeStats>? ClusterNodeStats
        // GraphQL -> clusterNodeStats: [ClusterNodeStats!]! (type)
        if (ec.Includes("clusterNodeStats",false))
        {
            if(this.ClusterNodeStats == null) {

                this.ClusterNodeStats = new List<ClusterNodeStats>();
                this.ClusterNodeStats.ApplyExploratoryFieldSpec(ec.NewChild("clusterNodeStats"));

            } else {

                this.ClusterNodeStats.ApplyExploratoryFieldSpec(ec.NewChild("clusterNodeStats"));

            }
        }
        else if (this.ClusterNodeStats != null && ec.Excludes("clusterNodeStats",false))
        {
            this.ClusterNodeStats = null;
        }
        //      C# -> ConfigProtectionInfo? ConfigProtectionInfo
        // GraphQL -> configProtectionInfo: ConfigProtectionInfo (type)
        if (ec.Includes("configProtectionInfo",false))
        {
            if(this.ConfigProtectionInfo == null) {

                this.ConfigProtectionInfo = new ConfigProtectionInfo();
                this.ConfigProtectionInfo.ApplyExploratoryFieldSpec(ec.NewChild("configProtectionInfo"));

            } else {

                this.ConfigProtectionInfo.ApplyExploratoryFieldSpec(ec.NewChild("configProtectionInfo"));

            }
        }
        else if (this.ConfigProtectionInfo != null && ec.Excludes("configProtectionInfo",false))
        {
            this.ConfigProtectionInfo = null;
        }
        //      C# -> AutoEnablePolicyClusterConfigReply? DatagovAutoEnablePolicyConfig
        // GraphQL -> datagovAutoEnablePolicyConfig: AutoEnablePolicyClusterConfigReply! (type)
        if (ec.Includes("datagovAutoEnablePolicyConfig",false))
        {
            if(this.DatagovAutoEnablePolicyConfig == null) {

                this.DatagovAutoEnablePolicyConfig = new AutoEnablePolicyClusterConfigReply();
                this.DatagovAutoEnablePolicyConfig.ApplyExploratoryFieldSpec(ec.NewChild("datagovAutoEnablePolicyConfig"));

            } else {

                this.DatagovAutoEnablePolicyConfig.ApplyExploratoryFieldSpec(ec.NewChild("datagovAutoEnablePolicyConfig"));

            }
        }
        else if (this.DatagovAutoEnablePolicyConfig != null && ec.Excludes("datagovAutoEnablePolicyConfig",false))
        {
            this.DatagovAutoEnablePolicyConfig = null;
        }
        //      C# -> PreviewerClusterConfig? DatagovPreviewerConfig
        // GraphQL -> datagovPreviewerConfig: PreviewerClusterConfig! (type)
        if (ec.Includes("datagovPreviewerConfig",false))
        {
            if(this.DatagovPreviewerConfig == null) {

                this.DatagovPreviewerConfig = new PreviewerClusterConfig();
                this.DatagovPreviewerConfig.ApplyExploratoryFieldSpec(ec.NewChild("datagovPreviewerConfig"));

            } else {

                this.DatagovPreviewerConfig.ApplyExploratoryFieldSpec(ec.NewChild("datagovPreviewerConfig"));

            }
        }
        else if (this.DatagovPreviewerConfig != null && ec.Excludes("datagovPreviewerConfig",false))
        {
            this.DatagovPreviewerConfig = null;
        }
        //      C# -> GeoLocation? GeoLocation
        // GraphQL -> geoLocation: GeoLocation (type)
        if (ec.Includes("geoLocation",false))
        {
            if(this.GeoLocation == null) {

                this.GeoLocation = new GeoLocation();
                this.GeoLocation.ApplyExploratoryFieldSpec(ec.NewChild("geoLocation"));

            } else {

                this.GeoLocation.ApplyExploratoryFieldSpec(ec.NewChild("geoLocation"));

            }
        }
        else if (this.GeoLocation != null && ec.Excludes("geoLocation",false))
        {
            this.GeoLocation = null;
        }
        //      C# -> GlobalManagerConnectivity? GlobalManagerConnectivityStatus
        // GraphQL -> globalManagerConnectivityStatus: GlobalManagerConnectivity (type)
        if (ec.Includes("globalManagerConnectivityStatus",false))
        {
            if(this.GlobalManagerConnectivityStatus == null) {

                this.GlobalManagerConnectivityStatus = new GlobalManagerConnectivity();
                this.GlobalManagerConnectivityStatus.ApplyExploratoryFieldSpec(ec.NewChild("globalManagerConnectivityStatus"));

            } else {

                this.GlobalManagerConnectivityStatus.ApplyExploratoryFieldSpec(ec.NewChild("globalManagerConnectivityStatus"));

            }
        }
        else if (this.GlobalManagerConnectivityStatus != null && ec.Excludes("globalManagerConnectivityStatus",false))
        {
            this.GlobalManagerConnectivityStatus = null;
        }
        //      C# -> GetLambdaConfigReply? LambdaConfig
        // GraphQL -> lambdaConfig: GetLambdaConfigReply (type)
        if (ec.Includes("lambdaConfig",false))
        {
            if(this.LambdaConfig == null) {

                this.LambdaConfig = new GetLambdaConfigReply();
                this.LambdaConfig.ApplyExploratoryFieldSpec(ec.NewChild("lambdaConfig"));

            } else {

                this.LambdaConfig.ApplyExploratoryFieldSpec(ec.NewChild("lambdaConfig"));

            }
        }
        else if (this.LambdaConfig != null && ec.Excludes("lambdaConfig",false))
        {
            this.LambdaConfig = null;
        }
        //      C# -> LambdaFeatureHistory? LambdaFeatureHistory
        // GraphQL -> lambdaFeatureHistory: LambdaFeatureHistory (type)
        if (ec.Includes("lambdaFeatureHistory",false))
        {
            if(this.LambdaFeatureHistory == null) {

                this.LambdaFeatureHistory = new LambdaFeatureHistory();
                this.LambdaFeatureHistory.ApplyExploratoryFieldSpec(ec.NewChild("lambdaFeatureHistory"));

            } else {

                this.LambdaFeatureHistory.ApplyExploratoryFieldSpec(ec.NewChild("lambdaFeatureHistory"));

            }
        }
        else if (this.LambdaFeatureHistory != null && ec.Excludes("lambdaFeatureHistory",false))
        {
            this.LambdaFeatureHistory = null;
        }
        //      C# -> JobsReply? MetadataPullScheduler
        // GraphQL -> metadataPullScheduler: JobsReply (type)
        if (ec.Includes("metadataPullScheduler",false))
        {
            if(this.MetadataPullScheduler == null) {

                this.MetadataPullScheduler = new JobsReply();
                this.MetadataPullScheduler.ApplyExploratoryFieldSpec(ec.NewChild("metadataPullScheduler"));

            } else {

                this.MetadataPullScheduler.ApplyExploratoryFieldSpec(ec.NewChild("metadataPullScheduler"));

            }
        }
        else if (this.MetadataPullScheduler != null && ec.Excludes("metadataPullScheduler",false))
        {
            this.MetadataPullScheduler = null;
        }
        //      C# -> ClusterMetric? Metric
        // GraphQL -> metric: ClusterMetric (type)
        if (ec.Includes("metric",false))
        {
            if(this.Metric == null) {

                this.Metric = new ClusterMetric();
                this.Metric.ApplyExploratoryFieldSpec(ec.NewChild("metric"));

            } else {

                this.Metric.ApplyExploratoryFieldSpec(ec.NewChild("metric"));

            }
        }
        else if (this.Metric != null && ec.Excludes("metric",false))
        {
            this.Metric = null;
        }
        //      C# -> List<MetricTimeSeries>? MetricTimeSeries
        // GraphQL -> metricTimeSeries: [metricTimeSeries!]! (type)
        if (ec.Includes("metricTimeSeries",false))
        {
            if(this.MetricTimeSeries == null) {

                this.MetricTimeSeries = new List<MetricTimeSeries>();
                this.MetricTimeSeries.ApplyExploratoryFieldSpec(ec.NewChild("metricTimeSeries"));

            } else {

                this.MetricTimeSeries.ApplyExploratoryFieldSpec(ec.NewChild("metricTimeSeries"));

            }
        }
        else if (this.MetricTimeSeries != null && ec.Excludes("metricTimeSeries",false))
        {
            this.MetricTimeSeries = null;
        }
        //      C# -> List<ReplicationSource>? ReplicationSources
        // GraphQL -> replicationSources: [ReplicationSource!]! (type)
        if (ec.Includes("replicationSources",false))
        {
            if(this.ReplicationSources == null) {

                this.ReplicationSources = new List<ReplicationSource>();
                this.ReplicationSources.ApplyExploratoryFieldSpec(ec.NewChild("replicationSources"));

            } else {

                this.ReplicationSources.ApplyExploratoryFieldSpec(ec.NewChild("replicationSources"));

            }
        }
        else if (this.ReplicationSources != null && ec.Excludes("replicationSources",false))
        {
            this.ReplicationSources = null;
        }
        //      C# -> List<ReplicationTarget>? ReplicationTargets
        // GraphQL -> replicationTargets: [ReplicationTarget!]! (type)
        if (ec.Includes("replicationTargets",false))
        {
            if(this.ReplicationTargets == null) {

                this.ReplicationTargets = new List<ReplicationTarget>();
                this.ReplicationTargets.ApplyExploratoryFieldSpec(ec.NewChild("replicationTargets"));

            } else {

                this.ReplicationTargets.ApplyExploratoryFieldSpec(ec.NewChild("replicationTargets"));

            }
        }
        else if (this.ReplicationTargets != null && ec.Excludes("replicationTargets",false))
        {
            this.ReplicationTargets = null;
        }
        //      C# -> RubrikSyncStatus? RubrikSyncStatus
        // GraphQL -> rubrikSyncStatus: RubrikSyncStatus! (type)
        if (ec.Includes("rubrikSyncStatus",false))
        {
            if(this.RubrikSyncStatus == null) {

                this.RubrikSyncStatus = new RubrikSyncStatus();
                this.RubrikSyncStatus.ApplyExploratoryFieldSpec(ec.NewChild("rubrikSyncStatus"));

            } else {

                this.RubrikSyncStatus.ApplyExploratoryFieldSpec(ec.NewChild("rubrikSyncStatus"));

            }
        }
        else if (this.RubrikSyncStatus != null && ec.Excludes("rubrikSyncStatus",false))
        {
            this.RubrikSyncStatus = null;
        }
        //      C# -> SnappableConnection? SnappableConnection
        // GraphQL -> snappableConnection: SnappableConnection! (type)
        if (ec.Includes("snappableConnection",false))
        {
            if(this.SnappableConnection == null) {

                this.SnappableConnection = new SnappableConnection();
                this.SnappableConnection.ApplyExploratoryFieldSpec(ec.NewChild("snappableConnection"));

            } else {

                this.SnappableConnection.ApplyExploratoryFieldSpec(ec.NewChild("snappableConnection"));

            }
        }
        else if (this.SnappableConnection != null && ec.Excludes("snappableConnection",false))
        {
            this.SnappableConnection = null;
        }
        //      C# -> ClusterState? State
        // GraphQL -> state: clusterState! (type)
        if (ec.Includes("state",false))
        {
            if(this.State == null) {

                this.State = new ClusterState();
                this.State.ApplyExploratoryFieldSpec(ec.NewChild("state"));

            } else {

                this.State.ApplyExploratoryFieldSpec(ec.NewChild("state"));

            }
        }
        else if (this.State != null && ec.Excludes("state",false))
        {
            this.State = null;
        }
        //      C# -> List<ClusterNode>? SystemStatusAffectedNodes
        // GraphQL -> systemStatusAffectedNodes: [ClusterNode!] (type)
        if (ec.Includes("systemStatusAffectedNodes",false))
        {
            if(this.SystemStatusAffectedNodes == null) {

                this.SystemStatusAffectedNodes = new List<ClusterNode>();
                this.SystemStatusAffectedNodes.ApplyExploratoryFieldSpec(ec.NewChild("systemStatusAffectedNodes"));

            } else {

                this.SystemStatusAffectedNodes.ApplyExploratoryFieldSpec(ec.NewChild("systemStatusAffectedNodes"));

            }
        }
        else if (this.SystemStatusAffectedNodes != null && ec.Excludes("systemStatusAffectedNodes",false))
        {
            this.SystemStatusAffectedNodes = null;
        }
    }


    #endregion

    } // class Cluster
    
    #endregion

    public static class ListClusterExtensions
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
            this List<Cluster> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Cluster> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Cluster());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Cluster> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types