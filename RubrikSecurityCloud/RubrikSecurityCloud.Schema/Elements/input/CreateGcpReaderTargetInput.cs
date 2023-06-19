// CreateGcpReaderTargetInput.cs
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
    #region CreateGcpReaderTargetInput

    public class CreateGcpReaderTargetInput: IInput
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> GcpRegion? Region
        // GraphQL -> region: GcpRegion! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("region")]
        public GcpRegion? Region { get; set; }

        //      C# -> GcpStorageClass? StorageClass
        // GraphQL -> storageClass: GcpStorageClass! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("storageClass")]
        public GcpStorageClass? StorageClass { get; set; }

        //      C# -> System.String? Bucket
        // GraphQL -> bucket: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("bucket")]
        public System.String? Bucket { get; set; }

        //      C# -> System.String? EncryptionPassword
        // GraphQL -> encryptionPassword: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("encryptionPassword")]
        public System.String? EncryptionPassword { get; set; }

        //      C# -> System.String? ServiceAccountJsonKey
        // GraphQL -> serviceAccountJsonKey: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("serviceAccountJsonKey")]
        public System.String? ServiceAccountJsonKey { get; set; }

        //      C# -> ProxySettingsInput? ArchivalProxySettings
        // GraphQL -> archivalProxySettings: ProxySettingsInput (input)
        [JsonProperty("archivalProxySettings")]
        public ProxySettingsInput? ArchivalProxySettings { get; set; }

        //      C# -> ReaderRetrievalMethod? ReaderRetrievalMethod
        // GraphQL -> readerRetrievalMethod: ReaderRetrievalMethod! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("readerRetrievalMethod")]
        public ReaderRetrievalMethod? ReaderRetrievalMethod { get; set; }

        //      C# -> System.Boolean? BypassProxy
        // GraphQL -> bypassProxy: Boolean! (scalar)
        [Required]
        [JsonRequired]
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

    } // class CreateGcpReaderTargetInput
    #endregion

} // namespace RubrikSecurityCloud.Types