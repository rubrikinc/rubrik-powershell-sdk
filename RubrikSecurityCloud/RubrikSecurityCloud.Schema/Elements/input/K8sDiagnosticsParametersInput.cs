// K8sDiagnosticsParametersInput.cs
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
    #region K8sDiagnosticsParametersInput

    public class K8sDiagnosticsParametersInput: IInput
    {
        #region members

        //      C# -> System.Boolean? IsBackupCheckEnabled
        // GraphQL -> isBackupCheckEnabled: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isBackupCheckEnabled")]
        public System.Boolean? IsBackupCheckEnabled { get; set; }

        //      C# -> System.Boolean? IsRestoreCheckEnabled
        // GraphQL -> isRestoreCheckEnabled: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isRestoreCheckEnabled")]
        public System.Boolean? IsRestoreCheckEnabled { get; set; }

        //      C# -> System.Boolean? IsRegistryCheckEnabled
        // GraphQL -> isRegistryCheckEnabled: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isRegistryCheckEnabled")]
        public System.Boolean? IsRegistryCheckEnabled { get; set; }


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

    } // class K8sDiagnosticsParametersInput
    #endregion

} // namespace RubrikSecurityCloud.Types