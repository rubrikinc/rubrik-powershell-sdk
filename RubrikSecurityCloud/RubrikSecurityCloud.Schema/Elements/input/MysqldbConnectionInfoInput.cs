// MysqldbConnectionInfoInput.cs
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
    #region MysqldbConnectionInfoInput

    public class MysqldbConnectionInfoInput: IInput
    {
        #region members

        //      C# -> System.String? SocketFilePath
        // GraphQL -> socketFilePath: String (scalar)
        [JsonProperty("socketFilePath")]
        public System.String? SocketFilePath { get; set; }

        //      C# -> System.String? SystemUsername
        // GraphQL -> systemUsername: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("systemUsername")]
        public System.String? SystemUsername { get; set; }

        //      C# -> MysqldbAuthenticationType? AuthenticationType
        // GraphQL -> authenticationType: MysqldbAuthenticationType (enum)
        [JsonProperty("authenticationType")]
        public MysqldbAuthenticationType? AuthenticationType { get; set; }

        //      C# -> System.String? BindIpAddress
        // GraphQL -> bindIpAddress: String (scalar)
        [JsonProperty("bindIpAddress")]
        public System.String? BindIpAddress { get; set; }

        //      C# -> MysqldbSslConfigInput? SslConfig
        // GraphQL -> sslConfig: MysqldbSslConfigInput (input)
        [JsonProperty("sslConfig")]
        public MysqldbSslConfigInput? SslConfig { get; set; }

        //      C# -> System.String? Password
        // GraphQL -> password: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("password")]
        public System.String? Password { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("username")]
        public System.String? Username { get; set; }


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

    } // class MysqldbConnectionInfoInput
    #endregion

} // namespace RubrikSecurityCloud.Types