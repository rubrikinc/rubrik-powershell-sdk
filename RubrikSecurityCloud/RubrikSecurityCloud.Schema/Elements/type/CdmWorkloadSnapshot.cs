// CdmWorkloadSnapshot.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region CdmWorkloadSnapshot
    public class CdmWorkloadSnapshot: BaseType
    {
        #region members

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        [JsonProperty("cdmVersion")]
        public System.String? CdmVersion { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Date
        // GraphQL -> date: String! (scalar)
        [JsonProperty("date")]
        public System.String? Date { get; set; }

        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        [JsonProperty("expirationDate")]
        public DateTime? ExpirationDate { get; set; }

        //      C# -> System.Boolean? ExpiryHint
        // GraphQL -> expiryHint: Boolean! (scalar)
        [JsonProperty("expiryHint")]
        public System.Boolean? ExpiryHint { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
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
        // GraphQL -> isDownloadedSnapshot: Boolean! (scalar)
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

        //      C# -> System.Boolean? IsUnindexable
        // GraphQL -> isUnindexable: Boolean! (scalar)
        [JsonProperty("isUnindexable")]
        public System.Boolean? IsUnindexable { get; set; }

        //      C# -> System.String? RetentionInfo
        // GraphQL -> retentionInfo: String! (scalar)
        [JsonProperty("retentionInfo")]
        public System.String? RetentionInfo { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> System.String? WorkloadType
        // GraphQL -> workloadType: String! (scalar)
        [JsonProperty("workloadType")]
        public System.String? WorkloadType { get; set; }

        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        [JsonProperty("latestUserNote")]
        public LatestUserNote? LatestUserNote { get; set; }

        //      C# -> SlaConfig? SlaDomain
        // GraphQL -> slaDomain: SlaConfig (type)
        [JsonProperty("slaDomain")]
        public SlaConfig? SlaDomain { get; set; }

        //      C# -> List<SnapshotSubObject>? SubObjs
        // GraphQL -> subObjs: [SnapshotSubObject!]! (type)
        [JsonProperty("subObjs")]
        public List<SnapshotSubObject>? SubObjs { get; set; }


        #endregion

    #region methods

    public CdmWorkloadSnapshot Set(
        System.String? CdmId = null,
        System.String? CdmVersion = null,
        System.String? ClusterUuid = null,
        System.String? Date = null,
        DateTime? ExpirationDate = null,
        System.Boolean? ExpiryHint = null,
        System.String? Id = null,
        System.Int64? IndexingAttempts = null,
        System.Boolean? IsCorrupted = null,
        System.Boolean? IsDownloadedSnapshot = null,
        System.Boolean? IsExpired = null,
        System.Boolean? IsIndexed = null,
        System.Boolean? IsOnDemandSnapshot = null,
        System.Boolean? IsUnindexable = null,
        System.String? RetentionInfo = null,
        System.String? WorkloadId = null,
        System.String? WorkloadType = null,
        LatestUserNote? LatestUserNote = null,
        SlaConfig? SlaDomain = null,
        List<SnapshotSubObject>? SubObjs = null
    ) 
    {
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( CdmVersion != null ) {
            this.CdmVersion = CdmVersion;
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
        if ( IsUnindexable != null ) {
            this.IsUnindexable = IsUnindexable;
        }
        if ( RetentionInfo != null ) {
            this.RetentionInfo = RetentionInfo;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
        }
        if ( WorkloadType != null ) {
            this.WorkloadType = WorkloadType;
        }
        if ( LatestUserNote != null ) {
            this.LatestUserNote = LatestUserNote;
        }
        if ( SlaDomain != null ) {
            this.SlaDomain = SlaDomain;
        }
        if ( SubObjs != null ) {
            this.SubObjs = SubObjs;
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
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            s += ind + "cdmId\n" ;
        }
        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        if (this.CdmVersion != null) {
            s += ind + "cdmVersion\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.String? Date
        // GraphQL -> date: String! (scalar)
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
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
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
        // GraphQL -> isDownloadedSnapshot: Boolean! (scalar)
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
        //      C# -> System.Boolean? IsUnindexable
        // GraphQL -> isUnindexable: Boolean! (scalar)
        if (this.IsUnindexable != null) {
            s += ind + "isUnindexable\n" ;
        }
        //      C# -> System.String? RetentionInfo
        // GraphQL -> retentionInfo: String! (scalar)
        if (this.RetentionInfo != null) {
            s += ind + "retentionInfo\n" ;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (this.WorkloadId != null) {
            s += ind + "workloadId\n" ;
        }
        //      C# -> System.String? WorkloadType
        // GraphQL -> workloadType: String! (scalar)
        if (this.WorkloadType != null) {
            s += ind + "workloadType\n" ;
        }
        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        if (this.LatestUserNote != null) {
            s += ind + "latestUserNote {\n" + this.LatestUserNote.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SlaConfig? SlaDomain
        // GraphQL -> slaDomain: SlaConfig (type)
        if (this.SlaDomain != null) {
            s += ind + "slaDomain {\n" + this.SlaDomain.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<SnapshotSubObject>? SubObjs
        // GraphQL -> subObjs: [SnapshotSubObject!]! (type)
        if (this.SubObjs != null) {
            s += ind + "subObjs {\n" + this.SubObjs.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId == null && Exploration.Includes(parent + ".cdmId", true))
        {
            this.CdmId = new System.String("FETCH");
        }
        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        if (this.CdmVersion == null && Exploration.Includes(parent + ".cdmVersion", true))
        {
            this.CdmVersion = new System.String("FETCH");
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = new System.String("FETCH");
        }
        //      C# -> System.String? Date
        // GraphQL -> date: String! (scalar)
        if (this.Date == null && Exploration.Includes(parent + ".date", true))
        {
            this.Date = new System.String("FETCH");
        }
        //      C# -> DateTime? ExpirationDate
        // GraphQL -> expirationDate: DateTime (scalar)
        if (this.ExpirationDate == null && Exploration.Includes(parent + ".expirationDate", true))
        {
            this.ExpirationDate = new DateTime();
        }
        //      C# -> System.Boolean? ExpiryHint
        // GraphQL -> expiryHint: Boolean! (scalar)
        if (this.ExpiryHint == null && Exploration.Includes(parent + ".expiryHint", true))
        {
            this.ExpiryHint = true;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.Int64? IndexingAttempts
        // GraphQL -> indexingAttempts: Long! (scalar)
        if (this.IndexingAttempts == null && Exploration.Includes(parent + ".indexingAttempts", true))
        {
            this.IndexingAttempts = new System.Int64();
        }
        //      C# -> System.Boolean? IsCorrupted
        // GraphQL -> isCorrupted: Boolean! (scalar)
        if (this.IsCorrupted == null && Exploration.Includes(parent + ".isCorrupted", true))
        {
            this.IsCorrupted = true;
        }
        //      C# -> System.Boolean? IsDownloadedSnapshot
        // GraphQL -> isDownloadedSnapshot: Boolean! (scalar)
        if (this.IsDownloadedSnapshot == null && Exploration.Includes(parent + ".isDownloadedSnapshot", true))
        {
            this.IsDownloadedSnapshot = true;
        }
        //      C# -> System.Boolean? IsExpired
        // GraphQL -> isExpired: Boolean! (scalar)
        if (this.IsExpired == null && Exploration.Includes(parent + ".isExpired", true))
        {
            this.IsExpired = true;
        }
        //      C# -> System.Boolean? IsIndexed
        // GraphQL -> isIndexed: Boolean! (scalar)
        if (this.IsIndexed == null && Exploration.Includes(parent + ".isIndexed", true))
        {
            this.IsIndexed = true;
        }
        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        if (this.IsOnDemandSnapshot == null && Exploration.Includes(parent + ".isOnDemandSnapshot", true))
        {
            this.IsOnDemandSnapshot = true;
        }
        //      C# -> System.Boolean? IsUnindexable
        // GraphQL -> isUnindexable: Boolean! (scalar)
        if (this.IsUnindexable == null && Exploration.Includes(parent + ".isUnindexable", true))
        {
            this.IsUnindexable = true;
        }
        //      C# -> System.String? RetentionInfo
        // GraphQL -> retentionInfo: String! (scalar)
        if (this.RetentionInfo == null && Exploration.Includes(parent + ".retentionInfo", true))
        {
            this.RetentionInfo = new System.String("FETCH");
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (this.WorkloadId == null && Exploration.Includes(parent + ".workloadId", true))
        {
            this.WorkloadId = new System.String("FETCH");
        }
        //      C# -> System.String? WorkloadType
        // GraphQL -> workloadType: String! (scalar)
        if (this.WorkloadType == null && Exploration.Includes(parent + ".workloadType", true))
        {
            this.WorkloadType = new System.String("FETCH");
        }
        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        if (this.LatestUserNote == null && Exploration.Includes(parent + ".latestUserNote"))
        {
            this.LatestUserNote = new LatestUserNote();
            this.LatestUserNote.ApplyExploratoryFieldSpec(parent + ".latestUserNote");
        }
        //      C# -> SlaConfig? SlaDomain
        // GraphQL -> slaDomain: SlaConfig (type)
        if (this.SlaDomain == null && Exploration.Includes(parent + ".slaDomain"))
        {
            this.SlaDomain = new SlaConfig();
            this.SlaDomain.ApplyExploratoryFieldSpec(parent + ".slaDomain");
        }
        //      C# -> List<SnapshotSubObject>? SubObjs
        // GraphQL -> subObjs: [SnapshotSubObject!]! (type)
        if (this.SubObjs == null && Exploration.Includes(parent + ".subObjs"))
        {
            this.SubObjs = new List<SnapshotSubObject>();
            this.SubObjs.ApplyExploratoryFieldSpec(parent + ".subObjs");
        }
    }


    #endregion

    } // class CdmWorkloadSnapshot
    
    #endregion

    public static class ListCdmWorkloadSnapshotExtensions
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
            this List<CdmWorkloadSnapshot> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmWorkloadSnapshot> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmWorkloadSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types