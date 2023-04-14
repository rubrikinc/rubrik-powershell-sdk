// CreateK8sClusterInput.cs
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
    #region CreateK8sClusterInput

    public class CreateK8sClusterInput: IInput
    {
        #region members

        //      C# -> System.String? CdmClusterId
        // GraphQL -> cdmClusterId: UUID (scalar)
        [JsonProperty("cdmClusterId")]
        public System.String? CdmClusterId { get; set; }

        //      C# -> List<System.String>? HostList
        // GraphQL -> hostList: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("hostList")]
        public List<System.String>? HostList { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("port")]
        public System.Int32? Port { get; set; }

        //      C# -> List<PortRange>? RbsPortRanges
        // GraphQL -> rbsPortRanges: [PortRange!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("rbsPortRanges")]
        public List<PortRange>? RbsPortRanges { get; set; }

        //      C# -> List<PortRange>? UserDrivenPortRanges
        // GraphQL -> userDrivenPortRanges: [PortRange!] (input)
        [JsonProperty("userDrivenPortRanges")]
        public List<PortRange>? UserDrivenPortRanges { get; set; }

        //      C# -> K8sClusterProtoType? Type
        // GraphQL -> type: K8sClusterProtoType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("type")]
        public K8sClusterProtoType? Type { get; set; }

        //      C# -> System.String? ProxyUrl
        // GraphQL -> proxyUrl: String (scalar)
        [JsonProperty("proxyUrl")]
        public System.String? ProxyUrl { get; set; }


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

    } // class CreateK8sClusterInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types