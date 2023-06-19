// AwsNativeRdsInstanceFilters.cs
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
    #region AwsNativeRdsInstanceFilters

    public class AwsNativeRdsInstanceFilters: IInput
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

        //      C# -> AwsNativeAccountFilter? AccountFilter
        // GraphQL -> accountFilter: AwsNativeAccountFilter (input)
        [JsonProperty("accountFilter")]
        public AwsNativeAccountFilter? AccountFilter { get; set; }

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

        //      C# -> AwsNativeRegionFilter? RegionFilter
        // GraphQL -> regionFilter: AwsNativeRegionFilter (input)
        [JsonProperty("regionFilter")]
        public AwsNativeRegionFilter? RegionFilter { get; set; }

        //      C# -> AwsNativeRdsDbEngineFilter? DbEngineFilter
        // GraphQL -> dbEngineFilter: AwsNativeRdsDbEngineFilter (input)
        [JsonProperty("dbEngineFilter")]
        public AwsNativeRdsDbEngineFilter? DbEngineFilter { get; set; }

        //      C# -> AwsNativeRdsDbInstanceClassFilter? DbInstanceClassFilter
        // GraphQL -> dbInstanceClassFilter: AwsNativeRdsDbInstanceClassFilter (input)
        [JsonProperty("dbInstanceClassFilter")]
        public AwsNativeRdsDbInstanceClassFilter? DbInstanceClassFilter { get; set; }

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

    } // class AwsNativeRdsInstanceFilters
    #endregion

} // namespace RubrikSecurityCloud.Types