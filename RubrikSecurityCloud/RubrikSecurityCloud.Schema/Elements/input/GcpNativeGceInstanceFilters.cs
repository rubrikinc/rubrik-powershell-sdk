// GcpNativeGceInstanceFilters.cs
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
    #region GcpNativeGceInstanceFilters

    public class GcpNativeGceInstanceFilters: IInput
    {
        #region members

        //      C# -> GcpNativeInstanceNameOrIdSubstringFilter? NameOrIdSubstringFilter
        // GraphQL -> nameOrIdSubstringFilter: GcpNativeInstanceNameOrIdSubstringFilter (input)
        [JsonProperty("nameOrIdSubstringFilter")]
        public GcpNativeInstanceNameOrIdSubstringFilter? NameOrIdSubstringFilter { get; set; }

        //      C# -> GcpNativeProjectFilter? ProjectFilter
        // GraphQL -> projectFilter: GcpNativeProjectFilter (input)
        [JsonProperty("projectFilter")]
        public GcpNativeProjectFilter? ProjectFilter { get; set; }

        //      C# -> GcpNativeRegionFilter? RegionFilter
        // GraphQL -> regionFilter: GcpNativeRegionFilter (input)
        [JsonProperty("regionFilter")]
        public GcpNativeRegionFilter? RegionFilter { get; set; }

        //      C# -> GcpNativeMachineTypeFilter? MachineTypeFilter
        // GraphQL -> machineTypeFilter: GcpNativeMachineTypeFilter (input)
        [JsonProperty("machineTypeFilter")]
        public GcpNativeMachineTypeFilter? MachineTypeFilter { get; set; }

        //      C# -> GcpNativeNetworkFilter? NetworkFilter
        // GraphQL -> networkFilter: GcpNativeNetworkFilter (input)
        [JsonProperty("networkFilter")]
        public GcpNativeNetworkFilter? NetworkFilter { get; set; }

        //      C# -> GcpNativeLabelFilter? LabelFilter
        // GraphQL -> labelFilter: GcpNativeLabelFilter (input)
        [JsonProperty("labelFilter")]
        public GcpNativeLabelFilter? LabelFilter { get; set; }

        //      C# -> EffectiveSlaFilter? EffectiveSlaFilter
        // GraphQL -> effectiveSlaFilter: EffectiveSlaFilter (input)
        [JsonProperty("effectiveSlaFilter")]
        public EffectiveSlaFilter? EffectiveSlaFilter { get; set; }

        //      C# -> RelicFilter? RelicFilter
        // GraphQL -> relicFilter: RelicFilter (input)
        [JsonProperty("relicFilter")]
        public RelicFilter? RelicFilter { get; set; }

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

    } // class GcpNativeGceInstanceFilters
    #endregion

} // namespace RubrikSecurityCloud.Types