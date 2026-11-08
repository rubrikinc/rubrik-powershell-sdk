// AwsApplicationServiceConfigurationInput.cs
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
    #region AwsApplicationServiceConfigurationInput

    public class AwsApplicationServiceConfigurationInput: IInput
    {
        #region members

        //      C# -> System.Boolean? Ec2Enabled
        // GraphQL -> ec2Enabled: Boolean (scalar)
        [JsonProperty("ec2Enabled")]
        public System.Boolean? Ec2Enabled { get; set; }

        //      C# -> System.Boolean? RdsEnabled
        // GraphQL -> rdsEnabled: Boolean (scalar)
        [JsonProperty("rdsEnabled")]
        public System.Boolean? RdsEnabled { get; set; }

        //      C# -> System.Boolean? EbsEnabled
        // GraphQL -> ebsEnabled: Boolean (scalar)
        [JsonProperty("ebsEnabled")]
        public System.Boolean? EbsEnabled { get; set; }

        //      C# -> System.Boolean? ElbEnabled
        // GraphQL -> elbEnabled: Boolean (scalar)
        [JsonProperty("elbEnabled")]
        public System.Boolean? ElbEnabled { get; set; }

        //      C# -> System.Boolean? S3Enabled
        // GraphQL -> s3Enabled: Boolean (scalar)
        [JsonProperty("s3Enabled")]
        public System.Boolean? S3Enabled { get; set; }

        //      C# -> System.Boolean? SecretsEnabled
        // GraphQL -> secretsEnabled: Boolean (scalar)
        [JsonProperty("secretsEnabled")]
        public System.Boolean? SecretsEnabled { get; set; }

        //      C# -> System.Boolean? ElasticacheEnabled
        // GraphQL -> elasticacheEnabled: Boolean (scalar)
        [JsonProperty("elasticacheEnabled")]
        public System.Boolean? ElasticacheEnabled { get; set; }

        //      C# -> System.Boolean? EksEnabled
        // GraphQL -> eksEnabled: Boolean (scalar)
        [JsonProperty("eksEnabled")]
        public System.Boolean? EksEnabled { get; set; }

        //      C# -> System.Boolean? EcrEnabled
        // GraphQL -> ecrEnabled: Boolean (scalar)
        [JsonProperty("ecrEnabled")]
        public System.Boolean? EcrEnabled { get; set; }

        //      C# -> System.Boolean? LambdaEnabled
        // GraphQL -> lambdaEnabled: Boolean (scalar)
        [JsonProperty("lambdaEnabled")]
        public System.Boolean? LambdaEnabled { get; set; }

        //      C# -> System.Boolean? IsEcsEnabled
        // GraphQL -> isEcsEnabled: Boolean (scalar)
        [JsonProperty("isEcsEnabled")]
        public System.Boolean? IsEcsEnabled { get; set; }


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

    } // class AwsApplicationServiceConfigurationInput
    #endregion

} // namespace RubrikSecurityCloud.Types