// ReplicationSpecV2.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:12.
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
    #region ReplicationSpecV2
    public class ReplicationSpecV2: IFragment
    {
        #region members
        //      C# -> System.String? AwsRegion
        // GraphQL -> awsRegion: String! (scalar)
        [JsonProperty("awsRegion")]
        public System.String? AwsRegion { get; set; }

        //      C# -> System.String? AzureRegion
        // GraphQL -> azureRegion: String! (scalar)
        [JsonProperty("azureRegion")]
        public System.String? AzureRegion { get; set; }

        //      C# -> AwsReplicationTarget? AwsTarget
        // GraphQL -> awsTarget: AwsReplicationTarget! (type)
        [JsonProperty("awsTarget")]
        public AwsReplicationTarget? AwsTarget { get; set; }

        //      C# -> AzureReplicationTarget? AzureTarget
        // GraphQL -> azureTarget: AzureReplicationTarget! (type)
        [JsonProperty("azureTarget")]
        public AzureReplicationTarget? AzureTarget { get; set; }

        //      C# -> List<CascadingArchivalSpec>? CascadingArchivalSpecs
        // GraphQL -> cascadingArchivalSpecs: [CascadingArchivalSpec!]! (type)
        [JsonProperty("cascadingArchivalSpecs")]
        public List<CascadingArchivalSpec>? CascadingArchivalSpecs { get; set; }

        //      C# -> SlaReplicationCluster? Cluster
        // GraphQL -> cluster: SlaReplicationCluster (type)
        [JsonProperty("cluster")]
        public SlaReplicationCluster? Cluster { get; set; }

        //      C# -> Duration? ReplicationLocalRetentionDuration
        // GraphQL -> replicationLocalRetentionDuration: Duration (type)
        [JsonProperty("replicationLocalRetentionDuration")]
        public Duration? ReplicationLocalRetentionDuration { get; set; }

        //      C# -> Duration? RetentionDuration
        // GraphQL -> retentionDuration: Duration (type)
        [JsonProperty("retentionDuration")]
        public Duration? RetentionDuration { get; set; }

        //      C# -> TargetMapping? TargetMapping
        // GraphQL -> targetMapping: TargetMapping (type)
        [JsonProperty("targetMapping")]
        public TargetMapping? TargetMapping { get; set; }

        #endregion

    #region methods

    public ReplicationSpecV2 Set(
        System.String? AwsRegion = null,
        System.String? AzureRegion = null,
        AwsReplicationTarget? AwsTarget = null,
        AzureReplicationTarget? AzureTarget = null,
        List<CascadingArchivalSpec>? CascadingArchivalSpecs = null,
        SlaReplicationCluster? Cluster = null,
        Duration? ReplicationLocalRetentionDuration = null,
        Duration? RetentionDuration = null,
        TargetMapping? TargetMapping = null
    ) 
    {
        if ( AwsRegion != null ) {
            this.AwsRegion = AwsRegion;
        }
        if ( AzureRegion != null ) {
            this.AzureRegion = AzureRegion;
        }
        if ( AwsTarget != null ) {
            this.AwsTarget = AwsTarget;
        }
        if ( AzureTarget != null ) {
            this.AzureTarget = AzureTarget;
        }
        if ( CascadingArchivalSpecs != null ) {
            this.CascadingArchivalSpecs = CascadingArchivalSpecs;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( ReplicationLocalRetentionDuration != null ) {
            this.ReplicationLocalRetentionDuration = ReplicationLocalRetentionDuration;
        }
        if ( RetentionDuration != null ) {
            this.RetentionDuration = RetentionDuration;
        }
        if ( TargetMapping != null ) {
            this.TargetMapping = TargetMapping;
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
            //      C# -> System.String? AwsRegion
            // GraphQL -> awsRegion: String! (scalar)
            if (this.AwsRegion != null)
            {
                 s += ind + "awsRegion\n";

            }
            //      C# -> System.String? AzureRegion
            // GraphQL -> azureRegion: String! (scalar)
            if (this.AzureRegion != null)
            {
                 s += ind + "azureRegion\n";

            }
            //      C# -> AwsReplicationTarget? AwsTarget
            // GraphQL -> awsTarget: AwsReplicationTarget! (type)
            if (this.AwsTarget != null)
            {
                 s += ind + "awsTarget\n";

                 s += ind + "{\n" + 
                 this.AwsTarget.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AzureReplicationTarget? AzureTarget
            // GraphQL -> azureTarget: AzureReplicationTarget! (type)
            if (this.AzureTarget != null)
            {
                 s += ind + "azureTarget\n";

                 s += ind + "{\n" + 
                 this.AzureTarget.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<CascadingArchivalSpec>? CascadingArchivalSpecs
            // GraphQL -> cascadingArchivalSpecs: [CascadingArchivalSpec!]! (type)
            if (this.CascadingArchivalSpecs != null)
            {
                 s += ind + "cascadingArchivalSpecs\n";

                 s += ind + "{\n" + 
                 this.CascadingArchivalSpecs.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SlaReplicationCluster? Cluster
            // GraphQL -> cluster: SlaReplicationCluster (type)
            if (this.Cluster != null)
            {
                 s += ind + "cluster\n";

                 s += ind + "{\n" + 
                 this.Cluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Duration? ReplicationLocalRetentionDuration
            // GraphQL -> replicationLocalRetentionDuration: Duration (type)
            if (this.ReplicationLocalRetentionDuration != null)
            {
                 s += ind + "replicationLocalRetentionDuration\n";

                 s += ind + "{\n" + 
                 this.ReplicationLocalRetentionDuration.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Duration? RetentionDuration
            // GraphQL -> retentionDuration: Duration (type)
            if (this.RetentionDuration != null)
            {
                 s += ind + "retentionDuration\n";

                 s += ind + "{\n" + 
                 this.RetentionDuration.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> TargetMapping? TargetMapping
            // GraphQL -> targetMapping: TargetMapping (type)
            if (this.TargetMapping != null)
            {
                 s += ind + "targetMapping\n";

                 s += ind + "{\n" + 
                 this.TargetMapping.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AwsRegion
            // GraphQL -> awsRegion: String! (scalar)
            if (this.AwsRegion == null && Exploration.Includes(parent + ".awsRegion$"))
            {
                this.AwsRegion = new System.String("FETCH");
            }
            //      C# -> System.String? AzureRegion
            // GraphQL -> azureRegion: String! (scalar)
            if (this.AzureRegion == null && Exploration.Includes(parent + ".azureRegion$"))
            {
                this.AzureRegion = new System.String("FETCH");
            }
            //      C# -> AwsReplicationTarget? AwsTarget
            // GraphQL -> awsTarget: AwsReplicationTarget! (type)
            if (this.AwsTarget == null && Exploration.Includes(parent + ".awsTarget"))
            {
                this.AwsTarget = new AwsReplicationTarget();
                this.AwsTarget.ApplyExploratoryFragment(parent + ".awsTarget");
            }
            //      C# -> AzureReplicationTarget? AzureTarget
            // GraphQL -> azureTarget: AzureReplicationTarget! (type)
            if (this.AzureTarget == null && Exploration.Includes(parent + ".azureTarget"))
            {
                this.AzureTarget = new AzureReplicationTarget();
                this.AzureTarget.ApplyExploratoryFragment(parent + ".azureTarget");
            }
            //      C# -> List<CascadingArchivalSpec>? CascadingArchivalSpecs
            // GraphQL -> cascadingArchivalSpecs: [CascadingArchivalSpec!]! (type)
            if (this.CascadingArchivalSpecs == null && Exploration.Includes(parent + ".cascadingArchivalSpecs"))
            {
                this.CascadingArchivalSpecs = new List<CascadingArchivalSpec>();
                this.CascadingArchivalSpecs.ApplyExploratoryFragment(parent + ".cascadingArchivalSpecs");
            }
            //      C# -> SlaReplicationCluster? Cluster
            // GraphQL -> cluster: SlaReplicationCluster (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new SlaReplicationCluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> Duration? ReplicationLocalRetentionDuration
            // GraphQL -> replicationLocalRetentionDuration: Duration (type)
            if (this.ReplicationLocalRetentionDuration == null && Exploration.Includes(parent + ".replicationLocalRetentionDuration"))
            {
                this.ReplicationLocalRetentionDuration = new Duration();
                this.ReplicationLocalRetentionDuration.ApplyExploratoryFragment(parent + ".replicationLocalRetentionDuration");
            }
            //      C# -> Duration? RetentionDuration
            // GraphQL -> retentionDuration: Duration (type)
            if (this.RetentionDuration == null && Exploration.Includes(parent + ".retentionDuration"))
            {
                this.RetentionDuration = new Duration();
                this.RetentionDuration.ApplyExploratoryFragment(parent + ".retentionDuration");
            }
            //      C# -> TargetMapping? TargetMapping
            // GraphQL -> targetMapping: TargetMapping (type)
            if (this.TargetMapping == null && Exploration.Includes(parent + ".targetMapping"))
            {
                this.TargetMapping = new TargetMapping();
                this.TargetMapping.ApplyExploratoryFragment(parent + ".targetMapping");
            }
        }


    #endregion

    } // class ReplicationSpecV2
    #endregion

    public static class ListReplicationSpecV2Extensions
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
            this List<ReplicationSpecV2> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ReplicationSpecV2> list, 
            String parent = "")
        {
            var item = new ReplicationSpecV2();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types