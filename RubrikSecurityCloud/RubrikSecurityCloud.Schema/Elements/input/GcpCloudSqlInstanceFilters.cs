// GcpCloudSqlInstanceFilters.cs
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
    #region GcpCloudSqlInstanceFilters

    public class GcpCloudSqlInstanceFilters: IInput
    {
        #region members

        //      C# -> GcpCloudSqlInstanceNameOrIdSubstringFilter? NameOrIdSubstringFilter
        // GraphQL -> nameOrIdSubstringFilter: GcpCloudSqlInstanceNameOrIdSubstringFilter (input)
        [JsonProperty("nameOrIdSubstringFilter")]
        public GcpCloudSqlInstanceNameOrIdSubstringFilter? NameOrIdSubstringFilter { get; set; }

        //      C# -> EffectiveSlaFilter? EffectiveSlaFilter
        // GraphQL -> effectiveSlaFilter: EffectiveSlaFilter (input)
        [JsonProperty("effectiveSlaFilter")]
        public EffectiveSlaFilter? EffectiveSlaFilter { get; set; }

        //      C# -> GcpCloudSqlInstanceProjectFilter? ProjectFilter
        // GraphQL -> projectFilter: GcpCloudSqlInstanceProjectFilter (input)
        [JsonProperty("projectFilter")]
        public GcpCloudSqlInstanceProjectFilter? ProjectFilter { get; set; }

        //      C# -> RelicFilter? RelicFilter
        // GraphQL -> relicFilter: RelicFilter (input)
        [JsonProperty("relicFilter")]
        public RelicFilter? RelicFilter { get; set; }


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

    } // class GcpCloudSqlInstanceFilters
    #endregion

} // namespace RubrikSecurityCloud.Types