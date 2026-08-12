// PingFederateObjectsCount.cs
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
    #region PingFederateObjectsCount
    public class PingFederateObjectsCount: BaseType
    {
        #region members

        //      C# -> System.Int64? AuthenticationPolicyContracts
        // GraphQL -> authenticationPolicyContracts: Long (scalar)
        [JsonProperty("authenticationPolicyContracts")]
        public System.Int64? AuthenticationPolicyContracts { get; set; }

        //      C# -> System.Int64? AuthenticationPolicySettings
        // GraphQL -> authenticationPolicySettings: Long (scalar)
        [JsonProperty("authenticationPolicySettings")]
        public System.Int64? AuthenticationPolicySettings { get; set; }

        //      C# -> System.Int64? CaCertificates
        // GraphQL -> caCertificates: Long (scalar)
        [JsonProperty("caCertificates")]
        public System.Int64? CaCertificates { get; set; }

        //      C# -> System.Int64? DataStores
        // GraphQL -> dataStores: Long (scalar)
        [JsonProperty("dataStores")]
        public System.Int64? DataStores { get; set; }

        //      C# -> System.Int64? DefaultAuthenticationPolicy
        // GraphQL -> defaultAuthenticationPolicy: Long (scalar)
        [JsonProperty("defaultAuthenticationPolicy")]
        public System.Int64? DefaultAuthenticationPolicy { get; set; }

        //      C# -> System.Int64? GeneralSettings
        // GraphQL -> generalSettings: Long (scalar)
        [JsonProperty("generalSettings")]
        public System.Int64? GeneralSettings { get; set; }

        //      C# -> System.Int64? IdpAdapters
        // GraphQL -> idpAdapters: Long (scalar)
        [JsonProperty("idpAdapters")]
        public System.Int64? IdpAdapters { get; set; }

        //      C# -> System.Int64? IdpConnections
        // GraphQL -> idpConnections: Long (scalar)
        [JsonProperty("idpConnections")]
        public System.Int64? IdpConnections { get; set; }

        //      C# -> System.Int64? OauthAccessTokenManagers
        // GraphQL -> oauthAccessTokenManagers: Long (scalar)
        [JsonProperty("oauthAccessTokenManagers")]
        public System.Int64? OauthAccessTokenManagers { get; set; }

        //      C# -> System.Int64? OauthAccessTokenManagersSettings
        // GraphQL -> oauthAccessTokenManagersSettings: Long (scalar)
        [JsonProperty("oauthAccessTokenManagersSettings")]
        public System.Int64? OauthAccessTokenManagersSettings { get; set; }

        //      C# -> System.Int64? OauthAccessTokenMappings
        // GraphQL -> oauthAccessTokenMappings: Long (scalar)
        [JsonProperty("oauthAccessTokenMappings")]
        public System.Int64? OauthAccessTokenMappings { get; set; }

        //      C# -> System.Int64? OauthAuthServerSettings
        // GraphQL -> oauthAuthServerSettings: Long (scalar)
        [JsonProperty("oauthAuthServerSettings")]
        public System.Int64? OauthAuthServerSettings { get; set; }

        //      C# -> System.Int64? OauthClients
        // GraphQL -> oauthClients: Long (scalar)
        [JsonProperty("oauthClients")]
        public System.Int64? OauthClients { get; set; }

        //      C# -> System.Int64? OauthIdpAdapterMappings
        // GraphQL -> oauthIdpAdapterMappings: Long (scalar)
        [JsonProperty("oauthIdpAdapterMappings")]
        public System.Int64? OauthIdpAdapterMappings { get; set; }

        //      C# -> System.Int64? OauthOidcKeysSettings
        // GraphQL -> oauthOidcKeysSettings: Long (scalar)
        [JsonProperty("oauthOidcKeysSettings")]
        public System.Int64? OauthOidcKeysSettings { get; set; }

        //      C# -> System.Int64? OauthOidcPolicies
        // GraphQL -> oauthOidcPolicies: Long (scalar)
        [JsonProperty("oauthOidcPolicies")]
        public System.Int64? OauthOidcPolicies { get; set; }

        //      C# -> System.Int64? OauthOidcSettings
        // GraphQL -> oauthOidcSettings: Long (scalar)
        [JsonProperty("oauthOidcSettings")]
        public System.Int64? OauthOidcSettings { get; set; }

        //      C# -> System.Int64? OauthTokenExchangeProcessorSettings
        // GraphQL -> oauthTokenExchangeProcessorSettings: Long (scalar)
        [JsonProperty("oauthTokenExchangeProcessorSettings")]
        public System.Int64? OauthTokenExchangeProcessorSettings { get; set; }

        //      C# -> System.Int64? OutboundProvisioningSettings
        // GraphQL -> outboundProvisioningSettings: Long (scalar)
        [JsonProperty("outboundProvisioningSettings")]
        public System.Int64? OutboundProvisioningSettings { get; set; }

        //      C# -> System.Int64? PasswordCredentialValidators
        // GraphQL -> passwordCredentialValidators: Long (scalar)
        [JsonProperty("passwordCredentialValidators")]
        public System.Int64? PasswordCredentialValidators { get; set; }

        //      C# -> System.Int64? ServerSettings
        // GraphQL -> serverSettings: Long (scalar)
        [JsonProperty("serverSettings")]
        public System.Int64? ServerSettings { get; set; }

        //      C# -> System.Int64? SigningKeyPairs
        // GraphQL -> signingKeyPairs: Long (scalar)
        [JsonProperty("signingKeyPairs")]
        public System.Int64? SigningKeyPairs { get; set; }

        //      C# -> System.Int64? SpConnections
        // GraphQL -> spConnections: Long (scalar)
        [JsonProperty("spConnections")]
        public System.Int64? SpConnections { get; set; }

        //      C# -> System.Int64? SslClientKeyPairs
        // GraphQL -> sslClientKeyPairs: Long (scalar)
        [JsonProperty("sslClientKeyPairs")]
        public System.Int64? SslClientKeyPairs { get; set; }

        //      C# -> System.Int64? SslServerKeyPairs
        // GraphQL -> sslServerKeyPairs: Long (scalar)
        [JsonProperty("sslServerKeyPairs")]
        public System.Int64? SslServerKeyPairs { get; set; }

        //      C# -> System.Int64? VirtualHostNames
        // GraphQL -> virtualHostNames: Long (scalar)
        [JsonProperty("virtualHostNames")]
        public System.Int64? VirtualHostNames { get; set; }

        //      C# -> System.Int64? WsTrustStsSettings
        // GraphQL -> wsTrustStsSettings: Long (scalar)
        [JsonProperty("wsTrustStsSettings")]
        public System.Int64? WsTrustStsSettings { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PingFederateObjectsCount";
    }

    public PingFederateObjectsCount Set(
        System.Int64? AuthenticationPolicyContracts = null,
        System.Int64? AuthenticationPolicySettings = null,
        System.Int64? CaCertificates = null,
        System.Int64? DataStores = null,
        System.Int64? DefaultAuthenticationPolicy = null,
        System.Int64? GeneralSettings = null,
        System.Int64? IdpAdapters = null,
        System.Int64? IdpConnections = null,
        System.Int64? OauthAccessTokenManagers = null,
        System.Int64? OauthAccessTokenManagersSettings = null,
        System.Int64? OauthAccessTokenMappings = null,
        System.Int64? OauthAuthServerSettings = null,
        System.Int64? OauthClients = null,
        System.Int64? OauthIdpAdapterMappings = null,
        System.Int64? OauthOidcKeysSettings = null,
        System.Int64? OauthOidcPolicies = null,
        System.Int64? OauthOidcSettings = null,
        System.Int64? OauthTokenExchangeProcessorSettings = null,
        System.Int64? OutboundProvisioningSettings = null,
        System.Int64? PasswordCredentialValidators = null,
        System.Int64? ServerSettings = null,
        System.Int64? SigningKeyPairs = null,
        System.Int64? SpConnections = null,
        System.Int64? SslClientKeyPairs = null,
        System.Int64? SslServerKeyPairs = null,
        System.Int64? VirtualHostNames = null,
        System.Int64? WsTrustStsSettings = null
    ) 
    {
        if ( AuthenticationPolicyContracts != null ) {
            this.AuthenticationPolicyContracts = AuthenticationPolicyContracts;
        }
        if ( AuthenticationPolicySettings != null ) {
            this.AuthenticationPolicySettings = AuthenticationPolicySettings;
        }
        if ( CaCertificates != null ) {
            this.CaCertificates = CaCertificates;
        }
        if ( DataStores != null ) {
            this.DataStores = DataStores;
        }
        if ( DefaultAuthenticationPolicy != null ) {
            this.DefaultAuthenticationPolicy = DefaultAuthenticationPolicy;
        }
        if ( GeneralSettings != null ) {
            this.GeneralSettings = GeneralSettings;
        }
        if ( IdpAdapters != null ) {
            this.IdpAdapters = IdpAdapters;
        }
        if ( IdpConnections != null ) {
            this.IdpConnections = IdpConnections;
        }
        if ( OauthAccessTokenManagers != null ) {
            this.OauthAccessTokenManagers = OauthAccessTokenManagers;
        }
        if ( OauthAccessTokenManagersSettings != null ) {
            this.OauthAccessTokenManagersSettings = OauthAccessTokenManagersSettings;
        }
        if ( OauthAccessTokenMappings != null ) {
            this.OauthAccessTokenMappings = OauthAccessTokenMappings;
        }
        if ( OauthAuthServerSettings != null ) {
            this.OauthAuthServerSettings = OauthAuthServerSettings;
        }
        if ( OauthClients != null ) {
            this.OauthClients = OauthClients;
        }
        if ( OauthIdpAdapterMappings != null ) {
            this.OauthIdpAdapterMappings = OauthIdpAdapterMappings;
        }
        if ( OauthOidcKeysSettings != null ) {
            this.OauthOidcKeysSettings = OauthOidcKeysSettings;
        }
        if ( OauthOidcPolicies != null ) {
            this.OauthOidcPolicies = OauthOidcPolicies;
        }
        if ( OauthOidcSettings != null ) {
            this.OauthOidcSettings = OauthOidcSettings;
        }
        if ( OauthTokenExchangeProcessorSettings != null ) {
            this.OauthTokenExchangeProcessorSettings = OauthTokenExchangeProcessorSettings;
        }
        if ( OutboundProvisioningSettings != null ) {
            this.OutboundProvisioningSettings = OutboundProvisioningSettings;
        }
        if ( PasswordCredentialValidators != null ) {
            this.PasswordCredentialValidators = PasswordCredentialValidators;
        }
        if ( ServerSettings != null ) {
            this.ServerSettings = ServerSettings;
        }
        if ( SigningKeyPairs != null ) {
            this.SigningKeyPairs = SigningKeyPairs;
        }
        if ( SpConnections != null ) {
            this.SpConnections = SpConnections;
        }
        if ( SslClientKeyPairs != null ) {
            this.SslClientKeyPairs = SslClientKeyPairs;
        }
        if ( SslServerKeyPairs != null ) {
            this.SslServerKeyPairs = SslServerKeyPairs;
        }
        if ( VirtualHostNames != null ) {
            this.VirtualHostNames = VirtualHostNames;
        }
        if ( WsTrustStsSettings != null ) {
            this.WsTrustStsSettings = WsTrustStsSettings;
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
        //      C# -> System.Int64? AuthenticationPolicyContracts
        // GraphQL -> authenticationPolicyContracts: Long (scalar)
        if (this.AuthenticationPolicyContracts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authenticationPolicyContracts\n" ;
            } else {
                s += ind + "authenticationPolicyContracts\n" ;
            }
        }
        //      C# -> System.Int64? AuthenticationPolicySettings
        // GraphQL -> authenticationPolicySettings: Long (scalar)
        if (this.AuthenticationPolicySettings != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authenticationPolicySettings\n" ;
            } else {
                s += ind + "authenticationPolicySettings\n" ;
            }
        }
        //      C# -> System.Int64? CaCertificates
        // GraphQL -> caCertificates: Long (scalar)
        if (this.CaCertificates != null) {
            if (conf.Flat) {
                s += conf.Prefix + "caCertificates\n" ;
            } else {
                s += ind + "caCertificates\n" ;
            }
        }
        //      C# -> System.Int64? DataStores
        // GraphQL -> dataStores: Long (scalar)
        if (this.DataStores != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataStores\n" ;
            } else {
                s += ind + "dataStores\n" ;
            }
        }
        //      C# -> System.Int64? DefaultAuthenticationPolicy
        // GraphQL -> defaultAuthenticationPolicy: Long (scalar)
        if (this.DefaultAuthenticationPolicy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "defaultAuthenticationPolicy\n" ;
            } else {
                s += ind + "defaultAuthenticationPolicy\n" ;
            }
        }
        //      C# -> System.Int64? GeneralSettings
        // GraphQL -> generalSettings: Long (scalar)
        if (this.GeneralSettings != null) {
            if (conf.Flat) {
                s += conf.Prefix + "generalSettings\n" ;
            } else {
                s += ind + "generalSettings\n" ;
            }
        }
        //      C# -> System.Int64? IdpAdapters
        // GraphQL -> idpAdapters: Long (scalar)
        if (this.IdpAdapters != null) {
            if (conf.Flat) {
                s += conf.Prefix + "idpAdapters\n" ;
            } else {
                s += ind + "idpAdapters\n" ;
            }
        }
        //      C# -> System.Int64? IdpConnections
        // GraphQL -> idpConnections: Long (scalar)
        if (this.IdpConnections != null) {
            if (conf.Flat) {
                s += conf.Prefix + "idpConnections\n" ;
            } else {
                s += ind + "idpConnections\n" ;
            }
        }
        //      C# -> System.Int64? OauthAccessTokenManagers
        // GraphQL -> oauthAccessTokenManagers: Long (scalar)
        if (this.OauthAccessTokenManagers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oauthAccessTokenManagers\n" ;
            } else {
                s += ind + "oauthAccessTokenManagers\n" ;
            }
        }
        //      C# -> System.Int64? OauthAccessTokenManagersSettings
        // GraphQL -> oauthAccessTokenManagersSettings: Long (scalar)
        if (this.OauthAccessTokenManagersSettings != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oauthAccessTokenManagersSettings\n" ;
            } else {
                s += ind + "oauthAccessTokenManagersSettings\n" ;
            }
        }
        //      C# -> System.Int64? OauthAccessTokenMappings
        // GraphQL -> oauthAccessTokenMappings: Long (scalar)
        if (this.OauthAccessTokenMappings != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oauthAccessTokenMappings\n" ;
            } else {
                s += ind + "oauthAccessTokenMappings\n" ;
            }
        }
        //      C# -> System.Int64? OauthAuthServerSettings
        // GraphQL -> oauthAuthServerSettings: Long (scalar)
        if (this.OauthAuthServerSettings != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oauthAuthServerSettings\n" ;
            } else {
                s += ind + "oauthAuthServerSettings\n" ;
            }
        }
        //      C# -> System.Int64? OauthClients
        // GraphQL -> oauthClients: Long (scalar)
        if (this.OauthClients != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oauthClients\n" ;
            } else {
                s += ind + "oauthClients\n" ;
            }
        }
        //      C# -> System.Int64? OauthIdpAdapterMappings
        // GraphQL -> oauthIdpAdapterMappings: Long (scalar)
        if (this.OauthIdpAdapterMappings != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oauthIdpAdapterMappings\n" ;
            } else {
                s += ind + "oauthIdpAdapterMappings\n" ;
            }
        }
        //      C# -> System.Int64? OauthOidcKeysSettings
        // GraphQL -> oauthOidcKeysSettings: Long (scalar)
        if (this.OauthOidcKeysSettings != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oauthOidcKeysSettings\n" ;
            } else {
                s += ind + "oauthOidcKeysSettings\n" ;
            }
        }
        //      C# -> System.Int64? OauthOidcPolicies
        // GraphQL -> oauthOidcPolicies: Long (scalar)
        if (this.OauthOidcPolicies != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oauthOidcPolicies\n" ;
            } else {
                s += ind + "oauthOidcPolicies\n" ;
            }
        }
        //      C# -> System.Int64? OauthOidcSettings
        // GraphQL -> oauthOidcSettings: Long (scalar)
        if (this.OauthOidcSettings != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oauthOidcSettings\n" ;
            } else {
                s += ind + "oauthOidcSettings\n" ;
            }
        }
        //      C# -> System.Int64? OauthTokenExchangeProcessorSettings
        // GraphQL -> oauthTokenExchangeProcessorSettings: Long (scalar)
        if (this.OauthTokenExchangeProcessorSettings != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oauthTokenExchangeProcessorSettings\n" ;
            } else {
                s += ind + "oauthTokenExchangeProcessorSettings\n" ;
            }
        }
        //      C# -> System.Int64? OutboundProvisioningSettings
        // GraphQL -> outboundProvisioningSettings: Long (scalar)
        if (this.OutboundProvisioningSettings != null) {
            if (conf.Flat) {
                s += conf.Prefix + "outboundProvisioningSettings\n" ;
            } else {
                s += ind + "outboundProvisioningSettings\n" ;
            }
        }
        //      C# -> System.Int64? PasswordCredentialValidators
        // GraphQL -> passwordCredentialValidators: Long (scalar)
        if (this.PasswordCredentialValidators != null) {
            if (conf.Flat) {
                s += conf.Prefix + "passwordCredentialValidators\n" ;
            } else {
                s += ind + "passwordCredentialValidators\n" ;
            }
        }
        //      C# -> System.Int64? ServerSettings
        // GraphQL -> serverSettings: Long (scalar)
        if (this.ServerSettings != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serverSettings\n" ;
            } else {
                s += ind + "serverSettings\n" ;
            }
        }
        //      C# -> System.Int64? SigningKeyPairs
        // GraphQL -> signingKeyPairs: Long (scalar)
        if (this.SigningKeyPairs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "signingKeyPairs\n" ;
            } else {
                s += ind + "signingKeyPairs\n" ;
            }
        }
        //      C# -> System.Int64? SpConnections
        // GraphQL -> spConnections: Long (scalar)
        if (this.SpConnections != null) {
            if (conf.Flat) {
                s += conf.Prefix + "spConnections\n" ;
            } else {
                s += ind + "spConnections\n" ;
            }
        }
        //      C# -> System.Int64? SslClientKeyPairs
        // GraphQL -> sslClientKeyPairs: Long (scalar)
        if (this.SslClientKeyPairs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sslClientKeyPairs\n" ;
            } else {
                s += ind + "sslClientKeyPairs\n" ;
            }
        }
        //      C# -> System.Int64? SslServerKeyPairs
        // GraphQL -> sslServerKeyPairs: Long (scalar)
        if (this.SslServerKeyPairs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sslServerKeyPairs\n" ;
            } else {
                s += ind + "sslServerKeyPairs\n" ;
            }
        }
        //      C# -> System.Int64? VirtualHostNames
        // GraphQL -> virtualHostNames: Long (scalar)
        if (this.VirtualHostNames != null) {
            if (conf.Flat) {
                s += conf.Prefix + "virtualHostNames\n" ;
            } else {
                s += ind + "virtualHostNames\n" ;
            }
        }
        //      C# -> System.Int64? WsTrustStsSettings
        // GraphQL -> wsTrustStsSettings: Long (scalar)
        if (this.WsTrustStsSettings != null) {
            if (conf.Flat) {
                s += conf.Prefix + "wsTrustStsSettings\n" ;
            } else {
                s += ind + "wsTrustStsSettings\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? AuthenticationPolicyContracts
        // GraphQL -> authenticationPolicyContracts: Long (scalar)
        if (ec.Includes("authenticationPolicyContracts",true))
        {
            if(this.AuthenticationPolicyContracts == null) {

                this.AuthenticationPolicyContracts = new System.Int64();

            } else {


            }
        }
        else if (this.AuthenticationPolicyContracts != null && ec.Excludes("authenticationPolicyContracts",true))
        {
            this.AuthenticationPolicyContracts = null;
        }
        //      C# -> System.Int64? AuthenticationPolicySettings
        // GraphQL -> authenticationPolicySettings: Long (scalar)
        if (ec.Includes("authenticationPolicySettings",true))
        {
            if(this.AuthenticationPolicySettings == null) {

                this.AuthenticationPolicySettings = new System.Int64();

            } else {


            }
        }
        else if (this.AuthenticationPolicySettings != null && ec.Excludes("authenticationPolicySettings",true))
        {
            this.AuthenticationPolicySettings = null;
        }
        //      C# -> System.Int64? CaCertificates
        // GraphQL -> caCertificates: Long (scalar)
        if (ec.Includes("caCertificates",true))
        {
            if(this.CaCertificates == null) {

                this.CaCertificates = new System.Int64();

            } else {


            }
        }
        else if (this.CaCertificates != null && ec.Excludes("caCertificates",true))
        {
            this.CaCertificates = null;
        }
        //      C# -> System.Int64? DataStores
        // GraphQL -> dataStores: Long (scalar)
        if (ec.Includes("dataStores",true))
        {
            if(this.DataStores == null) {

                this.DataStores = new System.Int64();

            } else {


            }
        }
        else if (this.DataStores != null && ec.Excludes("dataStores",true))
        {
            this.DataStores = null;
        }
        //      C# -> System.Int64? DefaultAuthenticationPolicy
        // GraphQL -> defaultAuthenticationPolicy: Long (scalar)
        if (ec.Includes("defaultAuthenticationPolicy",true))
        {
            if(this.DefaultAuthenticationPolicy == null) {

                this.DefaultAuthenticationPolicy = new System.Int64();

            } else {


            }
        }
        else if (this.DefaultAuthenticationPolicy != null && ec.Excludes("defaultAuthenticationPolicy",true))
        {
            this.DefaultAuthenticationPolicy = null;
        }
        //      C# -> System.Int64? GeneralSettings
        // GraphQL -> generalSettings: Long (scalar)
        if (ec.Includes("generalSettings",true))
        {
            if(this.GeneralSettings == null) {

                this.GeneralSettings = new System.Int64();

            } else {


            }
        }
        else if (this.GeneralSettings != null && ec.Excludes("generalSettings",true))
        {
            this.GeneralSettings = null;
        }
        //      C# -> System.Int64? IdpAdapters
        // GraphQL -> idpAdapters: Long (scalar)
        if (ec.Includes("idpAdapters",true))
        {
            if(this.IdpAdapters == null) {

                this.IdpAdapters = new System.Int64();

            } else {


            }
        }
        else if (this.IdpAdapters != null && ec.Excludes("idpAdapters",true))
        {
            this.IdpAdapters = null;
        }
        //      C# -> System.Int64? IdpConnections
        // GraphQL -> idpConnections: Long (scalar)
        if (ec.Includes("idpConnections",true))
        {
            if(this.IdpConnections == null) {

                this.IdpConnections = new System.Int64();

            } else {


            }
        }
        else if (this.IdpConnections != null && ec.Excludes("idpConnections",true))
        {
            this.IdpConnections = null;
        }
        //      C# -> System.Int64? OauthAccessTokenManagers
        // GraphQL -> oauthAccessTokenManagers: Long (scalar)
        if (ec.Includes("oauthAccessTokenManagers",true))
        {
            if(this.OauthAccessTokenManagers == null) {

                this.OauthAccessTokenManagers = new System.Int64();

            } else {


            }
        }
        else if (this.OauthAccessTokenManagers != null && ec.Excludes("oauthAccessTokenManagers",true))
        {
            this.OauthAccessTokenManagers = null;
        }
        //      C# -> System.Int64? OauthAccessTokenManagersSettings
        // GraphQL -> oauthAccessTokenManagersSettings: Long (scalar)
        if (ec.Includes("oauthAccessTokenManagersSettings",true))
        {
            if(this.OauthAccessTokenManagersSettings == null) {

                this.OauthAccessTokenManagersSettings = new System.Int64();

            } else {


            }
        }
        else if (this.OauthAccessTokenManagersSettings != null && ec.Excludes("oauthAccessTokenManagersSettings",true))
        {
            this.OauthAccessTokenManagersSettings = null;
        }
        //      C# -> System.Int64? OauthAccessTokenMappings
        // GraphQL -> oauthAccessTokenMappings: Long (scalar)
        if (ec.Includes("oauthAccessTokenMappings",true))
        {
            if(this.OauthAccessTokenMappings == null) {

                this.OauthAccessTokenMappings = new System.Int64();

            } else {


            }
        }
        else if (this.OauthAccessTokenMappings != null && ec.Excludes("oauthAccessTokenMappings",true))
        {
            this.OauthAccessTokenMappings = null;
        }
        //      C# -> System.Int64? OauthAuthServerSettings
        // GraphQL -> oauthAuthServerSettings: Long (scalar)
        if (ec.Includes("oauthAuthServerSettings",true))
        {
            if(this.OauthAuthServerSettings == null) {

                this.OauthAuthServerSettings = new System.Int64();

            } else {


            }
        }
        else if (this.OauthAuthServerSettings != null && ec.Excludes("oauthAuthServerSettings",true))
        {
            this.OauthAuthServerSettings = null;
        }
        //      C# -> System.Int64? OauthClients
        // GraphQL -> oauthClients: Long (scalar)
        if (ec.Includes("oauthClients",true))
        {
            if(this.OauthClients == null) {

                this.OauthClients = new System.Int64();

            } else {


            }
        }
        else if (this.OauthClients != null && ec.Excludes("oauthClients",true))
        {
            this.OauthClients = null;
        }
        //      C# -> System.Int64? OauthIdpAdapterMappings
        // GraphQL -> oauthIdpAdapterMappings: Long (scalar)
        if (ec.Includes("oauthIdpAdapterMappings",true))
        {
            if(this.OauthIdpAdapterMappings == null) {

                this.OauthIdpAdapterMappings = new System.Int64();

            } else {


            }
        }
        else if (this.OauthIdpAdapterMappings != null && ec.Excludes("oauthIdpAdapterMappings",true))
        {
            this.OauthIdpAdapterMappings = null;
        }
        //      C# -> System.Int64? OauthOidcKeysSettings
        // GraphQL -> oauthOidcKeysSettings: Long (scalar)
        if (ec.Includes("oauthOidcKeysSettings",true))
        {
            if(this.OauthOidcKeysSettings == null) {

                this.OauthOidcKeysSettings = new System.Int64();

            } else {


            }
        }
        else if (this.OauthOidcKeysSettings != null && ec.Excludes("oauthOidcKeysSettings",true))
        {
            this.OauthOidcKeysSettings = null;
        }
        //      C# -> System.Int64? OauthOidcPolicies
        // GraphQL -> oauthOidcPolicies: Long (scalar)
        if (ec.Includes("oauthOidcPolicies",true))
        {
            if(this.OauthOidcPolicies == null) {

                this.OauthOidcPolicies = new System.Int64();

            } else {


            }
        }
        else if (this.OauthOidcPolicies != null && ec.Excludes("oauthOidcPolicies",true))
        {
            this.OauthOidcPolicies = null;
        }
        //      C# -> System.Int64? OauthOidcSettings
        // GraphQL -> oauthOidcSettings: Long (scalar)
        if (ec.Includes("oauthOidcSettings",true))
        {
            if(this.OauthOidcSettings == null) {

                this.OauthOidcSettings = new System.Int64();

            } else {


            }
        }
        else if (this.OauthOidcSettings != null && ec.Excludes("oauthOidcSettings",true))
        {
            this.OauthOidcSettings = null;
        }
        //      C# -> System.Int64? OauthTokenExchangeProcessorSettings
        // GraphQL -> oauthTokenExchangeProcessorSettings: Long (scalar)
        if (ec.Includes("oauthTokenExchangeProcessorSettings",true))
        {
            if(this.OauthTokenExchangeProcessorSettings == null) {

                this.OauthTokenExchangeProcessorSettings = new System.Int64();

            } else {


            }
        }
        else if (this.OauthTokenExchangeProcessorSettings != null && ec.Excludes("oauthTokenExchangeProcessorSettings",true))
        {
            this.OauthTokenExchangeProcessorSettings = null;
        }
        //      C# -> System.Int64? OutboundProvisioningSettings
        // GraphQL -> outboundProvisioningSettings: Long (scalar)
        if (ec.Includes("outboundProvisioningSettings",true))
        {
            if(this.OutboundProvisioningSettings == null) {

                this.OutboundProvisioningSettings = new System.Int64();

            } else {


            }
        }
        else if (this.OutboundProvisioningSettings != null && ec.Excludes("outboundProvisioningSettings",true))
        {
            this.OutboundProvisioningSettings = null;
        }
        //      C# -> System.Int64? PasswordCredentialValidators
        // GraphQL -> passwordCredentialValidators: Long (scalar)
        if (ec.Includes("passwordCredentialValidators",true))
        {
            if(this.PasswordCredentialValidators == null) {

                this.PasswordCredentialValidators = new System.Int64();

            } else {


            }
        }
        else if (this.PasswordCredentialValidators != null && ec.Excludes("passwordCredentialValidators",true))
        {
            this.PasswordCredentialValidators = null;
        }
        //      C# -> System.Int64? ServerSettings
        // GraphQL -> serverSettings: Long (scalar)
        if (ec.Includes("serverSettings",true))
        {
            if(this.ServerSettings == null) {

                this.ServerSettings = new System.Int64();

            } else {


            }
        }
        else if (this.ServerSettings != null && ec.Excludes("serverSettings",true))
        {
            this.ServerSettings = null;
        }
        //      C# -> System.Int64? SigningKeyPairs
        // GraphQL -> signingKeyPairs: Long (scalar)
        if (ec.Includes("signingKeyPairs",true))
        {
            if(this.SigningKeyPairs == null) {

                this.SigningKeyPairs = new System.Int64();

            } else {


            }
        }
        else if (this.SigningKeyPairs != null && ec.Excludes("signingKeyPairs",true))
        {
            this.SigningKeyPairs = null;
        }
        //      C# -> System.Int64? SpConnections
        // GraphQL -> spConnections: Long (scalar)
        if (ec.Includes("spConnections",true))
        {
            if(this.SpConnections == null) {

                this.SpConnections = new System.Int64();

            } else {


            }
        }
        else if (this.SpConnections != null && ec.Excludes("spConnections",true))
        {
            this.SpConnections = null;
        }
        //      C# -> System.Int64? SslClientKeyPairs
        // GraphQL -> sslClientKeyPairs: Long (scalar)
        if (ec.Includes("sslClientKeyPairs",true))
        {
            if(this.SslClientKeyPairs == null) {

                this.SslClientKeyPairs = new System.Int64();

            } else {


            }
        }
        else if (this.SslClientKeyPairs != null && ec.Excludes("sslClientKeyPairs",true))
        {
            this.SslClientKeyPairs = null;
        }
        //      C# -> System.Int64? SslServerKeyPairs
        // GraphQL -> sslServerKeyPairs: Long (scalar)
        if (ec.Includes("sslServerKeyPairs",true))
        {
            if(this.SslServerKeyPairs == null) {

                this.SslServerKeyPairs = new System.Int64();

            } else {


            }
        }
        else if (this.SslServerKeyPairs != null && ec.Excludes("sslServerKeyPairs",true))
        {
            this.SslServerKeyPairs = null;
        }
        //      C# -> System.Int64? VirtualHostNames
        // GraphQL -> virtualHostNames: Long (scalar)
        if (ec.Includes("virtualHostNames",true))
        {
            if(this.VirtualHostNames == null) {

                this.VirtualHostNames = new System.Int64();

            } else {


            }
        }
        else if (this.VirtualHostNames != null && ec.Excludes("virtualHostNames",true))
        {
            this.VirtualHostNames = null;
        }
        //      C# -> System.Int64? WsTrustStsSettings
        // GraphQL -> wsTrustStsSettings: Long (scalar)
        if (ec.Includes("wsTrustStsSettings",true))
        {
            if(this.WsTrustStsSettings == null) {

                this.WsTrustStsSettings = new System.Int64();

            } else {


            }
        }
        else if (this.WsTrustStsSettings != null && ec.Excludes("wsTrustStsSettings",true))
        {
            this.WsTrustStsSettings = null;
        }
    }


    #endregion

    } // class PingFederateObjectsCount
    
    #endregion

    public static class ListPingFederateObjectsCountExtensions
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
            this List<PingFederateObjectsCount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PingFederateObjectsCount> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PingFederateObjectsCount> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PingFederateObjectsCount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PingFederateObjectsCount> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types