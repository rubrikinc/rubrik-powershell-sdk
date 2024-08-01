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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? EnableMacPreserveOnly
        // GraphQL -> enableMacPreserveOnly: Boolean (scalar)
        if (this.EnableMacPreserveOnly != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enableMacPreserveOnly\n" ;
            } else {
                s += ind + "enableMacPreserveOnly\n" ;
            }
        }
        //      C# -> System.Boolean? EnableNetworkDisconnect
        // GraphQL -> enableNetworkDisconnect: Boolean! (scalar)
        if (this.EnableNetworkDisconnect != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enableNetworkDisconnect\n" ;
            } else {
                s += ind + "enableNetworkDisconnect\n" ;
            }
        }
        //      C# -> System.Boolean? EnableNetworkPreserve
        // GraphQL -> enableNetworkPreserve: Boolean (scalar)
        if (this.EnableNetworkPreserve != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enableNetworkPreserve\n" ;
            } else {
                s += ind + "enableNetworkPreserve\n" ;
            }
        }
        //      C# -> System.Int32? MemoryMbs
        // GraphQL -> memoryMbs: Int! (scalar)
        if (this.MemoryMbs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "memoryMbs\n" ;
            } else {
                s += ind + "memoryMbs\n" ;
            }
        }
        //      C# -> System.Int64? RecoveryPointOpt
        // GraphQL -> recoveryPointOpt: Long (scalar)
        if (this.RecoveryPointOpt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPointOpt\n" ;
            } else {
                s += ind + "recoveryPointOpt\n" ;
            }
        }
        //      C# -> System.String? UserData
        // GraphQL -> userData: String (scalar)
        if (this.UserData != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userData\n" ;
            } else {
                s += ind + "userData\n" ;
            }
        }
        //      C# -> System.Int32? Vcpus
        // GraphQL -> vCpus: Int! (scalar)
        if (this.Vcpus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vCpus\n" ;
            } else {
                s += ind + "vCpus\n" ;
            }
        }
        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> VsphereRecoveryComputeTarget? Target
        // GraphQL -> target: VsphereRecoveryComputeTarget! (type)
        if (this.Target != null) {
            var fspec = this.Target.AsFieldSpec(conf.Child("target"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "target" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<VsphereVmNicSpec>? VsphereNicSpecs
        // GraphQL -> vSphereNicSpecs: [VSphereVMNicSpec!]! (type)
        if (this.VsphereNicSpecs != null) {
            var fspec = this.VsphereNicSpecs.AsFieldSpec(conf.Child("vSphereNicSpecs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "vSphereNicSpecs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<VsphereVmVolumeSpec>? VsphereVolumeSpecs
        // GraphQL -> vSphereVolumeSpecs: [VSphereVMVolumeSpec!]! (type)
        if (this.VsphereVolumeSpecs != null) {
            var fspec = this.VsphereVolumeSpecs.AsFieldSpec(conf.Child("vSphereVolumeSpecs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "vSphereVolumeSpecs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? EnableMacPreserveOnly
        // GraphQL -> enableMacPreserveOnly: Boolean (scalar)
        if (ec.Includes("enableMacPreserveOnly",true))
        {
            if(this.EnableMacPreserveOnly == null) {

                this.EnableMacPreserveOnly = true;

            } else {


            }
        }
        else if (this.EnableMacPreserveOnly != null && ec.Excludes("enableMacPreserveOnly",true))
        {
            this.EnableMacPreserveOnly = null;
        }
        //      C# -> System.Boolean? EnableNetworkDisconnect
        // GraphQL -> enableNetworkDisconnect: Boolean! (scalar)
        if (ec.Includes("enableNetworkDisconnect",true))
        {
            if(this.EnableNetworkDisconnect == null) {

                this.EnableNetworkDisconnect = true;

            } else {


            }
        }
        else if (this.EnableNetworkDisconnect != null && ec.Excludes("enableNetworkDisconnect",true))
        {
            this.EnableNetworkDisconnect = null;
        }
        //      C# -> System.Boolean? EnableNetworkPreserve
        // GraphQL -> enableNetworkPreserve: Boolean (scalar)
        if (ec.Includes("enableNetworkPreserve",true))
        {
            if(this.EnableNetworkPreserve == null) {

                this.EnableNetworkPreserve = true;

            } else {


            }
        }
        else if (this.EnableNetworkPreserve != null && ec.Excludes("enableNetworkPreserve",true))
        {
            this.EnableNetworkPreserve = null;
        }
        //      C# -> System.Int32? MemoryMbs
        // GraphQL -> memoryMbs: Int! (scalar)
        if (ec.Includes("memoryMbs",true))
        {
            if(this.MemoryMbs == null) {

                this.MemoryMbs = Int32.MinValue;

            } else {


            }
        }
        else if (this.MemoryMbs != null && ec.Excludes("memoryMbs",true))
        {
            this.MemoryMbs = null;
        }
        //      C# -> System.Int64? RecoveryPointOpt
        // GraphQL -> recoveryPointOpt: Long (scalar)
        if (ec.Includes("recoveryPointOpt",true))
        {
            if(this.RecoveryPointOpt == null) {

                this.RecoveryPointOpt = new System.Int64();

            } else {


            }
        }
        else if (this.RecoveryPointOpt != null && ec.Excludes("recoveryPointOpt",true))
        {
            this.RecoveryPointOpt = null;
        }
        //      C# -> System.String? UserData
        // GraphQL -> userData: String (scalar)
        if (ec.Includes("userData",true))
        {
            if(this.UserData == null) {

                this.UserData = "FETCH";

            } else {


            }
        }
        else if (this.UserData != null && ec.Excludes("userData",true))
        {
            this.UserData = null;
        }
        //      C# -> System.Int32? Vcpus
        // GraphQL -> vCpus: Int! (scalar)
        if (ec.Includes("vCpus",true))
        {
            if(this.Vcpus == null) {

                this.Vcpus = Int32.MinValue;

            } else {


            }
        }
        else if (this.Vcpus != null && ec.Excludes("vCpus",true))
        {
            this.Vcpus = null;
        }
        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = new System.Int64();

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> VsphereRecoveryComputeTarget? Target
        // GraphQL -> target: VsphereRecoveryComputeTarget! (type)
        if (ec.Includes("target",false))
        {
            if(this.Target == null) {

                this.Target = new VsphereRecoveryComputeTarget();
                this.Target.ApplyExploratoryFieldSpec(ec.NewChild("target"));

            } else {

                this.Target.ApplyExploratoryFieldSpec(ec.NewChild("target"));

            }
        }
        else if (this.Target != null && ec.Excludes("target",false))
        {
            this.Target = null;
        }
        //      C# -> List<VsphereVmNicSpec>? VsphereNicSpecs
        // GraphQL -> vSphereNicSpecs: [VSphereVMNicSpec!]! (type)
        if (ec.Includes("vSphereNicSpecs",false))
        {
            if(this.VsphereNicSpecs == null) {

                this.VsphereNicSpecs = new List<VsphereVmNicSpec>();
                this.VsphereNicSpecs.ApplyExploratoryFieldSpec(ec.NewChild("vSphereNicSpecs"));

            } else {

                this.VsphereNicSpecs.ApplyExploratoryFieldSpec(ec.NewChild("vSphereNicSpecs"));

            }
        }
        else if (this.VsphereNicSpecs != null && ec.Excludes("vSphereNicSpecs",false))
        {
            this.VsphereNicSpecs = null;
        }
        //      C# -> List<VsphereVmVolumeSpec>? VsphereVolumeSpecs
        // GraphQL -> vSphereVolumeSpecs: [VSphereVMVolumeSpec!]! (type)
        if (ec.Includes("vSphereVolumeSpecs",false))
        {
            if(this.VsphereVolumeSpecs == null) {

                this.VsphereVolumeSpecs = new List<VsphereVmVolumeSpec>();
                this.VsphereVolumeSpecs.ApplyExploratoryFieldSpec(ec.NewChild("vSphereVolumeSpecs"));

            } else {

                this.VsphereVolumeSpecs.ApplyExploratoryFieldSpec(ec.NewChild("vSphereVolumeSpecs"));

            }
        }
        else if (this.VsphereVolumeSpecs != null && ec.Excludes("vSphereVolumeSpecs",false))
        {
            this.VsphereVolumeSpecs = null;
        }
    }


    #endregion

    } // class VsphereRecoverySpec
    
    #endregion

    public static class ListVsphereRecoverySpecExtensions
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
            this List<VsphereRecoverySpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VsphereRecoverySpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VsphereRecoverySpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereRecoverySpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VsphereRecoverySpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types