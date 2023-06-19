// AddAwsAuthenticationServerBasedCloudAccountInput.cs
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
    #region AddAwsAuthenticationServerBasedCloudAccountInput

    public class AddAwsAuthenticationServerBasedCloudAccountInput: IInput
    {
        #region members

        //      C# -> AwsCloudType? CloudType
        // GraphQL -> cloudType: AwsCloudType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudType")]
        public AwsCloudType? CloudType { get; set; }

        //      C# -> System.String? AwsAccountName
        // GraphQL -> awsAccountName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("awsAccountName")]
        public System.String? AwsAccountName { get; set; }

        //      C# -> List<AwsAuthServerBasedCloudAccountRegion>? AwsRegions
        // GraphQL -> awsRegions: [AwsAuthServerBasedCloudAccountRegion!] (enum)
        [JsonProperty("awsRegions")]
        public List<AwsAuthServerBasedCloudAccountRegion>? AwsRegions { get; set; }

        //      C# -> List<CloudAccountFeature>? Features
        // GraphQL -> features: [CloudAccountFeature!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("features")]
        public List<CloudAccountFeature>? Features { get; set; }

        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String (scalar)
        [JsonProperty("nativeId")]
        public System.String? NativeId { get; set; }

        //      C# -> System.String? AgencyName
        // GraphQL -> agencyName: String (scalar)
        [JsonProperty("agencyName")]
        public System.String? AgencyName { get; set; }

        //      C# -> System.String? RoleName
        // GraphQL -> roleName: String (scalar)
        [JsonProperty("roleName")]
        public System.String? RoleName { get; set; }

        //      C# -> System.String? AuthServerHostName
        // GraphQL -> authServerHostName: String (scalar)
        [JsonProperty("authServerHostName")]
        public System.String? AuthServerHostName { get; set; }

        //      C# -> AwsAuthServerCertificateIdInput? AuthServerUserClientCertId
        // GraphQL -> authServerUserClientCertId: AwsAuthServerCertificateIdInput (input)
        [JsonProperty("authServerUserClientCertId")]
        public AwsAuthServerCertificateIdInput? AuthServerUserClientCertId { get; set; }

        //      C# -> AwsAuthServerCertificateIdInput? AuthServerCaCertId
        // GraphQL -> authServerCaCertId: AwsAuthServerCertificateIdInput (input)
        [JsonProperty("authServerCaCertId")]
        public AwsAuthServerCertificateIdInput? AuthServerCaCertId { get; set; }

        //      C# -> AwsAuthServerCertificateIdInput? AwsCaCertId
        // GraphQL -> awsCaCertId: AwsAuthServerCertificateIdInput (input)
        [JsonProperty("awsCaCertId")]
        public AwsAuthServerCertificateIdInput? AwsCaCertId { get; set; }


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

    } // class AddAwsAuthenticationServerBasedCloudAccountInput
    #endregion

} // namespace RubrikSecurityCloud.Types