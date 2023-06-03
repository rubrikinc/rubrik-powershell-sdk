// CreateOrgInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region CreateOrgInput

    public class CreateOrgInput: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("fullName")]
        public System.String? FullName { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> TenantAuthDomainConfig? AuthDomainConfig
        // GraphQL -> authDomainConfig: TenantAuthDomainConfig! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("authDomainConfig")]
        public TenantAuthDomainConfig? AuthDomainConfig { get; set; }

        //      C# -> System.Boolean? ShouldEnforceMfaForAll
        // GraphQL -> shouldEnforceMfaForAll: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldEnforceMfaForAll")]
        public System.Boolean? ShouldEnforceMfaForAll { get; set; }

        //      C# -> System.Boolean? IsEnvoyRequired
        // GraphQL -> isEnvoyRequired: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isEnvoyRequired")]
        public System.Boolean? IsEnvoyRequired { get; set; }

        //      C# -> List<System.String>? AllowedClusters
        // GraphQL -> allowedClusters: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("allowedClusters")]
        public List<System.String>? AllowedClusters { get; set; }

        //      C# -> List<ExistingUserInput>? ExistingUsers
        // GraphQL -> existingUsers: [ExistingUserInput!] (input)
        [JsonProperty("existingUsers")]
        public List<ExistingUserInput>? ExistingUsers { get; set; }

        //      C# -> List<UserInviteInput>? UserInvites
        // GraphQL -> userInvites: [UserInviteInput!] (input)
        [JsonProperty("userInvites")]
        public List<UserInviteInput>? UserInvites { get; set; }

        //      C# -> List<PermissionInput>? Permissions
        // GraphQL -> permissions: [PermissionInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("permissions")]
        public List<PermissionInput>? Permissions { get; set; }

        //      C# -> List<SelfServicePermissionInput>? SelfServicePermissions
        // GraphQL -> selfServicePermissions: [SelfServicePermissionInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("selfServicePermissions")]
        public List<SelfServicePermissionInput>? SelfServicePermissions { get; set; }

        //      C# -> List<ExistingSsoGroupInput>? ExistingSsoGroups
        // GraphQL -> existingSsoGroups: [ExistingSsoGroupInput!] (input)
        [JsonProperty("existingSsoGroups")]
        public List<ExistingSsoGroupInput>? ExistingSsoGroups { get; set; }

        //      C# -> List<NewSsoGroupInput>? NewSsoGroups
        // GraphQL -> newSsoGroups: [NewSsoGroupInput!] (input)
        [JsonProperty("newSsoGroups")]
        public List<NewSsoGroupInput>? NewSsoGroups { get; set; }


        #endregion

    
        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;

                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion

    } // class CreateOrgInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types