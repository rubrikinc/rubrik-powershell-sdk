// VsphereSnapshotRestoreFilesFromLocationInput.cs
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
    #region VsphereSnapshotRestoreFilesFromLocationInput

    public class VsphereSnapshotRestoreFilesFromLocationInput: IInput
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }

        //      C# -> RestoreFilesJobConfigInput? Config
        // GraphQL -> config: RestoreFilesJobConfigInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("config")]
        public RestoreFilesJobConfigInput? Config { get; set; }


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

    } // class VsphereSnapshotRestoreFilesFromLocationInput
    #endregion

} // namespace RubrikSecurityCloud.Types