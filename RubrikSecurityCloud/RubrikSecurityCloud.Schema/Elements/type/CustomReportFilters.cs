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

namespace Rubrik.SecurityCloud.Types
{
    #region CustomReportFilters
    public class CustomReportFilters: IFragment
    {
        #region members
        //      C# -> List<System.String>? ClusterLocation
        // GraphQL -> clusterLocation: [String!] (scalar)
        [JsonProperty("clusterLocation")]
        public List<System.String>? ClusterLocation { get; set; }

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

        #endregion

    #region methods

    public CustomReportFilters Set(
        List<System.String>? ClusterLocation = null,
        System.Boolean? IsAnomaly = null,
        List<System.String>? ManagedId = null,
        List<System.String>? OrgId = null,
        List<System.String>? PolicyId = null,
        List<System.String>? ReplicationSource = null,
        System.String? SearchTerm = null,
        List<System.String>? Source = null,
        List<System.String>? TargetSite = null,
        List<System.String>? TaskCategory = null,
        List<System.String>? TaskStatus = null,
        List<System.String>? TaskType = null,
        List<Cluster>? Cluster = null,
        GenericTimeRange? TimeRange = null,
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
        List<SlaDomain>? SlaDomain = null
    ) 
    {
        if ( ClusterLocation != null ) {
            this.ClusterLocation = ClusterLocation;
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
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> List<System.String>? ClusterLocation
            // GraphQL -> clusterLocation: [String!] (scalar)
            if (this.ClusterLocation != null)
            {
                 s += ind + "clusterLocation\n";

            }
            //      C# -> System.Boolean? IsAnomaly
            // GraphQL -> isAnomaly: Boolean (scalar)
            if (this.IsAnomaly != null)
            {
                 s += ind + "isAnomaly\n";

            }
            //      C# -> List<System.String>? ManagedId
            // GraphQL -> managedId: [String!] (scalar)
            if (this.ManagedId != null)
            {
                 s += ind + "managedId\n";

            }
            //      C# -> List<System.String>? OrgId
            // GraphQL -> orgId: [String!] (scalar)
            if (this.OrgId != null)
            {
                 s += ind + "orgId\n";

            }
            //      C# -> List<System.String>? PolicyId
            // GraphQL -> policyId: [String!] (scalar)
            if (this.PolicyId != null)
            {
                 s += ind + "policyId\n";

            }
            //      C# -> List<System.String>? ReplicationSource
            // GraphQL -> replicationSource: [String!] (scalar)
            if (this.ReplicationSource != null)
            {
                 s += ind + "replicationSource\n";

            }
            //      C# -> System.String? SearchTerm
            // GraphQL -> searchTerm: String (scalar)
            if (this.SearchTerm != null)
            {
                 s += ind + "searchTerm\n";

            }
            //      C# -> List<System.String>? Source
            // GraphQL -> source: [String!] (scalar)
            if (this.Source != null)
            {
                 s += ind + "source\n";

            }
            //      C# -> List<System.String>? TargetSite
            // GraphQL -> targetSite: [String!] (scalar)
            if (this.TargetSite != null)
            {
                 s += ind + "targetSite\n";

            }
            //      C# -> List<System.String>? TaskCategory
            // GraphQL -> taskCategory: [String!] (scalar)
            if (this.TaskCategory != null)
            {
                 s += ind + "taskCategory\n";

            }
            //      C# -> List<System.String>? TaskStatus
            // GraphQL -> taskStatus: [String!] (scalar)
            if (this.TaskStatus != null)
            {
                 s += ind + "taskStatus\n";

            }
            //      C# -> List<System.String>? TaskType
            // GraphQL -> taskType: [String!] (scalar)
            if (this.TaskType != null)
            {
                 s += ind + "taskType\n";

            }
            //      C# -> List<Cluster>? Cluster
            // GraphQL -> cluster: [Cluster!] (type)
            if (this.Cluster != null)
            {
                 s += ind + "cluster\n";

                 s += ind + "{\n" + 
                 this.Cluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> GenericTimeRange? TimeRange
            // GraphQL -> timeRange: GenericTimeRange (type)
            if (this.TimeRange != null)
            {
                 s += ind + "timeRange\n";

                 s += ind + "{\n" + 
                 this.TimeRange.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ActivityObjectTypeEnum>? ActivityObjectType
            // GraphQL -> activityObjectType: [ActivityObjectTypeEnum!] (enum)
            if (this.ActivityObjectType != null)
            {
                 s += ind + "activityObjectType\n";

            }
            //      C# -> List<ClusterTypeEnum>? ClusterType
            // GraphQL -> clusterType: [ClusterTypeEnum!] (enum)
            if (this.ClusterType != null)
            {
                 s += ind + "clusterType\n";

            }
            //      C# -> List<ComplianceStatusEnum>? ComplianceStatus
            // GraphQL -> complianceStatus: [ComplianceStatusEnum!] (enum)
            if (this.ComplianceStatus != null)
            {
                 s += ind + "complianceStatus\n";

            }
            //      C# -> List<FailoverStatusEnum>? FailoverStatus
            // GraphQL -> failoverStatus: [FailoverStatusEnum!] (enum)
            if (this.FailoverStatus != null)
            {
                 s += ind + "failoverStatus\n";

            }
            //      C# -> FailoverTypeEnum? FailoverType
            // GraphQL -> failoverType: FailoverTypeEnum (enum)
            if (this.FailoverType != null)
            {
                 s += ind + "failoverType\n";

            }
            //      C# -> List<ActivityStatusEnum>? LastActivityStatus
            // GraphQL -> lastActivityStatus: [ActivityStatusEnum!] (enum)
            if (this.LastActivityStatus != null)
            {
                 s += ind + "lastActivityStatus\n";

            }
            //      C# -> List<ActivityTypeEnum>? LastActivityType
            // GraphQL -> lastActivityType: [ActivityTypeEnum!] (enum)
            if (this.LastActivityType != null)
            {
                 s += ind + "lastActivityType\n";

            }
            //      C# -> List<ObjectTypeEnum>? ObjectType
            // GraphQL -> objectType: [ObjectTypeEnum!] (enum)
            if (this.ObjectType != null)
            {
                 s += ind + "objectType\n";

            }
            //      C# -> List<ProtectionStatusEnum>? ProtectionStatus
            // GraphQL -> protectionStatus: [ProtectionStatusEnum!] (enum)
            if (this.ProtectionStatus != null)
            {
                 s += ind + "protectionStatus\n";

            }
            //      C# -> SlaComplianceTimeRange? SlaTimeRange
            // GraphQL -> slaTimeRange: SlaComplianceTimeRange (enum)
            if (this.SlaTimeRange != null)
            {
                 s += ind + "slaTimeRange\n";

            }
            //      C# -> List<HierarchyObjectTypeEnum>? SonarObjectTypes
            // GraphQL -> sonarObjectTypes: [HierarchyObjectTypeEnum!] (enum)
            if (this.SonarObjectTypes != null)
            {
                 s += ind + "sonarObjectTypes\n";

            }
            //      C# -> List<UserAuditObjectTypeEnum>? UserAuditObjectType
            // GraphQL -> userAuditObjectType: [UserAuditObjectTypeEnum!] (enum)
            if (this.UserAuditObjectType != null)
            {
                 s += ind + "userAuditObjectType\n";

            }
            //      C# -> List<UserAuditStatusEnum>? UserAuditStatus
            // GraphQL -> userAuditStatus: [UserAuditStatusEnum!] (enum)
            if (this.UserAuditStatus != null)
            {
                 s += ind + "userAuditStatus\n";

            }
            //      C# -> List<UserAuditTypeEnum>? UserAuditType
            // GraphQL -> userAuditType: [UserAuditTypeEnum!] (enum)
            if (this.UserAuditType != null)
            {
                 s += ind + "userAuditType\n";

            }
                        //      C# -> List<SlaDomain>? SlaDomain
            // GraphQL -> slaDomain: [SlaDomain!] (interface)
            if (this.SlaDomain != null)
            {
                s += ind + "slaDomain\n";
                s += ind + "{\n";

                s += this.SlaDomain.AsFragment(indent+1) +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? ClusterLocation
            // GraphQL -> clusterLocation: [String!] (scalar)
            if (this.ClusterLocation == null && Exploration.Includes(parent + ".clusterLocation$"))
            {
                this.ClusterLocation = new List<System.String>();
            }
            //      C# -> System.Boolean? IsAnomaly
            // GraphQL -> isAnomaly: Boolean (scalar)
            if (this.IsAnomaly == null && Exploration.Includes(parent + ".isAnomaly$"))
            {
                this.IsAnomaly = new System.Boolean();
            }
            //      C# -> List<System.String>? ManagedId
            // GraphQL -> managedId: [String!] (scalar)
            if (this.ManagedId == null && Exploration.Includes(parent + ".managedId$"))
            {
                this.ManagedId = new List<System.String>();
            }
            //      C# -> List<System.String>? OrgId
            // GraphQL -> orgId: [String!] (scalar)
            if (this.OrgId == null && Exploration.Includes(parent + ".orgId$"))
            {
                this.OrgId = new List<System.String>();
            }
            //      C# -> List<System.String>? PolicyId
            // GraphQL -> policyId: [String!] (scalar)
            if (this.PolicyId == null && Exploration.Includes(parent + ".policyId$"))
            {
                this.PolicyId = new List<System.String>();
            }
            //      C# -> List<System.String>? ReplicationSource
            // GraphQL -> replicationSource: [String!] (scalar)
            if (this.ReplicationSource == null && Exploration.Includes(parent + ".replicationSource$"))
            {
                this.ReplicationSource = new List<System.String>();
            }
            //      C# -> System.String? SearchTerm
            // GraphQL -> searchTerm: String (scalar)
            if (this.SearchTerm == null && Exploration.Includes(parent + ".searchTerm$"))
            {
                this.SearchTerm = new System.String("FETCH");
            }
            //      C# -> List<System.String>? Source
            // GraphQL -> source: [String!] (scalar)
            if (this.Source == null && Exploration.Includes(parent + ".source$"))
            {
                this.Source = new List<System.String>();
            }
            //      C# -> List<System.String>? TargetSite
            // GraphQL -> targetSite: [String!] (scalar)
            if (this.TargetSite == null && Exploration.Includes(parent + ".targetSite$"))
            {
                this.TargetSite = new List<System.String>();
            }
            //      C# -> List<System.String>? TaskCategory
            // GraphQL -> taskCategory: [String!] (scalar)
            if (this.TaskCategory == null && Exploration.Includes(parent + ".taskCategory$"))
            {
                this.TaskCategory = new List<System.String>();
            }
            //      C# -> List<System.String>? TaskStatus
            // GraphQL -> taskStatus: [String!] (scalar)
            if (this.TaskStatus == null && Exploration.Includes(parent + ".taskStatus$"))
            {
                this.TaskStatus = new List<System.String>();
            }
            //      C# -> List<System.String>? TaskType
            // GraphQL -> taskType: [String!] (scalar)
            if (this.TaskType == null && Exploration.Includes(parent + ".taskType$"))
            {
                this.TaskType = new List<System.String>();
            }
            //      C# -> List<Cluster>? Cluster
            // GraphQL -> cluster: [Cluster!] (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new List<Cluster>();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> GenericTimeRange? TimeRange
            // GraphQL -> timeRange: GenericTimeRange (type)
            if (this.TimeRange == null && Exploration.Includes(parent + ".timeRange"))
            {
                this.TimeRange = new GenericTimeRange();
                this.TimeRange.ApplyExploratoryFragment(parent + ".timeRange");
            }
            //      C# -> List<ActivityObjectTypeEnum>? ActivityObjectType
            // GraphQL -> activityObjectType: [ActivityObjectTypeEnum!] (enum)
            if (this.ActivityObjectType == null && Exploration.Includes(parent + ".activityObjectType$"))
            {
                this.ActivityObjectType = new List<ActivityObjectTypeEnum>();
            }
            //      C# -> List<ClusterTypeEnum>? ClusterType
            // GraphQL -> clusterType: [ClusterTypeEnum!] (enum)
            if (this.ClusterType == null && Exploration.Includes(parent + ".clusterType$"))
            {
                this.ClusterType = new List<ClusterTypeEnum>();
            }
            //      C# -> List<ComplianceStatusEnum>? ComplianceStatus
            // GraphQL -> complianceStatus: [ComplianceStatusEnum!] (enum)
            if (this.ComplianceStatus == null && Exploration.Includes(parent + ".complianceStatus$"))
            {
                this.ComplianceStatus = new List<ComplianceStatusEnum>();
            }
            //      C# -> List<FailoverStatusEnum>? FailoverStatus
            // GraphQL -> failoverStatus: [FailoverStatusEnum!] (enum)
            if (this.FailoverStatus == null && Exploration.Includes(parent + ".failoverStatus$"))
            {
                this.FailoverStatus = new List<FailoverStatusEnum>();
            }
            //      C# -> FailoverTypeEnum? FailoverType
            // GraphQL -> failoverType: FailoverTypeEnum (enum)
            if (this.FailoverType == null && Exploration.Includes(parent + ".failoverType$"))
            {
                this.FailoverType = new FailoverTypeEnum();
            }
            //      C# -> List<ActivityStatusEnum>? LastActivityStatus
            // GraphQL -> lastActivityStatus: [ActivityStatusEnum!] (enum)
            if (this.LastActivityStatus == null && Exploration.Includes(parent + ".lastActivityStatus$"))
            {
                this.LastActivityStatus = new List<ActivityStatusEnum>();
            }
            //      C# -> List<ActivityTypeEnum>? LastActivityType
            // GraphQL -> lastActivityType: [ActivityTypeEnum!] (enum)
            if (this.LastActivityType == null && Exploration.Includes(parent + ".lastActivityType$"))
            {
                this.LastActivityType = new List<ActivityTypeEnum>();
            }
            //      C# -> List<ObjectTypeEnum>? ObjectType
            // GraphQL -> objectType: [ObjectTypeEnum!] (enum)
            if (this.ObjectType == null && Exploration.Includes(parent + ".objectType$"))
            {
                this.ObjectType = new List<ObjectTypeEnum>();
            }
            //      C# -> List<ProtectionStatusEnum>? ProtectionStatus
            // GraphQL -> protectionStatus: [ProtectionStatusEnum!] (enum)
            if (this.ProtectionStatus == null && Exploration.Includes(parent + ".protectionStatus$"))
            {
                this.ProtectionStatus = new List<ProtectionStatusEnum>();
            }
            //      C# -> SlaComplianceTimeRange? SlaTimeRange
            // GraphQL -> slaTimeRange: SlaComplianceTimeRange (enum)
            if (this.SlaTimeRange == null && Exploration.Includes(parent + ".slaTimeRange$"))
            {
                this.SlaTimeRange = new SlaComplianceTimeRange();
            }
            //      C# -> List<HierarchyObjectTypeEnum>? SonarObjectTypes
            // GraphQL -> sonarObjectTypes: [HierarchyObjectTypeEnum!] (enum)
            if (this.SonarObjectTypes == null && Exploration.Includes(parent + ".sonarObjectTypes$"))
            {
                this.SonarObjectTypes = new List<HierarchyObjectTypeEnum>();
            }
            //      C# -> List<UserAuditObjectTypeEnum>? UserAuditObjectType
            // GraphQL -> userAuditObjectType: [UserAuditObjectTypeEnum!] (enum)
            if (this.UserAuditObjectType == null && Exploration.Includes(parent + ".userAuditObjectType$"))
            {
                this.UserAuditObjectType = new List<UserAuditObjectTypeEnum>();
            }
            //      C# -> List<UserAuditStatusEnum>? UserAuditStatus
            // GraphQL -> userAuditStatus: [UserAuditStatusEnum!] (enum)
            if (this.UserAuditStatus == null && Exploration.Includes(parent + ".userAuditStatus$"))
            {
                this.UserAuditStatus = new List<UserAuditStatusEnum>();
            }
            //      C# -> List<UserAuditTypeEnum>? UserAuditType
            // GraphQL -> userAuditType: [UserAuditTypeEnum!] (enum)
            if (this.UserAuditType == null && Exploration.Includes(parent + ".userAuditType$"))
            {
                this.UserAuditType = new List<UserAuditTypeEnum>();
            }
            //      C# -> List<SlaDomain>? SlaDomain
            // GraphQL -> slaDomain: [SlaDomain!] (interface)
            if (this.SlaDomain == null && Exploration.Includes(parent + ".slaDomain"))
            {
                this.SlaDomain = new List<SlaDomain>();
                this.SlaDomain.ApplyExploratoryFragment(parent + ".slaDomain");
            }
        }


    #endregion

    } // class CustomReportFilters
    #endregion

    public static class ListCustomReportFiltersExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<CustomReportFilters> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CustomReportFilters> list, 
            String parent = "")
        {
            var item = new CustomReportFilters();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types