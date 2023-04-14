// RestoreMssqlDbJobConfigInput.cs
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
    #region RestoreMssqlDbJobConfigInput

    public class RestoreMssqlDbJobConfigInput: IInput
    {
        #region members

        //      C# -> System.Boolean? FinishRecovery
        // GraphQL -> finishRecovery: Boolean (scalar)
        [JsonProperty("finishRecovery")]
        public System.Boolean? FinishRecovery { get; set; }

        //      C# -> System.Int32? MaxDataStreams
        // GraphQL -> maxDataStreams: Int (scalar)
        [JsonProperty("maxDataStreams")]
        public System.Int32? MaxDataStreams { get; set; }

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

    } // class RestoreMssqlDbJobConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types