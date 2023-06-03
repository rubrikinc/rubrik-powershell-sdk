// BootstrappableNodeInfo.cs
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
    #region BootstrappableNodeInfo
    public class BootstrappableNodeInfo: BaseType
    {
        #region members

        //      C# -> System.Int64? CapacityInBytes
        // GraphQL -> capacityInBytes: Long (scalar)
        [JsonProperty("capacityInBytes")]
        public System.Int64? CapacityInBytes { get; set; }

        //      C# -> System.String? ChassisId
        // GraphQL -> chassisId: String (scalar)
        [JsonProperty("chassisId")]
        public System.String? ChassisId { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.String? Ipv6
        // GraphQL -> ipv6: String! (scalar)
        [JsonProperty("ipv6")]
        public System.String? Ipv6 { get; set; }

        //      C# -> System.Boolean? IsAllCopper
        // GraphQL -> isAllCopper: Boolean (scalar)
        [JsonProperty("isAllCopper")]
        public System.Boolean? IsAllCopper { get; set; }

        //      C# -> System.Boolean? IsBond0Eth0Enabled
        // GraphQL -> isBond0Eth0Enabled: Boolean (scalar)
        [JsonProperty("isBond0Eth0Enabled")]
        public System.Boolean? IsBond0Eth0Enabled { get; set; }

        //      C# -> System.Boolean? IsBond0Eth1Enabled
        // GraphQL -> isBond0Eth1Enabled: Boolean (scalar)
        [JsonProperty("isBond0Eth1Enabled")]
        public System.Boolean? IsBond0Eth1Enabled { get; set; }

        //      C# -> System.Boolean? IsBond0Reachable
        // GraphQL -> isBond0Reachable: Boolean (scalar)
        [JsonProperty("isBond0Reachable")]
        public System.Boolean? IsBond0Reachable { get; set; }

        //      C# -> System.Boolean? IsBond1Eth2Enabled
        // GraphQL -> isBond1Eth2Enabled: Boolean (scalar)
        [JsonProperty("isBond1Eth2Enabled")]
        public System.Boolean? IsBond1Eth2Enabled { get; set; }

        //      C# -> System.Boolean? IsBond1Eth3Enabled
        // GraphQL -> isBond1Eth3Enabled: Boolean (scalar)
        [JsonProperty("isBond1Eth3Enabled")]
        public System.Boolean? IsBond1Eth3Enabled { get; set; }

        //      C# -> System.String? NodePosition
        // GraphQL -> nodePosition: String (scalar)
        [JsonProperty("nodePosition")]
        public System.String? NodePosition { get; set; }

        //      C# -> System.String? PlatformName
        // GraphQL -> platformName: String (scalar)
        [JsonProperty("platformName")]
        public System.String? PlatformName { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }


        #endregion

    #region methods

    public BootstrappableNodeInfo Set(
        System.Int64? CapacityInBytes = null,
        System.String? ChassisId = null,
        System.String? Hostname = null,
        System.String? Ipv6 = null,
        System.Boolean? IsAllCopper = null,
        System.Boolean? IsBond0Eth0Enabled = null,
        System.Boolean? IsBond0Eth1Enabled = null,
        System.Boolean? IsBond0Reachable = null,
        System.Boolean? IsBond1Eth2Enabled = null,
        System.Boolean? IsBond1Eth3Enabled = null,
        System.String? NodePosition = null,
        System.String? PlatformName = null,
        System.String? Version = null
    ) 
    {
        if ( CapacityInBytes != null ) {
            this.CapacityInBytes = CapacityInBytes;
        }
        if ( ChassisId != null ) {
            this.ChassisId = ChassisId;
        }
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( Ipv6 != null ) {
            this.Ipv6 = Ipv6;
        }
        if ( IsAllCopper != null ) {
            this.IsAllCopper = IsAllCopper;
        }
        if ( IsBond0Eth0Enabled != null ) {
            this.IsBond0Eth0Enabled = IsBond0Eth0Enabled;
        }
        if ( IsBond0Eth1Enabled != null ) {
            this.IsBond0Eth1Enabled = IsBond0Eth1Enabled;
        }
        if ( IsBond0Reachable != null ) {
            this.IsBond0Reachable = IsBond0Reachable;
        }
        if ( IsBond1Eth2Enabled != null ) {
            this.IsBond1Eth2Enabled = IsBond1Eth2Enabled;
        }
        if ( IsBond1Eth3Enabled != null ) {
            this.IsBond1Eth3Enabled = IsBond1Eth3Enabled;
        }
        if ( NodePosition != null ) {
            this.NodePosition = NodePosition;
        }
        if ( PlatformName != null ) {
            this.PlatformName = PlatformName;
        }
        if ( Version != null ) {
            this.Version = Version;
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
        //      C# -> System.Int64? CapacityInBytes
        // GraphQL -> capacityInBytes: Long (scalar)
        if (this.CapacityInBytes != null) {
            s += ind + "capacityInBytes\n" ;
        }
        //      C# -> System.String? ChassisId
        // GraphQL -> chassisId: String (scalar)
        if (this.ChassisId != null) {
            s += ind + "chassisId\n" ;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            s += ind + "hostname\n" ;
        }
        //      C# -> System.String? Ipv6
        // GraphQL -> ipv6: String! (scalar)
        if (this.Ipv6 != null) {
            s += ind + "ipv6\n" ;
        }
        //      C# -> System.Boolean? IsAllCopper
        // GraphQL -> isAllCopper: Boolean (scalar)
        if (this.IsAllCopper != null) {
            s += ind + "isAllCopper\n" ;
        }
        //      C# -> System.Boolean? IsBond0Eth0Enabled
        // GraphQL -> isBond0Eth0Enabled: Boolean (scalar)
        if (this.IsBond0Eth0Enabled != null) {
            s += ind + "isBond0Eth0Enabled\n" ;
        }
        //      C# -> System.Boolean? IsBond0Eth1Enabled
        // GraphQL -> isBond0Eth1Enabled: Boolean (scalar)
        if (this.IsBond0Eth1Enabled != null) {
            s += ind + "isBond0Eth1Enabled\n" ;
        }
        //      C# -> System.Boolean? IsBond0Reachable
        // GraphQL -> isBond0Reachable: Boolean (scalar)
        if (this.IsBond0Reachable != null) {
            s += ind + "isBond0Reachable\n" ;
        }
        //      C# -> System.Boolean? IsBond1Eth2Enabled
        // GraphQL -> isBond1Eth2Enabled: Boolean (scalar)
        if (this.IsBond1Eth2Enabled != null) {
            s += ind + "isBond1Eth2Enabled\n" ;
        }
        //      C# -> System.Boolean? IsBond1Eth3Enabled
        // GraphQL -> isBond1Eth3Enabled: Boolean (scalar)
        if (this.IsBond1Eth3Enabled != null) {
            s += ind + "isBond1Eth3Enabled\n" ;
        }
        //      C# -> System.String? NodePosition
        // GraphQL -> nodePosition: String (scalar)
        if (this.NodePosition != null) {
            s += ind + "nodePosition\n" ;
        }
        //      C# -> System.String? PlatformName
        // GraphQL -> platformName: String (scalar)
        if (this.PlatformName != null) {
            s += ind + "platformName\n" ;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version != null) {
            s += ind + "version\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? CapacityInBytes
        // GraphQL -> capacityInBytes: Long (scalar)
        if (this.CapacityInBytes == null && Exploration.Includes(parent + ".capacityInBytes", true))
        {
            this.CapacityInBytes = new System.Int64();
        }
        //      C# -> System.String? ChassisId
        // GraphQL -> chassisId: String (scalar)
        if (this.ChassisId == null && Exploration.Includes(parent + ".chassisId", true))
        {
            this.ChassisId = new System.String("FETCH");
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname == null && Exploration.Includes(parent + ".hostname", true))
        {
            this.Hostname = new System.String("FETCH");
        }
        //      C# -> System.String? Ipv6
        // GraphQL -> ipv6: String! (scalar)
        if (this.Ipv6 == null && Exploration.Includes(parent + ".ipv6", true))
        {
            this.Ipv6 = new System.String("FETCH");
        }
        //      C# -> System.Boolean? IsAllCopper
        // GraphQL -> isAllCopper: Boolean (scalar)
        if (this.IsAllCopper == null && Exploration.Includes(parent + ".isAllCopper", true))
        {
            this.IsAllCopper = true;
        }
        //      C# -> System.Boolean? IsBond0Eth0Enabled
        // GraphQL -> isBond0Eth0Enabled: Boolean (scalar)
        if (this.IsBond0Eth0Enabled == null && Exploration.Includes(parent + ".isBond0Eth0Enabled", true))
        {
            this.IsBond0Eth0Enabled = true;
        }
        //      C# -> System.Boolean? IsBond0Eth1Enabled
        // GraphQL -> isBond0Eth1Enabled: Boolean (scalar)
        if (this.IsBond0Eth1Enabled == null && Exploration.Includes(parent + ".isBond0Eth1Enabled", true))
        {
            this.IsBond0Eth1Enabled = true;
        }
        //      C# -> System.Boolean? IsBond0Reachable
        // GraphQL -> isBond0Reachable: Boolean (scalar)
        if (this.IsBond0Reachable == null && Exploration.Includes(parent + ".isBond0Reachable", true))
        {
            this.IsBond0Reachable = true;
        }
        //      C# -> System.Boolean? IsBond1Eth2Enabled
        // GraphQL -> isBond1Eth2Enabled: Boolean (scalar)
        if (this.IsBond1Eth2Enabled == null && Exploration.Includes(parent + ".isBond1Eth2Enabled", true))
        {
            this.IsBond1Eth2Enabled = true;
        }
        //      C# -> System.Boolean? IsBond1Eth3Enabled
        // GraphQL -> isBond1Eth3Enabled: Boolean (scalar)
        if (this.IsBond1Eth3Enabled == null && Exploration.Includes(parent + ".isBond1Eth3Enabled", true))
        {
            this.IsBond1Eth3Enabled = true;
        }
        //      C# -> System.String? NodePosition
        // GraphQL -> nodePosition: String (scalar)
        if (this.NodePosition == null && Exploration.Includes(parent + ".nodePosition", true))
        {
            this.NodePosition = new System.String("FETCH");
        }
        //      C# -> System.String? PlatformName
        // GraphQL -> platformName: String (scalar)
        if (this.PlatformName == null && Exploration.Includes(parent + ".platformName", true))
        {
            this.PlatformName = new System.String("FETCH");
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version == null && Exploration.Includes(parent + ".version", true))
        {
            this.Version = new System.String("FETCH");
        }
    }


    #endregion

    } // class BootstrappableNodeInfo
    
    #endregion

    public static class ListBootstrappableNodeInfoExtensions
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
            this List<BootstrappableNodeInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BootstrappableNodeInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new BootstrappableNodeInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types