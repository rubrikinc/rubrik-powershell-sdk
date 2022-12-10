// FolderInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:32.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region FolderInfo

    public class FolderInfo
    {
        #region members
        //      C# -> System.String? FolderId
        // GraphQL -> folderId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("folderId")]
        public System.String? FolderId { get; set; }

        //      C# -> System.String? FolderName
        // GraphQL -> folderName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("folderName")]
        public System.String? FolderName { get; set; }

        //      C# -> System.Int64? FolderSize
        // GraphQL -> folderSize: Long! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("folderSize")]
        public System.Int64? FolderSize { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotNum")]
        public System.Int32? SnapshotNum { get; set; }

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

    } // class FolderInfo
    #endregion

} // namespace Rubrik.SecurityCloud.Types