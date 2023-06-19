// VlanConfigInput.cs
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
    #region VlanConfigInput

    public class VlanConfigInput: IInput
    {
        #region members

        //      C# -> List<NodeIpInput>? Interfaces
        // GraphQL -> interfaces: [NodeIpInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("interfaces")]
        public List<NodeIpInput>? Interfaces { get; set; }

        //      C# -> System.String? Netmask
        // GraphQL -> netmask: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("netmask")]
        public System.String? Netmask { get; set; }

        //      C# -> System.Int32? Vlan
        // GraphQL -> vlan: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("vlan")]
        public System.Int32? Vlan { get; set; }


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

    } // class VlanConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types