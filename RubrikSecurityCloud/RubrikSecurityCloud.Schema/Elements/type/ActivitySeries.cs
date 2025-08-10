// ActivitySeries.cs
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
    #region ActivitySeries
    public class ActivitySeries: BaseType
    {
        #region members

        //      C# -> ActivityStatusEnum? LastActivityStatus
        // GraphQL -> lastActivityStatus: ActivityStatusEnum! (enum)
        [JsonProperty("lastActivityStatus")]
        public ActivityStatusEnum? LastActivityStatus { get; set; }

        //      C# -> ActivityTypeEnum? LastActivityType
        // GraphQL -> lastActivityType: ActivityTypeEnum! (enum)
        [JsonProperty("lastActivityType")]
        public ActivityTypeEnum? LastActivityType { get; set; }

        //      C# -> ActivityObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ActivityObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public ActivityObjectTypeEnum? ObjectType { get; set; }

        //      C# -> ActivitySeverityEnum? Severity
        // GraphQL -> severity: ActivitySeverityEnum! (enum)
        [JsonProperty("severity")]
        public ActivitySeverityEnum? Severity { get; set; }

        //      C# -> System.String? ActivitySeriesId
        // GraphQL -> activitySeriesId: UUID! (scalar)
        [JsonProperty("activitySeriesId")]
        public System.String? ActivitySeriesId { get; set; }

        //      C# -> System.Int32? AttemptNumber
        // GraphQL -> attemptNumber: Int (scalar)
        [JsonProperty("attemptNumber")]
        public System.Int32? AttemptNumber { get; set; }

        //      C# -> System.String? CauseErrorCode
        // GraphQL -> causeErrorCode: String (scalar)
        [JsonProperty("causeErrorCode")]
        public System.String? CauseErrorCode { get; set; }

        //      C# -> System.String? CauseErrorMessage
        // GraphQL -> causeErrorMessage: String (scalar)
        [JsonProperty("causeErrorMessage")]
        public System.String? CauseErrorMessage { get; set; }

        //      C# -> System.String? CauseErrorReason
        // GraphQL -> causeErrorReason: String (scalar)
        [JsonProperty("causeErrorReason")]
        public System.String? CauseErrorReason { get; set; }

        //      C# -> System.String? CauseErrorRemedy
        // GraphQL -> causeErrorRemedy: String (scalar)
        [JsonProperty("causeErrorRemedy")]
        public System.String? CauseErrorRemedy { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Int64? DataTransferred
        // GraphQL -> dataTransferred: Long (scalar)
        [JsonProperty("dataTransferred")]
        public System.Int64? DataTransferred { get; set; }

        //      C# -> System.Int64? EffectiveThroughput
        // GraphQL -> effectiveThroughput: Long (scalar)
        [JsonProperty("effectiveThroughput")]
        public System.Int64? EffectiveThroughput { get; set; }

        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String (scalar)
        [JsonProperty("failureReason")]
        public System.String? FailureReason { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        [JsonProperty("id")]
        public System.Int64? Id { get; set; }

        //      C# -> System.Boolean? IsCancelable
        // GraphQL -> isCancelable: Boolean (scalar)
        [JsonProperty("isCancelable")]
        public System.Boolean? IsCancelable { get; set; }

        //      C# -> System.Boolean? IsOnDemand
        // GraphQL -> isOnDemand: Boolean (scalar)
        [JsonProperty("isOnDemand")]
        public System.Boolean? IsOnDemand { get; set; }

        //      C# -> System.Boolean? IsPolarisEventSeries
        // GraphQL -> isPolarisEventSeries: Boolean! (scalar)
        [JsonProperty("isPolarisEventSeries")]
        public System.Boolean? IsPolarisEventSeries { get; set; }

        //      C# -> System.Boolean? IsTransactionLogEventSeries
        // GraphQL -> isTransactionLogEventSeries: Boolean (scalar)
        [JsonProperty("isTransactionLogEventSeries")]
        public System.Boolean? IsTransactionLogEventSeries { get; set; }

        //      C# -> System.String? LastActivityMessage
        // GraphQL -> lastActivityMessage: String (scalar)
        [JsonProperty("lastActivityMessage")]
        public System.String? LastActivityMessage { get; set; }

        //      C# -> DateTime? LastEventAddedAt
        // GraphQL -> lastEventAddedAt: DateTime (scalar)
        [JsonProperty("lastEventAddedAt")]
        public DateTime? LastEventAddedAt { get; set; }

        //      C# -> DateTime? LastUpdated
        // GraphQL -> lastUpdated: DateTime! (scalar)
        [JsonProperty("lastUpdated")]
        public DateTime? LastUpdated { get; set; }

        //      C# -> DateTime? LastVerifiedAt
        // GraphQL -> lastVerifiedAt: DateTime (scalar)
        [JsonProperty("lastVerifiedAt")]
        public DateTime? LastVerifiedAt { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.Int64? LogicalSize
        // GraphQL -> logicalSize: Long (scalar)
        [JsonProperty("logicalSize")]
        public System.Int64? LogicalSize { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String (scalar)
        [JsonProperty("objectName")]
        public System.String? ObjectName { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String (scalar)
        [JsonProperty("orgName")]
        public System.String? OrgName { get; set; }

        //      C# -> System.String? Progress
        // GraphQL -> progress: String (scalar)
        [JsonProperty("progress")]
        public System.String? Progress { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        //      C# -> System.String? UrlMetadata
        // GraphQL -> urlMetadata: String (scalar)
        [JsonProperty("urlMetadata")]
        public System.String? UrlMetadata { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> ActivityConnection? ActivityConnection
        // GraphQL -> activityConnection: ActivityConnection! (type)
        [JsonProperty("activityConnection")]
        public ActivityConnection? ActivityConnection { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> List<Org>? Organizations
        // GraphQL -> organizations: [Org!]! (type)
        [JsonProperty("organizations")]
        public List<Org>? Organizations { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars ActivityConnection { get; set; }


        public InlineVars() {
            Tuple<string, string>[] activityConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                };
            this.ActivityConnection =
                new RscGqlVars(null, activityConnectionArgs, null, true);
        }
    }

    public ActivitySeries()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "ActivitySeries";
    }

    public ActivitySeries Set(
        ActivityStatusEnum? LastActivityStatus = null,
        ActivityTypeEnum? LastActivityType = null,
        ActivityObjectTypeEnum? ObjectType = null,
        ActivitySeverityEnum? Severity = null,
        System.String? ActivitySeriesId = null,
        System.Int32? AttemptNumber = null,
        System.String? CauseErrorCode = null,
        System.String? CauseErrorMessage = null,
        System.String? CauseErrorReason = null,
        System.String? CauseErrorRemedy = null,
        System.String? ClusterName = null,
        System.String? ClusterUuid = null,
        System.Int64? DataTransferred = null,
        System.Int64? EffectiveThroughput = null,
        System.String? FailureReason = null,
        System.String? Fid = null,
        System.Int64? Id = null,
        System.Boolean? IsCancelable = null,
        System.Boolean? IsOnDemand = null,
        System.Boolean? IsPolarisEventSeries = null,
        System.Boolean? IsTransactionLogEventSeries = null,
        System.String? LastActivityMessage = null,
        DateTime? LastEventAddedAt = null,
        DateTime? LastUpdated = null,
        DateTime? LastVerifiedAt = null,
        System.String? Location = null,
        System.Int64? LogicalSize = null,
        System.String? ObjectId = null,
        System.String? ObjectName = null,
        System.String? OrgId = null,
        System.String? OrgName = null,
        System.String? Progress = null,
        DateTime? StartTime = null,
        System.String? UrlMetadata = null,
        System.String? Username = null,
        ActivityConnection? ActivityConnection = null,
        Cluster? Cluster = null,
        List<Org>? Organizations = null
    ) 
    {
        if ( LastActivityStatus != null ) {
            this.LastActivityStatus = LastActivityStatus;
        }
        if ( LastActivityType != null ) {
            this.LastActivityType = LastActivityType;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( ActivitySeriesId != null ) {
            this.ActivitySeriesId = ActivitySeriesId;
        }
        if ( AttemptNumber != null ) {
            this.AttemptNumber = AttemptNumber;
        }
        if ( CauseErrorCode != null ) {
            this.CauseErrorCode = CauseErrorCode;
        }
        if ( CauseErrorMessage != null ) {
            this.CauseErrorMessage = CauseErrorMessage;
        }
        if ( CauseErrorReason != null ) {
            this.CauseErrorReason = CauseErrorReason;
        }
        if ( CauseErrorRemedy != null ) {
            this.CauseErrorRemedy = CauseErrorRemedy;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( DataTransferred != null ) {
            this.DataTransferred = DataTransferred;
        }
        if ( EffectiveThroughput != null ) {
            this.EffectiveThroughput = EffectiveThroughput;
        }
        if ( FailureReason != null ) {
            this.FailureReason = FailureReason;
        }
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsCancelable != null ) {
            this.IsCancelable = IsCancelable;
        }
        if ( IsOnDemand != null ) {
            this.IsOnDemand = IsOnDemand;
        }
        if ( IsPolarisEventSeries != null ) {
            this.IsPolarisEventSeries = IsPolarisEventSeries;
        }
        if ( IsTransactionLogEventSeries != null ) {
            this.IsTransactionLogEventSeries = IsTransactionLogEventSeries;
        }
        if ( LastActivityMessage != null ) {
            this.LastActivityMessage = LastActivityMessage;
        }
        if ( LastEventAddedAt != null ) {
            this.LastEventAddedAt = LastEventAddedAt;
        }
        if ( LastUpdated != null ) {
            this.LastUpdated = LastUpdated;
        }
        if ( LastVerifiedAt != null ) {
            this.LastVerifiedAt = LastVerifiedAt;
        }
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( LogicalSize != null ) {
            this.LogicalSize = LogicalSize;
        }
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
        }
        if ( ObjectName != null ) {
            this.ObjectName = ObjectName;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( OrgName != null ) {
            this.OrgName = OrgName;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( UrlMetadata != null ) {
            this.UrlMetadata = UrlMetadata;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( ActivityConnection != null ) {
            this.ActivityConnection = ActivityConnection;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( Organizations != null ) {
            this.Organizations = Organizations;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ActivityStatusEnum? LastActivityStatus
        // GraphQL -> lastActivityStatus: ActivityStatusEnum! (enum)
        if (this.LastActivityStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastActivityStatus\n" ;
            } else {
                s += ind + "lastActivityStatus\n" ;
            }
        }
        //      C# -> ActivityTypeEnum? LastActivityType
        // GraphQL -> lastActivityType: ActivityTypeEnum! (enum)
        if (this.LastActivityType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastActivityType\n" ;
            } else {
                s += ind + "lastActivityType\n" ;
            }
        }
        //      C# -> ActivityObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ActivityObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> ActivitySeverityEnum? Severity
        // GraphQL -> severity: ActivitySeverityEnum! (enum)
        if (this.Severity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "severity\n" ;
            } else {
                s += ind + "severity\n" ;
            }
        }
        //      C# -> System.String? ActivitySeriesId
        // GraphQL -> activitySeriesId: UUID! (scalar)
        if (this.ActivitySeriesId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activitySeriesId\n" ;
            } else {
                s += ind + "activitySeriesId\n" ;
            }
        }
        //      C# -> System.Int32? AttemptNumber
        // GraphQL -> attemptNumber: Int (scalar)
        if (this.AttemptNumber != null) {
            if (conf.Flat) {
                s += conf.Prefix + "attemptNumber\n" ;
            } else {
                s += ind + "attemptNumber\n" ;
            }
        }
        //      C# -> System.String? CauseErrorCode
        // GraphQL -> causeErrorCode: String (scalar)
        if (this.CauseErrorCode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "causeErrorCode\n" ;
            } else {
                s += ind + "causeErrorCode\n" ;
            }
        }
        //      C# -> System.String? CauseErrorMessage
        // GraphQL -> causeErrorMessage: String (scalar)
        if (this.CauseErrorMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "causeErrorMessage\n" ;
            } else {
                s += ind + "causeErrorMessage\n" ;
            }
        }
        //      C# -> System.String? CauseErrorReason
        // GraphQL -> causeErrorReason: String (scalar)
        if (this.CauseErrorReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "causeErrorReason\n" ;
            } else {
                s += ind + "causeErrorReason\n" ;
            }
        }
        //      C# -> System.String? CauseErrorRemedy
        // GraphQL -> causeErrorRemedy: String (scalar)
        if (this.CauseErrorRemedy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "causeErrorRemedy\n" ;
            } else {
                s += ind + "causeErrorRemedy\n" ;
            }
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterName\n" ;
            } else {
                s += ind + "clusterName\n" ;
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.Int64? DataTransferred
        // GraphQL -> dataTransferred: Long (scalar)
        if (this.DataTransferred != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataTransferred\n" ;
            } else {
                s += ind + "dataTransferred\n" ;
            }
        }
        //      C# -> System.Int64? EffectiveThroughput
        // GraphQL -> effectiveThroughput: Long (scalar)
        if (this.EffectiveThroughput != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveThroughput\n" ;
            } else {
                s += ind + "effectiveThroughput\n" ;
            }
        }
        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String (scalar)
        if (this.FailureReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failureReason\n" ;
            } else {
                s += ind + "failureReason\n" ;
            }
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (this.Fid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fid\n" ;
            } else {
                s += ind + "fid\n" ;
            }
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsCancelable
        // GraphQL -> isCancelable: Boolean (scalar)
        if (this.IsCancelable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isCancelable\n" ;
            } else {
                s += ind + "isCancelable\n" ;
            }
        }
        //      C# -> System.Boolean? IsOnDemand
        // GraphQL -> isOnDemand: Boolean (scalar)
        if (this.IsOnDemand != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isOnDemand\n" ;
            } else {
                s += ind + "isOnDemand\n" ;
            }
        }
        //      C# -> System.Boolean? IsPolarisEventSeries
        // GraphQL -> isPolarisEventSeries: Boolean! (scalar)
        if (this.IsPolarisEventSeries != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPolarisEventSeries\n" ;
            } else {
                s += ind + "isPolarisEventSeries\n" ;
            }
        }
        //      C# -> System.Boolean? IsTransactionLogEventSeries
        // GraphQL -> isTransactionLogEventSeries: Boolean (scalar)
        if (this.IsTransactionLogEventSeries != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isTransactionLogEventSeries\n" ;
            } else {
                s += ind + "isTransactionLogEventSeries\n" ;
            }
        }
        //      C# -> System.String? LastActivityMessage
        // GraphQL -> lastActivityMessage: String (scalar)
        if (this.LastActivityMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastActivityMessage\n" ;
            } else {
                s += ind + "lastActivityMessage\n" ;
            }
        }
        //      C# -> DateTime? LastEventAddedAt
        // GraphQL -> lastEventAddedAt: DateTime (scalar)
        if (this.LastEventAddedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastEventAddedAt\n" ;
            } else {
                s += ind + "lastEventAddedAt\n" ;
            }
        }
        //      C# -> DateTime? LastUpdated
        // GraphQL -> lastUpdated: DateTime! (scalar)
        if (this.LastUpdated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastUpdated\n" ;
            } else {
                s += ind + "lastUpdated\n" ;
            }
        }
        //      C# -> DateTime? LastVerifiedAt
        // GraphQL -> lastVerifiedAt: DateTime (scalar)
        if (this.LastVerifiedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastVerifiedAt\n" ;
            } else {
                s += ind + "lastVerifiedAt\n" ;
            }
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location != null) {
            if (conf.Flat) {
                s += conf.Prefix + "location\n" ;
            } else {
                s += ind + "location\n" ;
            }
        }
        //      C# -> System.Int64? LogicalSize
        // GraphQL -> logicalSize: Long (scalar)
        if (this.LogicalSize != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logicalSize\n" ;
            } else {
                s += ind + "logicalSize\n" ;
            }
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectId\n" ;
            } else {
                s += ind + "objectId\n" ;
            }
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String (scalar)
        if (this.ObjectName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectName\n" ;
            } else {
                s += ind + "objectName\n" ;
            }
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID (scalar)
        if (this.OrgId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgId\n" ;
            } else {
                s += ind + "orgId\n" ;
            }
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String (scalar)
        if (this.OrgName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgName\n" ;
            } else {
                s += ind + "orgName\n" ;
            }
        }
        //      C# -> System.String? Progress
        // GraphQL -> progress: String (scalar)
        if (this.Progress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "progress\n" ;
            } else {
                s += ind + "progress\n" ;
            }
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        //      C# -> System.String? UrlMetadata
        // GraphQL -> urlMetadata: String (scalar)
        if (this.UrlMetadata != null) {
            if (conf.Flat) {
                s += conf.Prefix + "urlMetadata\n" ;
            } else {
                s += ind + "urlMetadata\n" ;
            }
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        if (this.Username != null) {
            if (conf.Flat) {
                s += conf.Prefix + "username\n" ;
            } else {
                s += ind + "username\n" ;
            }
        }
        //      C# -> ActivityConnection? ActivityConnection
        // GraphQL -> activityConnection: ActivityConnection! (type)
        if (this.ActivityConnection != null) {
            var fspec = this.ActivityConnection.AsFieldSpec(conf.Child("activityConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "activityConnection" + "\n(" + this.Vars.ActivityConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<Org>? Organizations
        // GraphQL -> organizations: [Org!]! (type)
        if (this.Organizations != null) {
            var fspec = this.Organizations.AsFieldSpec(conf.Child("organizations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "organizations" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ActivityStatusEnum? LastActivityStatus
        // GraphQL -> lastActivityStatus: ActivityStatusEnum! (enum)
        if (ec.Includes("lastActivityStatus",true))
        {
            if(this.LastActivityStatus == null) {

                this.LastActivityStatus = new ActivityStatusEnum();

            } else {


            }
        }
        else if (this.LastActivityStatus != null && ec.Excludes("lastActivityStatus",true))
        {
            this.LastActivityStatus = null;
        }
        //      C# -> ActivityTypeEnum? LastActivityType
        // GraphQL -> lastActivityType: ActivityTypeEnum! (enum)
        if (ec.Includes("lastActivityType",true))
        {
            if(this.LastActivityType == null) {

                this.LastActivityType = new ActivityTypeEnum();

            } else {


            }
        }
        else if (this.LastActivityType != null && ec.Excludes("lastActivityType",true))
        {
            this.LastActivityType = null;
        }
        //      C# -> ActivityObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ActivityObjectTypeEnum! (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new ActivityObjectTypeEnum();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> ActivitySeverityEnum? Severity
        // GraphQL -> severity: ActivitySeverityEnum! (enum)
        if (ec.Includes("severity",true))
        {
            if(this.Severity == null) {

                this.Severity = new ActivitySeverityEnum();

            } else {


            }
        }
        else if (this.Severity != null && ec.Excludes("severity",true))
        {
            this.Severity = null;
        }
        //      C# -> System.String? ActivitySeriesId
        // GraphQL -> activitySeriesId: UUID! (scalar)
        if (ec.Includes("activitySeriesId",true))
        {
            if(this.ActivitySeriesId == null) {

                this.ActivitySeriesId = "FETCH";

            } else {


            }
        }
        else if (this.ActivitySeriesId != null && ec.Excludes("activitySeriesId",true))
        {
            this.ActivitySeriesId = null;
        }
        //      C# -> System.Int32? AttemptNumber
        // GraphQL -> attemptNumber: Int (scalar)
        if (ec.Includes("attemptNumber",true))
        {
            if(this.AttemptNumber == null) {

                this.AttemptNumber = Int32.MinValue;

            } else {


            }
        }
        else if (this.AttemptNumber != null && ec.Excludes("attemptNumber",true))
        {
            this.AttemptNumber = null;
        }
        //      C# -> System.String? CauseErrorCode
        // GraphQL -> causeErrorCode: String (scalar)
        if (ec.Includes("causeErrorCode",true))
        {
            if(this.CauseErrorCode == null) {

                this.CauseErrorCode = "FETCH";

            } else {


            }
        }
        else if (this.CauseErrorCode != null && ec.Excludes("causeErrorCode",true))
        {
            this.CauseErrorCode = null;
        }
        //      C# -> System.String? CauseErrorMessage
        // GraphQL -> causeErrorMessage: String (scalar)
        if (ec.Includes("causeErrorMessage",true))
        {
            if(this.CauseErrorMessage == null) {

                this.CauseErrorMessage = "FETCH";

            } else {


            }
        }
        else if (this.CauseErrorMessage != null && ec.Excludes("causeErrorMessage",true))
        {
            this.CauseErrorMessage = null;
        }
        //      C# -> System.String? CauseErrorReason
        // GraphQL -> causeErrorReason: String (scalar)
        if (ec.Includes("causeErrorReason",true))
        {
            if(this.CauseErrorReason == null) {

                this.CauseErrorReason = "FETCH";

            } else {


            }
        }
        else if (this.CauseErrorReason != null && ec.Excludes("causeErrorReason",true))
        {
            this.CauseErrorReason = null;
        }
        //      C# -> System.String? CauseErrorRemedy
        // GraphQL -> causeErrorRemedy: String (scalar)
        if (ec.Includes("causeErrorRemedy",true))
        {
            if(this.CauseErrorRemedy == null) {

                this.CauseErrorRemedy = "FETCH";

            } else {


            }
        }
        else if (this.CauseErrorRemedy != null && ec.Excludes("causeErrorRemedy",true))
        {
            this.CauseErrorRemedy = null;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (ec.Includes("clusterName",true))
        {
            if(this.ClusterName == null) {

                this.ClusterName = "FETCH";

            } else {


            }
        }
        else if (this.ClusterName != null && ec.Excludes("clusterName",true))
        {
            this.ClusterName = null;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> System.Int64? DataTransferred
        // GraphQL -> dataTransferred: Long (scalar)
        if (ec.Includes("dataTransferred",true))
        {
            if(this.DataTransferred == null) {

                this.DataTransferred = new System.Int64();

            } else {


            }
        }
        else if (this.DataTransferred != null && ec.Excludes("dataTransferred",true))
        {
            this.DataTransferred = null;
        }
        //      C# -> System.Int64? EffectiveThroughput
        // GraphQL -> effectiveThroughput: Long (scalar)
        if (ec.Includes("effectiveThroughput",true))
        {
            if(this.EffectiveThroughput == null) {

                this.EffectiveThroughput = new System.Int64();

            } else {


            }
        }
        else if (this.EffectiveThroughput != null && ec.Excludes("effectiveThroughput",true))
        {
            this.EffectiveThroughput = null;
        }
        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String (scalar)
        if (ec.Includes("failureReason",true))
        {
            if(this.FailureReason == null) {

                this.FailureReason = "FETCH";

            } else {


            }
        }
        else if (this.FailureReason != null && ec.Excludes("failureReason",true))
        {
            this.FailureReason = null;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (ec.Includes("fid",true))
        {
            if(this.Fid == null) {

                this.Fid = "FETCH";

            } else {


            }
        }
        else if (this.Fid != null && ec.Excludes("fid",true))
        {
            this.Fid = null;
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = new System.Int64();

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsCancelable
        // GraphQL -> isCancelable: Boolean (scalar)
        if (ec.Includes("isCancelable",true))
        {
            if(this.IsCancelable == null) {

                this.IsCancelable = true;

            } else {


            }
        }
        else if (this.IsCancelable != null && ec.Excludes("isCancelable",true))
        {
            this.IsCancelable = null;
        }
        //      C# -> System.Boolean? IsOnDemand
        // GraphQL -> isOnDemand: Boolean (scalar)
        if (ec.Includes("isOnDemand",true))
        {
            if(this.IsOnDemand == null) {

                this.IsOnDemand = true;

            } else {


            }
        }
        else if (this.IsOnDemand != null && ec.Excludes("isOnDemand",true))
        {
            this.IsOnDemand = null;
        }
        //      C# -> System.Boolean? IsPolarisEventSeries
        // GraphQL -> isPolarisEventSeries: Boolean! (scalar)
        if (ec.Includes("isPolarisEventSeries",true))
        {
            if(this.IsPolarisEventSeries == null) {

                this.IsPolarisEventSeries = true;

            } else {


            }
        }
        else if (this.IsPolarisEventSeries != null && ec.Excludes("isPolarisEventSeries",true))
        {
            this.IsPolarisEventSeries = null;
        }
        //      C# -> System.Boolean? IsTransactionLogEventSeries
        // GraphQL -> isTransactionLogEventSeries: Boolean (scalar)
        if (ec.Includes("isTransactionLogEventSeries",true))
        {
            if(this.IsTransactionLogEventSeries == null) {

                this.IsTransactionLogEventSeries = true;

            } else {


            }
        }
        else if (this.IsTransactionLogEventSeries != null && ec.Excludes("isTransactionLogEventSeries",true))
        {
            this.IsTransactionLogEventSeries = null;
        }
        //      C# -> System.String? LastActivityMessage
        // GraphQL -> lastActivityMessage: String (scalar)
        if (ec.Includes("lastActivityMessage",true))
        {
            if(this.LastActivityMessage == null) {

                this.LastActivityMessage = "FETCH";

            } else {


            }
        }
        else if (this.LastActivityMessage != null && ec.Excludes("lastActivityMessage",true))
        {
            this.LastActivityMessage = null;
        }
        //      C# -> DateTime? LastEventAddedAt
        // GraphQL -> lastEventAddedAt: DateTime (scalar)
        if (ec.Includes("lastEventAddedAt",true))
        {
            if(this.LastEventAddedAt == null) {

                this.LastEventAddedAt = new DateTime();

            } else {


            }
        }
        else if (this.LastEventAddedAt != null && ec.Excludes("lastEventAddedAt",true))
        {
            this.LastEventAddedAt = null;
        }
        //      C# -> DateTime? LastUpdated
        // GraphQL -> lastUpdated: DateTime! (scalar)
        if (ec.Includes("lastUpdated",true))
        {
            if(this.LastUpdated == null) {

                this.LastUpdated = new DateTime();

            } else {


            }
        }
        else if (this.LastUpdated != null && ec.Excludes("lastUpdated",true))
        {
            this.LastUpdated = null;
        }
        //      C# -> DateTime? LastVerifiedAt
        // GraphQL -> lastVerifiedAt: DateTime (scalar)
        if (ec.Includes("lastVerifiedAt",true))
        {
            if(this.LastVerifiedAt == null) {

                this.LastVerifiedAt = new DateTime();

            } else {


            }
        }
        else if (this.LastVerifiedAt != null && ec.Excludes("lastVerifiedAt",true))
        {
            this.LastVerifiedAt = null;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (ec.Includes("location",true))
        {
            if(this.Location == null) {

                this.Location = "FETCH";

            } else {


            }
        }
        else if (this.Location != null && ec.Excludes("location",true))
        {
            this.Location = null;
        }
        //      C# -> System.Int64? LogicalSize
        // GraphQL -> logicalSize: Long (scalar)
        if (ec.Includes("logicalSize",true))
        {
            if(this.LogicalSize == null) {

                this.LogicalSize = new System.Int64();

            } else {


            }
        }
        else if (this.LogicalSize != null && ec.Excludes("logicalSize",true))
        {
            this.LogicalSize = null;
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (ec.Includes("objectId",true))
        {
            if(this.ObjectId == null) {

                this.ObjectId = "FETCH";

            } else {


            }
        }
        else if (this.ObjectId != null && ec.Excludes("objectId",true))
        {
            this.ObjectId = null;
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String (scalar)
        if (ec.Includes("objectName",true))
        {
            if(this.ObjectName == null) {

                this.ObjectName = "FETCH";

            } else {


            }
        }
        else if (this.ObjectName != null && ec.Excludes("objectName",true))
        {
            this.ObjectName = null;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID (scalar)
        if (ec.Includes("orgId",true))
        {
            if(this.OrgId == null) {

                this.OrgId = "FETCH";

            } else {


            }
        }
        else if (this.OrgId != null && ec.Excludes("orgId",true))
        {
            this.OrgId = null;
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String (scalar)
        if (ec.Includes("orgName",true))
        {
            if(this.OrgName == null) {

                this.OrgName = "FETCH";

            } else {


            }
        }
        else if (this.OrgName != null && ec.Excludes("orgName",true))
        {
            this.OrgName = null;
        }
        //      C# -> System.String? Progress
        // GraphQL -> progress: String (scalar)
        if (ec.Includes("progress",true))
        {
            if(this.Progress == null) {

                this.Progress = "FETCH";

            } else {


            }
        }
        else if (this.Progress != null && ec.Excludes("progress",true))
        {
            this.Progress = null;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (ec.Includes("startTime",true))
        {
            if(this.StartTime == null) {

                this.StartTime = new DateTime();

            } else {


            }
        }
        else if (this.StartTime != null && ec.Excludes("startTime",true))
        {
            this.StartTime = null;
        }
        //      C# -> System.String? UrlMetadata
        // GraphQL -> urlMetadata: String (scalar)
        if (ec.Includes("urlMetadata",true))
        {
            if(this.UrlMetadata == null) {

                this.UrlMetadata = "FETCH";

            } else {


            }
        }
        else if (this.UrlMetadata != null && ec.Excludes("urlMetadata",true))
        {
            this.UrlMetadata = null;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        if (ec.Includes("username",true))
        {
            if(this.Username == null) {

                this.Username = "FETCH";

            } else {


            }
        }
        else if (this.Username != null && ec.Excludes("username",true))
        {
            this.Username = null;
        }
        //      C# -> ActivityConnection? ActivityConnection
        // GraphQL -> activityConnection: ActivityConnection! (type)
        if (ec.Includes("activityConnection",false))
        {
            if(this.ActivityConnection == null) {

                this.ActivityConnection = new ActivityConnection();
                this.ActivityConnection.ApplyExploratoryFieldSpec(ec.NewChild("activityConnection"));

            } else {

                this.ActivityConnection.ApplyExploratoryFieldSpec(ec.NewChild("activityConnection"));

            }
        }
        else if (this.ActivityConnection != null && ec.Excludes("activityConnection",false))
        {
            this.ActivityConnection = null;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
        //      C# -> List<Org>? Organizations
        // GraphQL -> organizations: [Org!]! (type)
        if (ec.Includes("organizations",false))
        {
            if(this.Organizations == null) {

                this.Organizations = new List<Org>();
                this.Organizations.ApplyExploratoryFieldSpec(ec.NewChild("organizations"));

            } else {

                this.Organizations.ApplyExploratoryFieldSpec(ec.NewChild("organizations"));

            }
        }
        else if (this.Organizations != null && ec.Excludes("organizations",false))
        {
            this.Organizations = null;
        }
    }


    #endregion

    } // class ActivitySeries
    
    #endregion

    public static class ListActivitySeriesExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ActivitySeries> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActivitySeries> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActivitySeries> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActivitySeries());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActivitySeries> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types