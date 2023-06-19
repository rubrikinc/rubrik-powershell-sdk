// AwsCloudComputeSettingsInput.cs
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
    #region AwsCloudComputeSettingsInput

    public class AwsCloudComputeSettingsInput: IInput
    {
        #region members

        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String (scalar)
        [JsonProperty("subnetId")]
        public System.String? SubnetId { get; set; }

        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String (scalar)
        [JsonProperty("vpcId")]
        public System.String? VpcId { get; set; }

        //      C# -> System.String? SecurityGroupId
        // GraphQL -> securityGroupId: String (scalar)
        [JsonProperty("securityGroupId")]
        public System.String? SecurityGroupId { get; set; }

        //      C# -> ProxySettingsInput? ComputeProxySettings
        // GraphQL -> computeProxySettings: ProxySettingsInput (input)
        [JsonProperty("computeProxySettings")]
        public ProxySettingsInput? ComputeProxySettings { get; set; }


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

    } // class AwsCloudComputeSettingsInput
    #endregion

} // namespace RubrikSecurityCloud.Types