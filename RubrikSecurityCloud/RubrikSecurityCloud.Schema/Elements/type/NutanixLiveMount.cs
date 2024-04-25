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

        //      C# -> NutanixVmMountStatus? MountStatus
        // GraphQL -> mountStatus: NutanixVmMountStatus (enum)
        [JsonProperty("mountStatus")]
        public NutanixVmMountStatus? MountStatus { get; set; }

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
        NutanixVmMountStatus? MountStatus = null,
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
        if ( MountStatus != null ) {
            this.MountStatus = MountStatus;
        }
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> NutanixVmMountStatus? MountStatus
        // GraphQL -> mountStatus: NutanixVmMountStatus (enum)
        if (this.MountStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountStatus\n" ;
            } else {
                s += ind + "mountStatus\n" ;
            }
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmId\n" ;
            } else {
                s += ind + "cdmId\n" ;
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
        //      C# -> System.Boolean? IsMigrationDisabled
        // GraphQL -> isMigrationDisabled: Boolean! (scalar)
        if (this.IsMigrationDisabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isMigrationDisabled\n" ;
            } else {
                s += ind + "isMigrationDisabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsVmReady
        // GraphQL -> isVmReady: Boolean! (scalar)
        if (this.IsVmReady != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isVmReady\n" ;
            } else {
                s += ind + "isVmReady\n" ;
            }
        }
        //      C# -> System.String? MigrationJobInstanceId
        // GraphQL -> migrationJobInstanceId: String (scalar)
        if (this.MigrationJobInstanceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "migrationJobInstanceId\n" ;
            } else {
                s += ind + "migrationJobInstanceId\n" ;
            }
        }
        //      C# -> System.String? MigrationJobStatus
        // GraphQL -> migrationJobStatus: String (scalar)
        if (this.MigrationJobStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "migrationJobStatus\n" ;
            } else {
                s += ind + "migrationJobStatus\n" ;
            }
        }
        //      C# -> System.String? MountJobInstanceId
        // GraphQL -> mountJobInstanceId: String! (scalar)
        if (this.MountJobInstanceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountJobInstanceId\n" ;
            } else {
                s += ind + "mountJobInstanceId\n" ;
            }
        }
        //      C# -> System.String? MountSpec
        // GraphQL -> mountSpec: String! (scalar)
        if (this.MountSpec != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountSpec\n" ;
            } else {
                s += ind + "mountSpec\n" ;
            }
        }
        //      C# -> DateTime? MountedDate
        // GraphQL -> mountedDate: DateTime (scalar)
        if (this.MountedDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountedDate\n" ;
            } else {
                s += ind + "mountedDate\n" ;
            }
        }
        //      C# -> System.String? MountedVmFid
        // GraphQL -> mountedVmFid: String (scalar)
        if (this.MountedVmFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountedVmFid\n" ;
            } else {
                s += ind + "mountedVmFid\n" ;
            }
        }
        //      C# -> System.String? MountedVmId
        // GraphQL -> mountedVmId: String (scalar)
        if (this.MountedVmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountedVmId\n" ;
            } else {
                s += ind + "mountedVmId\n" ;
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
        //      C# -> System.String? NutanixClusterFid
        // GraphQL -> nutanixClusterFid: String! (scalar)
        if (this.NutanixClusterFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nutanixClusterFid\n" ;
            } else {
                s += ind + "nutanixClusterFid\n" ;
            }
        }
        //      C# -> System.String? NutanixClusterId
        // GraphQL -> nutanixClusterId: String! (scalar)
        if (this.NutanixClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nutanixClusterId\n" ;
            } else {
                s += ind + "nutanixClusterId\n" ;
            }
        }
        //      C# -> System.String? NutanixClusterName
        // GraphQL -> nutanixClusterName: String! (scalar)
        if (this.NutanixClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nutanixClusterName\n" ;
            } else {
                s += ind + "nutanixClusterName\n" ;
            }
        }
        //      C# -> System.String? OrganizationId
        // GraphQL -> organizationId: String! (scalar)
        if (this.OrganizationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "organizationId\n" ;
            } else {
                s += ind + "organizationId\n" ;
            }
        }
        //      C# -> System.String? OwnerId
        // GraphQL -> ownerId: String! (scalar)
        if (this.OwnerId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ownerId\n" ;
            } else {
                s += ind + "ownerId\n" ;
            }
        }
        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String! (scalar)
        if (this.PowerStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "powerStatus\n" ;
            } else {
                s += ind + "powerStatus\n" ;
            }
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        if (this.SnapshotDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotDate\n" ;
            } else {
                s += ind + "snapshotDate\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> System.String? SourceVmFid
        // GraphQL -> sourceVmFid: String! (scalar)
        if (this.SourceVmFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceVmFid\n" ;
            } else {
                s += ind + "sourceVmFid\n" ;
            }
        }
        //      C# -> System.String? SourceVmId
        // GraphQL -> sourceVmId: String! (scalar)
        if (this.SourceVmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceVmId\n" ;
            } else {
                s += ind + "sourceVmId\n" ;
            }
        }
        //      C# -> System.String? SourceVmName
        // GraphQL -> sourceVmName: String! (scalar)
        if (this.SourceVmName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceVmName\n" ;
            } else {
                s += ind + "sourceVmName\n" ;
            }
        }
        //      C# -> System.String? StorageContainerName
        // GraphQL -> storageContainerName: String (scalar)
        if (this.StorageContainerName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageContainerName\n" ;
            } else {
                s += ind + "storageContainerName\n" ;
            }
        }
        //      C# -> System.String? UnmountJobInstanceId
        // GraphQL -> unmountJobInstanceId: String! (scalar)
        if (this.UnmountJobInstanceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unmountJobInstanceId\n" ;
            } else {
                s += ind + "unmountJobInstanceId\n" ;
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        if (this.SourceSnapshot != null) {
            var fspec = this.SourceSnapshot.AsFieldSpec(conf.Child("sourceSnapshot"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceSnapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> NutanixVmMountStatus? MountStatus
        // GraphQL -> mountStatus: NutanixVmMountStatus (enum)
        if (ec.Includes("mountStatus",true))
        {
            if(this.MountStatus == null) {

                this.MountStatus = new NutanixVmMountStatus();

            } else {


            }
        }
        else if (this.MountStatus != null && ec.Excludes("mountStatus",true))
        {
            this.MountStatus = null;
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (ec.Includes("cdmId",true))
        {
            if(this.CdmId == null) {

                this.CdmId = "FETCH";

            } else {


            }
        }
        else if (this.CdmId != null && ec.Excludes("cdmId",true))
        {
            this.CdmId = null;
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
        //      C# -> System.Boolean? IsMigrationDisabled
        // GraphQL -> isMigrationDisabled: Boolean! (scalar)
        if (ec.Includes("isMigrationDisabled",true))
        {
            if(this.IsMigrationDisabled == null) {

                this.IsMigrationDisabled = true;

            } else {


            }
        }
        else if (this.IsMigrationDisabled != null && ec.Excludes("isMigrationDisabled",true))
        {
            this.IsMigrationDisabled = null;
        }
        //      C# -> System.Boolean? IsVmReady
        // GraphQL -> isVmReady: Boolean! (scalar)
        if (ec.Includes("isVmReady",true))
        {
            if(this.IsVmReady == null) {

                this.IsVmReady = true;

            } else {


            }
        }
        else if (this.IsVmReady != null && ec.Excludes("isVmReady",true))
        {
            this.IsVmReady = null;
        }
        //      C# -> System.String? MigrationJobInstanceId
        // GraphQL -> migrationJobInstanceId: String (scalar)
        if (ec.Includes("migrationJobInstanceId",true))
        {
            if(this.MigrationJobInstanceId == null) {

                this.MigrationJobInstanceId = "FETCH";

            } else {


            }
        }
        else if (this.MigrationJobInstanceId != null && ec.Excludes("migrationJobInstanceId",true))
        {
            this.MigrationJobInstanceId = null;
        }
        //      C# -> System.String? MigrationJobStatus
        // GraphQL -> migrationJobStatus: String (scalar)
        if (ec.Includes("migrationJobStatus",true))
        {
            if(this.MigrationJobStatus == null) {

                this.MigrationJobStatus = "FETCH";

            } else {


            }
        }
        else if (this.MigrationJobStatus != null && ec.Excludes("migrationJobStatus",true))
        {
            this.MigrationJobStatus = null;
        }
        //      C# -> System.String? MountJobInstanceId
        // GraphQL -> mountJobInstanceId: String! (scalar)
        if (ec.Includes("mountJobInstanceId",true))
        {
            if(this.MountJobInstanceId == null) {

                this.MountJobInstanceId = "FETCH";

            } else {


            }
        }
        else if (this.MountJobInstanceId != null && ec.Excludes("mountJobInstanceId",true))
        {
            this.MountJobInstanceId = null;
        }
        //      C# -> System.String? MountSpec
        // GraphQL -> mountSpec: String! (scalar)
        if (ec.Includes("mountSpec",true))
        {
            if(this.MountSpec == null) {

                this.MountSpec = "FETCH";

            } else {


            }
        }
        else if (this.MountSpec != null && ec.Excludes("mountSpec",true))
        {
            this.MountSpec = null;
        }
        //      C# -> DateTime? MountedDate
        // GraphQL -> mountedDate: DateTime (scalar)
        if (ec.Includes("mountedDate",true))
        {
            if(this.MountedDate == null) {

                this.MountedDate = new DateTime();

            } else {


            }
        }
        else if (this.MountedDate != null && ec.Excludes("mountedDate",true))
        {
            this.MountedDate = null;
        }
        //      C# -> System.String? MountedVmFid
        // GraphQL -> mountedVmFid: String (scalar)
        if (ec.Includes("mountedVmFid",true))
        {
            if(this.MountedVmFid == null) {

                this.MountedVmFid = "FETCH";

            } else {


            }
        }
        else if (this.MountedVmFid != null && ec.Excludes("mountedVmFid",true))
        {
            this.MountedVmFid = null;
        }
        //      C# -> System.String? MountedVmId
        // GraphQL -> mountedVmId: String (scalar)
        if (ec.Includes("mountedVmId",true))
        {
            if(this.MountedVmId == null) {

                this.MountedVmId = "FETCH";

            } else {


            }
        }
        else if (this.MountedVmId != null && ec.Excludes("mountedVmId",true))
        {
            this.MountedVmId = null;
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
        //      C# -> System.String? NutanixClusterFid
        // GraphQL -> nutanixClusterFid: String! (scalar)
        if (ec.Includes("nutanixClusterFid",true))
        {
            if(this.NutanixClusterFid == null) {

                this.NutanixClusterFid = "FETCH";

            } else {


            }
        }
        else if (this.NutanixClusterFid != null && ec.Excludes("nutanixClusterFid",true))
        {
            this.NutanixClusterFid = null;
        }
        //      C# -> System.String? NutanixClusterId
        // GraphQL -> nutanixClusterId: String! (scalar)
        if (ec.Includes("nutanixClusterId",true))
        {
            if(this.NutanixClusterId == null) {

                this.NutanixClusterId = "FETCH";

            } else {


            }
        }
        else if (this.NutanixClusterId != null && ec.Excludes("nutanixClusterId",true))
        {
            this.NutanixClusterId = null;
        }
        //      C# -> System.String? NutanixClusterName
        // GraphQL -> nutanixClusterName: String! (scalar)
        if (ec.Includes("nutanixClusterName",true))
        {
            if(this.NutanixClusterName == null) {

                this.NutanixClusterName = "FETCH";

            } else {


            }
        }
        else if (this.NutanixClusterName != null && ec.Excludes("nutanixClusterName",true))
        {
            this.NutanixClusterName = null;
        }
        //      C# -> System.String? OrganizationId
        // GraphQL -> organizationId: String! (scalar)
        if (ec.Includes("organizationId",true))
        {
            if(this.OrganizationId == null) {

                this.OrganizationId = "FETCH";

            } else {


            }
        }
        else if (this.OrganizationId != null && ec.Excludes("organizationId",true))
        {
            this.OrganizationId = null;
        }
        //      C# -> System.String? OwnerId
        // GraphQL -> ownerId: String! (scalar)
        if (ec.Includes("ownerId",true))
        {
            if(this.OwnerId == null) {

                this.OwnerId = "FETCH";

            } else {


            }
        }
        else if (this.OwnerId != null && ec.Excludes("ownerId",true))
        {
            this.OwnerId = null;
        }
        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String! (scalar)
        if (ec.Includes("powerStatus",true))
        {
            if(this.PowerStatus == null) {

                this.PowerStatus = "FETCH";

            } else {


            }
        }
        else if (this.PowerStatus != null && ec.Excludes("powerStatus",true))
        {
            this.PowerStatus = null;
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        if (ec.Includes("snapshotDate",true))
        {
            if(this.SnapshotDate == null) {

                this.SnapshotDate = new DateTime();

            } else {


            }
        }
        else if (this.SnapshotDate != null && ec.Excludes("snapshotDate",true))
        {
            this.SnapshotDate = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> System.String? SourceVmFid
        // GraphQL -> sourceVmFid: String! (scalar)
        if (ec.Includes("sourceVmFid",true))
        {
            if(this.SourceVmFid == null) {

                this.SourceVmFid = "FETCH";

            } else {


            }
        }
        else if (this.SourceVmFid != null && ec.Excludes("sourceVmFid",true))
        {
            this.SourceVmFid = null;
        }
        //      C# -> System.String? SourceVmId
        // GraphQL -> sourceVmId: String! (scalar)
        if (ec.Includes("sourceVmId",true))
        {
            if(this.SourceVmId == null) {

                this.SourceVmId = "FETCH";

            } else {


            }
        }
        else if (this.SourceVmId != null && ec.Excludes("sourceVmId",true))
        {
            this.SourceVmId = null;
        }
        //      C# -> System.String? SourceVmName
        // GraphQL -> sourceVmName: String! (scalar)
        if (ec.Includes("sourceVmName",true))
        {
            if(this.SourceVmName == null) {

                this.SourceVmName = "FETCH";

            } else {


            }
        }
        else if (this.SourceVmName != null && ec.Excludes("sourceVmName",true))
        {
            this.SourceVmName = null;
        }
        //      C# -> System.String? StorageContainerName
        // GraphQL -> storageContainerName: String (scalar)
        if (ec.Includes("storageContainerName",true))
        {
            if(this.StorageContainerName == null) {

                this.StorageContainerName = "FETCH";

            } else {


            }
        }
        else if (this.StorageContainerName != null && ec.Excludes("storageContainerName",true))
        {
            this.StorageContainerName = null;
        }
        //      C# -> System.String? UnmountJobInstanceId
        // GraphQL -> unmountJobInstanceId: String! (scalar)
        if (ec.Includes("unmountJobInstanceId",true))
        {
            if(this.UnmountJobInstanceId == null) {

                this.UnmountJobInstanceId = "FETCH";

            } else {


            }
        }
        else if (this.UnmountJobInstanceId != null && ec.Excludes("unmountJobInstanceId",true))
        {
            this.UnmountJobInstanceId = null;
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
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        if (ec.Includes("sourceSnapshot",false))
        {
            if(this.SourceSnapshot == null) {

                this.SourceSnapshot = new CdmSnapshot();
                this.SourceSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("sourceSnapshot"));

            } else {

                this.SourceSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("sourceSnapshot"));

            }
        }
        else if (this.SourceSnapshot != null && ec.Excludes("sourceSnapshot",false))
        {
            this.SourceSnapshot = null;
        }
    }


    #endregion

    } // class NutanixLiveMount
    
    #endregion

    public static class ListNutanixLiveMountExtensions
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
            this List<NutanixLiveMount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NutanixLiveMount> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NutanixLiveMount> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixLiveMount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NutanixLiveMount> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types