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

        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        [JsonProperty("isReady")]
        public System.Boolean? IsReady { get; set; }

        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        [JsonProperty("mountRequestId")]
        public System.String? MountRequestId { get; set; }

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

    public HypervVirtualMachineMountSummary Set(
        HypervVirtualMachineMountSummaryPowerStatus? PowerStatus = null,
        System.String? HostId = null,
        System.String? HostName = null,
        System.String? Id = null,
        System.Boolean? IsReady = null,
        System.String? MountRequestId = null,
        System.String? MountedVmId = null,
        System.String? MountedVmName = null,
        DateTime? SnapshotDate = null,
        System.String? UnmountRequestId = null,
        System.String? VmId = null,
        System.String? VmName = null
    ) 
    {
        if ( PowerStatus != null ) {
            this.PowerStatus = PowerStatus;
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
        if ( IsReady != null ) {
            this.IsReady = IsReady;
        }
        if ( MountRequestId != null ) {
            this.MountRequestId = MountRequestId;
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
        //      C# -> HypervVirtualMachineMountSummaryPowerStatus? PowerStatus
        // GraphQL -> powerStatus: HypervVirtualMachineMountSummaryPowerStatus! (enum)
        if (this.PowerStatus != null) {
            s += ind + "powerStatus\n" ;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        if (this.HostId != null) {
            s += ind + "hostId\n" ;
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String (scalar)
        if (this.HostName != null) {
            s += ind + "hostName\n" ;
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
        //      C# -> System.String? MountedVmId
        // GraphQL -> mountedVmId: String (scalar)
        if (this.MountedVmId != null) {
            s += ind + "mountedVmId\n" ;
        }
        //      C# -> System.String? MountedVmName
        // GraphQL -> mountedVmName: String (scalar)
        if (this.MountedVmName != null) {
            s += ind + "mountedVmName\n" ;
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
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        if (this.VmName != null) {
            s += ind + "vmName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> HypervVirtualMachineMountSummaryPowerStatus? PowerStatus
        // GraphQL -> powerStatus: HypervVirtualMachineMountSummaryPowerStatus! (enum)
        if (this.PowerStatus == null && Exploration.Includes(parent + ".powerStatus", true))
        {
            this.PowerStatus = new HypervVirtualMachineMountSummaryPowerStatus();
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        if (this.HostId == null && Exploration.Includes(parent + ".hostId", true))
        {
            this.HostId = "FETCH";
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String (scalar)
        if (this.HostName == null && Exploration.Includes(parent + ".hostName", true))
        {
            this.HostName = "FETCH";
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
        //      C# -> System.String? MountedVmId
        // GraphQL -> mountedVmId: String (scalar)
        if (this.MountedVmId == null && Exploration.Includes(parent + ".mountedVmId", true))
        {
            this.MountedVmId = "FETCH";
        }
        //      C# -> System.String? MountedVmName
        // GraphQL -> mountedVmName: String (scalar)
        if (this.MountedVmName == null && Exploration.Includes(parent + ".mountedVmName", true))
        {
            this.MountedVmName = "FETCH";
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
        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        if (this.VmName == null && Exploration.Includes(parent + ".vmName", true))
        {
            this.VmName = "FETCH";
        }
    }


    #endregion

    } // class HypervVirtualMachineMountSummary
    
    #endregion

    public static class ListHypervVirtualMachineMountSummaryExtensions
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
            this List<HypervVirtualMachineMountSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HypervVirtualMachineMountSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervVirtualMachineMountSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types