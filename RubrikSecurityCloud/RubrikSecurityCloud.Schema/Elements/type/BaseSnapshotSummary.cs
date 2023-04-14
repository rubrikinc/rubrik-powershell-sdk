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

namespace Rubrik.SecurityCloud.Types
{
    #region BaseSnapshotSummary
    public class BaseSnapshotSummary: IFragment
    {
        #region members
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

        //      C# -> SnapshotCloudStorageTier? CloudStorageTier
        // GraphQL -> cloudStorageTier: SnapshotCloudStorageTier (enum)
        [JsonProperty("cloudStorageTier")]
        public SnapshotCloudStorageTier? CloudStorageTier { get; set; }

        #endregion

    #region methods

    public BaseSnapshotSummary Set(
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
        SnapshotRetentionInfo? SnapshotRetentionInfo = null,
        SnapshotCloudStorageTier? CloudStorageTier = null
    ) 
    {
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
        if ( CloudStorageTier != null ) {
            this.CloudStorageTier = CloudStorageTier;
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
            //      C# -> List<System.String>? ArchivalLocationIds
            // GraphQL -> archivalLocationIds: [String!]! (scalar)
            if (this.ArchivalLocationIds != null)
            {
                 s += ind + "archivalLocationIds\n";

            }
            //      C# -> System.Int64? CloudState
            // GraphQL -> cloudState: Long (scalar)
            if (this.CloudState != null)
            {
                 s += ind + "cloudState\n";

            }
            //      C# -> System.String? ConsistencyLevel
            // GraphQL -> consistencyLevel: String (scalar)
            if (this.ConsistencyLevel != null)
            {
                 s += ind + "consistencyLevel\n";

            }
            //      C# -> DateTime? Date
            // GraphQL -> date: DateTime (scalar)
            if (this.Date != null)
            {
                 s += ind + "date\n";

            }
            //      C# -> DateTime? ExpirationDate
            // GraphQL -> expirationDate: DateTime (scalar)
            if (this.ExpirationDate != null)
            {
                 s += ind + "expirationDate\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Int64? IndexState
            // GraphQL -> indexState: Long (scalar)
            if (this.IndexState != null)
            {
                 s += ind + "indexState\n";

            }
            //      C# -> System.Boolean? IsCustomRetentionApplied
            // GraphQL -> isCustomRetentionApplied: Boolean (scalar)
            if (this.IsCustomRetentionApplied != null)
            {
                 s += ind + "isCustomRetentionApplied\n";

            }
            //      C# -> System.Boolean? IsOnDemandSnapshot
            // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
            if (this.IsOnDemandSnapshot != null)
            {
                 s += ind + "isOnDemandSnapshot\n";

            }
            //      C# -> System.Boolean? IsPlacedOnLegalHold
            // GraphQL -> isPlacedOnLegalHold: Boolean (scalar)
            if (this.IsPlacedOnLegalHold != null)
            {
                 s += ind + "isPlacedOnLegalHold\n";

            }
            //      C# -> System.Boolean? IsRetainedByRetentionLockSla
            // GraphQL -> isRetainedByRetentionLockSla: Boolean (scalar)
            if (this.IsRetainedByRetentionLockSla != null)
            {
                 s += ind + "isRetainedByRetentionLockSla\n";

            }
            //      C# -> System.String? ParentSnapshotId
            // GraphQL -> parentSnapshotId: String (scalar)
            if (this.ParentSnapshotId != null)
            {
                 s += ind + "parentSnapshotId\n";

            }
            //      C# -> List<System.String>? ReplicationLocationIds
            // GraphQL -> replicationLocationIds: [String!]! (scalar)
            if (this.ReplicationLocationIds != null)
            {
                 s += ind + "replicationLocationIds\n";

            }
            //      C# -> System.String? SlaId
            // GraphQL -> slaId: String! (scalar)
            if (this.SlaId != null)
            {
                 s += ind + "slaId\n";

            }
            //      C# -> System.String? SlaName
            // GraphQL -> slaName: String! (scalar)
            if (this.SlaName != null)
            {
                 s += ind + "slaName\n";

            }
            //      C# -> System.String? SourceObjectType
            // GraphQL -> sourceObjectType: String (scalar)
            if (this.SourceObjectType != null)
            {
                 s += ind + "sourceObjectType\n";

            }
            //      C# -> List<PerLocationCloudStorageTier>? CloudStorageTiers
            // GraphQL -> cloudStorageTiers: [PerLocationCloudStorageTier!]! (type)
            if (this.CloudStorageTiers != null)
            {
                 s += ind + "cloudStorageTiers\n";

                 s += ind + "{\n" + 
                 this.CloudStorageTiers.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SnapshotRetentionInfo? SnapshotRetentionInfo
            // GraphQL -> snapshotRetentionInfo: SnapshotRetentionInfo (type)
            if (this.SnapshotRetentionInfo != null)
            {
                 s += ind + "snapshotRetentionInfo\n";

                 s += ind + "{\n" + 
                 this.SnapshotRetentionInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SnapshotCloudStorageTier? CloudStorageTier
            // GraphQL -> cloudStorageTier: SnapshotCloudStorageTier (enum)
            if (this.CloudStorageTier != null)
            {
                 s += ind + "cloudStorageTier\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? ArchivalLocationIds
            // GraphQL -> archivalLocationIds: [String!]! (scalar)
            if (this.ArchivalLocationIds == null && Exploration.Includes(parent + ".archivalLocationIds$"))
            {
                this.ArchivalLocationIds = new List<System.String>();
            }
            //      C# -> System.Int64? CloudState
            // GraphQL -> cloudState: Long (scalar)
            if (this.CloudState == null && Exploration.Includes(parent + ".cloudState$"))
            {
                this.CloudState = new System.Int64();
            }
            //      C# -> System.String? ConsistencyLevel
            // GraphQL -> consistencyLevel: String (scalar)
            if (this.ConsistencyLevel == null && Exploration.Includes(parent + ".consistencyLevel$"))
            {
                this.ConsistencyLevel = new System.String("FETCH");
            }
            //      C# -> DateTime? Date
            // GraphQL -> date: DateTime (scalar)
            if (this.Date == null && Exploration.Includes(parent + ".date$"))
            {
                this.Date = new DateTime();
            }
            //      C# -> DateTime? ExpirationDate
            // GraphQL -> expirationDate: DateTime (scalar)
            if (this.ExpirationDate == null && Exploration.Includes(parent + ".expirationDate$"))
            {
                this.ExpirationDate = new DateTime();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Int64? IndexState
            // GraphQL -> indexState: Long (scalar)
            if (this.IndexState == null && Exploration.Includes(parent + ".indexState$"))
            {
                this.IndexState = new System.Int64();
            }
            //      C# -> System.Boolean? IsCustomRetentionApplied
            // GraphQL -> isCustomRetentionApplied: Boolean (scalar)
            if (this.IsCustomRetentionApplied == null && Exploration.Includes(parent + ".isCustomRetentionApplied$"))
            {
                this.IsCustomRetentionApplied = new System.Boolean();
            }
            //      C# -> System.Boolean? IsOnDemandSnapshot
            // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
            if (this.IsOnDemandSnapshot == null && Exploration.Includes(parent + ".isOnDemandSnapshot$"))
            {
                this.IsOnDemandSnapshot = new System.Boolean();
            }
            //      C# -> System.Boolean? IsPlacedOnLegalHold
            // GraphQL -> isPlacedOnLegalHold: Boolean (scalar)
            if (this.IsPlacedOnLegalHold == null && Exploration.Includes(parent + ".isPlacedOnLegalHold$"))
            {
                this.IsPlacedOnLegalHold = new System.Boolean();
            }
            //      C# -> System.Boolean? IsRetainedByRetentionLockSla
            // GraphQL -> isRetainedByRetentionLockSla: Boolean (scalar)
            if (this.IsRetainedByRetentionLockSla == null && Exploration.Includes(parent + ".isRetainedByRetentionLockSla$"))
            {
                this.IsRetainedByRetentionLockSla = new System.Boolean();
            }
            //      C# -> System.String? ParentSnapshotId
            // GraphQL -> parentSnapshotId: String (scalar)
            if (this.ParentSnapshotId == null && Exploration.Includes(parent + ".parentSnapshotId$"))
            {
                this.ParentSnapshotId = new System.String("FETCH");
            }
            //      C# -> List<System.String>? ReplicationLocationIds
            // GraphQL -> replicationLocationIds: [String!]! (scalar)
            if (this.ReplicationLocationIds == null && Exploration.Includes(parent + ".replicationLocationIds$"))
            {
                this.ReplicationLocationIds = new List<System.String>();
            }
            //      C# -> System.String? SlaId
            // GraphQL -> slaId: String! (scalar)
            if (this.SlaId == null && Exploration.Includes(parent + ".slaId$"))
            {
                this.SlaId = new System.String("FETCH");
            }
            //      C# -> System.String? SlaName
            // GraphQL -> slaName: String! (scalar)
            if (this.SlaName == null && Exploration.Includes(parent + ".slaName$"))
            {
                this.SlaName = new System.String("FETCH");
            }
            //      C# -> System.String? SourceObjectType
            // GraphQL -> sourceObjectType: String (scalar)
            if (this.SourceObjectType == null && Exploration.Includes(parent + ".sourceObjectType$"))
            {
                this.SourceObjectType = new System.String("FETCH");
            }
            //      C# -> List<PerLocationCloudStorageTier>? CloudStorageTiers
            // GraphQL -> cloudStorageTiers: [PerLocationCloudStorageTier!]! (type)
            if (this.CloudStorageTiers == null && Exploration.Includes(parent + ".cloudStorageTiers"))
            {
                this.CloudStorageTiers = new List<PerLocationCloudStorageTier>();
                this.CloudStorageTiers.ApplyExploratoryFragment(parent + ".cloudStorageTiers");
            }
            //      C# -> SnapshotRetentionInfo? SnapshotRetentionInfo
            // GraphQL -> snapshotRetentionInfo: SnapshotRetentionInfo (type)
            if (this.SnapshotRetentionInfo == null && Exploration.Includes(parent + ".snapshotRetentionInfo"))
            {
                this.SnapshotRetentionInfo = new SnapshotRetentionInfo();
                this.SnapshotRetentionInfo.ApplyExploratoryFragment(parent + ".snapshotRetentionInfo");
            }
            //      C# -> SnapshotCloudStorageTier? CloudStorageTier
            // GraphQL -> cloudStorageTier: SnapshotCloudStorageTier (enum)
            if (this.CloudStorageTier == null && Exploration.Includes(parent + ".cloudStorageTier$"))
            {
                this.CloudStorageTier = new SnapshotCloudStorageTier();
            }
        }


    #endregion

    } // class BaseSnapshotSummary
    #endregion

    public static class ListBaseSnapshotSummaryExtensions
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
            this List<BaseSnapshotSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<BaseSnapshotSummary> list, 
            String parent = "")
        {
            var item = new BaseSnapshotSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types