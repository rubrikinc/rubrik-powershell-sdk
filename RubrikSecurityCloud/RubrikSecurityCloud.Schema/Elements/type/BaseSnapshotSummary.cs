// BaseSnapshotSummary.cs
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
    #region BaseSnapshotSummary
    public class BaseSnapshotSummary: BaseType
    {
        #region members

        //      C# -> SnapshotCloudStorageTier? CloudStorageTier
        // GraphQL -> cloudStorageTier: SnapshotCloudStorageTier (enum)
        [JsonProperty("cloudStorageTier")]
        public SnapshotCloudStorageTier? CloudStorageTier { get; set; }

        //      C# -> List<System.String>? ArchivalLocationIds
        // GraphQL -> archivalLocationIds: [String!]! (scalar)
        [JsonProperty("archivalLocationIds")]
        public List<System.String>? ArchivalLocationIds { get; set; }

        //      C# -> System.Int64? CloudState
        // GraphQL -> cloudState: Long (scalar)
        [JsonProperty("cloudState")]
        public System.Int64? CloudState { get; set; }

        //      C# -> System.String? ConsistencyLevel
        // GraphQL -> consistencyLevel: String (scalar)
        [JsonProperty("consistencyLevel")]
        public System.String? ConsistencyLevel { get; set; }

        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        [JsonProperty("expirationDate")]
        public DateTime? ExpirationDate { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int64? IndexState
        // GraphQL -> indexState: Long (scalar)
        [JsonProperty("indexState")]
        public System.Int64? IndexState { get; set; }

        //      C# -> System.Boolean? IsCustomRetentionApplied
        // GraphQL -> isCustomRetentionApplied: Boolean (scalar)
        [JsonProperty("isCustomRetentionApplied")]
        public System.Boolean? IsCustomRetentionApplied { get; set; }

        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        [JsonProperty("isOnDemandSnapshot")]
        public System.Boolean? IsOnDemandSnapshot { get; set; }

        //      C# -> System.Boolean? IsPlacedOnLegalHold
        // GraphQL -> isPlacedOnLegalHold: Boolean (scalar)
        [JsonProperty("isPlacedOnLegalHold")]
        public System.Boolean? IsPlacedOnLegalHold { get; set; }

        //      C# -> System.Boolean? IsRetainedByRetentionLockSla
        // GraphQL -> isRetainedByRetentionLockSla: Boolean (scalar)
        [JsonProperty("isRetainedByRetentionLockSla")]
        public System.Boolean? IsRetainedByRetentionLockSla { get; set; }

        //      C# -> System.String? ParentSnapshotId
        // GraphQL -> parentSnapshotId: String (scalar)
        [JsonProperty("parentSnapshotId")]
        public System.String? ParentSnapshotId { get; set; }

        //      C# -> List<System.String>? ReplicationLocationIds
        // GraphQL -> replicationLocationIds: [String!]! (scalar)
        [JsonProperty("replicationLocationIds")]
        public List<System.String>? ReplicationLocationIds { get; set; }

        //      C# -> System.String? SlaId
        // GraphQL -> slaId: String! (scalar)
        [JsonProperty("slaId")]
        public System.String? SlaId { get; set; }

        //      C# -> System.String? SlaName
        // GraphQL -> slaName: String! (scalar)
        [JsonProperty("slaName")]
        public System.String? SlaName { get; set; }

        //      C# -> System.String? SourceObjectType
        // GraphQL -> sourceObjectType: String (scalar)
        [JsonProperty("sourceObjectType")]
        public System.String? SourceObjectType { get; set; }

        //      C# -> List<PerLocationCloudStorageTier>? CloudStorageTiers
        // GraphQL -> cloudStorageTiers: [PerLocationCloudStorageTier!]! (type)
        [JsonProperty("cloudStorageTiers")]
        public List<PerLocationCloudStorageTier>? CloudStorageTiers { get; set; }

        //      C# -> SnapshotRetentionInfo? SnapshotRetentionInfo
        // GraphQL -> snapshotRetentionInfo: SnapshotRetentionInfo (type)
        [JsonProperty("snapshotRetentionInfo")]
        public SnapshotRetentionInfo? SnapshotRetentionInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BaseSnapshotSummary";
    }

    public BaseSnapshotSummary Set(
        SnapshotCloudStorageTier? CloudStorageTier = null,
        List<System.String>? ArchivalLocationIds = null,
        System.Int64? CloudState = null,
        System.String? ConsistencyLevel = null,
        DateTime? Date = null,
        DateTime? ExpirationDate = null,
        System.String? Id = null,
        System.Int64? IndexState = null,
        System.Boolean? IsCustomRetentionApplied = null,
        System.Boolean? IsOnDemandSnapshot = null,
        System.Boolean? IsPlacedOnLegalHold = null,
        System.Boolean? IsRetainedByRetentionLockSla = null,
        System.String? ParentSnapshotId = null,
        List<System.String>? ReplicationLocationIds = null,
        System.String? SlaId = null,
        System.String? SlaName = null,
        System.String? SourceObjectType = null,
        List<PerLocationCloudStorageTier>? CloudStorageTiers = null,
        SnapshotRetentionInfo? SnapshotRetentionInfo = null
    ) 
    {
        if ( CloudStorageTier != null ) {
            this.CloudStorageTier = CloudStorageTier;
        }
        if ( ArchivalLocationIds != null ) {
            this.ArchivalLocationIds = ArchivalLocationIds;
        }
        if ( CloudState != null ) {
            this.CloudState = CloudState;
        }
        if ( ConsistencyLevel != null ) {
            this.ConsistencyLevel = ConsistencyLevel;
        }
        if ( Date != null ) {
            this.Date = Date;
        }
        if ( ExpirationDate != null ) {
            this.ExpirationDate = ExpirationDate;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IndexState != null ) {
            this.IndexState = IndexState;
        }
        if ( IsCustomRetentionApplied != null ) {
            this.IsCustomRetentionApplied = IsCustomRetentionApplied;
        }
        if ( IsOnDemandSnapshot != null ) {
            this.IsOnDemandSnapshot = IsOnDemandSnapshot;
        }
        if ( IsPlacedOnLegalHold != null ) {
            this.IsPlacedOnLegalHold = IsPlacedOnLegalHold;
        }
        if ( IsRetainedByRetentionLockSla != null ) {
            this.IsRetainedByRetentionLockSla = IsRetainedByRetentionLockSla;
        }
        if ( ParentSnapshotId != null ) {
            this.ParentSnapshotId = ParentSnapshotId;
        }
        if ( ReplicationLocationIds != null ) {
            this.ReplicationLocationIds = ReplicationLocationIds;
        }
        if ( SlaId != null ) {
            this.SlaId = SlaId;
        }
        if ( SlaName != null ) {
            this.SlaName = SlaName;
        }
        if ( SourceObjectType != null ) {
            this.SourceObjectType = SourceObjectType;
        }
        if ( CloudStorageTiers != null ) {
            this.CloudStorageTiers = CloudStorageTiers;
        }
        if ( SnapshotRetentionInfo != null ) {
            this.SnapshotRetentionInfo = SnapshotRetentionInfo;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> SnapshotCloudStorageTier? CloudStorageTier
        // GraphQL -> cloudStorageTier: SnapshotCloudStorageTier (enum)
        if (this.CloudStorageTier != null) {
            s += ind + "cloudStorageTier\n" ;
        }
        //      C# -> List<System.String>? ArchivalLocationIds
        // GraphQL -> archivalLocationIds: [String!]! (scalar)
        if (this.ArchivalLocationIds != null) {
            s += ind + "archivalLocationIds\n" ;
        }
        //      C# -> System.Int64? CloudState
        // GraphQL -> cloudState: Long (scalar)
        if (this.CloudState != null) {
            s += ind + "cloudState\n" ;
        }
        //      C# -> System.String? ConsistencyLevel
        // GraphQL -> consistencyLevel: String (scalar)
        if (this.ConsistencyLevel != null) {
            s += ind + "consistencyLevel\n" ;
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        if (this.Date != null) {
            s += ind + "date\n" ;
        }
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (this.ExpirationDate != null) {
            s += ind + "expirationDate\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Int64? IndexState
        // GraphQL -> indexState: Long (scalar)
        if (this.IndexState != null) {
            s += ind + "indexState\n" ;
        }
        //      C# -> System.Boolean? IsCustomRetentionApplied
        // GraphQL -> isCustomRetentionApplied: Boolean (scalar)
        if (this.IsCustomRetentionApplied != null) {
            s += ind + "isCustomRetentionApplied\n" ;
        }
        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        if (this.IsOnDemandSnapshot != null) {
            s += ind + "isOnDemandSnapshot\n" ;
        }
        //      C# -> System.Boolean? IsPlacedOnLegalHold
        // GraphQL -> isPlacedOnLegalHold: Boolean (scalar)
        if (this.IsPlacedOnLegalHold != null) {
            s += ind + "isPlacedOnLegalHold\n" ;
        }
        //      C# -> System.Boolean? IsRetainedByRetentionLockSla
        // GraphQL -> isRetainedByRetentionLockSla: Boolean (scalar)
        if (this.IsRetainedByRetentionLockSla != null) {
            s += ind + "isRetainedByRetentionLockSla\n" ;
        }
        //      C# -> System.String? ParentSnapshotId
        // GraphQL -> parentSnapshotId: String (scalar)
        if (this.ParentSnapshotId != null) {
            s += ind + "parentSnapshotId\n" ;
        }
        //      C# -> List<System.String>? ReplicationLocationIds
        // GraphQL -> replicationLocationIds: [String!]! (scalar)
        if (this.ReplicationLocationIds != null) {
            s += ind + "replicationLocationIds\n" ;
        }
        //      C# -> System.String? SlaId
        // GraphQL -> slaId: String! (scalar)
        if (this.SlaId != null) {
            s += ind + "slaId\n" ;
        }
        //      C# -> System.String? SlaName
        // GraphQL -> slaName: String! (scalar)
        if (this.SlaName != null) {
            s += ind + "slaName\n" ;
        }
        //      C# -> System.String? SourceObjectType
        // GraphQL -> sourceObjectType: String (scalar)
        if (this.SourceObjectType != null) {
            s += ind + "sourceObjectType\n" ;
        }
        //      C# -> List<PerLocationCloudStorageTier>? CloudStorageTiers
        // GraphQL -> cloudStorageTiers: [PerLocationCloudStorageTier!]! (type)
        if (this.CloudStorageTiers != null) {
            var fspec = this.CloudStorageTiers.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cloudStorageTiers {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SnapshotRetentionInfo? SnapshotRetentionInfo
        // GraphQL -> snapshotRetentionInfo: SnapshotRetentionInfo (type)
        if (this.SnapshotRetentionInfo != null) {
            var fspec = this.SnapshotRetentionInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotRetentionInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SnapshotCloudStorageTier? CloudStorageTier
        // GraphQL -> cloudStorageTier: SnapshotCloudStorageTier (enum)
        if (this.CloudStorageTier == null && ec.Includes("cloudStorageTier",true))
        {
            this.CloudStorageTier = new SnapshotCloudStorageTier();
        }
        //      C# -> List<System.String>? ArchivalLocationIds
        // GraphQL -> archivalLocationIds: [String!]! (scalar)
        if (this.ArchivalLocationIds == null && ec.Includes("archivalLocationIds",true))
        {
            this.ArchivalLocationIds = new List<System.String>();
        }
        //      C# -> System.Int64? CloudState
        // GraphQL -> cloudState: Long (scalar)
        if (this.CloudState == null && ec.Includes("cloudState",true))
        {
            this.CloudState = new System.Int64();
        }
        //      C# -> System.String? ConsistencyLevel
        // GraphQL -> consistencyLevel: String (scalar)
        if (this.ConsistencyLevel == null && ec.Includes("consistencyLevel",true))
        {
            this.ConsistencyLevel = "FETCH";
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        if (this.Date == null && ec.Includes("date",true))
        {
            this.Date = new DateTime();
        }
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (this.ExpirationDate == null && ec.Includes("expirationDate",true))
        {
            this.ExpirationDate = new DateTime();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Int64? IndexState
        // GraphQL -> indexState: Long (scalar)
        if (this.IndexState == null && ec.Includes("indexState",true))
        {
            this.IndexState = new System.Int64();
        }
        //      C# -> System.Boolean? IsCustomRetentionApplied
        // GraphQL -> isCustomRetentionApplied: Boolean (scalar)
        if (this.IsCustomRetentionApplied == null && ec.Includes("isCustomRetentionApplied",true))
        {
            this.IsCustomRetentionApplied = true;
        }
        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        if (this.IsOnDemandSnapshot == null && ec.Includes("isOnDemandSnapshot",true))
        {
            this.IsOnDemandSnapshot = true;
        }
        //      C# -> System.Boolean? IsPlacedOnLegalHold
        // GraphQL -> isPlacedOnLegalHold: Boolean (scalar)
        if (this.IsPlacedOnLegalHold == null && ec.Includes("isPlacedOnLegalHold",true))
        {
            this.IsPlacedOnLegalHold = true;
        }
        //      C# -> System.Boolean? IsRetainedByRetentionLockSla
        // GraphQL -> isRetainedByRetentionLockSla: Boolean (scalar)
        if (this.IsRetainedByRetentionLockSla == null && ec.Includes("isRetainedByRetentionLockSla",true))
        {
            this.IsRetainedByRetentionLockSla = true;
        }
        //      C# -> System.String? ParentSnapshotId
        // GraphQL -> parentSnapshotId: String (scalar)
        if (this.ParentSnapshotId == null && ec.Includes("parentSnapshotId",true))
        {
            this.ParentSnapshotId = "FETCH";
        }
        //      C# -> List<System.String>? ReplicationLocationIds
        // GraphQL -> replicationLocationIds: [String!]! (scalar)
        if (this.ReplicationLocationIds == null && ec.Includes("replicationLocationIds",true))
        {
            this.ReplicationLocationIds = new List<System.String>();
        }
        //      C# -> System.String? SlaId
        // GraphQL -> slaId: String! (scalar)
        if (this.SlaId == null && ec.Includes("slaId",true))
        {
            this.SlaId = "FETCH";
        }
        //      C# -> System.String? SlaName
        // GraphQL -> slaName: String! (scalar)
        if (this.SlaName == null && ec.Includes("slaName",true))
        {
            this.SlaName = "FETCH";
        }
        //      C# -> System.String? SourceObjectType
        // GraphQL -> sourceObjectType: String (scalar)
        if (this.SourceObjectType == null && ec.Includes("sourceObjectType",true))
        {
            this.SourceObjectType = "FETCH";
        }
        //      C# -> List<PerLocationCloudStorageTier>? CloudStorageTiers
        // GraphQL -> cloudStorageTiers: [PerLocationCloudStorageTier!]! (type)
        if (this.CloudStorageTiers == null && ec.Includes("cloudStorageTiers",false))
        {
            this.CloudStorageTiers = new List<PerLocationCloudStorageTier>();
            this.CloudStorageTiers.ApplyExploratoryFieldSpec(ec.NewChild("cloudStorageTiers"));
        }
        //      C# -> SnapshotRetentionInfo? SnapshotRetentionInfo
        // GraphQL -> snapshotRetentionInfo: SnapshotRetentionInfo (type)
        if (this.SnapshotRetentionInfo == null && ec.Includes("snapshotRetentionInfo",false))
        {
            this.SnapshotRetentionInfo = new SnapshotRetentionInfo();
            this.SnapshotRetentionInfo.ApplyExploratoryFieldSpec(ec.NewChild("snapshotRetentionInfo"));
        }
    }


    #endregion

    } // class BaseSnapshotSummary
    
    #endregion

    public static class ListBaseSnapshotSummaryExtensions
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
            this List<BaseSnapshotSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BaseSnapshotSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BaseSnapshotSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BaseSnapshotSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types