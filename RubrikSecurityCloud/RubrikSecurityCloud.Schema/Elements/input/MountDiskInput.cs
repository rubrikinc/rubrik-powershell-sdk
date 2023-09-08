// MountDiskInput.cs
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
    #region MountDiskInput

    public class MountDiskInput: IInput
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? TargetWorkloadId
        // GraphQL -> targetWorkloadId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetWorkloadId")]
        public System.String? TargetWorkloadId { get; set; }

        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotType")]
        public SnapshotType? SnapshotType { get; set; }

        //      C# -> List<System.String>? MountDiskIds
        // GraphQL -> mountDiskIds: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("mountDiskIds")]
        public List<System.String>? MountDiskIds { get; set; }

        //      C# -> CloudNativeObjectType? WorkloadType
        // GraphQL -> workloadType: CloudNativeObjectType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("workloadType")]
        public CloudNativeObjectType? WorkloadType { get; set; }


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

    } // class MountDiskInput
    #endregion

} // namespace RubrikSecurityCloud.Types