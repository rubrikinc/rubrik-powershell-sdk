// StartCyberRecoveryInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region StartCyberRecoveryInput

    public class StartCyberRecoveryInput: IInput
    {
        #region members

        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("blueprintId")]
        public System.String? BlueprintId { get; set; }

        //      C# -> System.String? RecoverySpecId
        // GraphQL -> recoverySpecId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("recoverySpecId")]
        public System.String? RecoverySpecId { get; set; }

        //      C# -> LocationType? TargetLocationType
        // GraphQL -> targetLocationType: LocationType (enum)
        [JsonProperty("targetLocationType")]
        public LocationType? TargetLocationType { get; set; }

        //      C# -> System.String? TargetLocationUuid
        // GraphQL -> targetLocationUuid: UUID (scalar)
        [JsonProperty("targetLocationUuid")]
        public System.String? TargetLocationUuid { get; set; }

        //      C# -> System.String? FailoverType
        // GraphQL -> failoverType: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("failoverType")]
        public System.String? FailoverType { get; set; }

        //      C# -> System.String? JobTriggerEmail
        // GraphQL -> jobTriggerEmail: String (scalar)
        [JsonProperty("jobTriggerEmail")]
        public System.String? JobTriggerEmail { get; set; }

        //      C# -> System.String? FailoverFailureAction
        // GraphQL -> failoverFailureAction: String (scalar)
        [JsonProperty("failoverFailureAction")]
        public System.String? FailoverFailureAction { get; set; }

        //      C# -> System.String? FailoverOperation
        // GraphQL -> failoverOperation: String (scalar)
        [JsonProperty("failoverOperation")]
        public System.String? FailoverOperation { get; set; }

        //      C# -> DataTransferType? DataTransferType
        // GraphQL -> dataTransferType: DataTransferType (enum)
        [JsonProperty("dataTransferType")]
        public DataTransferType? DataTransferType { get; set; }

        //      C# -> List<SnappableFailoverInfoType>? ChildSnappableFailoverInfos
        // GraphQL -> childSnappableFailoverInfos: [SnappableFailoverInfoType!] (input)
        [JsonProperty("childSnappableFailoverInfos")]
        public List<SnappableFailoverInfoType>? ChildSnappableFailoverInfos { get; set; }

        //      C# -> List<BlueprintFailoverIgnorableError>? FailoverIgnorableErrors
        // GraphQL -> failoverIgnorableErrors: [BlueprintFailoverIgnorableError!] (enum)
        [JsonProperty("failoverIgnorableErrors")]
        public List<BlueprintFailoverIgnorableError>? FailoverIgnorableErrors { get; set; }

        //      C# -> System.Int32? TimeoutInMinutes
        // GraphQL -> timeoutInMinutes: Int (scalar)
        [JsonProperty("timeoutInMinutes")]
        public System.Int32? TimeoutInMinutes { get; set; }

        //      C# -> System.String? RecoveryName
        // GraphQL -> recoveryName: String (scalar)
        [JsonProperty("recoveryName")]
        public System.String? RecoveryName { get; set; }

        //      C# -> System.String? FailoverId
        // GraphQL -> failoverId: UUID (scalar)
        [JsonProperty("failoverId")]
        public System.String? FailoverId { get; set; }

        //      C# -> System.String? TriggeredFrom
        // GraphQL -> triggeredFrom: String (scalar)
        [JsonProperty("triggeredFrom")]
        public System.String? TriggeredFrom { get; set; }


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

    } // class StartCyberRecoveryInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types