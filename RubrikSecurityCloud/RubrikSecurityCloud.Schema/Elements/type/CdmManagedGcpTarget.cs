// CdmManagedGcpTarget.cs
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
    #region CdmManagedGcpTarget
 
    public class CdmManagedGcpTarget: BaseType, Target
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

        //      C# -> GcpRegion? Region
        // GraphQL -> region: GcpRegion! (enum)
        [JsonProperty("region")]
        public GcpRegion? Region { get; set; }

        //      C# -> ArchivalLocationStatus? Status
        // GraphQL -> status: ArchivalLocationStatus! (enum)
        [JsonProperty("status")]
        public ArchivalLocationStatus? Status { get; set; }

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

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? RunningTasks
        // GraphQL -> runningTasks: Int (scalar)
        [JsonProperty("runningTasks")]
        public System.Int32? RunningTasks { get; set; }

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
        return "CdmManagedGcpTarget";
    }

    public CdmManagedGcpTarget Set(
        ConnectionStatusType? LocationConnectionStatus = null,
        LocationScope? LocationScope = null,
        ReaderRetrievalMethod? ReaderRetrievalMethod = null,
        GcpRegion? Region = null,
        ArchivalLocationStatus? Status = null,
        TargetType? TargetType = null,
        UpgradeStatus? UpgradeStatus = null,
        System.String? ClusterName = null,
        System.Int64? ConsumedBytes = null,
        System.Int32? FailedTasks = null,
        System.String? Id = null,
        System.Boolean? IsActive = null,
        System.Boolean? IsArchived = null,
        System.String? Name = null,
        System.Int32? RunningTasks = null,
        Cluster? Cluster = null,
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
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( RunningTasks != null ) {
            this.RunningTasks = RunningTasks;
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
        //      C# -> GcpRegion? Region
        // GraphQL -> region: GcpRegion! (enum)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> ArchivalLocationStatus? Status
        // GraphQL -> status: ArchivalLocationStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
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
        //      C# -> GcpRegion? Region
        // GraphQL -> region: GcpRegion! (enum)
        if (this.Region == null && Exploration.Includes(parent + ".region", true))
        {
            this.Region = new GcpRegion();
        }
        //      C# -> ArchivalLocationStatus? Status
        // GraphQL -> status: ArchivalLocationStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new ArchivalLocationStatus();
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

    } // class CdmManagedGcpTarget
    
    #endregion

    public static class ListCdmManagedGcpTargetExtensions
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
            this List<CdmManagedGcpTarget> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmManagedGcpTarget> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmManagedGcpTarget());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types