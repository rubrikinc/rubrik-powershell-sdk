// VcenterUpdateConfigV2Input.cs
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
    #region VcenterUpdateConfigV2Input

    public class VcenterUpdateConfigV2Input: IInput
    {
        #region members

        //      C# -> VcenterUpdateConfigV2ConflictResolutionAuthz? ConflictResolutionAuthz
        // GraphQL -> conflictResolutionAuthz: VcenterUpdateConfigV2ConflictResolutionAuthz (enum)
        [JsonProperty("conflictResolutionAuthz")]
        public VcenterUpdateConfigV2ConflictResolutionAuthz? ConflictResolutionAuthz { get; set; }

        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String (scalar)
        [JsonProperty("caCerts")]
        public System.String? CaCerts { get; set; }

        //      C# -> System.String? Password
        // GraphQL -> password: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("password")]
        public System.String? Password { get; set; }

        //      C# -> System.Boolean? ShouldEnableHotAddProxyForOnPrem
        // GraphQL -> shouldEnableHotAddProxyForOnPrem: Boolean (scalar)
        [JsonProperty("shouldEnableHotAddProxyForOnPrem")]
        public System.Boolean? ShouldEnableHotAddProxyForOnPrem { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("username")]
        public System.String? Username { get; set; }


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

    } // class VcenterUpdateConfigV2Input
    #endregion

} // namespace RubrikSecurityCloud.Types