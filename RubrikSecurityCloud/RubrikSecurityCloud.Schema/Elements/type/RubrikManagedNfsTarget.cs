// RubrikManagedNfsTarget.cs
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
    #region RubrikManagedNfsTarget
 
    public class RubrikManagedNfsTarget: BaseType, Target
    {
        #region members

        //      C# -> ConnectionStatusType? ConnectionStatus
        // GraphQL -> connectionStatus: ConnectionStatusType! (enum)
        [JsonProperty("connectionStatus")]
        public ConnectionStatusType? ConnectionStatus { get; set; }

        //      C# -> ConnectionStatusType? LocationConnectionStatus
        // GraphQL -> locationConnectionStatus: ConnectionStatusType! (enum)
        [JsonProperty("locationConnectionStatus")]
        public ConnectionStatusType? LocationConnectionStatus { get; set; }

        //      C# -> LocationScope? LocationScope
        // GraphQL -> locationScope: LocationScope! (enum)
        [JsonProperty("locationScope")]
        public LocationScope? LocationScope { get; set; }

        //      C# -> AuthTypeEnum? NfsAuthType
        // GraphQL -> nfsAuthType: AuthTypeEnum! (enum)
        [JsonProperty("nfsAuthType")]
        public AuthTypeEnum? NfsAuthType { get; set; }

        //      C# -> ReaderRetrievalMethod? ReaderRetrievalMethod
        // GraphQL -> readerRetrievalMethod: ReaderRetrievalMethod (enum)
        [JsonProperty("readerRetrievalMethod")]
        public ReaderRetrievalMethod? ReaderRetrievalMethod { get; set; }

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

        //      C# -> System.String? DestinationFolder
        // GraphQL -> destinationFolder: String! (scalar)
        [JsonProperty("destinationFolder")]
        public System.String? DestinationFolder { get; set; }

        //      C# -> System.String? ExportDir
        // GraphQL -> exportDir: String! (scalar)
        [JsonProperty("exportDir")]
        public System.String? ExportDir { get; set; }

        //      C# -> System.Int32? FailedTasks
        // GraphQL -> failedTasks: Int (scalar)
        [JsonProperty("failedTasks")]
        public System.Int32? FailedTasks { get; set; }

        //      C# -> System.Int32? FileLockPeriodInSeconds
        // GraphQL -> fileLockPeriodInSeconds: Int! (scalar)
        [JsonProperty("fileLockPeriodInSeconds")]
        public System.Int32? FileLockPeriodInSeconds { get; set; }

        //      C# -> System.String? Host
        // GraphQL -> host: String! (scalar)
        [JsonProperty("host")]
        public System.String? Host { get; set; }

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

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NfsVersion
        // GraphQL -> nfsVersion: Int! (scalar)
        [JsonProperty("nfsVersion")]
        public System.Int32? NfsVersion { get; set; }

        //      C# -> System.String? OtherNfsOptions
        // GraphQL -> otherNfsOptions: String! (scalar)
        [JsonProperty("otherNfsOptions")]
        public System.String? OtherNfsOptions { get; set; }

        //      C# -> System.Int32? RunningTasks
        // GraphQL -> runningTasks: Int (scalar)
        [JsonProperty("runningTasks")]
        public System.Int32? RunningTasks { get; set; }

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
        return "RubrikManagedNfsTarget";
    }

    public RubrikManagedNfsTarget Set(
        ConnectionStatusType? ConnectionStatus = null,
        ConnectionStatusType? LocationConnectionStatus = null,
        LocationScope? LocationScope = null,
        AuthTypeEnum? NfsAuthType = null,
        ReaderRetrievalMethod? ReaderRetrievalMethod = null,
        ArchivalLocationStatus? Status = null,
        TargetSyncStatus? SyncStatus = null,
        TargetType? TargetType = null,
        UpgradeStatus? UpgradeStatus = null,
        System.String? ClusterName = null,
        System.Int64? ConsumedBytes = null,
        System.String? DestinationFolder = null,
        System.String? ExportDir = null,
        System.Int32? FailedTasks = null,
        System.Int32? FileLockPeriodInSeconds = null,
        System.String? Host = null,
        System.String? Id = null,
        System.Boolean? IsActive = null,
        System.Boolean? IsArchived = null,
        System.Boolean? IsConsolidationEnabled = null,
        System.String? Name = null,
        System.Int32? NfsVersion = null,
        System.String? OtherNfsOptions = null,
        System.Int32? RunningTasks = null,
        System.String? SyncFailureReason = null,
        Cluster? Cluster = null,
        TargetMappingBasic? TargetMapping = null,
        List<TargetMappingBasic>? TargetMappingBasic = null
    ) 
    {
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( LocationConnectionStatus != null ) {
            this.LocationConnectionStatus = LocationConnectionStatus;
        }
        if ( LocationScope != null ) {
            this.LocationScope = LocationScope;
        }
        if ( NfsAuthType != null ) {
            this.NfsAuthType = NfsAuthType;
        }
        if ( ReaderRetrievalMethod != null ) {
            this.ReaderRetrievalMethod = ReaderRetrievalMethod;
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
        if ( UpgradeStatus != null ) {
            this.UpgradeStatus = UpgradeStatus;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( ConsumedBytes != null ) {
            this.ConsumedBytes = ConsumedBytes;
        }
        if ( DestinationFolder != null ) {
            this.DestinationFolder = DestinationFolder;
        }
        if ( ExportDir != null ) {
            this.ExportDir = ExportDir;
        }
        if ( FailedTasks != null ) {
            this.FailedTasks = FailedTasks;
        }
        if ( FileLockPeriodInSeconds != null ) {
            this.FileLockPeriodInSeconds = FileLockPeriodInSeconds;
        }
        if ( Host != null ) {
            this.Host = Host;
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
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NfsVersion != null ) {
            this.NfsVersion = NfsVersion;
        }
        if ( OtherNfsOptions != null ) {
            this.OtherNfsOptions = OtherNfsOptions;
        }
        if ( RunningTasks != null ) {
            this.RunningTasks = RunningTasks;
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ConnectionStatusType? ConnectionStatus
        // GraphQL -> connectionStatus: ConnectionStatusType! (enum)
        if (this.ConnectionStatus != null) {
            s += ind + "connectionStatus\n" ;
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
        //      C# -> AuthTypeEnum? NfsAuthType
        // GraphQL -> nfsAuthType: AuthTypeEnum! (enum)
        if (this.NfsAuthType != null) {
            s += ind + "nfsAuthType\n" ;
        }
        //      C# -> ReaderRetrievalMethod? ReaderRetrievalMethod
        // GraphQL -> readerRetrievalMethod: ReaderRetrievalMethod (enum)
        if (this.ReaderRetrievalMethod != null) {
            s += ind + "readerRetrievalMethod\n" ;
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
        //      C# -> System.String? DestinationFolder
        // GraphQL -> destinationFolder: String! (scalar)
        if (this.DestinationFolder != null) {
            s += ind + "destinationFolder\n" ;
        }
        //      C# -> System.String? ExportDir
        // GraphQL -> exportDir: String! (scalar)
        if (this.ExportDir != null) {
            s += ind + "exportDir\n" ;
        }
        //      C# -> System.Int32? FailedTasks
        // GraphQL -> failedTasks: Int (scalar)
        if (this.FailedTasks != null) {
            s += ind + "failedTasks\n" ;
        }
        //      C# -> System.Int32? FileLockPeriodInSeconds
        // GraphQL -> fileLockPeriodInSeconds: Int! (scalar)
        if (this.FileLockPeriodInSeconds != null) {
            s += ind + "fileLockPeriodInSeconds\n" ;
        }
        //      C# -> System.String? Host
        // GraphQL -> host: String! (scalar)
        if (this.Host != null) {
            s += ind + "host\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.Int32? NfsVersion
        // GraphQL -> nfsVersion: Int! (scalar)
        if (this.NfsVersion != null) {
            s += ind + "nfsVersion\n" ;
        }
        //      C# -> System.String? OtherNfsOptions
        // GraphQL -> otherNfsOptions: String! (scalar)
        if (this.OtherNfsOptions != null) {
            s += ind + "otherNfsOptions\n" ;
        }
        //      C# -> System.Int32? RunningTasks
        // GraphQL -> runningTasks: Int (scalar)
        if (this.RunningTasks != null) {
            s += ind + "runningTasks\n" ;
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
        //      C# -> ConnectionStatusType? ConnectionStatus
        // GraphQL -> connectionStatus: ConnectionStatusType! (enum)
        if (this.ConnectionStatus == null && Exploration.Includes(parent + ".connectionStatus", true))
        {
            this.ConnectionStatus = new ConnectionStatusType();
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
        //      C# -> AuthTypeEnum? NfsAuthType
        // GraphQL -> nfsAuthType: AuthTypeEnum! (enum)
        if (this.NfsAuthType == null && Exploration.Includes(parent + ".nfsAuthType", true))
        {
            this.NfsAuthType = new AuthTypeEnum();
        }
        //      C# -> ReaderRetrievalMethod? ReaderRetrievalMethod
        // GraphQL -> readerRetrievalMethod: ReaderRetrievalMethod (enum)
        if (this.ReaderRetrievalMethod == null && Exploration.Includes(parent + ".readerRetrievalMethod", true))
        {
            this.ReaderRetrievalMethod = new ReaderRetrievalMethod();
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
        //      C# -> System.String? DestinationFolder
        // GraphQL -> destinationFolder: String! (scalar)
        if (this.DestinationFolder == null && Exploration.Includes(parent + ".destinationFolder", true))
        {
            this.DestinationFolder = "FETCH";
        }
        //      C# -> System.String? ExportDir
        // GraphQL -> exportDir: String! (scalar)
        if (this.ExportDir == null && Exploration.Includes(parent + ".exportDir", true))
        {
            this.ExportDir = "FETCH";
        }
        //      C# -> System.Int32? FailedTasks
        // GraphQL -> failedTasks: Int (scalar)
        if (this.FailedTasks == null && Exploration.Includes(parent + ".failedTasks", true))
        {
            this.FailedTasks = Int32.MinValue;
        }
        //      C# -> System.Int32? FileLockPeriodInSeconds
        // GraphQL -> fileLockPeriodInSeconds: Int! (scalar)
        if (this.FileLockPeriodInSeconds == null && Exploration.Includes(parent + ".fileLockPeriodInSeconds", true))
        {
            this.FileLockPeriodInSeconds = Int32.MinValue;
        }
        //      C# -> System.String? Host
        // GraphQL -> host: String! (scalar)
        if (this.Host == null && Exploration.Includes(parent + ".host", true))
        {
            this.Host = "FETCH";
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.Int32? NfsVersion
        // GraphQL -> nfsVersion: Int! (scalar)
        if (this.NfsVersion == null && Exploration.Includes(parent + ".nfsVersion", true))
        {
            this.NfsVersion = Int32.MinValue;
        }
        //      C# -> System.String? OtherNfsOptions
        // GraphQL -> otherNfsOptions: String! (scalar)
        if (this.OtherNfsOptions == null && Exploration.Includes(parent + ".otherNfsOptions", true))
        {
            this.OtherNfsOptions = "FETCH";
        }
        //      C# -> System.Int32? RunningTasks
        // GraphQL -> runningTasks: Int (scalar)
        if (this.RunningTasks == null && Exploration.Includes(parent + ".runningTasks", true))
        {
            this.RunningTasks = Int32.MinValue;
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

    } // class RubrikManagedNfsTarget
    
    #endregion

    public static class ListRubrikManagedNfsTargetExtensions
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
            this List<RubrikManagedNfsTarget> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RubrikManagedNfsTarget> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RubrikManagedNfsTarget());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types