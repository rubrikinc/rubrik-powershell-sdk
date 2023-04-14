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

namespace Rubrik.SecurityCloud.Types
{
    #region Org
    public class Org: IFragment
    {
        #region members
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

        //      C# -> TenantAuthDomainConfig? AuthDomainConfig
        // GraphQL -> authDomainConfig: TenantAuthDomainConfig! (enum)
        [JsonProperty("authDomainConfig")]
        public TenantAuthDomainConfig? AuthDomainConfig { get; set; }

        //      C# -> TenantNetworkHealth? TenantNetworkHealth
        // GraphQL -> tenantNetworkHealth: TenantNetworkHealth! (enum)
        [JsonProperty("tenantNetworkHealth")]
        public TenantNetworkHealth? TenantNetworkHealth { get; set; }

        #endregion

    #region methods

    public Org Set(
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
        List<ExistingUser>? Users = null,
        TenantAuthDomainConfig? AuthDomainConfig = null,
        TenantNetworkHealth? TenantNetworkHealth = null
    ) 
    {
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
        if ( AuthDomainConfig != null ) {
            this.AuthDomainConfig = AuthDomainConfig;
        }
        if ( TenantNetworkHealth != null ) {
            this.TenantNetworkHealth = TenantNetworkHealth;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> List<System.String>? AllUrls
            // GraphQL -> allUrls: [String!]! (scalar)
            if (this.AllUrls != null)
            {
                 s += ind + "allUrls\n";

            }
            //      C# -> List<System.String>? AllowedClusters
            // GraphQL -> allowedClusters: [String!]! (scalar)
            if (this.AllowedClusters != null)
            {
                 s += ind + "allowedClusters\n";

            }
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description != null)
            {
                 s += ind + "description\n";

            }
            //      C# -> System.String? FullName
            // GraphQL -> fullName: String! (scalar)
            if (this.FullName != null)
            {
                 s += ind + "fullName\n";

            }
            //      C# -> System.Boolean? HasOwnIdpConfigured
            // GraphQL -> hasOwnIdpConfigured: Boolean! (scalar)
            if (this.HasOwnIdpConfigured != null)
            {
                 s += ind + "hasOwnIdpConfigured\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsEnvoyRequired
            // GraphQL -> isEnvoyRequired: Boolean! (scalar)
            if (this.IsEnvoyRequired != null)
            {
                 s += ind + "isEnvoyRequired\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.Int64? PhysicalStorageUsed
            // GraphQL -> physicalStorageUsed: Long! (scalar)
            if (this.PhysicalStorageUsed != null)
            {
                 s += ind + "physicalStorageUsed\n";

            }
            //      C# -> System.Boolean? ShouldEnforceMfaForAll
            // GraphQL -> shouldEnforceMfaForAll: Boolean! (scalar)
            if (this.ShouldEnforceMfaForAll != null)
            {
                 s += ind + "shouldEnforceMfaForAll\n";

            }
            //      C# -> Role? OrgAdminRole
            // GraphQL -> orgAdminRole: Role! (type)
            if (this.OrgAdminRole != null)
            {
                 s += ind + "orgAdminRole\n";

                 s += ind + "{\n" + 
                 this.OrgAdminRole.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<Permission>? Permissions
            // GraphQL -> permissions: [Permission!]! (type)
            if (this.Permissions != null)
            {
                 s += ind + "permissions\n";

                 s += ind + "{\n" + 
                 this.Permissions.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<SelfServicePermission>? SelfServicePermissions
            // GraphQL -> selfServicePermissions: [SelfServicePermission!]! (type)
            if (this.SelfServicePermissions != null)
            {
                 s += ind + "selfServicePermissions\n";

                 s += ind + "{\n" + 
                 this.SelfServicePermissions.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<SsoGroup>? SsoGroups
            // GraphQL -> ssoGroups: [SsoGroup!]! (type)
            if (this.SsoGroups != null)
            {
                 s += ind + "ssoGroups\n";

                 s += ind + "{\n" + 
                 this.SsoGroups.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ExistingUser>? Users
            // GraphQL -> users: [ExistingUser!]! (type)
            if (this.Users != null)
            {
                 s += ind + "users\n";

                 s += ind + "{\n" + 
                 this.Users.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> TenantAuthDomainConfig? AuthDomainConfig
            // GraphQL -> authDomainConfig: TenantAuthDomainConfig! (enum)
            if (this.AuthDomainConfig != null)
            {
                 s += ind + "authDomainConfig\n";

            }
            //      C# -> TenantNetworkHealth? TenantNetworkHealth
            // GraphQL -> tenantNetworkHealth: TenantNetworkHealth! (enum)
            if (this.TenantNetworkHealth != null)
            {
                 s += ind + "tenantNetworkHealth\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? AllUrls
            // GraphQL -> allUrls: [String!]! (scalar)
            if (this.AllUrls == null && Exploration.Includes(parent + ".allUrls$"))
            {
                this.AllUrls = new List<System.String>();
            }
            //      C# -> List<System.String>? AllowedClusters
            // GraphQL -> allowedClusters: [String!]! (scalar)
            if (this.AllowedClusters == null && Exploration.Includes(parent + ".allowedClusters$"))
            {
                this.AllowedClusters = new List<System.String>();
            }
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description == null && Exploration.Includes(parent + ".description$"))
            {
                this.Description = new System.String("FETCH");
            }
            //      C# -> System.String? FullName
            // GraphQL -> fullName: String! (scalar)
            if (this.FullName == null && Exploration.Includes(parent + ".fullName$"))
            {
                this.FullName = new System.String("FETCH");
            }
            //      C# -> System.Boolean? HasOwnIdpConfigured
            // GraphQL -> hasOwnIdpConfigured: Boolean! (scalar)
            if (this.HasOwnIdpConfigured == null && Exploration.Includes(parent + ".hasOwnIdpConfigured$"))
            {
                this.HasOwnIdpConfigured = new System.Boolean();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsEnvoyRequired
            // GraphQL -> isEnvoyRequired: Boolean! (scalar)
            if (this.IsEnvoyRequired == null && Exploration.Includes(parent + ".isEnvoyRequired$"))
            {
                this.IsEnvoyRequired = new System.Boolean();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.Int64? PhysicalStorageUsed
            // GraphQL -> physicalStorageUsed: Long! (scalar)
            if (this.PhysicalStorageUsed == null && Exploration.Includes(parent + ".physicalStorageUsed$"))
            {
                this.PhysicalStorageUsed = new System.Int64();
            }
            //      C# -> System.Boolean? ShouldEnforceMfaForAll
            // GraphQL -> shouldEnforceMfaForAll: Boolean! (scalar)
            if (this.ShouldEnforceMfaForAll == null && Exploration.Includes(parent + ".shouldEnforceMfaForAll$"))
            {
                this.ShouldEnforceMfaForAll = new System.Boolean();
            }
            //      C# -> Role? OrgAdminRole
            // GraphQL -> orgAdminRole: Role! (type)
            if (this.OrgAdminRole == null && Exploration.Includes(parent + ".orgAdminRole"))
            {
                this.OrgAdminRole = new Role();
                this.OrgAdminRole.ApplyExploratoryFragment(parent + ".orgAdminRole");
            }
            //      C# -> List<Permission>? Permissions
            // GraphQL -> permissions: [Permission!]! (type)
            if (this.Permissions == null && Exploration.Includes(parent + ".permissions"))
            {
                this.Permissions = new List<Permission>();
                this.Permissions.ApplyExploratoryFragment(parent + ".permissions");
            }
            //      C# -> List<SelfServicePermission>? SelfServicePermissions
            // GraphQL -> selfServicePermissions: [SelfServicePermission!]! (type)
            if (this.SelfServicePermissions == null && Exploration.Includes(parent + ".selfServicePermissions"))
            {
                this.SelfServicePermissions = new List<SelfServicePermission>();
                this.SelfServicePermissions.ApplyExploratoryFragment(parent + ".selfServicePermissions");
            }
            //      C# -> List<SsoGroup>? SsoGroups
            // GraphQL -> ssoGroups: [SsoGroup!]! (type)
            if (this.SsoGroups == null && Exploration.Includes(parent + ".ssoGroups"))
            {
                this.SsoGroups = new List<SsoGroup>();
                this.SsoGroups.ApplyExploratoryFragment(parent + ".ssoGroups");
            }
            //      C# -> List<ExistingUser>? Users
            // GraphQL -> users: [ExistingUser!]! (type)
            if (this.Users == null && Exploration.Includes(parent + ".users"))
            {
                this.Users = new List<ExistingUser>();
                this.Users.ApplyExploratoryFragment(parent + ".users");
            }
            //      C# -> TenantAuthDomainConfig? AuthDomainConfig
            // GraphQL -> authDomainConfig: TenantAuthDomainConfig! (enum)
            if (this.AuthDomainConfig == null && Exploration.Includes(parent + ".authDomainConfig$"))
            {
                this.AuthDomainConfig = new TenantAuthDomainConfig();
            }
            //      C# -> TenantNetworkHealth? TenantNetworkHealth
            // GraphQL -> tenantNetworkHealth: TenantNetworkHealth! (enum)
            if (this.TenantNetworkHealth == null && Exploration.Includes(parent + ".tenantNetworkHealth$"))
            {
                this.TenantNetworkHealth = new TenantNetworkHealth();
            }
        }


    #endregion

    } // class Org
    #endregion

    public static class ListOrgExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<Org> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Org> list, 
            String parent = "")
        {
            var item = new Org();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types