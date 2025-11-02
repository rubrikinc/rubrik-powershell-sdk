// SnmpTrapReceiverConfigInput.cs
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
    #region SnmpTrapReceiverConfigInput

    public class SnmpTrapReceiverConfigInput: IInput
    {
        #region members

        //      C# -> System.String? Address
        // GraphQL -> address: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("address")]
        public System.String? Address { get; set; }

        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("port")]
        public System.Int32? Port { get; set; }

        //      C# -> SnmpSecurityLevel? SecurityLevel
        // GraphQL -> securityLevel: SnmpSecurityLevel (enum)
        [JsonProperty("securityLevel")]
        public SnmpSecurityLevel? SecurityLevel { get; set; }

        //      C# -> System.String? User
        // GraphQL -> user: String (scalar)
        [JsonProperty("user")]
        public System.String? User { get; set; }


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

    } // class SnmpTrapReceiverConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types