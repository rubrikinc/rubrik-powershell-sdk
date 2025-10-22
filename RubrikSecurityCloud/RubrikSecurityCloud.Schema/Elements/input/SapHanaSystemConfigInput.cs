// SapHanaSystemConfigInput.cs
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
    #region SapHanaSystemConfigInput

    public class SapHanaSystemConfigInput: IInput
    {
        #region members

        //      C# -> System.String? AzureFeatureId
        // GraphQL -> azureFeatureId: String (scalar)
        [JsonProperty("azureFeatureId")]
        public System.String? AzureFeatureId { get; set; }

        //      C# -> SapHanaSystemConfigBackupTriggerType? BackupTriggerType
        // GraphQL -> backupTriggerType: SapHanaSystemConfigBackupTriggerType (enum)
        [JsonProperty("backupTriggerType")]
        public SapHanaSystemConfigBackupTriggerType? BackupTriggerType { get; set; }

        //      C# -> SapHanaSystemAuthTypeSpecInput? AuthTypeSpec
        // GraphQL -> authTypeSpec: SapHanaSystemAuthTypeSpecInput (input)
        [JsonProperty("authTypeSpec")]
        public SapHanaSystemAuthTypeSpecInput? AuthTypeSpec { get; set; }

        //      C# -> SapHanaSystemDataPathSpecInput? DataPathSpec
        // GraphQL -> dataPathSpec: SapHanaSystemDataPathSpecInput (input)
        [JsonProperty("dataPathSpec")]
        public SapHanaSystemDataPathSpecInput? DataPathSpec { get; set; }

        //      C# -> List<System.String>? HostIds
        // GraphQL -> hostIds: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("hostIds")]
        public List<System.String>? HostIds { get; set; }

        //      C# -> System.String? InstanceNumber
        // GraphQL -> instanceNumber: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("instanceNumber")]
        public System.String? InstanceNumber { get; set; }

        //      C# -> System.String? Password
        // GraphQL -> password: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("password")]
        public System.String? Password { get; set; }

        //      C# -> System.String? Sid
        // GraphQL -> sid: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sid")]
        public System.String? Sid { get; set; }

        //      C# -> SapHanaSslInfoInput? SslInfo
        // GraphQL -> sslInfo: SapHanaSslInfoInput (input)
        [JsonProperty("sslInfo")]
        public SapHanaSslInfoInput? SslInfo { get; set; }

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

    } // class SapHanaSystemConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types