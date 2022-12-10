// SetUserSessionManagementConfigInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:39.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region SetUserSessionManagementConfigInput

    public class SetUserSessionManagementConfigInput
    {
        #region members
        //      C# -> System.Boolean? IsConcurrentSessionLimitationEnabled
        // GraphQL -> isConcurrentSessionLimitationEnabled: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isConcurrentSessionLimitationEnabled")]
        public System.Boolean? IsConcurrentSessionLimitationEnabled { get; set; }

        //      C# -> System.Int64? InactivityTimeoutInSeconds
        // GraphQL -> inactivityTimeoutInSeconds: Long! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("inactivityTimeoutInSeconds")]
        public System.Int64? InactivityTimeoutInSeconds { get; set; }

        //      C# -> System.Boolean? IsInactivityTimeoutEnabled
        // GraphQL -> isInactivityTimeoutEnabled: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isInactivityTimeoutEnabled")]
        public System.Boolean? IsInactivityTimeoutEnabled { get; set; }

        //      C# -> System.Int32? MaxConcurrentSessions
        // GraphQL -> maxConcurrentSessions: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("maxConcurrentSessions")]
        public System.Int32? MaxConcurrentSessions { get; set; }

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

    } // class SetUserSessionManagementConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types