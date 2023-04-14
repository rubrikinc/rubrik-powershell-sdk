// VappInstantRecoveryJobConfigInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region VappInstantRecoveryJobConfigInput

    public class VappInstantRecoveryJobConfigInput: IInput
    {
        #region members

        //      C# -> System.Boolean? ShouldPowerOnVmsAfterRecovery
        // GraphQL -> shouldPowerOnVmsAfterRecovery: Boolean (scalar)
        [JsonProperty("shouldPowerOnVmsAfterRecovery")]
        public System.Boolean? ShouldPowerOnVmsAfterRecovery { get; set; }

        //      C# -> List<VappVmRestoreSpecInput>? VmsToRestore
        // GraphQL -> vmsToRestore: [VappVmRestoreSpecInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("vmsToRestore")]
        public List<VappVmRestoreSpecInput>? VmsToRestore { get; set; }


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

    } // class VappInstantRecoveryJobConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types