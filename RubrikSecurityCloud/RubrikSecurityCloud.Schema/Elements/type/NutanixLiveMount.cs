// NutanixLiveMount.cs
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
    #region NutanixLiveMount
    public class NutanixLiveMount: BaseType
    {
        #region members

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsMigrationDisabled
        // GraphQL -> isMigrationDisabled: Boolean! (scalar)
        [JsonProperty("isMigrationDisabled")]
        public System.Boolean? IsMigrationDisabled { get; set; }

        //      C# -> System.Boolean? IsVmReady
        // GraphQL -> isVmReady: Boolean! (scalar)
        [JsonProperty("isVmReady")]
        public System.Boolean? IsVmReady { get; set; }

        //      C# -> System.String? MigrationJobInstanceId
        // GraphQL -> migrationJobInstanceId: String (scalar)
        [JsonProperty("migrationJobInstanceId")]
        public System.String? MigrationJobInstanceId { get; set; }

        //      C# -> System.String? MigrationJobStatus
        // GraphQL -> migrationJobStatus: String (scalar)
        [JsonProperty("migrationJobStatus")]
        public System.String? MigrationJobStatus { get; set; }

        //      C# -> System.String? MountJobInstanceId
        // GraphQL -> mountJobInstanceId: String! (scalar)
        [JsonProperty("mountJobInstanceId")]
        public System.String? MountJobInstanceId { get; set; }

        //      C# -> System.String? MountSpec
        // GraphQL -> mountSpec: String! (scalar)
        [JsonProperty("mountSpec")]
        public System.String? MountSpec { get; set; }

        //      C# -> DateTime? MountedDate
        // GraphQL -> mountedDate: DateTime (scalar)
        [JsonProperty("mountedDate")]
        public DateTime? MountedDate { get; set; }

        //      C# -> System.String? MountedVmFid
        // GraphQL -> mountedVmFid: String (scalar)
        [JsonProperty("mountedVmFid")]
        public System.String? MountedVmFid { get; set; }

        //      C# -> System.String? MountedVmId
        // GraphQL -> mountedVmId: String (scalar)
        [JsonProperty("mountedVmId")]
        public System.String? MountedVmId { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NutanixClusterFid
        // GraphQL -> nutanixClusterFid: String! (scalar)
        [JsonProperty("nutanixClusterFid")]
        public System.String? NutanixClusterFid { get; set; }

        //      C# -> System.String? NutanixClusterId
        // GraphQL -> nutanixClusterId: String! (scalar)
        [JsonProperty("nutanixClusterId")]
        public System.String? NutanixClusterId { get; set; }

        //      C# -> System.String? NutanixClusterName
        // GraphQL -> nutanixClusterName: String! (scalar)
        [JsonProperty("nutanixClusterName")]
        public System.String? NutanixClusterName { get; set; }

        //      C# -> System.String? OrganizationId
        // GraphQL -> organizationId: String! (scalar)
        [JsonProperty("organizationId")]
        public System.String? OrganizationId { get; set; }

        //      C# -> System.String? OwnerId
        // GraphQL -> ownerId: String! (scalar)
        [JsonProperty("ownerId")]
        public System.String? OwnerId { get; set; }

        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String! (scalar)
        [JsonProperty("powerStatus")]
        public System.String? PowerStatus { get; set; }

        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        [JsonProperty("snapshotDate")]
        public DateTime? SnapshotDate { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? SourceVmFid
        // GraphQL -> sourceVmFid: String! (scalar)
        [JsonProperty("sourceVmFid")]
        public System.String? SourceVmFid { get; set; }

        //      C# -> System.String? SourceVmId
        // GraphQL -> sourceVmId: String! (scalar)
        [JsonProperty("sourceVmId")]
        public System.String? SourceVmId { get; set; }

        //      C# -> System.String? SourceVmName
        // GraphQL -> sourceVmName: String! (scalar)
        [JsonProperty("sourceVmName")]
        public System.String? SourceVmName { get; set; }

        //      C# -> System.String? StorageContainerName
        // GraphQL -> storageContainerName: String (scalar)
        [JsonProperty("storageContainerName")]
        public System.String? StorageContainerName { get; set; }

        //      C# -> System.String? UnmountJobInstanceId
        // GraphQL -> unmountJobInstanceId: String! (scalar)
        [JsonProperty("unmountJobInstanceId")]
        public System.String? UnmountJobInstanceId { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        [JsonProperty("sourceSnapshot")]
        public CdmSnapshot? SourceSnapshot { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NutanixLiveMount";
    }

    public NutanixLiveMount Set(
        System.String? CdmId = null,
        System.String? Id = null,
        System.Boolean? IsMigrationDisabled = null,
        System.Boolean? IsVmReady = null,
        System.String? MigrationJobInstanceId = null,
        System.String? MigrationJobStatus = null,
        System.String? MountJobInstanceId = null,
        System.String? MountSpec = null,
        DateTime? MountedDate = null,
        System.String? MountedVmFid = null,
        System.String? MountedVmId = null,
        System.String? Name = null,
        System.String? NutanixClusterFid = null,
        System.String? NutanixClusterId = null,
        System.String? NutanixClusterName = null,
        System.String? OrganizationId = null,
        System.String? OwnerId = null,
        System.String? PowerStatus = null,
        DateTime? SnapshotDate = null,
        System.String? SnapshotId = null,
        System.String? SourceVmFid = null,
        System.String? SourceVmId = null,
        System.String? SourceVmName = null,
        System.String? StorageContainerName = null,
        System.String? UnmountJobInstanceId = null,
        Cluster? Cluster = null,
        CdmSnapshot? SourceSnapshot = null
    ) 
    {
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsMigrationDisabled != null ) {
            this.IsMigrationDisabled = IsMigrationDisabled;
        }
        if ( IsVmReady != null ) {
            this.IsVmReady = IsVmReady;
        }
        if ( MigrationJobInstanceId != null ) {
            this.MigrationJobInstanceId = MigrationJobInstanceId;
        }
        if ( MigrationJobStatus != null ) {
            this.MigrationJobStatus = MigrationJobStatus;
        }
        if ( MountJobInstanceId != null ) {
            this.MountJobInstanceId = MountJobInstanceId;
        }
        if ( MountSpec != null ) {
            this.MountSpec = MountSpec;
        }
        if ( MountedDate != null ) {
            this.MountedDate = MountedDate;
        }
        if ( MountedVmFid != null ) {
            this.MountedVmFid = MountedVmFid;
        }
        if ( MountedVmId != null ) {
            this.MountedVmId = MountedVmId;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NutanixClusterFid != null ) {
            this.NutanixClusterFid = NutanixClusterFid;
        }
        if ( NutanixClusterId != null ) {
            this.NutanixClusterId = NutanixClusterId;
        }
        if ( NutanixClusterName != null ) {
            this.NutanixClusterName = NutanixClusterName;
        }
        if ( OrganizationId != null ) {
            this.OrganizationId = OrganizationId;
        }
        if ( OwnerId != null ) {
            this.OwnerId = OwnerId;
        }
        if ( PowerStatus != null ) {
            this.PowerStatus = PowerStatus;
        }
        if ( SnapshotDate != null ) {
            this.SnapshotDate = SnapshotDate;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( SourceVmFid != null ) {
            this.SourceVmFid = SourceVmFid;
        }
        if ( SourceVmId != null ) {
            this.SourceVmId = SourceVmId;
        }
        if ( SourceVmName != null ) {
            this.SourceVmName = SourceVmName;
        }
        if ( StorageContainerName != null ) {
            this.StorageContainerName = StorageContainerName;
        }
        if ( UnmountJobInstanceId != null ) {
            this.UnmountJobInstanceId = UnmountJobInstanceId;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( SourceSnapshot != null ) {
            this.SourceSnapshot = SourceSnapshot;
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
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            s += ind + "cdmId\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsMigrationDisabled
        // GraphQL -> isMigrationDisabled: Boolean! (scalar)
        if (this.IsMigrationDisabled != null) {
            s += ind + "isMigrationDisabled\n" ;
        }
        //      C# -> System.Boolean? IsVmReady
        // GraphQL -> isVmReady: Boolean! (scalar)
        if (this.IsVmReady != null) {
            s += ind + "isVmReady\n" ;
        }
        //      C# -> System.String? MigrationJobInstanceId
        // GraphQL -> migrationJobInstanceId: String (scalar)
        if (this.MigrationJobInstanceId != null) {
            s += ind + "migrationJobInstanceId\n" ;
        }
        //      C# -> System.String? MigrationJobStatus
        // GraphQL -> migrationJobStatus: String (scalar)
        if (this.MigrationJobStatus != null) {
            s += ind + "migrationJobStatus\n" ;
        }
        //      C# -> System.String? MountJobInstanceId
        // GraphQL -> mountJobInstanceId: String! (scalar)
        if (this.MountJobInstanceId != null) {
            s += ind + "mountJobInstanceId\n" ;
        }
        //      C# -> System.String? MountSpec
        // GraphQL -> mountSpec: String! (scalar)
        if (this.MountSpec != null) {
            s += ind + "mountSpec\n" ;
        }
        //      C# -> DateTime? MountedDate
        // GraphQL -> mountedDate: DateTime (scalar)
        if (this.MountedDate != null) {
            s += ind + "mountedDate\n" ;
        }
        //      C# -> System.String? MountedVmFid
        // GraphQL -> mountedVmFid: String (scalar)
        if (this.MountedVmFid != null) {
            s += ind + "mountedVmFid\n" ;
        }
        //      C# -> System.String? MountedVmId
        // GraphQL -> mountedVmId: String (scalar)
        if (this.MountedVmId != null) {
            s += ind + "mountedVmId\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? NutanixClusterFid
        // GraphQL -> nutanixClusterFid: String! (scalar)
        if (this.NutanixClusterFid != null) {
            s += ind + "nutanixClusterFid\n" ;
        }
        //      C# -> System.String? NutanixClusterId
        // GraphQL -> nutanixClusterId: String! (scalar)
        if (this.NutanixClusterId != null) {
            s += ind + "nutanixClusterId\n" ;
        }
        //      C# -> System.String? NutanixClusterName
        // GraphQL -> nutanixClusterName: String! (scalar)
        if (this.NutanixClusterName != null) {
            s += ind + "nutanixClusterName\n" ;
        }
        //      C# -> System.String? OrganizationId
        // GraphQL -> organizationId: String! (scalar)
        if (this.OrganizationId != null) {
            s += ind + "organizationId\n" ;
        }
        //      C# -> System.String? OwnerId
        // GraphQL -> ownerId: String! (scalar)
        if (this.OwnerId != null) {
            s += ind + "ownerId\n" ;
        }
        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String! (scalar)
        if (this.PowerStatus != null) {
            s += ind + "powerStatus\n" ;
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        if (this.SnapshotDate != null) {
            s += ind + "snapshotDate\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        //      C# -> System.String? SourceVmFid
        // GraphQL -> sourceVmFid: String! (scalar)
        if (this.SourceVmFid != null) {
            s += ind + "sourceVmFid\n" ;
        }
        //      C# -> System.String? SourceVmId
        // GraphQL -> sourceVmId: String! (scalar)
        if (this.SourceVmId != null) {
            s += ind + "sourceVmId\n" ;
        }
        //      C# -> System.String? SourceVmName
        // GraphQL -> sourceVmName: String! (scalar)
        if (this.SourceVmName != null) {
            s += ind + "sourceVmName\n" ;
        }
        //      C# -> System.String? StorageContainerName
        // GraphQL -> storageContainerName: String (scalar)
        if (this.StorageContainerName != null) {
            s += ind + "storageContainerName\n" ;
        }
        //      C# -> System.String? UnmountJobInstanceId
        // GraphQL -> unmountJobInstanceId: String! (scalar)
        if (this.UnmountJobInstanceId != null) {
            s += ind + "unmountJobInstanceId\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        if (this.SourceSnapshot != null) {
            var fspec = this.SourceSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sourceSnapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId == null && Exploration.Includes(parent + ".cdmId", true))
        {
            this.CdmId = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsMigrationDisabled
        // GraphQL -> isMigrationDisabled: Boolean! (scalar)
        if (this.IsMigrationDisabled == null && Exploration.Includes(parent + ".isMigrationDisabled", true))
        {
            this.IsMigrationDisabled = true;
        }
        //      C# -> System.Boolean? IsVmReady
        // GraphQL -> isVmReady: Boolean! (scalar)
        if (this.IsVmReady == null && Exploration.Includes(parent + ".isVmReady", true))
        {
            this.IsVmReady = true;
        }
        //      C# -> System.String? MigrationJobInstanceId
        // GraphQL -> migrationJobInstanceId: String (scalar)
        if (this.MigrationJobInstanceId == null && Exploration.Includes(parent + ".migrationJobInstanceId", true))
        {
            this.MigrationJobInstanceId = "FETCH";
        }
        //      C# -> System.String? MigrationJobStatus
        // GraphQL -> migrationJobStatus: String (scalar)
        if (this.MigrationJobStatus == null && Exploration.Includes(parent + ".migrationJobStatus", true))
        {
            this.MigrationJobStatus = "FETCH";
        }
        //      C# -> System.String? MountJobInstanceId
        // GraphQL -> mountJobInstanceId: String! (scalar)
        if (this.MountJobInstanceId == null && Exploration.Includes(parent + ".mountJobInstanceId", true))
        {
            this.MountJobInstanceId = "FETCH";
        }
        //      C# -> System.String? MountSpec
        // GraphQL -> mountSpec: String! (scalar)
        if (this.MountSpec == null && Exploration.Includes(parent + ".mountSpec", true))
        {
            this.MountSpec = "FETCH";
        }
        //      C# -> DateTime? MountedDate
        // GraphQL -> mountedDate: DateTime (scalar)
        if (this.MountedDate == null && Exploration.Includes(parent + ".mountedDate", true))
        {
            this.MountedDate = new DateTime();
        }
        //      C# -> System.String? MountedVmFid
        // GraphQL -> mountedVmFid: String (scalar)
        if (this.MountedVmFid == null && Exploration.Includes(parent + ".mountedVmFid", true))
        {
            this.MountedVmFid = "FETCH";
        }
        //      C# -> System.String? MountedVmId
        // GraphQL -> mountedVmId: String (scalar)
        if (this.MountedVmId == null && Exploration.Includes(parent + ".mountedVmId", true))
        {
            this.MountedVmId = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? NutanixClusterFid
        // GraphQL -> nutanixClusterFid: String! (scalar)
        if (this.NutanixClusterFid == null && Exploration.Includes(parent + ".nutanixClusterFid", true))
        {
            this.NutanixClusterFid = "FETCH";
        }
        //      C# -> System.String? NutanixClusterId
        // GraphQL -> nutanixClusterId: String! (scalar)
        if (this.NutanixClusterId == null && Exploration.Includes(parent + ".nutanixClusterId", true))
        {
            this.NutanixClusterId = "FETCH";
        }
        //      C# -> System.String? NutanixClusterName
        // GraphQL -> nutanixClusterName: String! (scalar)
        if (this.NutanixClusterName == null && Exploration.Includes(parent + ".nutanixClusterName", true))
        {
            this.NutanixClusterName = "FETCH";
        }
        //      C# -> System.String? OrganizationId
        // GraphQL -> organizationId: String! (scalar)
        if (this.OrganizationId == null && Exploration.Includes(parent + ".organizationId", true))
        {
            this.OrganizationId = "FETCH";
        }
        //      C# -> System.String? OwnerId
        // GraphQL -> ownerId: String! (scalar)
        if (this.OwnerId == null && Exploration.Includes(parent + ".ownerId", true))
        {
            this.OwnerId = "FETCH";
        }
        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String! (scalar)
        if (this.PowerStatus == null && Exploration.Includes(parent + ".powerStatus", true))
        {
            this.PowerStatus = "FETCH";
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        if (this.SnapshotDate == null && Exploration.Includes(parent + ".snapshotDate", true))
        {
            this.SnapshotDate = new DateTime();
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId", true))
        {
            this.SnapshotId = "FETCH";
        }
        //      C# -> System.String? SourceVmFid
        // GraphQL -> sourceVmFid: String! (scalar)
        if (this.SourceVmFid == null && Exploration.Includes(parent + ".sourceVmFid", true))
        {
            this.SourceVmFid = "FETCH";
        }
        //      C# -> System.String? SourceVmId
        // GraphQL -> sourceVmId: String! (scalar)
        if (this.SourceVmId == null && Exploration.Includes(parent + ".sourceVmId", true))
        {
            this.SourceVmId = "FETCH";
        }
        //      C# -> System.String? SourceVmName
        // GraphQL -> sourceVmName: String! (scalar)
        if (this.SourceVmName == null && Exploration.Includes(parent + ".sourceVmName", true))
        {
            this.SourceVmName = "FETCH";
        }
        //      C# -> System.String? StorageContainerName
        // GraphQL -> storageContainerName: String (scalar)
        if (this.StorageContainerName == null && Exploration.Includes(parent + ".storageContainerName", true))
        {
            this.StorageContainerName = "FETCH";
        }
        //      C# -> System.String? UnmountJobInstanceId
        // GraphQL -> unmountJobInstanceId: String! (scalar)
        if (this.UnmountJobInstanceId == null && Exploration.Includes(parent + ".unmountJobInstanceId", true))
        {
            this.UnmountJobInstanceId = "FETCH";
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        if (this.SourceSnapshot == null && Exploration.Includes(parent + ".sourceSnapshot"))
        {
            this.SourceSnapshot = new CdmSnapshot();
            this.SourceSnapshot.ApplyExploratoryFieldSpec(parent + ".sourceSnapshot");
        }
    }


    #endregion

    } // class NutanixLiveMount
    
    #endregion

    public static class ListNutanixLiveMountExtensions
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
            this List<NutanixLiveMount> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NutanixLiveMount> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixLiveMount());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types