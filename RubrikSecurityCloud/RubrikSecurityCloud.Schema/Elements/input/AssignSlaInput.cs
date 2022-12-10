// AssignSlaInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:26.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region AssignSlaInput

    public class AssignSlaInput
    {
        #region members
        //      C# -> SlaAssignTypeEnum? SlaDomainAssignType
        // GraphQL -> slaDomainAssignType: SlaAssignTypeEnum! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("slaDomainAssignType")]
        public SlaAssignTypeEnum? SlaDomainAssignType { get; set; }

        //      C# -> System.String? SlaOptionalId
        // GraphQL -> slaOptionalId: UUID (scalar)
        [JsonProperty("slaOptionalId")]
        public System.String? SlaOptionalId { get; set; }

        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("objectIds")]
        public List<System.String>? ObjectIds { get; set; }

        //      C# -> WorkloadLevelHierarchy? ApplicableWorkloadType
        // GraphQL -> applicableWorkloadType: WorkloadLevelHierarchy (enum)
        [JsonProperty("applicableWorkloadType")]
        public WorkloadLevelHierarchy? ApplicableWorkloadType { get; set; }

        //      C# -> System.Boolean? ShouldApplyToExistingSnapshots
        // GraphQL -> shouldApplyToExistingSnapshots: Boolean (scalar)
        [JsonProperty("shouldApplyToExistingSnapshots")]
        public System.Boolean? ShouldApplyToExistingSnapshots { get; set; }

        //      C# -> System.Boolean? ShouldApplyToNonPolicySnapshots
        // GraphQL -> shouldApplyToNonPolicySnapshots: Boolean (scalar)
        [JsonProperty("shouldApplyToNonPolicySnapshots")]
        public System.Boolean? ShouldApplyToNonPolicySnapshots { get; set; }

        //      C# -> GlobalExistingSnapshotRetention? ExistingSnapshotRetention
        // GraphQL -> existingSnapshotRetention: GlobalExistingSnapshotRetention (enum)
        [JsonProperty("existingSnapshotRetention")]
        public GlobalExistingSnapshotRetention? ExistingSnapshotRetention { get; set; }

        //      C# -> System.String? UserNote
        // GraphQL -> userNote: String (scalar)
        [JsonProperty("userNote")]
        public System.String? UserNote { get; set; }

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

    } // class AssignSlaInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types