// PitRestoreEntityInputInput.cs
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
    #region PitRestoreEntityInputInput

    public class PitRestoreEntityInputInput: IInput
    {
        #region members

        //      C# -> DateTime? RecoveryTime
        // GraphQL -> recoveryTime: DateTime (scalar)
        [JsonProperty("recoveryTime")]
        public DateTime? RecoveryTime { get; set; }

        //      C# -> System.Int64? ExtendedRecoveryTimeInSec
        // GraphQL -> extendedRecoveryTimeInSec: Long (scalar)
        [JsonProperty("extendedRecoveryTimeInSec")]
        public System.Int64? ExtendedRecoveryTimeInSec { get; set; }

        //      C# -> List<HostRecoveryTargetInput>? HostRecoveryTargets
        // GraphQL -> hostRecoveryTargets: [HostRecoveryTargetInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("hostRecoveryTargets")]
        public List<HostRecoveryTargetInput>? HostRecoveryTargets { get; set; }


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

    } // class PitRestoreEntityInputInput
    #endregion

} // namespace RubrikSecurityCloud.Types