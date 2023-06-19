// MosaicSnapshot.cs
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
    #region MosaicSnapshot
    public class MosaicSnapshot: BaseType
    {
        #region members

        //      C# -> MosaicSnapshotType? SnapshotType
        // GraphQL -> snapshotType: MosaicSnapshotType! (enum)
        [JsonProperty("snapshotType")]
        public MosaicSnapshotType? SnapshotType { get; set; }

        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        [JsonProperty("slaDomain")]
        public SlaDomain? SlaDomain { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? DbInfo
        // GraphQL -> dbInfo: String (scalar)
        [JsonProperty("dbInfo")]
        public System.String? DbInfo { get; set; }

        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        [JsonProperty("expirationTime")]
        public DateTime? ExpirationTime { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int32? JobDuration
        // GraphQL -> jobDuration: Int (scalar)
        [JsonProperty("jobDuration")]
        public System.Int32? JobDuration { get; set; }

        //      C# -> DateTime? Version
        // GraphQL -> version: DateTime! (scalar)
        [JsonProperty("version")]
        public DateTime? Version { get; set; }

        //      C# -> System.String? VersionState
        // GraphQL -> versionState: String (scalar)
        [JsonProperty("versionState")]
        public System.String? VersionState { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }


        #endregion

    #region methods

    public MosaicSnapshot Set(
        MosaicSnapshotType? SnapshotType = null,
        SlaDomain? SlaDomain = null,
        System.String? ClusterUuid = null,
        System.String? DbInfo = null,
        DateTime? ExpirationTime = null,
        System.String? Id = null,
        System.Int32? JobDuration = null,
        DateTime? Version = null,
        System.String? VersionState = null,
        System.String? WorkloadId = null
    ) 
    {
        if ( SnapshotType != null ) {
            this.SnapshotType = SnapshotType;
        }
        if ( SlaDomain != null ) {
            this.SlaDomain = SlaDomain;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( DbInfo != null ) {
            this.DbInfo = DbInfo;
        }
        if ( ExpirationTime != null ) {
            this.ExpirationTime = ExpirationTime;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( JobDuration != null ) {
            this.JobDuration = JobDuration;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( VersionState != null ) {
            this.VersionState = VersionState;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
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
        //      C# -> MosaicSnapshotType? SnapshotType
        // GraphQL -> snapshotType: MosaicSnapshotType! (enum)
        if (this.SnapshotType != null) {
            s += ind + "snapshotType\n" ;
        }
        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        if (this.SlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.SlaDomain).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "slaDomain {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.String? DbInfo
        // GraphQL -> dbInfo: String (scalar)
        if (this.DbInfo != null) {
            s += ind + "dbInfo\n" ;
        }
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        if (this.ExpirationTime != null) {
            s += ind + "expirationTime\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Int32? JobDuration
        // GraphQL -> jobDuration: Int (scalar)
        if (this.JobDuration != null) {
            s += ind + "jobDuration\n" ;
        }
        //      C# -> DateTime? Version
        // GraphQL -> version: DateTime! (scalar)
        if (this.Version != null) {
            s += ind + "version\n" ;
        }
        //      C# -> System.String? VersionState
        // GraphQL -> versionState: String (scalar)
        if (this.VersionState != null) {
            s += ind + "versionState\n" ;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (this.WorkloadId != null) {
            s += ind + "workloadId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> MosaicSnapshotType? SnapshotType
        // GraphQL -> snapshotType: MosaicSnapshotType! (enum)
        if (this.SnapshotType == null && Exploration.Includes(parent + ".snapshotType", true))
        {
            this.SnapshotType = new MosaicSnapshotType();
        }
        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        if (this.SlaDomain == null && Exploration.Includes(parent + ".slaDomain"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".slaDomain");
            this.SlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> System.String? DbInfo
        // GraphQL -> dbInfo: String (scalar)
        if (this.DbInfo == null && Exploration.Includes(parent + ".dbInfo", true))
        {
            this.DbInfo = "FETCH";
        }
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        if (this.ExpirationTime == null && Exploration.Includes(parent + ".expirationTime", true))
        {
            this.ExpirationTime = new DateTime();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Int32? JobDuration
        // GraphQL -> jobDuration: Int (scalar)
        if (this.JobDuration == null && Exploration.Includes(parent + ".jobDuration", true))
        {
            this.JobDuration = Int32.MinValue;
        }
        //      C# -> DateTime? Version
        // GraphQL -> version: DateTime! (scalar)
        if (this.Version == null && Exploration.Includes(parent + ".version", true))
        {
            this.Version = new DateTime();
        }
        //      C# -> System.String? VersionState
        // GraphQL -> versionState: String (scalar)
        if (this.VersionState == null && Exploration.Includes(parent + ".versionState", true))
        {
            this.VersionState = "FETCH";
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (this.WorkloadId == null && Exploration.Includes(parent + ".workloadId", true))
        {
            this.WorkloadId = "FETCH";
        }
    }


    #endregion

    } // class MosaicSnapshot
    
    #endregion

    public static class ListMosaicSnapshotExtensions
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
            this List<MosaicSnapshot> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MosaicSnapshot> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MosaicSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types