// StaticIpInfoInput.cs
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
    #region StaticIpInfoInput

    public class StaticIpInfoInput: IInput
    {
        #region members

        //      C# -> List<System.String>? DnsServers
        // GraphQL -> dnsServers: [String!] (scalar)
        [JsonProperty("dnsServers")]
        public List<System.String>? DnsServers { get; set; }

        //      C# -> System.String? Gateway
        // GraphQL -> gateway: String (scalar)
        [JsonProperty("gateway")]
        public System.String? Gateway { get; set; }

        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("ipAddresses")]
        public List<System.String>? IpAddresses { get; set; }

        //      C# -> System.String? SubnetMask
        // GraphQL -> subnetMask: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("subnetMask")]
        public System.String? SubnetMask { get; set; }


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

    } // class StaticIpInfoInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types