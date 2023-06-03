// CreateConfigProtectionSetupInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region CreateConfigProtectionSetupInput

    public class CreateConfigProtectionSetupInput: IInput
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? EncryptionPassword
        // GraphQL -> encryptionPassword: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("encryptionPassword")]
        public System.String? EncryptionPassword { get; set; }

        //      C# -> ConfigProtectionCaCert? CaCertificate
        // GraphQL -> caCertificate: ConfigProtectionCaCert (input)
        [JsonProperty("caCertificate")]
        public ConfigProtectionCaCert? CaCertificate { get; set; }

        //      C# -> System.String? ReplicationTargetUuid
        // GraphQL -> replicationTargetUuid: UUID (scalar)
        [JsonProperty("replicationTargetUuid")]
        public System.String? ReplicationTargetUuid { get; set; }

        //      C# -> UploadLocationType? UploadLocationType
        // GraphQL -> uploadLocationType: UploadLocationType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("uploadLocationType")]
        public UploadLocationType? UploadLocationType { get; set; }


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

    } // class CreateConfigProtectionSetupInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types