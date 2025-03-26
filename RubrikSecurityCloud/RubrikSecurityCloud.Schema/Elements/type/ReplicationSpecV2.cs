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

        //      C# -> List<SlaReplicationPair>? ReplicationPairs
        // GraphQL -> replicationPairs: [SlaReplicationPair!] (type)
        [JsonProperty("replicationPairs")]
        public List<SlaReplicationPair>? ReplicationPairs { get; set; }

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
        List<SlaReplicationPair>? ReplicationPairs = null,
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
        if ( ReplicationPairs != null ) {
            this.ReplicationPairs = ReplicationPairs;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? AwsRegion
        // GraphQL -> awsRegion: String! (scalar)
        if (this.AwsRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awsRegion\n" ;
            } else {
                s += ind + "awsRegion\n" ;
            }
        }
        //      C# -> System.String? AzureRegion
        // GraphQL -> azureRegion: String! (scalar)
        if (this.AzureRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureRegion\n" ;
            } else {
                s += ind + "azureRegion\n" ;
            }
        }
        //      C# -> AwsReplicationTarget? AwsTarget
        // GraphQL -> awsTarget: AwsReplicationTarget! (type)
        if (this.AwsTarget != null) {
            var fspec = this.AwsTarget.AsFieldSpec(conf.Child("awsTarget"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsTarget" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureReplicationTarget? AzureTarget
        // GraphQL -> azureTarget: AzureReplicationTarget! (type)
        if (this.AzureTarget != null) {
            var fspec = this.AzureTarget.AsFieldSpec(conf.Child("azureTarget"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureTarget" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<CascadingArchivalSpec>? CascadingArchivalSpecs
        // GraphQL -> cascadingArchivalSpecs: [CascadingArchivalSpec!]! (type)
        if (this.CascadingArchivalSpecs != null) {
            var fspec = this.CascadingArchivalSpecs.AsFieldSpec(conf.Child("cascadingArchivalSpecs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cascadingArchivalSpecs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SlaReplicationCluster? Cluster
        // GraphQL -> cluster: SlaReplicationCluster (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Duration? ReplicationLocalRetentionDuration
        // GraphQL -> replicationLocalRetentionDuration: Duration (type)
        if (this.ReplicationLocalRetentionDuration != null) {
            var fspec = this.ReplicationLocalRetentionDuration.AsFieldSpec(conf.Child("replicationLocalRetentionDuration"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "replicationLocalRetentionDuration" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<SlaReplicationPair>? ReplicationPairs
        // GraphQL -> replicationPairs: [SlaReplicationPair!] (type)
        if (this.ReplicationPairs != null) {
            var fspec = this.ReplicationPairs.AsFieldSpec(conf.Child("replicationPairs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "replicationPairs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Duration? RetentionDuration
        // GraphQL -> retentionDuration: Duration (type)
        if (this.RetentionDuration != null) {
            var fspec = this.RetentionDuration.AsFieldSpec(conf.Child("retentionDuration"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "retentionDuration" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> TargetMapping? TargetMapping
        // GraphQL -> targetMapping: TargetMapping (type)
        if (this.TargetMapping != null) {
            var fspec = this.TargetMapping.AsFieldSpec(conf.Child("targetMapping"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetMapping" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? AwsRegion
        // GraphQL -> awsRegion: String! (scalar)
        if (ec.Includes("awsRegion",true))
        {
            if(this.AwsRegion == null) {

                this.AwsRegion = "FETCH";

            } else {


            }
        }
        else if (this.AwsRegion != null && ec.Excludes("awsRegion",true))
        {
            this.AwsRegion = null;
        }
        //      C# -> System.String? AzureRegion
        // GraphQL -> azureRegion: String! (scalar)
        if (ec.Includes("azureRegion",true))
        {
            if(this.AzureRegion == null) {

                this.AzureRegion = "FETCH";

            } else {


            }
        }
        else if (this.AzureRegion != null && ec.Excludes("azureRegion",true))
        {
            this.AzureRegion = null;
        }
        //      C# -> AwsReplicationTarget? AwsTarget
        // GraphQL -> awsTarget: AwsReplicationTarget! (type)
        if (ec.Includes("awsTarget",false))
        {
            if(this.AwsTarget == null) {

                this.AwsTarget = new AwsReplicationTarget();
                this.AwsTarget.ApplyExploratoryFieldSpec(ec.NewChild("awsTarget"));

            } else {

                this.AwsTarget.ApplyExploratoryFieldSpec(ec.NewChild("awsTarget"));

            }
        }
        else if (this.AwsTarget != null && ec.Excludes("awsTarget",false))
        {
            this.AwsTarget = null;
        }
        //      C# -> AzureReplicationTarget? AzureTarget
        // GraphQL -> azureTarget: AzureReplicationTarget! (type)
        if (ec.Includes("azureTarget",false))
        {
            if(this.AzureTarget == null) {

                this.AzureTarget = new AzureReplicationTarget();
                this.AzureTarget.ApplyExploratoryFieldSpec(ec.NewChild("azureTarget"));

            } else {

                this.AzureTarget.ApplyExploratoryFieldSpec(ec.NewChild("azureTarget"));

            }
        }
        else if (this.AzureTarget != null && ec.Excludes("azureTarget",false))
        {
            this.AzureTarget = null;
        }
        //      C# -> List<CascadingArchivalSpec>? CascadingArchivalSpecs
        // GraphQL -> cascadingArchivalSpecs: [CascadingArchivalSpec!]! (type)
        if (ec.Includes("cascadingArchivalSpecs",false))
        {
            if(this.CascadingArchivalSpecs == null) {

                this.CascadingArchivalSpecs = new List<CascadingArchivalSpec>();
                this.CascadingArchivalSpecs.ApplyExploratoryFieldSpec(ec.NewChild("cascadingArchivalSpecs"));

            } else {

                this.CascadingArchivalSpecs.ApplyExploratoryFieldSpec(ec.NewChild("cascadingArchivalSpecs"));

            }
        }
        else if (this.CascadingArchivalSpecs != null && ec.Excludes("cascadingArchivalSpecs",false))
        {
            this.CascadingArchivalSpecs = null;
        }
        //      C# -> SlaReplicationCluster? Cluster
        // GraphQL -> cluster: SlaReplicationCluster (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new SlaReplicationCluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
        //      C# -> Duration? ReplicationLocalRetentionDuration
        // GraphQL -> replicationLocalRetentionDuration: Duration (type)
        if (ec.Includes("replicationLocalRetentionDuration",false))
        {
            if(this.ReplicationLocalRetentionDuration == null) {

                this.ReplicationLocalRetentionDuration = new Duration();
                this.ReplicationLocalRetentionDuration.ApplyExploratoryFieldSpec(ec.NewChild("replicationLocalRetentionDuration"));

            } else {

                this.ReplicationLocalRetentionDuration.ApplyExploratoryFieldSpec(ec.NewChild("replicationLocalRetentionDuration"));

            }
        }
        else if (this.ReplicationLocalRetentionDuration != null && ec.Excludes("replicationLocalRetentionDuration",false))
        {
            this.ReplicationLocalRetentionDuration = null;
        }
        //      C# -> List<SlaReplicationPair>? ReplicationPairs
        // GraphQL -> replicationPairs: [SlaReplicationPair!] (type)
        if (ec.Includes("replicationPairs",false))
        {
            if(this.ReplicationPairs == null) {

                this.ReplicationPairs = new List<SlaReplicationPair>();
                this.ReplicationPairs.ApplyExploratoryFieldSpec(ec.NewChild("replicationPairs"));

            } else {

                this.ReplicationPairs.ApplyExploratoryFieldSpec(ec.NewChild("replicationPairs"));

            }
        }
        else if (this.ReplicationPairs != null && ec.Excludes("replicationPairs",false))
        {
            this.ReplicationPairs = null;
        }
        //      C# -> Duration? RetentionDuration
        // GraphQL -> retentionDuration: Duration (type)
        if (ec.Includes("retentionDuration",false))
        {
            if(this.RetentionDuration == null) {

                this.RetentionDuration = new Duration();
                this.RetentionDuration.ApplyExploratoryFieldSpec(ec.NewChild("retentionDuration"));

            } else {

                this.RetentionDuration.ApplyExploratoryFieldSpec(ec.NewChild("retentionDuration"));

            }
        }
        else if (this.RetentionDuration != null && ec.Excludes("retentionDuration",false))
        {
            this.RetentionDuration = null;
        }
        //      C# -> TargetMapping? TargetMapping
        // GraphQL -> targetMapping: TargetMapping (type)
        if (ec.Includes("targetMapping",false))
        {
            if(this.TargetMapping == null) {

                this.TargetMapping = new TargetMapping();
                this.TargetMapping.ApplyExploratoryFieldSpec(ec.NewChild("targetMapping"));

            } else {

                this.TargetMapping.ApplyExploratoryFieldSpec(ec.NewChild("targetMapping"));

            }
        }
        else if (this.TargetMapping != null && ec.Excludes("targetMapping",false))
        {
            this.TargetMapping = null;
        }
    }


    #endregion

    } // class ReplicationSpecV2
    
    #endregion

    public static class ListReplicationSpecV2Extensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ReplicationSpecV2> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ReplicationSpecV2> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ReplicationSpecV2> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReplicationSpecV2());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ReplicationSpecV2> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types