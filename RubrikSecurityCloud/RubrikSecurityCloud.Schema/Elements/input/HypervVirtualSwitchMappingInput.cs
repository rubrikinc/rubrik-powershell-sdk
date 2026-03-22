// HypervVirtualSwitchMappingInput.cs
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
    #region HypervVirtualSwitchMappingInput

    public class HypervVirtualSwitchMappingInput: IInput
    {
        #region members

        //      C# -> System.String? MacAddress
        // GraphQL -> macAddress: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("macAddress")]
        public System.String? MacAddress { get; set; }

        //      C# -> System.String? SwitchId
        // GraphQL -> switchId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("switchId")]
        public System.String? SwitchId { get; set; }

        //      C# -> System.String? AdapterName
        // GraphQL -> adapterName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("adapterName")]
        public System.String? AdapterName { get; set; }


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

    } // class HypervVirtualSwitchMappingInput
    #endregion

} // namespace RubrikSecurityCloud.Types