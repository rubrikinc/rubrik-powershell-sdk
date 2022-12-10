// GcpNativeDiskFilters.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:34.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region GcpNativeDiskFilters

    public class GcpNativeDiskFilters
    {
        #region members
        //      C# -> GcpNativeDiskNameOrIdSubstringFilter? NameOrIdSubstringFilter
        // GraphQL -> nameOrIdSubstringFilter: GcpNativeDiskNameOrIdSubstringFilter (input)
        [JsonProperty("nameOrIdSubstringFilter")]
        public GcpNativeDiskNameOrIdSubstringFilter? NameOrIdSubstringFilter { get; set; }

        //      C# -> EffectiveSlaFilter? EffectiveSlaFilter
        // GraphQL -> effectiveSlaFilter: EffectiveSlaFilter (input)
        [JsonProperty("effectiveSlaFilter")]
        public EffectiveSlaFilter? EffectiveSlaFilter { get; set; }

        //      C# -> GcpNativeDiskProjectFilter? ProjectFilter
        // GraphQL -> projectFilter: GcpNativeDiskProjectFilter (input)
        [JsonProperty("projectFilter")]
        public GcpNativeDiskProjectFilter? ProjectFilter { get; set; }

        //      C# -> GcpNativeDiskLocationFilter? LocationFilter
        // GraphQL -> locationFilter: GcpNativeDiskLocationFilter (input)
        [JsonProperty("locationFilter")]
        public GcpNativeDiskLocationFilter? LocationFilter { get; set; }

        //      C# -> GcpNativeDiskTypeFilter? DiskTypeFilter
        // GraphQL -> diskTypeFilter: GcpNativeDiskTypeFilter (input)
        [JsonProperty("diskTypeFilter")]
        public GcpNativeDiskTypeFilter? DiskTypeFilter { get; set; }

        //      C# -> RelicFilter? RelicFilter
        // GraphQL -> relicFilter: RelicFilter (input)
        [JsonProperty("relicFilter")]
        public RelicFilter? RelicFilter { get; set; }

        //      C# -> GcpNativeLabelFilter? LabelFilter
        // GraphQL -> labelFilter: GcpNativeLabelFilter (input)
        [JsonProperty("labelFilter")]
        public GcpNativeLabelFilter? LabelFilter { get; set; }

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

    } // class GcpNativeDiskFilters
    #endregion

} // namespace Rubrik.SecurityCloud.Types