// FinalizeAwsCloudAccountProtectionInput.cs
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
    #region FinalizeAwsCloudAccountProtectionInput

    public class FinalizeAwsCloudAccountProtectionInput: IInput
    {
        #region members

        //      C# -> CloudAccountAction? Action
        // GraphQL -> action: CloudAccountAction! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("action")]
        public CloudAccountAction? Action { get; set; }

        //      C# -> List<CloudAccountFeature>? Features
        // GraphQL -> features: [CloudAccountFeature!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("features")]
        public List<CloudAccountFeature>? Features { get; set; }

        //      C# -> AwsCloudAccountInput? AwsAdminAccount
        // GraphQL -> awsAdminAccount: AwsCloudAccountInput (input)
        [JsonProperty("awsAdminAccount")]
        public AwsCloudAccountInput? AwsAdminAccount { get; set; }

        //      C# -> List<AwsCloudAccountInput>? AwsChildAccounts
        // GraphQL -> awsChildAccounts: [AwsCloudAccountInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("awsChildAccounts")]
        public List<AwsCloudAccountInput>? AwsChildAccounts { get; set; }

        //      C# -> List<AwsCloudAccountRegion>? AwsRegions
        // GraphQL -> awsRegions: [AwsCloudAccountRegion!] (enum)
        [JsonProperty("awsRegions")]
        public List<AwsCloudAccountRegion>? AwsRegions { get; set; }

        //      C# -> System.String? StackName
        // GraphQL -> stackName: String (scalar)
        [JsonProperty("stackName")]
        public System.String? StackName { get; set; }

        //      C# -> System.String? StackSetName
        // GraphQL -> stackSetName: String (scalar)
        [JsonProperty("stackSetName")]
        public System.String? StackSetName { get; set; }

        //      C# -> System.String? ExternalId
        // GraphQL -> externalId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("externalId")]
        public System.String? ExternalId { get; set; }

        //      C# -> List<AwsCloudAccountFeatureVersionInput>? FeatureVersion
        // GraphQL -> featureVersion: [AwsCloudAccountFeatureVersionInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("featureVersion")]
        public List<AwsCloudAccountFeatureVersionInput>? FeatureVersion { get; set; }


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

    } // class FinalizeAwsCloudAccountProtectionInput
    #endregion

} // namespace RubrikSecurityCloud.Types