// CustomizedRestoreFormConfigurationS3ArchivalLocationInput.cs
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
    #region CustomizedRestoreFormConfigurationS3ArchivalLocationInput

    public class CustomizedRestoreFormConfigurationS3ArchivalLocationInput: IInput
    {
        #region members

        //      C# -> CustomizedRestoreFormConfigurationArchivalProxyConfigInput? ArchivalProxyConfig
        // GraphQL -> archivalProxyConfig: CustomizedRestoreFormConfigurationArchivalProxyConfigInput (input)
        [JsonProperty("archivalProxyConfig")]
        public CustomizedRestoreFormConfigurationArchivalProxyConfigInput? ArchivalProxyConfig { get; set; }

        //      C# -> CustomizedRestoreFormConfigurationComputeProxyConfigInput? ComputeProxyConfig
        // GraphQL -> computeProxyConfig: CustomizedRestoreFormConfigurationComputeProxyConfigInput (input)
        [JsonProperty("computeProxyConfig")]
        public CustomizedRestoreFormConfigurationComputeProxyConfigInput? ComputeProxyConfig { get; set; }

        //      C# -> System.String? KmsMasterKeyId
        // GraphQL -> kmsMasterKeyId: String (scalar)
        [JsonProperty("kmsMasterKeyId")]
        public System.String? KmsMasterKeyId { get; set; }

        //      C# -> System.String? PemFileContent
        // GraphQL -> pemFileContent: String (scalar)
        [JsonProperty("pemFileContent")]
        public System.String? PemFileContent { get; set; }

        //      C# -> System.String? SecretKey
        // GraphQL -> secretKey: String (scalar)
        [JsonProperty("secretKey")]
        public System.String? SecretKey { get; set; }

        //      C# -> System.String? AccessKey
        // GraphQL -> accessKey: String (scalar)
        [JsonProperty("accessKey")]
        public System.String? AccessKey { get; set; }

        //      C# -> System.String? EncryptionPassword
        // GraphQL -> encryptionPassword: String (scalar)
        [JsonProperty("encryptionPassword")]
        public System.String? EncryptionPassword { get; set; }

        //      C# -> System.Boolean? ShouldRecoverSnappableMetadataOnly
        // GraphQL -> shouldRecoverSnappableMetadataOnly: Boolean (scalar)
        [JsonProperty("shouldRecoverSnappableMetadataOnly")]
        public System.Boolean? ShouldRecoverSnappableMetadataOnly { get; set; }

        //      C# -> RestoreFormConfigurationS3ArchivalLocationInput? RestoreFormConfigurationS3ArchivalLocation
        // GraphQL -> restoreFormConfigurationS3ArchivalLocation: RestoreFormConfigurationS3ArchivalLocationInput (input)
        [JsonProperty("restoreFormConfigurationS3ArchivalLocation")]
        public RestoreFormConfigurationS3ArchivalLocationInput? RestoreFormConfigurationS3ArchivalLocation { get; set; }


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

    } // class CustomizedRestoreFormConfigurationS3ArchivalLocationInput
    #endregion

} // namespace RubrikSecurityCloud.Types