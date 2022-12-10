// AzureSqlManagedInstanceDatabaseFilters.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:15.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region AzureSqlManagedInstanceDatabaseFilters

    public class AzureSqlManagedInstanceDatabaseFilters
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

        //      C# -> AzureSqlManagedInstanceDatabaseResourceGroupFilter? ResourceGroupFilter
        // GraphQL -> resourceGroupFilter: AzureSqlManagedInstanceDatabaseResourceGroupFilter (input)
        [JsonProperty("resourceGroupFilter")]
        public AzureSqlManagedInstanceDatabaseResourceGroupFilter? ResourceGroupFilter { get; set; }

        //      C# -> AzureSqlManagedInstanceDatabaseSubscriptionFilter? SubscriptionFilter
        // GraphQL -> subscriptionFilter: AzureSqlManagedInstanceDatabaseSubscriptionFilter (input)
        [JsonProperty("subscriptionFilter")]
        public AzureSqlManagedInstanceDatabaseSubscriptionFilter? SubscriptionFilter { get; set; }

        //      C# -> AzureNativeRegionFilter? RegionFilter
        // GraphQL -> regionFilter: AzureNativeRegionFilter (input)
        [JsonProperty("regionFilter")]
        public AzureNativeRegionFilter? RegionFilter { get; set; }

        //      C# -> RelicFilter? RelicFilter
        // GraphQL -> relicFilter: RelicFilter (input)
        [JsonProperty("relicFilter")]
        public RelicFilter? RelicFilter { get; set; }

        //      C# -> CloudNativeDatabaseServerFilter? ServerFilter
        // GraphQL -> serverFilter: CloudNativeDatabaseServerFilter (input)
        [JsonProperty("serverFilter")]
        public CloudNativeDatabaseServerFilter? ServerFilter { get; set; }

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

    } // class AzureSqlManagedInstanceDatabaseFilters
    #endregion

} // namespace Rubrik.SecurityCloud.Types