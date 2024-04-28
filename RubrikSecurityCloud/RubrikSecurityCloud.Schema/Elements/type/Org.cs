// Org.cs
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
    #region Org
    public class Org: BaseType
    {
        #region members

        //      C# -> TenantAuthDomainConfig? AuthDomainConfig
        // GraphQL -> authDomainConfig: TenantAuthDomainConfig! (enum)
        [JsonProperty("authDomainConfig")]
        public TenantAuthDomainConfig? AuthDomainConfig { get; set; }

        //      C# -> List<CrossAccountCapability>? CrossAccountCapabilities
        // GraphQL -> crossAccountCapabilities: [CrossAccountCapability!]! (enum)
        [JsonProperty("crossAccountCapabilities")]
        public List<CrossAccountCapability>? CrossAccountCapabilities { get; set; }

        //      C# -> TenantNetworkHealth? TenantNetworkHealth
        // GraphQL -> tenantNetworkHealth: TenantNetworkHealth! (enum)
        [JsonProperty("tenantNetworkHealth")]
        public TenantNetworkHealth? TenantNetworkHealth { get; set; }

        //      C# -> List<System.String>? AllUrls
        // GraphQL -> allUrls: [String!]! (scalar)
        [JsonProperty("allUrls")]
        public List<System.String>? AllUrls { get; set; }

        //      C# -> List<System.String>? AllowedClusters
        // GraphQL -> allowedClusters: [String!]! (scalar)
        [JsonProperty("allowedClusters")]
        public List<System.String>? AllowedClusters { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        [JsonProperty("fullName")]
        public System.String? FullName { get; set; }

        //      C# -> System.Boolean? HasOwnIdpConfigured
        // GraphQL -> hasOwnIdpConfigured: Boolean! (scalar)
        [JsonProperty("hasOwnIdpConfigured")]
        public System.Boolean? HasOwnIdpConfigured { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsEnvoyRequired
        // GraphQL -> isEnvoyRequired: Boolean! (scalar)
        [JsonProperty("isEnvoyRequired")]
        public System.Boolean? IsEnvoyRequired { get; set; }

        //      C# -> System.Boolean? IsServiceAccountDisabled
        // GraphQL -> isServiceAccountDisabled: Boolean! (scalar)
        [JsonProperty("isServiceAccountDisabled")]
        public System.Boolean? IsServiceAccountDisabled { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int64? PhysicalStorageUsed
        // GraphQL -> physicalStorageUsed: Long! (scalar)
        [JsonProperty("physicalStorageUsed")]
        public System.Int64? PhysicalStorageUsed { get; set; }

        //      C# -> System.Boolean? ShouldEnforceMfaForAll
        // GraphQL -> shouldEnforceMfaForAll: Boolean! (scalar)
        [JsonProperty("shouldEnforceMfaForAll")]
        public System.Boolean? ShouldEnforceMfaForAll { get; set; }

        //      C# -> List<ClusterCapacityQuota>? AllClusterCapacityQuotas
        // GraphQL -> allClusterCapacityQuotas: [ClusterCapacityQuota!]! (type)
        [JsonProperty("allClusterCapacityQuotas")]
        public List<ClusterCapacityQuota>? AllClusterCapacityQuotas { get; set; }

        //      C# -> Role? OrgAdminRole
        // GraphQL -> orgAdminRole: Role! (type)
        [JsonProperty("orgAdminRole")]
        public Role? OrgAdminRole { get; set; }

        //      C# -> List<Permission>? Permissions
        // GraphQL -> permissions: [Permission!]! (type)
        [JsonProperty("permissions")]
        public List<Permission>? Permissions { get; set; }

        //      C# -> List<SelfServicePermission>? SelfServicePermissions
        // GraphQL -> selfServicePermissions: [SelfServicePermission!]! (type)
        [JsonProperty("selfServicePermissions")]
        public List<SelfServicePermission>? SelfServicePermissions { get; set; }

        //      C# -> List<SsoGroup>? SsoGroups
        // GraphQL -> ssoGroups: [SsoGroup!]! (type)
        [JsonProperty("ssoGroups")]
        public List<SsoGroup>? SsoGroups { get; set; }

        //      C# -> List<ExistingUser>? Users
        // GraphQL -> users: [ExistingUser!]! (type)
        [JsonProperty("users")]
        public List<ExistingUser>? Users { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Org";
    }

    public Org Set(
        TenantAuthDomainConfig? AuthDomainConfig = null,
        List<CrossAccountCapability>? CrossAccountCapabilities = null,
        TenantNetworkHealth? TenantNetworkHealth = null,
        List<System.String>? AllUrls = null,
        List<System.String>? AllowedClusters = null,
        System.String? Description = null,
        System.String? FullName = null,
        System.Boolean? HasOwnIdpConfigured = null,
        System.String? Id = null,
        System.Boolean? IsEnvoyRequired = null,
        System.Boolean? IsServiceAccountDisabled = null,
        System.String? Name = null,
        System.Int64? PhysicalStorageUsed = null,
        System.Boolean? ShouldEnforceMfaForAll = null,
        List<ClusterCapacityQuota>? AllClusterCapacityQuotas = null,
        Role? OrgAdminRole = null,
        List<Permission>? Permissions = null,
        List<SelfServicePermission>? SelfServicePermissions = null,
        List<SsoGroup>? SsoGroups = null,
        List<ExistingUser>? Users = null
    ) 
    {
        if ( AuthDomainConfig != null ) {
            this.AuthDomainConfig = AuthDomainConfig;
        }
        if ( CrossAccountCapabilities != null ) {
            this.CrossAccountCapabilities = CrossAccountCapabilities;
        }
        if ( TenantNetworkHealth != null ) {
            this.TenantNetworkHealth = TenantNetworkHealth;
        }
        if ( AllUrls != null ) {
            this.AllUrls = AllUrls;
        }
        if ( AllowedClusters != null ) {
            this.AllowedClusters = AllowedClusters;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( FullName != null ) {
            this.FullName = FullName;
        }
        if ( HasOwnIdpConfigured != null ) {
            this.HasOwnIdpConfigured = HasOwnIdpConfigured;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsEnvoyRequired != null ) {
            this.IsEnvoyRequired = IsEnvoyRequired;
        }
        if ( IsServiceAccountDisabled != null ) {
            this.IsServiceAccountDisabled = IsServiceAccountDisabled;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PhysicalStorageUsed != null ) {
            this.PhysicalStorageUsed = PhysicalStorageUsed;
        }
        if ( ShouldEnforceMfaForAll != null ) {
            this.ShouldEnforceMfaForAll = ShouldEnforceMfaForAll;
        }
        if ( AllClusterCapacityQuotas != null ) {
            this.AllClusterCapacityQuotas = AllClusterCapacityQuotas;
        }
        if ( OrgAdminRole != null ) {
            this.OrgAdminRole = OrgAdminRole;
        }
        if ( Permissions != null ) {
            this.Permissions = Permissions;
        }
        if ( SelfServicePermissions != null ) {
            this.SelfServicePermissions = SelfServicePermissions;
        }
        if ( SsoGroups != null ) {
            this.SsoGroups = SsoGroups;
        }
        if ( Users != null ) {
            this.Users = Users;
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
        //      C# -> TenantAuthDomainConfig? AuthDomainConfig
        // GraphQL -> authDomainConfig: TenantAuthDomainConfig! (enum)
        if (this.AuthDomainConfig != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authDomainConfig\n" ;
            } else {
                s += ind + "authDomainConfig\n" ;
            }
        }
        //      C# -> List<CrossAccountCapability>? CrossAccountCapabilities
        // GraphQL -> crossAccountCapabilities: [CrossAccountCapability!]! (enum)
        if (this.CrossAccountCapabilities != null) {
            if (conf.Flat) {
                s += conf.Prefix + "crossAccountCapabilities\n" ;
            } else {
                s += ind + "crossAccountCapabilities\n" ;
            }
        }
        //      C# -> TenantNetworkHealth? TenantNetworkHealth
        // GraphQL -> tenantNetworkHealth: TenantNetworkHealth! (enum)
        if (this.TenantNetworkHealth != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tenantNetworkHealth\n" ;
            } else {
                s += ind + "tenantNetworkHealth\n" ;
            }
        }
        //      C# -> List<System.String>? AllUrls
        // GraphQL -> allUrls: [String!]! (scalar)
        if (this.AllUrls != null) {
            if (conf.Flat) {
                s += conf.Prefix + "allUrls\n" ;
            } else {
                s += ind + "allUrls\n" ;
            }
        }
        //      C# -> List<System.String>? AllowedClusters
        // GraphQL -> allowedClusters: [String!]! (scalar)
        if (this.AllowedClusters != null) {
            if (conf.Flat) {
                s += conf.Prefix + "allowedClusters\n" ;
            } else {
                s += ind + "allowedClusters\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        if (this.FullName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fullName\n" ;
            } else {
                s += ind + "fullName\n" ;
            }
        }
        //      C# -> System.Boolean? HasOwnIdpConfigured
        // GraphQL -> hasOwnIdpConfigured: Boolean! (scalar)
        if (this.HasOwnIdpConfigured != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasOwnIdpConfigured\n" ;
            } else {
                s += ind + "hasOwnIdpConfigured\n" ;
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
        //      C# -> System.Boolean? IsEnvoyRequired
        // GraphQL -> isEnvoyRequired: Boolean! (scalar)
        if (this.IsEnvoyRequired != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEnvoyRequired\n" ;
            } else {
                s += ind + "isEnvoyRequired\n" ;
            }
        }
        //      C# -> System.Boolean? IsServiceAccountDisabled
        // GraphQL -> isServiceAccountDisabled: Boolean! (scalar)
        if (this.IsServiceAccountDisabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isServiceAccountDisabled\n" ;
            } else {
                s += ind + "isServiceAccountDisabled\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.Int64? PhysicalStorageUsed
        // GraphQL -> physicalStorageUsed: Long! (scalar)
        if (this.PhysicalStorageUsed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "physicalStorageUsed\n" ;
            } else {
                s += ind + "physicalStorageUsed\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldEnforceMfaForAll
        // GraphQL -> shouldEnforceMfaForAll: Boolean! (scalar)
        if (this.ShouldEnforceMfaForAll != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldEnforceMfaForAll\n" ;
            } else {
                s += ind + "shouldEnforceMfaForAll\n" ;
            }
        }
        //      C# -> List<ClusterCapacityQuota>? AllClusterCapacityQuotas
        // GraphQL -> allClusterCapacityQuotas: [ClusterCapacityQuota!]! (type)
        if (this.AllClusterCapacityQuotas != null) {
            var fspec = this.AllClusterCapacityQuotas.AsFieldSpec(conf.Child("allClusterCapacityQuotas"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allClusterCapacityQuotas" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Role? OrgAdminRole
        // GraphQL -> orgAdminRole: Role! (type)
        if (this.OrgAdminRole != null) {
            var fspec = this.OrgAdminRole.AsFieldSpec(conf.Child("orgAdminRole"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "orgAdminRole" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<Permission>? Permissions
        // GraphQL -> permissions: [Permission!]! (type)
        if (this.Permissions != null) {
            var fspec = this.Permissions.AsFieldSpec(conf.Child("permissions"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "permissions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<SelfServicePermission>? SelfServicePermissions
        // GraphQL -> selfServicePermissions: [SelfServicePermission!]! (type)
        if (this.SelfServicePermissions != null) {
            var fspec = this.SelfServicePermissions.AsFieldSpec(conf.Child("selfServicePermissions"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "selfServicePermissions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<SsoGroup>? SsoGroups
        // GraphQL -> ssoGroups: [SsoGroup!]! (type)
        if (this.SsoGroups != null) {
            var fspec = this.SsoGroups.AsFieldSpec(conf.Child("ssoGroups"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ssoGroups" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ExistingUser>? Users
        // GraphQL -> users: [ExistingUser!]! (type)
        if (this.Users != null) {
            var fspec = this.Users.AsFieldSpec(conf.Child("users"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "users" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TenantAuthDomainConfig? AuthDomainConfig
        // GraphQL -> authDomainConfig: TenantAuthDomainConfig! (enum)
        if (ec.Includes("authDomainConfig",true))
        {
            if(this.AuthDomainConfig == null) {

                this.AuthDomainConfig = new TenantAuthDomainConfig();

            } else {


            }
        }
        else if (this.AuthDomainConfig != null && ec.Excludes("authDomainConfig",true))
        {
            this.AuthDomainConfig = null;
        }
        //      C# -> List<CrossAccountCapability>? CrossAccountCapabilities
        // GraphQL -> crossAccountCapabilities: [CrossAccountCapability!]! (enum)
        if (ec.Includes("crossAccountCapabilities",true))
        {
            if(this.CrossAccountCapabilities == null) {

                this.CrossAccountCapabilities = new List<CrossAccountCapability>();

            } else {


            }
        }
        else if (this.CrossAccountCapabilities != null && ec.Excludes("crossAccountCapabilities",true))
        {
            this.CrossAccountCapabilities = null;
        }
        //      C# -> TenantNetworkHealth? TenantNetworkHealth
        // GraphQL -> tenantNetworkHealth: TenantNetworkHealth! (enum)
        if (ec.Includes("tenantNetworkHealth",true))
        {
            if(this.TenantNetworkHealth == null) {

                this.TenantNetworkHealth = new TenantNetworkHealth();

            } else {


            }
        }
        else if (this.TenantNetworkHealth != null && ec.Excludes("tenantNetworkHealth",true))
        {
            this.TenantNetworkHealth = null;
        }
        //      C# -> List<System.String>? AllUrls
        // GraphQL -> allUrls: [String!]! (scalar)
        if (ec.Includes("allUrls",true))
        {
            if(this.AllUrls == null) {

                this.AllUrls = new List<System.String>();

            } else {


            }
        }
        else if (this.AllUrls != null && ec.Excludes("allUrls",true))
        {
            this.AllUrls = null;
        }
        //      C# -> List<System.String>? AllowedClusters
        // GraphQL -> allowedClusters: [String!]! (scalar)
        if (ec.Includes("allowedClusters",true))
        {
            if(this.AllowedClusters == null) {

                this.AllowedClusters = new List<System.String>();

            } else {


            }
        }
        else if (this.AllowedClusters != null && ec.Excludes("allowedClusters",true))
        {
            this.AllowedClusters = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
        }
        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        if (ec.Includes("fullName",true))
        {
            if(this.FullName == null) {

                this.FullName = "FETCH";

            } else {


            }
        }
        else if (this.FullName != null && ec.Excludes("fullName",true))
        {
            this.FullName = null;
        }
        //      C# -> System.Boolean? HasOwnIdpConfigured
        // GraphQL -> hasOwnIdpConfigured: Boolean! (scalar)
        if (ec.Includes("hasOwnIdpConfigured",true))
        {
            if(this.HasOwnIdpConfigured == null) {

                this.HasOwnIdpConfigured = true;

            } else {


            }
        }
        else if (this.HasOwnIdpConfigured != null && ec.Excludes("hasOwnIdpConfigured",true))
        {
            this.HasOwnIdpConfigured = null;
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
        //      C# -> System.Boolean? IsEnvoyRequired
        // GraphQL -> isEnvoyRequired: Boolean! (scalar)
        if (ec.Includes("isEnvoyRequired",true))
        {
            if(this.IsEnvoyRequired == null) {

                this.IsEnvoyRequired = true;

            } else {


            }
        }
        else if (this.IsEnvoyRequired != null && ec.Excludes("isEnvoyRequired",true))
        {
            this.IsEnvoyRequired = null;
        }
        //      C# -> System.Boolean? IsServiceAccountDisabled
        // GraphQL -> isServiceAccountDisabled: Boolean! (scalar)
        if (ec.Includes("isServiceAccountDisabled",true))
        {
            if(this.IsServiceAccountDisabled == null) {

                this.IsServiceAccountDisabled = true;

            } else {


            }
        }
        else if (this.IsServiceAccountDisabled != null && ec.Excludes("isServiceAccountDisabled",true))
        {
            this.IsServiceAccountDisabled = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.Int64? PhysicalStorageUsed
        // GraphQL -> physicalStorageUsed: Long! (scalar)
        if (ec.Includes("physicalStorageUsed",true))
        {
            if(this.PhysicalStorageUsed == null) {

                this.PhysicalStorageUsed = new System.Int64();

            } else {


            }
        }
        else if (this.PhysicalStorageUsed != null && ec.Excludes("physicalStorageUsed",true))
        {
            this.PhysicalStorageUsed = null;
        }
        //      C# -> System.Boolean? ShouldEnforceMfaForAll
        // GraphQL -> shouldEnforceMfaForAll: Boolean! (scalar)
        if (ec.Includes("shouldEnforceMfaForAll",true))
        {
            if(this.ShouldEnforceMfaForAll == null) {

                this.ShouldEnforceMfaForAll = true;

            } else {


            }
        }
        else if (this.ShouldEnforceMfaForAll != null && ec.Excludes("shouldEnforceMfaForAll",true))
        {
            this.ShouldEnforceMfaForAll = null;
        }
        //      C# -> List<ClusterCapacityQuota>? AllClusterCapacityQuotas
        // GraphQL -> allClusterCapacityQuotas: [ClusterCapacityQuota!]! (type)
        if (ec.Includes("allClusterCapacityQuotas",false))
        {
            if(this.AllClusterCapacityQuotas == null) {

                this.AllClusterCapacityQuotas = new List<ClusterCapacityQuota>();
                this.AllClusterCapacityQuotas.ApplyExploratoryFieldSpec(ec.NewChild("allClusterCapacityQuotas"));

            } else {

                this.AllClusterCapacityQuotas.ApplyExploratoryFieldSpec(ec.NewChild("allClusterCapacityQuotas"));

            }
        }
        else if (this.AllClusterCapacityQuotas != null && ec.Excludes("allClusterCapacityQuotas",false))
        {
            this.AllClusterCapacityQuotas = null;
        }
        //      C# -> Role? OrgAdminRole
        // GraphQL -> orgAdminRole: Role! (type)
        if (ec.Includes("orgAdminRole",false))
        {
            if(this.OrgAdminRole == null) {

                this.OrgAdminRole = new Role();
                this.OrgAdminRole.ApplyExploratoryFieldSpec(ec.NewChild("orgAdminRole"));

            } else {

                this.OrgAdminRole.ApplyExploratoryFieldSpec(ec.NewChild("orgAdminRole"));

            }
        }
        else if (this.OrgAdminRole != null && ec.Excludes("orgAdminRole",false))
        {
            this.OrgAdminRole = null;
        }
        //      C# -> List<Permission>? Permissions
        // GraphQL -> permissions: [Permission!]! (type)
        if (ec.Includes("permissions",false))
        {
            if(this.Permissions == null) {

                this.Permissions = new List<Permission>();
                this.Permissions.ApplyExploratoryFieldSpec(ec.NewChild("permissions"));

            } else {

                this.Permissions.ApplyExploratoryFieldSpec(ec.NewChild("permissions"));

            }
        }
        else if (this.Permissions != null && ec.Excludes("permissions",false))
        {
            this.Permissions = null;
        }
        //      C# -> List<SelfServicePermission>? SelfServicePermissions
        // GraphQL -> selfServicePermissions: [SelfServicePermission!]! (type)
        if (ec.Includes("selfServicePermissions",false))
        {
            if(this.SelfServicePermissions == null) {

                this.SelfServicePermissions = new List<SelfServicePermission>();
                this.SelfServicePermissions.ApplyExploratoryFieldSpec(ec.NewChild("selfServicePermissions"));

            } else {

                this.SelfServicePermissions.ApplyExploratoryFieldSpec(ec.NewChild("selfServicePermissions"));

            }
        }
        else if (this.SelfServicePermissions != null && ec.Excludes("selfServicePermissions",false))
        {
            this.SelfServicePermissions = null;
        }
        //      C# -> List<SsoGroup>? SsoGroups
        // GraphQL -> ssoGroups: [SsoGroup!]! (type)
        if (ec.Includes("ssoGroups",false))
        {
            if(this.SsoGroups == null) {

                this.SsoGroups = new List<SsoGroup>();
                this.SsoGroups.ApplyExploratoryFieldSpec(ec.NewChild("ssoGroups"));

            } else {

                this.SsoGroups.ApplyExploratoryFieldSpec(ec.NewChild("ssoGroups"));

            }
        }
        else if (this.SsoGroups != null && ec.Excludes("ssoGroups",false))
        {
            this.SsoGroups = null;
        }
        //      C# -> List<ExistingUser>? Users
        // GraphQL -> users: [ExistingUser!]! (type)
        if (ec.Includes("users",false))
        {
            if(this.Users == null) {

                this.Users = new List<ExistingUser>();
                this.Users.ApplyExploratoryFieldSpec(ec.NewChild("users"));

            } else {

                this.Users.ApplyExploratoryFieldSpec(ec.NewChild("users"));

            }
        }
        else if (this.Users != null && ec.Excludes("users",false))
        {
            this.Users = null;
        }
    }


    #endregion

    } // class Org
    
    #endregion

    public static class ListOrgExtensions
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
            this List<Org> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Org> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Org> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Org());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Org> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types