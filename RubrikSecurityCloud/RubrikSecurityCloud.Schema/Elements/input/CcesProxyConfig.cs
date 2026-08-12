// CcesProxyConfig.cs
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
    #region CcesProxyConfig

    public class CcesProxyConfig: IInput
    {
        #region members

        //      C# -> ProxyProtocol? Protocol
        // GraphQL -> protocol: ProxyProtocol (enum)
        [JsonProperty("protocol")]
        public ProxyProtocol? Protocol { get; set; }

        //      C# -> System.String? Server
        // GraphQL -> server: String (scalar)
        [JsonProperty("server")]
        public System.String? Server { get; set; }

        //      C# -> System.Int32? Port
        // GraphQL -> port: Int (scalar)
        [JsonProperty("port")]
        public System.Int32? Port { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> CcesProxyPasswordSecretRefInput? ProxyPasswordSecretRef
        // GraphQL -> proxyPasswordSecretRef: CcesProxyPasswordSecretRefInput (input)
        [JsonProperty("proxyPasswordSecretRef")]
        public CcesProxyPasswordSecretRefInput? ProxyPasswordSecretRef { get; set; }


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

    } // class CcesProxyConfig
    #endregion

} // namespace RubrikSecurityCloud.Types