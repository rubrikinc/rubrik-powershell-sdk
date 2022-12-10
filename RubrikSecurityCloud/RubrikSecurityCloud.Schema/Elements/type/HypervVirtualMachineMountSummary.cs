// HypervVirtualMachineMountSummary.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:27.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region HypervVirtualMachineMountSummary
    public class HypervVirtualMachineMountSummary: IFragment
    {
        #region members
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

        //      C# -> HypervVirtualMachineMountSummaryPowerStatus? PowerStatus
        // GraphQL -> powerStatus: HypervVirtualMachineMountSummaryPowerStatus! (enum)
        [JsonProperty("powerStatus")]
        public HypervVirtualMachineMountSummaryPowerStatus? PowerStatus { get; set; }

        #endregion

    #region methods

    public HypervVirtualMachineMountSummary Set(
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
        System.String? VmName = null,
        HypervVirtualMachineMountSummaryPowerStatus? PowerStatus = null
    ) 
    {
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
        if ( PowerStatus != null ) {
            this.PowerStatus = PowerStatus;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? HostId
            // GraphQL -> hostId: String (scalar)
            if (this.HostId != null)
            {
                 s += ind + "hostId\n";

            }
            //      C# -> System.String? HostName
            // GraphQL -> hostName: String (scalar)
            if (this.HostName != null)
            {
                 s += ind + "hostName\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsReady
            // GraphQL -> isReady: Boolean! (scalar)
            if (this.IsReady != null)
            {
                 s += ind + "isReady\n";

            }
            //      C# -> System.String? MountRequestId
            // GraphQL -> mountRequestId: String (scalar)
            if (this.MountRequestId != null)
            {
                 s += ind + "mountRequestId\n";

            }
            //      C# -> System.String? MountedVmId
            // GraphQL -> mountedVmId: String (scalar)
            if (this.MountedVmId != null)
            {
                 s += ind + "mountedVmId\n";

            }
            //      C# -> System.String? MountedVmName
            // GraphQL -> mountedVmName: String (scalar)
            if (this.MountedVmName != null)
            {
                 s += ind + "mountedVmName\n";

            }
            //      C# -> DateTime? SnapshotDate
            // GraphQL -> snapshotDate: DateTime (scalar)
            if (this.SnapshotDate != null)
            {
                 s += ind + "snapshotDate\n";

            }
            //      C# -> System.String? UnmountRequestId
            // GraphQL -> unmountRequestId: String (scalar)
            if (this.UnmountRequestId != null)
            {
                 s += ind + "unmountRequestId\n";

            }
            //      C# -> System.String? VmId
            // GraphQL -> vmId: String! (scalar)
            if (this.VmId != null)
            {
                 s += ind + "vmId\n";

            }
            //      C# -> System.String? VmName
            // GraphQL -> vmName: String! (scalar)
            if (this.VmName != null)
            {
                 s += ind + "vmName\n";

            }
            //      C# -> HypervVirtualMachineMountSummaryPowerStatus? PowerStatus
            // GraphQL -> powerStatus: HypervVirtualMachineMountSummaryPowerStatus! (enum)
            if (this.PowerStatus != null)
            {
                 s += ind + "powerStatus\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? HostId
            // GraphQL -> hostId: String (scalar)
            if (this.HostId == null && Exploration.Includes(parent + ".hostId$"))
            {
                this.HostId = new System.String("FETCH");
            }
            //      C# -> System.String? HostName
            // GraphQL -> hostName: String (scalar)
            if (this.HostName == null && Exploration.Includes(parent + ".hostName$"))
            {
                this.HostName = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsReady
            // GraphQL -> isReady: Boolean! (scalar)
            if (this.IsReady == null && Exploration.Includes(parent + ".isReady$"))
            {
                this.IsReady = new System.Boolean();
            }
            //      C# -> System.String? MountRequestId
            // GraphQL -> mountRequestId: String (scalar)
            if (this.MountRequestId == null && Exploration.Includes(parent + ".mountRequestId$"))
            {
                this.MountRequestId = new System.String("FETCH");
            }
            //      C# -> System.String? MountedVmId
            // GraphQL -> mountedVmId: String (scalar)
            if (this.MountedVmId == null && Exploration.Includes(parent + ".mountedVmId$"))
            {
                this.MountedVmId = new System.String("FETCH");
            }
            //      C# -> System.String? MountedVmName
            // GraphQL -> mountedVmName: String (scalar)
            if (this.MountedVmName == null && Exploration.Includes(parent + ".mountedVmName$"))
            {
                this.MountedVmName = new System.String("FETCH");
            }
            //      C# -> DateTime? SnapshotDate
            // GraphQL -> snapshotDate: DateTime (scalar)
            if (this.SnapshotDate == null && Exploration.Includes(parent + ".snapshotDate$"))
            {
                this.SnapshotDate = new DateTime();
            }
            //      C# -> System.String? UnmountRequestId
            // GraphQL -> unmountRequestId: String (scalar)
            if (this.UnmountRequestId == null && Exploration.Includes(parent + ".unmountRequestId$"))
            {
                this.UnmountRequestId = new System.String("FETCH");
            }
            //      C# -> System.String? VmId
            // GraphQL -> vmId: String! (scalar)
            if (this.VmId == null && Exploration.Includes(parent + ".vmId$"))
            {
                this.VmId = new System.String("FETCH");
            }
            //      C# -> System.String? VmName
            // GraphQL -> vmName: String! (scalar)
            if (this.VmName == null && Exploration.Includes(parent + ".vmName$"))
            {
                this.VmName = new System.String("FETCH");
            }
            //      C# -> HypervVirtualMachineMountSummaryPowerStatus? PowerStatus
            // GraphQL -> powerStatus: HypervVirtualMachineMountSummaryPowerStatus! (enum)
            if (this.PowerStatus == null && Exploration.Includes(parent + ".powerStatus$"))
            {
                this.PowerStatus = new HypervVirtualMachineMountSummaryPowerStatus();
            }
        }


    #endregion

    } // class HypervVirtualMachineMountSummary
    #endregion

    public static class ListHypervVirtualMachineMountSummaryExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<HypervVirtualMachineMountSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<HypervVirtualMachineMountSummary> list, 
            String parent = "")
        {
            var item = new HypervVirtualMachineMountSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types