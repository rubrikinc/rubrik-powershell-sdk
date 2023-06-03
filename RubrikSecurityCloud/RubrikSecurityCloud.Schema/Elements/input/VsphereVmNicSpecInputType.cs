// VsphereVmNicSpecInputType.cs
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
    #region VsphereVmNicSpecInputType

    public class VsphereVmNicSpecInputType: IInput
    {
        #region members

        //      C# -> System.String? Key
        // GraphQL -> key: String (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }

        //      C# -> System.Boolean? IsPrimaryNic
        // GraphQL -> isPrimaryNic: Boolean (scalar)
        [JsonProperty("isPrimaryNic")]
        public System.Boolean? IsPrimaryNic { get; set; }

        //      C# -> NetworkType? NetworkType
        // GraphQL -> networkType: NetworkType (enum)
        [JsonProperty("networkType")]
        public NetworkType? NetworkType { get; set; }

        //      C# -> System.String? NetworkId
        // GraphQL -> networkId: String (scalar)
        [JsonProperty("networkId")]
        public System.String? NetworkId { get; set; }

        //      C# -> System.String? NetworkMoid
        // GraphQL -> networkMoid: String (scalar)
        [JsonProperty("networkMoid")]
        public System.String? NetworkMoid { get; set; }

        //      C# -> NetworkAdapterType? AdapterType
        // GraphQL -> adapterType: NetworkAdapterType (enum)
        [JsonProperty("adapterType")]
        public NetworkAdapterType? AdapterType { get; set; }

        //      C# -> System.String? Ipv4Address
        // GraphQL -> ipv4Address: String (scalar)
        [JsonProperty("ipv4Address")]
        public System.String? Ipv4Address { get; set; }

        //      C# -> System.String? Ipv6Address
        // GraphQL -> ipv6Address: String (scalar)
        [JsonProperty("ipv6Address")]
        public System.String? Ipv6Address { get; set; }

        //      C# -> List<System.String>? DnsInfos
        // GraphQL -> dnsInfos: [String!] (scalar)
        [JsonProperty("dnsInfos")]
        public List<System.String>? DnsInfos { get; set; }

        //      C# -> System.String? Gateway
        // GraphQL -> gateway: String (scalar)
        [JsonProperty("gateway")]
        public System.String? Gateway { get; set; }

        //      C# -> System.String? Netmask
        // GraphQL -> netmask: String (scalar)
        [JsonProperty("netmask")]
        public System.String? Netmask { get; set; }


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

    } // class VsphereVmNicSpecInputType
    #endregion

} // namespace Rubrik.SecurityCloud.Types