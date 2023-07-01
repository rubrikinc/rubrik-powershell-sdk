// ActiveDirectoryLiveMountConfigInput.cs
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
    #region ActiveDirectoryLiveMountConfigInput

    public class ActiveDirectoryLiveMountConfigInput: IInput
    {
        #region members

        //      C# -> List<System.String>? ValidUsers
        // GraphQL -> validUsers: [String!] (scalar)
        [JsonProperty("validUsers")]
        public List<System.String>? ValidUsers { get; set; }

        //      C# -> List<System.String>? ValidIps
        // GraphQL -> validIps: [String!] (scalar)
        [JsonProperty("validIps")]
        public List<System.String>? ValidIps { get; set; }

        //      C# -> System.String? Password
        // GraphQL -> password: String (scalar)
        [JsonProperty("password")]
        public System.String? Password { get; set; }

        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String (scalar)
        [JsonProperty("domainName")]
        public System.String? DomainName { get; set; }

        //      C# -> System.String? Subnet
        // GraphQL -> subnet: String (scalar)
        [JsonProperty("subnet")]
        public System.String? Subnet { get; set; }


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

    } // class ActiveDirectoryLiveMountConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types