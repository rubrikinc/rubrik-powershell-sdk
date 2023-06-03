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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region SelectorRecoverySpec

    public class SelectorRecoverySpec: IInput
    {
        #region members

        //      C# -> System.String? SrcSubscriptionName
        // GraphQL -> srcSubscriptionName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("srcSubscriptionName")]
        public System.String? SrcSubscriptionName { get; set; }

        //      C# -> System.String? TargetSubscriptionName
        // GraphQL -> targetSubscriptionName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetSubscriptionName")]
        public System.String? TargetSubscriptionName { get; set; }

        //      C# -> System.Int64? RecoveryPoint
        // GraphQL -> recoveryPoint: Long! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("recoveryPoint")]
        public System.Int64? RecoveryPoint { get; set; }


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

} // namespace Rubrik.SecurityCloud.Types