// LegalHoldQueryFilter.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:02.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region LegalHoldQueryFilter

    public class LegalHoldQueryFilter
    {
        #region members
        //      C# -> LegalHoldQueryFilterField? FilterField
        // GraphQL -> filterField: LegalHoldQueryFilterField (enum)
        [JsonProperty("filterField")]
        public LegalHoldQueryFilterField? FilterField { get; set; }

        //      C# -> DateTime? BeforeTime
        // GraphQL -> beforeTime: DateTime (scalar)
        [JsonProperty("beforeTime")]
        public DateTime? BeforeTime { get; set; }

        //      C# -> DateTime? AfterTime
        // GraphQL -> afterTime: DateTime (scalar)
        [JsonProperty("afterTime")]
        public DateTime? AfterTime { get; set; }

        //      C# -> System.String? SnappableName
        // GraphQL -> snappableName: String (scalar)
        [JsonProperty("snappableName")]
        public System.String? SnappableName { get; set; }

        //      C# -> List<ManagedObjectType>? SnappableTypes
        // GraphQL -> snappableTypes: [ManagedObjectType!] (enum)
        [JsonProperty("snappableTypes")]
        public List<ManagedObjectType>? SnappableTypes { get; set; }

        //      C# -> List<SnapshotTypeEnum>? SnapshotTypes
        // GraphQL -> snapshotTypes: [SnapshotTypeEnum!] (enum)
        [JsonProperty("snapshotTypes")]
        public List<SnapshotTypeEnum>? SnapshotTypes { get; set; }

        //      C# -> List<SnapshotCustomization>? SnapshotCustomizations
        // GraphQL -> snapshotCustomizations: [SnapshotCustomization!] (enum)
        [JsonProperty("snapshotCustomizations")]
        public List<SnapshotCustomization>? SnapshotCustomizations { get; set; }

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

    } // class LegalHoldQueryFilter
    #endregion

} // namespace Rubrik.SecurityCloud.Types