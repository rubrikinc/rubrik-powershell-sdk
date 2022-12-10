// GetCompatibleMssqlInstancesV1Input.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:46.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region GetCompatibleMssqlInstancesV1Input

    public class GetCompatibleMssqlInstancesV1Input
    {
        #region members
        //      C# -> DateTime? RecoveryTime
        // GraphQL -> recoveryTime: DateTime (scalar)
        [JsonProperty("recoveryTime")]
        public DateTime? RecoveryTime { get; set; }

        //      C# -> V1GetCompatibleMssqlInstancesV1RequestRecoveryType? RecoveryType
        // GraphQL -> recoveryType: V1GetCompatibleMssqlInstancesV1RequestRecoveryType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("recoveryType")]
        public V1GetCompatibleMssqlInstancesV1RequestRecoveryType? RecoveryType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

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

    } // class GetCompatibleMssqlInstancesV1Input
    #endregion

} // namespace Rubrik.SecurityCloud.Types