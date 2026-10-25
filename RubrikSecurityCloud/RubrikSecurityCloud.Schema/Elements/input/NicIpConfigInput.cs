// NicIpConfigInput.cs
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
    #region NicIpConfigInput

    public class NicIpConfigInput: IInput
    {
        #region members

        //      C# -> IpAllocationMethod? Method
        // GraphQL -> method: IpAllocationMethod (enum)
        [JsonProperty("method")]
        public IpAllocationMethod? Method { get; set; }

        //      C# -> System.String? Ipv4Address
        // GraphQL -> ipv4Address: String (scalar)
        [JsonProperty("ipv4Address")]
        public System.String? Ipv4Address { get; set; }

        //      C# -> System.String? SubnetMask
        // GraphQL -> subnetMask: String (scalar)
        [JsonProperty("subnetMask")]
        public System.String? SubnetMask { get; set; }

        //      C# -> System.String? Gateway
        // GraphQL -> gateway: String (scalar)
        [JsonProperty("gateway")]
        public System.String? Gateway { get; set; }

        //      C# -> List<System.String>? DnsServers
        // GraphQL -> dnsServers: [String!] (scalar)
        [JsonProperty("dnsServers")]
        public List<System.String>? DnsServers { get; set; }


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

    } // class NicIpConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types