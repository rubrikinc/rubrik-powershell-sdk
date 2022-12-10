// StartDisableAzureNativeSubscriptionProtectionJobInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:15.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region StartDisableAzureNativeSubscriptionProtectionJobInput

    public class StartDisableAzureNativeSubscriptionProtectionJobInput
    {
        #region members
        //      C# -> System.String? AzureSubscriptionRubrikId
        // GraphQL -> azureSubscriptionRubrikId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("azureSubscriptionRubrikId")]
        public System.String? AzureSubscriptionRubrikId { get; set; }

        //      C# -> System.Boolean? ShouldDeleteNativeSnapshots
        // GraphQL -> shouldDeleteNativeSnapshots: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldDeleteNativeSnapshots")]
        public System.Boolean? ShouldDeleteNativeSnapshots { get; set; }

        //      C# -> AzureNativeProtectionFeature? AzureNativeProtectionFeature
        // GraphQL -> azureNativeProtectionFeature: AzureNativeProtectionFeature! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("azureNativeProtectionFeature")]
        public AzureNativeProtectionFeature? AzureNativeProtectionFeature { get; set; }

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

    } // class StartDisableAzureNativeSubscriptionProtectionJobInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types