// FilesetDownloadSnapshotFilesInput.cs
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
    #region FilesetDownloadSnapshotFilesInput

    public class FilesetDownloadSnapshotFilesInput: IInput
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? NextSnapshotFid
        // GraphQL -> nextSnapshotFid: UUID (scalar)
        [JsonProperty("nextSnapshotFid")]
        public System.String? NextSnapshotFid { get; set; }

        //      C# -> System.String? UserNote
        // GraphQL -> userNote: String (scalar)
        [JsonProperty("userNote")]
        public System.String? UserNote { get; set; }

        //      C# -> FilesetDownloadFilesJobConfigInput? Config
        // GraphQL -> config: FilesetDownloadFilesJobConfigInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("config")]
        public FilesetDownloadFilesJobConfigInput? Config { get; set; }

        //      C# -> List<DeltaType>? DeltaTypeFilter
        // GraphQL -> deltaTypeFilter: [DeltaType!] (enum)
        [JsonProperty("deltaTypeFilter")]
        public List<DeltaType>? DeltaTypeFilter { get; set; }


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

    } // class FilesetDownloadSnapshotFilesInput
    #endregion

} // namespace RubrikSecurityCloud.Types