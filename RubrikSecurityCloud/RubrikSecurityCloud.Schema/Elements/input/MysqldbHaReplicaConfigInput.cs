// MysqldbHaReplicaConfigInput.cs
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
    #region MysqldbHaReplicaConfigInput

    public class MysqldbHaReplicaConfigInput: IInput
    {
        #region members

        //      C# -> System.Boolean? ShouldDeleteReplica
        // GraphQL -> shouldDeleteReplica: Boolean (scalar)
        [JsonProperty("shouldDeleteReplica")]
        public System.Boolean? ShouldDeleteReplica { get; set; }

        //      C# -> MysqldbHaReplicaConfigRole? Role
        // GraphQL -> role: MysqldbHaReplicaConfigRole (enum)
        [JsonProperty("role")]
        public MysqldbHaReplicaConfigRole? Role { get; set; }

        //      C# -> System.String? ReplicaId
        // GraphQL -> replicaId: String (scalar)
        [JsonProperty("replicaId")]
        public System.String? ReplicaId { get; set; }

        //      C# -> MysqldbReplicaConnectionInfoInput? ConnectionInfo
        // GraphQL -> connectionInfo: MysqldbReplicaConnectionInfoInput (input)
        [JsonProperty("connectionInfo")]
        public MysqldbReplicaConnectionInfoInput? ConnectionInfo { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? ReplicaName
        // GraphQL -> replicaName: String (scalar)
        [JsonProperty("replicaName")]
        public System.String? ReplicaName { get; set; }


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

    } // class MysqldbHaReplicaConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types