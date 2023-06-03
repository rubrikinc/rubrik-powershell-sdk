// UpdateHypervVirtualMachineReply.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region UpdateHypervVirtualMachineReply
    public class UpdateHypervVirtualMachineReply: BaseType
    {
        #region members

        //      C# -> HypervVirtualMachineDetailGuestOsType? GuestOsType
        // GraphQL -> guestOsType: HypervVirtualMachineDetailGuestOsType! (enum)
        [JsonProperty("guestOsType")]
        public HypervVirtualMachineDetailGuestOsType? GuestOsType { get; set; }

        //      C# -> HypervVirtualMachineDetailOperatingSystemType? OperatingSystemType
        // GraphQL -> operatingSystemType: HypervVirtualMachineDetailOperatingSystemType (enum)
        [JsonProperty("operatingSystemType")]
        public HypervVirtualMachineDetailOperatingSystemType? OperatingSystemType { get; set; }

        //      C# -> System.Boolean? IsAgentRegistered
        // GraphQL -> isAgentRegistered: Boolean (scalar)
        [JsonProperty("isAgentRegistered")]
        public System.Boolean? IsAgentRegistered { get; set; }

        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String (scalar)
        [JsonProperty("naturalId")]
        public System.String? NaturalId { get; set; }

        //      C# -> HypervVirtualMachineSummary? HypervVirtualMachineSummary
        // GraphQL -> hypervVirtualMachineSummary: HypervVirtualMachineSummary! (type)
        [JsonProperty("hypervVirtualMachineSummary")]
        public HypervVirtualMachineSummary? HypervVirtualMachineSummary { get; set; }

        //      C# -> HypervVirtualMachineUpdate? HypervVirtualMachineUpdate
        // GraphQL -> hypervVirtualMachineUpdate: HypervVirtualMachineUpdate! (type)
        [JsonProperty("hypervVirtualMachineUpdate")]
        public HypervVirtualMachineUpdate? HypervVirtualMachineUpdate { get; set; }

        //      C# -> List<HypervVirtualDiskInfo>? VirtualDiskInfo
        // GraphQL -> virtualDiskInfo: [HypervVirtualDiskInfo!]! (type)
        [JsonProperty("virtualDiskInfo")]
        public List<HypervVirtualDiskInfo>? VirtualDiskInfo { get; set; }


        #endregion

    #region methods

    public UpdateHypervVirtualMachineReply Set(
        HypervVirtualMachineDetailGuestOsType? GuestOsType = null,
        HypervVirtualMachineDetailOperatingSystemType? OperatingSystemType = null,
        System.Boolean? IsAgentRegistered = null,
        System.String? NaturalId = null,
        HypervVirtualMachineSummary? HypervVirtualMachineSummary = null,
        HypervVirtualMachineUpdate? HypervVirtualMachineUpdate = null,
        List<HypervVirtualDiskInfo>? VirtualDiskInfo = null
    ) 
    {
        if ( GuestOsType != null ) {
            this.GuestOsType = GuestOsType;
        }
        if ( OperatingSystemType != null ) {
            this.OperatingSystemType = OperatingSystemType;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> HypervVirtualMachineDetailGuestOsType? GuestOsType
        // GraphQL -> guestOsType: HypervVirtualMachineDetailGuestOsType! (enum)
        if (this.GuestOsType != null) {
            s += ind + "guestOsType\n" ;
        }
        //      C# -> HypervVirtualMachineDetailOperatingSystemType? OperatingSystemType
        // GraphQL -> operatingSystemType: HypervVirtualMachineDetailOperatingSystemType (enum)
        if (this.OperatingSystemType != null) {
            s += ind + "operatingSystemType\n" ;
        }
        //      C# -> System.Boolean? IsAgentRegistered
        // GraphQL -> isAgentRegistered: Boolean (scalar)
        if (this.IsAgentRegistered != null) {
            s += ind + "isAgentRegistered\n" ;
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String (scalar)
        if (this.NaturalId != null) {
            s += ind + "naturalId\n" ;
        }
        //      C# -> HypervVirtualMachineSummary? HypervVirtualMachineSummary
        // GraphQL -> hypervVirtualMachineSummary: HypervVirtualMachineSummary! (type)
        if (this.HypervVirtualMachineSummary != null) {
            s += ind + "hypervVirtualMachineSummary {\n" + this.HypervVirtualMachineSummary.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> HypervVirtualMachineUpdate? HypervVirtualMachineUpdate
        // GraphQL -> hypervVirtualMachineUpdate: HypervVirtualMachineUpdate! (type)
        if (this.HypervVirtualMachineUpdate != null) {
            s += ind + "hypervVirtualMachineUpdate {\n" + this.HypervVirtualMachineUpdate.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<HypervVirtualDiskInfo>? VirtualDiskInfo
        // GraphQL -> virtualDiskInfo: [HypervVirtualDiskInfo!]! (type)
        if (this.VirtualDiskInfo != null) {
            s += ind + "virtualDiskInfo {\n" + this.VirtualDiskInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> HypervVirtualMachineDetailGuestOsType? GuestOsType
        // GraphQL -> guestOsType: HypervVirtualMachineDetailGuestOsType! (enum)
        if (this.GuestOsType == null && Exploration.Includes(parent + ".guestOsType", true))
        {
            this.GuestOsType = new HypervVirtualMachineDetailGuestOsType();
        }
        //      C# -> HypervVirtualMachineDetailOperatingSystemType? OperatingSystemType
        // GraphQL -> operatingSystemType: HypervVirtualMachineDetailOperatingSystemType (enum)
        if (this.OperatingSystemType == null && Exploration.Includes(parent + ".operatingSystemType", true))
        {
            this.OperatingSystemType = new HypervVirtualMachineDetailOperatingSystemType();
        }
        //      C# -> System.Boolean? IsAgentRegistered
        // GraphQL -> isAgentRegistered: Boolean (scalar)
        if (this.IsAgentRegistered == null && Exploration.Includes(parent + ".isAgentRegistered", true))
        {
            this.IsAgentRegistered = true;
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String (scalar)
        if (this.NaturalId == null && Exploration.Includes(parent + ".naturalId", true))
        {
            this.NaturalId = new System.String("FETCH");
        }
        //      C# -> HypervVirtualMachineSummary? HypervVirtualMachineSummary
        // GraphQL -> hypervVirtualMachineSummary: HypervVirtualMachineSummary! (type)
        if (this.HypervVirtualMachineSummary == null && Exploration.Includes(parent + ".hypervVirtualMachineSummary"))
        {
            this.HypervVirtualMachineSummary = new HypervVirtualMachineSummary();
            this.HypervVirtualMachineSummary.ApplyExploratoryFieldSpec(parent + ".hypervVirtualMachineSummary");
        }
        //      C# -> HypervVirtualMachineUpdate? HypervVirtualMachineUpdate
        // GraphQL -> hypervVirtualMachineUpdate: HypervVirtualMachineUpdate! (type)
        if (this.HypervVirtualMachineUpdate == null && Exploration.Includes(parent + ".hypervVirtualMachineUpdate"))
        {
            this.HypervVirtualMachineUpdate = new HypervVirtualMachineUpdate();
            this.HypervVirtualMachineUpdate.ApplyExploratoryFieldSpec(parent + ".hypervVirtualMachineUpdate");
        }
        //      C# -> List<HypervVirtualDiskInfo>? VirtualDiskInfo
        // GraphQL -> virtualDiskInfo: [HypervVirtualDiskInfo!]! (type)
        if (this.VirtualDiskInfo == null && Exploration.Includes(parent + ".virtualDiskInfo"))
        {
            this.VirtualDiskInfo = new List<HypervVirtualDiskInfo>();
            this.VirtualDiskInfo.ApplyExploratoryFieldSpec(parent + ".virtualDiskInfo");
        }
    }


    #endregion

    } // class UpdateHypervVirtualMachineReply
    
    #endregion

    public static class ListUpdateHypervVirtualMachineReplyExtensions
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
            this List<UpdateHypervVirtualMachineReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateHypervVirtualMachineReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateHypervVirtualMachineReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types