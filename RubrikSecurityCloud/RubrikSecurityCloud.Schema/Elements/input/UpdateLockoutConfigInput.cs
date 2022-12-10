// UpdateLockoutConfigInput.cs
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
    #region UpdateLockoutConfigInput

    public class UpdateLockoutConfigInput
    {
        #region members
        //      C# -> System.Int32? LoginAttemptsLimit
        // GraphQL -> loginAttemptsLimit: Int (scalar)
        [JsonProperty("loginAttemptsLimit")]
        public System.Int32? LoginAttemptsLimit { get; set; }

        //      C# -> System.Int32? SelfServiceTokenValidityInMins
        // GraphQL -> selfServiceTokenValidityInMins: Int (scalar)
        [JsonProperty("selfServiceTokenValidityInMins")]
        public System.Int32? SelfServiceTokenValidityInMins { get; set; }

        //      C# -> System.Int32? SelfServiceAttemptsLimit
        // GraphQL -> selfServiceAttemptsLimit: Int (scalar)
        [JsonProperty("selfServiceAttemptsLimit")]
        public System.Int32? SelfServiceAttemptsLimit { get; set; }

        //      C# -> System.Boolean? IsSelfServiceEnabled
        // GraphQL -> isSelfServiceEnabled: Boolean (scalar)
        [JsonProperty("isSelfServiceEnabled")]
        public System.Boolean? IsSelfServiceEnabled { get; set; }

        //      C# -> System.Int32? AccountAutoUnlockDurationInMins
        // GraphQL -> accountAutoUnlockDurationInMins: Int (scalar)
        [JsonProperty("accountAutoUnlockDurationInMins")]
        public System.Int32? AccountAutoUnlockDurationInMins { get; set; }

        //      C# -> System.Boolean? IsBruteForceLockoutEnabled
        // GraphQL -> isBruteForceLockoutEnabled: Boolean (scalar)
        [JsonProperty("isBruteForceLockoutEnabled")]
        public System.Boolean? IsBruteForceLockoutEnabled { get; set; }

        //      C# -> System.Boolean? IsAutoUnlockFeatureEnabled
        // GraphQL -> isAutoUnlockFeatureEnabled: Boolean (scalar)
        [JsonProperty("isAutoUnlockFeatureEnabled")]
        public System.Boolean? IsAutoUnlockFeatureEnabled { get; set; }

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

    } // class UpdateLockoutConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types