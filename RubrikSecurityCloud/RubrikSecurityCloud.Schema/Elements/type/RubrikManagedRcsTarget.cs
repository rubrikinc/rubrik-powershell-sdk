// RubrikManagedRcsTarget.cs
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
    #region RubrikManagedRcsTarget
 
    public class RubrikManagedRcsTarget: BaseType, Target
    {
        #region members

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

        //      C# -> System.Int64? ImmutabilityPeriodDays
        // GraphQL -> immutabilityPeriodDays: Long! (scalar)
        [JsonProperty("immutabilityPeriodDays")]
        public System.Int64? ImmutabilityPeriodDays { get; set; }

        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        [JsonProperty("isActive")]
        public System.Boolean? IsActive { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.Boolean? IsBlobImmutabilityEnabled
        // GraphQL -> isBlobImmutabilityEnabled: Boolean! (scalar)
        [JsonProperty("isBlobImmutabilityEnabled")]
        public System.Boolean? IsBlobImmutabilityEnabled { get; set; }

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

        //      C# -> System.Int32? SpaceUsageAlertThreshold
        // GraphQL -> spaceUsageAlertThreshold: Int! (scalar)
        [JsonProperty("spaceUsageAlertThreshold")]
        public System.Int32? SpaceUsageAlertThreshold { get; set; }

        //      C# -> System.Single? StorageConsumptionValue
        // GraphQL -> storageConsumptionValue: Float! (scalar)
        [JsonProperty("storageConsumptionValue")]
        public System.Single? StorageConsumptionValue { get; set; }

        //      C# -> System.String? SyncFailureReason
        // GraphQL -> syncFailureReason: String! (scalar)
        [JsonProperty("syncFailureReason")]
        public System.String? SyncFailureReason { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> ClusterIpMapping? ClusterIpMapping
        // GraphQL -> clusterIpMapping: ClusterIpMapping (type)
        [JsonProperty("clusterIpMapping")]
        public ClusterIpMapping? ClusterIpMapping { get; set; }

        //      C# -> PrivateEndpointConnection? PrivateEndpointConnection
        // GraphQL -> privateEndpointConnection: PrivateEndpointConnection (type)
        [JsonProperty("privateEndpointConnection")]
        public PrivateEndpointConnection? PrivateEndpointConnection { get; set; }

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
        return "RubrikManagedRcsTarget";
    }

    public RubrikManagedRcsTarget Set(
        ConnectionStatusType? LocationConnectionStatus = null,
        LocationScope? LocationScope = null,
        ReaderRetrievalMethod? ReaderRetrievalMethod = null,
        RcsRegionEnumType? Region = null,
        ArchivalLocationStatus? Status = null,
        TargetSyncStatus? SyncStatus = null,
        TargetType? TargetType = null,
        RcsTierEnumType? Tier = null,
        UpgradeStatus? UpgradeStatus = null,
        System.String? ClusterName = null,
        System.Int64? ConsumedBytes = null,
        System.Int32? FailedTasks = null,
        System.String? Id = null,
        System.Int64? ImmutabilityPeriodDays = null,
        System.Boolean? IsActive = null,
        System.Boolean? IsArchived = null,
        System.Boolean? IsBlobImmutabilityEnabled = null,
        System.String? Name = null,
        System.Int32? RunningTasks = null,
        System.Boolean? ShouldBypassProxy = null,
        System.Int32? SpaceUsageAlertThreshold = null,
        System.Single? StorageConsumptionValue = null,
        System.String? SyncFailureReason = null,
        Cluster? Cluster = null,
        ClusterIpMapping? ClusterIpMapping = null,
        PrivateEndpointConnection? PrivateEndpointConnection = null,
        TargetMappingBasic? TargetMapping = null,
        List<TargetMappingBasic>? TargetMappingBasic = null
    ) 
    {
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
        if ( ImmutabilityPeriodDays != null ) {
            this.ImmutabilityPeriodDays = ImmutabilityPeriodDays;
        }
        if ( IsActive != null ) {
            this.IsActive = IsActive;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( IsBlobImmutabilityEnabled != null ) {
            this.IsBlobImmutabilityEnabled = IsBlobImmutabilityEnabled;
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
        if ( SpaceUsageAlertThreshold != null ) {
            this.SpaceUsageAlertThreshold = SpaceUsageAlertThreshold;
        }
        if ( StorageConsumptionValue != null ) {
            this.StorageConsumptionValue = StorageConsumptionValue;
        }
        if ( SyncFailureReason != null ) {
            this.SyncFailureReason = SyncFailureReason;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( ClusterIpMapping != null ) {
            this.ClusterIpMapping = ClusterIpMapping;
        }
        if ( PrivateEndpointConnection != null ) {
            this.PrivateEndpointConnection = PrivateEndpointConnection;
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
        //      C# -> RcsRegionEnumType? Region
        // GraphQL -> region: RcsRegionEnumType! (enum)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> ArchivalLocationStatus? Status
        // GraphQL -> status: ArchivalLocationStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
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
        //      C# -> RcsTierEnumType? Tier
        // GraphQL -> tier: RcsTierEnumType! (enum)
        if (this.Tier != null) {
            s += ind + "tier\n" ;
        }
        //      C# -> UpgradeStatus? UpgradeStatus
        // GraphQL -> upgradeStatus: UpgradeStatus! (enum)
        if (this.UpgradeStatus != null) {
            s += ind + "upgradeStatus\n" ;
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
        //      C# -> System.Int64? ImmutabilityPeriodDays
        // GraphQL -> immutabilityPeriodDays: Long! (scalar)
        if (this.ImmutabilityPeriodDays != null) {
            s += ind + "immutabilityPeriodDays\n" ;
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
        //      C# -> System.Boolean? IsBlobImmutabilityEnabled
        // GraphQL -> isBlobImmutabilityEnabled: Boolean! (scalar)
        if (this.IsBlobImmutabilityEnabled != null) {
            s += ind + "isBlobImmutabilityEnabled\n" ;
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
        //      C# -> System.Boolean? ShouldBypassProxy
        // GraphQL -> shouldBypassProxy: Boolean! (scalar)
        if (this.ShouldBypassProxy != null) {
            s += ind + "shouldBypassProxy\n" ;
        }
        //      C# -> System.Int32? SpaceUsageAlertThreshold
        // GraphQL -> spaceUsageAlertThreshold: Int! (scalar)
        if (this.SpaceUsageAlertThreshold != null) {
            s += ind + "spaceUsageAlertThreshold\n" ;
        }
        //      C# -> System.Single? StorageConsumptionValue
        // GraphQL -> storageConsumptionValue: Float! (scalar)
        if (this.StorageConsumptionValue != null) {
            s += ind + "storageConsumptionValue\n" ;
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
        //      C# -> ClusterIpMapping? ClusterIpMapping
        // GraphQL -> clusterIpMapping: ClusterIpMapping (type)
        if (this.ClusterIpMapping != null) {
            var fspec = this.ClusterIpMapping.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "clusterIpMapping {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PrivateEndpointConnection? PrivateEndpointConnection
        // GraphQL -> privateEndpointConnection: PrivateEndpointConnection (type)
        if (this.PrivateEndpointConnection != null) {
            var fspec = this.PrivateEndpointConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "privateEndpointConnection {\n" + fspec + ind + "}\n" ;
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
        //      C# -> RcsRegionEnumType? Region
        // GraphQL -> region: RcsRegionEnumType! (enum)
        if (this.Region == null && Exploration.Includes(parent + ".region", true))
        {
            this.Region = new RcsRegionEnumType();
        }
        //      C# -> ArchivalLocationStatus? Status
        // GraphQL -> status: ArchivalLocationStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new ArchivalLocationStatus();
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
        //      C# -> RcsTierEnumType? Tier
        // GraphQL -> tier: RcsTierEnumType! (enum)
        if (this.Tier == null && Exploration.Includes(parent + ".tier", true))
        {
            this.Tier = new RcsTierEnumType();
        }
        //      C# -> UpgradeStatus? UpgradeStatus
        // GraphQL -> upgradeStatus: UpgradeStatus! (enum)
        if (this.UpgradeStatus == null && Exploration.Includes(parent + ".upgradeStatus", true))
        {
            this.UpgradeStatus = new UpgradeStatus();
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
        //      C# -> System.Int64? ImmutabilityPeriodDays
        // GraphQL -> immutabilityPeriodDays: Long! (scalar)
        if (this.ImmutabilityPeriodDays == null && Exploration.Includes(parent + ".immutabilityPeriodDays", true))
        {
            this.ImmutabilityPeriodDays = new System.Int64();
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
        //      C# -> System.Boolean? IsBlobImmutabilityEnabled
        // GraphQL -> isBlobImmutabilityEnabled: Boolean! (scalar)
        if (this.IsBlobImmutabilityEnabled == null && Exploration.Includes(parent + ".isBlobImmutabilityEnabled", true))
        {
            this.IsBlobImmutabilityEnabled = true;
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
        //      C# -> System.Boolean? ShouldBypassProxy
        // GraphQL -> shouldBypassProxy: Boolean! (scalar)
        if (this.ShouldBypassProxy == null && Exploration.Includes(parent + ".shouldBypassProxy", true))
        {
            this.ShouldBypassProxy = true;
        }
        //      C# -> System.Int32? SpaceUsageAlertThreshold
        // GraphQL -> spaceUsageAlertThreshold: Int! (scalar)
        if (this.SpaceUsageAlertThreshold == null && Exploration.Includes(parent + ".spaceUsageAlertThreshold", true))
        {
            this.SpaceUsageAlertThreshold = Int32.MinValue;
        }
        //      C# -> System.Single? StorageConsumptionValue
        // GraphQL -> storageConsumptionValue: Float! (scalar)
        if (this.StorageConsumptionValue == null && Exploration.Includes(parent + ".storageConsumptionValue", true))
        {
            this.StorageConsumptionValue = new System.Single();
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
        //      C# -> ClusterIpMapping? ClusterIpMapping
        // GraphQL -> clusterIpMapping: ClusterIpMapping (type)
        if (this.ClusterIpMapping == null && Exploration.Includes(parent + ".clusterIpMapping"))
        {
            this.ClusterIpMapping = new ClusterIpMapping();
            this.ClusterIpMapping.ApplyExploratoryFieldSpec(parent + ".clusterIpMapping");
        }
        //      C# -> PrivateEndpointConnection? PrivateEndpointConnection
        // GraphQL -> privateEndpointConnection: PrivateEndpointConnection (type)
        if (this.PrivateEndpointConnection == null && Exploration.Includes(parent + ".privateEndpointConnection"))
        {
            this.PrivateEndpointConnection = new PrivateEndpointConnection();
            this.PrivateEndpointConnection.ApplyExploratoryFieldSpec(parent + ".privateEndpointConnection");
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

    } // class RubrikManagedRcsTarget
    
    #endregion

    public static class ListRubrikManagedRcsTargetExtensions
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
            this List<RubrikManagedRcsTarget> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RubrikManagedRcsTarget> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RubrikManagedRcsTarget());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types