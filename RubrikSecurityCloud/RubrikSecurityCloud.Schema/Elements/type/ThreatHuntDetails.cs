// ThreatHuntDetails.cs
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
    #region ThreatHuntDetails
    public class ThreatHuntDetails: BaseType
    {
        #region members

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> ThreatHuntConfig? Config
        // GraphQL -> config: ThreatHuntConfig! (type)
        [JsonProperty("config")]
        public ThreatHuntConfig? Config { get; set; }

        //      C# -> List<WorkloadIdToSnapshotIds>? Snapshots
        // GraphQL -> snapshots: [WorkloadIdToSnapshotIds!]! (type)
        [JsonProperty("snapshots")]
        public List<WorkloadIdToSnapshotIds>? Snapshots { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatHuntDetails";
    }

    public ThreatHuntDetails Set(
        System.String? CdmId = null,
        DateTime? EndTime = null,
        DateTime? StartTime = null,
        Cluster? Cluster = null,
        ThreatHuntConfig? Config = null,
        List<WorkloadIdToSnapshotIds>? Snapshots = null
    ) 
    {
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( Config != null ) {
            this.Config = Config;
        }
        if ( Snapshots != null ) {
            this.Snapshots = Snapshots;
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
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime != null) {
            s += ind + "endTime\n" ;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime != null) {
            s += ind + "startTime\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ThreatHuntConfig? Config
        // GraphQL -> config: ThreatHuntConfig! (type)
        if (this.Config != null) {
            var fspec = this.Config.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "config {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<WorkloadIdToSnapshotIds>? Snapshots
        // GraphQL -> snapshots: [WorkloadIdToSnapshotIds!]! (type)
        if (this.Snapshots != null) {
            var fspec = this.Snapshots.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshots {\n" + fspec + ind + "}\n" ;
            }
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
            this.CdmId = "FETCH";
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime == null && Exploration.Includes(parent + ".endTime", true))
        {
            this.EndTime = new DateTime();
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime == null && Exploration.Includes(parent + ".startTime", true))
        {
            this.StartTime = new DateTime();
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
        //      C# -> ThreatHuntConfig? Config
        // GraphQL -> config: ThreatHuntConfig! (type)
        if (this.Config == null && Exploration.Includes(parent + ".config"))
        {
            this.Config = new ThreatHuntConfig();
            this.Config.ApplyExploratoryFieldSpec(parent + ".config");
        }
        //      C# -> List<WorkloadIdToSnapshotIds>? Snapshots
        // GraphQL -> snapshots: [WorkloadIdToSnapshotIds!]! (type)
        if (this.Snapshots == null && Exploration.Includes(parent + ".snapshots"))
        {
            this.Snapshots = new List<WorkloadIdToSnapshotIds>();
            this.Snapshots.ApplyExploratoryFieldSpec(parent + ".snapshots");
        }
    }


    #endregion

    } // class ThreatHuntDetails
    
    #endregion

    public static class ListThreatHuntDetailsExtensions
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
            this List<ThreatHuntDetails> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ThreatHuntDetails> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHuntDetails());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types