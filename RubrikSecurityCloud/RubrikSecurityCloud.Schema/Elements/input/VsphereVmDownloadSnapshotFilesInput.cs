// VsphereVmDownloadSnapshotFilesInput.cs
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
    #region VsphereVmDownloadSnapshotFilesInput

    public class VsphereVmDownloadSnapshotFilesInput: IInput
    {
        #region members

        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> List<System.String>? Paths
        // GraphQL -> paths: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("paths")]
        public List<System.String>? Paths { get; set; }

        //      C# -> List<DeltaType>? DeltaTypeFilter
        // GraphQL -> deltaTypeFilter: [DeltaType!] (enum)
        [JsonProperty("deltaTypeFilter")]
        public List<DeltaType>? DeltaTypeFilter { get; set; }

        //      C# -> System.String? NextSnapshotFid
        // GraphQL -> nextSnapshotFid: UUID (scalar)
        [JsonProperty("nextSnapshotFid")]
        public System.String? NextSnapshotFid { get; set; }

        //      C# -> System.Boolean? IsLegalHoldDownload
        // GraphQL -> isLegalHoldDownload: Boolean (scalar)
        [JsonProperty("isLegalHoldDownload")]
        public System.Boolean? IsLegalHoldDownload { get; set; }

        //      C# -> System.String? UserNote
        // GraphQL -> userNote: String (scalar)
        [JsonProperty("userNote")]
        public System.String? UserNote { get; set; }


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

    } // class VsphereVmDownloadSnapshotFilesInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types