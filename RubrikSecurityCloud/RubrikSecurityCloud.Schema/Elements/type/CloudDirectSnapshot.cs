// CloudDirectSnapshot.cs
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
    #region CloudDirectSnapshot
 
    public class CloudDirectSnapshot: BaseType, GenericSnapshot
    {
        #region members

        //      C# -> CloudDirectSnapshotProtocolType? Protocol
        // GraphQL -> protocol: CloudDirectSnapshotProtocolType! (enum)
        [JsonProperty("protocol")]
        public CloudDirectSnapshotProtocolType? Protocol { get; set; }

        //      C# -> CloudDirectSnapshotSateType? State
        // GraphQL -> state: CloudDirectSnapshotSateType! (enum)
        [JsonProperty("state")]
        public CloudDirectSnapshotSateType? State { get; set; }

        //      C# -> CloudDirectSnapshotType? Type
        // GraphQL -> type: CloudDirectSnapshotType! (enum)
        [JsonProperty("type")]
        public CloudDirectSnapshotType? Type { get; set; }

        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        [JsonProperty("slaDomain")]
        public SlaDomain? SlaDomain { get; set; }

        //      C# -> System.String? CloudDirectId
        // GraphQL -> cloudDirectId: UUID! (scalar)
        [JsonProperty("cloudDirectId")]
        public System.String? CloudDirectId { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> DateTime? Completed
        // GraphQL -> completed: DateTime (scalar)
        [JsonProperty("completed")]
        public DateTime? Completed { get; set; }

        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        [JsonProperty("expirationDate")]
        public DateTime? ExpirationDate { get; set; }

        //      C# -> System.Boolean? ExpiryHint
        // GraphQL -> expiryHint: Boolean! (scalar)
        [JsonProperty("expiryHint")]
        public System.Boolean? ExpiryHint { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int64? IndexingAttempts
        // GraphQL -> indexingAttempts: Long! (scalar)
        [JsonProperty("indexingAttempts")]
        public System.Int64? IndexingAttempts { get; set; }

        //      C# -> System.Boolean? IsCorrupted
        // GraphQL -> isCorrupted: Boolean! (scalar)
        [JsonProperty("isCorrupted")]
        public System.Boolean? IsCorrupted { get; set; }

        //      C# -> System.Boolean? IsDownloadedSnapshot
        // GraphQL -> isDownloadedSnapshot: Boolean (scalar)
        [JsonProperty("isDownloadedSnapshot")]
        public System.Boolean? IsDownloadedSnapshot { get; set; }

        //      C# -> System.Boolean? IsExpired
        // GraphQL -> isExpired: Boolean! (scalar)
        [JsonProperty("isExpired")]
        public System.Boolean? IsExpired { get; set; }

        //      C# -> System.Boolean? IsIndexed
        // GraphQL -> isIndexed: Boolean! (scalar)
        [JsonProperty("isIndexed")]
        public System.Boolean? IsIndexed { get; set; }

        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        [JsonProperty("isOnDemandSnapshot")]
        public System.Boolean? IsOnDemandSnapshot { get; set; }

        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        [JsonProperty("isQuarantined")]
        public System.Boolean? IsQuarantined { get; set; }

        //      C# -> System.Boolean? IsUnindexable
        // GraphQL -> isUnindexable: Boolean! (scalar)
        [JsonProperty("isUnindexable")]
        public System.Boolean? IsUnindexable { get; set; }

        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        [JsonProperty("policyName")]
        public System.String? PolicyName { get; set; }

        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        [JsonProperty("snappableId")]
        public System.String? SnappableId { get; set; }

        //      C# -> System.String? SystemId
        // GraphQL -> systemId: String! (scalar)
        [JsonProperty("systemId")]
        public System.String? SystemId { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> CloudDirectNasShare? Share
        // GraphQL -> share: CloudDirectNasShare! (type)
        [JsonProperty("share")]
        public CloudDirectNasShare? Share { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudDirectSnapshot";
    }

    public CloudDirectSnapshot Set(
        CloudDirectSnapshotProtocolType? Protocol = null,
        CloudDirectSnapshotSateType? State = null,
        CloudDirectSnapshotType? Type = null,
        SlaDomain? SlaDomain = null,
        System.String? CloudDirectId = null,
        System.String? ClusterUuid = null,
        DateTime? Completed = null,
        DateTime? Date = null,
        DateTime? ExpirationDate = null,
        System.Boolean? ExpiryHint = null,
        System.String? Id = null,
        System.Int64? IndexingAttempts = null,
        System.Boolean? IsCorrupted = null,
        System.Boolean? IsDownloadedSnapshot = null,
        System.Boolean? IsExpired = null,
        System.Boolean? IsIndexed = null,
        System.Boolean? IsOnDemandSnapshot = null,
        System.Boolean? IsQuarantined = null,
        System.Boolean? IsUnindexable = null,
        System.String? PolicyName = null,
        System.String? SnappableId = null,
        System.String? SystemId = null,
        System.String? WorkloadId = null,
        CloudDirectNasShare? Share = null
    ) 
    {
        if ( Protocol != null ) {
            this.Protocol = Protocol;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( SlaDomain != null ) {
            this.SlaDomain = SlaDomain;
        }
        if ( CloudDirectId != null ) {
            this.CloudDirectId = CloudDirectId;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( Completed != null ) {
            this.Completed = Completed;
        }
        if ( Date != null ) {
            this.Date = Date;
        }
        if ( ExpirationDate != null ) {
            this.ExpirationDate = ExpirationDate;
        }
        if ( ExpiryHint != null ) {
            this.ExpiryHint = ExpiryHint;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IndexingAttempts != null ) {
            this.IndexingAttempts = IndexingAttempts;
        }
        if ( IsCorrupted != null ) {
            this.IsCorrupted = IsCorrupted;
        }
        if ( IsDownloadedSnapshot != null ) {
            this.IsDownloadedSnapshot = IsDownloadedSnapshot;
        }
        if ( IsExpired != null ) {
            this.IsExpired = IsExpired;
        }
        if ( IsIndexed != null ) {
            this.IsIndexed = IsIndexed;
        }
        if ( IsOnDemandSnapshot != null ) {
            this.IsOnDemandSnapshot = IsOnDemandSnapshot;
        }
        if ( IsQuarantined != null ) {
            this.IsQuarantined = IsQuarantined;
        }
        if ( IsUnindexable != null ) {
            this.IsUnindexable = IsUnindexable;
        }
        if ( PolicyName != null ) {
            this.PolicyName = PolicyName;
        }
        if ( SnappableId != null ) {
            this.SnappableId = SnappableId;
        }
        if ( SystemId != null ) {
            this.SystemId = SystemId;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
        }
        if ( Share != null ) {
            this.Share = Share;
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
        //      C# -> CloudDirectSnapshotProtocolType? Protocol
        // GraphQL -> protocol: CloudDirectSnapshotProtocolType! (enum)
        if (this.Protocol != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protocol\n" ;
            } else {
                s += ind + "protocol\n" ;
            }
        }
        //      C# -> CloudDirectSnapshotSateType? State
        // GraphQL -> state: CloudDirectSnapshotSateType! (enum)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        //      C# -> CloudDirectSnapshotType? Type
        // GraphQL -> type: CloudDirectSnapshotType! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        if (this.SlaDomain != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.SlaDomain, conf.Child("slaDomain"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slaDomain" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? CloudDirectId
        // GraphQL -> cloudDirectId: UUID! (scalar)
        if (this.CloudDirectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudDirectId\n" ;
            } else {
                s += ind + "cloudDirectId\n" ;
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
        //      C# -> DateTime? Completed
        // GraphQL -> completed: DateTime (scalar)
        if (this.Completed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "completed\n" ;
            } else {
                s += ind + "completed\n" ;
            }
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        if (this.Date != null) {
            if (conf.Flat) {
                s += conf.Prefix + "date\n" ;
            } else {
                s += ind + "date\n" ;
            }
        }
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (this.ExpirationDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expirationDate\n" ;
            } else {
                s += ind + "expirationDate\n" ;
            }
        }
        //      C# -> System.Boolean? ExpiryHint
        // GraphQL -> expiryHint: Boolean! (scalar)
        if (this.ExpiryHint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expiryHint\n" ;
            } else {
                s += ind + "expiryHint\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Int64? IndexingAttempts
        // GraphQL -> indexingAttempts: Long! (scalar)
        if (this.IndexingAttempts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "indexingAttempts\n" ;
            } else {
                s += ind + "indexingAttempts\n" ;
            }
        }
        //      C# -> System.Boolean? IsCorrupted
        // GraphQL -> isCorrupted: Boolean! (scalar)
        if (this.IsCorrupted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isCorrupted\n" ;
            } else {
                s += ind + "isCorrupted\n" ;
            }
        }
        //      C# -> System.Boolean? IsDownloadedSnapshot
        // GraphQL -> isDownloadedSnapshot: Boolean (scalar)
        if (this.IsDownloadedSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDownloadedSnapshot\n" ;
            } else {
                s += ind + "isDownloadedSnapshot\n" ;
            }
        }
        //      C# -> System.Boolean? IsExpired
        // GraphQL -> isExpired: Boolean! (scalar)
        if (this.IsExpired != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isExpired\n" ;
            } else {
                s += ind + "isExpired\n" ;
            }
        }
        //      C# -> System.Boolean? IsIndexed
        // GraphQL -> isIndexed: Boolean! (scalar)
        if (this.IsIndexed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isIndexed\n" ;
            } else {
                s += ind + "isIndexed\n" ;
            }
        }
        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        if (this.IsOnDemandSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isOnDemandSnapshot\n" ;
            } else {
                s += ind + "isOnDemandSnapshot\n" ;
            }
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (this.IsQuarantined != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isQuarantined\n" ;
            } else {
                s += ind + "isQuarantined\n" ;
            }
        }
        //      C# -> System.Boolean? IsUnindexable
        // GraphQL -> isUnindexable: Boolean! (scalar)
        if (this.IsUnindexable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isUnindexable\n" ;
            } else {
                s += ind + "isUnindexable\n" ;
            }
        }
        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        if (this.PolicyName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyName\n" ;
            } else {
                s += ind + "policyName\n" ;
            }
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappableId\n" ;
            } else {
                s += ind + "snappableId\n" ;
            }
        }
        //      C# -> System.String? SystemId
        // GraphQL -> systemId: String! (scalar)
        if (this.SystemId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "systemId\n" ;
            } else {
                s += ind + "systemId\n" ;
            }
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        if (this.WorkloadId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadId\n" ;
            } else {
                s += ind + "workloadId\n" ;
            }
        }
        //      C# -> CloudDirectNasShare? Share
        // GraphQL -> share: CloudDirectNasShare! (type)
        if (this.Share != null) {
            var fspec = this.Share.AsFieldSpec(conf.Child("share"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "share" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CloudDirectSnapshotProtocolType? Protocol
        // GraphQL -> protocol: CloudDirectSnapshotProtocolType! (enum)
        if (ec.Includes("protocol",true))
        {
            if(this.Protocol == null) {

                this.Protocol = new CloudDirectSnapshotProtocolType();

            } else {


            }
        }
        else if (this.Protocol != null && ec.Excludes("protocol",true))
        {
            this.Protocol = null;
        }
        //      C# -> CloudDirectSnapshotSateType? State
        // GraphQL -> state: CloudDirectSnapshotSateType! (enum)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = new CloudDirectSnapshotSateType();

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
        //      C# -> CloudDirectSnapshotType? Type
        // GraphQL -> type: CloudDirectSnapshotType! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new CloudDirectSnapshotType();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        if (ec.Includes("slaDomain",false))
        {
            if(this.SlaDomain == null) {

                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("slaDomain"));
                this.SlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("slaDomain"));
                this.SlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.SlaDomain != null && ec.Excludes("slaDomain",false))
        {
            this.SlaDomain = null;
        }
        //      C# -> System.String? CloudDirectId
        // GraphQL -> cloudDirectId: UUID! (scalar)
        if (ec.Includes("cloudDirectId",true))
        {
            if(this.CloudDirectId == null) {

                this.CloudDirectId = "FETCH";

            } else {


            }
        }
        else if (this.CloudDirectId != null && ec.Excludes("cloudDirectId",true))
        {
            this.CloudDirectId = null;
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
        //      C# -> DateTime? Completed
        // GraphQL -> completed: DateTime (scalar)
        if (ec.Includes("completed",true))
        {
            if(this.Completed == null) {

                this.Completed = new DateTime();

            } else {


            }
        }
        else if (this.Completed != null && ec.Excludes("completed",true))
        {
            this.Completed = null;
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
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
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (ec.Includes("expirationDate",true))
        {
            if(this.ExpirationDate == null) {

                this.ExpirationDate = new DateTime();

            } else {


            }
        }
        else if (this.ExpirationDate != null && ec.Excludes("expirationDate",true))
        {
            this.ExpirationDate = null;
        }
        //      C# -> System.Boolean? ExpiryHint
        // GraphQL -> expiryHint: Boolean! (scalar)
        if (ec.Includes("expiryHint",true))
        {
            if(this.ExpiryHint == null) {

                this.ExpiryHint = true;

            } else {


            }
        }
        else if (this.ExpiryHint != null && ec.Excludes("expiryHint",true))
        {
            this.ExpiryHint = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Int64? IndexingAttempts
        // GraphQL -> indexingAttempts: Long! (scalar)
        if (ec.Includes("indexingAttempts",true))
        {
            if(this.IndexingAttempts == null) {

                this.IndexingAttempts = new System.Int64();

            } else {


            }
        }
        else if (this.IndexingAttempts != null && ec.Excludes("indexingAttempts",true))
        {
            this.IndexingAttempts = null;
        }
        //      C# -> System.Boolean? IsCorrupted
        // GraphQL -> isCorrupted: Boolean! (scalar)
        if (ec.Includes("isCorrupted",true))
        {
            if(this.IsCorrupted == null) {

                this.IsCorrupted = true;

            } else {


            }
        }
        else if (this.IsCorrupted != null && ec.Excludes("isCorrupted",true))
        {
            this.IsCorrupted = null;
        }
        //      C# -> System.Boolean? IsDownloadedSnapshot
        // GraphQL -> isDownloadedSnapshot: Boolean (scalar)
        if (ec.Includes("isDownloadedSnapshot",true))
        {
            if(this.IsDownloadedSnapshot == null) {

                this.IsDownloadedSnapshot = true;

            } else {


            }
        }
        else if (this.IsDownloadedSnapshot != null && ec.Excludes("isDownloadedSnapshot",true))
        {
            this.IsDownloadedSnapshot = null;
        }
        //      C# -> System.Boolean? IsExpired
        // GraphQL -> isExpired: Boolean! (scalar)
        if (ec.Includes("isExpired",true))
        {
            if(this.IsExpired == null) {

                this.IsExpired = true;

            } else {


            }
        }
        else if (this.IsExpired != null && ec.Excludes("isExpired",true))
        {
            this.IsExpired = null;
        }
        //      C# -> System.Boolean? IsIndexed
        // GraphQL -> isIndexed: Boolean! (scalar)
        if (ec.Includes("isIndexed",true))
        {
            if(this.IsIndexed == null) {

                this.IsIndexed = true;

            } else {


            }
        }
        else if (this.IsIndexed != null && ec.Excludes("isIndexed",true))
        {
            this.IsIndexed = null;
        }
        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        if (ec.Includes("isOnDemandSnapshot",true))
        {
            if(this.IsOnDemandSnapshot == null) {

                this.IsOnDemandSnapshot = true;

            } else {


            }
        }
        else if (this.IsOnDemandSnapshot != null && ec.Excludes("isOnDemandSnapshot",true))
        {
            this.IsOnDemandSnapshot = null;
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (ec.Includes("isQuarantined",true))
        {
            if(this.IsQuarantined == null) {

                this.IsQuarantined = true;

            } else {


            }
        }
        else if (this.IsQuarantined != null && ec.Excludes("isQuarantined",true))
        {
            this.IsQuarantined = null;
        }
        //      C# -> System.Boolean? IsUnindexable
        // GraphQL -> isUnindexable: Boolean! (scalar)
        if (ec.Includes("isUnindexable",true))
        {
            if(this.IsUnindexable == null) {

                this.IsUnindexable = true;

            } else {


            }
        }
        else if (this.IsUnindexable != null && ec.Excludes("isUnindexable",true))
        {
            this.IsUnindexable = null;
        }
        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        if (ec.Includes("policyName",true))
        {
            if(this.PolicyName == null) {

                this.PolicyName = "FETCH";

            } else {


            }
        }
        else if (this.PolicyName != null && ec.Excludes("policyName",true))
        {
            this.PolicyName = null;
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (ec.Includes("snappableId",true))
        {
            if(this.SnappableId == null) {

                this.SnappableId = "FETCH";

            } else {


            }
        }
        else if (this.SnappableId != null && ec.Excludes("snappableId",true))
        {
            this.SnappableId = null;
        }
        //      C# -> System.String? SystemId
        // GraphQL -> systemId: String! (scalar)
        if (ec.Includes("systemId",true))
        {
            if(this.SystemId == null) {

                this.SystemId = "FETCH";

            } else {


            }
        }
        else if (this.SystemId != null && ec.Excludes("systemId",true))
        {
            this.SystemId = null;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        if (ec.Includes("workloadId",true))
        {
            if(this.WorkloadId == null) {

                this.WorkloadId = "FETCH";

            } else {


            }
        }
        else if (this.WorkloadId != null && ec.Excludes("workloadId",true))
        {
            this.WorkloadId = null;
        }
        //      C# -> CloudDirectNasShare? Share
        // GraphQL -> share: CloudDirectNasShare! (type)
        if (ec.Includes("share",false))
        {
            if(this.Share == null) {

                this.Share = new CloudDirectNasShare();
                this.Share.ApplyExploratoryFieldSpec(ec.NewChild("share"));

            } else {

                this.Share.ApplyExploratoryFieldSpec(ec.NewChild("share"));

            }
        }
        else if (this.Share != null && ec.Excludes("share",false))
        {
            this.Share = null;
        }
    }


    #endregion

    } // class CloudDirectSnapshot
    
    #endregion

    public static class ListCloudDirectSnapshotExtensions
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
            this List<CloudDirectSnapshot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudDirectSnapshot> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudDirectSnapshot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudDirectSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudDirectSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types