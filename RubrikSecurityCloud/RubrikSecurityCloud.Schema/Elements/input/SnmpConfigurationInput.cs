// SnmpConfigurationInput.cs
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
    #region SnmpConfigurationInput

    public class SnmpConfigurationInput: IInput
    {
        #region members

        //      C# -> System.String? CommunityString
        // GraphQL -> communityString: String (scalar)
        [JsonProperty("communityString")]
        public System.String? CommunityString { get; set; }

        //      C# -> List<System.String>? Users
        // GraphQL -> users: [String!] (scalar)
        [JsonProperty("users")]
        public List<System.String>? Users { get; set; }

        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isEnabled")]
        public System.Boolean? IsEnabled { get; set; }

        //      C# -> System.Int32? SnmpAgentPort
        // GraphQL -> snmpAgentPort: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snmpAgentPort")]
        public System.Int32? SnmpAgentPort { get; set; }

        //      C# -> List<SnmpTrapReceiverConfigInput>? TrapReceiverConfigs
        // GraphQL -> trapReceiverConfigs: [SnmpTrapReceiverConfigInput!] (input)
        [JsonProperty("trapReceiverConfigs")]
        public List<SnmpTrapReceiverConfigInput>? TrapReceiverConfigs { get; set; }


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

    } // class SnmpConfigurationInput
    #endregion

} // namespace RubrikSecurityCloud.Types