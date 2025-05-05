// M365BackupStorageObjectSearchRestorePointsInput.cs
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
    #region M365BackupStorageObjectSearchRestorePointsInput

    public class M365BackupStorageObjectSearchRestorePointsInput: IInput
    {
        #region members

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> TimeSpanFilter? RangeFilter
        // GraphQL -> rangeFilter: TimeSpanFilter! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("rangeFilter")]
        public TimeSpanFilter? RangeFilter { get; set; }

        //      C# -> RestorePointTagType? RestorePointTagType
        // GraphQL -> restorePointTagType: RestorePointTagType (enum)
        [JsonProperty("restorePointTagType")]
        public RestorePointTagType? RestorePointTagType { get; set; }

        //      C# -> RestorePointPreferenceType? RestorePointPreferenceType
        // GraphQL -> restorePointPreferenceType: RestorePointPreferenceType (enum)
        [JsonProperty("restorePointPreferenceType")]
        public RestorePointPreferenceType? RestorePointPreferenceType { get; set; }


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

    } // class M365BackupStorageObjectSearchRestorePointsInput
    #endregion

} // namespace RubrikSecurityCloud.Types