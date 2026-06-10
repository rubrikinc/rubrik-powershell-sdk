// CoordinatorLabelEntryInput.cs
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
    #region CoordinatorLabelEntryInput

    public class CoordinatorLabelEntryInput: IInput
    {
        #region members

        //      C# -> System.String? HardwareId
        // GraphQL -> hardwareId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("hardwareId")]
        public System.String? HardwareId { get; set; }

        //      C# -> List<CoordinatorLabel>? Labels
        // GraphQL -> labels: [CoordinatorLabel!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("labels")]
        public List<CoordinatorLabel>? Labels { get; set; }

        //      C# -> System.String? DeviceState
        // GraphQL -> deviceState: String (scalar)
        [JsonProperty("deviceState")]
        public System.String? DeviceState { get; set; }


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

    } // class CoordinatorLabelEntryInput
    #endregion

} // namespace RubrikSecurityCloud.Types