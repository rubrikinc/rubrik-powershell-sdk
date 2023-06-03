// VappVmNetworkConnectionInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region VappVmNetworkConnectionInput

    public class VappVmNetworkConnectionInput: IInput
    {
        #region members

        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String (scalar)
        [JsonProperty("ipAddress")]
        public System.String? IpAddress { get; set; }

        //      C# -> System.String? MacAddress
        // GraphQL -> macAddress: String (scalar)
        [JsonProperty("macAddress")]
        public System.String? MacAddress { get; set; }

        //      C# -> System.String? VappNetworkName
        // GraphQL -> vappNetworkName: String (scalar)
        [JsonProperty("vappNetworkName")]
        public System.String? VappNetworkName { get; set; }

        //      C# -> System.String? NetworkAdapterType
        // GraphQL -> networkAdapterType: String (scalar)
        [JsonProperty("networkAdapterType")]
        public System.String? NetworkAdapterType { get; set; }

        //      C# -> VappVmIpAddressingMode? AddressingMode
        // GraphQL -> addressingMode: VappVmIpAddressingMode! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("addressingMode")]
        public VappVmIpAddressingMode? AddressingMode { get; set; }

        //      C# -> System.Boolean? IsConnected
        // GraphQL -> isConnected: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isConnected")]
        public System.Boolean? IsConnected { get; set; }

        //      C# -> System.Int32? NicIndex
        // GraphQL -> nicIndex: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("nicIndex")]
        public System.Int32? NicIndex { get; set; }


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

    } // class VappVmNetworkConnectionInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types