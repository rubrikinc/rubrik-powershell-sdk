// CdmSnapshotFilterInput.cs
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
    #region CdmSnapshotFilterInput

    public class CdmSnapshotFilterInput: IInput
    {
        #region members

        //      C# -> List<System.String>? ClusterUuid
        // GraphQL -> clusterUuid: [UUID!] (scalar)
        [JsonProperty("clusterUuid")]
        public List<System.String>? ClusterUuid { get; set; }

        //      C# -> List<System.String>? SnappableId
        // GraphQL -> snappableId: [String!] (scalar)
        [JsonProperty("snappableId")]
        public List<System.String>? SnappableId { get; set; }

        //      C# -> List<System.String>? SnapshotId
        // GraphQL -> snapshotId: [UUID!] (scalar)
        [JsonProperty("snapshotId")]
        public List<System.String>? SnapshotId { get; set; }

        //      C# -> TimeRangeInput? TimeRange
        // GraphQL -> timeRange: TimeRangeInput (input)
        [JsonProperty("timeRange")]
        public TimeRangeInput? TimeRange { get; set; }

        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean (scalar)
        [JsonProperty("isOnDemandSnapshot")]
        public System.Boolean? IsOnDemandSnapshot { get; set; }

        //      C# -> System.Boolean? IsIndexed
        // GraphQL -> isIndexed: Boolean (scalar)
        [JsonProperty("isIndexed")]
        public System.Boolean? IsIndexed { get; set; }

        //      C# -> System.Boolean? LocalSnapshotsOnly
        // GraphQL -> localSnapshotsOnly: Boolean (scalar)
        [JsonProperty("localSnapshotsOnly")]
        public System.Boolean? LocalSnapshotsOnly { get; set; }


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

    } // class CdmSnapshotFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types