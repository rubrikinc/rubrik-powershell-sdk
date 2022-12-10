// TeamsRestoreConfig.cs
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
    #region TeamsRestoreConfig

    public class TeamsRestoreConfig
    {
        #region members
        //      C# -> DriveRestoreConfig? FilesRestoreConfig
        // GraphQL -> filesRestoreConfig: DriveRestoreConfig (input)
        [JsonProperty("filesRestoreConfig")]
        public DriveRestoreConfig? FilesRestoreConfig { get; set; }

        //      C# -> ConversationsRestoreConfig? ConversationsRestoreConfig
        // GraphQL -> conversationsRestoreConfig: ConversationsRestoreConfig (input)
        [JsonProperty("conversationsRestoreConfig")]
        public ConversationsRestoreConfig? ConversationsRestoreConfig { get; set; }

        //      C# -> TeamsChannelInfo? DestChannelInfo
        // GraphQL -> destChannelInfo: TeamsChannelInfo (input)
        [JsonProperty("destChannelInfo")]
        public TeamsChannelInfo? DestChannelInfo { get; set; }

        //      C# -> System.Boolean? ShouldCreateDestChannel
        // GraphQL -> shouldCreateDestChannel: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldCreateDestChannel")]
        public System.Boolean? ShouldCreateDestChannel { get; set; }

        //      C# -> ChannelMembershipType? ChannelType
        // GraphQL -> channelType: ChannelMembershipType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("channelType")]
        public ChannelMembershipType? ChannelType { get; set; }

        //      C# -> System.Boolean? RestoreLatestPermissions
        // GraphQL -> restoreLatestPermissions: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("restoreLatestPermissions")]
        public System.Boolean? RestoreLatestPermissions { get; set; }

        //      C# -> System.Int32? SnapshotSequenceNum
        // GraphQL -> snapshotSequenceNum: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotSequenceNum")]
        public System.Int32? SnapshotSequenceNum { get; set; }

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

    } // class TeamsRestoreConfig
    #endregion

} // namespace Rubrik.SecurityCloud.Types