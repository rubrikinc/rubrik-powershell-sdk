// MongoRecoveryRequestConfigInput.cs
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
    #region MongoRecoveryRequestConfigInput

    public class MongoRecoveryRequestConfigInput: IInput
    {
        #region members

        //      C# -> System.String? Prefix
        // GraphQL -> prefix: String (scalar)
        [JsonProperty("prefix")]
        public System.String? Prefix { get; set; }

        //      C# -> System.String? RestoreDbPassword
        // GraphQL -> restoreDbPassword: String (scalar)
        [JsonProperty("restoreDbPassword")]
        public System.String? RestoreDbPassword { get; set; }

        //      C# -> System.String? RestoreDbUsername
        // GraphQL -> restoreDbUsername: String (scalar)
        [JsonProperty("restoreDbUsername")]
        public System.String? RestoreDbUsername { get; set; }

        //      C# -> System.Boolean? ShouldDropExistingCollection
        // GraphQL -> shouldDropExistingCollection: Boolean (scalar)
        [JsonProperty("shouldDropExistingCollection")]
        public System.Boolean? ShouldDropExistingCollection { get; set; }

        //      C# -> List<System.String>? SourceCollectionIds
        // GraphQL -> sourceCollectionIds: [String!] (scalar)
        [JsonProperty("sourceCollectionIds")]
        public List<System.String>? SourceCollectionIds { get; set; }

        //      C# -> List<System.String>? SourceDatabaseIds
        // GraphQL -> sourceDatabaseIds: [String!] (scalar)
        [JsonProperty("sourceDatabaseIds")]
        public List<System.String>? SourceDatabaseIds { get; set; }

        //      C# -> System.String? TargetCollectionName
        // GraphQL -> targetCollectionName: String (scalar)
        [JsonProperty("targetCollectionName")]
        public System.String? TargetCollectionName { get; set; }

        //      C# -> System.String? TargetDatabaseName
        // GraphQL -> targetDatabaseName: String (scalar)
        [JsonProperty("targetDatabaseName")]
        public System.String? TargetDatabaseName { get; set; }

        //      C# -> DateTime? VersionTime
        // GraphQL -> versionTime: DateTime (scalar)
        [JsonProperty("versionTime")]
        public DateTime? VersionTime { get; set; }

        //      C# -> System.Int64? RestoreThrottleInBytesPerSecond
        // GraphQL -> restoreThrottleInBytesPerSecond: Long (scalar)
        [JsonProperty("restoreThrottleInBytesPerSecond")]
        public System.Int64? RestoreThrottleInBytesPerSecond { get; set; }

        //      C# -> System.Boolean? IsRestoreWithIndex
        // GraphQL -> isRestoreWithIndex: Boolean (scalar)
        [JsonProperty("isRestoreWithIndex")]
        public System.Boolean? IsRestoreWithIndex { get; set; }

        //      C# -> MongoAuthenticationType? TargetAuthenticationType
        // GraphQL -> targetAuthenticationType: MongoAuthenticationType (enum)
        [JsonProperty("targetAuthenticationType")]
        public MongoAuthenticationType? TargetAuthenticationType { get; set; }

        //      C# -> System.String? SourceMongoClusterId
        // GraphQL -> sourceMongoClusterId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceMongoClusterId")]
        public System.String? SourceMongoClusterId { get; set; }

        //      C# -> System.String? TargetMongoClusterId
        // GraphQL -> targetMongoClusterId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetMongoClusterId")]
        public System.String? TargetMongoClusterId { get; set; }


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

    } // class MongoRecoveryRequestConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types