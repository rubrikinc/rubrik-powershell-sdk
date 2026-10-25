// HypervAzureLocalNicSpecInput.cs
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
    #region HypervAzureLocalNicSpecInput

    public class HypervAzureLocalNicSpecInput: IInput
    {
        #region members

        //      C# -> System.String? NicInstanceId
        // GraphQL -> nicInstanceId: String (scalar)
        [JsonProperty("nicInstanceId")]
        public System.String? NicInstanceId { get; set; }

        //      C# -> System.Int32? SourceNicIndex
        // GraphQL -> sourceNicIndex: Int (scalar)
        [JsonProperty("sourceNicIndex")]
        public System.Int32? SourceNicIndex { get; set; }

        //      C# -> System.String? LogicalNetworkId
        // GraphQL -> logicalNetworkId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("logicalNetworkId")]
        public System.String? LogicalNetworkId { get; set; }

        //      C# -> NicIpConfigInput? IpConfig
        // GraphQL -> ipConfig: NicIpConfigInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("ipConfig")]
        public NicIpConfigInput? IpConfig { get; set; }


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

    } // class HypervAzureLocalNicSpecInput
    #endregion

} // namespace RubrikSecurityCloud.Types