// SelectorRecoverySpec.cs
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
    #region SelectorRecoverySpec

    public class SelectorRecoverySpec: IInput
    {
        #region members

        //      C# -> InplaceRecoverySpec? InplaceRecoverySpec
        // GraphQL -> inplaceRecoverySpec: InplaceRecoverySpec (input)
        [JsonProperty("inplaceRecoverySpec")]
        public InplaceRecoverySpec? InplaceRecoverySpec { get; set; }

        //      C# -> OperationalRecoverySpec? OperationalRecoverySpec
        // GraphQL -> operationalRecoverySpec: OperationalRecoverySpec (input)
        [JsonProperty("operationalRecoverySpec")]
        public OperationalRecoverySpec? OperationalRecoverySpec { get; set; }

        //      C# -> System.Int64? RecoveryPoint
        // GraphQL -> recoveryPoint: Long! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("recoveryPoint")]
        public System.Int64? RecoveryPoint { get; set; }

        //      C# -> System.String? SrcSubscriptionId
        // GraphQL -> srcSubscriptionId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("srcSubscriptionId")]
        public System.String? SrcSubscriptionId { get; set; }

        //      C# -> System.String? TargetSubscriptionId
        // GraphQL -> targetSubscriptionId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetSubscriptionId")]
        public System.String? TargetSubscriptionId { get; set; }


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

    } // class SelectorRecoverySpec
    #endregion

} // namespace RubrikSecurityCloud.Types