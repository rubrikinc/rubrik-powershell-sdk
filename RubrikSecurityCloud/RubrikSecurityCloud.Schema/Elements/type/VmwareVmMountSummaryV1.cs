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

    public override string GetGqlTypeName() {
        return "VmwareVmMountSummaryV1";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int32? AttachingDiskCount
        // GraphQL -> attachingDiskCount: Int (scalar)
        if (this.AttachingDiskCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "attachingDiskCount\n" ;
            } else {
                s += ind + "attachingDiskCount\n" ;
            }
        }
        //      C# -> System.Boolean? CreateDatastoreOnlyMount
        // GraphQL -> createDatastoreOnlyMount: Boolean (scalar)
        if (this.CreateDatastoreOnlyMount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createDatastoreOnlyMount\n" ;
            } else {
                s += ind + "createDatastoreOnlyMount\n" ;
            }
        }
        //      C# -> System.String? DatastoreName
        // GraphQL -> datastoreName: String (scalar)
        if (this.DatastoreName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "datastoreName\n" ;
            } else {
                s += ind + "datastoreName\n" ;
            }
        }
        //      C# -> System.Boolean? DatastoreReady
        // GraphQL -> datastoreReady: Boolean (scalar)
        if (this.DatastoreReady != null) {
            if (conf.Flat) {
                s += conf.Prefix + "datastoreReady\n" ;
            } else {
                s += ind + "datastoreReady\n" ;
            }
        }
        //      C# -> System.Boolean? HasAttachingDisk
        // GraphQL -> hasAttachingDisk: Boolean (scalar)
        if (this.HasAttachingDisk != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasAttachingDisk\n" ;
            } else {
                s += ind + "hasAttachingDisk\n" ;
            }
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        if (this.HostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostId\n" ;
            } else {
                s += ind + "hostId\n" ;
            }
        }
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
        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        if (this.MountRequestId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountRequestId\n" ;
            } else {
                s += ind + "mountRequestId\n" ;
            }
        }
        //      C# -> DateTime? MountTimestamp
        // GraphQL -> mountTimestamp: DateTime (scalar)
        if (this.MountTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountTimestamp\n" ;
            } else {
                s += ind + "mountTimestamp\n" ;
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
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        if (this.SnapshotDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotDate\n" ;
            } else {
                s += ind + "snapshotDate\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? AttachingDiskCount
        // GraphQL -> attachingDiskCount: Int (scalar)
        if (ec.Includes("attachingDiskCount",true))
        {
            if(this.AttachingDiskCount == null) {

                this.AttachingDiskCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.AttachingDiskCount != null && ec.Excludes("attachingDiskCount",true))
        {
            this.AttachingDiskCount = null;
        }
        //      C# -> System.Boolean? CreateDatastoreOnlyMount
        // GraphQL -> createDatastoreOnlyMount: Boolean (scalar)
        if (ec.Includes("createDatastoreOnlyMount",true))
        {
            if(this.CreateDatastoreOnlyMount == null) {

                this.CreateDatastoreOnlyMount = true;

            } else {


            }
        }
        else if (this.CreateDatastoreOnlyMount != null && ec.Excludes("createDatastoreOnlyMount",true))
        {
            this.CreateDatastoreOnlyMount = null;
        }
        //      C# -> System.String? DatastoreName
        // GraphQL -> datastoreName: String (scalar)
        if (ec.Includes("datastoreName",true))
        {
            if(this.DatastoreName == null) {

                this.DatastoreName = "FETCH";

            } else {


            }
        }
        else if (this.DatastoreName != null && ec.Excludes("datastoreName",true))
        {
            this.DatastoreName = null;
        }
        //      C# -> System.Boolean? DatastoreReady
        // GraphQL -> datastoreReady: Boolean (scalar)
        if (ec.Includes("datastoreReady",true))
        {
            if(this.DatastoreReady == null) {

                this.DatastoreReady = true;

            } else {


            }
        }
        else if (this.DatastoreReady != null && ec.Excludes("datastoreReady",true))
        {
            this.DatastoreReady = null;
        }
        //      C# -> System.Boolean? HasAttachingDisk
        // GraphQL -> hasAttachingDisk: Boolean (scalar)
        if (ec.Includes("hasAttachingDisk",true))
        {
            if(this.HasAttachingDisk == null) {

                this.HasAttachingDisk = true;

            } else {


            }
        }
        else if (this.HasAttachingDisk != null && ec.Excludes("hasAttachingDisk",true))
        {
            this.HasAttachingDisk = null;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        if (ec.Includes("hostId",true))
        {
            if(this.HostId == null) {

                this.HostId = "FETCH";

            } else {


            }
        }
        else if (this.HostId != null && ec.Excludes("hostId",true))
        {
            this.HostId = null;
        }
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
        //      C# -> DateTime? MountTimestamp
        // GraphQL -> mountTimestamp: DateTime (scalar)
        if (ec.Includes("mountTimestamp",true))
        {
            if(this.MountTimestamp == null) {

                this.MountTimestamp = new DateTime();

            } else {


            }
        }
        else if (this.MountTimestamp != null && ec.Excludes("mountTimestamp",true))
        {
            this.MountTimestamp = null;
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
    }


    #endregion

    } // class VmwareVmMountSummaryV1
    
    #endregion

    public static class ListVmwareVmMountSummaryV1Extensions
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
            this List<VmwareVmMountSummaryV1> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VmwareVmMountSummaryV1> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VmwareVmMountSummaryV1> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareVmMountSummaryV1());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmwareVmMountSummaryV1> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types