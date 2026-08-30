// HypervVmRecoverySpec.cs
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
    #region HypervVmRecoverySpec
    public class HypervVmRecoverySpec: BaseType
    {
        #region members

        //      C# -> NetworkPreservationMode? NetworkMode
        // GraphQL -> networkMode: NetworkPreservationMode! (enum)
        [JsonProperty("networkMode")]
        public NetworkPreservationMode? NetworkMode { get; set; }

        //      C# -> System.Int64? MemoryMbs
        // GraphQL -> memoryMbs: Long! (scalar)
        [JsonProperty("memoryMbs")]
        public System.Int64? MemoryMbs { get; set; }

        //      C# -> System.Boolean? ShouldDisconnectNetwork
        // GraphQL -> shouldDisconnectNetwork: Boolean! (scalar)
        [JsonProperty("shouldDisconnectNetwork")]
        public System.Boolean? ShouldDisconnectNetwork { get; set; }

        //      C# -> System.Int32? Vcpus
        // GraphQL -> vCpus: Int! (scalar)
        [JsonProperty("vCpus")]
        public System.Int32? Vcpus { get; set; }

        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        [JsonProperty("version")]
        public System.Int64? Version { get; set; }

        //      C# -> HypervTargetConfig? TargetConfig
        // GraphQL -> targetConfig: HypervTargetConfig (type)
        [JsonProperty("targetConfig")]
        public HypervTargetConfig? TargetConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HypervVmRecoverySpec";
    }

    public HypervVmRecoverySpec Set(
        NetworkPreservationMode? NetworkMode = null,
        System.Int64? MemoryMbs = null,
        System.Boolean? ShouldDisconnectNetwork = null,
        System.Int32? Vcpus = null,
        System.Int64? Version = null,
        HypervTargetConfig? TargetConfig = null
    ) 
    {
        if ( NetworkMode != null ) {
            this.NetworkMode = NetworkMode;
        }
        if ( MemoryMbs != null ) {
            this.MemoryMbs = MemoryMbs;
        }
        if ( ShouldDisconnectNetwork != null ) {
            this.ShouldDisconnectNetwork = ShouldDisconnectNetwork;
        }
        if ( Vcpus != null ) {
            this.Vcpus = Vcpus;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( TargetConfig != null ) {
            this.TargetConfig = TargetConfig;
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
        //      C# -> NetworkPreservationMode? NetworkMode
        // GraphQL -> networkMode: NetworkPreservationMode! (enum)
        if (this.NetworkMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkMode\n" ;
            } else {
                s += ind + "networkMode\n" ;
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
        //      C# -> System.Boolean? ShouldDisconnectNetwork
        // GraphQL -> shouldDisconnectNetwork: Boolean! (scalar)
        if (this.ShouldDisconnectNetwork != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldDisconnectNetwork\n" ;
            } else {
                s += ind + "shouldDisconnectNetwork\n" ;
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
        //      C# -> HypervTargetConfig? TargetConfig
        // GraphQL -> targetConfig: HypervTargetConfig (type)
        if (this.TargetConfig != null) {
            var fspec = this.TargetConfig.AsFieldSpec(conf.Child("targetConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> NetworkPreservationMode? NetworkMode
        // GraphQL -> networkMode: NetworkPreservationMode! (enum)
        if (ec.Includes("networkMode",true))
        {
            if(this.NetworkMode == null) {

                this.NetworkMode = new NetworkPreservationMode();

            } else {


            }
        }
        else if (this.NetworkMode != null && ec.Excludes("networkMode",true))
        {
            this.NetworkMode = null;
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
        //      C# -> System.Boolean? ShouldDisconnectNetwork
        // GraphQL -> shouldDisconnectNetwork: Boolean! (scalar)
        if (ec.Includes("shouldDisconnectNetwork",true))
        {
            if(this.ShouldDisconnectNetwork == null) {

                this.ShouldDisconnectNetwork = true;

            } else {


            }
        }
        else if (this.ShouldDisconnectNetwork != null && ec.Excludes("shouldDisconnectNetwork",true))
        {
            this.ShouldDisconnectNetwork = null;
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
        //      C# -> HypervTargetConfig? TargetConfig
        // GraphQL -> targetConfig: HypervTargetConfig (type)
        if (ec.Includes("targetConfig",false))
        {
            if(this.TargetConfig == null) {

                this.TargetConfig = new HypervTargetConfig();
                this.TargetConfig.ApplyExploratoryFieldSpec(ec.NewChild("targetConfig"));

            } else {

                this.TargetConfig.ApplyExploratoryFieldSpec(ec.NewChild("targetConfig"));

            }
        }
        else if (this.TargetConfig != null && ec.Excludes("targetConfig",false))
        {
            this.TargetConfig = null;
        }
    }


    #endregion

    } // class HypervVmRecoverySpec
    
    #endregion

    public static class ListHypervVmRecoverySpecExtensions
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
            this List<HypervVmRecoverySpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HypervVmRecoverySpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HypervVmRecoverySpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervVmRecoverySpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HypervVmRecoverySpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types