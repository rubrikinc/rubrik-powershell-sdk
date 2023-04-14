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

namespace Rubrik.SecurityCloud.Types
{
    #region Cluster
 
    public class Cluster: IFragment, TaskDetailGroupByInfo, AnomalyResultGroupByInfo, SnappableGroupByInfo, RansomwareResultGroupByInfo
    {
        #region members
        //      C# -> DateTime? ConnectivityLastUpdated
        // GraphQL -> connectivityLastUpdated: DateTime (scalar)
        [JsonProperty("connectivityLastUpdated")]
        public DateTime? ConnectivityLastUpdated { get; set; }

        //      C# -> System.String? DefaultAddress
        // GraphQL -> defaultAddress: String (scalar)
        [JsonProperty("defaultAddress")]
        public System.String? DefaultAddress { get; set; }

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

        #endregion

    #region methods

    public Cluster Set(
        DateTime? ConnectivityLastUpdated = null,
        System.String? DefaultAddress = null,
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
        List<ClusterNode>? SystemStatusAffectedNodes = null,
        List<Product>? LicensedProducts = null,
        ClusterPauseStatus? PauseStatus = null,
        ClusterProductEnum? ProductType = null,
        ClusterRegistrationMode? RegisteredMode = null,
        ClusterStatus? Status = null,
        ClusterSubStatus? SubStatus = null,
        ClusterSystemStatus? SystemStatus = null,
        ClusterTypeEnum? Type = null
    ) 
    {
        if ( ConnectivityLastUpdated != null ) {
            this.ConnectivityLastUpdated = ConnectivityLastUpdated;
        }
        if ( DefaultAddress != null ) {
            this.DefaultAddress = DefaultAddress;
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
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> DateTime? ConnectivityLastUpdated
            // GraphQL -> connectivityLastUpdated: DateTime (scalar)
            if (this.ConnectivityLastUpdated != null)
            {
                 s += ind + "connectivityLastUpdated\n";

            }
            //      C# -> System.String? DefaultAddress
            // GraphQL -> defaultAddress: String (scalar)
            if (this.DefaultAddress != null)
            {
                 s += ind + "defaultAddress\n";

            }
            //      C# -> System.Boolean? EncryptionEnabled
            // GraphQL -> encryptionEnabled: Boolean! (scalar)
            if (this.EncryptionEnabled != null)
            {
                 s += ind + "encryptionEnabled\n";

            }
            //      C# -> System.Int64? EstimatedRunway
            // GraphQL -> estimatedRunway: Long! (scalar)
            if (this.EstimatedRunway != null)
            {
                 s += ind + "estimatedRunway\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsHealthy
            // GraphQL -> isHealthy: Boolean! (scalar)
            if (this.IsHealthy != null)
            {
                 s += ind + "isHealthy\n";

            }
            //      C# -> DateTime? LastConnectionTime
            // GraphQL -> lastConnectionTime: DateTime (scalar)
            if (this.LastConnectionTime != null)
            {
                 s += ind + "lastConnectionTime\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.Int32? NoSqlWorkloadCount
            // GraphQL -> noSqlWorkloadCount: Int! (scalar)
            if (this.NoSqlWorkloadCount != null)
            {
                 s += ind + "noSqlWorkloadCount\n";

            }
            //      C# -> System.Boolean? PassesConnectivityCheck
            // GraphQL -> passesConnectivityCheck: Boolean (scalar)
            if (this.PassesConnectivityCheck != null)
            {
                 s += ind + "passesConnectivityCheck\n";

            }
            //      C# -> DateTime? RegistrationTime
            // GraphQL -> registrationTime: DateTime! (scalar)
            if (this.RegistrationTime != null)
            {
                 s += ind + "registrationTime\n";

            }
            //      C# -> System.Int64? SnapshotCount
            // GraphQL -> snapshotCount: Long! (scalar)
            if (this.SnapshotCount != null)
            {
                 s += ind + "snapshotCount\n";

            }
            //      C# -> System.String? SystemStatusMessage
            // GraphQL -> systemStatusMessage: String (scalar)
            if (this.SystemStatusMessage != null)
            {
                 s += ind + "systemStatusMessage\n";

            }
            //      C# -> System.String? Timezone
            // GraphQL -> timezone: String (scalar)
            if (this.Timezone != null)
            {
                 s += ind + "timezone\n";

            }
            //      C# -> System.String? Version
            // GraphQL -> version: String (scalar)
            if (this.Version != null)
            {
                 s += ind + "version\n";

            }
            //      C# -> ActivitySeriesConnection? ActivitySeriesConnection
            // GraphQL -> activitySeriesConnection: ActivitySeriesConnection! (type)
            if (this.ActivitySeriesConnection != null)
            {
                 s += ind + "activitySeriesConnection\n";

                 s += ind + "{\n" + 
                 this.ActivitySeriesConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<Org>? AllOrgs
            // GraphQL -> allOrgs: [Org!]! (type)
            if (this.AllOrgs != null)
            {
                 s += ind + "allOrgs\n";

                 s += ind + "{\n" + 
                 this.AllOrgs.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AuthorizedOperations? AuthorizedOperations
            // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
            if (this.AuthorizedOperations != null)
            {
                 s += ind + "authorizedOperations\n";

                 s += ind + "{\n" + 
                 this.AuthorizedOperations.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CcprovisionInfo? CcprovisionInfo
            // GraphQL -> ccprovisionInfo: CcprovisionInfo (type)
            if (this.CcprovisionInfo != null)
            {
                 s += ind + "ccprovisionInfo\n";

                 s += ind + "{\n" + 
                 this.CcprovisionInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<CdmNodeDetail>? CdmClusterNodeDetails
            // GraphQL -> cdmClusterNodeDetails: [CdmNodeDetail!]! (type)
            if (this.CdmClusterNodeDetails != null)
            {
                 s += ind + "cdmClusterNodeDetails\n";

                 s += ind + "{\n" + 
                 this.CdmClusterNodeDetails.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmUpgradeInfo? CdmUpgradeInfo
            // GraphQL -> cdmUpgradeInfo: CdmUpgradeInfo (type)
            if (this.CdmUpgradeInfo != null)
            {
                 s += ind + "cdmUpgradeInfo\n";

                 s += ind + "{\n" + 
                 this.CdmUpgradeInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CcWithCloudInfo? CloudInfo
            // GraphQL -> cloudInfo: CcWithCloudInfo (type)
            if (this.CloudInfo != null)
            {
                 s += ind + "cloudInfo\n";

                 s += ind + "{\n" + 
                 this.CloudInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ClusterDiskConnection? ClusterDiskConnection
            // GraphQL -> clusterDiskConnection: ClusterDiskConnection! (type)
            if (this.ClusterDiskConnection != null)
            {
                 s += ind + "clusterDiskConnection\n";

                 s += ind + "{\n" + 
                 this.ClusterDiskConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ClusterNodeConnection? ClusterNodeConnection
            // GraphQL -> clusterNodeConnection: ClusterNodeConnection! (type)
            if (this.ClusterNodeConnection != null)
            {
                 s += ind + "clusterNodeConnection\n";

                 s += ind + "{\n" + 
                 this.ClusterNodeConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ClusterNodeStats>? ClusterNodeStats
            // GraphQL -> clusterNodeStats: [ClusterNodeStats!]! (type)
            if (this.ClusterNodeStats != null)
            {
                 s += ind + "clusterNodeStats\n";

                 s += ind + "{\n" + 
                 this.ClusterNodeStats.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ConfigProtectionInfo? ConfigProtectionInfo
            // GraphQL -> configProtectionInfo: ConfigProtectionInfo (type)
            if (this.ConfigProtectionInfo != null)
            {
                 s += ind + "configProtectionInfo\n";

                 s += ind + "{\n" + 
                 this.ConfigProtectionInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AutoEnablePolicyClusterConfigReply? DatagovAutoEnablePolicyConfig
            // GraphQL -> datagovAutoEnablePolicyConfig: AutoEnablePolicyClusterConfigReply! (type)
            if (this.DatagovAutoEnablePolicyConfig != null)
            {
                 s += ind + "datagovAutoEnablePolicyConfig\n";

                 s += ind + "{\n" + 
                 this.DatagovAutoEnablePolicyConfig.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PreviewerClusterConfig? DatagovPreviewerConfig
            // GraphQL -> datagovPreviewerConfig: PreviewerClusterConfig! (type)
            if (this.DatagovPreviewerConfig != null)
            {
                 s += ind + "datagovPreviewerConfig\n";

                 s += ind + "{\n" + 
                 this.DatagovPreviewerConfig.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> GeoLocation? GeoLocation
            // GraphQL -> geoLocation: GeoLocation (type)
            if (this.GeoLocation != null)
            {
                 s += ind + "geoLocation\n";

                 s += ind + "{\n" + 
                 this.GeoLocation.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> GlobalManagerConnectivity? GlobalManagerConnectivityStatus
            // GraphQL -> globalManagerConnectivityStatus: GlobalManagerConnectivity (type)
            if (this.GlobalManagerConnectivityStatus != null)
            {
                 s += ind + "globalManagerConnectivityStatus\n";

                 s += ind + "{\n" + 
                 this.GlobalManagerConnectivityStatus.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> GetLambdaConfigReply? LambdaConfig
            // GraphQL -> lambdaConfig: GetLambdaConfigReply (type)
            if (this.LambdaConfig != null)
            {
                 s += ind + "lambdaConfig\n";

                 s += ind + "{\n" + 
                 this.LambdaConfig.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> LambdaFeatureHistory? LambdaFeatureHistory
            // GraphQL -> lambdaFeatureHistory: LambdaFeatureHistory (type)
            if (this.LambdaFeatureHistory != null)
            {
                 s += ind + "lambdaFeatureHistory\n";

                 s += ind + "{\n" + 
                 this.LambdaFeatureHistory.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> JobsReply? MetadataPullScheduler
            // GraphQL -> metadataPullScheduler: JobsReply (type)
            if (this.MetadataPullScheduler != null)
            {
                 s += ind + "metadataPullScheduler\n";

                 s += ind + "{\n" + 
                 this.MetadataPullScheduler.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ClusterMetric? Metric
            // GraphQL -> metric: ClusterMetric (type)
            if (this.Metric != null)
            {
                 s += ind + "metric\n";

                 s += ind + "{\n" + 
                 this.Metric.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<MetricTimeSeries>? MetricTimeSeries
            // GraphQL -> metricTimeSeries: [metricTimeSeries!]! (type)
            if (this.MetricTimeSeries != null)
            {
                 s += ind + "metricTimeSeries\n";

                 s += ind + "{\n" + 
                 this.MetricTimeSeries.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ReplicationSource>? ReplicationSources
            // GraphQL -> replicationSources: [ReplicationSource!]! (type)
            if (this.ReplicationSources != null)
            {
                 s += ind + "replicationSources\n";

                 s += ind + "{\n" + 
                 this.ReplicationSources.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ReplicationTarget>? ReplicationTargets
            // GraphQL -> replicationTargets: [ReplicationTarget!]! (type)
            if (this.ReplicationTargets != null)
            {
                 s += ind + "replicationTargets\n";

                 s += ind + "{\n" + 
                 this.ReplicationTargets.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> RubrikSyncStatus? RubrikSyncStatus
            // GraphQL -> rubrikSyncStatus: RubrikSyncStatus! (type)
            if (this.RubrikSyncStatus != null)
            {
                 s += ind + "rubrikSyncStatus\n";

                 s += ind + "{\n" + 
                 this.RubrikSyncStatus.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SnappableConnection? SnappableConnection
            // GraphQL -> snappableConnection: SnappableConnection! (type)
            if (this.SnappableConnection != null)
            {
                 s += ind + "snappableConnection\n";

                 s += ind + "{\n" + 
                 this.SnappableConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ClusterState? State
            // GraphQL -> state: clusterState! (type)
            if (this.State != null)
            {
                 s += ind + "state\n";

                 s += ind + "{\n" + 
                 this.State.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ClusterNode>? SystemStatusAffectedNodes
            // GraphQL -> systemStatusAffectedNodes: [ClusterNode!] (type)
            if (this.SystemStatusAffectedNodes != null)
            {
                 s += ind + "systemStatusAffectedNodes\n";

                 s += ind + "{\n" + 
                 this.SystemStatusAffectedNodes.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<Product>? LicensedProducts
            // GraphQL -> licensedProducts: [Product!]! (enum)
            if (this.LicensedProducts != null)
            {
                 s += ind + "licensedProducts\n";

            }
            //      C# -> ClusterPauseStatus? PauseStatus
            // GraphQL -> pauseStatus: ClusterPauseStatus (enum)
            if (this.PauseStatus != null)
            {
                 s += ind + "pauseStatus\n";

            }
            //      C# -> ClusterProductEnum? ProductType
            // GraphQL -> productType: ClusterProductEnum (enum)
            if (this.ProductType != null)
            {
                 s += ind + "productType\n";

            }
            //      C# -> ClusterRegistrationMode? RegisteredMode
            // GraphQL -> registeredMode: ClusterRegistrationMode (enum)
            if (this.RegisteredMode != null)
            {
                 s += ind + "registeredMode\n";

            }
            //      C# -> ClusterStatus? Status
            // GraphQL -> status: ClusterStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            //      C# -> ClusterSubStatus? SubStatus
            // GraphQL -> subStatus: ClusterSubStatus! (enum)
            if (this.SubStatus != null)
            {
                 s += ind + "subStatus\n";

            }
            //      C# -> ClusterSystemStatus? SystemStatus
            // GraphQL -> systemStatus: ClusterSystemStatus (enum)
            if (this.SystemStatus != null)
            {
                 s += ind + "systemStatus\n";

            }
            //      C# -> ClusterTypeEnum? Type
            // GraphQL -> type: ClusterTypeEnum! (enum)
            if (this.Type != null)
            {
                 s += ind + "type\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? ConnectivityLastUpdated
            // GraphQL -> connectivityLastUpdated: DateTime (scalar)
            if (this.ConnectivityLastUpdated == null && Exploration.Includes(parent + ".connectivityLastUpdated$"))
            {
                this.ConnectivityLastUpdated = new DateTime();
            }
            //      C# -> System.String? DefaultAddress
            // GraphQL -> defaultAddress: String (scalar)
            if (this.DefaultAddress == null && Exploration.Includes(parent + ".defaultAddress$"))
            {
                this.DefaultAddress = new System.String("FETCH");
            }
            //      C# -> System.Boolean? EncryptionEnabled
            // GraphQL -> encryptionEnabled: Boolean! (scalar)
            if (this.EncryptionEnabled == null && Exploration.Includes(parent + ".encryptionEnabled$"))
            {
                this.EncryptionEnabled = new System.Boolean();
            }
            //      C# -> System.Int64? EstimatedRunway
            // GraphQL -> estimatedRunway: Long! (scalar)
            if (this.EstimatedRunway == null && Exploration.Includes(parent + ".estimatedRunway$"))
            {
                this.EstimatedRunway = new System.Int64();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsHealthy
            // GraphQL -> isHealthy: Boolean! (scalar)
            if (this.IsHealthy == null && Exploration.Includes(parent + ".isHealthy$"))
            {
                this.IsHealthy = new System.Boolean();
            }
            //      C# -> DateTime? LastConnectionTime
            // GraphQL -> lastConnectionTime: DateTime (scalar)
            if (this.LastConnectionTime == null && Exploration.Includes(parent + ".lastConnectionTime$"))
            {
                this.LastConnectionTime = new DateTime();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.Int32? NoSqlWorkloadCount
            // GraphQL -> noSqlWorkloadCount: Int! (scalar)
            if (this.NoSqlWorkloadCount == null && Exploration.Includes(parent + ".noSqlWorkloadCount$"))
            {
                this.NoSqlWorkloadCount = new System.Int32();
            }
            //      C# -> System.Boolean? PassesConnectivityCheck
            // GraphQL -> passesConnectivityCheck: Boolean (scalar)
            if (this.PassesConnectivityCheck == null && Exploration.Includes(parent + ".passesConnectivityCheck$"))
            {
                this.PassesConnectivityCheck = new System.Boolean();
            }
            //      C# -> DateTime? RegistrationTime
            // GraphQL -> registrationTime: DateTime! (scalar)
            if (this.RegistrationTime == null && Exploration.Includes(parent + ".registrationTime$"))
            {
                this.RegistrationTime = new DateTime();
            }
            //      C# -> System.Int64? SnapshotCount
            // GraphQL -> snapshotCount: Long! (scalar)
            if (this.SnapshotCount == null && Exploration.Includes(parent + ".snapshotCount$"))
            {
                this.SnapshotCount = new System.Int64();
            }
            //      C# -> System.String? SystemStatusMessage
            // GraphQL -> systemStatusMessage: String (scalar)
            if (this.SystemStatusMessage == null && Exploration.Includes(parent + ".systemStatusMessage$"))
            {
                this.SystemStatusMessage = new System.String("FETCH");
            }
            //      C# -> System.String? Timezone
            // GraphQL -> timezone: String (scalar)
            if (this.Timezone == null && Exploration.Includes(parent + ".timezone$"))
            {
                this.Timezone = new System.String("FETCH");
            }
            //      C# -> System.String? Version
            // GraphQL -> version: String (scalar)
            if (this.Version == null && Exploration.Includes(parent + ".version$"))
            {
                this.Version = new System.String("FETCH");
            }
            //      C# -> ActivitySeriesConnection? ActivitySeriesConnection
            // GraphQL -> activitySeriesConnection: ActivitySeriesConnection! (type)
            if (this.ActivitySeriesConnection == null && Exploration.Includes(parent + ".activitySeriesConnection"))
            {
                this.ActivitySeriesConnection = new ActivitySeriesConnection();
                this.ActivitySeriesConnection.ApplyExploratoryFragment(parent + ".activitySeriesConnection");
            }
            //      C# -> List<Org>? AllOrgs
            // GraphQL -> allOrgs: [Org!]! (type)
            if (this.AllOrgs == null && Exploration.Includes(parent + ".allOrgs"))
            {
                this.AllOrgs = new List<Org>();
                this.AllOrgs.ApplyExploratoryFragment(parent + ".allOrgs");
            }
            //      C# -> AuthorizedOperations? AuthorizedOperations
            // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
            if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations"))
            {
                this.AuthorizedOperations = new AuthorizedOperations();
                this.AuthorizedOperations.ApplyExploratoryFragment(parent + ".authorizedOperations");
            }
            //      C# -> CcprovisionInfo? CcprovisionInfo
            // GraphQL -> ccprovisionInfo: CcprovisionInfo (type)
            if (this.CcprovisionInfo == null && Exploration.Includes(parent + ".ccprovisionInfo"))
            {
                this.CcprovisionInfo = new CcprovisionInfo();
                this.CcprovisionInfo.ApplyExploratoryFragment(parent + ".ccprovisionInfo");
            }
            //      C# -> List<CdmNodeDetail>? CdmClusterNodeDetails
            // GraphQL -> cdmClusterNodeDetails: [CdmNodeDetail!]! (type)
            if (this.CdmClusterNodeDetails == null && Exploration.Includes(parent + ".cdmClusterNodeDetails"))
            {
                this.CdmClusterNodeDetails = new List<CdmNodeDetail>();
                this.CdmClusterNodeDetails.ApplyExploratoryFragment(parent + ".cdmClusterNodeDetails");
            }
            //      C# -> CdmUpgradeInfo? CdmUpgradeInfo
            // GraphQL -> cdmUpgradeInfo: CdmUpgradeInfo (type)
            if (this.CdmUpgradeInfo == null && Exploration.Includes(parent + ".cdmUpgradeInfo"))
            {
                this.CdmUpgradeInfo = new CdmUpgradeInfo();
                this.CdmUpgradeInfo.ApplyExploratoryFragment(parent + ".cdmUpgradeInfo");
            }
            //      C# -> CcWithCloudInfo? CloudInfo
            // GraphQL -> cloudInfo: CcWithCloudInfo (type)
            if (this.CloudInfo == null && Exploration.Includes(parent + ".cloudInfo"))
            {
                this.CloudInfo = new CcWithCloudInfo();
                this.CloudInfo.ApplyExploratoryFragment(parent + ".cloudInfo");
            }
            //      C# -> ClusterDiskConnection? ClusterDiskConnection
            // GraphQL -> clusterDiskConnection: ClusterDiskConnection! (type)
            if (this.ClusterDiskConnection == null && Exploration.Includes(parent + ".clusterDiskConnection"))
            {
                this.ClusterDiskConnection = new ClusterDiskConnection();
                this.ClusterDiskConnection.ApplyExploratoryFragment(parent + ".clusterDiskConnection");
            }
            //      C# -> ClusterNodeConnection? ClusterNodeConnection
            // GraphQL -> clusterNodeConnection: ClusterNodeConnection! (type)
            if (this.ClusterNodeConnection == null && Exploration.Includes(parent + ".clusterNodeConnection"))
            {
                this.ClusterNodeConnection = new ClusterNodeConnection();
                this.ClusterNodeConnection.ApplyExploratoryFragment(parent + ".clusterNodeConnection");
            }
            //      C# -> List<ClusterNodeStats>? ClusterNodeStats
            // GraphQL -> clusterNodeStats: [ClusterNodeStats!]! (type)
            if (this.ClusterNodeStats == null && Exploration.Includes(parent + ".clusterNodeStats"))
            {
                this.ClusterNodeStats = new List<ClusterNodeStats>();
                this.ClusterNodeStats.ApplyExploratoryFragment(parent + ".clusterNodeStats");
            }
            //      C# -> ConfigProtectionInfo? ConfigProtectionInfo
            // GraphQL -> configProtectionInfo: ConfigProtectionInfo (type)
            if (this.ConfigProtectionInfo == null && Exploration.Includes(parent + ".configProtectionInfo"))
            {
                this.ConfigProtectionInfo = new ConfigProtectionInfo();
                this.ConfigProtectionInfo.ApplyExploratoryFragment(parent + ".configProtectionInfo");
            }
            //      C# -> AutoEnablePolicyClusterConfigReply? DatagovAutoEnablePolicyConfig
            // GraphQL -> datagovAutoEnablePolicyConfig: AutoEnablePolicyClusterConfigReply! (type)
            if (this.DatagovAutoEnablePolicyConfig == null && Exploration.Includes(parent + ".datagovAutoEnablePolicyConfig"))
            {
                this.DatagovAutoEnablePolicyConfig = new AutoEnablePolicyClusterConfigReply();
                this.DatagovAutoEnablePolicyConfig.ApplyExploratoryFragment(parent + ".datagovAutoEnablePolicyConfig");
            }
            //      C# -> PreviewerClusterConfig? DatagovPreviewerConfig
            // GraphQL -> datagovPreviewerConfig: PreviewerClusterConfig! (type)
            if (this.DatagovPreviewerConfig == null && Exploration.Includes(parent + ".datagovPreviewerConfig"))
            {
                this.DatagovPreviewerConfig = new PreviewerClusterConfig();
                this.DatagovPreviewerConfig.ApplyExploratoryFragment(parent + ".datagovPreviewerConfig");
            }
            //      C# -> GeoLocation? GeoLocation
            // GraphQL -> geoLocation: GeoLocation (type)
            if (this.GeoLocation == null && Exploration.Includes(parent + ".geoLocation"))
            {
                this.GeoLocation = new GeoLocation();
                this.GeoLocation.ApplyExploratoryFragment(parent + ".geoLocation");
            }
            //      C# -> GlobalManagerConnectivity? GlobalManagerConnectivityStatus
            // GraphQL -> globalManagerConnectivityStatus: GlobalManagerConnectivity (type)
            if (this.GlobalManagerConnectivityStatus == null && Exploration.Includes(parent + ".globalManagerConnectivityStatus"))
            {
                this.GlobalManagerConnectivityStatus = new GlobalManagerConnectivity();
                this.GlobalManagerConnectivityStatus.ApplyExploratoryFragment(parent + ".globalManagerConnectivityStatus");
            }
            //      C# -> GetLambdaConfigReply? LambdaConfig
            // GraphQL -> lambdaConfig: GetLambdaConfigReply (type)
            if (this.LambdaConfig == null && Exploration.Includes(parent + ".lambdaConfig"))
            {
                this.LambdaConfig = new GetLambdaConfigReply();
                this.LambdaConfig.ApplyExploratoryFragment(parent + ".lambdaConfig");
            }
            //      C# -> LambdaFeatureHistory? LambdaFeatureHistory
            // GraphQL -> lambdaFeatureHistory: LambdaFeatureHistory (type)
            if (this.LambdaFeatureHistory == null && Exploration.Includes(parent + ".lambdaFeatureHistory"))
            {
                this.LambdaFeatureHistory = new LambdaFeatureHistory();
                this.LambdaFeatureHistory.ApplyExploratoryFragment(parent + ".lambdaFeatureHistory");
            }
            //      C# -> JobsReply? MetadataPullScheduler
            // GraphQL -> metadataPullScheduler: JobsReply (type)
            if (this.MetadataPullScheduler == null && Exploration.Includes(parent + ".metadataPullScheduler"))
            {
                this.MetadataPullScheduler = new JobsReply();
                this.MetadataPullScheduler.ApplyExploratoryFragment(parent + ".metadataPullScheduler");
            }
            //      C# -> ClusterMetric? Metric
            // GraphQL -> metric: ClusterMetric (type)
            if (this.Metric == null && Exploration.Includes(parent + ".metric"))
            {
                this.Metric = new ClusterMetric();
                this.Metric.ApplyExploratoryFragment(parent + ".metric");
            }
            //      C# -> List<MetricTimeSeries>? MetricTimeSeries
            // GraphQL -> metricTimeSeries: [metricTimeSeries!]! (type)
            if (this.MetricTimeSeries == null && Exploration.Includes(parent + ".metricTimeSeries"))
            {
                this.MetricTimeSeries = new List<MetricTimeSeries>();
                this.MetricTimeSeries.ApplyExploratoryFragment(parent + ".metricTimeSeries");
            }
            //      C# -> List<ReplicationSource>? ReplicationSources
            // GraphQL -> replicationSources: [ReplicationSource!]! (type)
            if (this.ReplicationSources == null && Exploration.Includes(parent + ".replicationSources"))
            {
                this.ReplicationSources = new List<ReplicationSource>();
                this.ReplicationSources.ApplyExploratoryFragment(parent + ".replicationSources");
            }
            //      C# -> List<ReplicationTarget>? ReplicationTargets
            // GraphQL -> replicationTargets: [ReplicationTarget!]! (type)
            if (this.ReplicationTargets == null && Exploration.Includes(parent + ".replicationTargets"))
            {
                this.ReplicationTargets = new List<ReplicationTarget>();
                this.ReplicationTargets.ApplyExploratoryFragment(parent + ".replicationTargets");
            }
            //      C# -> RubrikSyncStatus? RubrikSyncStatus
            // GraphQL -> rubrikSyncStatus: RubrikSyncStatus! (type)
            if (this.RubrikSyncStatus == null && Exploration.Includes(parent + ".rubrikSyncStatus"))
            {
                this.RubrikSyncStatus = new RubrikSyncStatus();
                this.RubrikSyncStatus.ApplyExploratoryFragment(parent + ".rubrikSyncStatus");
            }
            //      C# -> SnappableConnection? SnappableConnection
            // GraphQL -> snappableConnection: SnappableConnection! (type)
            if (this.SnappableConnection == null && Exploration.Includes(parent + ".snappableConnection"))
            {
                this.SnappableConnection = new SnappableConnection();
                this.SnappableConnection.ApplyExploratoryFragment(parent + ".snappableConnection");
            }
            //      C# -> ClusterState? State
            // GraphQL -> state: clusterState! (type)
            if (this.State == null && Exploration.Includes(parent + ".state"))
            {
                this.State = new ClusterState();
                this.State.ApplyExploratoryFragment(parent + ".state");
            }
            //      C# -> List<ClusterNode>? SystemStatusAffectedNodes
            // GraphQL -> systemStatusAffectedNodes: [ClusterNode!] (type)
            if (this.SystemStatusAffectedNodes == null && Exploration.Includes(parent + ".systemStatusAffectedNodes"))
            {
                this.SystemStatusAffectedNodes = new List<ClusterNode>();
                this.SystemStatusAffectedNodes.ApplyExploratoryFragment(parent + ".systemStatusAffectedNodes");
            }
            //      C# -> List<Product>? LicensedProducts
            // GraphQL -> licensedProducts: [Product!]! (enum)
            if (this.LicensedProducts == null && Exploration.Includes(parent + ".licensedProducts$"))
            {
                this.LicensedProducts = new List<Product>();
            }
            //      C# -> ClusterPauseStatus? PauseStatus
            // GraphQL -> pauseStatus: ClusterPauseStatus (enum)
            if (this.PauseStatus == null && Exploration.Includes(parent + ".pauseStatus$"))
            {
                this.PauseStatus = new ClusterPauseStatus();
            }
            //      C# -> ClusterProductEnum? ProductType
            // GraphQL -> productType: ClusterProductEnum (enum)
            if (this.ProductType == null && Exploration.Includes(parent + ".productType$"))
            {
                this.ProductType = new ClusterProductEnum();
            }
            //      C# -> ClusterRegistrationMode? RegisteredMode
            // GraphQL -> registeredMode: ClusterRegistrationMode (enum)
            if (this.RegisteredMode == null && Exploration.Includes(parent + ".registeredMode$"))
            {
                this.RegisteredMode = new ClusterRegistrationMode();
            }
            //      C# -> ClusterStatus? Status
            // GraphQL -> status: ClusterStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new ClusterStatus();
            }
            //      C# -> ClusterSubStatus? SubStatus
            // GraphQL -> subStatus: ClusterSubStatus! (enum)
            if (this.SubStatus == null && Exploration.Includes(parent + ".subStatus$"))
            {
                this.SubStatus = new ClusterSubStatus();
            }
            //      C# -> ClusterSystemStatus? SystemStatus
            // GraphQL -> systemStatus: ClusterSystemStatus (enum)
            if (this.SystemStatus == null && Exploration.Includes(parent + ".systemStatus$"))
            {
                this.SystemStatus = new ClusterSystemStatus();
            }
            //      C# -> ClusterTypeEnum? Type
            // GraphQL -> type: ClusterTypeEnum! (enum)
            if (this.Type == null && Exploration.Includes(parent + ".type$"))
            {
                this.Type = new ClusterTypeEnum();
            }
        }


    #endregion

    } // class Cluster
    #endregion

    public static class ListClusterExtensions
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
            this List<Cluster> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Cluster> list, 
            String parent = "")
        {
            var item = new Cluster();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types