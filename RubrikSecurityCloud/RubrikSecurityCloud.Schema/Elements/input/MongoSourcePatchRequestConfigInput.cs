// MongoSourcePatchRequestConfigInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:29.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region MongoSourcePatchRequestConfigInput

    public class MongoSourcePatchRequestConfigInput
    {
        #region members
        //      C# -> System.String? CaCertfilePath
        // GraphQL -> caCertfilePath: String (scalar)
        [JsonProperty("caCertfilePath")]
        public System.String? CaCertfilePath { get; set; }

        //      C# -> List<System.String>? IgnoreSecondaries
        // GraphQL -> ignoreSecondaries: [String!] (scalar)
        [JsonProperty("ignoreSecondaries")]
        public List<System.String>? IgnoreSecondaries { get; set; }

        //      C# -> System.String? SourceDriverPassword
        // GraphQL -> sourceDriverPassword: String (scalar)
        [JsonProperty("sourceDriverPassword")]
        public System.String? SourceDriverPassword { get; set; }

        //      C# -> System.String? SourceDriverUser
        // GraphQL -> sourceDriverUser: String (scalar)
        [JsonProperty("sourceDriverUser")]
        public System.String? SourceDriverUser { get; set; }

        //      C# -> System.String? SslKeyfilePath
        // GraphQL -> sslKeyfilePath: String (scalar)
        [JsonProperty("sslKeyfilePath")]
        public System.String? SslKeyfilePath { get; set; }

        //      C# -> System.String? SslCertfilePath
        // GraphQL -> sslCertfilePath: String (scalar)
        [JsonProperty("sslCertfilePath")]
        public System.String? SslCertfilePath { get; set; }

        //      C# -> MongoSslCertificateRequirement? SslCertificateRequired
        // GraphQL -> sslCertificateRequired: MongoSslCertificateRequirement (enum)
        [JsonProperty("sslCertificateRequired")]
        public MongoSslCertificateRequirement? SslCertificateRequired { get; set; }

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

    } // class MongoSourcePatchRequestConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types