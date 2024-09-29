// AwsNativeEbsVolumeFilters.cs
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
    #region AwsNativeEbsVolumeFilters

    public class AwsNativeEbsVolumeFilters: IInput
    {
        #region members

        //      C# -> AwsNativeEbsVolumeNameOrIdSubstringFilter? NameOrIdSubstringFilter
        // GraphQL -> nameOrIdSubstringFilter: AwsNativeEbsVolumeNameOrIdSubstringFilter (input)
        [JsonProperty("nameOrIdSubstringFilter")]
        public AwsNativeEbsVolumeNameOrIdSubstringFilter? NameOrIdSubstringFilter { get; set; }

        //      C# -> AwsNativeEbsVolumeFileRecoveryStatusFilter? FileRecoveryStatusFilter
        // GraphQL -> fileRecoveryStatusFilter: AwsNativeEbsVolumeFileRecoveryStatusFilter (input)
        [JsonProperty("fileRecoveryStatusFilter")]
        public AwsNativeEbsVolumeFileRecoveryStatusFilter? FileRecoveryStatusFilter { get; set; }

        //      C# -> AwsNativeEbsVolumeTypeFilter? TypeFilter
        // GraphQL -> typeFilter: AwsNativeEbsVolumeTypeFilter (input)
        [JsonProperty("typeFilter")]
        public AwsNativeEbsVolumeTypeFilter? TypeFilter { get; set; }

        //      C# -> AwsNativeAttachedInstanceFilter? AttachedInstanceFilter
        // GraphQL -> attachedInstanceFilter: AwsNativeAttachedInstanceFilter (input)
        [JsonProperty("attachedInstanceFilter")]
        public AwsNativeAttachedInstanceFilter? AttachedInstanceFilter { get; set; }

        //      C# -> EffectiveSlaFilter? EffectiveSlaFilter
        // GraphQL -> effectiveSlaFilter: EffectiveSlaFilter (input)
        [JsonProperty("effectiveSlaFilter")]
        public EffectiveSlaFilter? EffectiveSlaFilter { get; set; }

        //      C# -> AwsNativeAccountFilter? AccountFilter
        // GraphQL -> accountFilter: AwsNativeAccountFilter (input)
        [JsonProperty("accountFilter")]
        public AwsNativeAccountFilter? AccountFilter { get; set; }

        //      C# -> AwsNativeRegionFilter? RegionFilter
        // GraphQL -> regionFilter: AwsNativeRegionFilter (input)
        [JsonProperty("regionFilter")]
        public AwsNativeRegionFilter? RegionFilter { get; set; }

        //      C# -> RelicFilter? RelicFilter
        // GraphQL -> relicFilter: RelicFilter (input)
        [JsonProperty("relicFilter")]
        public RelicFilter? RelicFilter { get; set; }

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

        //      C# -> AwsNativeTagFilter? TagFilter
        // GraphQL -> tagFilter: AwsNativeTagFilter (input)
        [JsonProperty("tagFilter")]
        public AwsNativeTagFilter? TagFilter { get; set; }

        //      C# -> OrgFilter? OrgFilter
        // GraphQL -> orgFilter: OrgFilter (input)
        [JsonProperty("orgFilter")]
        public OrgFilter? OrgFilter { get; set; }

        //      C# -> AwsNativeFeatureStatusFilter? AwsNativeFeatureStatusFilter
        // GraphQL -> awsNativeFeatureStatusFilter: AwsNativeFeatureStatusFilter (input)
        [JsonProperty("awsNativeFeatureStatusFilter")]
        public AwsNativeFeatureStatusFilter? AwsNativeFeatureStatusFilter { get; set; }


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

    } // class AwsNativeEbsVolumeFilters
    #endregion

} // namespace RubrikSecurityCloud.Types