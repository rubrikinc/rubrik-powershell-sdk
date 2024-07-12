// VolumeGroupRestoreFilesConfigInput.cs
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
    #region VolumeGroupRestoreFilesConfigInput

    public class VolumeGroupRestoreFilesConfigInput: IInput
    {
        #region members

        //      C# -> System.String? TargetHostId
        // GraphQL -> targetHostId: String (scalar)
        [JsonProperty("targetHostId")]
        public System.String? TargetHostId { get; set; }

        //      C# -> System.Boolean? ShouldIgnoreError
        // GraphQL -> shouldIgnoreError: Boolean (scalar)
        [JsonProperty("shouldIgnoreError")]
        public System.Boolean? ShouldIgnoreError { get; set; }

        //      C# -> List<VolumeGroupRestoreFileConfigInput>? RestoreConfigs
        // GraphQL -> restoreConfigs: [VolumeGroupRestoreFileConfigInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("restoreConfigs")]
        public List<VolumeGroupRestoreFileConfigInput>? RestoreConfigs { get; set; }


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

    } // class VolumeGroupRestoreFilesConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types