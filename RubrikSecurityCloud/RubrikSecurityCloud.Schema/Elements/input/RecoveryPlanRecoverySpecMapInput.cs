// RecoveryPlanRecoverySpecMapInput.cs
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
    #region RecoveryPlanRecoverySpecMapInput

    public class RecoveryPlanRecoverySpecMapInput: IInput
    {
        #region members

        //      C# -> RecoveryType? RecoveryType
        // GraphQL -> recoveryType: RecoveryType (enum)
        [JsonProperty("recoveryType")]
        public RecoveryType? RecoveryType { get; set; }

        //      C# -> RecoveryPlanLocationInput? TargetLocationInfo
        // GraphQL -> targetLocationInfo: RecoveryPlanLocationInput (input)
        [JsonProperty("targetLocationInfo")]
        public RecoveryPlanLocationInput? TargetLocationInfo { get; set; }

        //      C# -> System.String? UserData
        // GraphQL -> userData: String (scalar)
        [JsonProperty("userData")]
        public System.String? UserData { get; set; }

        //      C# -> List<ChildRecoverySpecMapV2Input>? ChildRecoverySpecs
        // GraphQL -> childRecoverySpecs: [ChildRecoverySpecMapV2Input!] (input)
        [JsonProperty("childRecoverySpecs")]
        public List<ChildRecoverySpecMapV2Input>? ChildRecoverySpecs { get; set; }

        //      C# -> RecoverySpecTypeV2? RecoverySpecType
        // GraphQL -> recoverySpecType: RecoverySpecTypeV2 (enum)
        [JsonProperty("recoverySpecType")]
        public RecoverySpecTypeV2? RecoverySpecType { get; set; }

        //      C# -> System.String? RecoveryId
        // GraphQL -> recoveryId: String (scalar)
        [JsonProperty("recoveryId")]
        public System.String? RecoveryId { get; set; }

        //      C# -> RecoveryPlanLocationInput? SourceLocationInfo
        // GraphQL -> sourceLocationInfo: RecoveryPlanLocationInput (input)
        [JsonProperty("sourceLocationInfo")]
        public RecoveryPlanLocationInput? SourceLocationInfo { get; set; }

        //      C# -> List<System.Int64>? PauseBetweenPriorityGroups
        // GraphQL -> pauseBetweenPriorityGroups: [Long!] (scalar)
        [JsonProperty("pauseBetweenPriorityGroups")]
        public List<System.Int64>? PauseBetweenPriorityGroups { get; set; }

        //      C# -> RecoverySpecConfigInput? Config
        // GraphQL -> config: RecoverySpecConfigInput (input)
        [JsonProperty("config")]
        public RecoverySpecConfigInput? Config { get; set; }


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

    } // class RecoveryPlanRecoverySpecMapInput
    #endregion

} // namespace RubrikSecurityCloud.Types