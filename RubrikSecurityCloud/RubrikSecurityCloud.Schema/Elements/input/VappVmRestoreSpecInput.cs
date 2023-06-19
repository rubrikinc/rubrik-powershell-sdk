// VappVmRestoreSpecInput.cs
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
    #region VappVmRestoreSpecInput

    public class VappVmRestoreSpecInput: IInput
    {
        #region members

        //      C# -> System.String? StoragePolicyId
        // GraphQL -> storagePolicyId: String (scalar)
        [JsonProperty("storagePolicyId")]
        public System.String? StoragePolicyId { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<VappVmNetworkConnectionInput>? NetworkConnections
        // GraphQL -> networkConnections: [VappVmNetworkConnectionInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("networkConnections")]
        public List<VappVmNetworkConnectionInput>? NetworkConnections { get; set; }

        //      C# -> System.String? VcdMoid
        // GraphQL -> vcdMoid: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("vcdMoid")]
        public System.String? VcdMoid { get; set; }


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

    } // class VappVmRestoreSpecInput
    #endregion

} // namespace RubrikSecurityCloud.Types