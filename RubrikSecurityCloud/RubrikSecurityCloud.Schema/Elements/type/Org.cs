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
        TenantNetworkHealth? TenantNetworkHealth = null,
        List<System.String>? AllUrls = null,
        List<System.String>? AllowedClusters = null,
        System.String? Description = null,
        System.String? FullName = null,
        System.Boolean? HasOwnIdpConfigured = null,
        System.String? Id = null,
        System.Boolean? IsEnvoyRequired = null,
        System.String? Name = null,
        System.Int64? PhysicalStorageUsed = null,
        System.Boolean? ShouldEnforceMfaForAll = null,
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
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PhysicalStorageUsed != null ) {
            this.PhysicalStorageUsed = PhysicalStorageUsed;
        }
        if ( ShouldEnforceMfaForAll != null ) {
            this.ShouldEnforceMfaForAll = ShouldEnforceMfaForAll;
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> TenantAuthDomainConfig? AuthDomainConfig
        // GraphQL -> authDomainConfig: TenantAuthDomainConfig! (enum)
        if (this.AuthDomainConfig != null) {
            s += ind + "authDomainConfig\n" ;
        }
        //      C# -> TenantNetworkHealth? TenantNetworkHealth
        // GraphQL -> tenantNetworkHealth: TenantNetworkHealth! (enum)
        if (this.TenantNetworkHealth != null) {
            s += ind + "tenantNetworkHealth\n" ;
        }
        //      C# -> List<System.String>? AllUrls
        // GraphQL -> allUrls: [String!]! (scalar)
        if (this.AllUrls != null) {
            s += ind + "allUrls\n" ;
        }
        //      C# -> List<System.String>? AllowedClusters
        // GraphQL -> allowedClusters: [String!]! (scalar)
        if (this.AllowedClusters != null) {
            s += ind + "allowedClusters\n" ;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        if (this.FullName != null) {
            s += ind + "fullName\n" ;
        }
        //      C# -> System.Boolean? HasOwnIdpConfigured
        // GraphQL -> hasOwnIdpConfigured: Boolean! (scalar)
        if (this.HasOwnIdpConfigured != null) {
            s += ind + "hasOwnIdpConfigured\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsEnvoyRequired
        // GraphQL -> isEnvoyRequired: Boolean! (scalar)
        if (this.IsEnvoyRequired != null) {
            s += ind + "isEnvoyRequired\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.Int64? PhysicalStorageUsed
        // GraphQL -> physicalStorageUsed: Long! (scalar)
        if (this.PhysicalStorageUsed != null) {
            s += ind + "physicalStorageUsed\n" ;
        }
        //      C# -> System.Boolean? ShouldEnforceMfaForAll
        // GraphQL -> shouldEnforceMfaForAll: Boolean! (scalar)
        if (this.ShouldEnforceMfaForAll != null) {
            s += ind + "shouldEnforceMfaForAll\n" ;
        }
        //      C# -> Role? OrgAdminRole
        // GraphQL -> orgAdminRole: Role! (type)
        if (this.OrgAdminRole != null) {
            var fspec = this.OrgAdminRole.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "orgAdminRole {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<Permission>? Permissions
        // GraphQL -> permissions: [Permission!]! (type)
        if (this.Permissions != null) {
            var fspec = this.Permissions.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "permissions {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<SelfServicePermission>? SelfServicePermissions
        // GraphQL -> selfServicePermissions: [SelfServicePermission!]! (type)
        if (this.SelfServicePermissions != null) {
            var fspec = this.SelfServicePermissions.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "selfServicePermissions {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<SsoGroup>? SsoGroups
        // GraphQL -> ssoGroups: [SsoGroup!]! (type)
        if (this.SsoGroups != null) {
            var fspec = this.SsoGroups.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "ssoGroups {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ExistingUser>? Users
        // GraphQL -> users: [ExistingUser!]! (type)
        if (this.Users != null) {
            var fspec = this.Users.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "users {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TenantAuthDomainConfig? AuthDomainConfig
        // GraphQL -> authDomainConfig: TenantAuthDomainConfig! (enum)
        if (this.AuthDomainConfig == null && ec.Includes("authDomainConfig",true))
        {
            this.AuthDomainConfig = new TenantAuthDomainConfig();
        }
        //      C# -> TenantNetworkHealth? TenantNetworkHealth
        // GraphQL -> tenantNetworkHealth: TenantNetworkHealth! (enum)
        if (this.TenantNetworkHealth == null && ec.Includes("tenantNetworkHealth",true))
        {
            this.TenantNetworkHealth = new TenantNetworkHealth();
        }
        //      C# -> List<System.String>? AllUrls
        // GraphQL -> allUrls: [String!]! (scalar)
        if (this.AllUrls == null && ec.Includes("allUrls",true))
        {
            this.AllUrls = new List<System.String>();
        }
        //      C# -> List<System.String>? AllowedClusters
        // GraphQL -> allowedClusters: [String!]! (scalar)
        if (this.AllowedClusters == null && ec.Includes("allowedClusters",true))
        {
            this.AllowedClusters = new List<System.String>();
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description == null && ec.Includes("description",true))
        {
            this.Description = "FETCH";
        }
        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        if (this.FullName == null && ec.Includes("fullName",true))
        {
            this.FullName = "FETCH";
        }
        //      C# -> System.Boolean? HasOwnIdpConfigured
        // GraphQL -> hasOwnIdpConfigured: Boolean! (scalar)
        if (this.HasOwnIdpConfigured == null && ec.Includes("hasOwnIdpConfigured",true))
        {
            this.HasOwnIdpConfigured = true;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsEnvoyRequired
        // GraphQL -> isEnvoyRequired: Boolean! (scalar)
        if (this.IsEnvoyRequired == null && ec.Includes("isEnvoyRequired",true))
        {
            this.IsEnvoyRequired = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.Int64? PhysicalStorageUsed
        // GraphQL -> physicalStorageUsed: Long! (scalar)
        if (this.PhysicalStorageUsed == null && ec.Includes("physicalStorageUsed",true))
        {
            this.PhysicalStorageUsed = new System.Int64();
        }
        //      C# -> System.Boolean? ShouldEnforceMfaForAll
        // GraphQL -> shouldEnforceMfaForAll: Boolean! (scalar)
        if (this.ShouldEnforceMfaForAll == null && ec.Includes("shouldEnforceMfaForAll",true))
        {
            this.ShouldEnforceMfaForAll = true;
        }
        //      C# -> Role? OrgAdminRole
        // GraphQL -> orgAdminRole: Role! (type)
        if (this.OrgAdminRole == null && ec.Includes("orgAdminRole",false))
        {
            this.OrgAdminRole = new Role();
            this.OrgAdminRole.ApplyExploratoryFieldSpec(ec.NewChild("orgAdminRole"));
        }
        //      C# -> List<Permission>? Permissions
        // GraphQL -> permissions: [Permission!]! (type)
        if (this.Permissions == null && ec.Includes("permissions",false))
        {
            this.Permissions = new List<Permission>();
            this.Permissions.ApplyExploratoryFieldSpec(ec.NewChild("permissions"));
        }
        //      C# -> List<SelfServicePermission>? SelfServicePermissions
        // GraphQL -> selfServicePermissions: [SelfServicePermission!]! (type)
        if (this.SelfServicePermissions == null && ec.Includes("selfServicePermissions",false))
        {
            this.SelfServicePermissions = new List<SelfServicePermission>();
            this.SelfServicePermissions.ApplyExploratoryFieldSpec(ec.NewChild("selfServicePermissions"));
        }
        //      C# -> List<SsoGroup>? SsoGroups
        // GraphQL -> ssoGroups: [SsoGroup!]! (type)
        if (this.SsoGroups == null && ec.Includes("ssoGroups",false))
        {
            this.SsoGroups = new List<SsoGroup>();
            this.SsoGroups.ApplyExploratoryFieldSpec(ec.NewChild("ssoGroups"));
        }
        //      C# -> List<ExistingUser>? Users
        // GraphQL -> users: [ExistingUser!]! (type)
        if (this.Users == null && ec.Includes("users",false))
        {
            this.Users = new List<ExistingUser>();
            this.Users.ApplyExploratoryFieldSpec(ec.NewChild("users"));
        }
    }


    #endregion

    } // class Org
    
    #endregion

    public static class ListOrgExtensions
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
            this List<Org> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<Org> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types