// ManagedVolumePatchConfigInput.cs
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
    #region ManagedVolumePatchConfigInput

    public class ManagedVolumePatchConfigInput: IInput
    {
        #region members

        //      C# -> List<System.String>? HostPatterns
        // GraphQL -> hostPatterns: [String!] (scalar)
        [JsonProperty("hostPatterns")]
        public List<System.String>? HostPatterns { get; set; }

        //      C# -> List<System.String>? NodeHint
        // GraphQL -> nodeHint: [String!] (scalar)
        [JsonProperty("nodeHint")]
        public List<System.String>? NodeHint { get; set; }

        //      C# -> System.String? SmbDomainName
        // GraphQL -> smbDomainName: String (scalar)
        [JsonProperty("smbDomainName")]
        public System.String? SmbDomainName { get; set; }

        //      C# -> List<System.String>? SmbValidIps
        // GraphQL -> smbValidIps: [String!] (scalar)
        [JsonProperty("smbValidIps")]
        public List<System.String>? SmbValidIps { get; set; }

        //      C# -> List<System.String>? SmbValidUsers
        // GraphQL -> smbValidUsers: [String!] (scalar)
        [JsonProperty("smbValidUsers")]
        public List<System.String>? SmbValidUsers { get; set; }


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

    } // class ManagedVolumePatchConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types