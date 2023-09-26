// NutanixVmMountSummary.cs
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
    #region NutanixVmMountSummary
    public class NutanixVmMountSummary: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        [JsonProperty("isReady")]
        public System.Boolean? IsReady { get; set; }

        //      C# -> System.String? MigrationStatus
        // GraphQL -> migrationStatus: String (scalar)
        [JsonProperty("migrationStatus")]
        public System.String? MigrationStatus { get; set; }

        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        [JsonProperty("mountRequestId")]
        public System.String? MountRequestId { get; set; }

        //      C# -> System.String? MountStatus
        // GraphQL -> mountStatus: String (scalar)
        [JsonProperty("mountStatus")]
        public System.String? MountStatus { get; set; }

        //      C# -> DateTime? MountedDate
        // GraphQL -> mountedDate: DateTime (scalar)
        [JsonProperty("mountedDate")]
        public DateTime? MountedDate { get; set; }

        //      C# -> System.String? MountedVmId
        // GraphQL -> mountedVmId: String (scalar)
        [JsonProperty("mountedVmId")]
        public System.String? MountedVmId { get; set; }

        //      C# -> System.String? MountedVmIpAddress
        // GraphQL -> mountedVmIpAddress: String (scalar)
        [JsonProperty("mountedVmIpAddress")]
        public System.String? MountedVmIpAddress { get; set; }

        //      C# -> System.String? MountedVmName
        // GraphQL -> mountedVmName: String (scalar)
        [JsonProperty("mountedVmName")]
        public System.String? MountedVmName { get; set; }

        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String (scalar)
        [JsonProperty("powerStatus")]
        public System.String? PowerStatus { get; set; }

        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        [JsonProperty("snapshotDate")]
        public DateTime? SnapshotDate { get; set; }

        //      C# -> System.String? StorageContainerName
        // GraphQL -> storageContainerName: String (scalar)
        [JsonProperty("storageContainerName")]
        public System.String? StorageContainerName { get; set; }

        //      C# -> System.String? TargetNutanixClusterId
        // GraphQL -> targetNutanixClusterId: String! (scalar)
        [JsonProperty("targetNutanixClusterId")]
        public System.String? TargetNutanixClusterId { get; set; }

        //      C# -> System.String? TargetNutanixClusterName
        // GraphQL -> targetNutanixClusterName: String (scalar)
        [JsonProperty("targetNutanixClusterName")]
        public System.String? TargetNutanixClusterName { get; set; }

        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String (scalar)
        [JsonProperty("unmountRequestId")]
        public System.String? UnmountRequestId { get; set; }

        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        [JsonProperty("vmId")]
        public System.String? VmId { get; set; }

        //      C# -> System.String? VmName
        // GraphQL -> vmName: String (scalar)
        [JsonProperty("vmName")]
        public System.String? VmName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NutanixVmMountSummary";
    }

    public NutanixVmMountSummary Set(
        System.String? Id = null,
        System.Boolean? IsReady = null,
        System.String? MigrationStatus = null,
        System.String? MountRequestId = null,
        System.String? MountStatus = null,
        DateTime? MountedDate = null,
        System.String? MountedVmId = null,
        System.String? MountedVmIpAddress = null,
        System.String? MountedVmName = null,
        System.String? PowerStatus = null,
        DateTime? SnapshotDate = null,
        System.String? StorageContainerName = null,
        System.String? TargetNutanixClusterId = null,
        System.String? TargetNutanixClusterName = null,
        System.String? UnmountRequestId = null,
        System.String? VmId = null,
        System.String? VmName = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsReady != null ) {
            this.IsReady = IsReady;
        }
        if ( MigrationStatus != null ) {
            this.MigrationStatus = MigrationStatus;
        }
        if ( MountRequestId != null ) {
            this.MountRequestId = MountRequestId;
        }
        if ( MountStatus != null ) {
            this.MountStatus = MountStatus;
        }
        if ( MountedDate != null ) {
            this.MountedDate = MountedDate;
        }
        if ( MountedVmId != null ) {
            this.MountedVmId = MountedVmId;
        }
        if ( MountedVmIpAddress != null ) {
            this.MountedVmIpAddress = MountedVmIpAddress;
        }
        if ( MountedVmName != null ) {
            this.MountedVmName = MountedVmName;
        }
        if ( PowerStatus != null ) {
            this.PowerStatus = PowerStatus;
        }
        if ( SnapshotDate != null ) {
            this.SnapshotDate = SnapshotDate;
        }
        if ( StorageContainerName != null ) {
            this.StorageContainerName = StorageContainerName;
        }
        if ( TargetNutanixClusterId != null ) {
            this.TargetNutanixClusterId = TargetNutanixClusterId;
        }
        if ( TargetNutanixClusterName != null ) {
            this.TargetNutanixClusterName = TargetNutanixClusterName;
        }
        if ( UnmountRequestId != null ) {
            this.UnmountRequestId = UnmountRequestId;
        }
        if ( VmId != null ) {
            this.VmId = VmId;
        }
        if ( VmName != null ) {
            this.VmName = VmName;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (this.IsReady != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isReady\n" ;
            } else {
                s += ind + "isReady\n" ;
            }
        }
        //      C# -> System.String? MigrationStatus
        // GraphQL -> migrationStatus: String (scalar)
        if (this.MigrationStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "migrationStatus\n" ;
            } else {
                s += ind + "migrationStatus\n" ;
            }
        }
        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        if (this.MountRequestId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountRequestId\n" ;
            } else {
                s += ind + "mountRequestId\n" ;
            }
        }
        //      C# -> System.String? MountStatus
        // GraphQL -> mountStatus: String (scalar)
        if (this.MountStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountStatus\n" ;
            } else {
                s += ind + "mountStatus\n" ;
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
        //      C# -> System.String? MountedVmId
        // GraphQL -> mountedVmId: String (scalar)
        if (this.MountedVmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountedVmId\n" ;
            } else {
                s += ind + "mountedVmId\n" ;
            }
        }
        //      C# -> System.String? MountedVmIpAddress
        // GraphQL -> mountedVmIpAddress: String (scalar)
        if (this.MountedVmIpAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountedVmIpAddress\n" ;
            } else {
                s += ind + "mountedVmIpAddress\n" ;
            }
        }
        //      C# -> System.String? MountedVmName
        // GraphQL -> mountedVmName: String (scalar)
        if (this.MountedVmName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountedVmName\n" ;
            } else {
                s += ind + "mountedVmName\n" ;
            }
        }
        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String (scalar)
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
        //      C# -> System.String? StorageContainerName
        // GraphQL -> storageContainerName: String (scalar)
        if (this.StorageContainerName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageContainerName\n" ;
            } else {
                s += ind + "storageContainerName\n" ;
            }
        }
        //      C# -> System.String? TargetNutanixClusterId
        // GraphQL -> targetNutanixClusterId: String! (scalar)
        if (this.TargetNutanixClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetNutanixClusterId\n" ;
            } else {
                s += ind + "targetNutanixClusterId\n" ;
            }
        }
        //      C# -> System.String? TargetNutanixClusterName
        // GraphQL -> targetNutanixClusterName: String (scalar)
        if (this.TargetNutanixClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetNutanixClusterName\n" ;
            } else {
                s += ind + "targetNutanixClusterName\n" ;
            }
        }
        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String (scalar)
        if (this.UnmountRequestId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unmountRequestId\n" ;
            } else {
                s += ind + "unmountRequestId\n" ;
            }
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (this.VmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmId\n" ;
            } else {
                s += ind + "vmId\n" ;
            }
        }
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String (scalar)
        if (this.VmName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmName\n" ;
            } else {
                s += ind + "vmName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
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
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (ec.Includes("isReady",true))
        {
            if(this.IsReady == null) {

                this.IsReady = true;

            } else {


            }
        }
        else if (this.IsReady != null && ec.Excludes("isReady",true))
        {
            this.IsReady = null;
        }
        //      C# -> System.String? MigrationStatus
        // GraphQL -> migrationStatus: String (scalar)
        if (ec.Includes("migrationStatus",true))
        {
            if(this.MigrationStatus == null) {

                this.MigrationStatus = "FETCH";

            } else {


            }
        }
        else if (this.MigrationStatus != null && ec.Excludes("migrationStatus",true))
        {
            this.MigrationStatus = null;
        }
        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        if (ec.Includes("mountRequestId",true))
        {
            if(this.MountRequestId == null) {

                this.MountRequestId = "FETCH";

            } else {


            }
        }
        else if (this.MountRequestId != null && ec.Excludes("mountRequestId",true))
        {
            this.MountRequestId = null;
        }
        //      C# -> System.String? MountStatus
        // GraphQL -> mountStatus: String (scalar)
        if (ec.Includes("mountStatus",true))
        {
            if(this.MountStatus == null) {

                this.MountStatus = "FETCH";

            } else {


            }
        }
        else if (this.MountStatus != null && ec.Excludes("mountStatus",true))
        {
            this.MountStatus = null;
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
        //      C# -> System.String? MountedVmIpAddress
        // GraphQL -> mountedVmIpAddress: String (scalar)
        if (ec.Includes("mountedVmIpAddress",true))
        {
            if(this.MountedVmIpAddress == null) {

                this.MountedVmIpAddress = "FETCH";

            } else {


            }
        }
        else if (this.MountedVmIpAddress != null && ec.Excludes("mountedVmIpAddress",true))
        {
            this.MountedVmIpAddress = null;
        }
        //      C# -> System.String? MountedVmName
        // GraphQL -> mountedVmName: String (scalar)
        if (ec.Includes("mountedVmName",true))
        {
            if(this.MountedVmName == null) {

                this.MountedVmName = "FETCH";

            } else {


            }
        }
        else if (this.MountedVmName != null && ec.Excludes("mountedVmName",true))
        {
            this.MountedVmName = null;
        }
        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String (scalar)
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
        //      C# -> System.String? TargetNutanixClusterId
        // GraphQL -> targetNutanixClusterId: String! (scalar)
        if (ec.Includes("targetNutanixClusterId",true))
        {
            if(this.TargetNutanixClusterId == null) {

                this.TargetNutanixClusterId = "FETCH";

            } else {


            }
        }
        else if (this.TargetNutanixClusterId != null && ec.Excludes("targetNutanixClusterId",true))
        {
            this.TargetNutanixClusterId = null;
        }
        //      C# -> System.String? TargetNutanixClusterName
        // GraphQL -> targetNutanixClusterName: String (scalar)
        if (ec.Includes("targetNutanixClusterName",true))
        {
            if(this.TargetNutanixClusterName == null) {

                this.TargetNutanixClusterName = "FETCH";

            } else {


            }
        }
        else if (this.TargetNutanixClusterName != null && ec.Excludes("targetNutanixClusterName",true))
        {
            this.TargetNutanixClusterName = null;
        }
        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String (scalar)
        if (ec.Includes("unmountRequestId",true))
        {
            if(this.UnmountRequestId == null) {

                this.UnmountRequestId = "FETCH";

            } else {


            }
        }
        else if (this.UnmountRequestId != null && ec.Excludes("unmountRequestId",true))
        {
            this.UnmountRequestId = null;
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (ec.Includes("vmId",true))
        {
            if(this.VmId == null) {

                this.VmId = "FETCH";

            } else {


            }
        }
        else if (this.VmId != null && ec.Excludes("vmId",true))
        {
            this.VmId = null;
        }
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String (scalar)
        if (ec.Includes("vmName",true))
        {
            if(this.VmName == null) {

                this.VmName = "FETCH";

            } else {


            }
        }
        else if (this.VmName != null && ec.Excludes("vmName",true))
        {
            this.VmName = null;
        }
    }


    #endregion

    } // class NutanixVmMountSummary
    
    #endregion

    public static class ListNutanixVmMountSummaryExtensions
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
            this List<NutanixVmMountSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NutanixVmMountSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixVmMountSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NutanixVmMountSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types