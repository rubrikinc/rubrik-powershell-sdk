// FilesetRecoverFilesFromArchivalLocationInput.cs
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
    #region FilesetRecoverFilesFromArchivalLocationInput

    public class FilesetRecoverFilesFromArchivalLocationInput: IInput
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? NextSnapshotId
        // GraphQL -> nextSnapshotId: UUID (scalar)
        [JsonProperty("nextSnapshotId")]
        public System.String? NextSnapshotId { get; set; }

        //      C# -> List<OldRestorePathPairInput>? RestorePathPairList
        // GraphQL -> restorePathPairList: [OldRestorePathPairInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("restorePathPairList")]
        public List<OldRestorePathPairInput>? RestorePathPairList { get; set; }

        //      C# -> List<DeltaType>? DeltaTypeFilter
        // GraphQL -> deltaTypeFilter: [DeltaType!] (enum)
        [JsonProperty("deltaTypeFilter")]
        public List<DeltaType>? DeltaTypeFilter { get; set; }

        //      C# -> FilesetRestoreFilesJobConfigInput? Config
        // GraphQL -> config: FilesetRestoreFilesJobConfigInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("config")]
        public FilesetRestoreFilesJobConfigInput? Config { get; set; }

        //      C# -> ShareTypeEnum? ShareType
        // GraphQL -> shareType: ShareTypeEnum! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("shareType")]
        public ShareTypeEnum? ShareType { get; set; }

        //      C# -> GuestOsType? OsType
        // GraphQL -> osType: GuestOsType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("osType")]
        public GuestOsType? OsType { get; set; }

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }


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

    } // class FilesetRecoverFilesFromArchivalLocationInput
    #endregion

} // namespace RubrikSecurityCloud.Types