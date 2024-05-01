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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "BootstrappableNodeInfo";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int64? CapacityInBytes
        // GraphQL -> capacityInBytes: Long (scalar)
        if (this.CapacityInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "capacityInBytes\n" ;
            } else {
                s += ind + "capacityInBytes\n" ;
            }
        }
        //      C# -> System.String? ChassisId
        // GraphQL -> chassisId: String (scalar)
        if (this.ChassisId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "chassisId\n" ;
            } else {
                s += ind + "chassisId\n" ;
            }
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostname\n" ;
            } else {
                s += ind + "hostname\n" ;
            }
        }
        //      C# -> System.String? Ipv6
        // GraphQL -> ipv6: String! (scalar)
        if (this.Ipv6 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipv6\n" ;
            } else {
                s += ind + "ipv6\n" ;
            }
        }
        //      C# -> System.Boolean? IsAllCopper
        // GraphQL -> isAllCopper: Boolean (scalar)
        if (this.IsAllCopper != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAllCopper\n" ;
            } else {
                s += ind + "isAllCopper\n" ;
            }
        }
        //      C# -> System.Boolean? IsBond0Eth0Enabled
        // GraphQL -> isBond0Eth0Enabled: Boolean (scalar)
        if (this.IsBond0Eth0Enabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isBond0Eth0Enabled\n" ;
            } else {
                s += ind + "isBond0Eth0Enabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsBond0Eth1Enabled
        // GraphQL -> isBond0Eth1Enabled: Boolean (scalar)
        if (this.IsBond0Eth1Enabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isBond0Eth1Enabled\n" ;
            } else {
                s += ind + "isBond0Eth1Enabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsBond0Reachable
        // GraphQL -> isBond0Reachable: Boolean (scalar)
        if (this.IsBond0Reachable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isBond0Reachable\n" ;
            } else {
                s += ind + "isBond0Reachable\n" ;
            }
        }
        //      C# -> System.Boolean? IsBond1Eth2Enabled
        // GraphQL -> isBond1Eth2Enabled: Boolean (scalar)
        if (this.IsBond1Eth2Enabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isBond1Eth2Enabled\n" ;
            } else {
                s += ind + "isBond1Eth2Enabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsBond1Eth3Enabled
        // GraphQL -> isBond1Eth3Enabled: Boolean (scalar)
        if (this.IsBond1Eth3Enabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isBond1Eth3Enabled\n" ;
            } else {
                s += ind + "isBond1Eth3Enabled\n" ;
            }
        }
        //      C# -> System.String? NodePosition
        // GraphQL -> nodePosition: String (scalar)
        if (this.NodePosition != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodePosition\n" ;
            } else {
                s += ind + "nodePosition\n" ;
            }
        }
        //      C# -> System.String? PlatformName
        // GraphQL -> platformName: String (scalar)
        if (this.PlatformName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "platformName\n" ;
            } else {
                s += ind + "platformName\n" ;
            }
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? CapacityInBytes
        // GraphQL -> capacityInBytes: Long (scalar)
        if (ec.Includes("capacityInBytes",true))
        {
            if(this.CapacityInBytes == null) {

                this.CapacityInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.CapacityInBytes != null && ec.Excludes("capacityInBytes",true))
        {
            this.CapacityInBytes = null;
        }
        //      C# -> System.String? ChassisId
        // GraphQL -> chassisId: String (scalar)
        if (ec.Includes("chassisId",true))
        {
            if(this.ChassisId == null) {

                this.ChassisId = "FETCH";

            } else {


            }
        }
        else if (this.ChassisId != null && ec.Excludes("chassisId",true))
        {
            this.ChassisId = null;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
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
        //      C# -> System.String? Ipv6
        // GraphQL -> ipv6: String! (scalar)
        if (ec.Includes("ipv6",true))
        {
            if(this.Ipv6 == null) {

                this.Ipv6 = "FETCH";

            } else {


            }
        }
        else if (this.Ipv6 != null && ec.Excludes("ipv6",true))
        {
            this.Ipv6 = null;
        }
        //      C# -> System.Boolean? IsAllCopper
        // GraphQL -> isAllCopper: Boolean (scalar)
        if (ec.Includes("isAllCopper",true))
        {
            if(this.IsAllCopper == null) {

                this.IsAllCopper = true;

            } else {


            }
        }
        else if (this.IsAllCopper != null && ec.Excludes("isAllCopper",true))
        {
            this.IsAllCopper = null;
        }
        //      C# -> System.Boolean? IsBond0Eth0Enabled
        // GraphQL -> isBond0Eth0Enabled: Boolean (scalar)
        if (ec.Includes("isBond0Eth0Enabled",true))
        {
            if(this.IsBond0Eth0Enabled == null) {

                this.IsBond0Eth0Enabled = true;

            } else {


            }
        }
        else if (this.IsBond0Eth0Enabled != null && ec.Excludes("isBond0Eth0Enabled",true))
        {
            this.IsBond0Eth0Enabled = null;
        }
        //      C# -> System.Boolean? IsBond0Eth1Enabled
        // GraphQL -> isBond0Eth1Enabled: Boolean (scalar)
        if (ec.Includes("isBond0Eth1Enabled",true))
        {
            if(this.IsBond0Eth1Enabled == null) {

                this.IsBond0Eth1Enabled = true;

            } else {


            }
        }
        else if (this.IsBond0Eth1Enabled != null && ec.Excludes("isBond0Eth1Enabled",true))
        {
            this.IsBond0Eth1Enabled = null;
        }
        //      C# -> System.Boolean? IsBond0Reachable
        // GraphQL -> isBond0Reachable: Boolean (scalar)
        if (ec.Includes("isBond0Reachable",true))
        {
            if(this.IsBond0Reachable == null) {

                this.IsBond0Reachable = true;

            } else {


            }
        }
        else if (this.IsBond0Reachable != null && ec.Excludes("isBond0Reachable",true))
        {
            this.IsBond0Reachable = null;
        }
        //      C# -> System.Boolean? IsBond1Eth2Enabled
        // GraphQL -> isBond1Eth2Enabled: Boolean (scalar)
        if (ec.Includes("isBond1Eth2Enabled",true))
        {
            if(this.IsBond1Eth2Enabled == null) {

                this.IsBond1Eth2Enabled = true;

            } else {


            }
        }
        else if (this.IsBond1Eth2Enabled != null && ec.Excludes("isBond1Eth2Enabled",true))
        {
            this.IsBond1Eth2Enabled = null;
        }
        //      C# -> System.Boolean? IsBond1Eth3Enabled
        // GraphQL -> isBond1Eth3Enabled: Boolean (scalar)
        if (ec.Includes("isBond1Eth3Enabled",true))
        {
            if(this.IsBond1Eth3Enabled == null) {

                this.IsBond1Eth3Enabled = true;

            } else {


            }
        }
        else if (this.IsBond1Eth3Enabled != null && ec.Excludes("isBond1Eth3Enabled",true))
        {
            this.IsBond1Eth3Enabled = null;
        }
        //      C# -> System.String? NodePosition
        // GraphQL -> nodePosition: String (scalar)
        if (ec.Includes("nodePosition",true))
        {
            if(this.NodePosition == null) {

                this.NodePosition = "FETCH";

            } else {


            }
        }
        else if (this.NodePosition != null && ec.Excludes("nodePosition",true))
        {
            this.NodePosition = null;
        }
        //      C# -> System.String? PlatformName
        // GraphQL -> platformName: String (scalar)
        if (ec.Includes("platformName",true))
        {
            if(this.PlatformName == null) {

                this.PlatformName = "FETCH";

            } else {


            }
        }
        else if (this.PlatformName != null && ec.Excludes("platformName",true))
        {
            this.PlatformName = null;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
    }


    #endregion

    } // class BootstrappableNodeInfo
    
    #endregion

    public static class ListBootstrappableNodeInfoExtensions
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
            this List<BootstrappableNodeInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BootstrappableNodeInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BootstrappableNodeInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BootstrappableNodeInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BootstrappableNodeInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types