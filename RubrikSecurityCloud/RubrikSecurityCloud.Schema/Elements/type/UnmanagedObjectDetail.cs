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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

        //      C# -> System.String? RetentionSlaDomainRscManagedId
        // GraphQL -> retentionSlaDomainRscManagedId: String (scalar)
        [JsonProperty("retentionSlaDomainRscManagedId")]
        public System.String? RetentionSlaDomainRscManagedId { get; set; }

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

        //      C# -> WorkloadRecoveryInfo? RecoveryInfo
        // GraphQL -> recoveryInfo: WorkloadRecoveryInfo (type)
        [JsonProperty("recoveryInfo")]
        public WorkloadRecoveryInfo? RecoveryInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UnmanagedObjectDetail";
    }

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
        System.String? RetentionSlaDomainRscManagedId = null,
        System.Int64? SnapshotCount = null,
        Cluster? Cluster = null,
        List<LocationPathPoint>? PhysicalLocation = null,
        WorkloadRecoveryInfo? RecoveryInfo = null
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
        if ( RetentionSlaDomainRscManagedId != null ) {
            this.RetentionSlaDomainRscManagedId = RetentionSlaDomainRscManagedId;
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
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveSlaDomain).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "effectiveSlaDomain {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (this.PendingSla != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.PendingSla).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pendingSla {\n" + fspec + ind + "}\n";
            }
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
        //      C# -> System.String? RetentionSlaDomainRscManagedId
        // GraphQL -> retentionSlaDomainRscManagedId: String (scalar)
        if (this.RetentionSlaDomainRscManagedId != null) {
            s += ind + "retentionSlaDomainRscManagedId\n" ;
        }
        //      C# -> System.Int64? SnapshotCount
        // GraphQL -> snapshotCount: Long! (scalar)
        if (this.SnapshotCount != null) {
            s += ind + "snapshotCount\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<LocationPathPoint>? PhysicalLocation
        // GraphQL -> physicalLocation: [LocationPathPoint!]! (type)
        if (this.PhysicalLocation != null) {
            var fspec = this.PhysicalLocation.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "physicalLocation {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> WorkloadRecoveryInfo? RecoveryInfo
        // GraphQL -> recoveryInfo: WorkloadRecoveryInfo (type)
        if (this.RecoveryInfo != null) {
            var fspec = this.RecoveryInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "recoveryInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType! (enum)
        if (this.ObjectType == null && ec.Includes("objectType",true))
        {
            this.ObjectType = new ManagedObjectType();
        }
        //      C# -> UnmanagedObjectAvailabilityFilter? UnmanagedStatus
        // GraphQL -> unmanagedStatus: UnmanagedObjectAvailabilityFilter! (enum)
        if (this.UnmanagedStatus == null && ec.Includes("unmanagedStatus",true))
        {
            this.UnmanagedStatus = new UnmanagedObjectAvailabilityFilter();
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain == null && ec.Includes("effectiveSlaDomain",false))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaDomain"));
            this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (this.PendingSla == null && ec.Includes("pendingSla",false))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("pendingSla"));
            this.PendingSla = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long! (scalar)
        if (this.ArchiveStorage == null && ec.Includes("archiveStorage",true))
        {
            this.ArchiveStorage = new System.Int64();
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && ec.Includes("clusterUuid",true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> System.Boolean? HasSnapshotsWithPolicy
        // GraphQL -> hasSnapshotsWithPolicy: Boolean! (scalar)
        if (this.HasSnapshotsWithPolicy == null && ec.Includes("hasSnapshotsWithPolicy",true))
        {
            this.HasSnapshotsWithPolicy = true;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsRemote
        // GraphQL -> isRemote: Boolean (scalar)
        if (this.IsRemote == null && ec.Includes("isRemote",true))
        {
            this.IsRemote = true;
        }
        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long! (scalar)
        if (this.LocalStorage == null && ec.Includes("localStorage",true))
        {
            this.LocalStorage = new System.Int64();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? RetentionSlaDomainId
        // GraphQL -> retentionSlaDomainId: String! (scalar)
        if (this.RetentionSlaDomainId == null && ec.Includes("retentionSlaDomainId",true))
        {
            this.RetentionSlaDomainId = "FETCH";
        }
        //      C# -> System.String? RetentionSlaDomainName
        // GraphQL -> retentionSlaDomainName: String! (scalar)
        if (this.RetentionSlaDomainName == null && ec.Includes("retentionSlaDomainName",true))
        {
            this.RetentionSlaDomainName = "FETCH";
        }
        //      C# -> System.String? RetentionSlaDomainRscManagedId
        // GraphQL -> retentionSlaDomainRscManagedId: String (scalar)
        if (this.RetentionSlaDomainRscManagedId == null && ec.Includes("retentionSlaDomainRscManagedId",true))
        {
            this.RetentionSlaDomainRscManagedId = "FETCH";
        }
        //      C# -> System.Int64? SnapshotCount
        // GraphQL -> snapshotCount: Long! (scalar)
        if (this.SnapshotCount == null && ec.Includes("snapshotCount",true))
        {
            this.SnapshotCount = new System.Int64();
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && ec.Includes("cluster",false))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));
        }
        //      C# -> List<LocationPathPoint>? PhysicalLocation
        // GraphQL -> physicalLocation: [LocationPathPoint!]! (type)
        if (this.PhysicalLocation == null && ec.Includes("physicalLocation",false))
        {
            this.PhysicalLocation = new List<LocationPathPoint>();
            this.PhysicalLocation.ApplyExploratoryFieldSpec(ec.NewChild("physicalLocation"));
        }
        //      C# -> WorkloadRecoveryInfo? RecoveryInfo
        // GraphQL -> recoveryInfo: WorkloadRecoveryInfo (type)
        if (this.RecoveryInfo == null && ec.Includes("recoveryInfo",false))
        {
            this.RecoveryInfo = new WorkloadRecoveryInfo();
            this.RecoveryInfo.ApplyExploratoryFieldSpec(ec.NewChild("recoveryInfo"));
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
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UnmanagedObjectDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UnmanagedObjectDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<UnmanagedObjectDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types