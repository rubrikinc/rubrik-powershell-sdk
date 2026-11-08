// AwsRecoverySettingsInput.cs
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
    #region AwsRecoverySettingsInput

    public class AwsRecoverySettingsInput: IInput
    {
        #region members

        //      C# -> AwsNetworkingSettingsInput? Networking
        // GraphQL -> networking: AwsNetworkingSettingsInput (input)
        [JsonProperty("networking")]
        public AwsNetworkingSettingsInput? Networking { get; set; }

        //      C# -> AwsKmsSettingsInput? Kms
        // GraphQL -> kms: AwsKmsSettingsInput (input)
        [JsonProperty("kms")]
        public AwsKmsSettingsInput? Kms { get; set; }

        //      C# -> AwsRoute53Input? Dns
        // GraphQL -> dns: AwsRoute53Input (input)
        [JsonProperty("dns")]
        public AwsRoute53Input? Dns { get; set; }

        //      C# -> AwsS3RecoverySettingsInput? S3
        // GraphQL -> s3: AwsS3RecoverySettingsInput (input)
        [JsonProperty("s3")]
        public AwsS3RecoverySettingsInput? S3 { get; set; }


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

    } // class AwsRecoverySettingsInput
    #endregion

} // namespace RubrikSecurityCloud.Types