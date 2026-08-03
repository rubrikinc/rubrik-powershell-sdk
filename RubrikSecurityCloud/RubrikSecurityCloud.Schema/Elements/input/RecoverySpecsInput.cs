// RecoverySpecsInput.cs
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
    #region RecoverySpecsInput

    public class RecoverySpecsInput: IInput
    {
        #region members

        //      C# -> System.Boolean? GetInvalidSpecs
        // GraphQL -> getInvalidSpecs: Boolean (scalar)
        [JsonProperty("getInvalidSpecs")]
        public System.Boolean? GetInvalidSpecs { get; set; }

        //      C# -> System.String? RecoveryId
        // GraphQL -> recoveryId: String (scalar)
        [JsonProperty("recoveryId")]
        public System.String? RecoveryId { get; set; }

        //      C# -> List<RecoverySpecTypeV2>? RecoverySpecType
        // GraphQL -> recoverySpecType: [RecoverySpecTypeV2!] (enum)
        [JsonProperty("recoverySpecType")]
        public List<RecoverySpecTypeV2>? RecoverySpecType { get; set; }

        //      C# -> System.String? RecoveryPlanId
        // GraphQL -> recoveryPlanId: UUID (scalar)
        [JsonProperty("recoveryPlanId")]
        public System.String? RecoveryPlanId { get; set; }


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

    } // class RecoverySpecsInput
    #endregion

} // namespace RubrikSecurityCloud.Types