// ClusterConfigInput.cs
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
    #region ClusterConfigInput

    public class ClusterConfigInput: IInput
    {
        #region members

        //      C# -> System.String? UserEmail
        // GraphQL -> userEmail: String (scalar)
        [JsonProperty("userEmail")]
        public System.String? UserEmail { get; set; }

        //      C# -> System.String? AdminPassword
        // GraphQL -> adminPassword: String (scalar)
        [JsonProperty("adminPassword")]
        public System.String? AdminPassword { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.Int32? NumNodes
        // GraphQL -> numNodes: Int (scalar)
        [JsonProperty("numNodes")]
        public System.Int32? NumNodes { get; set; }

        //      C# -> List<System.String>? DnsSearchDomains
        // GraphQL -> dnsSearchDomains: [String!] (scalar)
        [JsonProperty("dnsSearchDomains")]
        public List<System.String>? DnsSearchDomains { get; set; }

        //      C# -> List<System.String>? DnsNameServers
        // GraphQL -> dnsNameServers: [String!] (scalar)
        [JsonProperty("dnsNameServers")]
        public List<System.String>? DnsNameServers { get; set; }

        //      C# -> List<System.String>? NtpServers
        // GraphQL -> ntpServers: [String!] (scalar)
        [JsonProperty("ntpServers")]
        public List<System.String>? NtpServers { get; set; }

        //      C# -> AzureEsConfigInput? AzureEsConfig
        // GraphQL -> azureEsConfig: AzureEsConfigInput (input)
        [JsonProperty("azureEsConfig")]
        public AzureEsConfigInput? AzureEsConfig { get; set; }

        //      C# -> AwsEsConfigInput? AwsEsConfig
        // GraphQL -> awsEsConfig: AwsEsConfigInput (input)
        [JsonProperty("awsEsConfig")]
        public AwsEsConfigInput? AwsEsConfig { get; set; }


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

    } // class ClusterConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types