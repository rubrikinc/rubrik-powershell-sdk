// UnmanagedObjectDetail.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region UnmanagedObjectDetail
    public class UnmanagedObjectDetail: BaseType
    {
        #region members

        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType! (enum)
        [JsonProperty("objectType")]
        public ManagedObjectType? ObjectType { get; set; }

        //      C# -> UnmanagedObjectAvailabilityFilter? UnmanagedStatus
        // GraphQL -> unmanagedStatus: UnmanagedObjectAvailabilityFilter! (enum)
        [JsonProperty("unmanagedStatus")]
        public UnmanagedObjectAvailabilityFilter? UnmanagedStatus { get; set; }

        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        [JsonProperty("effectiveSlaDomain")]
        public SlaDomain? EffectiveSlaDomain { get; set; }

        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        [JsonProperty("pendingSla")]
        public SlaDomain? PendingSla { get; set; }

        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long! (scalar)
        [JsonProperty("archiveStorage")]
        public System.Int64? ArchiveStorage { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Boolean? HasSnapshotsWithPolicy
        // GraphQL -> hasSnapshotsWithPolicy: Boolean! (scalar)
        [JsonProperty("hasSnapshotsWithPolicy")]
        public System.Boolean? HasSnapshotsWithPolicy { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsRemote
        // GraphQL -> isRemote: Boolean (scalar)
        [JsonProperty("isRemote")]
        public System.Boolean? IsRemote { get; set; }

        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long! (scalar)
        [JsonProperty("localStorage")]
        public System.Int64? LocalStorage { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? RetentionSlaDomainId
        // GraphQL -> retentionSlaDomainId: String! (scalar)
        [JsonProperty("retentionSlaDomainId")]
        public System.String? RetentionSlaDomainId { get; set; }

        //      C# -> System.String? RetentionSlaDomainName
        // GraphQL -> retentionSlaDomainName: String! (scalar)
        [JsonProperty("retentionSlaDomainName")]
        public System.String? RetentionSlaDomainName { get; set; }

        //      C# -> System.String? RetentionSlaDomainPolarisManagedId
        // GraphQL -> retentionSlaDomainPolarisManagedId: String (scalar)
        [JsonProperty("retentionSlaDomainPolarisManagedId")]
        public System.String? RetentionSlaDomainPolarisManagedId { get; set; }

        //      C# -> System.Int64? SnapshotCount
        // GraphQL -> snapshotCount: Long! (scalar)
        [JsonProperty("snapshotCount")]
        public System.Int64? SnapshotCount { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> List<LocationPathPoint>? PhysicalLocation
        // GraphQL -> physicalLocation: [LocationPathPoint!]! (type)
        [JsonProperty("physicalLocation")]
        public List<LocationPathPoint>? PhysicalLocation { get; set; }

        //      C# -> SnappableRecoveryInfo? RecoveryInfo
        // GraphQL -> recoveryInfo: SnappableRecoveryInfo (type)
        [JsonProperty("recoveryInfo")]
        public SnappableRecoveryInfo? RecoveryInfo { get; set; }


        #endregion

    #region methods

    public UnmanagedObjectDetail Set(
        ManagedObjectType? ObjectType = null,
        UnmanagedObjectAvailabilityFilter? UnmanagedStatus = null,
        SlaDomain? EffectiveSlaDomain = null,
        SlaDomain? PendingSla = null,
        System.Int64? ArchiveStorage = null,
        System.String? ClusterUuid = null,
        System.Boolean? HasSnapshotsWithPolicy = null,
        System.String? Id = null,
        System.Boolean? IsRemote = null,
        System.Int64? LocalStorage = null,
        System.String? Name = null,
        System.String? RetentionSlaDomainId = null,
        System.String? RetentionSlaDomainName = null,
        System.String? RetentionSlaDomainPolarisManagedId = null,
        System.Int64? SnapshotCount = null,
        Cluster? Cluster = null,
        List<LocationPathPoint>? PhysicalLocation = null,
        SnappableRecoveryInfo? RecoveryInfo = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( UnmanagedStatus != null ) {
            this.UnmanagedStatus = UnmanagedStatus;
        }
        if ( EffectiveSlaDomain != null ) {
            this.EffectiveSlaDomain = EffectiveSlaDomain;
        }
        if ( PendingSla != null ) {
            this.PendingSla = PendingSla;
        }
        if ( ArchiveStorage != null ) {
            this.ArchiveStorage = ArchiveStorage;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( HasSnapshotsWithPolicy != null ) {
            this.HasSnapshotsWithPolicy = HasSnapshotsWithPolicy;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsRemote != null ) {
            this.IsRemote = IsRemote;
        }
        if ( LocalStorage != null ) {
            this.LocalStorage = LocalStorage;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( RetentionSlaDomainId != null ) {
            this.RetentionSlaDomainId = RetentionSlaDomainId;
        }
        if ( RetentionSlaDomainName != null ) {
            this.RetentionSlaDomainName = RetentionSlaDomainName;
        }
        if ( RetentionSlaDomainPolarisManagedId != null ) {
            this.RetentionSlaDomainPolarisManagedId = RetentionSlaDomainPolarisManagedId;
        }
        if ( SnapshotCount != null ) {
            this.SnapshotCount = SnapshotCount;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( PhysicalLocation != null ) {
            this.PhysicalLocation = PhysicalLocation;
        }
        if ( RecoveryInfo != null ) {
            this.RecoveryInfo = RecoveryInfo;
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
        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> UnmanagedObjectAvailabilityFilter? UnmanagedStatus
        // GraphQL -> unmanagedStatus: UnmanagedObjectAvailabilityFilter! (enum)
        if (this.UnmanagedStatus != null) {
            s += ind + "unmanagedStatus\n" ;
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain != null) {
            s += ind + "effectiveSlaDomain {\n" +
                InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveSlaDomain).AsFieldSpec(indent+1) + ind + "}\n";
        }
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (this.PendingSla != null) {
            s += ind + "pendingSla {\n" +
                InterfaceHelper.MakeListFromComposite((BaseType)this.PendingSla).AsFieldSpec(indent+1) + ind + "}\n";
        }
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long! (scalar)
        if (this.ArchiveStorage != null) {
            s += ind + "archiveStorage\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.Boolean? HasSnapshotsWithPolicy
        // GraphQL -> hasSnapshotsWithPolicy: Boolean! (scalar)
        if (this.HasSnapshotsWithPolicy != null) {
            s += ind + "hasSnapshotsWithPolicy\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsRemote
        // GraphQL -> isRemote: Boolean (scalar)
        if (this.IsRemote != null) {
            s += ind + "isRemote\n" ;
        }
        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long! (scalar)
        if (this.LocalStorage != null) {
            s += ind + "localStorage\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? RetentionSlaDomainId
        // GraphQL -> retentionSlaDomainId: String! (scalar)
        if (this.RetentionSlaDomainId != null) {
            s += ind + "retentionSlaDomainId\n" ;
        }
        //      C# -> System.String? RetentionSlaDomainName
        // GraphQL -> retentionSlaDomainName: String! (scalar)
        if (this.RetentionSlaDomainName != null) {
            s += ind + "retentionSlaDomainName\n" ;
        }
        //      C# -> System.String? RetentionSlaDomainPolarisManagedId
        // GraphQL -> retentionSlaDomainPolarisManagedId: String (scalar)
        if (this.RetentionSlaDomainPolarisManagedId != null) {
            s += ind + "retentionSlaDomainPolarisManagedId\n" ;
        }
        //      C# -> System.Int64? SnapshotCount
        // GraphQL -> snapshotCount: Long! (scalar)
        if (this.SnapshotCount != null) {
            s += ind + "snapshotCount\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            s += ind + "cluster {\n" + this.Cluster.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<LocationPathPoint>? PhysicalLocation
        // GraphQL -> physicalLocation: [LocationPathPoint!]! (type)
        if (this.PhysicalLocation != null) {
            s += ind + "physicalLocation {\n" + this.PhysicalLocation.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SnappableRecoveryInfo? RecoveryInfo
        // GraphQL -> recoveryInfo: SnappableRecoveryInfo (type)
        if (this.RecoveryInfo != null) {
            s += ind + "recoveryInfo {\n" + this.RecoveryInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType! (enum)
        if (this.ObjectType == null && Exploration.Includes(parent + ".objectType", true))
        {
            this.ObjectType = new ManagedObjectType();
        }
        //      C# -> UnmanagedObjectAvailabilityFilter? UnmanagedStatus
        // GraphQL -> unmanagedStatus: UnmanagedObjectAvailabilityFilter! (enum)
        if (this.UnmanagedStatus == null && Exploration.Includes(parent + ".unmanagedStatus", true))
        {
            this.UnmanagedStatus = new UnmanagedObjectAvailabilityFilter();
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain == null && Exploration.Includes(parent + ".effectiveSlaDomain"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".effectiveSlaDomain");
            this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (this.PendingSla == null && Exploration.Includes(parent + ".pendingSla"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".pendingSla");
            this.PendingSla = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long! (scalar)
        if (this.ArchiveStorage == null && Exploration.Includes(parent + ".archiveStorage", true))
        {
            this.ArchiveStorage = new System.Int64();
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> System.Boolean? HasSnapshotsWithPolicy
        // GraphQL -> hasSnapshotsWithPolicy: Boolean! (scalar)
        if (this.HasSnapshotsWithPolicy == null && Exploration.Includes(parent + ".hasSnapshotsWithPolicy", true))
        {
            this.HasSnapshotsWithPolicy = true;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsRemote
        // GraphQL -> isRemote: Boolean (scalar)
        if (this.IsRemote == null && Exploration.Includes(parent + ".isRemote", true))
        {
            this.IsRemote = true;
        }
        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long! (scalar)
        if (this.LocalStorage == null && Exploration.Includes(parent + ".localStorage", true))
        {
            this.LocalStorage = new System.Int64();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? RetentionSlaDomainId
        // GraphQL -> retentionSlaDomainId: String! (scalar)
        if (this.RetentionSlaDomainId == null && Exploration.Includes(parent + ".retentionSlaDomainId", true))
        {
            this.RetentionSlaDomainId = "FETCH";
        }
        //      C# -> System.String? RetentionSlaDomainName
        // GraphQL -> retentionSlaDomainName: String! (scalar)
        if (this.RetentionSlaDomainName == null && Exploration.Includes(parent + ".retentionSlaDomainName", true))
        {
            this.RetentionSlaDomainName = "FETCH";
        }
        //      C# -> System.String? RetentionSlaDomainPolarisManagedId
        // GraphQL -> retentionSlaDomainPolarisManagedId: String (scalar)
        if (this.RetentionSlaDomainPolarisManagedId == null && Exploration.Includes(parent + ".retentionSlaDomainPolarisManagedId", true))
        {
            this.RetentionSlaDomainPolarisManagedId = "FETCH";
        }
        //      C# -> System.Int64? SnapshotCount
        // GraphQL -> snapshotCount: Long! (scalar)
        if (this.SnapshotCount == null && Exploration.Includes(parent + ".snapshotCount", true))
        {
            this.SnapshotCount = new System.Int64();
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
        //      C# -> List<LocationPathPoint>? PhysicalLocation
        // GraphQL -> physicalLocation: [LocationPathPoint!]! (type)
        if (this.PhysicalLocation == null && Exploration.Includes(parent + ".physicalLocation"))
        {
            this.PhysicalLocation = new List<LocationPathPoint>();
            this.PhysicalLocation.ApplyExploratoryFieldSpec(parent + ".physicalLocation");
        }
        //      C# -> SnappableRecoveryInfo? RecoveryInfo
        // GraphQL -> recoveryInfo: SnappableRecoveryInfo (type)
        if (this.RecoveryInfo == null && Exploration.Includes(parent + ".recoveryInfo"))
        {
            this.RecoveryInfo = new SnappableRecoveryInfo();
            this.RecoveryInfo.ApplyExploratoryFieldSpec(parent + ".recoveryInfo");
        }
    }


    #endregion

    } // class UnmanagedObjectDetail
    
    #endregion

    public static class ListUnmanagedObjectDetailExtensions
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
            this List<UnmanagedObjectDetail> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UnmanagedObjectDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UnmanagedObjectDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types