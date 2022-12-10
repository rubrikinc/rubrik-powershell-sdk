// ReplicationSpecV2Input.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:26.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region ReplicationSpecV2Input

    public class ReplicationSpecV2Input
    {
        #region members
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? StorageSettingId
        // GraphQL -> storageSettingId: String (scalar)
        [JsonProperty("storageSettingId")]
        public System.String? StorageSettingId { get; set; }

        //      C# -> SlaDurationInput? RetentionDuration
        // GraphQL -> retentionDuration: SlaDurationInput (input)
        [JsonProperty("retentionDuration")]
        public SlaDurationInput? RetentionDuration { get; set; }

        //      C# -> System.String? AwsAccount
        // GraphQL -> awsAccount: String (scalar)
        [JsonProperty("awsAccount")]
        public System.String? AwsAccount { get; set; }

        //      C# -> System.String? AzureSubscription
        // GraphQL -> azureSubscription: String (scalar)
        [JsonProperty("azureSubscription")]
        public System.String? AzureSubscription { get; set; }

        //      C# -> SlaDurationInput? ReplicationLocalRetentionDuration
        // GraphQL -> replicationLocalRetentionDuration: SlaDurationInput (input)
        [JsonProperty("replicationLocalRetentionDuration")]
        public SlaDurationInput? ReplicationLocalRetentionDuration { get; set; }

        //      C# -> List<CascadingArchivalSpecInput>? CascadingArchivalSpecs
        // GraphQL -> cascadingArchivalSpecs: [CascadingArchivalSpecInput!] (input)
        [JsonProperty("cascadingArchivalSpecs")]
        public List<CascadingArchivalSpecInput>? CascadingArchivalSpecs { get; set; }

        //      C# -> AwsNativeRegionForReplication? AwsRegion
        // GraphQL -> awsRegion: AwsNativeRegionForReplication (enum)
        [JsonProperty("awsRegion")]
        public AwsNativeRegionForReplication? AwsRegion { get; set; }

        //      C# -> AzureNativeRegionForReplication? AzureRegion
        // GraphQL -> azureRegion: AzureNativeRegionForReplication (enum)
        [JsonProperty("azureRegion")]
        public AzureNativeRegionForReplication? AzureRegion { get; set; }

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

    } // class ReplicationSpecV2Input
    #endregion

} // namespace Rubrik.SecurityCloud.Types