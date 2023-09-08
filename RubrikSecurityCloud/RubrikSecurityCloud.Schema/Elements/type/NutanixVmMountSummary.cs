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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (this.IsReady != null) {
            s += ind + "isReady\n" ;
        }
        //      C# -> System.String? MigrationStatus
        // GraphQL -> migrationStatus: String (scalar)
        if (this.MigrationStatus != null) {
            s += ind + "migrationStatus\n" ;
        }
        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        if (this.MountRequestId != null) {
            s += ind + "mountRequestId\n" ;
        }
        //      C# -> DateTime? MountedDate
        // GraphQL -> mountedDate: DateTime (scalar)
        if (this.MountedDate != null) {
            s += ind + "mountedDate\n" ;
        }
        //      C# -> System.String? MountedVmId
        // GraphQL -> mountedVmId: String (scalar)
        if (this.MountedVmId != null) {
            s += ind + "mountedVmId\n" ;
        }
        //      C# -> System.String? MountedVmIpAddress
        // GraphQL -> mountedVmIpAddress: String (scalar)
        if (this.MountedVmIpAddress != null) {
            s += ind + "mountedVmIpAddress\n" ;
        }
        //      C# -> System.String? MountedVmName
        // GraphQL -> mountedVmName: String (scalar)
        if (this.MountedVmName != null) {
            s += ind + "mountedVmName\n" ;
        }
        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String (scalar)
        if (this.PowerStatus != null) {
            s += ind + "powerStatus\n" ;
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        if (this.SnapshotDate != null) {
            s += ind + "snapshotDate\n" ;
        }
        //      C# -> System.String? StorageContainerName
        // GraphQL -> storageContainerName: String (scalar)
        if (this.StorageContainerName != null) {
            s += ind + "storageContainerName\n" ;
        }
        //      C# -> System.String? TargetNutanixClusterId
        // GraphQL -> targetNutanixClusterId: String! (scalar)
        if (this.TargetNutanixClusterId != null) {
            s += ind + "targetNutanixClusterId\n" ;
        }
        //      C# -> System.String? TargetNutanixClusterName
        // GraphQL -> targetNutanixClusterName: String (scalar)
        if (this.TargetNutanixClusterName != null) {
            s += ind + "targetNutanixClusterName\n" ;
        }
        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String (scalar)
        if (this.UnmountRequestId != null) {
            s += ind + "unmountRequestId\n" ;
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (this.VmId != null) {
            s += ind + "vmId\n" ;
        }
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String (scalar)
        if (this.VmName != null) {
            s += ind + "vmName\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (this.IsReady == null && ec.Includes("isReady",true))
        {
            this.IsReady = true;
        }
        //      C# -> System.String? MigrationStatus
        // GraphQL -> migrationStatus: String (scalar)
        if (this.MigrationStatus == null && ec.Includes("migrationStatus",true))
        {
            this.MigrationStatus = "FETCH";
        }
        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        if (this.MountRequestId == null && ec.Includes("mountRequestId",true))
        {
            this.MountRequestId = "FETCH";
        }
        //      C# -> DateTime? MountedDate
        // GraphQL -> mountedDate: DateTime (scalar)
        if (this.MountedDate == null && ec.Includes("mountedDate",true))
        {
            this.MountedDate = new DateTime();
        }
        //      C# -> System.String? MountedVmId
        // GraphQL -> mountedVmId: String (scalar)
        if (this.MountedVmId == null && ec.Includes("mountedVmId",true))
        {
            this.MountedVmId = "FETCH";
        }
        //      C# -> System.String? MountedVmIpAddress
        // GraphQL -> mountedVmIpAddress: String (scalar)
        if (this.MountedVmIpAddress == null && ec.Includes("mountedVmIpAddress",true))
        {
            this.MountedVmIpAddress = "FETCH";
        }
        //      C# -> System.String? MountedVmName
        // GraphQL -> mountedVmName: String (scalar)
        if (this.MountedVmName == null && ec.Includes("mountedVmName",true))
        {
            this.MountedVmName = "FETCH";
        }
        //      C# -> System.String? PowerStatus
        // GraphQL -> powerStatus: String (scalar)
        if (this.PowerStatus == null && ec.Includes("powerStatus",true))
        {
            this.PowerStatus = "FETCH";
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        if (this.SnapshotDate == null && ec.Includes("snapshotDate",true))
        {
            this.SnapshotDate = new DateTime();
        }
        //      C# -> System.String? StorageContainerName
        // GraphQL -> storageContainerName: String (scalar)
        if (this.StorageContainerName == null && ec.Includes("storageContainerName",true))
        {
            this.StorageContainerName = "FETCH";
        }
        //      C# -> System.String? TargetNutanixClusterId
        // GraphQL -> targetNutanixClusterId: String! (scalar)
        if (this.TargetNutanixClusterId == null && ec.Includes("targetNutanixClusterId",true))
        {
            this.TargetNutanixClusterId = "FETCH";
        }
        //      C# -> System.String? TargetNutanixClusterName
        // GraphQL -> targetNutanixClusterName: String (scalar)
        if (this.TargetNutanixClusterName == null && ec.Includes("targetNutanixClusterName",true))
        {
            this.TargetNutanixClusterName = "FETCH";
        }
        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String (scalar)
        if (this.UnmountRequestId == null && ec.Includes("unmountRequestId",true))
        {
            this.UnmountRequestId = "FETCH";
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (this.VmId == null && ec.Includes("vmId",true))
        {
            this.VmId = "FETCH";
        }
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String (scalar)
        if (this.VmName == null && ec.Includes("vmName",true))
        {
            this.VmName = "FETCH";
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<NutanixVmMountSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types