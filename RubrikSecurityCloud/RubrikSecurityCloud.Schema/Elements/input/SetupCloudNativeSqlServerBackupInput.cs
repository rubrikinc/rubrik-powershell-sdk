// SetupCloudNativeSqlServerBackupInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:16.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region SetupCloudNativeSqlServerBackupInput

    public class SetupCloudNativeSqlServerBackupInput
    {
        #region members
        //      C# -> List<System.String>? DatabaseIds
        // GraphQL -> databaseIds: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("databaseIds")]
        public List<System.String>? DatabaseIds { get; set; }

        //      C# -> LoginCredentials? AdminCredentials
        // GraphQL -> adminCredentials: LoginCredentials (input)
        [JsonProperty("adminCredentials")]
        public LoginCredentials? AdminCredentials { get; set; }

        //      C# -> SqlAuthenticationMechanism? AuthMechanism
        // GraphQL -> authMechanism: SqlAuthenticationMechanism (enum)
        [JsonProperty("authMechanism")]
        public SqlAuthenticationMechanism? AuthMechanism { get; set; }

        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String (scalar)
        [JsonProperty("sessionId")]
        public System.String? SessionId { get; set; }

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

    } // class SetupCloudNativeSqlServerBackupInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types