// VsphereVmRecoverySpec.cs
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
    #region VsphereVmRecoverySpec
    public class VsphereVmRecoverySpec: BaseType
    {
        #region members

        //      C# -> System.Boolean? EnableMacPreserveOnly
        // GraphQL -> enableMacPreserveOnly: Boolean! (scalar)
        [JsonProperty("enableMacPreserveOnly")]
        public System.Boolean? EnableMacPreserveOnly { get; set; }

        //      C# -> System.Boolean? EnableNetworkDisconnect
        // GraphQL -> enableNetworkDisconnect: Boolean! (scalar)
        [JsonProperty("enableNetworkDisconnect")]
        public System.Boolean? EnableNetworkDisconnect { get; set; }

        //      C# -> System.Boolean? EnableNetworkPreserve
        // GraphQL -> enableNetworkPreserve: Boolean! (scalar)
        [JsonProperty("enableNetworkPreserve")]
        public System.Boolean? EnableNetworkPreserve { get; set; }

        //      C# -> System.Int32? MemoryMbs
        // GraphQL -> memoryMbs: Int! (scalar)
        [JsonProperty("memoryMbs")]
        public System.Int32? MemoryMbs { get; set; }

        //      C# -> System.String? PostScript
        // GraphQL -> postScript: String! (scalar)
        [JsonProperty("postScript")]
        public System.String? PostScript { get; set; }

        //      C# -> System.Int32? Vcpus
        // GraphQL -> vcpus: Int! (scalar)
        [JsonProperty("vcpus")]
        public System.Int32? Vcpus { get; set; }

        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        [JsonProperty("version")]
        public System.Int64? Version { get; set; }

        //      C# -> List<VsphereVmNicSpec>? Nics
        // GraphQL -> nics: [VsphereVmNicSpec!]! (type)
        [JsonProperty("nics")]
        public List<VsphereVmNicSpec>? Nics { get; set; }

        //      C# -> VsphereComputeTarget? Target
        // GraphQL -> target: VsphereComputeTarget! (type)
        [JsonProperty("target")]
        public VsphereComputeTarget? Target { get; set; }

        //      C# -> List<VsphereVmVolumeSpec>? Volumes
        // GraphQL -> volumes: [VsphereVmVolumeSpec!]! (type)
        [JsonProperty("volumes")]
        public List<VsphereVmVolumeSpec>? Volumes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VsphereVmRecoverySpec";
    }

    public VsphereVmRecoverySpec Set(
        System.Boolean? EnableMacPreserveOnly = null,
        System.Boolean? EnableNetworkDisconnect = null,
        System.Boolean? EnableNetworkPreserve = null,
        System.Int32? MemoryMbs = null,
        System.String? PostScript = null,
        System.Int32? Vcpus = null,
        System.Int64? Version = null,
        List<VsphereVmNicSpec>? Nics = null,
        VsphereComputeTarget? Target = null,
        List<VsphereVmVolumeSpec>? Volumes = null
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
        if ( PostScript != null ) {
            this.PostScript = PostScript;
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
        //      C# -> System.Boolean? EnableMacPreserveOnly
        // GraphQL -> enableMacPreserveOnly: Boolean! (scalar)
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
        // GraphQL -> enableNetworkPreserve: Boolean! (scalar)
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
        //      C# -> System.String? PostScript
        // GraphQL -> postScript: String! (scalar)
        if (this.PostScript != null) {
            if (conf.Flat) {
                s += conf.Prefix + "postScript\n" ;
            } else {
                s += ind + "postScript\n" ;
            }
        }
        //      C# -> System.Int32? Vcpus
        // GraphQL -> vcpus: Int! (scalar)
        if (this.Vcpus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vcpus\n" ;
            } else {
                s += ind + "vcpus\n" ;
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
        //      C# -> List<VsphereVmNicSpec>? Nics
        // GraphQL -> nics: [VsphereVmNicSpec!]! (type)
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
        //      C# -> VsphereComputeTarget? Target
        // GraphQL -> target: VsphereComputeTarget! (type)
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
        //      C# -> List<VsphereVmVolumeSpec>? Volumes
        // GraphQL -> volumes: [VsphereVmVolumeSpec!]! (type)
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? EnableMacPreserveOnly
        // GraphQL -> enableMacPreserveOnly: Boolean! (scalar)
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
        // GraphQL -> enableNetworkPreserve: Boolean! (scalar)
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
        //      C# -> System.String? PostScript
        // GraphQL -> postScript: String! (scalar)
        if (ec.Includes("postScript",true))
        {
            if(this.PostScript == null) {

                this.PostScript = "FETCH";

            } else {


            }
        }
        else if (this.PostScript != null && ec.Excludes("postScript",true))
        {
            this.PostScript = null;
        }
        //      C# -> System.Int32? Vcpus
        // GraphQL -> vcpus: Int! (scalar)
        if (ec.Includes("vcpus",true))
        {
            if(this.Vcpus == null) {

                this.Vcpus = Int32.MinValue;

            } else {


            }
        }
        else if (this.Vcpus != null && ec.Excludes("vcpus",true))
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
        //      C# -> List<VsphereVmNicSpec>? Nics
        // GraphQL -> nics: [VsphereVmNicSpec!]! (type)
        if (ec.Includes("nics",false))
        {
            if(this.Nics == null) {

                this.Nics = new List<VsphereVmNicSpec>();
                this.Nics.ApplyExploratoryFieldSpec(ec.NewChild("nics"));

            } else {

                this.Nics.ApplyExploratoryFieldSpec(ec.NewChild("nics"));

            }
        }
        else if (this.Nics != null && ec.Excludes("nics",false))
        {
            this.Nics = null;
        }
        //      C# -> VsphereComputeTarget? Target
        // GraphQL -> target: VsphereComputeTarget! (type)
        if (ec.Includes("target",false))
        {
            if(this.Target == null) {

                this.Target = new VsphereComputeTarget();
                this.Target.ApplyExploratoryFieldSpec(ec.NewChild("target"));

            } else {

                this.Target.ApplyExploratoryFieldSpec(ec.NewChild("target"));

            }
        }
        else if (this.Target != null && ec.Excludes("target",false))
        {
            this.Target = null;
        }
        //      C# -> List<VsphereVmVolumeSpec>? Volumes
        // GraphQL -> volumes: [VsphereVmVolumeSpec!]! (type)
        if (ec.Includes("volumes",false))
        {
            if(this.Volumes == null) {

                this.Volumes = new List<VsphereVmVolumeSpec>();
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

    } // class VsphereVmRecoverySpec
    
    #endregion

    public static class ListVsphereVmRecoverySpecExtensions
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
            this List<VsphereVmRecoverySpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VsphereVmRecoverySpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VsphereVmRecoverySpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereVmRecoverySpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VsphereVmRecoverySpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types