// ClusterNode.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:01.
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
    #region ClusterNode
    public class ClusterNode: IFragment
    {
        #region members
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

        #endregion

    #region methods

    public ClusterNode Set(
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
        List<ClusterNodeInterfaceCidr>? InterfaceCidrs = null,
        ClusterNodePlatformType? PlatformType = null,
        ClusterNodePosition? Position = null,
        ClusterNodeStatus? Status = null
    ) 
    {
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
        if ( PlatformType != null ) {
            this.PlatformType = PlatformType;
        }
        if ( Position != null ) {
            this.Position = Position;
        }
        if ( Status != null ) {
            this.Status = Status;
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
            //      C# -> System.String? BrikId
            // GraphQL -> brikId: String! (scalar)
            if (this.BrikId != null)
            {
                 s += ind + "brikId\n";

            }
            //      C# -> System.String? ClusterId
            // GraphQL -> clusterId: UUID! (scalar)
            if (this.ClusterId != null)
            {
                 s += ind + "clusterId\n";

            }
            //      C# -> System.Int32? CpuCores
            // GraphQL -> cpuCores: Int (scalar)
            if (this.CpuCores != null)
            {
                 s += ind + "cpuCores\n";

            }
            //      C# -> System.String? Hostname
            // GraphQL -> hostname: String (scalar)
            if (this.Hostname != null)
            {
                 s += ind + "hostname\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? IpAddress
            // GraphQL -> ipAddress: String (scalar)
            if (this.IpAddress != null)
            {
                 s += ind + "ipAddress\n";

            }
            //      C# -> System.Boolean? NeedsInspection
            // GraphQL -> needsInspection: Boolean (scalar)
            if (this.NeedsInspection != null)
            {
                 s += ind + "needsInspection\n";

            }
            //      C# -> System.String? NetworkSpeed
            // GraphQL -> networkSpeed: String (scalar)
            if (this.NetworkSpeed != null)
            {
                 s += ind + "networkSpeed\n";

            }
            //      C# -> System.Int64? Ram
            // GraphQL -> ram: Long (scalar)
            if (this.Ram != null)
            {
                 s += ind + "ram\n";

            }
            //      C# -> List<HealthPolicyStatus>? HardwareHealth
            // GraphQL -> hardwareHealth: [HealthPolicyStatus!] (type)
            if (this.HardwareHealth != null)
            {
                 s += ind + "hardwareHealth\n";

                 s += ind + "{\n" + 
                 this.HardwareHealth.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ClusterNodeInterfaceCidr>? InterfaceCidrs
            // GraphQL -> interfaceCidrs: [ClusterNodeInterfaceCidr!] (type)
            if (this.InterfaceCidrs != null)
            {
                 s += ind + "interfaceCidrs\n";

                 s += ind + "{\n" + 
                 this.InterfaceCidrs.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ClusterNodePlatformType? PlatformType
            // GraphQL -> platformType: ClusterNodePlatformType (enum)
            if (this.PlatformType != null)
            {
                 s += ind + "platformType\n";

            }
            //      C# -> ClusterNodePosition? Position
            // GraphQL -> position: ClusterNodePosition (enum)
            if (this.Position != null)
            {
                 s += ind + "position\n";

            }
            //      C# -> ClusterNodeStatus? Status
            // GraphQL -> status: ClusterNodeStatus (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? BrikId
            // GraphQL -> brikId: String! (scalar)
            if (this.BrikId == null && Exploration.Includes(parent + ".brikId$"))
            {
                this.BrikId = new System.String("FETCH");
            }
            //      C# -> System.String? ClusterId
            // GraphQL -> clusterId: UUID! (scalar)
            if (this.ClusterId == null && Exploration.Includes(parent + ".clusterId$"))
            {
                this.ClusterId = new System.String("FETCH");
            }
            //      C# -> System.Int32? CpuCores
            // GraphQL -> cpuCores: Int (scalar)
            if (this.CpuCores == null && Exploration.Includes(parent + ".cpuCores$"))
            {
                this.CpuCores = new System.Int32();
            }
            //      C# -> System.String? Hostname
            // GraphQL -> hostname: String (scalar)
            if (this.Hostname == null && Exploration.Includes(parent + ".hostname$"))
            {
                this.Hostname = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? IpAddress
            // GraphQL -> ipAddress: String (scalar)
            if (this.IpAddress == null && Exploration.Includes(parent + ".ipAddress$"))
            {
                this.IpAddress = new System.String("FETCH");
            }
            //      C# -> System.Boolean? NeedsInspection
            // GraphQL -> needsInspection: Boolean (scalar)
            if (this.NeedsInspection == null && Exploration.Includes(parent + ".needsInspection$"))
            {
                this.NeedsInspection = new System.Boolean();
            }
            //      C# -> System.String? NetworkSpeed
            // GraphQL -> networkSpeed: String (scalar)
            if (this.NetworkSpeed == null && Exploration.Includes(parent + ".networkSpeed$"))
            {
                this.NetworkSpeed = new System.String("FETCH");
            }
            //      C# -> System.Int64? Ram
            // GraphQL -> ram: Long (scalar)
            if (this.Ram == null && Exploration.Includes(parent + ".ram$"))
            {
                this.Ram = new System.Int64();
            }
            //      C# -> List<HealthPolicyStatus>? HardwareHealth
            // GraphQL -> hardwareHealth: [HealthPolicyStatus!] (type)
            if (this.HardwareHealth == null && Exploration.Includes(parent + ".hardwareHealth"))
            {
                this.HardwareHealth = new List<HealthPolicyStatus>();
                this.HardwareHealth.ApplyExploratoryFragment(parent + ".hardwareHealth");
            }
            //      C# -> List<ClusterNodeInterfaceCidr>? InterfaceCidrs
            // GraphQL -> interfaceCidrs: [ClusterNodeInterfaceCidr!] (type)
            if (this.InterfaceCidrs == null && Exploration.Includes(parent + ".interfaceCidrs"))
            {
                this.InterfaceCidrs = new List<ClusterNodeInterfaceCidr>();
                this.InterfaceCidrs.ApplyExploratoryFragment(parent + ".interfaceCidrs");
            }
            //      C# -> ClusterNodePlatformType? PlatformType
            // GraphQL -> platformType: ClusterNodePlatformType (enum)
            if (this.PlatformType == null && Exploration.Includes(parent + ".platformType$"))
            {
                this.PlatformType = new ClusterNodePlatformType();
            }
            //      C# -> ClusterNodePosition? Position
            // GraphQL -> position: ClusterNodePosition (enum)
            if (this.Position == null && Exploration.Includes(parent + ".position$"))
            {
                this.Position = new ClusterNodePosition();
            }
            //      C# -> ClusterNodeStatus? Status
            // GraphQL -> status: ClusterNodeStatus (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new ClusterNodeStatus();
            }
        }


    #endregion

    } // class ClusterNode
    #endregion

    public static class ListClusterNodeExtensions
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
            this List<ClusterNode> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterNode> list, 
            String parent = "")
        {
            var item = new ClusterNode();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types