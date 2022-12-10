// ConversationsRestoreConfig.cs
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
    #region ConversationsRestoreConfig

    public class ConversationsRestoreConfig
    {
        #region members
        //      C# -> TeamsConversationsSearchFilterJson? SearchFilter
        // GraphQL -> SearchFilter: TeamsConversationsSearchFilterJson (input)
        [JsonProperty("SearchFilter")]
        public TeamsConversationsSearchFilterJson? SearchFilter { get; set; }

        //      C# -> TeamsConvChannelInfo? ChannelInfoForFullRestore
        // GraphQL -> ChannelInfoForFullRestore: TeamsConvChannelInfo (input)
        [JsonProperty("ChannelInfoForFullRestore")]
        public TeamsConvChannelInfo? ChannelInfoForFullRestore { get; set; }

        //      C# -> System.String? RefreshTokenEncrypted
        // GraphQL -> RefreshTokenEncrypted: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("RefreshTokenEncrypted")]
        public System.String? RefreshTokenEncrypted { get; set; }

        //      C# -> System.String? O365AppId
        // GraphQL -> O365AppID: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("O365AppID")]
        public System.String? O365AppId { get; set; }

        //      C# -> List<TeamsConvChannelInfo>? ChannelsToRestore
        // GraphQL -> ChannelsToRestore: [TeamsConvChannelInfo!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("ChannelsToRestore")]
        public List<TeamsConvChannelInfo>? ChannelsToRestore { get; set; }

        //      C# -> System.Boolean? ShouldRestoreFileAttachments
        // GraphQL -> ShouldRestoreFileAttachments: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("ShouldRestoreFileAttachments")]
        public System.Boolean? ShouldRestoreFileAttachments { get; set; }

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

    } // class ConversationsRestoreConfig
    #endregion

} // namespace Rubrik.SecurityCloud.Types