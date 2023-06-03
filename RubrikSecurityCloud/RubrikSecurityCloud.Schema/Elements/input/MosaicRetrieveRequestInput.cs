// MosaicRetrieveRequestInput.cs
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
    #region MosaicRetrieveRequestInput

    public class MosaicRetrieveRequestInput: IInput
    {
        #region members

        //      C# -> MosaicDatabaseManagementObjectInput? DestinationManagementObjects
        // GraphQL -> destinationManagementObjects: MosaicDatabaseManagementObjectInput (input)
        [JsonProperty("destinationManagementObjects")]
        public MosaicDatabaseManagementObjectInput? DestinationManagementObjects { get; set; }

        //      C# -> System.String? DestinationSourceName
        // GraphQL -> destinationSourceName: String (scalar)
        [JsonProperty("destinationSourceName")]
        public System.String? DestinationSourceName { get; set; }

        //      C# -> System.String? KeyspaceConfig
        // GraphQL -> keyspaceConfig: String (scalar)
        [JsonProperty("keyspaceConfig")]
        public System.String? KeyspaceConfig { get; set; }

        //      C# -> System.String? MaxDiskUsage
        // GraphQL -> maxDiskUsage: String (scalar)
        [JsonProperty("maxDiskUsage")]
        public System.String? MaxDiskUsage { get; set; }

        //      C# -> System.String? RestoreDbUserPwd
        // GraphQL -> restoreDbUserPwd: String (scalar)
        [JsonProperty("restoreDbUserPwd")]
        public System.String? RestoreDbUserPwd { get; set; }

        //      C# -> System.String? RestoreDbUsername
        // GraphQL -> restoreDbUsername: String (scalar)
        [JsonProperty("restoreDbUsername")]
        public System.String? RestoreDbUsername { get; set; }

        //      C# -> System.Int32? StartTimestamp
        // GraphQL -> startTimestamp: Int (scalar)
        [JsonProperty("startTimestamp")]
        public System.Int32? StartTimestamp { get; set; }

        //      C# -> System.String? TargetEncryptionKey
        // GraphQL -> targetEncryptionKey: String (scalar)
        [JsonProperty("targetEncryptionKey")]
        public System.String? TargetEncryptionKey { get; set; }

        //      C# -> System.String? TargetQuery
        // GraphQL -> targetQuery: String (scalar)
        [JsonProperty("targetQuery")]
        public System.String? TargetQuery { get; set; }

        //      C# -> MosaicRetrieveRequestSourceType? SourceType
        // GraphQL -> sourceType: MosaicRetrieveRequestSourceType (enum)
        [JsonProperty("sourceType")]
        public MosaicRetrieveRequestSourceType? SourceType { get; set; }

        //      C# -> System.String? DestinationPath
        // GraphQL -> destinationPath: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("destinationPath")]
        public System.String? DestinationPath { get; set; }

        //      C# -> MosaicDatabaseManagementObjectInput? ManagementObjects
        // GraphQL -> managementObjects: MosaicDatabaseManagementObjectInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("managementObjects")]
        public MosaicDatabaseManagementObjectInput? ManagementObjects { get; set; }

        //      C# -> System.Boolean? ParameterEncoded
        // GraphQL -> parameterEncoded: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("parameterEncoded")]
        public System.Boolean? ParameterEncoded { get; set; }

        //      C# -> System.String? SourceName
        // GraphQL -> sourceName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceName")]
        public System.String? SourceName { get; set; }

        //      C# -> System.Int32? VersionTime
        // GraphQL -> versionTime: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("versionTime")]
        public System.Int32? VersionTime { get; set; }


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

    } // class MosaicRetrieveRequestInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types