// GcpNativeProjectFilters.cs
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
    #region GcpNativeProjectFilters

    public class GcpNativeProjectFilters
    {
        #region members
        //      C# -> GcpNativeProjectNameOrNumberSubstringFilter? NameOrNumberSubstringFilter
        // GraphQL -> nameOrNumberSubstringFilter: GcpNativeProjectNameOrNumberSubstringFilter (input)
        [JsonProperty("nameOrNumberSubstringFilter")]
        public GcpNativeProjectNameOrNumberSubstringFilter? NameOrNumberSubstringFilter { get; set; }

        //      C# -> GcpNativeProjectIdSubstringFilter? IdSubstringFilter
        // GraphQL -> idSubstringFilter: GcpNativeProjectIdSubstringFilter (input)
        [JsonProperty("idSubstringFilter")]
        public GcpNativeProjectIdSubstringFilter? IdSubstringFilter { get; set; }

        //      C# -> EffectiveSlaFilter? EffectiveSlaFilter
        // GraphQL -> effectiveSlaFilter: EffectiveSlaFilter (input)
        [JsonProperty("effectiveSlaFilter")]
        public EffectiveSlaFilter? EffectiveSlaFilter { get; set; }

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

    } // class GcpNativeProjectFilters
    #endregion

} // namespace Rubrik.SecurityCloud.Types