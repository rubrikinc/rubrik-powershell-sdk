// AddCloudDirectSystemInput.cs
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
    #region AddCloudDirectSystemInput

    public class AddCloudDirectSystemInput: IInput
    {
        #region members

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> CloudDirectNasVendorType? SystemType
        // GraphQL -> systemType: CloudDirectNasVendorType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("systemType")]
        public CloudDirectNasVendorType? SystemType { get; set; }

        //      C# -> System.String? Host
        // GraphQL -> host: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("host")]
        public System.String? Host { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> System.String? Password
        // GraphQL -> password: String (scalar)
        [JsonProperty("password")]
        public System.String? Password { get; set; }

        //      C# -> NcdManagementInfo? ManagementInfo
        // GraphQL -> managementInfo: NcdManagementInfo (input)
        [JsonProperty("managementInfo")]
        public NcdManagementInfo? ManagementInfo { get; set; }

        //      C# -> System.Boolean? SkipServiceAccountCreation
        // GraphQL -> skipServiceAccountCreation: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("skipServiceAccountCreation")]
        public System.Boolean? SkipServiceAccountCreation { get; set; }

        //      C# -> System.String? Region
        // GraphQL -> region: String (scalar)
        [JsonProperty("region")]
        public System.String? Region { get; set; }

        //      C# -> System.Boolean? VerifySsl
        // GraphQL -> verifySsl: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("verifySsl")]
        public System.Boolean? VerifySsl { get; set; }

        //      C# -> System.String? CertificateData
        // GraphQL -> certificateData: String (scalar)
        [JsonProperty("certificateData")]
        public System.String? CertificateData { get; set; }

        //      C# -> CloudDirectCertificateType? CertificateType
        // GraphQL -> certificateType: CloudDirectCertificateType (enum)
        [JsonProperty("certificateType")]
        public CloudDirectCertificateType? CertificateType { get; set; }

        //      C# -> System.String? CertificateKeyPassword
        // GraphQL -> certificateKeyPassword: String (scalar)
        [JsonProperty("certificateKeyPassword")]
        public System.String? CertificateKeyPassword { get; set; }


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

    } // class AddCloudDirectSystemInput
    #endregion

} // namespace RubrikSecurityCloud.Types