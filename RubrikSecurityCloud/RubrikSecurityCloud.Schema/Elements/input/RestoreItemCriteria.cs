// RestoreItemCriteria.cs
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
    #region RestoreItemCriteria

    public class RestoreItemCriteria: IInput
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.Int32? SequenceNumber
        // GraphQL -> sequenceNumber: Int (scalar)
        [JsonProperty("sequenceNumber")]
        public System.Int32? SequenceNumber { get; set; }

        //      C# -> DateTime? ClosestSnapshotTime
        // GraphQL -> closestSnapshotTime: DateTime (scalar)
        [JsonProperty("closestSnapshotTime")]
        public DateTime? ClosestSnapshotTime { get; set; }

        //      C# -> System.Int32? RecordLimit
        // GraphQL -> recordLimit: Int (scalar)
        [JsonProperty("recordLimit")]
        public System.Int32? RecordLimit { get; set; }

        //      C# -> SaasSortByParam? SortByParam
        // GraphQL -> sortByParam: SaasSortByParam (input)
        [JsonProperty("sortByParam")]
        public SaasSortByParam? SortByParam { get; set; }

        //      C# -> RecordFilter? ItemFilters
        // GraphQL -> itemFilters: RecordFilter! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("itemFilters")]
        public RecordFilter? ItemFilters { get; set; }

        //      C# -> ChildRestoreItemCriteria? ChildRestoreItemCriteria
        // GraphQL -> childRestoreItemCriteria: ChildRestoreItemCriteria (input)
        [JsonProperty("childRestoreItemCriteria")]
        public ChildRestoreItemCriteria? ChildRestoreItemCriteria { get; set; }


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

    } // class RestoreItemCriteria
    #endregion

} // namespace RubrikSecurityCloud.Types