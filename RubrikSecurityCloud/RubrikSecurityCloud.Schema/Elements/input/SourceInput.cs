// SourceInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:15.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region SourceInput

    public class SourceInput
    {
        #region members
        //      C# -> System.Boolean? Async
        // GraphQL -> async: Boolean (scalar)
        [JsonProperty("async")]
        public System.Boolean? Async { get; set; }

        //      C# -> List<System.String>? CassandraYaml
        // GraphQL -> cassandraYaml: [String!] (scalar)
        [JsonProperty("cassandraYaml")]
        public List<System.String>? CassandraYaml { get; set; }

        //      C# -> List<System.String>? DseYaml
        // GraphQL -> dseYaml: [String!] (scalar)
        [JsonProperty("dseYaml")]
        public List<System.String>? DseYaml { get; set; }

        //      C# -> System.Boolean? EnableSsl
        // GraphQL -> enableSsl: Boolean (scalar)
        [JsonProperty("enableSsl")]
        public System.Boolean? EnableSsl { get; set; }

        //      C# -> System.String? HttpsCertificate
        // GraphQL -> httpsCertificate: String (scalar)
        [JsonProperty("httpsCertificate")]
        public System.String? HttpsCertificate { get; set; }

        //      C# -> List<System.String>? IgnoreSecondaries
        // GraphQL -> ignoreSecondaries: [String!] (scalar)
        [JsonProperty("ignoreSecondaries")]
        public List<System.String>? IgnoreSecondaries { get; set; }

        //      C# -> System.String? JmxPassword
        // GraphQL -> jmxPassword: String (scalar)
        [JsonProperty("jmxPassword")]
        public System.String? JmxPassword { get; set; }

        //      C# -> System.String? JmxUser
        // GraphQL -> jmxUser: String (scalar)
        [JsonProperty("jmxUser")]
        public System.String? JmxUser { get; set; }

        //      C# -> System.Boolean? ParameterEncoded
        // GraphQL -> parameterEncoded: Boolean (scalar)
        [JsonProperty("parameterEncoded")]
        public System.Boolean? ParameterEncoded { get; set; }

        //      C# -> System.String? SourceAuthKey
        // GraphQL -> sourceAuthKey: String (scalar)
        [JsonProperty("sourceAuthKey")]
        public System.String? SourceAuthKey { get; set; }

        //      C# -> System.String? SourceAuthKeyfile
        // GraphQL -> sourceAuthKeyfile: String (scalar)
        [JsonProperty("sourceAuthKeyfile")]
        public System.String? SourceAuthKeyfile { get; set; }

        //      C# -> System.String? SourceAuthPassphrase
        // GraphQL -> sourceAuthPassphrase: String (scalar)
        [JsonProperty("sourceAuthPassphrase")]
        public System.String? SourceAuthPassphrase { get; set; }

        //      C# -> System.String? SourceDriverPassword
        // GraphQL -> sourceDriverPassword: String (scalar)
        [JsonProperty("sourceDriverPassword")]
        public System.String? SourceDriverPassword { get; set; }

        //      C# -> System.String? SourceDriverUser
        // GraphQL -> sourceDriverUser: String (scalar)
        [JsonProperty("sourceDriverUser")]
        public System.String? SourceDriverUser { get; set; }

        //      C# -> System.String? SourceHttpsPort
        // GraphQL -> sourceHttpsPort: String (scalar)
        [JsonProperty("sourceHttpsPort")]
        public System.String? SourceHttpsPort { get; set; }

        //      C# -> System.String? SourcePassword
        // GraphQL -> sourcePassword: String (scalar)
        [JsonProperty("sourcePassword")]
        public System.String? SourcePassword { get; set; }

        //      C# -> System.String? SourcePort
        // GraphQL -> sourcePort: String (scalar)
        [JsonProperty("sourcePort")]
        public System.String? SourcePort { get; set; }

        //      C# -> System.String? SourceRpcPort
        // GraphQL -> sourceRpcPort: String (scalar)
        [JsonProperty("sourceRpcPort")]
        public System.String? SourceRpcPort { get; set; }

        //      C# -> System.String? SourceSshPort
        // GraphQL -> sourceSshPort: String (scalar)
        [JsonProperty("sourceSshPort")]
        public System.String? SourceSshPort { get; set; }

        //      C# -> System.String? SourceUser
        // GraphQL -> sourceUser: String (scalar)
        [JsonProperty("sourceUser")]
        public System.String? SourceUser { get; set; }

        //      C# -> System.String? SslCaCerts
        // GraphQL -> sslCaCerts: String (scalar)
        [JsonProperty("sslCaCerts")]
        public System.String? SslCaCerts { get; set; }

        //      C# -> System.String? SslCertfile
        // GraphQL -> sslCertfile: String (scalar)
        [JsonProperty("sslCertfile")]
        public System.String? SslCertfile { get; set; }

        //      C# -> System.String? SslKeyfile
        // GraphQL -> sslKeyfile: String (scalar)
        [JsonProperty("sslKeyfile")]
        public System.String? SslKeyfile { get; set; }

        //      C# -> SourceSourceType? SourceType
        // GraphQL -> sourceType: SourceSourceType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceType")]
        public SourceSourceType? SourceType { get; set; }

        //      C# -> SourceSslCertReqs? SslCertReqs
        // GraphQL -> sslCertReqs: SourceSslCertReqs (enum)
        [JsonProperty("sslCertReqs")]
        public SourceSslCertReqs? SslCertReqs { get; set; }

        //      C# -> List<System.String>? SourceIp
        // GraphQL -> sourceIp: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceIp")]
        public List<System.String>? SourceIp { get; set; }

        //      C# -> System.String? SourceName
        // GraphQL -> sourceName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceName")]
        public System.String? SourceName { get; set; }

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

    } // class SourceInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types