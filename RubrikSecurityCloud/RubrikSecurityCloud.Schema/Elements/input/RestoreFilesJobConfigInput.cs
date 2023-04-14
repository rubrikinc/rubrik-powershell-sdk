// RestoreFilesJobConfigInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region RestoreFilesJobConfigInput

    public class RestoreFilesJobConfigInput: IInput
    {
        #region members

        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String (scalar)
        [JsonProperty("domainName")]
        public System.String? DomainName { get; set; }

        //      C# -> System.Boolean? IgnoreErrors
        // GraphQL -> ignoreErrors: Boolean (scalar)
        [JsonProperty("ignoreErrors")]
        public System.Boolean? IgnoreErrors { get; set; }

        //      C# -> System.String? Password
        // GraphQL -> password: String (scalar)
        [JsonProperty("password")]
        public System.String? Password { get; set; }

        //      C# -> System.Boolean? ShouldSaveCredentials
        // GraphQL -> shouldSaveCredentials: Boolean (scalar)
        [JsonProperty("shouldSaveCredentials")]
        public System.Boolean? ShouldSaveCredentials { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> System.String? DestObjectId
        // GraphQL -> destObjectId: String (scalar)
        [JsonProperty("destObjectId")]
        public System.String? DestObjectId { get; set; }

        //      C# -> System.Boolean? ShouldRestoreXattrs
        // GraphQL -> shouldRestoreXAttrs: Boolean (scalar)
        [JsonProperty("shouldRestoreXAttrs")]
        public System.Boolean? ShouldRestoreXattrs { get; set; }

        //      C# -> System.Boolean? ShouldUseAgent
        // GraphQL -> shouldUseAgent: Boolean (scalar)
        [JsonProperty("shouldUseAgent")]
        public System.Boolean? ShouldUseAgent { get; set; }

        //      C# -> System.String? GuestCredentialId
        // GraphQL -> guestCredentialId: String (scalar)
        [JsonProperty("guestCredentialId")]
        public System.String? GuestCredentialId { get; set; }

        //      C# -> List<VmRestorePathPairInput>? RestoreConfig
        // GraphQL -> restoreConfig: [VmRestorePathPairInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("restoreConfig")]
        public List<VmRestorePathPairInput>? RestoreConfig { get; set; }


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

    } // class RestoreFilesJobConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types