// AzureSqlDatabaseServerFilters.cs
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
    #region AzureSqlDatabaseServerFilters

    public class AzureSqlDatabaseServerFilters: IInput
    {
        #region members

        //      C# -> NameSubstringFilter? NameSubstringFilter
        // GraphQL -> nameSubstringFilter: NameSubstringFilter (input)
        [JsonProperty("nameSubstringFilter")]
        public NameSubstringFilter? NameSubstringFilter { get; set; }

        //      C# -> EffectiveSlaFilter? EffectiveSlaFilter
        // GraphQL -> effectiveSlaFilter: EffectiveSlaFilter (input)
        [JsonProperty("effectiveSlaFilter")]
        public EffectiveSlaFilter? EffectiveSlaFilter { get; set; }

        //      C# -> AzureSqlDatabaseServerResourceGroupFilter? ResourceGroupFilter
        // GraphQL -> resourceGroupFilter: AzureSqlDatabaseServerResourceGroupFilter (input)
        [JsonProperty("resourceGroupFilter")]
        public AzureSqlDatabaseServerResourceGroupFilter? ResourceGroupFilter { get; set; }

        //      C# -> AzureSqlDatabaseServerSubscriptionFilter? SubscriptionFilter
        // GraphQL -> subscriptionFilter: AzureSqlDatabaseServerSubscriptionFilter (input)
        [JsonProperty("subscriptionFilter")]
        public AzureSqlDatabaseServerSubscriptionFilter? SubscriptionFilter { get; set; }

        //      C# -> AzureNativeRegionFilter? RegionFilter
        // GraphQL -> regionFilter: AzureNativeRegionFilter (input)
        [JsonProperty("regionFilter")]
        public AzureNativeRegionFilter? RegionFilter { get; set; }

        //      C# -> AzureNativeIsEligibleForSqlDatabaseServerProtectionFilter? AzureNativeIsEligibleForSqlDatabaseServerProtectionFilter
        // GraphQL -> azureNativeIsEligibleForSqlDatabaseServerProtectionFilter: AzureNativeIsEligibleForSqlDatabaseServerProtectionFilter (input)
        [JsonProperty("azureNativeIsEligibleForSqlDatabaseServerProtectionFilter")]
        public AzureNativeIsEligibleForSqlDatabaseServerProtectionFilter? AzureNativeIsEligibleForSqlDatabaseServerProtectionFilter { get; set; }

        //      C# -> System.Boolean? IsEligibleForProtection
        // GraphQL -> isEligibleForProtection: Boolean (scalar)
        [JsonProperty("isEligibleForProtection")]
        public System.Boolean? IsEligibleForProtection { get; set; }


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

    } // class AzureSqlDatabaseServerFilters
    #endregion

} // namespace RubrikSecurityCloud.Types