// UpdateGcpTargetInput.cs
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
    #region UpdateGcpTargetInput

    public class UpdateGcpTargetInput: IInput
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> GcpRegion? Region
        // GraphQL -> region: GcpRegion (enum)
        [JsonProperty("region")]
        public GcpRegion? Region { get; set; }

        //      C# -> GcpStorageClass? StorageClass
        // GraphQL -> storageClass: GcpStorageClass (enum)
        [JsonProperty("storageClass")]
        public GcpStorageClass? StorageClass { get; set; }

        //      C# -> System.String? Bucket
        // GraphQL -> bucket: String (scalar)
        [JsonProperty("bucket")]
        public System.String? Bucket { get; set; }

        //      C# -> System.String? EncryptionPassword
        // GraphQL -> encryptionPassword: String (scalar)
        [JsonProperty("encryptionPassword")]
        public System.String? EncryptionPassword { get; set; }

        //      C# -> System.String? ServiceAccountJsonKey
        // GraphQL -> serviceAccountJsonKey: String (scalar)
        [JsonProperty("serviceAccountJsonKey")]
        public System.String? ServiceAccountJsonKey { get; set; }

        //      C# -> ProxySettingsInput? ArchivalProxySettings
        // GraphQL -> archivalProxySettings: ProxySettingsInput (input)
        [JsonProperty("archivalProxySettings")]
        public ProxySettingsInput? ArchivalProxySettings { get; set; }

        //      C# -> System.Boolean? BypassProxy
        // GraphQL -> bypassProxy: Boolean (scalar)
        [JsonProperty("bypassProxy")]
        public System.Boolean? BypassProxy { get; set; }


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

    } // class UpdateGcpTargetInput
    #endregion

} // namespace RubrikSecurityCloud.Types