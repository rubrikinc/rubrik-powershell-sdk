// HypervVirtualMachineMountSummary.cs
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
    #region HypervVirtualMachineMountSummary
    public class HypervVirtualMachineMountSummary: BaseType
    {
        #region members

        //      C# -> HypervVirtualMachineMountSummaryPowerStatus? PowerStatus
        // GraphQL -> powerStatus: HypervVirtualMachineMountSummaryPowerStatus! (enum)
        [JsonProperty("powerStatus")]
        public HypervVirtualMachineMountSummaryPowerStatus? PowerStatus { get; set; }

        //      C# -> System.Int32? AttachedDiskCount
        // GraphQL -> attachedDiskCount: Int (scalar)
        [JsonProperty("attachedDiskCount")]
        public System.Int32? AttachedDiskCount { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsDiskLevelMount
        // GraphQL -> isDiskLevelMount: Boolean (scalar)
        [JsonProperty("isDiskLevelMount")]
        public System.Boolean? IsDiskLevelMount { get; set; }

        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        [JsonProperty("isReady")]
        public System.Boolean? IsReady { get; set; }

        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        [JsonProperty("mountRequestId")]
        public System.String? MountRequestId { get; set; }

        //      C# -> DateTime? MountTime
        // GraphQL -> mountTime: DateTime (scalar)
        [JsonProperty("mountTime")]
        public DateTime? MountTime { get; set; }

        //      C# -> System.String? MountedVmId
        // GraphQL -> mountedVmId: String (scalar)
        [JsonProperty("mountedVmId")]
        public System.String? MountedVmId { get; set; }

        //      C# -> System.String? MountedVmName
        // GraphQL -> mountedVmName: String (scalar)
        [JsonProperty("mountedVmName")]
        public System.String? MountedVmName { get; set; }

        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        [JsonProperty("snapshotDate")]
        public DateTime? SnapshotDate { get; set; }

        //      C# -> System.String? TargetVmName
        // GraphQL -> targetVmName: String (scalar)
        [JsonProperty("targetVmName")]
        public System.String? TargetVmName { get; set; }

        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String (scalar)
        [JsonProperty("unmountRequestId")]
        public System.String? UnmountRequestId { get; set; }

        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        [JsonProperty("vmId")]
        public System.String? VmId { get; set; }

        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        [JsonProperty("vmName")]
        public System.String? VmName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HypervVirtualMachineMountSummary";
    }

    public HypervVirtualMachineMountSummary Set(
        HypervVirtualMachineMountSummaryPowerStatus? PowerStatus = null,
        System.Int32? AttachedDiskCount = null,
        System.String? HostId = null,
        System.String? HostName = null,
        System.String? Id = null,
        System.Boolean? IsDiskLevelMount = null,
        System.Boolean? IsReady = null,
        System.String? MountRequestId = null,
        DateTime? MountTime = null,
        System.String? MountedVmId = null,
        System.String? MountedVmName = null,
        DateTime? SnapshotDate = null,
        System.String? TargetVmName = null,
        System.String? UnmountRequestId = null,
        System.String? VmId = null,
        System.String? VmName = null
    ) 
    {
        if ( PowerStatus != null ) {
            this.PowerStatus = PowerStatus;
        }
        if ( AttachedDiskCount != null ) {
            this.AttachedDiskCount = AttachedDiskCount;
        }
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( HostName != null ) {
            this.HostName = HostName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsDiskLevelMount != null ) {
            this.IsDiskLevelMount = IsDiskLevelMount;
        }
        if ( IsReady != null ) {
            this.IsReady = IsReady;
        }
        if ( MountRequestId != null ) {
            this.MountRequestId = MountRequestId;
        }
        if ( MountTime != null ) {
            this.MountTime = MountTime;
        }
        if ( MountedVmId != null ) {
            this.MountedVmId = MountedVmId;
        }
        if ( MountedVmName != null ) {
            this.MountedVmName = MountedVmName;
        }
        if ( SnapshotDate != null ) {
            this.SnapshotDate = SnapshotDate;
        }
        if ( TargetVmName != null ) {
            this.TargetVmName = TargetVmName;
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
        //      C# -> HypervVirtualMachineMountSummaryPowerStatus? PowerStatus
        // GraphQL -> powerStatus: HypervVirtualMachineMountSummaryPowerStatus! (enum)
        if (this.PowerStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "powerStatus\n" ;
            } else {
                s += ind + "powerStatus\n" ;
            }
        }
        //      C# -> System.Int32? AttachedDiskCount
        // GraphQL -> attachedDiskCount: Int (scalar)
        if (this.AttachedDiskCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "attachedDiskCount\n" ;
            } else {
                s += ind + "attachedDiskCount\n" ;
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
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String (scalar)
        if (this.HostName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostName\n" ;
            } else {
                s += ind + "hostName\n" ;
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
        //      C# -> System.Boolean? IsDiskLevelMount
        // GraphQL -> isDiskLevelMount: Boolean (scalar)
        if (this.IsDiskLevelMount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDiskLevelMount\n" ;
            } else {
                s += ind + "isDiskLevelMount\n" ;
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
        //      C# -> DateTime? MountTime
        // GraphQL -> mountTime: DateTime (scalar)
        if (this.MountTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountTime\n" ;
            } else {
                s += ind + "mountTime\n" ;
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
        //      C# -> System.String? MountedVmName
        // GraphQL -> mountedVmName: String (scalar)
        if (this.MountedVmName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountedVmName\n" ;
            } else {
                s += ind + "mountedVmName\n" ;
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
        //      C# -> System.String? TargetVmName
        // GraphQL -> targetVmName: String (scalar)
        if (this.TargetVmName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetVmName\n" ;
            } else {
                s += ind + "targetVmName\n" ;
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
        // GraphQL -> vmName: String! (scalar)
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
        //      C# -> HypervVirtualMachineMountSummaryPowerStatus? PowerStatus
        // GraphQL -> powerStatus: HypervVirtualMachineMountSummaryPowerStatus! (enum)
        if (ec.Includes("powerStatus",true))
        {
            if(this.PowerStatus == null) {

                this.PowerStatus = new HypervVirtualMachineMountSummaryPowerStatus();

            } else {


            }
        }
        else if (this.PowerStatus != null && ec.Excludes("powerStatus",true))
        {
            this.PowerStatus = null;
        }
        //      C# -> System.Int32? AttachedDiskCount
        // GraphQL -> attachedDiskCount: Int (scalar)
        if (ec.Includes("attachedDiskCount",true))
        {
            if(this.AttachedDiskCount == null) {

                this.AttachedDiskCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.AttachedDiskCount != null && ec.Excludes("attachedDiskCount",true))
        {
            this.AttachedDiskCount = null;
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
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String (scalar)
        if (ec.Includes("hostName",true))
        {
            if(this.HostName == null) {

                this.HostName = "FETCH";

            } else {


            }
        }
        else if (this.HostName != null && ec.Excludes("hostName",true))
        {
            this.HostName = null;
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
        //      C# -> System.Boolean? IsDiskLevelMount
        // GraphQL -> isDiskLevelMount: Boolean (scalar)
        if (ec.Includes("isDiskLevelMount",true))
        {
            if(this.IsDiskLevelMount == null) {

                this.IsDiskLevelMount = true;

            } else {


            }
        }
        else if (this.IsDiskLevelMount != null && ec.Excludes("isDiskLevelMount",true))
        {
            this.IsDiskLevelMount = null;
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
        //      C# -> DateTime? MountTime
        // GraphQL -> mountTime: DateTime (scalar)
        if (ec.Includes("mountTime",true))
        {
            if(this.MountTime == null) {

                this.MountTime = new DateTime();

            } else {


            }
        }
        else if (this.MountTime != null && ec.Excludes("mountTime",true))
        {
            this.MountTime = null;
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
        //      C# -> System.String? TargetVmName
        // GraphQL -> targetVmName: String (scalar)
        if (ec.Includes("targetVmName",true))
        {
            if(this.TargetVmName == null) {

                this.TargetVmName = "FETCH";

            } else {


            }
        }
        else if (this.TargetVmName != null && ec.Excludes("targetVmName",true))
        {
            this.TargetVmName = null;
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
        // GraphQL -> vmName: String! (scalar)
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

    } // class HypervVirtualMachineMountSummary
    
    #endregion

    public static class ListHypervVirtualMachineMountSummaryExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<HypervVirtualMachineMountSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HypervVirtualMachineMountSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HypervVirtualMachineMountSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervVirtualMachineMountSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HypervVirtualMachineMountSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types