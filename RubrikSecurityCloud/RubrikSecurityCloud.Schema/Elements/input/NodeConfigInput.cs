// NodeConfigInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:17.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region NodeConfigInput

    public class NodeConfigInput
    {
        #region members
        //      C# -> IpConfigInput? DataIpConfig
        // GraphQL -> dataIpConfig: IpConfigInput (input)
        [JsonProperty("dataIpConfig")]
        public IpConfigInput? DataIpConfig { get; set; }

        //      C# -> IpConfigInput? IpmiIpConfig
        // GraphQL -> ipmiIpConfig: IpConfigInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("ipmiIpConfig")]
        public IpConfigInput? IpmiIpConfig { get; set; }

        //      C# -> IpConfigInput? ManagementIpConfig
        // GraphQL -> managementIpConfig: IpConfigInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("managementIpConfig")]
        public IpConfigInput? ManagementIpConfig { get; set; }

        //      C# -> List<VlanIpInput>? VlanIpConfigs
        // GraphQL -> vlanIpConfigs: [VlanIpInput!] (input)
        [JsonProperty("vlanIpConfigs")]
        public List<VlanIpInput>? VlanIpConfigs { get; set; }

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

    } // class NodeConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types