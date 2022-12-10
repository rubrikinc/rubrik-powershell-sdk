// ManagedVolumePatchSlaClientConfigInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:28.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region ManagedVolumePatchSlaClientConfigInput

    public class ManagedVolumePatchSlaClientConfigInput
    {
        #region members
        //      C# -> System.String? BackupScriptCommand
        // GraphQL -> backupScriptCommand: String (scalar)
        [JsonProperty("backupScriptCommand")]
        public System.String? BackupScriptCommand { get; set; }

        //      C# -> System.Int64? BackupScriptTimeout
        // GraphQL -> backupScriptTimeout: Long (scalar)
        [JsonProperty("backupScriptTimeout")]
        public System.Int64? BackupScriptTimeout { get; set; }

        //      C# -> List<System.String>? ChannelHostMountPaths
        // GraphQL -> channelHostMountPaths: [String!] (scalar)
        [JsonProperty("channelHostMountPaths")]
        public List<System.String>? ChannelHostMountPaths { get; set; }

        //      C# -> System.String? ClientHostId
        // GraphQL -> clientHostId: String (scalar)
        [JsonProperty("clientHostId")]
        public System.String? ClientHostId { get; set; }

        //      C# -> System.String? PostBackupScriptOnBackupFailureCommand
        // GraphQL -> postBackupScriptOnBackupFailureCommand: String (scalar)
        [JsonProperty("postBackupScriptOnBackupFailureCommand")]
        public System.String? PostBackupScriptOnBackupFailureCommand { get; set; }

        //      C# -> System.Int64? PostBackupScriptOnBackupFailureTimeout
        // GraphQL -> postBackupScriptOnBackupFailureTimeout: Long (scalar)
        [JsonProperty("postBackupScriptOnBackupFailureTimeout")]
        public System.Int64? PostBackupScriptOnBackupFailureTimeout { get; set; }

        //      C# -> System.String? PostBackupScriptOnBackupSuccessCommand
        // GraphQL -> postBackupScriptOnBackupSuccessCommand: String (scalar)
        [JsonProperty("postBackupScriptOnBackupSuccessCommand")]
        public System.String? PostBackupScriptOnBackupSuccessCommand { get; set; }

        //      C# -> System.Int64? PostBackupScriptOnBackupSuccessTimeout
        // GraphQL -> postBackupScriptOnBackupSuccessTimeout: Long (scalar)
        [JsonProperty("postBackupScriptOnBackupSuccessTimeout")]
        public System.Int64? PostBackupScriptOnBackupSuccessTimeout { get; set; }

        //      C# -> System.String? PreBackupScriptCommand
        // GraphQL -> preBackupScriptCommand: String (scalar)
        [JsonProperty("preBackupScriptCommand")]
        public System.String? PreBackupScriptCommand { get; set; }

        //      C# -> System.Int64? PreBackupScriptTimeout
        // GraphQL -> preBackupScriptTimeout: Long (scalar)
        [JsonProperty("preBackupScriptTimeout")]
        public System.Int64? PreBackupScriptTimeout { get; set; }

        //      C# -> System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure
        // GraphQL -> shouldCancelBackupOnPreBackupScriptFailure: Boolean (scalar)
        [JsonProperty("shouldCancelBackupOnPreBackupScriptFailure")]
        public System.Boolean? ShouldCancelBackupOnPreBackupScriptFailure { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> System.Boolean? ShouldDisablePostBackupScriptOnBackupFailure
        // GraphQL -> shouldDisablePostBackupScriptOnBackupFailure: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldDisablePostBackupScriptOnBackupFailure")]
        public System.Boolean? ShouldDisablePostBackupScriptOnBackupFailure { get; set; }

        //      C# -> System.Boolean? ShouldDisablePostBackupScriptOnBackupSuccess
        // GraphQL -> shouldDisablePostBackupScriptOnBackupSuccess: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldDisablePostBackupScriptOnBackupSuccess")]
        public System.Boolean? ShouldDisablePostBackupScriptOnBackupSuccess { get; set; }

        //      C# -> System.Boolean? ShouldDisablePreBackupScript
        // GraphQL -> shouldDisablePreBackupScript: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldDisablePreBackupScript")]
        public System.Boolean? ShouldDisablePreBackupScript { get; set; }

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

    } // class ManagedVolumePatchSlaClientConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types