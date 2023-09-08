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

        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        [JsonProperty("slaDomain")]
        public SlaDomain? SlaDomain { get; set; }

        //      C# -> CloudDirectHierarchyWorkload? Snappable
        // GraphQL -> snappable: CloudDirectHierarchyWorkload! (interface)
        [JsonProperty("snappable")]
        public CloudDirectHierarchyWorkload? Snappable { get; set; }

        //      C# -> System.String? CloudDirectId
        // GraphQL -> cloudDirectId: UUID! (scalar)
        [JsonProperty("cloudDirectId")]
        public System.String? CloudDirectId { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

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

        //      C# -> DateTime? IndexTime
        // GraphQL -> indexTime: DateTime (scalar)
        [JsonProperty("indexTime")]
        public DateTime? IndexTime { get; set; }

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

        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        [JsonProperty("snappableId")]
        public System.String? SnappableId { get; set; }

        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        [JsonProperty("state")]
        public System.String? State { get; set; }

        //      C# -> DateTime? TimeCompleted
        // GraphQL -> timeCompleted: DateTime (scalar)
        [JsonProperty("timeCompleted")]
        public DateTime? TimeCompleted { get; set; }

        //      C# -> DateTime? TimeStarted
        // GraphQL -> timeStarted: DateTime (scalar)
        [JsonProperty("timeStarted")]
        public DateTime? TimeStarted { get; set; }

        //      C# -> System.String? Type
        // GraphQL -> type: String! (scalar)
        [JsonProperty("type")]
        public System.String? Type { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudDirectSnapshot";
    }

    public CloudDirectSnapshot Set(
        SlaDomain? SlaDomain = null,
        CloudDirectHierarchyWorkload? Snappable = null,
        System.String? CloudDirectId = null,
        System.String? ClusterUuid = null,
        DateTime? Date = null,
        DateTime? ExpirationDate = null,
        System.Boolean? ExpiryHint = null,
        System.String? Id = null,
        DateTime? IndexTime = null,
        System.Int64? IndexingAttempts = null,
        System.Boolean? IsCorrupted = null,
        System.Boolean? IsDownloadedSnapshot = null,
        System.Boolean? IsExpired = null,
        System.Boolean? IsIndexed = null,
        System.Boolean? IsOnDemandSnapshot = null,
        System.Boolean? IsQuarantined = null,
        System.Boolean? IsUnindexable = null,
        System.String? SnappableId = null,
        System.String? State = null,
        DateTime? TimeCompleted = null,
        DateTime? TimeStarted = null,
        System.String? Type = null
    ) 
    {
        if ( SlaDomain != null ) {
            this.SlaDomain = SlaDomain;
        }
        if ( Snappable != null ) {
            this.Snappable = Snappable;
        }
        if ( CloudDirectId != null ) {
            this.CloudDirectId = CloudDirectId;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
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
        if ( IndexTime != null ) {
            this.IndexTime = IndexTime;
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
        if ( SnappableId != null ) {
            this.SnappableId = SnappableId;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( TimeCompleted != null ) {
            this.TimeCompleted = TimeCompleted;
        }
        if ( TimeStarted != null ) {
            this.TimeStarted = TimeStarted;
        }
        if ( Type != null ) {
            this.Type = Type;
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
        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        if (this.SlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.SlaDomain).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "slaDomain {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> CloudDirectHierarchyWorkload? Snappable
        // GraphQL -> snappable: CloudDirectHierarchyWorkload! (interface)
        if (this.Snappable != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.Snappable).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snappable {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.String? CloudDirectId
        // GraphQL -> cloudDirectId: UUID! (scalar)
        if (this.CloudDirectId != null) {
            s += ind + "cloudDirectId\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        if (this.Date != null) {
            s += ind + "date\n" ;
        }
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (this.ExpirationDate != null) {
            s += ind + "expirationDate\n" ;
        }
        //      C# -> System.Boolean? ExpiryHint
        // GraphQL -> expiryHint: Boolean! (scalar)
        if (this.ExpiryHint != null) {
            s += ind + "expiryHint\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> DateTime? IndexTime
        // GraphQL -> indexTime: DateTime (scalar)
        if (this.IndexTime != null) {
            s += ind + "indexTime\n" ;
        }
        //      C# -> System.Int64? IndexingAttempts
        // GraphQL -> indexingAttempts: Long! (scalar)
        if (this.IndexingAttempts != null) {
            s += ind + "indexingAttempts\n" ;
        }
        //      C# -> System.Boolean? IsCorrupted
        // GraphQL -> isCorrupted: Boolean! (scalar)
        if (this.IsCorrupted != null) {
            s += ind + "isCorrupted\n" ;
        }
        //      C# -> System.Boolean? IsDownloadedSnapshot
        // GraphQL -> isDownloadedSnapshot: Boolean (scalar)
        if (this.IsDownloadedSnapshot != null) {
            s += ind + "isDownloadedSnapshot\n" ;
        }
        //      C# -> System.Boolean? IsExpired
        // GraphQL -> isExpired: Boolean! (scalar)
        if (this.IsExpired != null) {
            s += ind + "isExpired\n" ;
        }
        //      C# -> System.Boolean? IsIndexed
        // GraphQL -> isIndexed: Boolean! (scalar)
        if (this.IsIndexed != null) {
            s += ind + "isIndexed\n" ;
        }
        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        if (this.IsOnDemandSnapshot != null) {
            s += ind + "isOnDemandSnapshot\n" ;
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (this.IsQuarantined != null) {
            s += ind + "isQuarantined\n" ;
        }
        //      C# -> System.Boolean? IsUnindexable
        // GraphQL -> isUnindexable: Boolean! (scalar)
        if (this.IsUnindexable != null) {
            s += ind + "isUnindexable\n" ;
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId != null) {
            s += ind + "snappableId\n" ;
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (this.State != null) {
            s += ind + "state\n" ;
        }
        //      C# -> DateTime? TimeCompleted
        // GraphQL -> timeCompleted: DateTime (scalar)
        if (this.TimeCompleted != null) {
            s += ind + "timeCompleted\n" ;
        }
        //      C# -> DateTime? TimeStarted
        // GraphQL -> timeStarted: DateTime (scalar)
        if (this.TimeStarted != null) {
            s += ind + "timeStarted\n" ;
        }
        //      C# -> System.String? Type
        // GraphQL -> type: String! (scalar)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        if (this.SlaDomain == null && ec.Includes("slaDomain",false))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("slaDomain"));
            this.SlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> CloudDirectHierarchyWorkload? Snappable
        // GraphQL -> snappable: CloudDirectHierarchyWorkload! (interface)
        if (this.Snappable == null && ec.Includes("snappable",false))
        {
            var impls = new List<CloudDirectHierarchyWorkload>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("snappable"));
            this.Snappable = (CloudDirectHierarchyWorkload)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.String? CloudDirectId
        // GraphQL -> cloudDirectId: UUID! (scalar)
        if (this.CloudDirectId == null && ec.Includes("cloudDirectId",true))
        {
            this.CloudDirectId = "FETCH";
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && ec.Includes("clusterUuid",true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
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
        //      C# -> System.Boolean? ExpiryHint
        // GraphQL -> expiryHint: Boolean! (scalar)
        if (this.ExpiryHint == null && ec.Includes("expiryHint",true))
        {
            this.ExpiryHint = true;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> DateTime? IndexTime
        // GraphQL -> indexTime: DateTime (scalar)
        if (this.IndexTime == null && ec.Includes("indexTime",true))
        {
            this.IndexTime = new DateTime();
        }
        //      C# -> System.Int64? IndexingAttempts
        // GraphQL -> indexingAttempts: Long! (scalar)
        if (this.IndexingAttempts == null && ec.Includes("indexingAttempts",true))
        {
            this.IndexingAttempts = new System.Int64();
        }
        //      C# -> System.Boolean? IsCorrupted
        // GraphQL -> isCorrupted: Boolean! (scalar)
        if (this.IsCorrupted == null && ec.Includes("isCorrupted",true))
        {
            this.IsCorrupted = true;
        }
        //      C# -> System.Boolean? IsDownloadedSnapshot
        // GraphQL -> isDownloadedSnapshot: Boolean (scalar)
        if (this.IsDownloadedSnapshot == null && ec.Includes("isDownloadedSnapshot",true))
        {
            this.IsDownloadedSnapshot = true;
        }
        //      C# -> System.Boolean? IsExpired
        // GraphQL -> isExpired: Boolean! (scalar)
        if (this.IsExpired == null && ec.Includes("isExpired",true))
        {
            this.IsExpired = true;
        }
        //      C# -> System.Boolean? IsIndexed
        // GraphQL -> isIndexed: Boolean! (scalar)
        if (this.IsIndexed == null && ec.Includes("isIndexed",true))
        {
            this.IsIndexed = true;
        }
        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        if (this.IsOnDemandSnapshot == null && ec.Includes("isOnDemandSnapshot",true))
        {
            this.IsOnDemandSnapshot = true;
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (this.IsQuarantined == null && ec.Includes("isQuarantined",true))
        {
            this.IsQuarantined = true;
        }
        //      C# -> System.Boolean? IsUnindexable
        // GraphQL -> isUnindexable: Boolean! (scalar)
        if (this.IsUnindexable == null && ec.Includes("isUnindexable",true))
        {
            this.IsUnindexable = true;
        }
        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: String! (scalar)
        if (this.SnappableId == null && ec.Includes("snappableId",true))
        {
            this.SnappableId = "FETCH";
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (this.State == null && ec.Includes("state",true))
        {
            this.State = "FETCH";
        }
        //      C# -> DateTime? TimeCompleted
        // GraphQL -> timeCompleted: DateTime (scalar)
        if (this.TimeCompleted == null && ec.Includes("timeCompleted",true))
        {
            this.TimeCompleted = new DateTime();
        }
        //      C# -> DateTime? TimeStarted
        // GraphQL -> timeStarted: DateTime (scalar)
        if (this.TimeStarted == null && ec.Includes("timeStarted",true))
        {
            this.TimeStarted = new DateTime();
        }
        //      C# -> System.String? Type
        // GraphQL -> type: String! (scalar)
        if (this.Type == null && ec.Includes("type",true))
        {
            this.Type = "FETCH";
        }
    }


    #endregion

    } // class CloudDirectSnapshot
    
    #endregion

    public static class ListCloudDirectSnapshotExtensions
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
            this List<CloudDirectSnapshot> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<CloudDirectSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types