// OracleValidateConfigInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:34.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region OracleValidateConfigInput

    public class OracleValidateConfigInput
    {
        #region members
        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int (scalar)
        [JsonProperty("numChannels")]
        public System.Int32? NumChannels { get; set; }

        //      C# -> System.Int64? SgaMaxSizeInMb
        // GraphQL -> sgaMaxSizeInMb: Long (scalar)
        [JsonProperty("sgaMaxSizeInMb")]
        public System.Int64? SgaMaxSizeInMb { get; set; }

        //      C# -> System.String? TargetMountPath
        // GraphQL -> targetMountPath: String (scalar)
        [JsonProperty("targetMountPath")]
        public System.String? TargetMountPath { get; set; }

        //      C# -> System.String? TargetOracleHome
        // GraphQL -> targetOracleHome: String (scalar)
        [JsonProperty("targetOracleHome")]
        public System.String? TargetOracleHome { get; set; }

        //      C# -> OracleRecoveryPointInput? RecoveryPoint
        // GraphQL -> recoveryPoint: OracleRecoveryPointInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("recoveryPoint")]
        public OracleRecoveryPointInput? RecoveryPoint { get; set; }

        //      C# -> System.String? TargetOracleHostOrRacId
        // GraphQL -> targetOracleHostOrRacId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetOracleHostOrRacId")]
        public System.String? TargetOracleHostOrRacId { get; set; }

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

    } // class OracleValidateConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types