// AzureNativeVirtualMachineFilters.cs
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
    #region AzureNativeVirtualMachineFilters

    public class AzureNativeVirtualMachineFilters: IInput
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

        //      C# -> AzureNativeVmResourceGroupFilter? ResourceGroupFilter
        // GraphQL -> resourceGroupFilter: AzureNativeVmResourceGroupFilter (input)
        [JsonProperty("resourceGroupFilter")]
        public AzureNativeVmResourceGroupFilter? ResourceGroupFilter { get; set; }

        //      C# -> AzureNativeVmSubscriptionFilter? SubscriptionFilter
        // GraphQL -> subscriptionFilter: AzureNativeVmSubscriptionFilter (input)
        [JsonProperty("subscriptionFilter")]
        public AzureNativeVmSubscriptionFilter? SubscriptionFilter { get; set; }

        //      C# -> AzureNativeRegionFilter? RegionFilter
        // GraphQL -> regionFilter: AzureNativeRegionFilter (input)
        [JsonProperty("regionFilter")]
        public AzureNativeRegionFilter? RegionFilter { get; set; }

        //      C# -> AzureNativeVmSizeFilter? VmSizeFilter
        // GraphQL -> vmSizeFilter: AzureNativeVmSizeFilter (input)
        [JsonProperty("vmSizeFilter")]
        public AzureNativeVmSizeFilter? VmSizeFilter { get; set; }

        //      C# -> AzureNativeVnetFilter? VnetFilter
        // GraphQL -> vnetFilter: AzureNativeVnetFilter (input)
        [JsonProperty("vnetFilter")]
        public AzureNativeVnetFilter? VnetFilter { get; set; }

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

        //      C# -> AzureNativeVmExocomputeConnectedFilter? ExocomputeConnectedFilter
        // GraphQL -> exocomputeConnectedFilter: AzureNativeVmExocomputeConnectedFilter (input)
        [JsonProperty("exocomputeConnectedFilter")]
        public AzureNativeVmExocomputeConnectedFilter? ExocomputeConnectedFilter { get; set; }

        //      C# -> AzureNativeVmFileIndexingFilter? FileIndexingFilter
        // GraphQL -> fileIndexingFilter: AzureNativeVmFileIndexingFilter (input)
        [JsonProperty("fileIndexingFilter")]
        public AzureNativeVmFileIndexingFilter? FileIndexingFilter { get; set; }

        //      C# -> CloudNativeInstaceAppProtectionFilter? AppProtectionStatusFilter
        // GraphQL -> appProtectionStatusFilter: CloudNativeInstaceAppProtectionFilter (input)
        [JsonProperty("appProtectionStatusFilter")]
        public CloudNativeInstaceAppProtectionFilter? AppProtectionStatusFilter { get; set; }

        //      C# -> AzureVmCcOrCnpRbsConnectionStatusFilter? RbsStatusFilter
        // GraphQL -> rbsStatusFilter: AzureVmCcOrCnpRbsConnectionStatusFilter (input)
        [JsonProperty("rbsStatusFilter")]
        public AzureVmCcOrCnpRbsConnectionStatusFilter? RbsStatusFilter { get; set; }

        //      C# -> OrgFilter? OrgFilter
        // GraphQL -> orgFilter: OrgFilter (input)
        [JsonProperty("orgFilter")]
        public OrgFilter? OrgFilter { get; set; }


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

    } // class AzureNativeVirtualMachineFilters
    #endregion

} // namespace RubrikSecurityCloud.Types