// VolumeGroupRestoreFileConfigInput.cs
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
    #region VolumeGroupRestoreFileConfigInput

    public class VolumeGroupRestoreFileConfigInput: IInput
    {
        #region members

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> System.String? RestorePath
        // GraphQL -> restorePath: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("restorePath")]
        public System.String? RestorePath { get; set; }


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

    } // class VolumeGroupRestoreFileConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types