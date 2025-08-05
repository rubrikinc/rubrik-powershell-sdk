// CreateNfsReaderTargetInput.cs
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
    #region CreateNfsReaderTargetInput

    public class CreateNfsReaderTargetInput: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Host
        // GraphQL -> host: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("host")]
        public System.String? Host { get; set; }

        //      C# -> System.String? ExportDir
        // GraphQL -> exportDir: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("exportDir")]
        public System.String? ExportDir { get; set; }

        //      C# -> System.Int32? NfsVersion
        // GraphQL -> nfsVersion: Int (scalar)
        [JsonProperty("nfsVersion")]
        public System.Int32? NfsVersion { get; set; }

        //      C# -> AuthTypeEnum? NfsAuthType
        // GraphQL -> nfsAuthType: AuthTypeEnum! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("nfsAuthType")]
        public AuthTypeEnum? NfsAuthType { get; set; }

        //      C# -> System.String? OtherNfsOptions
        // GraphQL -> otherNfsOptions: String (scalar)
        [JsonProperty("otherNfsOptions")]
        public System.String? OtherNfsOptions { get; set; }

        //      C# -> System.Int32? FileLockPeriodInSeconds
        // GraphQL -> fileLockPeriodInSeconds: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("fileLockPeriodInSeconds")]
        public System.Int32? FileLockPeriodInSeconds { get; set; }

        //      C# -> System.String? DestinationFolder
        // GraphQL -> destinationFolder: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationFolder")]
        public System.String? DestinationFolder { get; set; }

        //      C# -> System.Boolean? IsConsolidationEnabled
        // GraphQL -> isConsolidationEnabled: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isConsolidationEnabled")]
        public System.Boolean? IsConsolidationEnabled { get; set; }

        //      C# -> System.String? EncryptionPassword
        // GraphQL -> encryptionPassword: String (scalar)
        [JsonProperty("encryptionPassword")]
        public System.String? EncryptionPassword { get; set; }

        //      C# -> ReaderRetrievalMethod? ReaderRetrievalMethod
        // GraphQL -> readerRetrievalMethod: ReaderRetrievalMethod! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("readerRetrievalMethod")]
        public ReaderRetrievalMethod? ReaderRetrievalMethod { get; set; }

        //      C# -> List<System.String>? ArchivalDataSourceIds
        // GraphQL -> archivalDataSourceIds: [String!] (scalar)
        [JsonProperty("archivalDataSourceIds")]
        public List<System.String>? ArchivalDataSourceIds { get; set; }


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

    } // class CreateNfsReaderTargetInput
    #endregion

} // namespace RubrikSecurityCloud.Types