// RecoverToEndOfBackupDb2DbConfigInput.cs
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
    #region RecoverToEndOfBackupDb2DbConfigInput

    public class RecoverToEndOfBackupDb2DbConfigInput: IInput
    {
        #region members

        //      C# -> System.String? TmpDirectoryPath
        // GraphQL -> tmpDirectoryPath: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("tmpDirectoryPath")]
        public System.String? TmpDirectoryPath { get; set; }

        //      C# -> System.Int32? Sessions
        // GraphQL -> sessions: Int (scalar)
        [JsonProperty("sessions")]
        public System.Int32? Sessions { get; set; }

        //      C# -> System.String? SourceDbId
        // GraphQL -> sourceDbId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceDbId")]
        public System.String? SourceDbId { get; set; }

        //      C# -> System.String? TargetInstanceId
        // GraphQL -> targetInstanceId: String (scalar)
        [JsonProperty("targetInstanceId")]
        public System.String? TargetInstanceId { get; set; }

        //      C# -> System.String? RemoteLocationId
        // GraphQL -> remoteLocationId: String (scalar)
        [JsonProperty("remoteLocationId")]
        public System.String? RemoteLocationId { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? TargetDbName
        // GraphQL -> targetDbName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetDbName")]
        public System.String? TargetDbName { get; set; }

        //      C# -> System.String? TargetDatabaseDirectoryPath
        // GraphQL -> targetDatabaseDirectoryPath: String (scalar)
        [JsonProperty("targetDatabaseDirectoryPath")]
        public System.String? TargetDatabaseDirectoryPath { get; set; }


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

    } // class RecoverToEndOfBackupDb2DbConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types