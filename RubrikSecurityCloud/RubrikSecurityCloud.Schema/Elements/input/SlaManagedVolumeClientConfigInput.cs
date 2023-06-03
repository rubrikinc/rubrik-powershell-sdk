// SlaManagedVolumeClientConfigInput.cs
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
    #region SlaManagedVolumeClientConfigInput

    public class SlaManagedVolumeClientConfigInput: IInput
    {
        #region members

        //      C# -> SlaManagedVolumeScriptConfigInput? PostBackupScriptOnBackupFailure
        // GraphQL -> postBackupScriptOnBackupFailure: SlaManagedVolumeScriptConfigInput (input)
        [JsonProperty("postBackupScriptOnBackupFailure")]
        public SlaManagedVolumeScriptConfigInput? PostBackupScriptOnBackupFailure { get; set; }

        //      C# -> SlaManagedVolumeScriptConfigInput? PostBackupScriptOnBackupSuccess
        // GraphQL -> postBackupScriptOnBackupSuccess: SlaManagedVolumeScriptConfigInput (input)
        [JsonProperty("postBackupScriptOnBackupSuccess")]
        public SlaManagedVolumeScriptConfigInput? PostBackupScriptOnBackupSuccess { get; set; }

        //      C# -> SlaManagedVolumeScriptConfigInput? PreBackupScript
        // GraphQL -> preBackupScript: SlaManagedVolumeScriptConfigInput (input)
        [JsonProperty("preBackupScript")]
        public SlaManagedVolumeScriptConfigInput? PreBackupScript { get; set; }

        //      C# -> System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure
        // GraphQL -> shouldCancelBackupOnPreBackupScriptFailure: Boolean (scalar)
        [JsonProperty("shouldCancelBackupOnPreBackupScriptFailure")]
        public System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure { get; set; }

        //      C# -> ManagedVolumeLogConfigInput? LogConfig
        // GraphQL -> logConfig: ManagedVolumeLogConfigInput (input)
        [JsonProperty("logConfig")]
        public ManagedVolumeLogConfigInput? LogConfig { get; set; }

        //      C# -> SlaManagedVolumeScriptConfigInput? BackupScript
        // GraphQL -> backupScript: SlaManagedVolumeScriptConfigInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("backupScript")]
        public SlaManagedVolumeScriptConfigInput? BackupScript { get; set; }

        //      C# -> List<System.String>? ChannelHostMountPaths
        // GraphQL -> channelHostMountPaths: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("channelHostMountPaths")]
        public List<System.String>? ChannelHostMountPaths { get; set; }

        //      C# -> System.String? ClientHostId
        // GraphQL -> clientHostId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clientHostId")]
        public System.String? ClientHostId { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("username")]
        public System.String? Username { get; set; }


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

    } // class SlaManagedVolumeClientConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types