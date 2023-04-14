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

namespace Rubrik.SecurityCloud.Types
{
    #region ReplicationPair
    public class ReplicationPair: IFragment
    {
        #region members
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

        //      C# -> ReplicationPairConnectionStatus? Status
        // GraphQL -> status: ReplicationPairConnectionStatus! (enum)
        [JsonProperty("status")]
        public ReplicationPairConnectionStatus? Status { get; set; }

        #endregion

    #region methods

    public ReplicationPair Set(
        System.Int64? FailedTasks = null,
        System.Boolean? IsPaused = null,
        System.Int64? RunningTasks = null,
        System.Int64? Storage = null,
        ReplicationPairConfigDetails? ConfigDetails = null,
        ConnectionStatusDetails? ConnectionDetails = null,
        NetworkThrottle? NetworkThrottle = null,
        ReplicationCluster? SourceCluster = null,
        ReplicationCluster? TargetCluster = null,
        ReplicationPairConnectionStatus? Status = null
    ) 
    {
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
        if ( Status != null ) {
            this.Status = Status;
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
            //      C# -> System.Int64? FailedTasks
            // GraphQL -> failedTasks: Long (scalar)
            if (this.FailedTasks != null)
            {
                 s += ind + "failedTasks\n";

            }
            //      C# -> System.Boolean? IsPaused
            // GraphQL -> isPaused: Boolean! (scalar)
            if (this.IsPaused != null)
            {
                 s += ind + "isPaused\n";

            }
            //      C# -> System.Int64? RunningTasks
            // GraphQL -> runningTasks: Long (scalar)
            if (this.RunningTasks != null)
            {
                 s += ind + "runningTasks\n";

            }
            //      C# -> System.Int64? Storage
            // GraphQL -> storage: Long! (scalar)
            if (this.Storage != null)
            {
                 s += ind + "storage\n";

            }
            //      C# -> ReplicationPairConfigDetails? ConfigDetails
            // GraphQL -> configDetails: ReplicationPairConfigDetails (type)
            if (this.ConfigDetails != null)
            {
                 s += ind + "configDetails\n";

                 s += ind + "{\n" + 
                 this.ConfigDetails.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ConnectionStatusDetails? ConnectionDetails
            // GraphQL -> connectionDetails: ConnectionStatusDetails! (type)
            if (this.ConnectionDetails != null)
            {
                 s += ind + "connectionDetails\n";

                 s += ind + "{\n" + 
                 this.ConnectionDetails.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> NetworkThrottle? NetworkThrottle
            // GraphQL -> networkThrottle: NetworkThrottle (type)
            if (this.NetworkThrottle != null)
            {
                 s += ind + "networkThrottle\n";

                 s += ind + "{\n" + 
                 this.NetworkThrottle.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ReplicationCluster? SourceCluster
            // GraphQL -> sourceCluster: ReplicationCluster! (type)
            if (this.SourceCluster != null)
            {
                 s += ind + "sourceCluster\n";

                 s += ind + "{\n" + 
                 this.SourceCluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ReplicationCluster? TargetCluster
            // GraphQL -> targetCluster: ReplicationCluster! (type)
            if (this.TargetCluster != null)
            {
                 s += ind + "targetCluster\n";

                 s += ind + "{\n" + 
                 this.TargetCluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ReplicationPairConnectionStatus? Status
            // GraphQL -> status: ReplicationPairConnectionStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? FailedTasks
            // GraphQL -> failedTasks: Long (scalar)
            if (this.FailedTasks == null && Exploration.Includes(parent + ".failedTasks$"))
            {
                this.FailedTasks = new System.Int64();
            }
            //      C# -> System.Boolean? IsPaused
            // GraphQL -> isPaused: Boolean! (scalar)
            if (this.IsPaused == null && Exploration.Includes(parent + ".isPaused$"))
            {
                this.IsPaused = new System.Boolean();
            }
            //      C# -> System.Int64? RunningTasks
            // GraphQL -> runningTasks: Long (scalar)
            if (this.RunningTasks == null && Exploration.Includes(parent + ".runningTasks$"))
            {
                this.RunningTasks = new System.Int64();
            }
            //      C# -> System.Int64? Storage
            // GraphQL -> storage: Long! (scalar)
            if (this.Storage == null && Exploration.Includes(parent + ".storage$"))
            {
                this.Storage = new System.Int64();
            }
            //      C# -> ReplicationPairConfigDetails? ConfigDetails
            // GraphQL -> configDetails: ReplicationPairConfigDetails (type)
            if (this.ConfigDetails == null && Exploration.Includes(parent + ".configDetails"))
            {
                this.ConfigDetails = new ReplicationPairConfigDetails();
                this.ConfigDetails.ApplyExploratoryFragment(parent + ".configDetails");
            }
            //      C# -> ConnectionStatusDetails? ConnectionDetails
            // GraphQL -> connectionDetails: ConnectionStatusDetails! (type)
            if (this.ConnectionDetails == null && Exploration.Includes(parent + ".connectionDetails"))
            {
                this.ConnectionDetails = new ConnectionStatusDetails();
                this.ConnectionDetails.ApplyExploratoryFragment(parent + ".connectionDetails");
            }
            //      C# -> NetworkThrottle? NetworkThrottle
            // GraphQL -> networkThrottle: NetworkThrottle (type)
            if (this.NetworkThrottle == null && Exploration.Includes(parent + ".networkThrottle"))
            {
                this.NetworkThrottle = new NetworkThrottle();
                this.NetworkThrottle.ApplyExploratoryFragment(parent + ".networkThrottle");
            }
            //      C# -> ReplicationCluster? SourceCluster
            // GraphQL -> sourceCluster: ReplicationCluster! (type)
            if (this.SourceCluster == null && Exploration.Includes(parent + ".sourceCluster"))
            {
                this.SourceCluster = new ReplicationCluster();
                this.SourceCluster.ApplyExploratoryFragment(parent + ".sourceCluster");
            }
            //      C# -> ReplicationCluster? TargetCluster
            // GraphQL -> targetCluster: ReplicationCluster! (type)
            if (this.TargetCluster == null && Exploration.Includes(parent + ".targetCluster"))
            {
                this.TargetCluster = new ReplicationCluster();
                this.TargetCluster.ApplyExploratoryFragment(parent + ".targetCluster");
            }
            //      C# -> ReplicationPairConnectionStatus? Status
            // GraphQL -> status: ReplicationPairConnectionStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new ReplicationPairConnectionStatus();
            }
        }


    #endregion

    } // class ReplicationPair
    #endregion

    public static class ListReplicationPairExtensions
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
            this List<ReplicationPair> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ReplicationPair> list, 
            String parent = "")
        {
            var item = new ReplicationPair();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types