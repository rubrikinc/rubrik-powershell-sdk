// FusionComputeRestoreFilesConfigInput.cs
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
    #region FusionComputeRestoreFilesConfigInput

    public class FusionComputeRestoreFilesConfigInput: IInput
    {
        #region members

        //      C# -> List<FusionComputeRestoreFileConfigInput>? RestoreConfig
        // GraphQL -> restoreConfig: [FusionComputeRestoreFileConfigInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("restoreConfig")]
        public List<FusionComputeRestoreFileConfigInput>? RestoreConfig { get; set; }

        //      C# -> System.String? TargetVmId
        // GraphQL -> targetVmId: UUID (scalar)
        [JsonProperty("targetVmId")]
        public System.String? TargetVmId { get; set; }


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

    } // class FusionComputeRestoreFilesConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types