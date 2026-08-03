// ChildRecoverySpecMapV2Input.cs
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
    #region ChildRecoverySpecMapV2Input

    public class ChildRecoverySpecMapV2Input: IInput
    {
        #region members

        //      C# -> WorkloadRecoverySpecInput? WorkloadRecoverySpec
        // GraphQL -> workloadRecoverySpec: WorkloadRecoverySpecInput (input)
        [JsonProperty("workloadRecoverySpec")]
        public WorkloadRecoverySpecInput? WorkloadRecoverySpec { get; set; }

        //      C# -> System.Int64? RecoveryPoint
        // GraphQL -> recoveryPoint: Long (scalar)
        [JsonProperty("recoveryPoint")]
        public System.Int64? RecoveryPoint { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? PostFailoverSlaId
        // GraphQL -> postFailoverSlaId: UUID (scalar)
        [JsonProperty("postFailoverSlaId")]
        public System.String? PostFailoverSlaId { get; set; }

        //      C# -> System.Int32? BootPriority
        // GraphQL -> bootPriority: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("bootPriority")]
        public System.Int32? BootPriority { get; set; }


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

    } // class ChildRecoverySpecMapV2Input
    #endregion

} // namespace RubrikSecurityCloud.Types