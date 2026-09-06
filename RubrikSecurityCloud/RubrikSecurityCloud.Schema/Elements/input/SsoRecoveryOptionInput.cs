// SsoRecoveryOptionInput.cs
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
    #region SsoRecoveryOptionInput

    public class SsoRecoveryOptionInput: IInput
    {
        #region members

        //      C# -> List<SsoSigningCertConfigInput>? SsoSigningCertConfigs
        // GraphQL -> ssoSigningCertConfigs: [SsoSigningCertConfigInput!] (input)
        [JsonProperty("ssoSigningCertConfigs")]
        public List<SsoSigningCertConfigInput>? SsoSigningCertConfigs { get; set; }

        //      C# -> DateTime? SsoSigningCertExpiryTime
        // GraphQL -> ssoSigningCertExpiryTime: DateTime (scalar)
        [JsonProperty("ssoSigningCertExpiryTime")]
        public DateTime? SsoSigningCertExpiryTime { get; set; }

        //      C# -> System.Boolean? ShouldRecoverLinkedSsoPolicies
        // GraphQL -> shouldRecoverLinkedSsoPolicies: Boolean (scalar)
        [JsonProperty("shouldRecoverLinkedSsoPolicies")]
        public System.Boolean? ShouldRecoverLinkedSsoPolicies { get; set; }


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

    } // class SsoRecoveryOptionInput
    #endregion

} // namespace RubrikSecurityCloud.Types