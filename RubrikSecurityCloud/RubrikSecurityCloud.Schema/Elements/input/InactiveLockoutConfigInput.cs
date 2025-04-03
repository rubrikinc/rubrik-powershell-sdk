// InactiveLockoutConfigInput.cs
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
    #region InactiveLockoutConfigInput

    public class InactiveLockoutConfigInput: IInput
    {
        #region members

        //      C# -> System.Boolean? IsInactiveLockoutEnabled
        // GraphQL -> isInactiveLockoutEnabled: Boolean (scalar)
        [JsonProperty("isInactiveLockoutEnabled")]
        public System.Boolean? IsInactiveLockoutEnabled { get; set; }

        //      C# -> System.Int32? InactivityDaysLimit
        // GraphQL -> inactivityDaysLimit: Int (scalar)
        [JsonProperty("inactivityDaysLimit")]
        public System.Int32? InactivityDaysLimit { get; set; }

        //      C# -> System.Boolean? IsWarningEmailEnabled
        // GraphQL -> isWarningEmailEnabled: Boolean (scalar)
        [JsonProperty("isWarningEmailEnabled")]
        public System.Boolean? IsWarningEmailEnabled { get; set; }

        //      C# -> System.Int32? NumDaysBeforeWarningEmail
        // GraphQL -> numDaysBeforeWarningEmail: Int (scalar)
        [JsonProperty("numDaysBeforeWarningEmail")]
        public System.Int32? NumDaysBeforeWarningEmail { get; set; }

        //      C# -> System.Boolean? IsSelfServiceUnlockEnabled
        // GraphQL -> isSelfServiceUnlockEnabled: Boolean (scalar)
        [JsonProperty("isSelfServiceUnlockEnabled")]
        public System.Boolean? IsSelfServiceUnlockEnabled { get; set; }


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

    } // class InactiveLockoutConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types