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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<Product>? LicensedProducts
        // GraphQL -> licensedProducts: [Product!]! (enum)
        if (this.LicensedProducts != null) {
            s += ind + "licensedProducts\n" ;
        }
        //      C# -> ClusterPauseStatus? PauseStatus
        // GraphQL -> pauseStatus: ClusterPauseStatus (enum)
        if (this.PauseStatus != null) {
            s += ind + "pauseStatus\n" ;
        }
        //      C# -> ClusterProductEnum? ProductType
        // GraphQL -> productType: ClusterProductEnum (enum)
        if (this.ProductType != null) {
            s += ind + "productType\n" ;
        }
        //      C# -> ClusterRegistrationMode? RegisteredMode
        // GraphQL -> registeredMode: ClusterRegistrationMode (enum)
        if (this.RegisteredMode != null) {
            s += ind + "registeredMode\n" ;
        }
        //      C# -> ClusterStatus? Status
        // GraphQL -> status: ClusterStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> ClusterSubStatus? SubStatus
        // GraphQL -> subStatus: ClusterSubStatus! (enum)
        if (this.SubStatus != null) {
            s += ind + "subStatus\n" ;
        }
        //      C# -> ClusterSystemStatus? SystemStatus
        // GraphQL -> systemStatus: ClusterSystemStatus (enum)
        if (this.SystemStatus != null) {
            s += ind + "systemStatus\n" ;
        }
        //      C# -> ClusterTypeEnum? Type
        // GraphQL -> type: ClusterTypeEnum! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> DateTime? ConnectivityLastUpdated
        // GraphQL -> connectivityLastUpdated: DateTime (scalar)
        if (this.ConnectivityLastUpdated != null) {
            s += ind + "connectivityLastUpdated\n" ;
        }
        //      C# -> System.String? DefaultAddress
        // GraphQL -> defaultAddress: String (scalar)
        if (this.DefaultAddress != null) {
            s += ind + "defaultAddress\n" ;
        }
        //      C# -> System.Int32? DefaultPort
        // GraphQL -> defaultPort: Int (scalar)
        if (this.DefaultPort != null) {
            s += ind + "defaultPort\n" ;
        }
        //      C# -> System.Boolean? EncryptionEnabled
        // GraphQL -> encryptionEnabled: Boolean! (scalar)
        if (this.EncryptionEnabled != null) {
            s += ind + "encryptionEnabled\n" ;
        }
        //      C# -> System.Int64? EstimatedRunway
        // GraphQL -> estimatedRunway: Long! (scalar)
        if (this.EstimatedRunway != null) {
            s += ind + "estimatedRunway\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsHealthy
        // GraphQL -> isHealthy: Boolean! (scalar)
        if (this.IsHealthy != null) {
            s += ind + "isHealthy\n" ;
        }
        //      C# -> DateTime? LastConnectionTime
        // GraphQL -> lastConnectionTime: DateTime (scalar)
        if (this.LastConnectionTime != null) {
            s += ind + "lastConnectionTime\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.Int32? NoSqlWorkloadCount
        // GraphQL -> noSqlWorkloadCount: Int! (scalar)
        if (this.NoSqlWorkloadCount != null) {
            s += ind + "noSqlWorkloadCount\n" ;
        }
        //      C# -> System.Boolean? PassesConnectivityCheck
        // GraphQL -> passesConnectivityCheck: Boolean (scalar)
        if (this.PassesConnectivityCheck != null) {
            s += ind + "passesConnectivityCheck\n" ;
        }
        //      C# -> DateTime? RegistrationTime
        // GraphQL -> registrationTime: DateTime! (scalar)
        if (this.RegistrationTime != null) {
            s += ind + "registrationTime\n" ;
        }
        //      C# -> System.Int64? SnapshotCount
        // GraphQL -> snapshotCount: Long! (scalar)
        if (this.SnapshotCount != null) {
            s += ind + "snapshotCount\n" ;
        }
        //      C# -> System.String? SystemStatusMessage
        // GraphQL -> systemStatusMessage: String (scalar)
        if (this.SystemStatusMessage != null) {
            s += ind + "systemStatusMessage\n" ;
        }
        //      C# -> System.String? Timezone
        // GraphQL -> timezone: String (scalar)
        if (this.Timezone != null) {
            s += ind + "timezone\n" ;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version != null) {
            s += ind + "version\n" ;
        }
        //      C# -> ActivitySeriesConnection? ActivitySeriesConnection
        // GraphQL -> activitySeriesConnection: ActivitySeriesConnection! (type)
        if (this.ActivitySeriesConnection != null) {
            var fspec = this.ActivitySeriesConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "activitySeriesConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            var fspec = this.AllOrgs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "allOrgs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        if (this.AuthorizedOperations != null) {
            var fspec = this.AuthorizedOperations.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "authorizedOperations {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CcprovisionInfo? CcprovisionInfo
        // GraphQL -> ccprovisionInfo: CcprovisionInfo (type)
        if (this.CcprovisionInfo != null) {
            var fspec = this.CcprovisionInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "ccprovisionInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<CdmNodeDetail>? CdmClusterNodeDetails
        // GraphQL -> cdmClusterNodeDetails: [CdmNodeDetail!]! (type)
        if (this.CdmClusterNodeDetails != null) {
            var fspec = this.CdmClusterNodeDetails.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cdmClusterNodeDetails {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> NotificationSettingSummaryListResponse? CdmNotificationSettings
        // GraphQL -> cdmNotificationSettings: NotificationSettingSummaryListResponse! (type)
        if (this.CdmNotificationSettings != null) {
            var fspec = this.CdmNotificationSettings.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cdmNotificationSettings {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmUpgradeInfo? CdmUpgradeInfo
        // GraphQL -> cdmUpgradeInfo: CdmUpgradeInfo (type)
        if (this.CdmUpgradeInfo != null) {
            var fspec = this.CdmUpgradeInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cdmUpgradeInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CcWithCloudInfo? CloudInfo
        // GraphQL -> cloudInfo: CcWithCloudInfo (type)
        if (this.CloudInfo != null) {
            var fspec = this.CloudInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cloudInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ClusterDiskConnection? ClusterDiskConnection
        // GraphQL -> clusterDiskConnection: ClusterDiskConnection! (type)
        if (this.ClusterDiskConnection != null) {
            var fspec = this.ClusterDiskConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "clusterDiskConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ClusterNodeConnection? ClusterNodeConnection
        // GraphQL -> clusterNodeConnection: ClusterNodeConnection! (type)
        if (this.ClusterNodeConnection != null) {
            var fspec = this.ClusterNodeConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "clusterNodeConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ClusterNodeStats>? ClusterNodeStats
        // GraphQL -> clusterNodeStats: [ClusterNodeStats!]! (type)
        if (this.ClusterNodeStats != null) {
            var fspec = this.ClusterNodeStats.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "clusterNodeStats {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ConfigProtectionInfo? ConfigProtectionInfo
        // GraphQL -> configProtectionInfo: ConfigProtectionInfo (type)
        if (this.ConfigProtectionInfo != null) {
            var fspec = this.ConfigProtectionInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "configProtectionInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AutoEnablePolicyClusterConfigReply? DatagovAutoEnablePolicyConfig
        // GraphQL -> datagovAutoEnablePolicyConfig: AutoEnablePolicyClusterConfigReply! (type)
        if (this.DatagovAutoEnablePolicyConfig != null) {
            var fspec = this.DatagovAutoEnablePolicyConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "datagovAutoEnablePolicyConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PreviewerClusterConfig? DatagovPreviewerConfig
        // GraphQL -> datagovPreviewerConfig: PreviewerClusterConfig! (type)
        if (this.DatagovPreviewerConfig != null) {
            var fspec = this.DatagovPreviewerConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "datagovPreviewerConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> GeoLocation? GeoLocation
        // GraphQL -> geoLocation: GeoLocation (type)
        if (this.GeoLocation != null) {
            var fspec = this.GeoLocation.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "geoLocation {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> GlobalManagerConnectivity? GlobalManagerConnectivityStatus
        // GraphQL -> globalManagerConnectivityStatus: GlobalManagerConnectivity (type)
        if (this.GlobalManagerConnectivityStatus != null) {
            var fspec = this.GlobalManagerConnectivityStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "globalManagerConnectivityStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> GetLambdaConfigReply? LambdaConfig
        // GraphQL -> lambdaConfig: GetLambdaConfigReply (type)
        if (this.LambdaConfig != null) {
            var fspec = this.LambdaConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "lambdaConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> LambdaFeatureHistory? LambdaFeatureHistory
        // GraphQL -> lambdaFeatureHistory: LambdaFeatureHistory (type)
        if (this.LambdaFeatureHistory != null) {
            var fspec = this.LambdaFeatureHistory.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "lambdaFeatureHistory {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> JobsReply? MetadataPullScheduler
        // GraphQL -> metadataPullScheduler: JobsReply (type)
        if (this.MetadataPullScheduler != null) {
            var fspec = this.MetadataPullScheduler.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "metadataPullScheduler {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ClusterMetric? Metric
        // GraphQL -> metric: ClusterMetric (type)
        if (this.Metric != null) {
            var fspec = this.Metric.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "metric {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<MetricTimeSeries>? MetricTimeSeries
        // GraphQL -> metricTimeSeries: [metricTimeSeries!]! (type)
        if (this.MetricTimeSeries != null) {
            var fspec = this.MetricTimeSeries.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "metricTimeSeries {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ReplicationSource>? ReplicationSources
        // GraphQL -> replicationSources: [ReplicationSource!]! (type)
        if (this.ReplicationSources != null) {
            var fspec = this.ReplicationSources.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "replicationSources {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ReplicationTarget>? ReplicationTargets
        // GraphQL -> replicationTargets: [ReplicationTarget!]! (type)
        if (this.ReplicationTargets != null) {
            var fspec = this.ReplicationTargets.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "replicationTargets {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> RubrikSyncStatus? RubrikSyncStatus
        // GraphQL -> rubrikSyncStatus: RubrikSyncStatus! (type)
        if (this.RubrikSyncStatus != null) {
            var fspec = this.RubrikSyncStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "rubrikSyncStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SnappableConnection? SnappableConnection
        // GraphQL -> snappableConnection: SnappableConnection! (type)
        if (this.SnappableConnection != null) {
            var fspec = this.SnappableConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snappableConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ClusterState? State
        // GraphQL -> state: clusterState! (type)
        if (this.State != null) {
            var fspec = this.State.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "state {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ClusterNode>? SystemStatusAffectedNodes
        // GraphQL -> systemStatusAffectedNodes: [ClusterNode!] (type)
        if (this.SystemStatusAffectedNodes != null) {
            var fspec = this.SystemStatusAffectedNodes.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "systemStatusAffectedNodes {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<Product>? LicensedProducts
        // GraphQL -> licensedProducts: [Product!]! (enum)
        if (this.LicensedProducts == null && ec.Includes("licensedProducts",true))
        {
            this.LicensedProducts = new List<Product>();
        }
        //      C# -> ClusterPauseStatus? PauseStatus
        // GraphQL -> pauseStatus: ClusterPauseStatus (enum)
        if (this.PauseStatus == null && ec.Includes("pauseStatus",true))
        {
            this.PauseStatus = new ClusterPauseStatus();
        }
        //      C# -> ClusterProductEnum? ProductType
        // GraphQL -> productType: ClusterProductEnum (enum)
        if (this.ProductType == null && ec.Includes("productType",true))
        {
            this.ProductType = new ClusterProductEnum();
        }
        //      C# -> ClusterRegistrationMode? RegisteredMode
        // GraphQL -> registeredMode: ClusterRegistrationMode (enum)
        if (this.RegisteredMode == null && ec.Includes("registeredMode",true))
        {
            this.RegisteredMode = new ClusterRegistrationMode();
        }
        //      C# -> ClusterStatus? Status
        // GraphQL -> status: ClusterStatus! (enum)
        if (this.Status == null && ec.Includes("status",true))
        {
            this.Status = new ClusterStatus();
        }
        //      C# -> ClusterSubStatus? SubStatus
        // GraphQL -> subStatus: ClusterSubStatus! (enum)
        if (this.SubStatus == null && ec.Includes("subStatus",true))
        {
            this.SubStatus = new ClusterSubStatus();
        }
        //      C# -> ClusterSystemStatus? SystemStatus
        // GraphQL -> systemStatus: ClusterSystemStatus (enum)
        if (this.SystemStatus == null && ec.Includes("systemStatus",true))
        {
            this.SystemStatus = new ClusterSystemStatus();
        }
        //      C# -> ClusterTypeEnum? Type
        // GraphQL -> type: ClusterTypeEnum! (enum)
        if (this.Type == null && ec.Includes("type",true))
        {
            this.Type = new ClusterTypeEnum();
        }
        //      C# -> DateTime? ConnectivityLastUpdated
        // GraphQL -> connectivityLastUpdated: DateTime (scalar)
        if (this.ConnectivityLastUpdated == null && ec.Includes("connectivityLastUpdated",true))
        {
            this.ConnectivityLastUpdated = new DateTime();
        }
        //      C# -> System.String? DefaultAddress
        // GraphQL -> defaultAddress: String (scalar)
        if (this.DefaultAddress == null && ec.Includes("defaultAddress",true))
        {
            this.DefaultAddress = "FETCH";
        }
        //      C# -> System.Int32? DefaultPort
        // GraphQL -> defaultPort: Int (scalar)
        if (this.DefaultPort == null && ec.Includes("defaultPort",true))
        {
            this.DefaultPort = Int32.MinValue;
        }
        //      C# -> System.Boolean? EncryptionEnabled
        // GraphQL -> encryptionEnabled: Boolean! (scalar)
        if (this.EncryptionEnabled == null && ec.Includes("encryptionEnabled",true))
        {
            this.EncryptionEnabled = true;
        }
        //      C# -> System.Int64? EstimatedRunway
        // GraphQL -> estimatedRunway: Long! (scalar)
        if (this.EstimatedRunway == null && ec.Includes("estimatedRunway",true))
        {
            this.EstimatedRunway = new System.Int64();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsHealthy
        // GraphQL -> isHealthy: Boolean! (scalar)
        if (this.IsHealthy == null && ec.Includes("isHealthy",true))
        {
            this.IsHealthy = true;
        }
        //      C# -> DateTime? LastConnectionTime
        // GraphQL -> lastConnectionTime: DateTime (scalar)
        if (this.LastConnectionTime == null && ec.Includes("lastConnectionTime",true))
        {
            this.LastConnectionTime = new DateTime();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.Int32? NoSqlWorkloadCount
        // GraphQL -> noSqlWorkloadCount: Int! (scalar)
        if (this.NoSqlWorkloadCount == null && ec.Includes("noSqlWorkloadCount",true))
        {
            this.NoSqlWorkloadCount = Int32.MinValue;
        }
        //      C# -> System.Boolean? PassesConnectivityCheck
        // GraphQL -> passesConnectivityCheck: Boolean (scalar)
        if (this.PassesConnectivityCheck == null && ec.Includes("passesConnectivityCheck",true))
        {
            this.PassesConnectivityCheck = true;
        }
        //      C# -> DateTime? RegistrationTime
        // GraphQL -> registrationTime: DateTime! (scalar)
        if (this.RegistrationTime == null && ec.Includes("registrationTime",true))
        {
            this.RegistrationTime = new DateTime();
        }
        //      C# -> System.Int64? SnapshotCount
        // GraphQL -> snapshotCount: Long! (scalar)
        if (this.SnapshotCount == null && ec.Includes("snapshotCount",true))
        {
            this.SnapshotCount = new System.Int64();
        }
        //      C# -> System.String? SystemStatusMessage
        // GraphQL -> systemStatusMessage: String (scalar)
        if (this.SystemStatusMessage == null && ec.Includes("systemStatusMessage",true))
        {
            this.SystemStatusMessage = "FETCH";
        }
        //      C# -> System.String? Timezone
        // GraphQL -> timezone: String (scalar)
        if (this.Timezone == null && ec.Includes("timezone",true))
        {
            this.Timezone = "FETCH";
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version == null && ec.Includes("version",true))
        {
            this.Version = "FETCH";
        }
        //      C# -> ActivitySeriesConnection? ActivitySeriesConnection
        // GraphQL -> activitySeriesConnection: ActivitySeriesConnection! (type)
        if (this.ActivitySeriesConnection == null && ec.Includes("activitySeriesConnection",false))
        {
            this.ActivitySeriesConnection = new ActivitySeriesConnection();
            this.ActivitySeriesConnection.ApplyExploratoryFieldSpec(ec.NewChild("activitySeriesConnection"));
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs == null && ec.Includes("allOrgs",false))
        {
            this.AllOrgs = new List<Org>();
            this.AllOrgs.ApplyExploratoryFieldSpec(ec.NewChild("allOrgs"));
        }
        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        if (this.AuthorizedOperations == null && ec.Includes("authorizedOperations",false))
        {
            this.AuthorizedOperations = new AuthorizedOperations();
            this.AuthorizedOperations.ApplyExploratoryFieldSpec(ec.NewChild("authorizedOperations"));
        }
        //      C# -> CcprovisionInfo? CcprovisionInfo
        // GraphQL -> ccprovisionInfo: CcprovisionInfo (type)
        if (this.CcprovisionInfo == null && ec.Includes("ccprovisionInfo",false))
        {
            this.CcprovisionInfo = new CcprovisionInfo();
            this.CcprovisionInfo.ApplyExploratoryFieldSpec(ec.NewChild("ccprovisionInfo"));
        }
        //      C# -> List<CdmNodeDetail>? CdmClusterNodeDetails
        // GraphQL -> cdmClusterNodeDetails: [CdmNodeDetail!]! (type)
        if (this.CdmClusterNodeDetails == null && ec.Includes("cdmClusterNodeDetails",false))
        {
            this.CdmClusterNodeDetails = new List<CdmNodeDetail>();
            this.CdmClusterNodeDetails.ApplyExploratoryFieldSpec(ec.NewChild("cdmClusterNodeDetails"));
        }
        //      C# -> NotificationSettingSummaryListResponse? CdmNotificationSettings
        // GraphQL -> cdmNotificationSettings: NotificationSettingSummaryListResponse! (type)
        if (this.CdmNotificationSettings == null && ec.Includes("cdmNotificationSettings",false))
        {
            this.CdmNotificationSettings = new NotificationSettingSummaryListResponse();
            this.CdmNotificationSettings.ApplyExploratoryFieldSpec(ec.NewChild("cdmNotificationSettings"));
        }
        //      C# -> CdmUpgradeInfo? CdmUpgradeInfo
        // GraphQL -> cdmUpgradeInfo: CdmUpgradeInfo (type)
        if (this.CdmUpgradeInfo == null && ec.Includes("cdmUpgradeInfo",false))
        {
            this.CdmUpgradeInfo = new CdmUpgradeInfo();
            this.CdmUpgradeInfo.ApplyExploratoryFieldSpec(ec.NewChild("cdmUpgradeInfo"));
        }
        //      C# -> CcWithCloudInfo? CloudInfo
        // GraphQL -> cloudInfo: CcWithCloudInfo (type)
        if (this.CloudInfo == null && ec.Includes("cloudInfo",false))
        {
            this.CloudInfo = new CcWithCloudInfo();
            this.CloudInfo.ApplyExploratoryFieldSpec(ec.NewChild("cloudInfo"));
        }
        //      C# -> ClusterDiskConnection? ClusterDiskConnection
        // GraphQL -> clusterDiskConnection: ClusterDiskConnection! (type)
        if (this.ClusterDiskConnection == null && ec.Includes("clusterDiskConnection",false))
        {
            this.ClusterDiskConnection = new ClusterDiskConnection();
            this.ClusterDiskConnection.ApplyExploratoryFieldSpec(ec.NewChild("clusterDiskConnection"));
        }
        //      C# -> ClusterNodeConnection? ClusterNodeConnection
        // GraphQL -> clusterNodeConnection: ClusterNodeConnection! (type)
        if (this.ClusterNodeConnection == null && ec.Includes("clusterNodeConnection",false))
        {
            this.ClusterNodeConnection = new ClusterNodeConnection();
            this.ClusterNodeConnection.ApplyExploratoryFieldSpec(ec.NewChild("clusterNodeConnection"));
        }
        //      C# -> List<ClusterNodeStats>? ClusterNodeStats
        // GraphQL -> clusterNodeStats: [ClusterNodeStats!]! (type)
        if (this.ClusterNodeStats == null && ec.Includes("clusterNodeStats",false))
        {
            this.ClusterNodeStats = new List<ClusterNodeStats>();
            this.ClusterNodeStats.ApplyExploratoryFieldSpec(ec.NewChild("clusterNodeStats"));
        }
        //      C# -> ConfigProtectionInfo? ConfigProtectionInfo
        // GraphQL -> configProtectionInfo: ConfigProtectionInfo (type)
        if (this.ConfigProtectionInfo == null && ec.Includes("configProtectionInfo",false))
        {
            this.ConfigProtectionInfo = new ConfigProtectionInfo();
            this.ConfigProtectionInfo.ApplyExploratoryFieldSpec(ec.NewChild("configProtectionInfo"));
        }
        //      C# -> AutoEnablePolicyClusterConfigReply? DatagovAutoEnablePolicyConfig
        // GraphQL -> datagovAutoEnablePolicyConfig: AutoEnablePolicyClusterConfigReply! (type)
        if (this.DatagovAutoEnablePolicyConfig == null && ec.Includes("datagovAutoEnablePolicyConfig",false))
        {
            this.DatagovAutoEnablePolicyConfig = new AutoEnablePolicyClusterConfigReply();
            this.DatagovAutoEnablePolicyConfig.ApplyExploratoryFieldSpec(ec.NewChild("datagovAutoEnablePolicyConfig"));
        }
        //      C# -> PreviewerClusterConfig? DatagovPreviewerConfig
        // GraphQL -> datagovPreviewerConfig: PreviewerClusterConfig! (type)
        if (this.DatagovPreviewerConfig == null && ec.Includes("datagovPreviewerConfig",false))
        {
            this.DatagovPreviewerConfig = new PreviewerClusterConfig();
            this.DatagovPreviewerConfig.ApplyExploratoryFieldSpec(ec.NewChild("datagovPreviewerConfig"));
        }
        //      C# -> GeoLocation? GeoLocation
        // GraphQL -> geoLocation: GeoLocation (type)
        if (this.GeoLocation == null && ec.Includes("geoLocation",false))
        {
            this.GeoLocation = new GeoLocation();
            this.GeoLocation.ApplyExploratoryFieldSpec(ec.NewChild("geoLocation"));
        }
        //      C# -> GlobalManagerConnectivity? GlobalManagerConnectivityStatus
        // GraphQL -> globalManagerConnectivityStatus: GlobalManagerConnectivity (type)
        if (this.GlobalManagerConnectivityStatus == null && ec.Includes("globalManagerConnectivityStatus",false))
        {
            this.GlobalManagerConnectivityStatus = new GlobalManagerConnectivity();
            this.GlobalManagerConnectivityStatus.ApplyExploratoryFieldSpec(ec.NewChild("globalManagerConnectivityStatus"));
        }
        //      C# -> GetLambdaConfigReply? LambdaConfig
        // GraphQL -> lambdaConfig: GetLambdaConfigReply (type)
        if (this.LambdaConfig == null && ec.Includes("lambdaConfig",false))
        {
            this.LambdaConfig = new GetLambdaConfigReply();
            this.LambdaConfig.ApplyExploratoryFieldSpec(ec.NewChild("lambdaConfig"));
        }
        //      C# -> LambdaFeatureHistory? LambdaFeatureHistory
        // GraphQL -> lambdaFeatureHistory: LambdaFeatureHistory (type)
        if (this.LambdaFeatureHistory == null && ec.Includes("lambdaFeatureHistory",false))
        {
            this.LambdaFeatureHistory = new LambdaFeatureHistory();
            this.LambdaFeatureHistory.ApplyExploratoryFieldSpec(ec.NewChild("lambdaFeatureHistory"));
        }
        //      C# -> JobsReply? MetadataPullScheduler
        // GraphQL -> metadataPullScheduler: JobsReply (type)
        if (this.MetadataPullScheduler == null && ec.Includes("metadataPullScheduler",false))
        {
            this.MetadataPullScheduler = new JobsReply();
            this.MetadataPullScheduler.ApplyExploratoryFieldSpec(ec.NewChild("metadataPullScheduler"));
        }
        //      C# -> ClusterMetric? Metric
        // GraphQL -> metric: ClusterMetric (type)
        if (this.Metric == null && ec.Includes("metric",false))
        {
            this.Metric = new ClusterMetric();
            this.Metric.ApplyExploratoryFieldSpec(ec.NewChild("metric"));
        }
        //      C# -> List<MetricTimeSeries>? MetricTimeSeries
        // GraphQL -> metricTimeSeries: [metricTimeSeries!]! (type)
        if (this.MetricTimeSeries == null && ec.Includes("metricTimeSeries",false))
        {
            this.MetricTimeSeries = new List<MetricTimeSeries>();
            this.MetricTimeSeries.ApplyExploratoryFieldSpec(ec.NewChild("metricTimeSeries"));
        }
        //      C# -> List<ReplicationSource>? ReplicationSources
        // GraphQL -> replicationSources: [ReplicationSource!]! (type)
        if (this.ReplicationSources == null && ec.Includes("replicationSources",false))
        {
            this.ReplicationSources = new List<ReplicationSource>();
            this.ReplicationSources.ApplyExploratoryFieldSpec(ec.NewChild("replicationSources"));
        }
        //      C# -> List<ReplicationTarget>? ReplicationTargets
        // GraphQL -> replicationTargets: [ReplicationTarget!]! (type)
        if (this.ReplicationTargets == null && ec.Includes("replicationTargets",false))
        {
            this.ReplicationTargets = new List<ReplicationTarget>();
            this.ReplicationTargets.ApplyExploratoryFieldSpec(ec.NewChild("replicationTargets"));
        }
        //      C# -> RubrikSyncStatus? RubrikSyncStatus
        // GraphQL -> rubrikSyncStatus: RubrikSyncStatus! (type)
        if (this.RubrikSyncStatus == null && ec.Includes("rubrikSyncStatus",false))
        {
            this.RubrikSyncStatus = new RubrikSyncStatus();
            this.RubrikSyncStatus.ApplyExploratoryFieldSpec(ec.NewChild("rubrikSyncStatus"));
        }
        //      C# -> SnappableConnection? SnappableConnection
        // GraphQL -> snappableConnection: SnappableConnection! (type)
        if (this.SnappableConnection == null && ec.Includes("snappableConnection",false))
        {
            this.SnappableConnection = new SnappableConnection();
            this.SnappableConnection.ApplyExploratoryFieldSpec(ec.NewChild("snappableConnection"));
        }
        //      C# -> ClusterState? State
        // GraphQL -> state: clusterState! (type)
        if (this.State == null && ec.Includes("state",false))
        {
            this.State = new ClusterState();
            this.State.ApplyExploratoryFieldSpec(ec.NewChild("state"));
        }
        //      C# -> List<ClusterNode>? SystemStatusAffectedNodes
        // GraphQL -> systemStatusAffectedNodes: [ClusterNode!] (type)
        if (this.SystemStatusAffectedNodes == null && ec.Includes("systemStatusAffectedNodes",false))
        {
            this.SystemStatusAffectedNodes = new List<ClusterNode>();
            this.SystemStatusAffectedNodes.ApplyExploratoryFieldSpec(ec.NewChild("systemStatusAffectedNodes"));
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<Cluster> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types