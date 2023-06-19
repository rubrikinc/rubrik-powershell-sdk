// AddNodesConfigInput.cs
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
    #region AddNodesConfigInput

    public class AddNodesConfigInput: IInput
    {
        #region members

        //      C# -> System.String? EncryptionPassword
        // GraphQL -> encryptionPassword: String (scalar)
        [JsonProperty("encryptionPassword")]
        public System.String? EncryptionPassword { get; set; }

        //      C# -> System.Boolean? IsIpv4ManualDiscoveryMode
        // GraphQL -> isIpv4ManualDiscoveryMode: Boolean (scalar)
        [JsonProperty("isIpv4ManualDiscoveryMode")]
        public System.Boolean? IsIpv4ManualDiscoveryMode { get; set; }

        //      C# -> System.Boolean? IsLinkLocalIpv4Mode
        // GraphQL -> isLinkLocalIpv4Mode: Boolean (scalar)
        [JsonProperty("isLinkLocalIpv4Mode")]
        public System.Boolean? IsLinkLocalIpv4Mode { get; set; }

        //      C# -> System.String? IpmiPassword
        // GraphQL -> ipmiPassword: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("ipmiPassword")]
        public System.String? IpmiPassword { get; set; }


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

    } // class AddNodesConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types