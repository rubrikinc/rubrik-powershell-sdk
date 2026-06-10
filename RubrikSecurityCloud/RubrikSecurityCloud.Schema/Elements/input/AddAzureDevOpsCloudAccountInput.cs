// AddAzureDevOpsCloudAccountInput.cs
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
    #region AddAzureDevOpsCloudAccountInput

    public class AddAzureDevOpsCloudAccountInput: IInput
    {
        #region members

        //      C# -> System.String? OrganizationNativeId
        // GraphQL -> organizationNativeId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("organizationNativeId")]
        public System.String? OrganizationNativeId { get; set; }

        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }

        //      C# -> System.String? BackupLocationId
        // GraphQL -> backupLocationId: UUID (scalar)
        [JsonProperty("backupLocationId")]
        public System.String? BackupLocationId { get; set; }

        //      C# -> System.String? BackupRegion
        // GraphQL -> backupRegion: String (scalar)
        [JsonProperty("backupRegion")]
        public System.String? BackupRegion { get; set; }

        //      C# -> System.String? ExocomputeCloudAccountId
        // GraphQL -> exocomputeCloudAccountId: UUID (scalar)
        [JsonProperty("exocomputeCloudAccountId")]
        public System.String? ExocomputeCloudAccountId { get; set; }

        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sessionId")]
        public System.String? SessionId { get; set; }

        //      C# -> List<FeatureWithPermissionsGroups>? FeaturesWithPermissionsGroups
        // GraphQL -> featuresWithPermissionsGroups: [FeatureWithPermissionsGroups!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("featuresWithPermissionsGroups")]
        public List<FeatureWithPermissionsGroups>? FeaturesWithPermissionsGroups { get; set; }

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

    } // class AddAzureDevOpsCloudAccountInput
    #endregion

} // namespace RubrikSecurityCloud.Types