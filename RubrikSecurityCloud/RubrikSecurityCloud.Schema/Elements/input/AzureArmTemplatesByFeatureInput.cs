// AzureArmTemplatesByFeatureInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:27.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region AzureArmTemplatesByFeatureInput

    public class AzureArmTemplatesByFeatureInput
    {
        #region members
        //      C# -> System.String? CustomerTenantDomainName
        // GraphQL -> customerTenantDomainName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("customerTenantDomainName")]
        public System.String? CustomerTenantDomainName { get; set; }

        //      C# -> List<CloudAccountFeature>? Features
        // GraphQL -> features: [CloudAccountFeature!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("features")]
        public List<CloudAccountFeature>? Features { get; set; }

        //      C# -> CloudAccountOperation? OperationType
        // GraphQL -> operationType: CloudAccountOperation! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("operationType")]
        public CloudAccountOperation? OperationType { get; set; }

        //      C# -> AzureCloudType? CloudType
        // GraphQL -> cloudType: AzureCloudType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudType")]
        public AzureCloudType? CloudType { get; set; }

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

    } // class AzureArmTemplatesByFeatureInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types