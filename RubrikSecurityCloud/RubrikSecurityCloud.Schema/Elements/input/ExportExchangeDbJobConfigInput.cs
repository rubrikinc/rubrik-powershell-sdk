// ExportExchangeDbJobConfigInput.cs
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
    #region ExportExchangeDbJobConfigInput

    public class ExportExchangeDbJobConfigInput: IInput
    {
        #region members

        //      C# -> System.String? TargetHostId
        // GraphQL -> targetHostId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetHostId")]
        public System.String? TargetHostId { get; set; }

        //      C# -> System.String? TargetLogFolderPath
        // GraphQL -> targetLogFolderPath: String (scalar)
        [JsonProperty("targetLogFolderPath")]
        public System.String? TargetLogFolderPath { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? TargetDatabaseName
        // GraphQL -> targetDatabaseName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetDatabaseName")]
        public System.String? TargetDatabaseName { get; set; }

        //      C# -> System.String? TargetEdbFilePath
        // GraphQL -> targetEdbFilePath: String (scalar)
        [JsonProperty("targetEdbFilePath")]
        public System.String? TargetEdbFilePath { get; set; }


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

    } // class ExportExchangeDbJobConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types