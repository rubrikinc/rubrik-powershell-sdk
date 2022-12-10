// SetMfaSettingInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:38.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region SetMfaSettingInput

    public class SetMfaSettingInput
    {
        #region members
        //      C# -> System.Boolean? IsTotpEnforcedGlobal
        // GraphQL -> isTotpEnforcedGlobal: Boolean (scalar)
        [JsonProperty("isTotpEnforcedGlobal")]
        public System.Boolean? IsTotpEnforcedGlobal { get; set; }

        //      C# -> System.Int32? TotpReminderHours
        // GraphQL -> totpReminderHours: Int (scalar)
        [JsonProperty("totpReminderHours")]
        public System.Int32? TotpReminderHours { get; set; }

        //      C# -> System.Int32? MfaRememberHours
        // GraphQL -> mfaRememberHours: Int (scalar)
        [JsonProperty("mfaRememberHours")]
        public System.Int32? MfaRememberHours { get; set; }

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

    } // class SetMfaSettingInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types