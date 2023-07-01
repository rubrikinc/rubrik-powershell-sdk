// VsphereRecoverySpec.cs
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
    #region VsphereRecoverySpec
 
    public class VsphereRecoverySpec: BaseType, RecoverySpec
    {
        #region members

        //      C# -> System.Boolean? EnableMacPreserveOnly
        // GraphQL -> enableMacPreserveOnly: Boolean (scalar)
        [JsonProperty("enableMacPreserveOnly")]
        public System.Boolean? EnableMacPreserveOnly { get; set; }

        //      C# -> System.Boolean? EnableNetworkDisconnect
        // GraphQL -> enableNetworkDisconnect: Boolean! (scalar)
        [JsonProperty("enableNetworkDisconnect")]
        public System.Boolean? EnableNetworkDisconnect { get; set; }

        //      C# -> System.Boolean? EnableNetworkPreserve
        // GraphQL -> enableNetworkPreserve: Boolean (scalar)
        [JsonProperty("enableNetworkPreserve")]
        public System.Boolean? EnableNetworkPreserve { get; set; }

        //      C# -> System.Int32? MemoryMbs
        // GraphQL -> memoryMbs: Int! (scalar)
        [JsonProperty("memoryMbs")]
        public System.Int32? MemoryMbs { get; set; }

        //      C# -> System.Int64? RecoveryPointOpt
        // GraphQL -> recoveryPointOpt: Long (scalar)
        [JsonProperty("recoveryPointOpt")]
        public System.Int64? RecoveryPointOpt { get; set; }

        //      C# -> System.String? UserData
        // GraphQL -> userData: String (scalar)
        [JsonProperty("userData")]
        public System.String? UserData { get; set; }

        //      C# -> System.Int32? Vcpus
        // GraphQL -> vCpus: Int! (scalar)
        [JsonProperty("vCpus")]
        public System.Int32? Vcpus { get; set; }

        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        [JsonProperty("version")]
        public System.Int64? Version { get; set; }

        //      C# -> VsphereRecoveryComputeTarget? Target
        // GraphQL -> target: VsphereRecoveryComputeTarget! (type)
        [JsonProperty("target")]
        public VsphereRecoveryComputeTarget? Target { get; set; }

        //      C# -> List<VsphereVmNicSpec>? VsphereNicSpecs
        // GraphQL -> vSphereNicSpecs: [VSphereVMNicSpec!]! (type)
        [JsonProperty("vSphereNicSpecs")]
        public List<VsphereVmNicSpec>? VsphereNicSpecs { get; set; }

        //      C# -> List<VsphereVmVolumeSpec>? VsphereVolumeSpecs
        // GraphQL -> vSphereVolumeSpecs: [VSphereVMVolumeSpec!]! (type)
        [JsonProperty("vSphereVolumeSpecs")]
        public List<VsphereVmVolumeSpec>? VsphereVolumeSpecs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VsphereRecoverySpec";
    }

    public VsphereRecoverySpec Set(
        System.Boolean? EnableMacPreserveOnly = null,
        System.Boolean? EnableNetworkDisconnect = null,
        System.Boolean? EnableNetworkPreserve = null,
        System.Int32? MemoryMbs = null,
        System.Int64? RecoveryPointOpt = null,
        System.String? UserData = null,
        System.Int32? Vcpus = null,
        System.Int64? Version = null,
        VsphereRecoveryComputeTarget? Target = null,
        List<VsphereVmNicSpec>? VsphereNicSpecs = null,
        List<VsphereVmVolumeSpec>? VsphereVolumeSpecs = null
    ) 
    {
        if ( EnableMacPreserveOnly != null ) {
            this.EnableMacPreserveOnly = EnableMacPreserveOnly;
        }
        if ( EnableNetworkDisconnect != null ) {
            this.EnableNetworkDisconnect = EnableNetworkDisconnect;
        }
        if ( EnableNetworkPreserve != null ) {
            this.EnableNetworkPreserve = EnableNetworkPreserve;
        }
        if ( MemoryMbs != null ) {
            this.MemoryMbs = MemoryMbs;
        }
        if ( RecoveryPointOpt != null ) {
            this.RecoveryPointOpt = RecoveryPointOpt;
        }
        if ( UserData != null ) {
            this.UserData = UserData;
        }
        if ( Vcpus != null ) {
            this.Vcpus = Vcpus;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( Target != null ) {
            this.Target = Target;
        }
        if ( VsphereNicSpecs != null ) {
            this.VsphereNicSpecs = VsphereNicSpecs;
        }
        if ( VsphereVolumeSpecs != null ) {
            this.VsphereVolumeSpecs = VsphereVolumeSpecs;
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
        //      C# -> System.Boolean? EnableMacPreserveOnly
        // GraphQL -> enableMacPreserveOnly: Boolean (scalar)
        if (this.EnableMacPreserveOnly != null) {
            s += ind + "enableMacPreserveOnly\n" ;
        }
        //      C# -> System.Boolean? EnableNetworkDisconnect
        // GraphQL -> enableNetworkDisconnect: Boolean! (scalar)
        if (this.EnableNetworkDisconnect != null) {
            s += ind + "enableNetworkDisconnect\n" ;
        }
        //      C# -> System.Boolean? EnableNetworkPreserve
        // GraphQL -> enableNetworkPreserve: Boolean (scalar)
        if (this.EnableNetworkPreserve != null) {
            s += ind + "enableNetworkPreserve\n" ;
        }
        //      C# -> System.Int32? MemoryMbs
        // GraphQL -> memoryMbs: Int! (scalar)
        if (this.MemoryMbs != null) {
            s += ind + "memoryMbs\n" ;
        }
        //      C# -> System.Int64? RecoveryPointOpt
        // GraphQL -> recoveryPointOpt: Long (scalar)
        if (this.RecoveryPointOpt != null) {
            s += ind + "recoveryPointOpt\n" ;
        }
        //      C# -> System.String? UserData
        // GraphQL -> userData: String (scalar)
        if (this.UserData != null) {
            s += ind + "userData\n" ;
        }
        //      C# -> System.Int32? Vcpus
        // GraphQL -> vCpus: Int! (scalar)
        if (this.Vcpus != null) {
            s += ind + "vCpus\n" ;
        }
        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        if (this.Version != null) {
            s += ind + "version\n" ;
        }
        //      C# -> VsphereRecoveryComputeTarget? Target
        // GraphQL -> target: VsphereRecoveryComputeTarget! (type)
        if (this.Target != null) {
            var fspec = this.Target.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "target {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<VsphereVmNicSpec>? VsphereNicSpecs
        // GraphQL -> vSphereNicSpecs: [VSphereVMNicSpec!]! (type)
        if (this.VsphereNicSpecs != null) {
            var fspec = this.VsphereNicSpecs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "vSphereNicSpecs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<VsphereVmVolumeSpec>? VsphereVolumeSpecs
        // GraphQL -> vSphereVolumeSpecs: [VSphereVMVolumeSpec!]! (type)
        if (this.VsphereVolumeSpecs != null) {
            var fspec = this.VsphereVolumeSpecs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "vSphereVolumeSpecs {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? EnableMacPreserveOnly
        // GraphQL -> enableMacPreserveOnly: Boolean (scalar)
        if (this.EnableMacPreserveOnly == null && Exploration.Includes(parent + ".enableMacPreserveOnly", true))
        {
            this.EnableMacPreserveOnly = true;
        }
        //      C# -> System.Boolean? EnableNetworkDisconnect
        // GraphQL -> enableNetworkDisconnect: Boolean! (scalar)
        if (this.EnableNetworkDisconnect == null && Exploration.Includes(parent + ".enableNetworkDisconnect", true))
        {
            this.EnableNetworkDisconnect = true;
        }
        //      C# -> System.Boolean? EnableNetworkPreserve
        // GraphQL -> enableNetworkPreserve: Boolean (scalar)
        if (this.EnableNetworkPreserve == null && Exploration.Includes(parent + ".enableNetworkPreserve", true))
        {
            this.EnableNetworkPreserve = true;
        }
        //      C# -> System.Int32? MemoryMbs
        // GraphQL -> memoryMbs: Int! (scalar)
        if (this.MemoryMbs == null && Exploration.Includes(parent + ".memoryMbs", true))
        {
            this.MemoryMbs = Int32.MinValue;
        }
        //      C# -> System.Int64? RecoveryPointOpt
        // GraphQL -> recoveryPointOpt: Long (scalar)
        if (this.RecoveryPointOpt == null && Exploration.Includes(parent + ".recoveryPointOpt", true))
        {
            this.RecoveryPointOpt = new System.Int64();
        }
        //      C# -> System.String? UserData
        // GraphQL -> userData: String (scalar)
        if (this.UserData == null && Exploration.Includes(parent + ".userData", true))
        {
            this.UserData = "FETCH";
        }
        //      C# -> System.Int32? Vcpus
        // GraphQL -> vCpus: Int! (scalar)
        if (this.Vcpus == null && Exploration.Includes(parent + ".vCpus", true))
        {
            this.Vcpus = Int32.MinValue;
        }
        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        if (this.Version == null && Exploration.Includes(parent + ".version", true))
        {
            this.Version = new System.Int64();
        }
        //      C# -> VsphereRecoveryComputeTarget? Target
        // GraphQL -> target: VsphereRecoveryComputeTarget! (type)
        if (this.Target == null && Exploration.Includes(parent + ".target"))
        {
            this.Target = new VsphereRecoveryComputeTarget();
            this.Target.ApplyExploratoryFieldSpec(parent + ".target");
        }
        //      C# -> List<VsphereVmNicSpec>? VsphereNicSpecs
        // GraphQL -> vSphereNicSpecs: [VSphereVMNicSpec!]! (type)
        if (this.VsphereNicSpecs == null && Exploration.Includes(parent + ".vSphereNicSpecs"))
        {
            this.VsphereNicSpecs = new List<VsphereVmNicSpec>();
            this.VsphereNicSpecs.ApplyExploratoryFieldSpec(parent + ".vSphereNicSpecs");
        }
        //      C# -> List<VsphereVmVolumeSpec>? VsphereVolumeSpecs
        // GraphQL -> vSphereVolumeSpecs: [VSphereVMVolumeSpec!]! (type)
        if (this.VsphereVolumeSpecs == null && Exploration.Includes(parent + ".vSphereVolumeSpecs"))
        {
            this.VsphereVolumeSpecs = new List<VsphereVmVolumeSpec>();
            this.VsphereVolumeSpecs.ApplyExploratoryFieldSpec(parent + ".vSphereVolumeSpecs");
        }
    }


    #endregion

    } // class VsphereRecoverySpec
    
    #endregion

    public static class ListVsphereRecoverySpecExtensions
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
            this List<VsphereRecoverySpec> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VsphereRecoverySpec> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereRecoverySpec());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types