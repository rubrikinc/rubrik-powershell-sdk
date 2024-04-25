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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ClusterNodePlatformType? PlatformType
        // GraphQL -> platformType: ClusterNodePlatformType (enum)
        if (this.PlatformType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "platformType\n" ;
            } else {
                s += ind + "platformType\n" ;
            }
        }
        //      C# -> ClusterNodePosition? Position
        // GraphQL -> position: ClusterNodePosition (enum)
        if (this.Position != null) {
            if (conf.Flat) {
                s += conf.Prefix + "position\n" ;
            } else {
                s += ind + "position\n" ;
            }
        }
        //      C# -> ClusterNodeStatus? Status
        // GraphQL -> status: ClusterNodeStatus (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? BrikId
        // GraphQL -> brikId: String! (scalar)
        if (this.BrikId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "brikId\n" ;
            } else {
                s += ind + "brikId\n" ;
            }
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (this.ClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterId\n" ;
            } else {
                s += ind + "clusterId\n" ;
            }
        }
        //      C# -> System.Int32? CpuCores
        // GraphQL -> cpuCores: Int (scalar)
        if (this.CpuCores != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cpuCores\n" ;
            } else {
                s += ind + "cpuCores\n" ;
            }
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        if (this.Hostname != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostname\n" ;
            } else {
                s += ind + "hostname\n" ;
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
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String (scalar)
        if (this.IpAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipAddress\n" ;
            } else {
                s += ind + "ipAddress\n" ;
            }
        }
        //      C# -> System.Boolean? NeedsInspection
        // GraphQL -> needsInspection: Boolean (scalar)
        if (this.NeedsInspection != null) {
            if (conf.Flat) {
                s += conf.Prefix + "needsInspection\n" ;
            } else {
                s += ind + "needsInspection\n" ;
            }
        }
        //      C# -> System.String? NetworkSpeed
        // GraphQL -> networkSpeed: String (scalar)
        if (this.NetworkSpeed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkSpeed\n" ;
            } else {
                s += ind + "networkSpeed\n" ;
            }
        }
        //      C# -> System.Int64? Ram
        // GraphQL -> ram: Long (scalar)
        if (this.Ram != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ram\n" ;
            } else {
                s += ind + "ram\n" ;
            }
        }
        //      C# -> List<HealthPolicyStatus>? HardwareHealth
        // GraphQL -> hardwareHealth: [HealthPolicyStatus!] (type)
        if (this.HardwareHealth != null) {
            var fspec = this.HardwareHealth.AsFieldSpec(conf.Child("hardwareHealth"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hardwareHealth" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ClusterNodeInterfaceCidr>? InterfaceCidrs
        // GraphQL -> interfaceCidrs: [ClusterNodeInterfaceCidr!] (type)
        if (this.InterfaceCidrs != null) {
            var fspec = this.InterfaceCidrs.AsFieldSpec(conf.Child("interfaceCidrs"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "interfaceCidrs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ClusterNodePlatformType? PlatformType
        // GraphQL -> platformType: ClusterNodePlatformType (enum)
        if (ec.Includes("platformType",true))
        {
            if(this.PlatformType == null) {

                this.PlatformType = new ClusterNodePlatformType();

            } else {


            }
        }
        else if (this.PlatformType != null && ec.Excludes("platformType",true))
        {
            this.PlatformType = null;
        }
        //      C# -> ClusterNodePosition? Position
        // GraphQL -> position: ClusterNodePosition (enum)
        if (ec.Includes("position",true))
        {
            if(this.Position == null) {

                this.Position = new ClusterNodePosition();

            } else {


            }
        }
        else if (this.Position != null && ec.Excludes("position",true))
        {
            this.Position = null;
        }
        //      C# -> ClusterNodeStatus? Status
        // GraphQL -> status: ClusterNodeStatus (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new ClusterNodeStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? BrikId
        // GraphQL -> brikId: String! (scalar)
        if (ec.Includes("brikId",true))
        {
            if(this.BrikId == null) {

                this.BrikId = "FETCH";

            } else {


            }
        }
        else if (this.BrikId != null && ec.Excludes("brikId",true))
        {
            this.BrikId = null;
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (ec.Includes("clusterId",true))
        {
            if(this.ClusterId == null) {

                this.ClusterId = "FETCH";

            } else {


            }
        }
        else if (this.ClusterId != null && ec.Excludes("clusterId",true))
        {
            this.ClusterId = null;
        }
        //      C# -> System.Int32? CpuCores
        // GraphQL -> cpuCores: Int (scalar)
        if (ec.Includes("cpuCores",true))
        {
            if(this.CpuCores == null) {

                this.CpuCores = Int32.MinValue;

            } else {


            }
        }
        else if (this.CpuCores != null && ec.Excludes("cpuCores",true))
        {
            this.CpuCores = null;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        if (ec.Includes("hostname",true))
        {
            if(this.Hostname == null) {

                this.Hostname = "FETCH";

            } else {


            }
        }
        else if (this.Hostname != null && ec.Excludes("hostname",true))
        {
            this.Hostname = null;
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
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String (scalar)
        if (ec.Includes("ipAddress",true))
        {
            if(this.IpAddress == null) {

                this.IpAddress = "FETCH";

            } else {


            }
        }
        else if (this.IpAddress != null && ec.Excludes("ipAddress",true))
        {
            this.IpAddress = null;
        }
        //      C# -> System.Boolean? NeedsInspection
        // GraphQL -> needsInspection: Boolean (scalar)
        if (ec.Includes("needsInspection",true))
        {
            if(this.NeedsInspection == null) {

                this.NeedsInspection = true;

            } else {


            }
        }
        else if (this.NeedsInspection != null && ec.Excludes("needsInspection",true))
        {
            this.NeedsInspection = null;
        }
        //      C# -> System.String? NetworkSpeed
        // GraphQL -> networkSpeed: String (scalar)
        if (ec.Includes("networkSpeed",true))
        {
            if(this.NetworkSpeed == null) {

                this.NetworkSpeed = "FETCH";

            } else {


            }
        }
        else if (this.NetworkSpeed != null && ec.Excludes("networkSpeed",true))
        {
            this.NetworkSpeed = null;
        }
        //      C# -> System.Int64? Ram
        // GraphQL -> ram: Long (scalar)
        if (ec.Includes("ram",true))
        {
            if(this.Ram == null) {

                this.Ram = new System.Int64();

            } else {


            }
        }
        else if (this.Ram != null && ec.Excludes("ram",true))
        {
            this.Ram = null;
        }
        //      C# -> List<HealthPolicyStatus>? HardwareHealth
        // GraphQL -> hardwareHealth: [HealthPolicyStatus!] (type)
        if (ec.Includes("hardwareHealth",false))
        {
            if(this.HardwareHealth == null) {

                this.HardwareHealth = new List<HealthPolicyStatus>();
                this.HardwareHealth.ApplyExploratoryFieldSpec(ec.NewChild("hardwareHealth"));

            } else {

                this.HardwareHealth.ApplyExploratoryFieldSpec(ec.NewChild("hardwareHealth"));

            }
        }
        else if (this.HardwareHealth != null && ec.Excludes("hardwareHealth",false))
        {
            this.HardwareHealth = null;
        }
        //      C# -> List<ClusterNodeInterfaceCidr>? InterfaceCidrs
        // GraphQL -> interfaceCidrs: [ClusterNodeInterfaceCidr!] (type)
        if (ec.Includes("interfaceCidrs",false))
        {
            if(this.InterfaceCidrs == null) {

                this.InterfaceCidrs = new List<ClusterNodeInterfaceCidr>();
                this.InterfaceCidrs.ApplyExploratoryFieldSpec(ec.NewChild("interfaceCidrs"));

            } else {

                this.InterfaceCidrs.ApplyExploratoryFieldSpec(ec.NewChild("interfaceCidrs"));

            }
        }
        else if (this.InterfaceCidrs != null && ec.Excludes("interfaceCidrs",false))
        {
            this.InterfaceCidrs = null;
        }
    }


    #endregion

    } // class ClusterNode
    
    #endregion

    public static class ListClusterNodeExtensions
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
            this List<ClusterNode> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterNode> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterNode> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterNode());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterNode> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types