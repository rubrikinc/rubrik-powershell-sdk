// ReplicationSpecV2.cs
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
    #region ReplicationSpecV2
    public class ReplicationSpecV2: BaseType
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

    public override string GetGqlTypeName() {
        return "ReplicationSpecV2";
    }

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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? AwsRegion
        // GraphQL -> awsRegion: String! (scalar)
        if (this.AwsRegion != null) {
            s += ind + "awsRegion\n" ;
        }
        //      C# -> System.String? AzureRegion
        // GraphQL -> azureRegion: String! (scalar)
        if (this.AzureRegion != null) {
            s += ind + "azureRegion\n" ;
        }
        //      C# -> AwsReplicationTarget? AwsTarget
        // GraphQL -> awsTarget: AwsReplicationTarget! (type)
        if (this.AwsTarget != null) {
            var fspec = this.AwsTarget.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "awsTarget {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AzureReplicationTarget? AzureTarget
        // GraphQL -> azureTarget: AzureReplicationTarget! (type)
        if (this.AzureTarget != null) {
            var fspec = this.AzureTarget.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "azureTarget {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<CascadingArchivalSpec>? CascadingArchivalSpecs
        // GraphQL -> cascadingArchivalSpecs: [CascadingArchivalSpec!]! (type)
        if (this.CascadingArchivalSpecs != null) {
            var fspec = this.CascadingArchivalSpecs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cascadingArchivalSpecs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SlaReplicationCluster? Cluster
        // GraphQL -> cluster: SlaReplicationCluster (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Duration? ReplicationLocalRetentionDuration
        // GraphQL -> replicationLocalRetentionDuration: Duration (type)
        if (this.ReplicationLocalRetentionDuration != null) {
            var fspec = this.ReplicationLocalRetentionDuration.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "replicationLocalRetentionDuration {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Duration? RetentionDuration
        // GraphQL -> retentionDuration: Duration (type)
        if (this.RetentionDuration != null) {
            var fspec = this.RetentionDuration.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "retentionDuration {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> TargetMapping? TargetMapping
        // GraphQL -> targetMapping: TargetMapping (type)
        if (this.TargetMapping != null) {
            var fspec = this.TargetMapping.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "targetMapping {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AwsRegion
        // GraphQL -> awsRegion: String! (scalar)
        if (this.AwsRegion == null && ec.Includes("awsRegion",true))
        {
            this.AwsRegion = "FETCH";
        }
        //      C# -> System.String? AzureRegion
        // GraphQL -> azureRegion: String! (scalar)
        if (this.AzureRegion == null && ec.Includes("azureRegion",true))
        {
            this.AzureRegion = "FETCH";
        }
        //      C# -> AwsReplicationTarget? AwsTarget
        // GraphQL -> awsTarget: AwsReplicationTarget! (type)
        if (this.AwsTarget == null && ec.Includes("awsTarget",false))
        {
            this.AwsTarget = new AwsReplicationTarget();
            this.AwsTarget.ApplyExploratoryFieldSpec(ec.NewChild("awsTarget"));
        }
        //      C# -> AzureReplicationTarget? AzureTarget
        // GraphQL -> azureTarget: AzureReplicationTarget! (type)
        if (this.AzureTarget == null && ec.Includes("azureTarget",false))
        {
            this.AzureTarget = new AzureReplicationTarget();
            this.AzureTarget.ApplyExploratoryFieldSpec(ec.NewChild("azureTarget"));
        }
        //      C# -> List<CascadingArchivalSpec>? CascadingArchivalSpecs
        // GraphQL -> cascadingArchivalSpecs: [CascadingArchivalSpec!]! (type)
        if (this.CascadingArchivalSpecs == null && ec.Includes("cascadingArchivalSpecs",false))
        {
            this.CascadingArchivalSpecs = new List<CascadingArchivalSpec>();
            this.CascadingArchivalSpecs.ApplyExploratoryFieldSpec(ec.NewChild("cascadingArchivalSpecs"));
        }
        //      C# -> SlaReplicationCluster? Cluster
        // GraphQL -> cluster: SlaReplicationCluster (type)
        if (this.Cluster == null && ec.Includes("cluster",false))
        {
            this.Cluster = new SlaReplicationCluster();
            this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));
        }
        //      C# -> Duration? ReplicationLocalRetentionDuration
        // GraphQL -> replicationLocalRetentionDuration: Duration (type)
        if (this.ReplicationLocalRetentionDuration == null && ec.Includes("replicationLocalRetentionDuration",false))
        {
            this.ReplicationLocalRetentionDuration = new Duration();
            this.ReplicationLocalRetentionDuration.ApplyExploratoryFieldSpec(ec.NewChild("replicationLocalRetentionDuration"));
        }
        //      C# -> Duration? RetentionDuration
        // GraphQL -> retentionDuration: Duration (type)
        if (this.RetentionDuration == null && ec.Includes("retentionDuration",false))
        {
            this.RetentionDuration = new Duration();
            this.RetentionDuration.ApplyExploratoryFieldSpec(ec.NewChild("retentionDuration"));
        }
        //      C# -> TargetMapping? TargetMapping
        // GraphQL -> targetMapping: TargetMapping (type)
        if (this.TargetMapping == null && ec.Includes("targetMapping",false))
        {
            this.TargetMapping = new TargetMapping();
            this.TargetMapping.ApplyExploratoryFieldSpec(ec.NewChild("targetMapping"));
        }
    }


    #endregion

    } // class ReplicationSpecV2
    
    #endregion

    public static class ListReplicationSpecV2Extensions
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
            this List<ReplicationSpecV2> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReplicationSpecV2> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReplicationSpecV2());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ReplicationSpecV2> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types