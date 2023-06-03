// VcdVappPatchInput.cs
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
    #region VcdVappPatchInput

    public class VcdVappPatchInput: IInput
    {
        #region members

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> System.Boolean? IsBestEffortSynchronizationEnabled
        // GraphQL -> isBestEffortSynchronizationEnabled: Boolean (scalar)
        [JsonProperty("isBestEffortSynchronizationEnabled")]
        public System.Boolean? IsBestEffortSynchronizationEnabled { get; set; }

        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean (scalar)
        [JsonProperty("isPaused")]
        public System.Boolean? IsPaused { get; set; }

        //      C# -> List<System.String>? VcdVmMoidsToExcludeFromSnapshot
        // GraphQL -> vcdVmMoidsToExcludeFromSnapshot: [String!] (scalar)
        [JsonProperty("vcdVmMoidsToExcludeFromSnapshot")]
        public List<System.String>? VcdVmMoidsToExcludeFromSnapshot { get; set; }


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

    } // class VcdVappPatchInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types