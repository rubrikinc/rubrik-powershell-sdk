// UpdateCertificateCloudAccountMappingsInput.cs
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
    #region UpdateCertificateCloudAccountMappingsInput

    public class UpdateCertificateCloudAccountMappingsInput: IInput
    {
        #region members

        //      C# -> System.String? CloudNativeAccountId
        // GraphQL -> cloudNativeAccountId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudNativeAccountId")]
        public System.String? CloudNativeAccountId { get; set; }

        //      C# -> List<CertificateInfoInput>? Certificates
        // GraphQL -> certificates: [CertificateInfoInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("certificates")]
        public List<CertificateInfoInput>? Certificates { get; set; }

        //      C# -> CloudType? CloudType
        // GraphQL -> cloudType: CloudType (enum)
        [JsonProperty("cloudType")]
        public CloudType? CloudType { get; set; }


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

    } // class UpdateCertificateCloudAccountMappingsInput
    #endregion

} // namespace RubrikSecurityCloud.Types