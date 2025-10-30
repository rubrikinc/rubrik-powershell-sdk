// AzureSqlManagedInstanceServerFilters.cs
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
    #region AzureSqlManagedInstanceServerFilters

    public class AzureSqlManagedInstanceServerFilters: IInput
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

        //      C# -> AzureSqlManagedInstanceServerResourceGroupFilter? ResourceGroupFilter
        // GraphQL -> resourceGroupFilter: AzureSqlManagedInstanceServerResourceGroupFilter (input)
        [JsonProperty("resourceGroupFilter")]
        public AzureSqlManagedInstanceServerResourceGroupFilter? ResourceGroupFilter { get; set; }

        //      C# -> AzureSqlManagedInstanceServerSubscriptionFilter? SubscriptionFilter
        // GraphQL -> subscriptionFilter: AzureSqlManagedInstanceServerSubscriptionFilter (input)
        [JsonProperty("subscriptionFilter")]
        public AzureSqlManagedInstanceServerSubscriptionFilter? SubscriptionFilter { get; set; }

        //      C# -> AzureNativeRegionFilter? RegionFilter
        // GraphQL -> regionFilter: AzureNativeRegionFilter (input)
        [JsonProperty("regionFilter")]
        public AzureNativeRegionFilter? RegionFilter { get; set; }

        //      C# -> AzureNativeTagFilter? TagFilter
        // GraphQL -> tagFilter: AzureNativeTagFilter (input)
        [JsonProperty("tagFilter")]
        public AzureNativeTagFilter? TagFilter { get; set; }

        //      C# -> AzureNativeIsEligibleForSqlMiServerProtectionFilter? AzureNativeIsEligibleForSqlMiServerProtectionFilter
        // GraphQL -> azureNativeIsEligibleForSqlMiServerProtectionFilter: AzureNativeIsEligibleForSqlMiServerProtectionFilter (input)
        [JsonProperty("azureNativeIsEligibleForSqlMiServerProtectionFilter")]
        public AzureNativeIsEligibleForSqlMiServerProtectionFilter? AzureNativeIsEligibleForSqlMiServerProtectionFilter { get; set; }

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

    } // class AzureSqlManagedInstanceServerFilters
    #endregion

} // namespace RubrikSecurityCloud.Types