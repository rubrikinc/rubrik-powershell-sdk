// RecoverCloudClusterInput.cs
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
    #region RecoverCloudClusterInput

    public class RecoverCloudClusterInput: IInput
    {
        #region members

        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudAccountId")]
        public System.String? CloudAccountId { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> AzureVmConfig? AzureVmConfig
        // GraphQL -> azureVmConfig: AzureVmConfig (input)
        [JsonProperty("azureVmConfig")]
        public AzureVmConfig? AzureVmConfig { get; set; }

        //      C# -> AwsVmConfig? AwsVmConfig
        // GraphQL -> awsVmConfig: AwsVmConfig (input)
        [JsonProperty("awsVmConfig")]
        public AwsVmConfig? AwsVmConfig { get; set; }

        //      C# -> System.String? AwsRegion
        // GraphQL -> awsRegion: String (scalar)
        [JsonProperty("awsRegion")]
        public System.String? AwsRegion { get; set; }

        //      C# -> System.Boolean? ShouldDisableAwsApiTermination
        // GraphQL -> shouldDisableAwsApiTermination: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldDisableAwsApiTermination")]
        public System.Boolean? ShouldDisableAwsApiTermination { get; set; }

        //      C# -> System.Boolean? ShouldKeepClusterOnFailure
        // GraphQL -> shouldKeepClusterOnFailure: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldKeepClusterOnFailure")]
        public System.Boolean? ShouldKeepClusterOnFailure { get; set; }


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

    } // class RecoverCloudClusterInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types