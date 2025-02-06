// RestoreO365TeamsFilesInput.cs
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
    #region RestoreO365TeamsFilesInput

    public class RestoreO365TeamsFilesInput: IInput
    {
        #region members

        //      C# -> List<FileInfo>? FilesToRestore
        // GraphQL -> filesToRestore: [FileInfo!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("filesToRestore")]
        public List<FileInfo>? FilesToRestore { get; set; }

        //      C# -> List<FolderInfo>? FoldersToRestore
        // GraphQL -> foldersToRestore: [FolderInfo!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("foldersToRestore")]
        public List<FolderInfo>? FoldersToRestore { get; set; }

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

        //      C# -> O365RestoreActionType? ActionType
        // GraphQL -> actionType: O365RestoreActionType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("actionType")]
        public O365RestoreActionType? ActionType { get; set; }

        //      C# -> InplaceRestoreConfig? InplaceRestoreConfig
        // GraphQL -> inplaceRestoreConfig: InplaceRestoreConfig (input)
        [JsonProperty("inplaceRestoreConfig")]
        public InplaceRestoreConfig? InplaceRestoreConfig { get; set; }

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

        //      C# -> System.String? TargetChannelFallbackOwner
        // GraphQL -> targetChannelFallbackOwner: String (scalar)
        [JsonProperty("targetChannelFallbackOwner")]
        public System.String? TargetChannelFallbackOwner { get; set; }


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

    } // class RestoreO365TeamsFilesInput
    #endregion

} // namespace RubrikSecurityCloud.Types