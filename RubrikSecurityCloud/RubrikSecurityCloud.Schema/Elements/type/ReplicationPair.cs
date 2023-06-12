// ReplicationPair.cs
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
    #region ReplicationPair
    public class ReplicationPair: BaseType
    {
        #region members

        //      C# -> ReplicationPairConnectionStatus? Status
        // GraphQL -> status: ReplicationPairConnectionStatus! (enum)
        [JsonProperty("status")]
        public ReplicationPairConnectionStatus? Status { get; set; }

        //      C# -> System.Int64? FailedTasks
        // GraphQL -> failedTasks: Long (scalar)
        [JsonProperty("failedTasks")]
        public System.Int64? FailedTasks { get; set; }

        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean! (scalar)
        [JsonProperty("isPaused")]
        public System.Boolean? IsPaused { get; set; }

        //      C# -> System.Int64? RunningTasks
        // GraphQL -> runningTasks: Long (scalar)
        [JsonProperty("runningTasks")]
        public System.Int64? RunningTasks { get; set; }

        //      C# -> System.Int64? Storage
        // GraphQL -> storage: Long! (scalar)
        [JsonProperty("storage")]
        public System.Int64? Storage { get; set; }

        //      C# -> ReplicationPairConfigDetails? ConfigDetails
        // GraphQL -> configDetails: ReplicationPairConfigDetails (type)
        [JsonProperty("configDetails")]
        public ReplicationPairConfigDetails? ConfigDetails { get; set; }

        //      C# -> ConnectionStatusDetails? ConnectionDetails
        // GraphQL -> connectionDetails: ConnectionStatusDetails! (type)
        [JsonProperty("connectionDetails")]
        public ConnectionStatusDetails? ConnectionDetails { get; set; }

        //      C# -> NetworkThrottle? NetworkThrottle
        // GraphQL -> networkThrottle: NetworkThrottle (type)
        [JsonProperty("networkThrottle")]
        public NetworkThrottle? NetworkThrottle { get; set; }

        //      C# -> ReplicationCluster? SourceCluster
        // GraphQL -> sourceCluster: ReplicationCluster! (type)
        [JsonProperty("sourceCluster")]
        public ReplicationCluster? SourceCluster { get; set; }

        //      C# -> ReplicationCluster? TargetCluster
        // GraphQL -> targetCluster: ReplicationCluster! (type)
        [JsonProperty("targetCluster")]
        public ReplicationCluster? TargetCluster { get; set; }


        #endregion

    #region methods

    public ReplicationPair Set(
        ReplicationPairConnectionStatus? Status = null,
        System.Int64? FailedTasks = null,
        System.Boolean? IsPaused = null,
        System.Int64? RunningTasks = null,
        System.Int64? Storage = null,
        ReplicationPairConfigDetails? ConfigDetails = null,
        ConnectionStatusDetails? ConnectionDetails = null,
        NetworkThrottle? NetworkThrottle = null,
        ReplicationCluster? SourceCluster = null,
        ReplicationCluster? TargetCluster = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( FailedTasks != null ) {
            this.FailedTasks = FailedTasks;
        }
        if ( IsPaused != null ) {
            this.IsPaused = IsPaused;
        }
        if ( RunningTasks != null ) {
            this.RunningTasks = RunningTasks;
        }
        if ( Storage != null ) {
            this.Storage = Storage;
        }
        if ( ConfigDetails != null ) {
            this.ConfigDetails = ConfigDetails;
        }
        if ( ConnectionDetails != null ) {
            this.ConnectionDetails = ConnectionDetails;
        }
        if ( NetworkThrottle != null ) {
            this.NetworkThrottle = NetworkThrottle;
        }
        if ( SourceCluster != null ) {
            this.SourceCluster = SourceCluster;
        }
        if ( TargetCluster != null ) {
            this.TargetCluster = TargetCluster;
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
        //      C# -> ReplicationPairConnectionStatus? Status
        // GraphQL -> status: ReplicationPairConnectionStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.Int64? FailedTasks
        // GraphQL -> failedTasks: Long (scalar)
        if (this.FailedTasks != null) {
            s += ind + "failedTasks\n" ;
        }
        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean! (scalar)
        if (this.IsPaused != null) {
            s += ind + "isPaused\n" ;
        }
        //      C# -> System.Int64? RunningTasks
        // GraphQL -> runningTasks: Long (scalar)
        if (this.RunningTasks != null) {
            s += ind + "runningTasks\n" ;
        }
        //      C# -> System.Int64? Storage
        // GraphQL -> storage: Long! (scalar)
        if (this.Storage != null) {
            s += ind + "storage\n" ;
        }
        //      C# -> ReplicationPairConfigDetails? ConfigDetails
        // GraphQL -> configDetails: ReplicationPairConfigDetails (type)
        if (this.ConfigDetails != null) {
            var fspec = this.ConfigDetails.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "configDetails {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ConnectionStatusDetails? ConnectionDetails
        // GraphQL -> connectionDetails: ConnectionStatusDetails! (type)
        if (this.ConnectionDetails != null) {
            var fspec = this.ConnectionDetails.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "connectionDetails {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> NetworkThrottle? NetworkThrottle
        // GraphQL -> networkThrottle: NetworkThrottle (type)
        if (this.NetworkThrottle != null) {
            var fspec = this.NetworkThrottle.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "networkThrottle {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ReplicationCluster? SourceCluster
        // GraphQL -> sourceCluster: ReplicationCluster! (type)
        if (this.SourceCluster != null) {
            var fspec = this.SourceCluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sourceCluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ReplicationCluster? TargetCluster
        // GraphQL -> targetCluster: ReplicationCluster! (type)
        if (this.TargetCluster != null) {
            var fspec = this.TargetCluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "targetCluster {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ReplicationPairConnectionStatus? Status
        // GraphQL -> status: ReplicationPairConnectionStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new ReplicationPairConnectionStatus();
        }
        //      C# -> System.Int64? FailedTasks
        // GraphQL -> failedTasks: Long (scalar)
        if (this.FailedTasks == null && Exploration.Includes(parent + ".failedTasks", true))
        {
            this.FailedTasks = new System.Int64();
        }
        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean! (scalar)
        if (this.IsPaused == null && Exploration.Includes(parent + ".isPaused", true))
        {
            this.IsPaused = true;
        }
        //      C# -> System.Int64? RunningTasks
        // GraphQL -> runningTasks: Long (scalar)
        if (this.RunningTasks == null && Exploration.Includes(parent + ".runningTasks", true))
        {
            this.RunningTasks = new System.Int64();
        }
        //      C# -> System.Int64? Storage
        // GraphQL -> storage: Long! (scalar)
        if (this.Storage == null && Exploration.Includes(parent + ".storage", true))
        {
            this.Storage = new System.Int64();
        }
        //      C# -> ReplicationPairConfigDetails? ConfigDetails
        // GraphQL -> configDetails: ReplicationPairConfigDetails (type)
        if (this.ConfigDetails == null && Exploration.Includes(parent + ".configDetails"))
        {
            this.ConfigDetails = new ReplicationPairConfigDetails();
            this.ConfigDetails.ApplyExploratoryFieldSpec(parent + ".configDetails");
        }
        //      C# -> ConnectionStatusDetails? ConnectionDetails
        // GraphQL -> connectionDetails: ConnectionStatusDetails! (type)
        if (this.ConnectionDetails == null && Exploration.Includes(parent + ".connectionDetails"))
        {
            this.ConnectionDetails = new ConnectionStatusDetails();
            this.ConnectionDetails.ApplyExploratoryFieldSpec(parent + ".connectionDetails");
        }
        //      C# -> NetworkThrottle? NetworkThrottle
        // GraphQL -> networkThrottle: NetworkThrottle (type)
        if (this.NetworkThrottle == null && Exploration.Includes(parent + ".networkThrottle"))
        {
            this.NetworkThrottle = new NetworkThrottle();
            this.NetworkThrottle.ApplyExploratoryFieldSpec(parent + ".networkThrottle");
        }
        //      C# -> ReplicationCluster? SourceCluster
        // GraphQL -> sourceCluster: ReplicationCluster! (type)
        if (this.SourceCluster == null && Exploration.Includes(parent + ".sourceCluster"))
        {
            this.SourceCluster = new ReplicationCluster();
            this.SourceCluster.ApplyExploratoryFieldSpec(parent + ".sourceCluster");
        }
        //      C# -> ReplicationCluster? TargetCluster
        // GraphQL -> targetCluster: ReplicationCluster! (type)
        if (this.TargetCluster == null && Exploration.Includes(parent + ".targetCluster"))
        {
            this.TargetCluster = new ReplicationCluster();
            this.TargetCluster.ApplyExploratoryFieldSpec(parent + ".targetCluster");
        }
    }


    #endregion

    } // class ReplicationPair
    
    #endregion

    public static class ListReplicationPairExtensions
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
            this List<ReplicationPair> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReplicationPair> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ReplicationPair());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types