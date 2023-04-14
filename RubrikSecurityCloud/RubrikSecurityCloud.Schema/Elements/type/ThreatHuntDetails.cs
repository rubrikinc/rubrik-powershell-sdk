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

namespace Rubrik.SecurityCloud.Types
{
    #region ThreatHuntDetails
    public class ThreatHuntDetails: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: String! (scalar)
            if (this.CdmId != null)
            {
                 s += ind + "cdmId\n";

            }
            //      C# -> DateTime? EndTime
            // GraphQL -> endTime: DateTime (scalar)
            if (this.EndTime != null)
            {
                 s += ind + "endTime\n";

            }
            //      C# -> DateTime? StartTime
            // GraphQL -> startTime: DateTime (scalar)
            if (this.StartTime != null)
            {
                 s += ind + "startTime\n";

            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster != null)
            {
                 s += ind + "cluster\n";

                 s += ind + "{\n" + 
                 this.Cluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ThreatHuntConfig? Config
            // GraphQL -> config: ThreatHuntConfig! (type)
            if (this.Config != null)
            {
                 s += ind + "config\n";

                 s += ind + "{\n" + 
                 this.Config.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<WorkloadIdToSnapshotIds>? Snapshots
            // GraphQL -> snapshots: [WorkloadIdToSnapshotIds!]! (type)
            if (this.Snapshots != null)
            {
                 s += ind + "snapshots\n";

                 s += ind + "{\n" + 
                 this.Snapshots.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: String! (scalar)
            if (this.CdmId == null && Exploration.Includes(parent + ".cdmId$"))
            {
                this.CdmId = new System.String("FETCH");
            }
            //      C# -> DateTime? EndTime
            // GraphQL -> endTime: DateTime (scalar)
            if (this.EndTime == null && Exploration.Includes(parent + ".endTime$"))
            {
                this.EndTime = new DateTime();
            }
            //      C# -> DateTime? StartTime
            // GraphQL -> startTime: DateTime (scalar)
            if (this.StartTime == null && Exploration.Includes(parent + ".startTime$"))
            {
                this.StartTime = new DateTime();
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> ThreatHuntConfig? Config
            // GraphQL -> config: ThreatHuntConfig! (type)
            if (this.Config == null && Exploration.Includes(parent + ".config"))
            {
                this.Config = new ThreatHuntConfig();
                this.Config.ApplyExploratoryFragment(parent + ".config");
            }
            //      C# -> List<WorkloadIdToSnapshotIds>? Snapshots
            // GraphQL -> snapshots: [WorkloadIdToSnapshotIds!]! (type)
            if (this.Snapshots == null && Exploration.Includes(parent + ".snapshots"))
            {
                this.Snapshots = new List<WorkloadIdToSnapshotIds>();
                this.Snapshots.ApplyExploratoryFragment(parent + ".snapshots");
            }
        }


    #endregion

    } // class ThreatHuntDetails
    #endregion

    public static class ListThreatHuntDetailsExtensions
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
            this List<ThreatHuntDetails> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ThreatHuntDetails> list, 
            String parent = "")
        {
            var item = new ThreatHuntDetails();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types