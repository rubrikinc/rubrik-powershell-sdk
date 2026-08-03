// StartRecoveryInput.cs
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
    #region StartRecoveryInput

    public class StartRecoveryInput: IInput
    {
        #region members

        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("recoveryName")]
        public System.String? RecoveryName { get; set; }

        //      C# -> DataTransferType? DataTransferType
        // GraphQL -> dataTransferType: DataTransferType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("dataTransferType")]
        public DataTransferType? DataTransferType { get; set; }

        //      C# -> RecoveryFailureAction? RecoveryFailureAction
        // GraphQL -> recoveryFailureAction: RecoveryFailureAction! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("recoveryFailureAction")]
        public RecoveryFailureAction? RecoveryFailureAction { get; set; }

        //      C# -> RecoveryTriggeredFrom? TriggeredFrom
        // GraphQL -> triggeredFrom: RecoveryTriggeredFrom (enum)
        [JsonProperty("triggeredFrom")]
        public RecoveryTriggeredFrom? TriggeredFrom { get; set; }

        //      C# -> RecoveryPlanInfo? RecoveryPlanInfo
        // GraphQL -> recoveryPlanInfo: RecoveryPlanInfo! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("recoveryPlanInfo")]
        public RecoveryPlanInfo? RecoveryPlanInfo { get; set; }

        //      C# -> RecoverySpecInfo? RecoverySpecInfo
        // GraphQL -> recoverySpecInfo: RecoverySpecInfo! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("recoverySpecInfo")]
        public RecoverySpecInfo? RecoverySpecInfo { get; set; }


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

    } // class StartRecoveryInput
    #endregion

} // namespace RubrikSecurityCloud.Types