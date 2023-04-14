// SnappableGroupByFilterInput.cs
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
    #region SnappableGroupByFilterInput

    public class SnappableGroupByFilterInput: IInput
    {
        #region members

        //      C# -> List<ProtectionStatusEnum>? ProtectionStatus
        // GraphQL -> protectionStatus: [ProtectionStatusEnum!] (enum)
        [JsonProperty("protectionStatus")]
        public List<ProtectionStatusEnum>? ProtectionStatus { get; set; }

        //      C# -> SnappableSlaDomainFilterInput? SlaDomain
        // GraphQL -> slaDomain: SnappableSlaDomainFilterInput (input)
        [JsonProperty("slaDomain")]
        public SnappableSlaDomainFilterInput? SlaDomain { get; set; }

        //      C# -> List<ComplianceStatusEnum>? ComplianceStatus
        // GraphQL -> complianceStatus: [ComplianceStatusEnum!] (enum)
        [JsonProperty("complianceStatus")]
        public List<ComplianceStatusEnum>? ComplianceStatus { get; set; }

        //      C# -> List<ObjectTypeEnum>? ObjectType
        // GraphQL -> objectType: [ObjectTypeEnum!] (enum)
        [JsonProperty("objectType")]
        public List<ObjectTypeEnum>? ObjectType { get; set; }

        //      C# -> List<ObjectTypeEnum>? ExcludedObjectTypes
        // GraphQL -> excludedObjectTypes: [ObjectTypeEnum!] (enum)
        [JsonProperty("excludedObjectTypes")]
        public List<ObjectTypeEnum>? ExcludedObjectTypes { get; set; }

        //      C# -> CommonClusterFilterInput? Cluster
        // GraphQL -> cluster: CommonClusterFilterInput (input)
        [JsonProperty("cluster")]
        public CommonClusterFilterInput? Cluster { get; set; }

        //      C# -> TimeRangeInput? TimeRange
        // GraphQL -> timeRange: TimeRangeInput (input)
        [JsonProperty("timeRange")]
        public TimeRangeInput? TimeRange { get; set; }

        //      C# -> SlaComplianceTimeRange? SlaTimeRange
        // GraphQL -> slaTimeRange: SlaComplianceTimeRange (enum)
        [JsonProperty("slaTimeRange")]
        public SlaComplianceTimeRange? SlaTimeRange { get; set; }

        //      C# -> List<System.String>? OrgId
        // GraphQL -> orgId: [UUID!] (scalar)
        [JsonProperty("orgId")]
        public List<System.String>? OrgId { get; set; }


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

    } // class SnappableGroupByFilterInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types