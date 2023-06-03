// PatchAwsIamUserBasedCloudAccountInput.cs
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
    #region PatchAwsIamUserBasedCloudAccountInput

    public class PatchAwsIamUserBasedCloudAccountInput: IInput
    {
        #region members

        //      C# -> System.String? AwsCloudAccountId
        // GraphQL -> awsCloudAccountId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("awsCloudAccountId")]
        public System.String? AwsCloudAccountId { get; set; }

        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("feature")]
        public CloudAccountFeature? Feature { get; set; }

        //      C# -> AwsRegionsInput? AwsRegions
        // GraphQL -> awsRegions: AwsRegionsInput (input)
        [JsonProperty("awsRegions")]
        public AwsRegionsInput? AwsRegions { get; set; }

        //      C# -> AwsUserKeysInput? AwsUserKeys
        // GraphQL -> awsUserKeys: AwsUserKeysInput (input)
        [JsonProperty("awsUserKeys")]
        public AwsUserKeysInput? AwsUserKeys { get; set; }

        //      C# -> AwsRoleArnInput? AwsRoleArn
        // GraphQL -> awsRoleArn: AwsRoleArnInput (input)
        [JsonProperty("awsRoleArn")]
        public AwsRoleArnInput? AwsRoleArn { get; set; }


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

    } // class PatchAwsIamUserBasedCloudAccountInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types