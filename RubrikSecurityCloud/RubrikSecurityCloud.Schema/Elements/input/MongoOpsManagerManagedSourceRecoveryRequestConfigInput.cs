// MongoOpsManagerManagedSourceRecoveryRequestConfigInput.cs
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
    #region MongoOpsManagerManagedSourceRecoveryRequestConfigInput

    public class MongoOpsManagerManagedSourceRecoveryRequestConfigInput: IInput
    {
        #region members

        //      C# -> DateTime? RestoreTime
        // GraphQL -> restoreTime: DateTime (scalar)
        [JsonProperty("restoreTime")]
        public DateTime? RestoreTime { get; set; }

        //      C# -> System.String? OplogDumpDirPath
        // GraphQL -> oplogDumpDirPath: String (scalar)
        [JsonProperty("oplogDumpDirPath")]
        public System.String? OplogDumpDirPath { get; set; }

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

    } // class MongoOpsManagerManagedSourceRecoveryRequestConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types