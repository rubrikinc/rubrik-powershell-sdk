// AwsNativeEc2InstanceFilters.cs
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
    #region AwsNativeEc2InstanceFilters

    public class AwsNativeEc2InstanceFilters: IInput
    {
        #region members

        //      C# -> AwsNativeEc2InstanceNameOrIdSubstringFilter? NameOrIdSubstringFilter
        // GraphQL -> nameOrIdSubstringFilter: AwsNativeEc2InstanceNameOrIdSubstringFilter (input)
        [JsonProperty("nameOrIdSubstringFilter")]
        public AwsNativeEc2InstanceNameOrIdSubstringFilter? NameOrIdSubstringFilter { get; set; }

        //      C# -> EffectiveSlaFilter? EffectiveSlaFilter
        // GraphQL -> effectiveSlaFilter: EffectiveSlaFilter (input)
        [JsonProperty("effectiveSlaFilter")]
        public EffectiveSlaFilter? EffectiveSlaFilter { get; set; }

        //      C# -> AwsNativeAccountFilter? AccountFilter
        // GraphQL -> accountFilter: AwsNativeAccountFilter (input)
        [JsonProperty("accountFilter")]
        public AwsNativeAccountFilter? AccountFilter { get; set; }

        //      C# -> AwsNativeEc2InstanceFileRecoveryStatusFilter? FileRecoveryStatusFilter
        // GraphQL -> fileRecoveryStatusFilter: AwsNativeEc2InstanceFileRecoveryStatusFilter (input)
        [JsonProperty("fileRecoveryStatusFilter")]
        public AwsNativeEc2InstanceFileRecoveryStatusFilter? FileRecoveryStatusFilter { get; set; }

        //      C# -> AwsNativeRegionFilter? RegionFilter
        // GraphQL -> regionFilter: AwsNativeRegionFilter (input)
        [JsonProperty("regionFilter")]
        public AwsNativeRegionFilter? RegionFilter { get; set; }

        //      C# -> UnaccessedFilter? UnaccessedFilter
        // GraphQL -> unaccessedFilter: UnaccessedFilter (input)
        [JsonProperty("unaccessedFilter")]
        public UnaccessedFilter? UnaccessedFilter { get; set; }

        //      C# -> SensitivityStatusFilter? SensitivityStatusFilter
        // GraphQL -> sensitivityStatusFilter: SensitivityStatusFilter (input)
        [JsonProperty("sensitivityStatusFilter")]
        public SensitivityStatusFilter? SensitivityStatusFilter { get; set; }

        //      C# -> ProtectionStatusFilter? ProtectionStatusFilter
        // GraphQL -> protectionStatusFilter: ProtectionStatusFilter (input)
        [JsonProperty("protectionStatusFilter")]
        public ProtectionStatusFilter? ProtectionStatusFilter { get; set; }

        //      C# -> AwsNativeEc2InstanceTypeFilter? TypeFilter
        // GraphQL -> typeFilter: AwsNativeEc2InstanceTypeFilter (input)
        [JsonProperty("typeFilter")]
        public AwsNativeEc2InstanceTypeFilter? TypeFilter { get; set; }

        //      C# -> AwsNativeVpcFilter? VpcFilter
        // GraphQL -> vpcFilter: AwsNativeVpcFilter (input)
        [JsonProperty("vpcFilter")]
        public AwsNativeVpcFilter? VpcFilter { get; set; }

        //      C# -> RelicFilter? RelicFilter
        // GraphQL -> relicFilter: RelicFilter (input)
        [JsonProperty("relicFilter")]
        public RelicFilter? RelicFilter { get; set; }

        //      C# -> AwsNativeTagFilter? TagFilter
        // GraphQL -> tagFilter: AwsNativeTagFilter (input)
        [JsonProperty("tagFilter")]
        public AwsNativeTagFilter? TagFilter { get; set; }

        //      C# -> CloudNativeInstaceAppProtectionFilter? AppProtectionStatusFilter
        // GraphQL -> appProtectionStatusFilter: CloudNativeInstaceAppProtectionFilter (input)
        [JsonProperty("appProtectionStatusFilter")]
        public CloudNativeInstaceAppProtectionFilter? AppProtectionStatusFilter { get; set; }

        //      C# -> AwsInstanceCcOrCnpRbsConnectionStatusFilter? RbsStatusFilter
        // GraphQL -> rbsStatusFilter: AwsInstanceCcOrCnpRbsConnectionStatusFilter (input)
        [JsonProperty("rbsStatusFilter")]
        public AwsInstanceCcOrCnpRbsConnectionStatusFilter? RbsStatusFilter { get; set; }

        //      C# -> OrgFilter? OrgFilter
        // GraphQL -> orgFilter: OrgFilter (input)
        [JsonProperty("orgFilter")]
        public OrgFilter? OrgFilter { get; set; }

        //      C# -> AwsNativeFeatureStatusFilter? AwsNativeFeatureStatusFilter
        // GraphQL -> awsNativeFeatureStatusFilter: AwsNativeFeatureStatusFilter (input)
        [JsonProperty("awsNativeFeatureStatusFilter")]
        public AwsNativeFeatureStatusFilter? AwsNativeFeatureStatusFilter { get; set; }

        //      C# -> AwsNativeIsEligibleForEc2ProtectionFilter? AwsNativeIsEligibleForEc2ProtectionFilter
        // GraphQL -> awsNativeIsEligibleForEc2ProtectionFilter: AwsNativeIsEligibleForEc2ProtectionFilter (input)
        [JsonProperty("awsNativeIsEligibleForEc2ProtectionFilter")]
        public AwsNativeIsEligibleForEc2ProtectionFilter? AwsNativeIsEligibleForEc2ProtectionFilter { get; set; }

        //      C# -> List<Filter>? HierarchyFilters
        // GraphQL -> hierarchyFilters: [Filter!] (input)
        [JsonProperty("hierarchyFilters")]
        public List<Filter>? HierarchyFilters { get; set; }


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

    } // class AwsNativeEc2InstanceFilters
    #endregion

} // namespace RubrikSecurityCloud.Types