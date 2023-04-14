// RestoreOracleLogsConfigInput.cs
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
    #region RestoreOracleLogsConfigInput

    public class RestoreOracleLogsConfigInput: IInput
    {
        #region members

        //      C# -> System.String? TargetMountPath
        // GraphQL -> targetMountPath: String (scalar)
        [JsonProperty("targetMountPath")]
        public System.String? TargetMountPath { get; set; }

        //      C# -> OracleLogRecoveryRangeInput? OracleLogRecoveryRange
        // GraphQL -> oracleLogRecoveryRange: OracleLogRecoveryRangeInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("oracleLogRecoveryRange")]
        public OracleLogRecoveryRangeInput? OracleLogRecoveryRange { get; set; }

        //      C# -> System.Boolean? ShouldMountFilesOnly
        // GraphQL -> shouldMountFilesOnly: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldMountFilesOnly")]
        public System.Boolean? ShouldMountFilesOnly { get; set; }

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

    } // class RestoreOracleLogsConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types