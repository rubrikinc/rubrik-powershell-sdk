// AddAwsIamUserBasedCloudAccountInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region AddAwsIamUserBasedCloudAccountInput

    public class AddAwsIamUserBasedCloudAccountInput: IInput
    {
        #region members

        //      C# -> List<CloudAccountFeature>? Features
        // GraphQL -> features: [CloudAccountFeature!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("features")]
        public List<CloudAccountFeature>? Features { get; set; }

        //      C# -> System.String? AccessKey
        // GraphQL -> accessKey: String (scalar)
        [JsonProperty("accessKey")]
        public System.String? AccessKey { get; set; }

        //      C# -> System.String? SecretKey
        // GraphQL -> secretKey: String (scalar)
        [JsonProperty("secretKey")]
        public System.String? SecretKey { get; set; }

        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("nativeId")]
        public System.String? NativeId { get; set; }

        //      C# -> System.String? CloudAccountName
        // GraphQL -> cloudAccountName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudAccountName")]
        public System.String? CloudAccountName { get; set; }

        //      C# -> AwsCloudType? CloudType
        // GraphQL -> cloudType: AwsCloudType (enum)
        [JsonProperty("cloudType")]
        public AwsCloudType? CloudType { get; set; }

        //      C# -> List<AwsCloudAccountRegion>? AwsRegions
        // GraphQL -> awsRegions: [AwsCloudAccountRegion!] (enum)
        [JsonProperty("awsRegions")]
        public List<AwsCloudAccountRegion>? AwsRegions { get; set; }

        //      C# -> System.String? RoleArn
        // GraphQL -> roleArn: String (scalar)
        [JsonProperty("roleArn")]
        public System.String? RoleArn { get; set; }


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

    } // class AddAwsIamUserBasedCloudAccountInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types