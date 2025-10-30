// AzureSqlDatabaseFilters.cs
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
    #region AzureSqlDatabaseFilters

    public class AzureSqlDatabaseFilters: IInput
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

        //      C# -> AzureSqlDatabaseResourceGroupFilter? ResourceGroupFilter
        // GraphQL -> resourceGroupFilter: AzureSqlDatabaseResourceGroupFilter (input)
        [JsonProperty("resourceGroupFilter")]
        public AzureSqlDatabaseResourceGroupFilter? ResourceGroupFilter { get; set; }

        //      C# -> AzureSqlDatabaseSubscriptionFilter? SubscriptionFilter
        // GraphQL -> subscriptionFilter: AzureSqlDatabaseSubscriptionFilter (input)
        [JsonProperty("subscriptionFilter")]
        public AzureSqlDatabaseSubscriptionFilter? SubscriptionFilter { get; set; }

        //      C# -> AzureNativeRegionFilter? RegionFilter
        // GraphQL -> regionFilter: AzureNativeRegionFilter (input)
        [JsonProperty("regionFilter")]
        public AzureNativeRegionFilter? RegionFilter { get; set; }

        //      C# -> RelicFilter? RelicFilter
        // GraphQL -> relicFilter: RelicFilter (input)
        [JsonProperty("relicFilter")]
        public RelicFilter? RelicFilter { get; set; }

        //      C# -> SensitivityStatusFilter? SensitivityStatusFilter
        // GraphQL -> sensitivityStatusFilter: SensitivityStatusFilter (input)
        [JsonProperty("sensitivityStatusFilter")]
        public SensitivityStatusFilter? SensitivityStatusFilter { get; set; }

        //      C# -> ProtectionStatusFilter? ProtectionStatusFilter
        // GraphQL -> protectionStatusFilter: ProtectionStatusFilter (input)
        [JsonProperty("protectionStatusFilter")]
        public ProtectionStatusFilter? ProtectionStatusFilter { get; set; }

        //      C# -> AzureNativeTagFilter? TagFilter
        // GraphQL -> tagFilter: AzureNativeTagFilter (input)
        [JsonProperty("tagFilter")]
        public AzureNativeTagFilter? TagFilter { get; set; }

        //      C# -> CloudNativeDatabaseServerFilter? ServerFilter
        // GraphQL -> serverFilter: CloudNativeDatabaseServerFilter (input)
        [JsonProperty("serverFilter")]
        public CloudNativeDatabaseServerFilter? ServerFilter { get; set; }

        //      C# -> System.String? ServerId
        // GraphQL -> serverId: UUID (scalar)
        [JsonProperty("serverId")]
        public System.String? ServerId { get; set; }

        //      C# -> AzureNativeIsEligibleForSqlDatabaseDbProtectionFilter? AzureNativeIsEligibleForSqlDatabaseDbProtectionFilter
        // GraphQL -> azureNativeIsEligibleForSqlDatabaseDbProtectionFilter: AzureNativeIsEligibleForSqlDatabaseDbProtectionFilter (input)
        [JsonProperty("azureNativeIsEligibleForSqlDatabaseDbProtectionFilter")]
        public AzureNativeIsEligibleForSqlDatabaseDbProtectionFilter? AzureNativeIsEligibleForSqlDatabaseDbProtectionFilter { get; set; }

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

    } // class AzureSqlDatabaseFilters
    #endregion

} // namespace RubrikSecurityCloud.Types