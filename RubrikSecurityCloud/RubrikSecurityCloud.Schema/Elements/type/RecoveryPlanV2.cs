// RecoveryPlanV2.cs
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
    #region RecoveryPlanV2
    public class RecoveryPlanV2: BaseType
    {
        #region members

        //      C# -> RecoveryPlanStatus? RecoveryPlanStatus
        // GraphQL -> recoveryPlanStatus: RecoveryPlanStatus! (enum)
        [JsonProperty("recoveryPlanStatus")]
        public RecoveryPlanStatus? RecoveryPlanStatus { get; set; }

        //      C# -> RecoveryPlanType? RecoveryPlanType
        // GraphQL -> recoveryPlanType: RecoveryPlanType! (enum)
        [JsonProperty("recoveryPlanType")]
        public RecoveryPlanType? RecoveryPlanType { get; set; }

        //      C# -> ManagedObjectType? WorkloadType
        // GraphQL -> workloadType: ManagedObjectType! (enum)
        [JsonProperty("workloadType")]
        public ManagedObjectType? WorkloadType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsHidden
        // GraphQL -> isHidden: Boolean! (scalar)
        [JsonProperty("isHidden")]
        public System.Boolean? IsHidden { get; set; }

        //      C# -> System.Boolean? IsHydrationEnabled
        // GraphQL -> isHydrationEnabled: Boolean! (scalar)
        [JsonProperty("isHydrationEnabled")]
        public System.Boolean? IsHydrationEnabled { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        [JsonProperty("version")]
        public System.Int64? Version { get; set; }

        //      C# -> List<RecoveryPlanChildV2>? Children
        // GraphQL -> children: [RecoveryPlanChildV2!]! (type)
        [JsonProperty("children")]
        public List<RecoveryPlanChildV2>? Children { get; set; }

        //      C# -> Recovery? LatestRecovery
        // GraphQL -> latestRecovery: Recovery (type)
        [JsonProperty("latestRecovery")]
        public Recovery? LatestRecovery { get; set; }

        //      C# -> RpoLagInfoV2? LocalRpoLagInfo
        // GraphQL -> localRpoLagInfo: RpoLagInfoV2 (type)
        [JsonProperty("localRpoLagInfo")]
        public RpoLagInfoV2? LocalRpoLagInfo { get; set; }

        //      C# -> RecoveryPlanStats? RecoveryPlanStats
        // GraphQL -> recoveryPlanStats: RecoveryPlanStats (type)
        [JsonProperty("recoveryPlanStats")]
        public RecoveryPlanStats? RecoveryPlanStats { get; set; }

        //      C# -> RecoverySchedule? RecoverySchedule
        // GraphQL -> recoverySchedule: RecoverySchedule (type)
        [JsonProperty("recoverySchedule")]
        public RecoverySchedule? RecoverySchedule { get; set; }

        //      C# -> RecoverySpecsReply? RecoverySpecs
        // GraphQL -> recoverySpecs: RecoverySpecsReply (type)
        [JsonProperty("recoverySpecs")]
        public RecoverySpecsReply? RecoverySpecs { get; set; }

        //      C# -> RpoLagInfoV2? RemoteRpoLagInfo
        // GraphQL -> remoteRpoLagInfo: RpoLagInfoV2 (type)
        [JsonProperty("remoteRpoLagInfo")]
        public RpoLagInfoV2? RemoteRpoLagInfo { get; set; }

        //      C# -> RecoveryPlanLocation? SourceLocation
        // GraphQL -> sourceLocation: RecoveryPlanLocation (type)
        [JsonProperty("sourceLocation")]
        public RecoveryPlanLocation? SourceLocation { get; set; }

        //      C# -> RecoveryPlanTargetConsistencyInfo? TargetConsistencyInfo
        // GraphQL -> targetConsistencyInfo: RecoveryPlanTargetConsistencyInfo (type)
        [JsonProperty("targetConsistencyInfo")]
        public RecoveryPlanTargetConsistencyInfo? TargetConsistencyInfo { get; set; }

        //      C# -> RecoveryPlanLocation? TargetLocation
        // GraphQL -> targetLocation: RecoveryPlanLocation (type)
        [JsonProperty("targetLocation")]
        public RecoveryPlanLocation? TargetLocation { get; set; }

        //      C# -> List<WorkloadLastRecovery>? WorkloadsLastRecovery
        // GraphQL -> workloadsLastRecovery: [WorkloadLastRecovery!] (type)
        [JsonProperty("workloadsLastRecovery")]
        public List<WorkloadLastRecovery>? WorkloadsLastRecovery { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecoveryPlanV2";
    }

    public RecoveryPlanV2 Set(
        RecoveryPlanStatus? RecoveryPlanStatus = null,
        RecoveryPlanType? RecoveryPlanType = null,
        ManagedObjectType? WorkloadType = null,
        System.String? Id = null,
        System.Boolean? IsHidden = null,
        System.Boolean? IsHydrationEnabled = null,
        System.String? Name = null,
        System.Int64? Version = null,
        List<RecoveryPlanChildV2>? Children = null,
        Recovery? LatestRecovery = null,
        RpoLagInfoV2? LocalRpoLagInfo = null,
        RecoveryPlanStats? RecoveryPlanStats = null,
        RecoverySchedule? RecoverySchedule = null,
        RecoverySpecsReply? RecoverySpecs = null,
        RpoLagInfoV2? RemoteRpoLagInfo = null,
        RecoveryPlanLocation? SourceLocation = null,
        RecoveryPlanTargetConsistencyInfo? TargetConsistencyInfo = null,
        RecoveryPlanLocation? TargetLocation = null,
        List<WorkloadLastRecovery>? WorkloadsLastRecovery = null
    ) 
    {
        if ( RecoveryPlanStatus != null ) {
            this.RecoveryPlanStatus = RecoveryPlanStatus;
        }
        if ( RecoveryPlanType != null ) {
            this.RecoveryPlanType = RecoveryPlanType;
        }
        if ( WorkloadType != null ) {
            this.WorkloadType = WorkloadType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsHidden != null ) {
            this.IsHidden = IsHidden;
        }
        if ( IsHydrationEnabled != null ) {
            this.IsHydrationEnabled = IsHydrationEnabled;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( Children != null ) {
            this.Children = Children;
        }
        if ( LatestRecovery != null ) {
            this.LatestRecovery = LatestRecovery;
        }
        if ( LocalRpoLagInfo != null ) {
            this.LocalRpoLagInfo = LocalRpoLagInfo;
        }
        if ( RecoveryPlanStats != null ) {
            this.RecoveryPlanStats = RecoveryPlanStats;
        }
        if ( RecoverySchedule != null ) {
            this.RecoverySchedule = RecoverySchedule;
        }
        if ( RecoverySpecs != null ) {
            this.RecoverySpecs = RecoverySpecs;
        }
        if ( RemoteRpoLagInfo != null ) {
            this.RemoteRpoLagInfo = RemoteRpoLagInfo;
        }
        if ( SourceLocation != null ) {
            this.SourceLocation = SourceLocation;
        }
        if ( TargetConsistencyInfo != null ) {
            this.TargetConsistencyInfo = TargetConsistencyInfo;
        }
        if ( TargetLocation != null ) {
            this.TargetLocation = TargetLocation;
        }
        if ( WorkloadsLastRecovery != null ) {
            this.WorkloadsLastRecovery = WorkloadsLastRecovery;
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
        //      C# -> RecoveryPlanStatus? RecoveryPlanStatus
        // GraphQL -> recoveryPlanStatus: RecoveryPlanStatus! (enum)
        if (this.RecoveryPlanStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPlanStatus\n" ;
            } else {
                s += ind + "recoveryPlanStatus\n" ;
            }
        }
        //      C# -> RecoveryPlanType? RecoveryPlanType
        // GraphQL -> recoveryPlanType: RecoveryPlanType! (enum)
        if (this.RecoveryPlanType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPlanType\n" ;
            } else {
                s += ind + "recoveryPlanType\n" ;
            }
        }
        //      C# -> ManagedObjectType? WorkloadType
        // GraphQL -> workloadType: ManagedObjectType! (enum)
        if (this.WorkloadType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadType\n" ;
            } else {
                s += ind + "workloadType\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsHidden
        // GraphQL -> isHidden: Boolean! (scalar)
        if (this.IsHidden != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isHidden\n" ;
            } else {
                s += ind + "isHidden\n" ;
            }
        }
        //      C# -> System.Boolean? IsHydrationEnabled
        // GraphQL -> isHydrationEnabled: Boolean! (scalar)
        if (this.IsHydrationEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isHydrationEnabled\n" ;
            } else {
                s += ind + "isHydrationEnabled\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> List<RecoveryPlanChildV2>? Children
        // GraphQL -> children: [RecoveryPlanChildV2!]! (type)
        if (this.Children != null) {
            var fspec = this.Children.AsFieldSpec(conf.Child("children"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "children" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Recovery? LatestRecovery
        // GraphQL -> latestRecovery: Recovery (type)
        if (this.LatestRecovery != null) {
            var fspec = this.LatestRecovery.AsFieldSpec(conf.Child("latestRecovery"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "latestRecovery" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RpoLagInfoV2? LocalRpoLagInfo
        // GraphQL -> localRpoLagInfo: RpoLagInfoV2 (type)
        if (this.LocalRpoLagInfo != null) {
            var fspec = this.LocalRpoLagInfo.AsFieldSpec(conf.Child("localRpoLagInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "localRpoLagInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RecoveryPlanStats? RecoveryPlanStats
        // GraphQL -> recoveryPlanStats: RecoveryPlanStats (type)
        if (this.RecoveryPlanStats != null) {
            var fspec = this.RecoveryPlanStats.AsFieldSpec(conf.Child("recoveryPlanStats"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoveryPlanStats" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RecoverySchedule? RecoverySchedule
        // GraphQL -> recoverySchedule: RecoverySchedule (type)
        if (this.RecoverySchedule != null) {
            var fspec = this.RecoverySchedule.AsFieldSpec(conf.Child("recoverySchedule"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoverySchedule" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RecoverySpecsReply? RecoverySpecs
        // GraphQL -> recoverySpecs: RecoverySpecsReply (type)
        if (this.RecoverySpecs != null) {
            var fspec = this.RecoverySpecs.AsFieldSpec(conf.Child("recoverySpecs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoverySpecs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RpoLagInfoV2? RemoteRpoLagInfo
        // GraphQL -> remoteRpoLagInfo: RpoLagInfoV2 (type)
        if (this.RemoteRpoLagInfo != null) {
            var fspec = this.RemoteRpoLagInfo.AsFieldSpec(conf.Child("remoteRpoLagInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "remoteRpoLagInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RecoveryPlanLocation? SourceLocation
        // GraphQL -> sourceLocation: RecoveryPlanLocation (type)
        if (this.SourceLocation != null) {
            var fspec = this.SourceLocation.AsFieldSpec(conf.Child("sourceLocation"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceLocation" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RecoveryPlanTargetConsistencyInfo? TargetConsistencyInfo
        // GraphQL -> targetConsistencyInfo: RecoveryPlanTargetConsistencyInfo (type)
        if (this.TargetConsistencyInfo != null) {
            var fspec = this.TargetConsistencyInfo.AsFieldSpec(conf.Child("targetConsistencyInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetConsistencyInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RecoveryPlanLocation? TargetLocation
        // GraphQL -> targetLocation: RecoveryPlanLocation (type)
        if (this.TargetLocation != null) {
            var fspec = this.TargetLocation.AsFieldSpec(conf.Child("targetLocation"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetLocation" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<WorkloadLastRecovery>? WorkloadsLastRecovery
        // GraphQL -> workloadsLastRecovery: [WorkloadLastRecovery!] (type)
        if (this.WorkloadsLastRecovery != null) {
            var fspec = this.WorkloadsLastRecovery.AsFieldSpec(conf.Child("workloadsLastRecovery"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "workloadsLastRecovery" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RecoveryPlanStatus? RecoveryPlanStatus
        // GraphQL -> recoveryPlanStatus: RecoveryPlanStatus! (enum)
        if (ec.Includes("recoveryPlanStatus",true))
        {
            if(this.RecoveryPlanStatus == null) {

                this.RecoveryPlanStatus = new RecoveryPlanStatus();

            } else {


            }
        }
        else if (this.RecoveryPlanStatus != null && ec.Excludes("recoveryPlanStatus",true))
        {
            this.RecoveryPlanStatus = null;
        }
        //      C# -> RecoveryPlanType? RecoveryPlanType
        // GraphQL -> recoveryPlanType: RecoveryPlanType! (enum)
        if (ec.Includes("recoveryPlanType",true))
        {
            if(this.RecoveryPlanType == null) {

                this.RecoveryPlanType = new RecoveryPlanType();

            } else {


            }
        }
        else if (this.RecoveryPlanType != null && ec.Excludes("recoveryPlanType",true))
        {
            this.RecoveryPlanType = null;
        }
        //      C# -> ManagedObjectType? WorkloadType
        // GraphQL -> workloadType: ManagedObjectType! (enum)
        if (ec.Includes("workloadType",true))
        {
            if(this.WorkloadType == null) {

                this.WorkloadType = new ManagedObjectType();

            } else {


            }
        }
        else if (this.WorkloadType != null && ec.Excludes("workloadType",true))
        {
            this.WorkloadType = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsHidden
        // GraphQL -> isHidden: Boolean! (scalar)
        if (ec.Includes("isHidden",true))
        {
            if(this.IsHidden == null) {

                this.IsHidden = true;

            } else {


            }
        }
        else if (this.IsHidden != null && ec.Excludes("isHidden",true))
        {
            this.IsHidden = null;
        }
        //      C# -> System.Boolean? IsHydrationEnabled
        // GraphQL -> isHydrationEnabled: Boolean! (scalar)
        if (ec.Includes("isHydrationEnabled",true))
        {
            if(this.IsHydrationEnabled == null) {

                this.IsHydrationEnabled = true;

            } else {


            }
        }
        else if (this.IsHydrationEnabled != null && ec.Excludes("isHydrationEnabled",true))
        {
            this.IsHydrationEnabled = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = new System.Int64();

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> List<RecoveryPlanChildV2>? Children
        // GraphQL -> children: [RecoveryPlanChildV2!]! (type)
        if (ec.Includes("children",false))
        {
            if(this.Children == null) {

                this.Children = new List<RecoveryPlanChildV2>();
                this.Children.ApplyExploratoryFieldSpec(ec.NewChild("children"));

            } else {

                this.Children.ApplyExploratoryFieldSpec(ec.NewChild("children"));

            }
        }
        else if (this.Children != null && ec.Excludes("children",false))
        {
            this.Children = null;
        }
        //      C# -> Recovery? LatestRecovery
        // GraphQL -> latestRecovery: Recovery (type)
        if (ec.Includes("latestRecovery",false))
        {
            if(this.LatestRecovery == null) {

                this.LatestRecovery = new Recovery();
                this.LatestRecovery.ApplyExploratoryFieldSpec(ec.NewChild("latestRecovery"));

            } else {

                this.LatestRecovery.ApplyExploratoryFieldSpec(ec.NewChild("latestRecovery"));

            }
        }
        else if (this.LatestRecovery != null && ec.Excludes("latestRecovery",false))
        {
            this.LatestRecovery = null;
        }
        //      C# -> RpoLagInfoV2? LocalRpoLagInfo
        // GraphQL -> localRpoLagInfo: RpoLagInfoV2 (type)
        if (ec.Includes("localRpoLagInfo",false))
        {
            if(this.LocalRpoLagInfo == null) {

                this.LocalRpoLagInfo = new RpoLagInfoV2();
                this.LocalRpoLagInfo.ApplyExploratoryFieldSpec(ec.NewChild("localRpoLagInfo"));

            } else {

                this.LocalRpoLagInfo.ApplyExploratoryFieldSpec(ec.NewChild("localRpoLagInfo"));

            }
        }
        else if (this.LocalRpoLagInfo != null && ec.Excludes("localRpoLagInfo",false))
        {
            this.LocalRpoLagInfo = null;
        }
        //      C# -> RecoveryPlanStats? RecoveryPlanStats
        // GraphQL -> recoveryPlanStats: RecoveryPlanStats (type)
        if (ec.Includes("recoveryPlanStats",false))
        {
            if(this.RecoveryPlanStats == null) {

                this.RecoveryPlanStats = new RecoveryPlanStats();
                this.RecoveryPlanStats.ApplyExploratoryFieldSpec(ec.NewChild("recoveryPlanStats"));

            } else {

                this.RecoveryPlanStats.ApplyExploratoryFieldSpec(ec.NewChild("recoveryPlanStats"));

            }
        }
        else if (this.RecoveryPlanStats != null && ec.Excludes("recoveryPlanStats",false))
        {
            this.RecoveryPlanStats = null;
        }
        //      C# -> RecoverySchedule? RecoverySchedule
        // GraphQL -> recoverySchedule: RecoverySchedule (type)
        if (ec.Includes("recoverySchedule",false))
        {
            if(this.RecoverySchedule == null) {

                this.RecoverySchedule = new RecoverySchedule();
                this.RecoverySchedule.ApplyExploratoryFieldSpec(ec.NewChild("recoverySchedule"));

            } else {

                this.RecoverySchedule.ApplyExploratoryFieldSpec(ec.NewChild("recoverySchedule"));

            }
        }
        else if (this.RecoverySchedule != null && ec.Excludes("recoverySchedule",false))
        {
            this.RecoverySchedule = null;
        }
        //      C# -> RecoverySpecsReply? RecoverySpecs
        // GraphQL -> recoverySpecs: RecoverySpecsReply (type)
        if (ec.Includes("recoverySpecs",false))
        {
            if(this.RecoverySpecs == null) {

                this.RecoverySpecs = new RecoverySpecsReply();
                this.RecoverySpecs.ApplyExploratoryFieldSpec(ec.NewChild("recoverySpecs"));

            } else {

                this.RecoverySpecs.ApplyExploratoryFieldSpec(ec.NewChild("recoverySpecs"));

            }
        }
        else if (this.RecoverySpecs != null && ec.Excludes("recoverySpecs",false))
        {
            this.RecoverySpecs = null;
        }
        //      C# -> RpoLagInfoV2? RemoteRpoLagInfo
        // GraphQL -> remoteRpoLagInfo: RpoLagInfoV2 (type)
        if (ec.Includes("remoteRpoLagInfo",false))
        {
            if(this.RemoteRpoLagInfo == null) {

                this.RemoteRpoLagInfo = new RpoLagInfoV2();
                this.RemoteRpoLagInfo.ApplyExploratoryFieldSpec(ec.NewChild("remoteRpoLagInfo"));

            } else {

                this.RemoteRpoLagInfo.ApplyExploratoryFieldSpec(ec.NewChild("remoteRpoLagInfo"));

            }
        }
        else if (this.RemoteRpoLagInfo != null && ec.Excludes("remoteRpoLagInfo",false))
        {
            this.RemoteRpoLagInfo = null;
        }
        //      C# -> RecoveryPlanLocation? SourceLocation
        // GraphQL -> sourceLocation: RecoveryPlanLocation (type)
        if (ec.Includes("sourceLocation",false))
        {
            if(this.SourceLocation == null) {

                this.SourceLocation = new RecoveryPlanLocation();
                this.SourceLocation.ApplyExploratoryFieldSpec(ec.NewChild("sourceLocation"));

            } else {

                this.SourceLocation.ApplyExploratoryFieldSpec(ec.NewChild("sourceLocation"));

            }
        }
        else if (this.SourceLocation != null && ec.Excludes("sourceLocation",false))
        {
            this.SourceLocation = null;
        }
        //      C# -> RecoveryPlanTargetConsistencyInfo? TargetConsistencyInfo
        // GraphQL -> targetConsistencyInfo: RecoveryPlanTargetConsistencyInfo (type)
        if (ec.Includes("targetConsistencyInfo",false))
        {
            if(this.TargetConsistencyInfo == null) {

                this.TargetConsistencyInfo = new RecoveryPlanTargetConsistencyInfo();
                this.TargetConsistencyInfo.ApplyExploratoryFieldSpec(ec.NewChild("targetConsistencyInfo"));

            } else {

                this.TargetConsistencyInfo.ApplyExploratoryFieldSpec(ec.NewChild("targetConsistencyInfo"));

            }
        }
        else if (this.TargetConsistencyInfo != null && ec.Excludes("targetConsistencyInfo",false))
        {
            this.TargetConsistencyInfo = null;
        }
        //      C# -> RecoveryPlanLocation? TargetLocation
        // GraphQL -> targetLocation: RecoveryPlanLocation (type)
        if (ec.Includes("targetLocation",false))
        {
            if(this.TargetLocation == null) {

                this.TargetLocation = new RecoveryPlanLocation();
                this.TargetLocation.ApplyExploratoryFieldSpec(ec.NewChild("targetLocation"));

            } else {

                this.TargetLocation.ApplyExploratoryFieldSpec(ec.NewChild("targetLocation"));

            }
        }
        else if (this.TargetLocation != null && ec.Excludes("targetLocation",false))
        {
            this.TargetLocation = null;
        }
        //      C# -> List<WorkloadLastRecovery>? WorkloadsLastRecovery
        // GraphQL -> workloadsLastRecovery: [WorkloadLastRecovery!] (type)
        if (ec.Includes("workloadsLastRecovery",false))
        {
            if(this.WorkloadsLastRecovery == null) {

                this.WorkloadsLastRecovery = new List<WorkloadLastRecovery>();
                this.WorkloadsLastRecovery.ApplyExploratoryFieldSpec(ec.NewChild("workloadsLastRecovery"));

            } else {

                this.WorkloadsLastRecovery.ApplyExploratoryFieldSpec(ec.NewChild("workloadsLastRecovery"));

            }
        }
        else if (this.WorkloadsLastRecovery != null && ec.Excludes("workloadsLastRecovery",false))
        {
            this.WorkloadsLastRecovery = null;
        }
    }


    #endregion

    } // class RecoveryPlanV2
    
    #endregion

    public static class ListRecoveryPlanV2Extensions
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
            this List<RecoveryPlanV2> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RecoveryPlanV2> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryPlanV2> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryPlanV2());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RecoveryPlanV2> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types