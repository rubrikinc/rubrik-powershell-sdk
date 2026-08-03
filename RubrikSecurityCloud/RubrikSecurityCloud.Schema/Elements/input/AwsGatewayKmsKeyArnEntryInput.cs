// AwsGatewayKmsKeyArnEntryInput.cs
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
    #region AwsGatewayKmsKeyArnEntryInput

    public class AwsGatewayKmsKeyArnEntryInput: IInput
    {
        #region members

        //      C# -> System.String? ApplicationCloudAccountId
        // GraphQL -> applicationCloudAccountId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("applicationCloudAccountId")]
        public System.String? ApplicationCloudAccountId { get; set; }

        //      C# -> System.String? GatewayKmsKeyArn
        // GraphQL -> gatewayKmsKeyArn: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("gatewayKmsKeyArn")]
        public System.String? GatewayKmsKeyArn { get; set; }


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

    } // class AwsGatewayKmsKeyArnEntryInput
    #endregion

} // namespace RubrikSecurityCloud.Types