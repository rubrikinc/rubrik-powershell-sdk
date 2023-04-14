// VsphereExcludeVmDisksInput.cs
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
    #region VsphereExcludeVmDisksInput

    public class VsphereExcludeVmDisksInput: IInput
    {
        #region members

        //      C# -> System.String? VirtualDiskFid
        // GraphQL -> virtualDiskFid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("virtualDiskFid")]
        public System.String? VirtualDiskFid { get; set; }

        //      C# -> System.Boolean? ExcludeFromSnapshots
        // GraphQL -> excludeFromSnapshots: Boolean (scalar)
        [JsonProperty("excludeFromSnapshots")]
        public System.Boolean? ExcludeFromSnapshots { get; set; }


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

    } // class VsphereExcludeVmDisksInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types