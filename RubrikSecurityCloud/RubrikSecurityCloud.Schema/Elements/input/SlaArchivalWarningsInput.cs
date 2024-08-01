// SlaArchivalWarningsInput.cs
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
    #region SlaArchivalWarningsInput

    public class SlaArchivalWarningsInput: IInput
    {
        #region members

        //      C# -> GlobalSnapshotScheduleInput? SnapshotSchedule
        // GraphQL -> snapshotSchedule: GlobalSnapshotScheduleInput (input)
        [JsonProperty("snapshotSchedule")]
        public GlobalSnapshotScheduleInput? SnapshotSchedule { get; set; }

        //      C# -> System.Int32? ArchivalThreshold
        // GraphQL -> archivalThreshold: Int (scalar)
        [JsonProperty("archivalThreshold")]
        public System.Int32? ArchivalThreshold { get; set; }

        //      C# -> RetentionUnit? ArchivalThresholdUnit
        // GraphQL -> archivalThresholdUnit: RetentionUnit (enum)
        [JsonProperty("archivalThresholdUnit")]
        public RetentionUnit? ArchivalThresholdUnit { get; set; }

        //      C# -> System.String? ArchivalGroupId
        // GraphQL -> archivalGroupId: String (scalar)
        [JsonProperty("archivalGroupId")]
        public System.String? ArchivalGroupId { get; set; }

        //      C# -> List<ArchivalLocationToClusterMappingInput>? ArchivalLocationToClusterMapping
        // GraphQL -> archivalLocationToClusterMapping: [ArchivalLocationToClusterMappingInput!] (input)
        [JsonProperty("archivalLocationToClusterMapping")]
        public List<ArchivalLocationToClusterMappingInput>? ArchivalLocationToClusterMapping { get; set; }

        //      C# -> List<RetentionUnit>? Frequencies
        // GraphQL -> frequencies: [RetentionUnit!] (enum)
        [JsonProperty("frequencies")]
        public List<RetentionUnit>? Frequencies { get; set; }


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

    } // class SlaArchivalWarningsInput
    #endregion

} // namespace RubrikSecurityCloud.Types