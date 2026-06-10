// AddGitHubCloudAccountInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region AddGitHubCloudAccountInput

    public class AddGitHubCloudAccountInput: IInput
    {
        #region members

        //      C# -> System.String? OrganizationName
        // GraphQL -> organizationName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("organizationName")]
        public System.String? OrganizationName { get; set; }

        //      C# -> System.String? ArchivalGroupId
        // GraphQL -> archivalGroupId: UUID (scalar)
        [JsonProperty("archivalGroupId")]
        public System.String? ArchivalGroupId { get; set; }

        //      C# -> System.String? ExocomputeCloudAccountId
        // GraphQL -> exocomputeCloudAccountId: UUID (scalar)
        [JsonProperty("exocomputeCloudAccountId")]
        public System.String? ExocomputeCloudAccountId { get; set; }

        //      C# -> DevopsHostType? HostType
        // GraphQL -> hostType: DevopsHostType (enum)
        [JsonProperty("hostType")]
        public DevopsHostType? HostType { get; set; }

        //      C# -> DevOpsStorageType? StorageType
        // GraphQL -> storageType: DevOpsStorageType (enum)
        [JsonProperty("storageType")]
        public DevOpsStorageType? StorageType { get; set; }

        //      C# -> System.String? ExocomputeRegion
        // GraphQL -> exocomputeRegion: String (scalar)
        [JsonProperty("exocomputeRegion")]
        public System.String? ExocomputeRegion { get; set; }

        //      C# -> System.String? OrganizationUrl
        // GraphQL -> organizationUrl: String (scalar)
        [JsonProperty("organizationUrl")]
        public System.String? OrganizationUrl { get; set; }


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

    } // class AddGitHubCloudAccountInput
    #endregion

} // namespace RubrikSecurityCloud.Types