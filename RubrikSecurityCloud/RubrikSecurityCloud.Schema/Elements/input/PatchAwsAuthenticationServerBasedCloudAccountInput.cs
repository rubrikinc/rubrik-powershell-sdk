// PatchAwsAuthenticationServerBasedCloudAccountInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:23.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region PatchAwsAuthenticationServerBasedCloudAccountInput

    public class PatchAwsAuthenticationServerBasedCloudAccountInput
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

        //      C# -> AwsAuthServerRegionsInput? AwsRegions
        // GraphQL -> awsRegions: AwsAuthServerRegionsInput (input)
        [JsonProperty("awsRegions")]
        public AwsAuthServerRegionsInput? AwsRegions { get; set; }

        //      C# -> AwsAuthServerRoleNameInput? RoleName
        // GraphQL -> roleName: AwsAuthServerRoleNameInput (input)
        [JsonProperty("roleName")]
        public AwsAuthServerRoleNameInput? RoleName { get; set; }

        //      C# -> AwsAuthServerCertificateIdInput? AuthServerUserClientCertId
        // GraphQL -> authServerUserClientCertId: AwsAuthServerCertificateIdInput (input)
        [JsonProperty("authServerUserClientCertId")]
        public AwsAuthServerCertificateIdInput? AuthServerUserClientCertId { get; set; }

        //      C# -> AwsAuthServerCertificateIdInput? AuthServerCaCertId
        // GraphQL -> authServerCaCertId: AwsAuthServerCertificateIdInput (input)
        [JsonProperty("authServerCaCertId")]
        public AwsAuthServerCertificateIdInput? AuthServerCaCertId { get; set; }

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

    } // class PatchAwsAuthenticationServerBasedCloudAccountInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types