// AzureSqlDatabaseDbPitExport.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region AzureSqlDatabaseDbPitExport

    public class AzureSqlDatabaseDbPitExport: IInput
    {
        #region members

        //      C# -> DateTime? RestorePointInTime
        // GraphQL -> restorePointInTime: DateTime! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("restorePointInTime")]
        public DateTime? RestorePointInTime { get; set; }

        //      C# -> AzureSqlBackupStorageRedundancyType? DbBackupRedundancy
        // GraphQL -> dbBackupRedundancy: AzureSqlBackupStorageRedundancyType (enum)
        [JsonProperty("dbBackupRedundancy")]
        public AzureSqlBackupStorageRedundancyType? DbBackupRedundancy { get; set; }


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

    } // class AzureSqlDatabaseDbPitExport
    #endregion

} // namespace Rubrik.SecurityCloud.Types