// Filter.cs
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
    #region Filter

    public class Filter: IInput
    {
        #region members

        //      C# -> HierarchyFilterField? Field
        // GraphQL -> field: HierarchyFilterField (enum)
        [JsonProperty("field")]
        public HierarchyFilterField? Field { get; set; }

        //      C# -> List<System.String>? Texts
        // GraphQL -> texts: [String!] (scalar)
        [JsonProperty("texts")]
        public List<System.String>? Texts { get; set; }

        //      C# -> List<TagFilterParams>? TagFilterParams
        // GraphQL -> tagFilterParams: [TagFilterParams!] (input)
        [JsonProperty("tagFilterParams")]
        public List<TagFilterParams>? TagFilterParams { get; set; }

        //      C# -> List<ManagedObjectType>? ObjectTypeFilterParams
        // GraphQL -> objectTypeFilterParams: [ManagedObjectType!] (enum)
        [JsonProperty("objectTypeFilterParams")]
        public List<ManagedObjectType>? ObjectTypeFilterParams { get; set; }

        //      C# -> List<AwsNativeProtectionFeature>? AwsNativeProtectionFeatureNames
        // GraphQL -> awsNativeProtectionFeatureNames: [AwsNativeProtectionFeature!] (enum)
        [JsonProperty("awsNativeProtectionFeatureNames")]
        public List<AwsNativeProtectionFeature>? AwsNativeProtectionFeatureNames { get; set; }

        //      C# -> System.Boolean? IsNegative
        // GraphQL -> isNegative: Boolean (scalar)
        [JsonProperty("isNegative")]
        public System.Boolean? IsNegative { get; set; }

        //      C# -> System.Boolean? IsSlowSearchEnabled
        // GraphQL -> isSlowSearchEnabled: Boolean (scalar)
        [JsonProperty("isSlowSearchEnabled")]
        public System.Boolean? IsSlowSearchEnabled { get; set; }

        //      C# -> List<AzureNativeProtectionFeature>? AzureNativeProtectionFeatureNames
        // GraphQL -> azureNativeProtectionFeatureNames: [AzureNativeProtectionFeature!] (enum)
        [JsonProperty("azureNativeProtectionFeatureNames")]
        public List<AzureNativeProtectionFeature>? AzureNativeProtectionFeatureNames { get; set; }

        //      C# -> List<UnmanagedObjectAvailabilityFilter>? UnmanagedObjectAvailabilityFilter
        // GraphQL -> unmanagedObjectAvailabilityFilter: [UnmanagedObjectAvailabilityFilter!] (enum)
        [JsonProperty("unmanagedObjectAvailabilityFilter")]
        public List<UnmanagedObjectAvailabilityFilter>? UnmanagedObjectAvailabilityFilter { get; set; }


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

    } // class Filter
    #endregion

} // namespace Rubrik.SecurityCloud.Types