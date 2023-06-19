// VmwareVmMountSummaryV1.cs
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
    #region VmwareVmMountSummaryV1
    public class VmwareVmMountSummaryV1: BaseType
    {
        #region members

        //      C# -> System.Int32? AttachingDiskCount
        // GraphQL -> attachingDiskCount: Int (scalar)
        [JsonProperty("attachingDiskCount")]
        public System.Int32? AttachingDiskCount { get; set; }

        //      C# -> System.Boolean? CreateDatastoreOnlyMount
        // GraphQL -> createDatastoreOnlyMount: Boolean (scalar)
        [JsonProperty("createDatastoreOnlyMount")]
        public System.Boolean? CreateDatastoreOnlyMount { get; set; }

        //      C# -> System.String? DatastoreName
        // GraphQL -> datastoreName: String (scalar)
        [JsonProperty("datastoreName")]
        public System.String? DatastoreName { get; set; }

        //      C# -> System.Boolean? DatastoreReady
        // GraphQL -> datastoreReady: Boolean (scalar)
        [JsonProperty("datastoreReady")]
        public System.Boolean? DatastoreReady { get; set; }

        //      C# -> System.Boolean? HasAttachingDisk
        // GraphQL -> hasAttachingDisk: Boolean (scalar)
        [JsonProperty("hasAttachingDisk")]
        public System.Boolean? HasAttachingDisk { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        [JsonProperty("isReady")]
        public System.Boolean? IsReady { get; set; }

        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        [JsonProperty("mountRequestId")]
        public System.String? MountRequestId { get; set; }

        //      C# -> DateTime? MountTimestamp
        // GraphQL -> mountTimestamp: DateTime (scalar)
        [JsonProperty("mountTimestamp")]
        public DateTime? MountTimestamp { get; set; }

        //      C# -> System.String? MountedVmId
        // GraphQL -> mountedVmId: String (scalar)
        [JsonProperty("mountedVmId")]
        public System.String? MountedVmId { get; set; }

        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        [JsonProperty("snapshotDate")]
        public DateTime? SnapshotDate { get; set; }

        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String (scalar)
        [JsonProperty("unmountRequestId")]
        public System.String? UnmountRequestId { get; set; }

        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        [JsonProperty("vmId")]
        public System.String? VmId { get; set; }


        #endregion

    #region methods

    public VmwareVmMountSummaryV1 Set(
        System.Int32? AttachingDiskCount = null,
        System.Boolean? CreateDatastoreOnlyMount = null,
        System.String? DatastoreName = null,
        System.Boolean? DatastoreReady = null,
        System.Boolean? HasAttachingDisk = null,
        System.String? HostId = null,
        System.String? Id = null,
        System.Boolean? IsReady = null,
        System.String? MountRequestId = null,
        DateTime? MountTimestamp = null,
        System.String? MountedVmId = null,
        DateTime? SnapshotDate = null,
        System.String? UnmountRequestId = null,
        System.String? VmId = null
    ) 
    {
        if ( AttachingDiskCount != null ) {
            this.AttachingDiskCount = AttachingDiskCount;
        }
        if ( CreateDatastoreOnlyMount != null ) {
            this.CreateDatastoreOnlyMount = CreateDatastoreOnlyMount;
        }
        if ( DatastoreName != null ) {
            this.DatastoreName = DatastoreName;
        }
        if ( DatastoreReady != null ) {
            this.DatastoreReady = DatastoreReady;
        }
        if ( HasAttachingDisk != null ) {
            this.HasAttachingDisk = HasAttachingDisk;
        }
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsReady != null ) {
            this.IsReady = IsReady;
        }
        if ( MountRequestId != null ) {
            this.MountRequestId = MountRequestId;
        }
        if ( MountTimestamp != null ) {
            this.MountTimestamp = MountTimestamp;
        }
        if ( MountedVmId != null ) {
            this.MountedVmId = MountedVmId;
        }
        if ( SnapshotDate != null ) {
            this.SnapshotDate = SnapshotDate;
        }
        if ( UnmountRequestId != null ) {
            this.UnmountRequestId = UnmountRequestId;
        }
        if ( VmId != null ) {
            this.VmId = VmId;
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
        //      C# -> System.Int32? AttachingDiskCount
        // GraphQL -> attachingDiskCount: Int (scalar)
        if (this.AttachingDiskCount != null) {
            s += ind + "attachingDiskCount\n" ;
        }
        //      C# -> System.Boolean? CreateDatastoreOnlyMount
        // GraphQL -> createDatastoreOnlyMount: Boolean (scalar)
        if (this.CreateDatastoreOnlyMount != null) {
            s += ind + "createDatastoreOnlyMount\n" ;
        }
        //      C# -> System.String? DatastoreName
        // GraphQL -> datastoreName: String (scalar)
        if (this.DatastoreName != null) {
            s += ind + "datastoreName\n" ;
        }
        //      C# -> System.Boolean? DatastoreReady
        // GraphQL -> datastoreReady: Boolean (scalar)
        if (this.DatastoreReady != null) {
            s += ind + "datastoreReady\n" ;
        }
        //      C# -> System.Boolean? HasAttachingDisk
        // GraphQL -> hasAttachingDisk: Boolean (scalar)
        if (this.HasAttachingDisk != null) {
            s += ind + "hasAttachingDisk\n" ;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        if (this.HostId != null) {
            s += ind + "hostId\n" ;
        }
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
        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        if (this.MountRequestId != null) {
            s += ind + "mountRequestId\n" ;
        }
        //      C# -> DateTime? MountTimestamp
        // GraphQL -> mountTimestamp: DateTime (scalar)
        if (this.MountTimestamp != null) {
            s += ind + "mountTimestamp\n" ;
        }
        //      C# -> System.String? MountedVmId
        // GraphQL -> mountedVmId: String (scalar)
        if (this.MountedVmId != null) {
            s += ind + "mountedVmId\n" ;
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        if (this.SnapshotDate != null) {
            s += ind + "snapshotDate\n" ;
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
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? AttachingDiskCount
        // GraphQL -> attachingDiskCount: Int (scalar)
        if (this.AttachingDiskCount == null && Exploration.Includes(parent + ".attachingDiskCount", true))
        {
            this.AttachingDiskCount = Int32.MinValue;
        }
        //      C# -> System.Boolean? CreateDatastoreOnlyMount
        // GraphQL -> createDatastoreOnlyMount: Boolean (scalar)
        if (this.CreateDatastoreOnlyMount == null && Exploration.Includes(parent + ".createDatastoreOnlyMount", true))
        {
            this.CreateDatastoreOnlyMount = true;
        }
        //      C# -> System.String? DatastoreName
        // GraphQL -> datastoreName: String (scalar)
        if (this.DatastoreName == null && Exploration.Includes(parent + ".datastoreName", true))
        {
            this.DatastoreName = "FETCH";
        }
        //      C# -> System.Boolean? DatastoreReady
        // GraphQL -> datastoreReady: Boolean (scalar)
        if (this.DatastoreReady == null && Exploration.Includes(parent + ".datastoreReady", true))
        {
            this.DatastoreReady = true;
        }
        //      C# -> System.Boolean? HasAttachingDisk
        // GraphQL -> hasAttachingDisk: Boolean (scalar)
        if (this.HasAttachingDisk == null && Exploration.Includes(parent + ".hasAttachingDisk", true))
        {
            this.HasAttachingDisk = true;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        if (this.HostId == null && Exploration.Includes(parent + ".hostId", true))
        {
            this.HostId = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (this.IsReady == null && Exploration.Includes(parent + ".isReady", true))
        {
            this.IsReady = true;
        }
        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        if (this.MountRequestId == null && Exploration.Includes(parent + ".mountRequestId", true))
        {
            this.MountRequestId = "FETCH";
        }
        //      C# -> DateTime? MountTimestamp
        // GraphQL -> mountTimestamp: DateTime (scalar)
        if (this.MountTimestamp == null && Exploration.Includes(parent + ".mountTimestamp", true))
        {
            this.MountTimestamp = new DateTime();
        }
        //      C# -> System.String? MountedVmId
        // GraphQL -> mountedVmId: String (scalar)
        if (this.MountedVmId == null && Exploration.Includes(parent + ".mountedVmId", true))
        {
            this.MountedVmId = "FETCH";
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        if (this.SnapshotDate == null && Exploration.Includes(parent + ".snapshotDate", true))
        {
            this.SnapshotDate = new DateTime();
        }
        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String (scalar)
        if (this.UnmountRequestId == null && Exploration.Includes(parent + ".unmountRequestId", true))
        {
            this.UnmountRequestId = "FETCH";
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        if (this.VmId == null && Exploration.Includes(parent + ".vmId", true))
        {
            this.VmId = "FETCH";
        }
    }


    #endregion

    } // class VmwareVmMountSummaryV1
    
    #endregion

    public static class ListVmwareVmMountSummaryV1Extensions
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
            this List<VmwareVmMountSummaryV1> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmwareVmMountSummaryV1> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareVmMountSummaryV1());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types