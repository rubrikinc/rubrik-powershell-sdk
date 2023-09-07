// CustomReportFiltersConfig.cs
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
    #region CustomReportFiltersConfig

    public class CustomReportFiltersConfig: IInput
    {
        #region members

        //      C# -> List<ActivityObjectTypeEnum>? ActivityObjectType
        // GraphQL -> activityObjectType: [ActivityObjectTypeEnum!] (enum)
        [JsonProperty("activityObjectType")]
        public List<ActivityObjectTypeEnum>? ActivityObjectType { get; set; }

        //      C# -> List<ObjectTypeEnum>? ObjectType
        // GraphQL -> objectType: [ObjectTypeEnum!] (enum)
        [JsonProperty("objectType")]
        public List<ObjectTypeEnum>? ObjectType { get; set; }

        //      C# -> List<ObjectTypeEnum>? ExcludedObjectTypes
        // GraphQL -> excludedObjectTypes: [ObjectTypeEnum!] (enum)
        [JsonProperty("excludedObjectTypes")]
        public List<ObjectTypeEnum>? ExcludedObjectTypes { get; set; }

        //      C# -> List<ActivityStatusEnum>? LastActivityStatus
        // GraphQL -> lastActivityStatus: [ActivityStatusEnum!] (enum)
        [JsonProperty("lastActivityStatus")]
        public List<ActivityStatusEnum>? LastActivityStatus { get; set; }

        //      C# -> List<ActivityTypeEnum>? LastActivityType
        // GraphQL -> lastActivityType: [ActivityTypeEnum!] (enum)
        [JsonProperty("lastActivityType")]
        public List<ActivityTypeEnum>? LastActivityType { get; set; }

        //      C# -> List<System.String>? SlaDomainId
        // GraphQL -> slaDomainId: [String!] (scalar)
        [JsonProperty("slaDomainId")]
        public List<System.String>? SlaDomainId { get; set; }

        //      C# -> List<ClusterTypeEnum>? ClusterType
        // GraphQL -> clusterType: [ClusterTypeEnum!] (enum)
        [JsonProperty("clusterType")]
        public List<ClusterTypeEnum>? ClusterType { get; set; }

        //      C# -> List<System.String>? ClusterId
        // GraphQL -> clusterId: [UUID!] (scalar)
        [JsonProperty("clusterId")]
        public List<System.String>? ClusterId { get; set; }

        //      C# -> GenericTimeRangeInput? TimeRange
        // GraphQL -> timeRange: GenericTimeRangeInput (input)
        [JsonProperty("timeRange")]
        public GenericTimeRangeInput? TimeRange { get; set; }

        //      C# -> SlaComplianceTimeRange? SlaTimeRange
        // GraphQL -> slaTimeRange: SlaComplianceTimeRange (enum)
        [JsonProperty("slaTimeRange")]
        public SlaComplianceTimeRange? SlaTimeRange { get; set; }

        //      C# -> List<System.String>? OrgId
        // GraphQL -> orgId: [String!] (scalar)
        [JsonProperty("orgId")]
        public List<System.String>? OrgId { get; set; }

        //      C# -> List<System.String>? ManagedId
        // GraphQL -> managedId: [String!] (scalar)
        [JsonProperty("managedId")]
        public List<System.String>? ManagedId { get; set; }

        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean (scalar)
        [JsonProperty("isAnomaly")]
        public System.Boolean? IsAnomaly { get; set; }

        //      C# -> System.String? SearchTerm
        // GraphQL -> searchTerm: String (scalar)
        [JsonProperty("searchTerm")]
        public System.String? SearchTerm { get; set; }

        //      C# -> List<ComplianceStatusEnum>? ComplianceStatus
        // GraphQL -> complianceStatus: [ComplianceStatusEnum!] (enum)
        [JsonProperty("complianceStatus")]
        public List<ComplianceStatusEnum>? ComplianceStatus { get; set; }

        //      C# -> List<ProtectionStatusEnum>? ProtectionStatus
        // GraphQL -> protectionStatus: [ProtectionStatusEnum!] (enum)
        [JsonProperty("protectionStatus")]
        public List<ProtectionStatusEnum>? ProtectionStatus { get; set; }

        //      C# -> List<FailoverStatusEnum>? FailoverStatus
        // GraphQL -> failoverStatus: [FailoverStatusEnum!] (enum)
        [JsonProperty("failoverStatus")]
        public List<FailoverStatusEnum>? FailoverStatus { get; set; }

        //      C# -> FailoverTypeEnum? FailoverType
        // GraphQL -> failoverType: FailoverTypeEnum (enum)
        [JsonProperty("failoverType")]
        public FailoverTypeEnum? FailoverType { get; set; }

        //      C# -> List<System.String>? Source
        // GraphQL -> source: [String!] (scalar)
        [JsonProperty("source")]
        public List<System.String>? Source { get; set; }

        //      C# -> List<System.String>? TargetSite
        // GraphQL -> targetSite: [String!] (scalar)
        [JsonProperty("targetSite")]
        public List<System.String>? TargetSite { get; set; }

        //      C# -> List<UserAuditObjectTypeEnum>? UserAuditObjectType
        // GraphQL -> userAuditObjectType: [UserAuditObjectTypeEnum!] (enum)
        [JsonProperty("userAuditObjectType")]
        public List<UserAuditObjectTypeEnum>? UserAuditObjectType { get; set; }

        //      C# -> List<UserAuditTypeEnum>? UserAuditType
        // GraphQL -> userAuditType: [UserAuditTypeEnum!] (enum)
        [JsonProperty("userAuditType")]
        public List<UserAuditTypeEnum>? UserAuditType { get; set; }

        //      C# -> List<UserAuditStatusEnum>? UserAuditStatus
        // GraphQL -> userAuditStatus: [UserAuditStatusEnum!] (enum)
        [JsonProperty("userAuditStatus")]
        public List<UserAuditStatusEnum>? UserAuditStatus { get; set; }

        //      C# -> List<System.String>? ReplicationSource
        // GraphQL -> replicationSource: [String!] (scalar)
        [JsonProperty("replicationSource")]
        public List<System.String>? ReplicationSource { get; set; }

        //      C# -> List<System.String>? ClusterLocation
        // GraphQL -> clusterLocation: [String!] (scalar)
        [JsonProperty("clusterLocation")]
        public List<System.String>? ClusterLocation { get; set; }

        //      C# -> List<System.String>? TaskCategory
        // GraphQL -> taskCategory: [String!] (scalar)
        [JsonProperty("taskCategory")]
        public List<System.String>? TaskCategory { get; set; }

        //      C# -> List<System.String>? TaskStatus
        // GraphQL -> taskStatus: [String!] (scalar)
        [JsonProperty("taskStatus")]
        public List<System.String>? TaskStatus { get; set; }

        //      C# -> List<System.String>? TaskType
        // GraphQL -> taskType: [String!] (scalar)
        [JsonProperty("taskType")]
        public List<System.String>? TaskType { get; set; }

        //      C# -> List<System.String>? PolicyId
        // GraphQL -> policyId: [String!] (scalar)
        [JsonProperty("policyId")]
        public List<System.String>? PolicyId { get; set; }

        //      C# -> List<HierarchyObjectTypeEnum>? SonarObjectTypes
        // GraphQL -> sonarObjectTypes: [HierarchyObjectTypeEnum!] (enum)
        [JsonProperty("sonarObjectTypes")]
        public List<HierarchyObjectTypeEnum>? SonarObjectTypes { get; set; }

        //      C# -> System.Boolean? ShouldApplyWhitelists
        // GraphQL -> shouldApplyWhitelists: Boolean (scalar)
        [JsonProperty("shouldApplyWhitelists")]
        public System.Boolean? ShouldApplyWhitelists { get; set; }

        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }


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

    } // class CustomReportFiltersConfig
    #endregion

} // namespace RubrikSecurityCloud.Types