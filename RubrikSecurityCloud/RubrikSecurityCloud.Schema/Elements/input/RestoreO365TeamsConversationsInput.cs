// RestoreO365TeamsConversationsInput.cs
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
    #region RestoreO365TeamsConversationsInput

    public class RestoreO365TeamsConversationsInput: IInput
    {
        #region members

        //      C# -> System.String? TeamUuid
        // GraphQL -> teamUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("teamUuid")]
        public System.String? TeamUuid { get; set; }

        //      C# -> TeamsChannelInfo? DestTeamsChannelInfo
        // GraphQL -> destTeamsChannelInfo: TeamsChannelInfo (input)
        [JsonProperty("destTeamsChannelInfo")]
        public TeamsChannelInfo? DestTeamsChannelInfo { get; set; }

        //      C# -> System.Boolean? ShouldCreateDestChannel
        // GraphQL -> shouldCreateDestChannel: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldCreateDestChannel")]
        public System.Boolean? ShouldCreateDestChannel { get; set; }

        //      C# -> O365TeamConvChannelInput? ChannelInfoForFullRestore
        // GraphQL -> channelInfoForFullRestore: O365TeamConvChannelInput (input)
        [JsonProperty("channelInfoForFullRestore")]
        public O365TeamConvChannelInput? ChannelInfoForFullRestore { get; set; }

        //      C# -> System.Boolean? ShouldRestoreFileAttachments
        // GraphQL -> shouldRestoreFileAttachments: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldRestoreFileAttachments")]
        public System.Boolean? ShouldRestoreFileAttachments { get; set; }

        //      C# -> List<O365TeamConvChannelInput>? TeamChannels
        // GraphQL -> teamChannels: [O365TeamConvChannelInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("teamChannels")]
        public List<O365TeamConvChannelInput>? TeamChannels { get; set; }

        //      C# -> TeamsConversationsSearchFilter? TeamsConversationsSearchFilter
        // GraphQL -> teamsConversationsSearchFilter: TeamsConversationsSearchFilter (input)
        [JsonProperty("teamsConversationsSearchFilter")]
        public TeamsConversationsSearchFilter? TeamsConversationsSearchFilter { get; set; }

        //      C# -> System.String? RefreshTokenEncrypted
        // GraphQL -> refreshTokenEncrypted: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("refreshTokenEncrypted")]
        public System.String? RefreshTokenEncrypted { get; set; }

        //      C# -> System.String? O365AppId
        // GraphQL -> o365AppId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("o365AppId")]
        public System.String? O365AppId { get; set; }

        //      C# -> ChannelMembershipType? ChannelRecoveryType
        // GraphQL -> channelRecoveryType: ChannelMembershipType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("channelRecoveryType")]
        public ChannelMembershipType? ChannelRecoveryType { get; set; }

        //      C# -> System.Boolean? RecoverWithLatestPermissions
        // GraphQL -> recoverWithLatestPermissions: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("recoverWithLatestPermissions")]
        public System.Boolean? RecoverWithLatestPermissions { get; set; }

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

    } // class RestoreO365TeamsConversationsInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types