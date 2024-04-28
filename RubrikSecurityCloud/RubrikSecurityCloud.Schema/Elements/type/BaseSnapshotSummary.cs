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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> SnapshotCloudStorageTier? CloudStorageTier
        // GraphQL -> cloudStorageTier: SnapshotCloudStorageTier (enum)
        if (this.CloudStorageTier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudStorageTier\n" ;
            } else {
                s += ind + "cloudStorageTier\n" ;
            }
        }
        //      C# -> List<System.String>? ArchivalLocationIds
        // GraphQL -> archivalLocationIds: [String!]! (scalar)
        if (this.ArchivalLocationIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archivalLocationIds\n" ;
            } else {
                s += ind + "archivalLocationIds\n" ;
            }
        }
        //      C# -> System.Int64? CloudState
        // GraphQL -> cloudState: Long (scalar)
        if (this.CloudState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudState\n" ;
            } else {
                s += ind + "cloudState\n" ;
            }
        }
        //      C# -> System.String? ConsistencyLevel
        // GraphQL -> consistencyLevel: String (scalar)
        if (this.ConsistencyLevel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "consistencyLevel\n" ;
            } else {
                s += ind + "consistencyLevel\n" ;
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
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (this.ExpirationDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expirationDate\n" ;
            } else {
                s += ind + "expirationDate\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Int64? IndexState
        // GraphQL -> indexState: Long (scalar)
        if (this.IndexState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "indexState\n" ;
            } else {
                s += ind + "indexState\n" ;
            }
        }
        //      C# -> System.Boolean? IsCustomRetentionApplied
        // GraphQL -> isCustomRetentionApplied: Boolean (scalar)
        if (this.IsCustomRetentionApplied != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isCustomRetentionApplied\n" ;
            } else {
                s += ind + "isCustomRetentionApplied\n" ;
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
        //      C# -> System.Boolean? IsPlacedOnLegalHold
        // GraphQL -> isPlacedOnLegalHold: Boolean (scalar)
        if (this.IsPlacedOnLegalHold != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPlacedOnLegalHold\n" ;
            } else {
                s += ind + "isPlacedOnLegalHold\n" ;
            }
        }
        //      C# -> System.Boolean? IsRetainedByRetentionLockSla
        // GraphQL -> isRetainedByRetentionLockSla: Boolean (scalar)
        if (this.IsRetainedByRetentionLockSla != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRetainedByRetentionLockSla\n" ;
            } else {
                s += ind + "isRetainedByRetentionLockSla\n" ;
            }
        }
        //      C# -> System.String? ParentSnapshotId
        // GraphQL -> parentSnapshotId: String (scalar)
        if (this.ParentSnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "parentSnapshotId\n" ;
            } else {
                s += ind + "parentSnapshotId\n" ;
            }
        }
        //      C# -> List<System.String>? ReplicationLocationIds
        // GraphQL -> replicationLocationIds: [String!]! (scalar)
        if (this.ReplicationLocationIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicationLocationIds\n" ;
            } else {
                s += ind + "replicationLocationIds\n" ;
            }
        }
        //      C# -> System.String? SlaId
        // GraphQL -> slaId: String! (scalar)
        if (this.SlaId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaId\n" ;
            } else {
                s += ind + "slaId\n" ;
            }
        }
        //      C# -> System.String? SlaName
        // GraphQL -> slaName: String! (scalar)
        if (this.SlaName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaName\n" ;
            } else {
                s += ind + "slaName\n" ;
            }
        }
        //      C# -> System.String? SourceObjectType
        // GraphQL -> sourceObjectType: String (scalar)
        if (this.SourceObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceObjectType\n" ;
            } else {
                s += ind + "sourceObjectType\n" ;
            }
        }
        //      C# -> List<PerLocationCloudStorageTier>? CloudStorageTiers
        // GraphQL -> cloudStorageTiers: [PerLocationCloudStorageTier!]! (type)
        if (this.CloudStorageTiers != null) {
            var fspec = this.CloudStorageTiers.AsFieldSpec(conf.Child("cloudStorageTiers"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudStorageTiers" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SnapshotRetentionInfo? SnapshotRetentionInfo
        // GraphQL -> snapshotRetentionInfo: SnapshotRetentionInfo (type)
        if (this.SnapshotRetentionInfo != null) {
            var fspec = this.SnapshotRetentionInfo.AsFieldSpec(conf.Child("snapshotRetentionInfo"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotRetentionInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SnapshotCloudStorageTier? CloudStorageTier
        // GraphQL -> cloudStorageTier: SnapshotCloudStorageTier (enum)
        if (ec.Includes("cloudStorageTier",true))
        {
            if(this.CloudStorageTier == null) {

                this.CloudStorageTier = new SnapshotCloudStorageTier();

            } else {


            }
        }
        else if (this.CloudStorageTier != null && ec.Excludes("cloudStorageTier",true))
        {
            this.CloudStorageTier = null;
        }
        //      C# -> List<System.String>? ArchivalLocationIds
        // GraphQL -> archivalLocationIds: [String!]! (scalar)
        if (ec.Includes("archivalLocationIds",true))
        {
            if(this.ArchivalLocationIds == null) {

                this.ArchivalLocationIds = new List<System.String>();

            } else {


            }
        }
        else if (this.ArchivalLocationIds != null && ec.Excludes("archivalLocationIds",true))
        {
            this.ArchivalLocationIds = null;
        }
        //      C# -> System.Int64? CloudState
        // GraphQL -> cloudState: Long (scalar)
        if (ec.Includes("cloudState",true))
        {
            if(this.CloudState == null) {

                this.CloudState = new System.Int64();

            } else {


            }
        }
        else if (this.CloudState != null && ec.Excludes("cloudState",true))
        {
            this.CloudState = null;
        }
        //      C# -> System.String? ConsistencyLevel
        // GraphQL -> consistencyLevel: String (scalar)
        if (ec.Includes("consistencyLevel",true))
        {
            if(this.ConsistencyLevel == null) {

                this.ConsistencyLevel = "FETCH";

            } else {


            }
        }
        else if (this.ConsistencyLevel != null && ec.Excludes("consistencyLevel",true))
        {
            this.ConsistencyLevel = null;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
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
        //      C# -> System.Int64? IndexState
        // GraphQL -> indexState: Long (scalar)
        if (ec.Includes("indexState",true))
        {
            if(this.IndexState == null) {

                this.IndexState = new System.Int64();

            } else {


            }
        }
        else if (this.IndexState != null && ec.Excludes("indexState",true))
        {
            this.IndexState = null;
        }
        //      C# -> System.Boolean? IsCustomRetentionApplied
        // GraphQL -> isCustomRetentionApplied: Boolean (scalar)
        if (ec.Includes("isCustomRetentionApplied",true))
        {
            if(this.IsCustomRetentionApplied == null) {

                this.IsCustomRetentionApplied = true;

            } else {


            }
        }
        else if (this.IsCustomRetentionApplied != null && ec.Excludes("isCustomRetentionApplied",true))
        {
            this.IsCustomRetentionApplied = null;
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
        //      C# -> System.Boolean? IsPlacedOnLegalHold
        // GraphQL -> isPlacedOnLegalHold: Boolean (scalar)
        if (ec.Includes("isPlacedOnLegalHold",true))
        {
            if(this.IsPlacedOnLegalHold == null) {

                this.IsPlacedOnLegalHold = true;

            } else {


            }
        }
        else if (this.IsPlacedOnLegalHold != null && ec.Excludes("isPlacedOnLegalHold",true))
        {
            this.IsPlacedOnLegalHold = null;
        }
        //      C# -> System.Boolean? IsRetainedByRetentionLockSla
        // GraphQL -> isRetainedByRetentionLockSla: Boolean (scalar)
        if (ec.Includes("isRetainedByRetentionLockSla",true))
        {
            if(this.IsRetainedByRetentionLockSla == null) {

                this.IsRetainedByRetentionLockSla = true;

            } else {


            }
        }
        else if (this.IsRetainedByRetentionLockSla != null && ec.Excludes("isRetainedByRetentionLockSla",true))
        {
            this.IsRetainedByRetentionLockSla = null;
        }
        //      C# -> System.String? ParentSnapshotId
        // GraphQL -> parentSnapshotId: String (scalar)
        if (ec.Includes("parentSnapshotId",true))
        {
            if(this.ParentSnapshotId == null) {

                this.ParentSnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.ParentSnapshotId != null && ec.Excludes("parentSnapshotId",true))
        {
            this.ParentSnapshotId = null;
        }
        //      C# -> List<System.String>? ReplicationLocationIds
        // GraphQL -> replicationLocationIds: [String!]! (scalar)
        if (ec.Includes("replicationLocationIds",true))
        {
            if(this.ReplicationLocationIds == null) {

                this.ReplicationLocationIds = new List<System.String>();

            } else {


            }
        }
        else if (this.ReplicationLocationIds != null && ec.Excludes("replicationLocationIds",true))
        {
            this.ReplicationLocationIds = null;
        }
        //      C# -> System.String? SlaId
        // GraphQL -> slaId: String! (scalar)
        if (ec.Includes("slaId",true))
        {
            if(this.SlaId == null) {

                this.SlaId = "FETCH";

            } else {


            }
        }
        else if (this.SlaId != null && ec.Excludes("slaId",true))
        {
            this.SlaId = null;
        }
        //      C# -> System.String? SlaName
        // GraphQL -> slaName: String! (scalar)
        if (ec.Includes("slaName",true))
        {
            if(this.SlaName == null) {

                this.SlaName = "FETCH";

            } else {


            }
        }
        else if (this.SlaName != null && ec.Excludes("slaName",true))
        {
            this.SlaName = null;
        }
        //      C# -> System.String? SourceObjectType
        // GraphQL -> sourceObjectType: String (scalar)
        if (ec.Includes("sourceObjectType",true))
        {
            if(this.SourceObjectType == null) {

                this.SourceObjectType = "FETCH";

            } else {


            }
        }
        else if (this.SourceObjectType != null && ec.Excludes("sourceObjectType",true))
        {
            this.SourceObjectType = null;
        }
        //      C# -> List<PerLocationCloudStorageTier>? CloudStorageTiers
        // GraphQL -> cloudStorageTiers: [PerLocationCloudStorageTier!]! (type)
        if (ec.Includes("cloudStorageTiers",false))
        {
            if(this.CloudStorageTiers == null) {

                this.CloudStorageTiers = new List<PerLocationCloudStorageTier>();
                this.CloudStorageTiers.ApplyExploratoryFieldSpec(ec.NewChild("cloudStorageTiers"));

            } else {

                this.CloudStorageTiers.ApplyExploratoryFieldSpec(ec.NewChild("cloudStorageTiers"));

            }
        }
        else if (this.CloudStorageTiers != null && ec.Excludes("cloudStorageTiers",false))
        {
            this.CloudStorageTiers = null;
        }
        //      C# -> SnapshotRetentionInfo? SnapshotRetentionInfo
        // GraphQL -> snapshotRetentionInfo: SnapshotRetentionInfo (type)
        if (ec.Includes("snapshotRetentionInfo",false))
        {
            if(this.SnapshotRetentionInfo == null) {

                this.SnapshotRetentionInfo = new SnapshotRetentionInfo();
                this.SnapshotRetentionInfo.ApplyExploratoryFieldSpec(ec.NewChild("snapshotRetentionInfo"));

            } else {

                this.SnapshotRetentionInfo.ApplyExploratoryFieldSpec(ec.NewChild("snapshotRetentionInfo"));

            }
        }
        else if (this.SnapshotRetentionInfo != null && ec.Excludes("snapshotRetentionInfo",false))
        {
            this.SnapshotRetentionInfo = null;
        }
    }


    #endregion

    } // class BaseSnapshotSummary
    
    #endregion

    public static class ListBaseSnapshotSummaryExtensions
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
            this List<BaseSnapshotSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BaseSnapshotSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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