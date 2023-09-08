// UnmountDiskInput.cs
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
    #region UnmountDiskInput

    public class UnmountDiskInput: IInput
    {
        #region members

        //      C# -> System.Int64? LiveMountId
        // GraphQL -> liveMountId: Long! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("liveMountId")]
        public System.Int64? LiveMountId { get; set; }

        //      C# -> List<System.Int64>? MountIds
        // GraphQL -> mountIds: [Long!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("mountIds")]
        public List<System.Int64>? MountIds { get; set; }

        //      C# -> System.String? TargetWorkloadId
        // GraphQL -> targetWorkloadId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetWorkloadId")]
        public System.String? TargetWorkloadId { get; set; }


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

    } // class UnmountDiskInput
    #endregion

} // namespace RubrikSecurityCloud.Types