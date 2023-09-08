// Db2RecoverableRange.cs
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
    #region Db2RecoverableRange
    public class Db2RecoverableRange: BaseType
    {
        #region members

        //      C# -> System.String? BaseSnapshotId
        // GraphQL -> baseSnapshotId: String (scalar)
        [JsonProperty("baseSnapshotId")]
        public System.String? BaseSnapshotId { get; set; }

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? DbId
        // GraphQL -> dbId: String! (scalar)
        [JsonProperty("dbId")]
        public System.String? DbId { get; set; }

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Db2RecoverableRange";
    }

    public Db2RecoverableRange Set(
        System.String? BaseSnapshotId = null,
        System.String? CdmId = null,
        System.String? ClusterUuid = null,
        System.String? DbId = null,
        DateTime? EndTime = null,
        System.String? Fid = null,
        System.Boolean? IsArchived = null,
        DateTime? StartTime = null
    ) 
    {
        if ( BaseSnapshotId != null ) {
            this.BaseSnapshotId = BaseSnapshotId;
        }
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( DbId != null ) {
            this.DbId = DbId;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
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
        //      C# -> System.String? BaseSnapshotId
        // GraphQL -> baseSnapshotId: String (scalar)
        if (this.BaseSnapshotId != null) {
            s += ind + "baseSnapshotId\n" ;
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            s += ind + "cdmId\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.String? DbId
        // GraphQL -> dbId: String! (scalar)
        if (this.DbId != null) {
            s += ind + "dbId\n" ;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime != null) {
            s += ind + "endTime\n" ;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (this.Fid != null) {
            s += ind + "fid\n" ;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            s += ind + "isArchived\n" ;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime != null) {
            s += ind + "startTime\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? BaseSnapshotId
        // GraphQL -> baseSnapshotId: String (scalar)
        if (this.BaseSnapshotId == null && ec.Includes("baseSnapshotId",true))
        {
            this.BaseSnapshotId = "FETCH";
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId == null && ec.Includes("cdmId",true))
        {
            this.CdmId = "FETCH";
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && ec.Includes("clusterUuid",true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> System.String? DbId
        // GraphQL -> dbId: String! (scalar)
        if (this.DbId == null && ec.Includes("dbId",true))
        {
            this.DbId = "FETCH";
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime == null && ec.Includes("endTime",true))
        {
            this.EndTime = new DateTime();
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (this.Fid == null && ec.Includes("fid",true))
        {
            this.Fid = "FETCH";
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived == null && ec.Includes("isArchived",true))
        {
            this.IsArchived = true;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime == null && ec.Includes("startTime",true))
        {
            this.StartTime = new DateTime();
        }
    }


    #endregion

    } // class Db2RecoverableRange
    
    #endregion

    public static class ListDb2RecoverableRangeExtensions
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
            this List<Db2RecoverableRange> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Db2RecoverableRange> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Db2RecoverableRange());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<Db2RecoverableRange> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types