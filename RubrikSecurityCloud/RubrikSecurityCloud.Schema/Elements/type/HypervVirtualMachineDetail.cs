// HypervVirtualMachineDetail.cs
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
    #region HypervVirtualMachineDetail
    public class HypervVirtualMachineDetail: BaseType
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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HypervVirtualMachineDetail";
    }

    public HypervVirtualMachineDetail Set(
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> HypervVirtualMachineDetailGuestOsType? GuestOsType
        // GraphQL -> guestOsType: HypervVirtualMachineDetailGuestOsType! (enum)
        if (this.GuestOsType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "guestOsType\n" ;
            } else {
                s += ind + "guestOsType\n" ;
            }
        }
        //      C# -> HypervVirtualMachineDetailOperatingSystemType? OperatingSystemType
        // GraphQL -> operatingSystemType: HypervVirtualMachineDetailOperatingSystemType (enum)
        if (this.OperatingSystemType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "operatingSystemType\n" ;
            } else {
                s += ind + "operatingSystemType\n" ;
            }
        }
        //      C# -> System.Boolean? IsAgentRegistered
        // GraphQL -> isAgentRegistered: Boolean (scalar)
        if (this.IsAgentRegistered != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAgentRegistered\n" ;
            } else {
                s += ind + "isAgentRegistered\n" ;
            }
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String (scalar)
        if (this.NaturalId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "naturalId\n" ;
            } else {
                s += ind + "naturalId\n" ;
            }
        }
        //      C# -> HypervVirtualMachineSummary? HypervVirtualMachineSummary
        // GraphQL -> hypervVirtualMachineSummary: HypervVirtualMachineSummary (type)
        if (this.HypervVirtualMachineSummary != null) {
            var fspec = this.HypervVirtualMachineSummary.AsFieldSpec(conf.Child("hypervVirtualMachineSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hypervVirtualMachineSummary {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> HypervVirtualMachineUpdate? HypervVirtualMachineUpdate
        // GraphQL -> hypervVirtualMachineUpdate: HypervVirtualMachineUpdate (type)
        if (this.HypervVirtualMachineUpdate != null) {
            var fspec = this.HypervVirtualMachineUpdate.AsFieldSpec(conf.Child("hypervVirtualMachineUpdate"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hypervVirtualMachineUpdate {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<HypervVirtualDiskInfo>? VirtualDiskInfo
        // GraphQL -> virtualDiskInfo: [HypervVirtualDiskInfo!]! (type)
        if (this.VirtualDiskInfo != null) {
            var fspec = this.VirtualDiskInfo.AsFieldSpec(conf.Child("virtualDiskInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "virtualDiskInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> HypervVirtualMachineDetailGuestOsType? GuestOsType
        // GraphQL -> guestOsType: HypervVirtualMachineDetailGuestOsType! (enum)
        if (ec.Includes("guestOsType",true))
        {
            if(this.GuestOsType == null) {

                this.GuestOsType = new HypervVirtualMachineDetailGuestOsType();

            } else {


            }
        }
        else if (this.GuestOsType != null && ec.Excludes("guestOsType",true))
        {
            this.GuestOsType = null;
        }
        //      C# -> HypervVirtualMachineDetailOperatingSystemType? OperatingSystemType
        // GraphQL -> operatingSystemType: HypervVirtualMachineDetailOperatingSystemType (enum)
        if (ec.Includes("operatingSystemType",true))
        {
            if(this.OperatingSystemType == null) {

                this.OperatingSystemType = new HypervVirtualMachineDetailOperatingSystemType();

            } else {


            }
        }
        else if (this.OperatingSystemType != null && ec.Excludes("operatingSystemType",true))
        {
            this.OperatingSystemType = null;
        }
        //      C# -> System.Boolean? IsAgentRegistered
        // GraphQL -> isAgentRegistered: Boolean (scalar)
        if (ec.Includes("isAgentRegistered",true))
        {
            if(this.IsAgentRegistered == null) {

                this.IsAgentRegistered = true;

            } else {


            }
        }
        else if (this.IsAgentRegistered != null && ec.Excludes("isAgentRegistered",true))
        {
            this.IsAgentRegistered = null;
        }
        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String (scalar)
        if (ec.Includes("naturalId",true))
        {
            if(this.NaturalId == null) {

                this.NaturalId = "FETCH";

            } else {


            }
        }
        else if (this.NaturalId != null && ec.Excludes("naturalId",true))
        {
            this.NaturalId = null;
        }
        //      C# -> HypervVirtualMachineSummary? HypervVirtualMachineSummary
        // GraphQL -> hypervVirtualMachineSummary: HypervVirtualMachineSummary (type)
        if (ec.Includes("hypervVirtualMachineSummary",false))
        {
            if(this.HypervVirtualMachineSummary == null) {

                this.HypervVirtualMachineSummary = new HypervVirtualMachineSummary();
                this.HypervVirtualMachineSummary.ApplyExploratoryFieldSpec(ec.NewChild("hypervVirtualMachineSummary"));

            } else {

                this.HypervVirtualMachineSummary.ApplyExploratoryFieldSpec(ec.NewChild("hypervVirtualMachineSummary"));

            }
        }
        else if (this.HypervVirtualMachineSummary != null && ec.Excludes("hypervVirtualMachineSummary",false))
        {
            this.HypervVirtualMachineSummary = null;
        }
        //      C# -> HypervVirtualMachineUpdate? HypervVirtualMachineUpdate
        // GraphQL -> hypervVirtualMachineUpdate: HypervVirtualMachineUpdate (type)
        if (ec.Includes("hypervVirtualMachineUpdate",false))
        {
            if(this.HypervVirtualMachineUpdate == null) {

                this.HypervVirtualMachineUpdate = new HypervVirtualMachineUpdate();
                this.HypervVirtualMachineUpdate.ApplyExploratoryFieldSpec(ec.NewChild("hypervVirtualMachineUpdate"));

            } else {

                this.HypervVirtualMachineUpdate.ApplyExploratoryFieldSpec(ec.NewChild("hypervVirtualMachineUpdate"));

            }
        }
        else if (this.HypervVirtualMachineUpdate != null && ec.Excludes("hypervVirtualMachineUpdate",false))
        {
            this.HypervVirtualMachineUpdate = null;
        }
        //      C# -> List<HypervVirtualDiskInfo>? VirtualDiskInfo
        // GraphQL -> virtualDiskInfo: [HypervVirtualDiskInfo!]! (type)
        if (ec.Includes("virtualDiskInfo",false))
        {
            if(this.VirtualDiskInfo == null) {

                this.VirtualDiskInfo = new List<HypervVirtualDiskInfo>();
                this.VirtualDiskInfo.ApplyExploratoryFieldSpec(ec.NewChild("virtualDiskInfo"));

            } else {

                this.VirtualDiskInfo.ApplyExploratoryFieldSpec(ec.NewChild("virtualDiskInfo"));

            }
        }
        else if (this.VirtualDiskInfo != null && ec.Excludes("virtualDiskInfo",false))
        {
            this.VirtualDiskInfo = null;
        }
    }


    #endregion

    } // class HypervVirtualMachineDetail
    
    #endregion

    public static class ListHypervVirtualMachineDetailExtensions
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
            this List<HypervVirtualMachineDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<HypervVirtualMachineDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HypervVirtualMachineDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervVirtualMachineDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HypervVirtualMachineDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types