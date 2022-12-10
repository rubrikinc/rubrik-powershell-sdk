// ReplicationTargetDefinitionInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:20.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region ReplicationTargetDefinitionInput

    public class ReplicationTargetDefinitionInput
    {
        #region members
        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String (scalar)
        [JsonProperty("caCerts")]
        public System.String? CaCerts { get; set; }

        //      C# -> System.String? Realm
        // GraphQL -> realm: String (scalar)
        [JsonProperty("realm")]
        public System.String? Realm { get; set; }

        //      C# -> GatewayInfoInput? SourceGateway
        // GraphQL -> sourceGateway: GatewayInfoInput (input)
        [JsonProperty("sourceGateway")]
        public GatewayInfoInput? SourceGateway { get; set; }

        //      C# -> System.String? TargetClusterAddress
        // GraphQL -> targetClusterAddress: String (scalar)
        [JsonProperty("targetClusterAddress")]
        public System.String? TargetClusterAddress { get; set; }

        //      C# -> GatewayInfoInput? TargetGateway
        // GraphQL -> targetGateway: GatewayInfoInput (input)
        [JsonProperty("targetGateway")]
        public GatewayInfoInput? TargetGateway { get; set; }

        //      C# -> System.String? Password
        // GraphQL -> password: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("password")]
        public System.String? Password { get; set; }

        //      C# -> System.String? ReplicationSetup
        // GraphQL -> replicationSetup: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("replicationSetup")]
        public System.String? ReplicationSetup { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("username")]
        public System.String? Username { get; set; }

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

    } // class ReplicationTargetDefinitionInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types