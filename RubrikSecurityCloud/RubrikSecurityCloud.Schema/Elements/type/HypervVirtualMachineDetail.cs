// HypervVirtualMachineDetail.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:37.
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
    #region HypervVirtualMachineDetail
    public class HypervVirtualMachineDetail: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsAgentRegistered
        // GraphQL -> isAgentRegistered: Boolean (scalar)
        [JsonProperty("isAgentRegistered")]
        public System.Boolean? IsAgentRegistered { get; set; }

        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String (scalar)
        [JsonProperty("naturalId")]
        public System.String? NaturalId { get; set; }

        //      C# -> HypervVirtualMachineSummary? HypervVirtualMachineSummary
        // GraphQL -> hypervVirtualMachineSummary: HypervVirtualMachineSummary (type)
        [JsonProperty("hypervVirtualMachineSummary")]
        public HypervVirtualMachineSummary? HypervVirtualMachineSummary { get; set; }

        //      C# -> HypervVirtualMachineUpdate? HypervVirtualMachineUpdate
        // GraphQL -> hypervVirtualMachineUpdate: HypervVirtualMachineUpdate (type)
        [JsonProperty("hypervVirtualMachineUpdate")]
        public HypervVirtualMachineUpdate? HypervVirtualMachineUpdate { get; set; }

        //      C# -> List<HypervVirtualDiskInfo>? VirtualDiskInfo
        // GraphQL -> virtualDiskInfo: [HypervVirtualDiskInfo!]! (type)
        [JsonProperty("virtualDiskInfo")]
        public List<HypervVirtualDiskInfo>? VirtualDiskInfo { get; set; }

        //      C# -> HypervVirtualMachineDetailGuestOsType? GuestOsType
        // GraphQL -> guestOsType: HypervVirtualMachineDetailGuestOsType! (enum)
        [JsonProperty("guestOsType")]
        public HypervVirtualMachineDetailGuestOsType? GuestOsType { get; set; }

        //      C# -> HypervVirtualMachineDetailOperatingSystemType? OperatingSystemType
        // GraphQL -> operatingSystemType: HypervVirtualMachineDetailOperatingSystemType (enum)
        [JsonProperty("operatingSystemType")]
        public HypervVirtualMachineDetailOperatingSystemType? OperatingSystemType { get; set; }

        #endregion

    #region methods

    public HypervVirtualMachineDetail Set(
        System.Boolean? IsAgentRegistered = null,
        System.String? NaturalId = null,
        HypervVirtualMachineSummary? HypervVirtualMachineSummary = null,
        HypervVirtualMachineUpdate? HypervVirtualMachineUpdate = null,
        List<HypervVirtualDiskInfo>? VirtualDiskInfo = null,
        HypervVirtualMachineDetailGuestOsType? GuestOsType = null,
        HypervVirtualMachineDetailOperatingSystemType? OperatingSystemType = null
    ) 
    {
        if ( IsAgentRegistered != null ) {
            this.IsAgentRegistered = IsAgentRegistered;
        }
        if ( NaturalId != null ) {
            this.NaturalId = NaturalId;
        }
        if ( HypervVirtualMachineSummary != null ) {
            this.HypervVirtualMachineSummary = HypervVirtualMachineSummary;
        }
        if ( HypervVirtualMachineUpdate != null ) {
            this.HypervVirtualMachineUpdate = HypervVirtualMachineUpdate;
        }
        if ( VirtualDiskInfo != null ) {
            this.VirtualDiskInfo = VirtualDiskInfo;
        }
        if ( GuestOsType != null ) {
            this.GuestOsType = GuestOsType;
        }
        if ( OperatingSystemType != null ) {
            this.OperatingSystemType = OperatingSystemType;
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
            //      C# -> System.Boolean? IsAgentRegistered
            // GraphQL -> isAgentRegistered: Boolean (scalar)
            if (this.IsAgentRegistered != null)
            {
                 s += ind + "isAgentRegistered\n";

            }
            //      C# -> System.String? NaturalId
            // GraphQL -> naturalId: String (scalar)
            if (this.NaturalId != null)
            {
                 s += ind + "naturalId\n";

            }
            //      C# -> HypervVirtualMachineSummary? HypervVirtualMachineSummary
            // GraphQL -> hypervVirtualMachineSummary: HypervVirtualMachineSummary (type)
            if (this.HypervVirtualMachineSummary != null)
            {
                 s += ind + "hypervVirtualMachineSummary\n";

                 s += ind + "{\n" + 
                 this.HypervVirtualMachineSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> HypervVirtualMachineUpdate? HypervVirtualMachineUpdate
            // GraphQL -> hypervVirtualMachineUpdate: HypervVirtualMachineUpdate (type)
            if (this.HypervVirtualMachineUpdate != null)
            {
                 s += ind + "hypervVirtualMachineUpdate\n";

                 s += ind + "{\n" + 
                 this.HypervVirtualMachineUpdate.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<HypervVirtualDiskInfo>? VirtualDiskInfo
            // GraphQL -> virtualDiskInfo: [HypervVirtualDiskInfo!]! (type)
            if (this.VirtualDiskInfo != null)
            {
                 s += ind + "virtualDiskInfo\n";

                 s += ind + "{\n" + 
                 this.VirtualDiskInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> HypervVirtualMachineDetailGuestOsType? GuestOsType
            // GraphQL -> guestOsType: HypervVirtualMachineDetailGuestOsType! (enum)
            if (this.GuestOsType != null)
            {
                 s += ind + "guestOsType\n";

            }
            //      C# -> HypervVirtualMachineDetailOperatingSystemType? OperatingSystemType
            // GraphQL -> operatingSystemType: HypervVirtualMachineDetailOperatingSystemType (enum)
            if (this.OperatingSystemType != null)
            {
                 s += ind + "operatingSystemType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsAgentRegistered
            // GraphQL -> isAgentRegistered: Boolean (scalar)
            if (this.IsAgentRegistered == null && Exploration.Includes(parent + ".isAgentRegistered$"))
            {
                this.IsAgentRegistered = new System.Boolean();
            }
            //      C# -> System.String? NaturalId
            // GraphQL -> naturalId: String (scalar)
            if (this.NaturalId == null && Exploration.Includes(parent + ".naturalId$"))
            {
                this.NaturalId = new System.String("FETCH");
            }
            //      C# -> HypervVirtualMachineSummary? HypervVirtualMachineSummary
            // GraphQL -> hypervVirtualMachineSummary: HypervVirtualMachineSummary (type)
            if (this.HypervVirtualMachineSummary == null && Exploration.Includes(parent + ".hypervVirtualMachineSummary"))
            {
                this.HypervVirtualMachineSummary = new HypervVirtualMachineSummary();
                this.HypervVirtualMachineSummary.ApplyExploratoryFragment(parent + ".hypervVirtualMachineSummary");
            }
            //      C# -> HypervVirtualMachineUpdate? HypervVirtualMachineUpdate
            // GraphQL -> hypervVirtualMachineUpdate: HypervVirtualMachineUpdate (type)
            if (this.HypervVirtualMachineUpdate == null && Exploration.Includes(parent + ".hypervVirtualMachineUpdate"))
            {
                this.HypervVirtualMachineUpdate = new HypervVirtualMachineUpdate();
                this.HypervVirtualMachineUpdate.ApplyExploratoryFragment(parent + ".hypervVirtualMachineUpdate");
            }
            //      C# -> List<HypervVirtualDiskInfo>? VirtualDiskInfo
            // GraphQL -> virtualDiskInfo: [HypervVirtualDiskInfo!]! (type)
            if (this.VirtualDiskInfo == null && Exploration.Includes(parent + ".virtualDiskInfo"))
            {
                this.VirtualDiskInfo = new List<HypervVirtualDiskInfo>();
                this.VirtualDiskInfo.ApplyExploratoryFragment(parent + ".virtualDiskInfo");
            }
            //      C# -> HypervVirtualMachineDetailGuestOsType? GuestOsType
            // GraphQL -> guestOsType: HypervVirtualMachineDetailGuestOsType! (enum)
            if (this.GuestOsType == null && Exploration.Includes(parent + ".guestOsType$"))
            {
                this.GuestOsType = new HypervVirtualMachineDetailGuestOsType();
            }
            //      C# -> HypervVirtualMachineDetailOperatingSystemType? OperatingSystemType
            // GraphQL -> operatingSystemType: HypervVirtualMachineDetailOperatingSystemType (enum)
            if (this.OperatingSystemType == null && Exploration.Includes(parent + ".operatingSystemType$"))
            {
                this.OperatingSystemType = new HypervVirtualMachineDetailOperatingSystemType();
            }
        }


    #endregion

    } // class HypervVirtualMachineDetail
    #endregion

    public static class ListHypervVirtualMachineDetailExtensions
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
            this List<HypervVirtualMachineDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<HypervVirtualMachineDetail> list, 
            String parent = "")
        {
            var item = new HypervVirtualMachineDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types