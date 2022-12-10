// MountMssqlDbConfigInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:30.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region MountMssqlDbConfigInput

    public class MountMssqlDbConfigInput
    {
        #region members
        //      C# -> System.String? TargetInstanceId
        // GraphQL -> targetInstanceId: String (scalar)
        [JsonProperty("targetInstanceId")]
        public System.String? TargetInstanceId { get; set; }

        //      C# -> MssqlDatabaseRecoveryModel? RecoveryModel
        // GraphQL -> recoveryModel: MssqlDatabaseRecoveryModel (enum)
        [JsonProperty("recoveryModel")]
        public MssqlDatabaseRecoveryModel? RecoveryModel { get; set; }

        //      C# -> System.String? MountedDatabaseName
        // GraphQL -> mountedDatabaseName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("mountedDatabaseName")]
        public System.String? MountedDatabaseName { get; set; }

        //      C# -> MssqlRecoveryPointInput? RecoveryPoint
        // GraphQL -> recoveryPoint: MssqlRecoveryPointInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("recoveryPoint")]
        public MssqlRecoveryPointInput? RecoveryPoint { get; set; }

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

    } // class MountMssqlDbConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types