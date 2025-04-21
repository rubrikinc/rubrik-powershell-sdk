// AzureExocomputeOptionalConfigInRegionInput.cs
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
    #region AzureExocomputeOptionalConfigInRegionInput

    public class AzureExocomputeOptionalConfigInRegionInput: IInput
    {
        #region members

        //      C# -> System.String? AksNodeRgPrefix
        // GraphQL -> aksNodeRgPrefix: String (scalar)
        [JsonProperty("aksNodeRgPrefix")]
        public System.String? AksNodeRgPrefix { get; set; }

        //      C# -> System.Boolean? DiskEncryptionAtHost
        // GraphQL -> diskEncryptionAtHost: Boolean (scalar)
        [JsonProperty("diskEncryptionAtHost")]
        public System.Boolean? DiskEncryptionAtHost { get; set; }

        //      C# -> List<System.String>? AdditionalWhitelistIps
        // GraphQL -> additionalWhitelistIps: [String!] (scalar)
        [JsonProperty("additionalWhitelistIps")]
        public List<System.String>? AdditionalWhitelistIps { get; set; }

        //      C# -> System.Boolean? EnableUserDefinedRouting
        // GraphQL -> enableUserDefinedRouting: Boolean (scalar)
        [JsonProperty("enableUserDefinedRouting")]
        public System.Boolean? EnableUserDefinedRouting { get; set; }

        //      C# -> System.Boolean? ShouldWhitelistRubrikIps
        // GraphQL -> shouldWhitelistRubrikIps: Boolean (scalar)
        [JsonProperty("shouldWhitelistRubrikIps")]
        public System.Boolean? ShouldWhitelistRubrikIps { get; set; }

        //      C# -> AksProvisionTier? AksClusterTier
        // GraphQL -> aksClusterTier: AKSProvisionTier (enum)
        [JsonProperty("aksClusterTier")]
        public AksProvisionTier? AksClusterTier { get; set; }

        //      C# -> AksNodeCountBucket? AksNodeCountBucket
        // GraphQL -> aksNodeCountBucket: AKSNodeCountBucket (enum)
        [JsonProperty("aksNodeCountBucket")]
        public AksNodeCountBucket? AksNodeCountBucket { get; set; }


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

    } // class AzureExocomputeOptionalConfigInRegionInput
    #endregion

} // namespace RubrikSecurityCloud.Types