// FileInfo.cs
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
    #region FileInfo

    public class FileInfo: IInput
    {
        #region members

        //      C# -> System.String? FileId
        // GraphQL -> fileId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("fileId")]
        public System.String? FileId { get; set; }

        //      C# -> System.String? FileName
        // GraphQL -> fileName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("fileName")]
        public System.String? FileName { get; set; }

        //      C# -> List<FileSnapshotInfo>? FileSnapshotsToRestore
        // GraphQL -> fileSnapshotsToRestore: [FileSnapshotInfo!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("fileSnapshotsToRestore")]
        public List<FileSnapshotInfo>? FileSnapshotsToRestore { get; set; }

        //      C# -> TeamsChannelInfo? ChannelInfo
        // GraphQL -> channelInfo: TeamsChannelInfo (input)
        [JsonProperty("channelInfo")]
        public TeamsChannelInfo? ChannelInfo { get; set; }


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

    } // class FileInfo
    #endregion

} // namespace Rubrik.SecurityCloud.Types