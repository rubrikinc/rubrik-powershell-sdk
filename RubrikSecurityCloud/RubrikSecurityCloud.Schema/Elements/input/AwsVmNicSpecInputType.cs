// AwsVmNicSpecInputType.cs
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
    #region AwsVmNicSpecInputType

    public class AwsVmNicSpecInputType: IInput
    {
        #region members

        //      C# -> System.Int32? Key
        // GraphQL -> key: Int (scalar)
        [JsonProperty("key")]
        public System.Int32? Key { get; set; }

        //      C# -> System.String? Ipv4Address
        // GraphQL -> ipv4Address: String (scalar)
        [JsonProperty("ipv4Address")]
        public System.String? Ipv4Address { get; set; }

        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String (scalar)
        [JsonProperty("subnetId")]
        public System.String? SubnetId { get; set; }

        //      C# -> System.String? AwsSubnetId
        // GraphQL -> awsSubnetId: String (scalar)
        [JsonProperty("awsSubnetId")]
        public System.String? AwsSubnetId { get; set; }

        //      C# -> System.String? SecurityGroupId
        // GraphQL -> securityGroupId: String (scalar)
        [JsonProperty("securityGroupId")]
        public System.String? SecurityGroupId { get; set; }

        //      C# -> System.String? AwsSecurityGroupId
        // GraphQL -> awsSecurityGroupId: String (scalar)
        [JsonProperty("awsSecurityGroupId")]
        public System.String? AwsSecurityGroupId { get; set; }


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

    } // class AwsVmNicSpecInputType
    #endregion

} // namespace RubrikSecurityCloud.Types