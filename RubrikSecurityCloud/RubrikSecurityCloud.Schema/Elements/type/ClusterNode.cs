// ClusterNode.cs
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
    #region ClusterNode
    public class ClusterNode: BaseType
    {
        #region members

        //      C# -> ClusterNodePlatformType? PlatformType
        // GraphQL -> platformType: ClusterNodePlatformType (enum)
        [JsonProperty("platformType")]
        public ClusterNodePlatformType? PlatformType { get; set; }

        //      C# -> ClusterNodePosition? Position
        // GraphQL -> position: ClusterNodePosition (enum)
        [JsonProperty("position")]
        public ClusterNodePosition? Position { get; set; }

        //      C# -> ClusterNodeStatus? Status
        // GraphQL -> status: ClusterNodeStatus (enum)
        [JsonProperty("status")]
        public ClusterNodeStatus? Status { get; set; }

        //      C# -> System.String? BrikId
        // GraphQL -> brikId: String! (scalar)
        [JsonProperty("brikId")]
        public System.String? BrikId { get; set; }

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> System.Int32? CpuCores
        // GraphQL -> cpuCores: Int (scalar)
        [JsonProperty("cpuCores")]
        public System.Int32? CpuCores { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String (scalar)
        [JsonProperty("ipAddress")]
        public System.String? IpAddress { get; set; }

        //      C# -> System.Boolean? NeedsInspection
        // GraphQL -> needsInspection: Boolean (scalar)
        [JsonProperty("needsInspection")]
        public System.Boolean? NeedsInspection { get; set; }

        //      C# -> System.String? NetworkSpeed
        // GraphQL -> networkSpeed: String (scalar)
        [JsonProperty("networkSpeed")]
        public System.String? NetworkSpeed { get; set; }

        //      C# -> System.Int64? Ram
        // GraphQL -> ram: Long (scalar)
        [JsonProperty("ram")]
        public System.Int64? Ram { get; set; }

        //      C# -> List<HealthPolicyStatus>? HardwareHealth
        // GraphQL -> hardwareHealth: [HealthPolicyStatus!] (type)
        [JsonProperty("hardwareHealth")]
        public List<HealthPolicyStatus>? HardwareHealth { get; set; }

        //      C# -> List<ClusterNodeInterfaceCidr>? InterfaceCidrs
        // GraphQL -> interfaceCidrs: [ClusterNodeInterfaceCidr!] (type)
        [JsonProperty("interfaceCidrs")]
        public List<ClusterNodeInterfaceCidr>? InterfaceCidrs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterNode";
    }

    public ClusterNode Set(
        ClusterNodePlatformType? PlatformType = null,
        ClusterNodePosition? Position = null,
        ClusterNodeStatus? Status = null,
        System.String? BrikId = null,
        System.String? ClusterId = null,
        System.Int32? CpuCores = null,
        System.String? Hostname = null,
        System.String? Id = null,
        System.String? IpAddress = null,
        System.Boolean? NeedsInspection = null,
        System.String? NetworkSpeed = null,
        System.Int64? Ram = null,
        List<HealthPolicyStatus>? HardwareHealth = null,
        List<ClusterNodeInterfaceCidr>? InterfaceCidrs = null
    ) 
    {
        if ( PlatformType != null ) {
            this.PlatformType = PlatformType;
        }
        if ( Position != null ) {
            this.Position = Position;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( BrikId != null ) {
            this.BrikId = BrikId;
        }
        if ( ClusterId != null ) {
            this.ClusterId = ClusterId;
        }
        if ( CpuCores != null ) {
            this.CpuCores = CpuCores;
        }
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IpAddress != null ) {
            this.IpAddress = IpAddress;
        }
        if ( NeedsInspection != null ) {
            this.NeedsInspection = NeedsInspection;
        }
        if ( NetworkSpeed != null ) {
            this.NetworkSpeed = NetworkSpeed;
        }
        if ( Ram != null ) {
            this.Ram = Ram;
        }
        if ( HardwareHealth != null ) {
            this.HardwareHealth = HardwareHealth;
        }
        if ( InterfaceCidrs != null ) {
            this.InterfaceCidrs = InterfaceCidrs;
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
        //      C# -> ClusterNodePlatformType? PlatformType
        // GraphQL -> platformType: ClusterNodePlatformType (enum)
        if (this.PlatformType != null) {
            s += ind + "platformType\n" ;
        }
        //      C# -> ClusterNodePosition? Position
        // GraphQL -> position: ClusterNodePosition (enum)
        if (this.Position != null) {
            s += ind + "position\n" ;
        }
        //      C# -> ClusterNodeStatus? Status
        // GraphQL -> status: ClusterNodeStatus (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? BrikId
        // GraphQL -> brikId: String! (scalar)
        if (this.BrikId != null) {
            s += ind + "brikId\n" ;
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (this.ClusterId != null) {
            s += ind + "clusterId\n" ;
        }
        //      C# -> System.Int32? CpuCores
        // GraphQL -> cpuCores: Int (scalar)
        if (this.CpuCores != null) {
            s += ind + "cpuCores\n" ;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        if (this.Hostname != null) {
            s += ind + "hostname\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String (scalar)
        if (this.IpAddress != null) {
            s += ind + "ipAddress\n" ;
        }
        //      C# -> System.Boolean? NeedsInspection
        // GraphQL -> needsInspection: Boolean (scalar)
        if (this.NeedsInspection != null) {
            s += ind + "needsInspection\n" ;
        }
        //      C# -> System.String? NetworkSpeed
        // GraphQL -> networkSpeed: String (scalar)
        if (this.NetworkSpeed != null) {
            s += ind + "networkSpeed\n" ;
        }
        //      C# -> System.Int64? Ram
        // GraphQL -> ram: Long (scalar)
        if (this.Ram != null) {
            s += ind + "ram\n" ;
        }
        //      C# -> List<HealthPolicyStatus>? HardwareHealth
        // GraphQL -> hardwareHealth: [HealthPolicyStatus!] (type)
        if (this.HardwareHealth != null) {
            var fspec = this.HardwareHealth.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "hardwareHealth {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ClusterNodeInterfaceCidr>? InterfaceCidrs
        // GraphQL -> interfaceCidrs: [ClusterNodeInterfaceCidr!] (type)
        if (this.InterfaceCidrs != null) {
            var fspec = this.InterfaceCidrs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "interfaceCidrs {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ClusterNodePlatformType? PlatformType
        // GraphQL -> platformType: ClusterNodePlatformType (enum)
        if (this.PlatformType == null && Exploration.Includes(parent + ".platformType", true))
        {
            this.PlatformType = new ClusterNodePlatformType();
        }
        //      C# -> ClusterNodePosition? Position
        // GraphQL -> position: ClusterNodePosition (enum)
        if (this.Position == null && Exploration.Includes(parent + ".position", true))
        {
            this.Position = new ClusterNodePosition();
        }
        //      C# -> ClusterNodeStatus? Status
        // GraphQL -> status: ClusterNodeStatus (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new ClusterNodeStatus();
        }
        //      C# -> System.String? BrikId
        // GraphQL -> brikId: String! (scalar)
        if (this.BrikId == null && Exploration.Includes(parent + ".brikId", true))
        {
            this.BrikId = "FETCH";
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (this.ClusterId == null && Exploration.Includes(parent + ".clusterId", true))
        {
            this.ClusterId = "FETCH";
        }
        //      C# -> System.Int32? CpuCores
        // GraphQL -> cpuCores: Int (scalar)
        if (this.CpuCores == null && Exploration.Includes(parent + ".cpuCores", true))
        {
            this.CpuCores = Int32.MinValue;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        if (this.Hostname == null && Exploration.Includes(parent + ".hostname", true))
        {
            this.Hostname = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String (scalar)
        if (this.IpAddress == null && Exploration.Includes(parent + ".ipAddress", true))
        {
            this.IpAddress = "FETCH";
        }
        //      C# -> System.Boolean? NeedsInspection
        // GraphQL -> needsInspection: Boolean (scalar)
        if (this.NeedsInspection == null && Exploration.Includes(parent + ".needsInspection", true))
        {
            this.NeedsInspection = true;
        }
        //      C# -> System.String? NetworkSpeed
        // GraphQL -> networkSpeed: String (scalar)
        if (this.NetworkSpeed == null && Exploration.Includes(parent + ".networkSpeed", true))
        {
            this.NetworkSpeed = "FETCH";
        }
        //      C# -> System.Int64? Ram
        // GraphQL -> ram: Long (scalar)
        if (this.Ram == null && Exploration.Includes(parent + ".ram", true))
        {
            this.Ram = new System.Int64();
        }
        //      C# -> List<HealthPolicyStatus>? HardwareHealth
        // GraphQL -> hardwareHealth: [HealthPolicyStatus!] (type)
        if (this.HardwareHealth == null && Exploration.Includes(parent + ".hardwareHealth"))
        {
            this.HardwareHealth = new List<HealthPolicyStatus>();
            this.HardwareHealth.ApplyExploratoryFieldSpec(parent + ".hardwareHealth");
        }
        //      C# -> List<ClusterNodeInterfaceCidr>? InterfaceCidrs
        // GraphQL -> interfaceCidrs: [ClusterNodeInterfaceCidr!] (type)
        if (this.InterfaceCidrs == null && Exploration.Includes(parent + ".interfaceCidrs"))
        {
            this.InterfaceCidrs = new List<ClusterNodeInterfaceCidr>();
            this.InterfaceCidrs.ApplyExploratoryFieldSpec(parent + ".interfaceCidrs");
        }
    }


    #endregion

    } // class ClusterNode
    
    #endregion

    public static class ListClusterNodeExtensions
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
            this List<ClusterNode> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterNode> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterNode());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types