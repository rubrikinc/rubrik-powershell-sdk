// SmbDomainJoinRequestInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:43.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region SmbDomainJoinRequestInput

    public class SmbDomainJoinRequestInput
    {
        #region members
        //      C# -> System.String? ComputerAccountName
        // GraphQL -> computerAccountName: String (scalar)
        [JsonProperty("computerAccountName")]
        public System.String? ComputerAccountName { get; set; }

        //      C# -> System.String? CreationOrganizationUnit
        // GraphQL -> creationOrganizationUnit: String (scalar)
        [JsonProperty("creationOrganizationUnit")]
        public System.String? CreationOrganizationUnit { get; set; }

        //      C# -> List<System.String>? DomainControllers
        // GraphQL -> domainControllers: [String!] (scalar)
        [JsonProperty("domainControllers")]
        public List<System.String>? DomainControllers { get; set; }

        //      C# -> System.Boolean? IsStickySmbService
        // GraphQL -> isStickySmbService: Boolean (scalar)
        [JsonProperty("isStickySmbService")]
        public System.Boolean? IsStickySmbService { get; set; }

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

    } // class SmbDomainJoinRequestInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types