// PendingEvaluationResults.cs
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
    #region PendingEvaluationResults
    public class PendingEvaluationResults: BaseType
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.String? Info
        // GraphQL -> info: String! (scalar)
        [JsonProperty("info")]
        public System.String? Info { get; set; }

        //      C# -> System.Boolean? IsCompleted
        // GraphQL -> isCompleted: Boolean! (scalar)
        [JsonProperty("isCompleted")]
        public System.Boolean? IsCompleted { get; set; }

        //      C# -> System.String? ManagedId
        // GraphQL -> managedId: String! (scalar)
        [JsonProperty("managedId")]
        public System.String? ManagedId { get; set; }

        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        [JsonProperty("snapshotDate")]
        public DateTime? SnapshotDate { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String! (scalar)
        [JsonProperty("workloadName")]
        public System.String? WorkloadName { get; set; }

        //      C# -> System.String? WorkloadType
        // GraphQL -> workloadType: String! (scalar)
        [JsonProperty("workloadType")]
        public System.String? WorkloadType { get; set; }


        #endregion

    #region methods

    public PendingEvaluationResults Set(
        System.String? ClusterUuid = null,
        DateTime? CreatedAt = null,
        System.String? Info = null,
        System.Boolean? IsCompleted = null,
        System.String? ManagedId = null,
        DateTime? SnapshotDate = null,
        System.String? SnapshotId = null,
        DateTime? UpdatedAt = null,
        System.String? WorkloadId = null,
        System.String? WorkloadName = null,
        System.String? WorkloadType = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( Info != null ) {
            this.Info = Info;
        }
        if ( IsCompleted != null ) {
            this.IsCompleted = IsCompleted;
        }
        if ( ManagedId != null ) {
            this.ManagedId = ManagedId;
        }
        if ( SnapshotDate != null ) {
            this.SnapshotDate = SnapshotDate;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( UpdatedAt != null ) {
            this.UpdatedAt = UpdatedAt;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
        }
        if ( WorkloadName != null ) {
            this.WorkloadName = WorkloadName;
        }
        if ( WorkloadType != null ) {
            this.WorkloadType = WorkloadType;
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
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt != null) {
            s += ind + "createdAt\n" ;
        }
        //      C# -> System.String? Info
        // GraphQL -> info: String! (scalar)
        if (this.Info != null) {
            s += ind + "info\n" ;
        }
        //      C# -> System.Boolean? IsCompleted
        // GraphQL -> isCompleted: Boolean! (scalar)
        if (this.IsCompleted != null) {
            s += ind + "isCompleted\n" ;
        }
        //      C# -> System.String? ManagedId
        // GraphQL -> managedId: String! (scalar)
        if (this.ManagedId != null) {
            s += ind + "managedId\n" ;
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        if (this.SnapshotDate != null) {
            s += ind + "snapshotDate\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt != null) {
            s += ind + "updatedAt\n" ;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (this.WorkloadId != null) {
            s += ind + "workloadId\n" ;
        }
        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String! (scalar)
        if (this.WorkloadName != null) {
            s += ind + "workloadName\n" ;
        }
        //      C# -> System.String? WorkloadType
        // GraphQL -> workloadType: String! (scalar)
        if (this.WorkloadType != null) {
            s += ind + "workloadType\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt == null && Exploration.Includes(parent + ".createdAt", true))
        {
            this.CreatedAt = new DateTime();
        }
        //      C# -> System.String? Info
        // GraphQL -> info: String! (scalar)
        if (this.Info == null && Exploration.Includes(parent + ".info", true))
        {
            this.Info = "FETCH";
        }
        //      C# -> System.Boolean? IsCompleted
        // GraphQL -> isCompleted: Boolean! (scalar)
        if (this.IsCompleted == null && Exploration.Includes(parent + ".isCompleted", true))
        {
            this.IsCompleted = true;
        }
        //      C# -> System.String? ManagedId
        // GraphQL -> managedId: String! (scalar)
        if (this.ManagedId == null && Exploration.Includes(parent + ".managedId", true))
        {
            this.ManagedId = "FETCH";
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        if (this.SnapshotDate == null && Exploration.Includes(parent + ".snapshotDate", true))
        {
            this.SnapshotDate = new DateTime();
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId", true))
        {
            this.SnapshotId = "FETCH";
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt == null && Exploration.Includes(parent + ".updatedAt", true))
        {
            this.UpdatedAt = new DateTime();
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (this.WorkloadId == null && Exploration.Includes(parent + ".workloadId", true))
        {
            this.WorkloadId = "FETCH";
        }
        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String! (scalar)
        if (this.WorkloadName == null && Exploration.Includes(parent + ".workloadName", true))
        {
            this.WorkloadName = "FETCH";
        }
        //      C# -> System.String? WorkloadType
        // GraphQL -> workloadType: String! (scalar)
        if (this.WorkloadType == null && Exploration.Includes(parent + ".workloadType", true))
        {
            this.WorkloadType = "FETCH";
        }
    }


    #endregion

    } // class PendingEvaluationResults
    
    #endregion

    public static class ListPendingEvaluationResultsExtensions
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
            this List<PendingEvaluationResults> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PendingEvaluationResults> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PendingEvaluationResults());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types