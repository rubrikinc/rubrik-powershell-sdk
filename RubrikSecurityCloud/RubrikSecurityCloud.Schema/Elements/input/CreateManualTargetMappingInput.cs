// CreateManualTargetMappingInput.cs
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
    #region CreateManualTargetMappingInput

    public class CreateManualTargetMappingInput: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> TargetType? Type
        // GraphQL -> type: TargetType (enum)
        [JsonProperty("type")]
        public TargetType? Type { get; set; }

        //      C# -> List<TargetToClusterMapping>? ArchivalLocationClusterMappings
        // GraphQL -> archivalLocationClusterMappings: [TargetToClusterMapping!] (input)
        [JsonProperty("archivalLocationClusterMappings")]
        public List<TargetToClusterMapping>? ArchivalLocationClusterMappings { get; set; }


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

    } // class CreateManualTargetMappingInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types