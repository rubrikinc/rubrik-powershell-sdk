// AzureNativeCommonResourceGroupFilters.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region AzureNativeCommonResourceGroupFilters

    public class AzureNativeCommonResourceGroupFilters: IInput
    {
        #region members

        //      C# -> NameSubstringFilter? NameSubstringFilter
        // GraphQL -> nameSubstringFilter: NameSubstringFilter (input)
        [JsonProperty("nameSubstringFilter")]
        public NameSubstringFilter? NameSubstringFilter { get; set; }

        //      C# -> AzureNativeCommonRgSubscriptionFilter? SubscriptionFilter
        // GraphQL -> subscriptionFilter: AzureNativeCommonRgSubscriptionFilter (input)
        [JsonProperty("subscriptionFilter")]
        public AzureNativeCommonRgSubscriptionFilter? SubscriptionFilter { get; set; }

        //      C# -> AzureNativeRegionFilter? RegionFilter
        // GraphQL -> regionFilter: AzureNativeRegionFilter (input)
        [JsonProperty("regionFilter")]
        public AzureNativeRegionFilter? RegionFilter { get; set; }

        //      C# -> AzureNativeRgSlaFilter? EffectiveSlaFilter
        // GraphQL -> effectiveSlaFilter: AzureNativeRgSlaFilter (input)
        [JsonProperty("effectiveSlaFilter")]
        public AzureNativeRgSlaFilter? EffectiveSlaFilter { get; set; }


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

    } // class AzureNativeCommonResourceGroupFilters
    #endregion

} // namespace Rubrik.SecurityCloud.Types