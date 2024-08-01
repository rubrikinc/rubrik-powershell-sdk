// NutanixRecoverySpec.cs
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
    #region NutanixRecoverySpec
 
    public class NutanixRecoverySpec: BaseType, RecoverySpec
    {
        #region members

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String! (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> System.Int64? MemoryMbs
        // GraphQL -> memoryMbs: Long! (scalar)
        [JsonProperty("memoryMbs")]
        public System.Int64? MemoryMbs { get; set; }

        //      C# -> System.Boolean? PreserveMacAddress
        // GraphQL -> preserveMacAddress: Boolean! (scalar)
        [JsonProperty("preserveMacAddress")]
        public System.Boolean? PreserveMacAddress { get; set; }

        //      C# -> System.Int64? RecoveryPointOpt
        // GraphQL -> recoveryPointOpt: Long (scalar)
        [JsonProperty("recoveryPointOpt")]
        public System.Int64? RecoveryPointOpt { get; set; }

        //      C# -> System.Boolean? RemoveAllNetwork
        // GraphQL -> removeAllNetwork: Boolean! (scalar)
        [JsonProperty("removeAllNetwork")]
        public System.Boolean? RemoveAllNetwork { get; set; }

        //      C# -> System.String? UserData
        // GraphQL -> userData: String (scalar)
        [JsonProperty("userData")]
        public System.String? UserData { get; set; }

        //      C# -> System.Int64? Vcpus
        // GraphQL -> vCpus: Long! (scalar)
        [JsonProperty("vCpus")]
        public System.Int64? Vcpus { get; set; }

        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        [JsonProperty("version")]
        public System.Int64? Version { get; set; }

        //      C# -> List<NutanixVmNicSpec>? Nics
        // GraphQL -> nics: [NutanixVMNicSpec!]! (type)
        [JsonProperty("nics")]
        public List<NutanixVmNicSpec>? Nics { get; set; }

        //      C# -> NutanixRecoveryComputeTarget? Target
        // GraphQL -> target: NutanixRecoveryComputeTarget! (type)
        [JsonProperty("target")]
        public NutanixRecoveryComputeTarget? Target { get; set; }

        //      C# -> List<NutanixVmVolumeSpec>? Volumes
        // GraphQL -> volumes: [NutanixVMVolumeSpec!]! (type)
        [JsonProperty("volumes")]
        public List<NutanixVmVolumeSpec>? Volumes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NutanixRecoverySpec";
    }

    public NutanixRecoverySpec Set(
        System.String? ClusterId = null,
        System.Int64? MemoryMbs = null,
        System.Boolean? PreserveMacAddress = null,
        System.Int64? RecoveryPointOpt = null,
        System.Boolean? RemoveAllNetwork = null,
        System.String? UserData = null,
        System.Int64? Vcpus = null,
        System.Int64? Version = null,
        List<NutanixVmNicSpec>? Nics = null,
        NutanixRecoveryComputeTarget? Target = null,
        List<NutanixVmVolumeSpec>? Volumes = null
    ) 
    {
        if ( ClusterId != null ) {
            this.ClusterId = ClusterId;
        }
        if ( MemoryMbs != null ) {
            this.MemoryMbs = MemoryMbs;
        }
        if ( PreserveMacAddress != null ) {
            this.PreserveMacAddress = PreserveMacAddress;
        }
        if ( RecoveryPointOpt != null ) {
            this.RecoveryPointOpt = RecoveryPointOpt;
        }
        if ( RemoveAllNetwork != null ) {
            this.RemoveAllNetwork = RemoveAllNetwork;
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
        if ( Nics != null ) {
            this.Nics = Nics;
        }
        if ( Target != null ) {
            this.Target = Target;
        }
        if ( Volumes != null ) {
            this.Volumes = Volumes;
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
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String! (scalar)
        if (this.ClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterId\n" ;
            } else {
                s += ind + "clusterId\n" ;
            }
        }
        //      C# -> System.Int64? MemoryMbs
        // GraphQL -> memoryMbs: Long! (scalar)
        if (this.MemoryMbs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "memoryMbs\n" ;
            } else {
                s += ind + "memoryMbs\n" ;
            }
        }
        //      C# -> System.Boolean? PreserveMacAddress
        // GraphQL -> preserveMacAddress: Boolean! (scalar)
        if (this.PreserveMacAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "preserveMacAddress\n" ;
            } else {
                s += ind + "preserveMacAddress\n" ;
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
        //      C# -> System.Boolean? RemoveAllNetwork
        // GraphQL -> removeAllNetwork: Boolean! (scalar)
        if (this.RemoveAllNetwork != null) {
            if (conf.Flat) {
                s += conf.Prefix + "removeAllNetwork\n" ;
            } else {
                s += ind + "removeAllNetwork\n" ;
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
        //      C# -> System.Int64? Vcpus
        // GraphQL -> vCpus: Long! (scalar)
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
        //      C# -> List<NutanixVmNicSpec>? Nics
        // GraphQL -> nics: [NutanixVMNicSpec!]! (type)
        if (this.Nics != null) {
            var fspec = this.Nics.AsFieldSpec(conf.Child("nics"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nics" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> NutanixRecoveryComputeTarget? Target
        // GraphQL -> target: NutanixRecoveryComputeTarget! (type)
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
        //      C# -> List<NutanixVmVolumeSpec>? Volumes
        // GraphQL -> volumes: [NutanixVMVolumeSpec!]! (type)
        if (this.Volumes != null) {
            var fspec = this.Volumes.AsFieldSpec(conf.Child("volumes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "volumes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String! (scalar)
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
        //      C# -> System.Int64? MemoryMbs
        // GraphQL -> memoryMbs: Long! (scalar)
        if (ec.Includes("memoryMbs",true))
        {
            if(this.MemoryMbs == null) {

                this.MemoryMbs = new System.Int64();

            } else {


            }
        }
        else if (this.MemoryMbs != null && ec.Excludes("memoryMbs",true))
        {
            this.MemoryMbs = null;
        }
        //      C# -> System.Boolean? PreserveMacAddress
        // GraphQL -> preserveMacAddress: Boolean! (scalar)
        if (ec.Includes("preserveMacAddress",true))
        {
            if(this.PreserveMacAddress == null) {

                this.PreserveMacAddress = true;

            } else {


            }
        }
        else if (this.PreserveMacAddress != null && ec.Excludes("preserveMacAddress",true))
        {
            this.PreserveMacAddress = null;
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
        //      C# -> System.Boolean? RemoveAllNetwork
        // GraphQL -> removeAllNetwork: Boolean! (scalar)
        if (ec.Includes("removeAllNetwork",true))
        {
            if(this.RemoveAllNetwork == null) {

                this.RemoveAllNetwork = true;

            } else {


            }
        }
        else if (this.RemoveAllNetwork != null && ec.Excludes("removeAllNetwork",true))
        {
            this.RemoveAllNetwork = null;
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
        //      C# -> System.Int64? Vcpus
        // GraphQL -> vCpus: Long! (scalar)
        if (ec.Includes("vCpus",true))
        {
            if(this.Vcpus == null) {

                this.Vcpus = new System.Int64();

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
        //      C# -> List<NutanixVmNicSpec>? Nics
        // GraphQL -> nics: [NutanixVMNicSpec!]! (type)
        if (ec.Includes("nics",false))
        {
            if(this.Nics == null) {

                this.Nics = new List<NutanixVmNicSpec>();
                this.Nics.ApplyExploratoryFieldSpec(ec.NewChild("nics"));

            } else {

                this.Nics.ApplyExploratoryFieldSpec(ec.NewChild("nics"));

            }
        }
        else if (this.Nics != null && ec.Excludes("nics",false))
        {
            this.Nics = null;
        }
        //      C# -> NutanixRecoveryComputeTarget? Target
        // GraphQL -> target: NutanixRecoveryComputeTarget! (type)
        if (ec.Includes("target",false))
        {
            if(this.Target == null) {

                this.Target = new NutanixRecoveryComputeTarget();
                this.Target.ApplyExploratoryFieldSpec(ec.NewChild("target"));

            } else {

                this.Target.ApplyExploratoryFieldSpec(ec.NewChild("target"));

            }
        }
        else if (this.Target != null && ec.Excludes("target",false))
        {
            this.Target = null;
        }
        //      C# -> List<NutanixVmVolumeSpec>? Volumes
        // GraphQL -> volumes: [NutanixVMVolumeSpec!]! (type)
        if (ec.Includes("volumes",false))
        {
            if(this.Volumes == null) {

                this.Volumes = new List<NutanixVmVolumeSpec>();
                this.Volumes.ApplyExploratoryFieldSpec(ec.NewChild("volumes"));

            } else {

                this.Volumes.ApplyExploratoryFieldSpec(ec.NewChild("volumes"));

            }
        }
        else if (this.Volumes != null && ec.Excludes("volumes",false))
        {
            this.Volumes = null;
        }
    }


    #endregion

    } // class NutanixRecoverySpec
    
    #endregion

    public static class ListNutanixRecoverySpecExtensions
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
            this List<NutanixRecoverySpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NutanixRecoverySpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NutanixRecoverySpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixRecoverySpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NutanixRecoverySpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types