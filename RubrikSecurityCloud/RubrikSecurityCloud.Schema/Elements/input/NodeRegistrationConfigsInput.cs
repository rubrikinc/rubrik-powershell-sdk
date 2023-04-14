// NodeRegistrationConfigsInput.cs
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
    #region NodeRegistrationConfigsInput

    public class NodeRegistrationConfigsInput: IInput
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? ManufactureTime
        // GraphQL -> manufactureTime: DateTime (scalar)
        [JsonProperty("manufactureTime")]
        public DateTime? ManufactureTime { get; set; }

        //      C# -> System.String? Serial
        // GraphQL -> serial: String (scalar)
        [JsonProperty("serial")]
        public System.String? Serial { get; set; }

        //      C# -> System.String? SystemUuid
        // GraphQL -> systemUuid: String (scalar)
        [JsonProperty("systemUuid")]
        public System.String? SystemUuid { get; set; }

        //      C# -> System.String? TeleportToken
        // GraphQL -> teleportToken: String (scalar)
        [JsonProperty("teleportToken")]
        public System.String? TeleportToken { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Platform
        // GraphQL -> platform: String (scalar)
        [JsonProperty("platform")]
        public System.String? Platform { get; set; }

        //      C# -> System.String? Capacity
        // GraphQL -> capacity: String (scalar)
        [JsonProperty("capacity")]
        public System.String? Capacity { get; set; }

        //      C# -> System.Boolean? IsEntitled
        // GraphQL -> isEntitled: Boolean (scalar)
        [JsonProperty("isEntitled")]
        public System.Boolean? IsEntitled { get; set; }


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

    } // class NodeRegistrationConfigsInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types