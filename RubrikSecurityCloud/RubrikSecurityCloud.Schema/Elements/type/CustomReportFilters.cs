// CustomReportFilters.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region CustomReportFilters
    public class CustomReportFilters: BaseType
    {
        #region members

        //      C# -> List<ActivityObjectTypeEnum>? ActivityObjectType
        // GraphQL -> activityObjectType: [ActivityObjectTypeEnum!] (enum)
        [JsonProperty("activityObjectType")]
        public List<ActivityObjectTypeEnum>? ActivityObjectType { get; set; }

        //      C# -> List<ClusterTypeEnum>? ClusterType
        // GraphQL -> clusterType: [ClusterTypeEnum!] (enum)
        [JsonProperty("clusterType")]
        public List<ClusterTypeEnum>? ClusterType { get; set; }

        //      C# -> List<ComplianceStatusEnum>? ComplianceStatus
        // GraphQL -> complianceStatus: [ComplianceStatusEnum!] (enum)
        [JsonProperty("complianceStatus")]
        public List<ComplianceStatusEnum>? ComplianceStatus { get; set; }

        //      C# -> List<FailoverStatusEnum>? FailoverStatus
        // GraphQL -> failoverStatus: [FailoverStatusEnum!] (enum)
        [JsonProperty("failoverStatus")]
        public List<FailoverStatusEnum>? FailoverStatus { get; set; }

        //      C# -> FailoverTypeEnum? FailoverType
        // GraphQL -> failoverType: FailoverTypeEnum (enum)
        [JsonProperty("failoverType")]
        public FailoverTypeEnum? FailoverType { get; set; }

        //      C# -> List<ActivityStatusEnum>? LastActivityStatus
        // GraphQL -> lastActivityStatus: [ActivityStatusEnum!] (enum)
        [JsonProperty("lastActivityStatus")]
        public List<ActivityStatusEnum>? LastActivityStatus { get; set; }

        //      C# -> List<ActivityTypeEnum>? LastActivityType
        // GraphQL -> lastActivityType: [ActivityTypeEnum!] (enum)
        [JsonProperty("lastActivityType")]
        public List<ActivityTypeEnum>? LastActivityType { get; set; }

        //      C# -> List<ObjectTypeEnum>? ObjectType
        // GraphQL -> objectType: [ObjectTypeEnum!] (enum)
        [JsonProperty("objectType")]
        public List<ObjectTypeEnum>? ObjectType { get; set; }

        //      C# -> List<ProtectionStatusEnum>? ProtectionStatus
        // GraphQL -> protectionStatus: [ProtectionStatusEnum!] (enum)
        [JsonProperty("protectionStatus")]
        public List<ProtectionStatusEnum>? ProtectionStatus { get; set; }

        //      C# -> SlaComplianceTimeRange? SlaTimeRange
        // GraphQL -> slaTimeRange: SlaComplianceTimeRange (enum)
        [JsonProperty("slaTimeRange")]
        public SlaComplianceTimeRange? SlaTimeRange { get; set; }

        //      C# -> List<HierarchyObjectTypeEnum>? SonarObjectTypes
        // GraphQL -> sonarObjectTypes: [HierarchyObjectTypeEnum!] (enum)
        [JsonProperty("sonarObjectTypes")]
        public List<HierarchyObjectTypeEnum>? SonarObjectTypes { get; set; }

        //      C# -> List<UserAuditObjectTypeEnum>? UserAuditObjectType
        // GraphQL -> userAuditObjectType: [UserAuditObjectTypeEnum!] (enum)
        [JsonProperty("userAuditObjectType")]
        public List<UserAuditObjectTypeEnum>? UserAuditObjectType { get; set; }

        //      C# -> List<UserAuditStatusEnum>? UserAuditStatus
        // GraphQL -> userAuditStatus: [UserAuditStatusEnum!] (enum)
        [JsonProperty("userAuditStatus")]
        public List<UserAuditStatusEnum>? UserAuditStatus { get; set; }

        //      C# -> List<UserAuditTypeEnum>? UserAuditType
        // GraphQL -> userAuditType: [UserAuditTypeEnum!] (enum)
        [JsonProperty("userAuditType")]
        public List<UserAuditTypeEnum>? UserAuditType { get; set; }

        //      C# -> List<SlaDomain>? SlaDomain
        // GraphQL -> slaDomain: [SlaDomain!] (interface)
        [JsonProperty("slaDomain")]
        public List<SlaDomain>? SlaDomain { get; set; }

        //      C# -> List<System.String>? ClusterLocation
        // GraphQL -> clusterLocation: [String!] (scalar)
        [JsonProperty("clusterLocation")]
        public List<System.String>? ClusterLocation { get; set; }

        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean (scalar)
        [JsonProperty("isAnomaly")]
        public System.Boolean? IsAnomaly { get; set; }

        //      C# -> List<System.String>? ManagedId
        // GraphQL -> managedId: [String!] (scalar)
        [JsonProperty("managedId")]
        public List<System.String>? ManagedId { get; set; }

        //      C# -> List<System.String>? OrgId
        // GraphQL -> orgId: [String!] (scalar)
        [JsonProperty("orgId")]
        public List<System.String>? OrgId { get; set; }

        //      C# -> List<System.String>? PolicyId
        // GraphQL -> policyId: [String!] (scalar)
        [JsonProperty("policyId")]
        public List<System.String>? PolicyId { get; set; }

        //      C# -> List<System.String>? ReplicationSource
        // GraphQL -> replicationSource: [String!] (scalar)
        [JsonProperty("replicationSource")]
        public List<System.String>? ReplicationSource { get; set; }

        //      C# -> System.String? SearchTerm
        // GraphQL -> searchTerm: String (scalar)
        [JsonProperty("searchTerm")]
        public System.String? SearchTerm { get; set; }

        //      C# -> System.Boolean? ShouldApplyWhitelists
        // GraphQL -> shouldApplyWhitelists: Boolean! (scalar)
        [JsonProperty("shouldApplyWhitelists")]
        public System.Boolean? ShouldApplyWhitelists { get; set; }

        //      C# -> List<System.String>? Source
        // GraphQL -> source: [String!] (scalar)
        [JsonProperty("source")]
        public List<System.String>? Source { get; set; }

        //      C# -> List<System.String>? TargetSite
        // GraphQL -> targetSite: [String!] (scalar)
        [JsonProperty("targetSite")]
        public List<System.String>? TargetSite { get; set; }

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

        //      C# -> List<Cluster>? Cluster
        // GraphQL -> cluster: [Cluster!] (type)
        [JsonProperty("cluster")]
        public List<Cluster>? Cluster { get; set; }

        //      C# -> GenericTimeRange? TimeRange
        // GraphQL -> timeRange: GenericTimeRange (type)
        [JsonProperty("timeRange")]
        public GenericTimeRange? TimeRange { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CustomReportFilters";
    }

    public CustomReportFilters Set(
        List<ActivityObjectTypeEnum>? ActivityObjectType = null,
        List<ClusterTypeEnum>? ClusterType = null,
        List<ComplianceStatusEnum>? ComplianceStatus = null,
        List<FailoverStatusEnum>? FailoverStatus = null,
        FailoverTypeEnum? FailoverType = null,
        List<ActivityStatusEnum>? LastActivityStatus = null,
        List<ActivityTypeEnum>? LastActivityType = null,
        List<ObjectTypeEnum>? ObjectType = null,
        List<ProtectionStatusEnum>? ProtectionStatus = null,
        SlaComplianceTimeRange? SlaTimeRange = null,
        List<HierarchyObjectTypeEnum>? SonarObjectTypes = null,
        List<UserAuditObjectTypeEnum>? UserAuditObjectType = null,
        List<UserAuditStatusEnum>? UserAuditStatus = null,
        List<UserAuditTypeEnum>? UserAuditType = null,
        List<SlaDomain>? SlaDomain = null,
        List<System.String>? ClusterLocation = null,
        DateTime? Date = null,
        System.Boolean? IsAnomaly = null,
        List<System.String>? ManagedId = null,
        List<System.String>? OrgId = null,
        List<System.String>? PolicyId = null,
        List<System.String>? ReplicationSource = null,
        System.String? SearchTerm = null,
        System.Boolean? ShouldApplyWhitelists = null,
        List<System.String>? Source = null,
        List<System.String>? TargetSite = null,
        List<System.String>? TaskCategory = null,
        List<System.String>? TaskStatus = null,
        List<System.String>? TaskType = null,
        List<Cluster>? Cluster = null,
        GenericTimeRange? TimeRange = null
    ) 
    {
        if ( ActivityObjectType != null ) {
            this.ActivityObjectType = ActivityObjectType;
        }
        if ( ClusterType != null ) {
            this.ClusterType = ClusterType;
        }
        if ( ComplianceStatus != null ) {
            this.ComplianceStatus = ComplianceStatus;
        }
        if ( FailoverStatus != null ) {
            this.FailoverStatus = FailoverStatus;
        }
        if ( FailoverType != null ) {
            this.FailoverType = FailoverType;
        }
        if ( LastActivityStatus != null ) {
            this.LastActivityStatus = LastActivityStatus;
        }
        if ( LastActivityType != null ) {
            this.LastActivityType = LastActivityType;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( ProtectionStatus != null ) {
            this.ProtectionStatus = ProtectionStatus;
        }
        if ( SlaTimeRange != null ) {
            this.SlaTimeRange = SlaTimeRange;
        }
        if ( SonarObjectTypes != null ) {
            this.SonarObjectTypes = SonarObjectTypes;
        }
        if ( UserAuditObjectType != null ) {
            this.UserAuditObjectType = UserAuditObjectType;
        }
        if ( UserAuditStatus != null ) {
            this.UserAuditStatus = UserAuditStatus;
        }
        if ( UserAuditType != null ) {
            this.UserAuditType = UserAuditType;
        }
        if ( SlaDomain != null ) {
            this.SlaDomain = SlaDomain;
        }
        if ( ClusterLocation != null ) {
            this.ClusterLocation = ClusterLocation;
        }
        if ( Date != null ) {
            this.Date = Date;
        }
        if ( IsAnomaly != null ) {
            this.IsAnomaly = IsAnomaly;
        }
        if ( ManagedId != null ) {
            this.ManagedId = ManagedId;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( PolicyId != null ) {
            this.PolicyId = PolicyId;
        }
        if ( ReplicationSource != null ) {
            this.ReplicationSource = ReplicationSource;
        }
        if ( SearchTerm != null ) {
            this.SearchTerm = SearchTerm;
        }
        if ( ShouldApplyWhitelists != null ) {
            this.ShouldApplyWhitelists = ShouldApplyWhitelists;
        }
        if ( Source != null ) {
            this.Source = Source;
        }
        if ( TargetSite != null ) {
            this.TargetSite = TargetSite;
        }
        if ( TaskCategory != null ) {
            this.TaskCategory = TaskCategory;
        }
        if ( TaskStatus != null ) {
            this.TaskStatus = TaskStatus;
        }
        if ( TaskType != null ) {
            this.TaskType = TaskType;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( TimeRange != null ) {
            this.TimeRange = TimeRange;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<ActivityObjectTypeEnum>? ActivityObjectType
        // GraphQL -> activityObjectType: [ActivityObjectTypeEnum!] (enum)
        if (this.ActivityObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activityObjectType\n" ;
            } else {
                s += ind + "activityObjectType\n" ;
            }
        }
        //      C# -> List<ClusterTypeEnum>? ClusterType
        // GraphQL -> clusterType: [ClusterTypeEnum!] (enum)
        if (this.ClusterType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterType\n" ;
            } else {
                s += ind + "clusterType\n" ;
            }
        }
        //      C# -> List<ComplianceStatusEnum>? ComplianceStatus
        // GraphQL -> complianceStatus: [ComplianceStatusEnum!] (enum)
        if (this.ComplianceStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "complianceStatus\n" ;
            } else {
                s += ind + "complianceStatus\n" ;
            }
        }
        //      C# -> List<FailoverStatusEnum>? FailoverStatus
        // GraphQL -> failoverStatus: [FailoverStatusEnum!] (enum)
        if (this.FailoverStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failoverStatus\n" ;
            } else {
                s += ind + "failoverStatus\n" ;
            }
        }
        //      C# -> FailoverTypeEnum? FailoverType
        // GraphQL -> failoverType: FailoverTypeEnum (enum)
        if (this.FailoverType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failoverType\n" ;
            } else {
                s += ind + "failoverType\n" ;
            }
        }
        //      C# -> List<ActivityStatusEnum>? LastActivityStatus
        // GraphQL -> lastActivityStatus: [ActivityStatusEnum!] (enum)
        if (this.LastActivityStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastActivityStatus\n" ;
            } else {
                s += ind + "lastActivityStatus\n" ;
            }
        }
        //      C# -> List<ActivityTypeEnum>? LastActivityType
        // GraphQL -> lastActivityType: [ActivityTypeEnum!] (enum)
        if (this.LastActivityType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastActivityType\n" ;
            } else {
                s += ind + "lastActivityType\n" ;
            }
        }
        //      C# -> List<ObjectTypeEnum>? ObjectType
        // GraphQL -> objectType: [ObjectTypeEnum!] (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> List<ProtectionStatusEnum>? ProtectionStatus
        // GraphQL -> protectionStatus: [ProtectionStatusEnum!] (enum)
        if (this.ProtectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionStatus\n" ;
            } else {
                s += ind + "protectionStatus\n" ;
            }
        }
        //      C# -> SlaComplianceTimeRange? SlaTimeRange
        // GraphQL -> slaTimeRange: SlaComplianceTimeRange (enum)
        if (this.SlaTimeRange != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaTimeRange\n" ;
            } else {
                s += ind + "slaTimeRange\n" ;
            }
        }
        //      C# -> List<HierarchyObjectTypeEnum>? SonarObjectTypes
        // GraphQL -> sonarObjectTypes: [HierarchyObjectTypeEnum!] (enum)
        if (this.SonarObjectTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sonarObjectTypes\n" ;
            } else {
                s += ind + "sonarObjectTypes\n" ;
            }
        }
        //      C# -> List<UserAuditObjectTypeEnum>? UserAuditObjectType
        // GraphQL -> userAuditObjectType: [UserAuditObjectTypeEnum!] (enum)
        if (this.UserAuditObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userAuditObjectType\n" ;
            } else {
                s += ind + "userAuditObjectType\n" ;
            }
        }
        //      C# -> List<UserAuditStatusEnum>? UserAuditStatus
        // GraphQL -> userAuditStatus: [UserAuditStatusEnum!] (enum)
        if (this.UserAuditStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userAuditStatus\n" ;
            } else {
                s += ind + "userAuditStatus\n" ;
            }
        }
        //      C# -> List<UserAuditTypeEnum>? UserAuditType
        // GraphQL -> userAuditType: [UserAuditTypeEnum!] (enum)
        if (this.UserAuditType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userAuditType\n" ;
            } else {
                s += ind + "userAuditType\n" ;
            }
        }
        //      C# -> List<SlaDomain>? SlaDomain
        // GraphQL -> slaDomain: [SlaDomain!] (interface)
        if (this.SlaDomain != null) {
                var fspec = this.SlaDomain.AsFieldSpec(conf.Child("slaDomain"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "CustomReportFilters_INTERFACE_FIELD_slaDomain: slaDomain{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> List<System.String>? ClusterLocation
        // GraphQL -> clusterLocation: [String!] (scalar)
        if (this.ClusterLocation != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterLocation\n" ;
            } else {
                s += ind + "clusterLocation\n" ;
            }
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        if (this.Date != null) {
            if (conf.Flat) {
                s += conf.Prefix + "date\n" ;
            } else {
                s += ind + "date\n" ;
            }
        }
        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean (scalar)
        if (this.IsAnomaly != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAnomaly\n" ;
            } else {
                s += ind + "isAnomaly\n" ;
            }
        }
        //      C# -> List<System.String>? ManagedId
        // GraphQL -> managedId: [String!] (scalar)
        if (this.ManagedId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "managedId\n" ;
            } else {
                s += ind + "managedId\n" ;
            }
        }
        //      C# -> List<System.String>? OrgId
        // GraphQL -> orgId: [String!] (scalar)
        if (this.OrgId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgId\n" ;
            } else {
                s += ind + "orgId\n" ;
            }
        }
        //      C# -> List<System.String>? PolicyId
        // GraphQL -> policyId: [String!] (scalar)
        if (this.PolicyId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyId\n" ;
            } else {
                s += ind + "policyId\n" ;
            }
        }
        //      C# -> List<System.String>? ReplicationSource
        // GraphQL -> replicationSource: [String!] (scalar)
        if (this.ReplicationSource != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicationSource\n" ;
            } else {
                s += ind + "replicationSource\n" ;
            }
        }
        //      C# -> System.String? SearchTerm
        // GraphQL -> searchTerm: String (scalar)
        if (this.SearchTerm != null) {
            if (conf.Flat) {
                s += conf.Prefix + "searchTerm\n" ;
            } else {
                s += ind + "searchTerm\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldApplyWhitelists
        // GraphQL -> shouldApplyWhitelists: Boolean! (scalar)
        if (this.ShouldApplyWhitelists != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldApplyWhitelists\n" ;
            } else {
                s += ind + "shouldApplyWhitelists\n" ;
            }
        }
        //      C# -> List<System.String>? Source
        // GraphQL -> source: [String!] (scalar)
        if (this.Source != null) {
            if (conf.Flat) {
                s += conf.Prefix + "source\n" ;
            } else {
                s += ind + "source\n" ;
            }
        }
        //      C# -> List<System.String>? TargetSite
        // GraphQL -> targetSite: [String!] (scalar)
        if (this.TargetSite != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetSite\n" ;
            } else {
                s += ind + "targetSite\n" ;
            }
        }
        //      C# -> List<System.String>? TaskCategory
        // GraphQL -> taskCategory: [String!] (scalar)
        if (this.TaskCategory != null) {
            if (conf.Flat) {
                s += conf.Prefix + "taskCategory\n" ;
            } else {
                s += ind + "taskCategory\n" ;
            }
        }
        //      C# -> List<System.String>? TaskStatus
        // GraphQL -> taskStatus: [String!] (scalar)
        if (this.TaskStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "taskStatus\n" ;
            } else {
                s += ind + "taskStatus\n" ;
            }
        }
        //      C# -> List<System.String>? TaskType
        // GraphQL -> taskType: [String!] (scalar)
        if (this.TaskType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "taskType\n" ;
            } else {
                s += ind + "taskType\n" ;
            }
        }
        //      C# -> List<Cluster>? Cluster
        // GraphQL -> cluster: [Cluster!] (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> GenericTimeRange? TimeRange
        // GraphQL -> timeRange: GenericTimeRange (type)
        if (this.TimeRange != null) {
            var fspec = this.TimeRange.AsFieldSpec(conf.Child("timeRange"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "timeRange {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ActivityObjectTypeEnum>? ActivityObjectType
        // GraphQL -> activityObjectType: [ActivityObjectTypeEnum!] (enum)
        if (ec.Includes("activityObjectType",true))
        {
            if(this.ActivityObjectType == null) {

                this.ActivityObjectType = new List<ActivityObjectTypeEnum>();

            } else {


            }
        }
        else if (this.ActivityObjectType != null && ec.Excludes("activityObjectType",true))
        {
            this.ActivityObjectType = null;
        }
        //      C# -> List<ClusterTypeEnum>? ClusterType
        // GraphQL -> clusterType: [ClusterTypeEnum!] (enum)
        if (ec.Includes("clusterType",true))
        {
            if(this.ClusterType == null) {

                this.ClusterType = new List<ClusterTypeEnum>();

            } else {


            }
        }
        else if (this.ClusterType != null && ec.Excludes("clusterType",true))
        {
            this.ClusterType = null;
        }
        //      C# -> List<ComplianceStatusEnum>? ComplianceStatus
        // GraphQL -> complianceStatus: [ComplianceStatusEnum!] (enum)
        if (ec.Includes("complianceStatus",true))
        {
            if(this.ComplianceStatus == null) {

                this.ComplianceStatus = new List<ComplianceStatusEnum>();

            } else {


            }
        }
        else if (this.ComplianceStatus != null && ec.Excludes("complianceStatus",true))
        {
            this.ComplianceStatus = null;
        }
        //      C# -> List<FailoverStatusEnum>? FailoverStatus
        // GraphQL -> failoverStatus: [FailoverStatusEnum!] (enum)
        if (ec.Includes("failoverStatus",true))
        {
            if(this.FailoverStatus == null) {

                this.FailoverStatus = new List<FailoverStatusEnum>();

            } else {


            }
        }
        else if (this.FailoverStatus != null && ec.Excludes("failoverStatus",true))
        {
            this.FailoverStatus = null;
        }
        //      C# -> FailoverTypeEnum? FailoverType
        // GraphQL -> failoverType: FailoverTypeEnum (enum)
        if (ec.Includes("failoverType",true))
        {
            if(this.FailoverType == null) {

                this.FailoverType = new FailoverTypeEnum();

            } else {


            }
        }
        else if (this.FailoverType != null && ec.Excludes("failoverType",true))
        {
            this.FailoverType = null;
        }
        //      C# -> List<ActivityStatusEnum>? LastActivityStatus
        // GraphQL -> lastActivityStatus: [ActivityStatusEnum!] (enum)
        if (ec.Includes("lastActivityStatus",true))
        {
            if(this.LastActivityStatus == null) {

                this.LastActivityStatus = new List<ActivityStatusEnum>();

            } else {


            }
        }
        else if (this.LastActivityStatus != null && ec.Excludes("lastActivityStatus",true))
        {
            this.LastActivityStatus = null;
        }
        //      C# -> List<ActivityTypeEnum>? LastActivityType
        // GraphQL -> lastActivityType: [ActivityTypeEnum!] (enum)
        if (ec.Includes("lastActivityType",true))
        {
            if(this.LastActivityType == null) {

                this.LastActivityType = new List<ActivityTypeEnum>();

            } else {


            }
        }
        else if (this.LastActivityType != null && ec.Excludes("lastActivityType",true))
        {
            this.LastActivityType = null;
        }
        //      C# -> List<ObjectTypeEnum>? ObjectType
        // GraphQL -> objectType: [ObjectTypeEnum!] (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new List<ObjectTypeEnum>();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> List<ProtectionStatusEnum>? ProtectionStatus
        // GraphQL -> protectionStatus: [ProtectionStatusEnum!] (enum)
        if (ec.Includes("protectionStatus",true))
        {
            if(this.ProtectionStatus == null) {

                this.ProtectionStatus = new List<ProtectionStatusEnum>();

            } else {


            }
        }
        else if (this.ProtectionStatus != null && ec.Excludes("protectionStatus",true))
        {
            this.ProtectionStatus = null;
        }
        //      C# -> SlaComplianceTimeRange? SlaTimeRange
        // GraphQL -> slaTimeRange: SlaComplianceTimeRange (enum)
        if (ec.Includes("slaTimeRange",true))
        {
            if(this.SlaTimeRange == null) {

                this.SlaTimeRange = new SlaComplianceTimeRange();

            } else {


            }
        }
        else if (this.SlaTimeRange != null && ec.Excludes("slaTimeRange",true))
        {
            this.SlaTimeRange = null;
        }
        //      C# -> List<HierarchyObjectTypeEnum>? SonarObjectTypes
        // GraphQL -> sonarObjectTypes: [HierarchyObjectTypeEnum!] (enum)
        if (ec.Includes("sonarObjectTypes",true))
        {
            if(this.SonarObjectTypes == null) {

                this.SonarObjectTypes = new List<HierarchyObjectTypeEnum>();

            } else {


            }
        }
        else if (this.SonarObjectTypes != null && ec.Excludes("sonarObjectTypes",true))
        {
            this.SonarObjectTypes = null;
        }
        //      C# -> List<UserAuditObjectTypeEnum>? UserAuditObjectType
        // GraphQL -> userAuditObjectType: [UserAuditObjectTypeEnum!] (enum)
        if (ec.Includes("userAuditObjectType",true))
        {
            if(this.UserAuditObjectType == null) {

                this.UserAuditObjectType = new List<UserAuditObjectTypeEnum>();

            } else {


            }
        }
        else if (this.UserAuditObjectType != null && ec.Excludes("userAuditObjectType",true))
        {
            this.UserAuditObjectType = null;
        }
        //      C# -> List<UserAuditStatusEnum>? UserAuditStatus
        // GraphQL -> userAuditStatus: [UserAuditStatusEnum!] (enum)
        if (ec.Includes("userAuditStatus",true))
        {
            if(this.UserAuditStatus == null) {

                this.UserAuditStatus = new List<UserAuditStatusEnum>();

            } else {


            }
        }
        else if (this.UserAuditStatus != null && ec.Excludes("userAuditStatus",true))
        {
            this.UserAuditStatus = null;
        }
        //      C# -> List<UserAuditTypeEnum>? UserAuditType
        // GraphQL -> userAuditType: [UserAuditTypeEnum!] (enum)
        if (ec.Includes("userAuditType",true))
        {
            if(this.UserAuditType == null) {

                this.UserAuditType = new List<UserAuditTypeEnum>();

            } else {


            }
        }
        else if (this.UserAuditType != null && ec.Excludes("userAuditType",true))
        {
            this.UserAuditType = null;
        }
        //      C# -> List<SlaDomain>? SlaDomain
        // GraphQL -> slaDomain: [SlaDomain!] (interface)
        if (ec.Includes("slaDomain",false))
        {
            if(this.SlaDomain == null) {

                this.SlaDomain = new List<SlaDomain>();
                this.SlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("slaDomain"));

            } else {

                this.SlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("slaDomain"));

            }
        }
        else if (this.SlaDomain != null && ec.Excludes("slaDomain",false))
        {
            this.SlaDomain = null;
        }
        //      C# -> List<System.String>? ClusterLocation
        // GraphQL -> clusterLocation: [String!] (scalar)
        if (ec.Includes("clusterLocation",true))
        {
            if(this.ClusterLocation == null) {

                this.ClusterLocation = new List<System.String>();

            } else {


            }
        }
        else if (this.ClusterLocation != null && ec.Excludes("clusterLocation",true))
        {
            this.ClusterLocation = null;
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        if (ec.Includes("date",true))
        {
            if(this.Date == null) {

                this.Date = new DateTime();

            } else {


            }
        }
        else if (this.Date != null && ec.Excludes("date",true))
        {
            this.Date = null;
        }
        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean (scalar)
        if (ec.Includes("isAnomaly",true))
        {
            if(this.IsAnomaly == null) {

                this.IsAnomaly = true;

            } else {


            }
        }
        else if (this.IsAnomaly != null && ec.Excludes("isAnomaly",true))
        {
            this.IsAnomaly = null;
        }
        //      C# -> List<System.String>? ManagedId
        // GraphQL -> managedId: [String!] (scalar)
        if (ec.Includes("managedId",true))
        {
            if(this.ManagedId == null) {

                this.ManagedId = new List<System.String>();

            } else {


            }
        }
        else if (this.ManagedId != null && ec.Excludes("managedId",true))
        {
            this.ManagedId = null;
        }
        //      C# -> List<System.String>? OrgId
        // GraphQL -> orgId: [String!] (scalar)
        if (ec.Includes("orgId",true))
        {
            if(this.OrgId == null) {

                this.OrgId = new List<System.String>();

            } else {


            }
        }
        else if (this.OrgId != null && ec.Excludes("orgId",true))
        {
            this.OrgId = null;
        }
        //      C# -> List<System.String>? PolicyId
        // GraphQL -> policyId: [String!] (scalar)
        if (ec.Includes("policyId",true))
        {
            if(this.PolicyId == null) {

                this.PolicyId = new List<System.String>();

            } else {


            }
        }
        else if (this.PolicyId != null && ec.Excludes("policyId",true))
        {
            this.PolicyId = null;
        }
        //      C# -> List<System.String>? ReplicationSource
        // GraphQL -> replicationSource: [String!] (scalar)
        if (ec.Includes("replicationSource",true))
        {
            if(this.ReplicationSource == null) {

                this.ReplicationSource = new List<System.String>();

            } else {


            }
        }
        else if (this.ReplicationSource != null && ec.Excludes("replicationSource",true))
        {
            this.ReplicationSource = null;
        }
        //      C# -> System.String? SearchTerm
        // GraphQL -> searchTerm: String (scalar)
        if (ec.Includes("searchTerm",true))
        {
            if(this.SearchTerm == null) {

                this.SearchTerm = "FETCH";

            } else {


            }
        }
        else if (this.SearchTerm != null && ec.Excludes("searchTerm",true))
        {
            this.SearchTerm = null;
        }
        //      C# -> System.Boolean? ShouldApplyWhitelists
        // GraphQL -> shouldApplyWhitelists: Boolean! (scalar)
        if (ec.Includes("shouldApplyWhitelists",true))
        {
            if(this.ShouldApplyWhitelists == null) {

                this.ShouldApplyWhitelists = true;

            } else {


            }
        }
        else if (this.ShouldApplyWhitelists != null && ec.Excludes("shouldApplyWhitelists",true))
        {
            this.ShouldApplyWhitelists = null;
        }
        //      C# -> List<System.String>? Source
        // GraphQL -> source: [String!] (scalar)
        if (ec.Includes("source",true))
        {
            if(this.Source == null) {

                this.Source = new List<System.String>();

            } else {


            }
        }
        else if (this.Source != null && ec.Excludes("source",true))
        {
            this.Source = null;
        }
        //      C# -> List<System.String>? TargetSite
        // GraphQL -> targetSite: [String!] (scalar)
        if (ec.Includes("targetSite",true))
        {
            if(this.TargetSite == null) {

                this.TargetSite = new List<System.String>();

            } else {


            }
        }
        else if (this.TargetSite != null && ec.Excludes("targetSite",true))
        {
            this.TargetSite = null;
        }
        //      C# -> List<System.String>? TaskCategory
        // GraphQL -> taskCategory: [String!] (scalar)
        if (ec.Includes("taskCategory",true))
        {
            if(this.TaskCategory == null) {

                this.TaskCategory = new List<System.String>();

            } else {


            }
        }
        else if (this.TaskCategory != null && ec.Excludes("taskCategory",true))
        {
            this.TaskCategory = null;
        }
        //      C# -> List<System.String>? TaskStatus
        // GraphQL -> taskStatus: [String!] (scalar)
        if (ec.Includes("taskStatus",true))
        {
            if(this.TaskStatus == null) {

                this.TaskStatus = new List<System.String>();

            } else {


            }
        }
        else if (this.TaskStatus != null && ec.Excludes("taskStatus",true))
        {
            this.TaskStatus = null;
        }
        //      C# -> List<System.String>? TaskType
        // GraphQL -> taskType: [String!] (scalar)
        if (ec.Includes("taskType",true))
        {
            if(this.TaskType == null) {

                this.TaskType = new List<System.String>();

            } else {


            }
        }
        else if (this.TaskType != null && ec.Excludes("taskType",true))
        {
            this.TaskType = null;
        }
        //      C# -> List<Cluster>? Cluster
        // GraphQL -> cluster: [Cluster!] (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new List<Cluster>();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
        //      C# -> GenericTimeRange? TimeRange
        // GraphQL -> timeRange: GenericTimeRange (type)
        if (ec.Includes("timeRange",false))
        {
            if(this.TimeRange == null) {

                this.TimeRange = new GenericTimeRange();
                this.TimeRange.ApplyExploratoryFieldSpec(ec.NewChild("timeRange"));

            } else {

                this.TimeRange.ApplyExploratoryFieldSpec(ec.NewChild("timeRange"));

            }
        }
        else if (this.TimeRange != null && ec.Excludes("timeRange",false))
        {
            this.TimeRange = null;
        }
    }


    #endregion

    } // class CustomReportFilters
    
    #endregion

    public static class ListCustomReportFiltersExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<CustomReportFilters> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CustomReportFilters> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CustomReportFilters> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CustomReportFilters());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CustomReportFilters> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types