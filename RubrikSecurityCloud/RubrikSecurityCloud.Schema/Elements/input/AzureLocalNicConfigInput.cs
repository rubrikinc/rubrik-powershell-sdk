// AzureLocalNicConfigInput.cs
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
    #region AzureLocalNicConfigInput

    public class AzureLocalNicConfigInput: IInput
    {
        #region members

        //      C# -> System.Int32? SourceNicIndex
        // GraphQL -> sourceNicIndex: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceNicIndex")]
        public System.Int32? SourceNicIndex { get; set; }

        //      C# -> System.String? LogicalNetworkId
        // GraphQL -> logicalNetworkId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("logicalNetworkId")]
        public System.String? LogicalNetworkId { get; set; }

        //      C# -> AzureLocalIpv4Type? Ipv4Type
        // GraphQL -> ipv4Type: AzureLocalIpv4Type! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("ipv4Type")]
        public AzureLocalIpv4Type? Ipv4Type { get; set; }

        //      C# -> AzureLocalIpAllocationMethod? IpAllocationMethod
        // GraphQL -> ipAllocationMethod: AzureLocalIpAllocationMethod (enum)
        [JsonProperty("ipAllocationMethod")]
        public AzureLocalIpAllocationMethod? IpAllocationMethod { get; set; }

        //      C# -> System.String? StaticIpAddress
        // GraphQL -> staticIpAddress: String (scalar)
        [JsonProperty("staticIpAddress")]
        public System.String? StaticIpAddress { get; set; }


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

    } // class AzureLocalNicConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types