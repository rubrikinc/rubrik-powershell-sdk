// MultiTenantHostSpec.cs
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
    #region MultiTenantHostSpec
    public class MultiTenantHostSpec: BaseType
    {
        #region members

        //      C# -> System.String? MultiTenantHostAzureAppId
        // GraphQL -> multiTenantHostAzureAppId: String! (scalar)
        [JsonProperty("multiTenantHostAzureAppId")]
        public System.String? MultiTenantHostAzureAppId { get; set; }

        //      C# -> System.Int64? MultiTenantHostId
        // GraphQL -> multiTenantHostId: Long! (scalar)
        [JsonProperty("multiTenantHostId")]
        public System.Int64? MultiTenantHostId { get; set; }

        //      C# -> System.String? Namespace
        // GraphQL -> namespace: String! (scalar)
        [JsonProperty("namespace")]
        public System.String? Namespace { get; set; }

        //      C# -> System.String? RegistryServer
        // GraphQL -> registryServer: String! (scalar)
        [JsonProperty("registryServer")]
        public System.String? RegistryServer { get; set; }

        //      C# -> System.String? TunnelMode
        // GraphQL -> tunnelMode: String! (scalar)
        [JsonProperty("tunnelMode")]
        public System.String? TunnelMode { get; set; }

        //      C# -> NetworkConfig? MultiTenantHostNetworkConfig
        // GraphQL -> multiTenantHostNetworkConfig: NetworkConfig (type)
        [JsonProperty("multiTenantHostNetworkConfig")]
        public NetworkConfig? MultiTenantHostNetworkConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MultiTenantHostSpec";
    }

    public MultiTenantHostSpec Set(
        System.String? MultiTenantHostAzureAppId = null,
        System.Int64? MultiTenantHostId = null,
        System.String? Namespace = null,
        System.String? RegistryServer = null,
        System.String? TunnelMode = null,
        NetworkConfig? MultiTenantHostNetworkConfig = null
    ) 
    {
        if ( MultiTenantHostAzureAppId != null ) {
            this.MultiTenantHostAzureAppId = MultiTenantHostAzureAppId;
        }
        if ( MultiTenantHostId != null ) {
            this.MultiTenantHostId = MultiTenantHostId;
        }
        if ( Namespace != null ) {
            this.Namespace = Namespace;
        }
        if ( RegistryServer != null ) {
            this.RegistryServer = RegistryServer;
        }
        if ( TunnelMode != null ) {
            this.TunnelMode = TunnelMode;
        }
        if ( MultiTenantHostNetworkConfig != null ) {
            this.MultiTenantHostNetworkConfig = MultiTenantHostNetworkConfig;
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
        //      C# -> System.String? MultiTenantHostAzureAppId
        // GraphQL -> multiTenantHostAzureAppId: String! (scalar)
        if (this.MultiTenantHostAzureAppId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "multiTenantHostAzureAppId\n" ;
            } else {
                s += ind + "multiTenantHostAzureAppId\n" ;
            }
        }
        //      C# -> System.Int64? MultiTenantHostId
        // GraphQL -> multiTenantHostId: Long! (scalar)
        if (this.MultiTenantHostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "multiTenantHostId\n" ;
            } else {
                s += ind + "multiTenantHostId\n" ;
            }
        }
        //      C# -> System.String? Namespace
        // GraphQL -> namespace: String! (scalar)
        if (this.Namespace != null) {
            if (conf.Flat) {
                s += conf.Prefix + "namespace\n" ;
            } else {
                s += ind + "namespace\n" ;
            }
        }
        //      C# -> System.String? RegistryServer
        // GraphQL -> registryServer: String! (scalar)
        if (this.RegistryServer != null) {
            if (conf.Flat) {
                s += conf.Prefix + "registryServer\n" ;
            } else {
                s += ind + "registryServer\n" ;
            }
        }
        //      C# -> System.String? TunnelMode
        // GraphQL -> tunnelMode: String! (scalar)
        if (this.TunnelMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tunnelMode\n" ;
            } else {
                s += ind + "tunnelMode\n" ;
            }
        }
        //      C# -> NetworkConfig? MultiTenantHostNetworkConfig
        // GraphQL -> multiTenantHostNetworkConfig: NetworkConfig (type)
        if (this.MultiTenantHostNetworkConfig != null) {
            var fspec = this.MultiTenantHostNetworkConfig.AsFieldSpec(conf.Child("multiTenantHostNetworkConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "multiTenantHostNetworkConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? MultiTenantHostAzureAppId
        // GraphQL -> multiTenantHostAzureAppId: String! (scalar)
        if (ec.Includes("multiTenantHostAzureAppId",true))
        {
            if(this.MultiTenantHostAzureAppId == null) {

                this.MultiTenantHostAzureAppId = "FETCH";

            } else {


            }
        }
        else if (this.MultiTenantHostAzureAppId != null && ec.Excludes("multiTenantHostAzureAppId",true))
        {
            this.MultiTenantHostAzureAppId = null;
        }
        //      C# -> System.Int64? MultiTenantHostId
        // GraphQL -> multiTenantHostId: Long! (scalar)
        if (ec.Includes("multiTenantHostId",true))
        {
            if(this.MultiTenantHostId == null) {

                this.MultiTenantHostId = new System.Int64();

            } else {


            }
        }
        else if (this.MultiTenantHostId != null && ec.Excludes("multiTenantHostId",true))
        {
            this.MultiTenantHostId = null;
        }
        //      C# -> System.String? Namespace
        // GraphQL -> namespace: String! (scalar)
        if (ec.Includes("namespace",true))
        {
            if(this.Namespace == null) {

                this.Namespace = "FETCH";

            } else {


            }
        }
        else if (this.Namespace != null && ec.Excludes("namespace",true))
        {
            this.Namespace = null;
        }
        //      C# -> System.String? RegistryServer
        // GraphQL -> registryServer: String! (scalar)
        if (ec.Includes("registryServer",true))
        {
            if(this.RegistryServer == null) {

                this.RegistryServer = "FETCH";

            } else {


            }
        }
        else if (this.RegistryServer != null && ec.Excludes("registryServer",true))
        {
            this.RegistryServer = null;
        }
        //      C# -> System.String? TunnelMode
        // GraphQL -> tunnelMode: String! (scalar)
        if (ec.Includes("tunnelMode",true))
        {
            if(this.TunnelMode == null) {

                this.TunnelMode = "FETCH";

            } else {


            }
        }
        else if (this.TunnelMode != null && ec.Excludes("tunnelMode",true))
        {
            this.TunnelMode = null;
        }
        //      C# -> NetworkConfig? MultiTenantHostNetworkConfig
        // GraphQL -> multiTenantHostNetworkConfig: NetworkConfig (type)
        if (ec.Includes("multiTenantHostNetworkConfig",false))
        {
            if(this.MultiTenantHostNetworkConfig == null) {

                this.MultiTenantHostNetworkConfig = new NetworkConfig();
                this.MultiTenantHostNetworkConfig.ApplyExploratoryFieldSpec(ec.NewChild("multiTenantHostNetworkConfig"));

            } else {

                this.MultiTenantHostNetworkConfig.ApplyExploratoryFieldSpec(ec.NewChild("multiTenantHostNetworkConfig"));

            }
        }
        else if (this.MultiTenantHostNetworkConfig != null && ec.Excludes("multiTenantHostNetworkConfig",false))
        {
            this.MultiTenantHostNetworkConfig = null;
        }
    }


    #endregion

    } // class MultiTenantHostSpec
    
    #endregion

    public static class ListMultiTenantHostSpecExtensions
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
            this List<MultiTenantHostSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MultiTenantHostSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MultiTenantHostSpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MultiTenantHostSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MultiTenantHostSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types