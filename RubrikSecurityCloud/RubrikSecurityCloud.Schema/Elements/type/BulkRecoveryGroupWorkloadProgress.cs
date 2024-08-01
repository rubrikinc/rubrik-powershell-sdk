// BulkRecoveryGroupWorkloadProgress.cs
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
    #region BulkRecoveryGroupWorkloadProgress
    public class BulkRecoveryGroupWorkloadProgress: BaseType
    {
        #region members

        //      C# -> BulkRecoveryGroupWorkloadStatus? Status
        // GraphQL -> status: BulkRecoveryGroupWorkloadStatus! (enum)
        [JsonProperty("status")]
        public BulkRecoveryGroupWorkloadStatus? Status { get; set; }

        //      C# -> List<System.Single>? BytesThroughputQuantiles
        // GraphQL -> bytesThroughputQuantiles: [Float!]! (scalar)
        [JsonProperty("bytesThroughputQuantiles")]
        public List<System.Single>? BytesThroughputQuantiles { get; set; }

        //      C# -> System.Int32? CanceledWorkloads
        // GraphQL -> canceledWorkloads: Int (scalar)
        [JsonProperty("canceledWorkloads")]
        public System.Int32? CanceledWorkloads { get; set; }

        //      C# -> List<System.Single>? ChildRecoveryStartLatencyQuantiles
        // GraphQL -> childRecoveryStartLatencyQuantiles: [Float!]! (scalar)
        [JsonProperty("childRecoveryStartLatencyQuantiles")]
        public List<System.Single>? ChildRecoveryStartLatencyQuantiles { get; set; }

        //      C# -> List<System.Single>? ChildRecoveryTotalLatencyQuantiles
        // GraphQL -> childRecoveryTotalLatencyQuantiles: [Float!]! (scalar)
        [JsonProperty("childRecoveryTotalLatencyQuantiles")]
        public List<System.Single>? ChildRecoveryTotalLatencyQuantiles { get; set; }

        //      C# -> System.Int64? CreateTime
        // GraphQL -> createTime: Long (scalar)
        [JsonProperty("createTime")]
        public System.Int64? CreateTime { get; set; }

        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        [JsonProperty("elapsedTime")]
        public System.Int64? ElapsedTime { get; set; }

        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long (scalar)
        [JsonProperty("endTime")]
        public System.Int64? EndTime { get; set; }

        //      C# -> System.Int32? FailedWorkloads
        // GraphQL -> failedWorkloads: Int (scalar)
        [JsonProperty("failedWorkloads")]
        public System.Int32? FailedWorkloads { get; set; }

        //      C# -> System.Int32? InProgressWorkloads
        // GraphQL -> inProgressWorkloads: Int (scalar)
        [JsonProperty("inProgressWorkloads")]
        public System.Int32? InProgressWorkloads { get; set; }

        //      C# -> List<System.Single>? ItemsThroughputQuantiles
        // GraphQL -> itemsThroughputQuantiles: [Float!]! (scalar)
        [JsonProperty("itemsThroughputQuantiles")]
        public List<System.Single>? ItemsThroughputQuantiles { get; set; }

        //      C# -> System.Int32? Seq
        // GraphQL -> seq: Int! (scalar)
        [JsonProperty("seq")]
        public System.Int32? Seq { get; set; }

        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long (scalar)
        [JsonProperty("startTime")]
        public System.Int64? StartTime { get; set; }

        //      C# -> System.Int32? SucceededWorkloads
        // GraphQL -> succeededWorkloads: Int (scalar)
        [JsonProperty("succeededWorkloads")]
        public System.Int32? SucceededWorkloads { get; set; }

        //      C# -> System.Int32? TotalWorkloads
        // GraphQL -> totalWorkloads: Int (scalar)
        [JsonProperty("totalWorkloads")]
        public System.Int32? TotalWorkloads { get; set; }

        //      C# -> System.String? WorkloadType
        // GraphQL -> workloadType: String! (scalar)
        [JsonProperty("workloadType")]
        public System.String? WorkloadType { get; set; }

        //      C# -> System.Int32? WorkloadsWithoutSnapshot
        // GraphQL -> workloadsWithoutSnapshot: Int (scalar)
        [JsonProperty("workloadsWithoutSnapshot")]
        public System.Int32? WorkloadsWithoutSnapshot { get; set; }

        //      C# -> List<BulkRecoverySelectorStep>? SelectorSteps
        // GraphQL -> selectorSteps: [BulkRecoverySelectorStep!]! (type)
        [JsonProperty("selectorSteps")]
        public List<BulkRecoverySelectorStep>? SelectorSteps { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BulkRecoveryGroupWorkloadProgress";
    }

    public BulkRecoveryGroupWorkloadProgress Set(
        BulkRecoveryGroupWorkloadStatus? Status = null,
        List<System.Single>? BytesThroughputQuantiles = null,
        System.Int32? CanceledWorkloads = null,
        List<System.Single>? ChildRecoveryStartLatencyQuantiles = null,
        List<System.Single>? ChildRecoveryTotalLatencyQuantiles = null,
        System.Int64? CreateTime = null,
        System.Int64? ElapsedTime = null,
        System.Int64? EndTime = null,
        System.Int32? FailedWorkloads = null,
        System.Int32? InProgressWorkloads = null,
        List<System.Single>? ItemsThroughputQuantiles = null,
        System.Int32? Seq = null,
        System.Int64? StartTime = null,
        System.Int32? SucceededWorkloads = null,
        System.Int32? TotalWorkloads = null,
        System.String? WorkloadType = null,
        System.Int32? WorkloadsWithoutSnapshot = null,
        List<BulkRecoverySelectorStep>? SelectorSteps = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( BytesThroughputQuantiles != null ) {
            this.BytesThroughputQuantiles = BytesThroughputQuantiles;
        }
        if ( CanceledWorkloads != null ) {
            this.CanceledWorkloads = CanceledWorkloads;
        }
        if ( ChildRecoveryStartLatencyQuantiles != null ) {
            this.ChildRecoveryStartLatencyQuantiles = ChildRecoveryStartLatencyQuantiles;
        }
        if ( ChildRecoveryTotalLatencyQuantiles != null ) {
            this.ChildRecoveryTotalLatencyQuantiles = ChildRecoveryTotalLatencyQuantiles;
        }
        if ( CreateTime != null ) {
            this.CreateTime = CreateTime;
        }
        if ( ElapsedTime != null ) {
            this.ElapsedTime = ElapsedTime;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( FailedWorkloads != null ) {
            this.FailedWorkloads = FailedWorkloads;
        }
        if ( InProgressWorkloads != null ) {
            this.InProgressWorkloads = InProgressWorkloads;
        }
        if ( ItemsThroughputQuantiles != null ) {
            this.ItemsThroughputQuantiles = ItemsThroughputQuantiles;
        }
        if ( Seq != null ) {
            this.Seq = Seq;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( SucceededWorkloads != null ) {
            this.SucceededWorkloads = SucceededWorkloads;
        }
        if ( TotalWorkloads != null ) {
            this.TotalWorkloads = TotalWorkloads;
        }
        if ( WorkloadType != null ) {
            this.WorkloadType = WorkloadType;
        }
        if ( WorkloadsWithoutSnapshot != null ) {
            this.WorkloadsWithoutSnapshot = WorkloadsWithoutSnapshot;
        }
        if ( SelectorSteps != null ) {
            this.SelectorSteps = SelectorSteps;
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
        //      C# -> BulkRecoveryGroupWorkloadStatus? Status
        // GraphQL -> status: BulkRecoveryGroupWorkloadStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> List<System.Single>? BytesThroughputQuantiles
        // GraphQL -> bytesThroughputQuantiles: [Float!]! (scalar)
        if (this.BytesThroughputQuantiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bytesThroughputQuantiles\n" ;
            } else {
                s += ind + "bytesThroughputQuantiles\n" ;
            }
        }
        //      C# -> System.Int32? CanceledWorkloads
        // GraphQL -> canceledWorkloads: Int (scalar)
        if (this.CanceledWorkloads != null) {
            if (conf.Flat) {
                s += conf.Prefix + "canceledWorkloads\n" ;
            } else {
                s += ind + "canceledWorkloads\n" ;
            }
        }
        //      C# -> List<System.Single>? ChildRecoveryStartLatencyQuantiles
        // GraphQL -> childRecoveryStartLatencyQuantiles: [Float!]! (scalar)
        if (this.ChildRecoveryStartLatencyQuantiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "childRecoveryStartLatencyQuantiles\n" ;
            } else {
                s += ind + "childRecoveryStartLatencyQuantiles\n" ;
            }
        }
        //      C# -> List<System.Single>? ChildRecoveryTotalLatencyQuantiles
        // GraphQL -> childRecoveryTotalLatencyQuantiles: [Float!]! (scalar)
        if (this.ChildRecoveryTotalLatencyQuantiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "childRecoveryTotalLatencyQuantiles\n" ;
            } else {
                s += ind + "childRecoveryTotalLatencyQuantiles\n" ;
            }
        }
        //      C# -> System.Int64? CreateTime
        // GraphQL -> createTime: Long (scalar)
        if (this.CreateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createTime\n" ;
            } else {
                s += ind + "createTime\n" ;
            }
        }
        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        if (this.ElapsedTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "elapsedTime\n" ;
            } else {
                s += ind + "elapsedTime\n" ;
            }
        }
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        //      C# -> System.Int32? FailedWorkloads
        // GraphQL -> failedWorkloads: Int (scalar)
        if (this.FailedWorkloads != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failedWorkloads\n" ;
            } else {
                s += ind + "failedWorkloads\n" ;
            }
        }
        //      C# -> System.Int32? InProgressWorkloads
        // GraphQL -> inProgressWorkloads: Int (scalar)
        if (this.InProgressWorkloads != null) {
            if (conf.Flat) {
                s += conf.Prefix + "inProgressWorkloads\n" ;
            } else {
                s += ind + "inProgressWorkloads\n" ;
            }
        }
        //      C# -> List<System.Single>? ItemsThroughputQuantiles
        // GraphQL -> itemsThroughputQuantiles: [Float!]! (scalar)
        if (this.ItemsThroughputQuantiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "itemsThroughputQuantiles\n" ;
            } else {
                s += ind + "itemsThroughputQuantiles\n" ;
            }
        }
        //      C# -> System.Int32? Seq
        // GraphQL -> seq: Int! (scalar)
        if (this.Seq != null) {
            if (conf.Flat) {
                s += conf.Prefix + "seq\n" ;
            } else {
                s += ind + "seq\n" ;
            }
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        //      C# -> System.Int32? SucceededWorkloads
        // GraphQL -> succeededWorkloads: Int (scalar)
        if (this.SucceededWorkloads != null) {
            if (conf.Flat) {
                s += conf.Prefix + "succeededWorkloads\n" ;
            } else {
                s += ind + "succeededWorkloads\n" ;
            }
        }
        //      C# -> System.Int32? TotalWorkloads
        // GraphQL -> totalWorkloads: Int (scalar)
        if (this.TotalWorkloads != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalWorkloads\n" ;
            } else {
                s += ind + "totalWorkloads\n" ;
            }
        }
        //      C# -> System.String? WorkloadType
        // GraphQL -> workloadType: String! (scalar)
        if (this.WorkloadType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadType\n" ;
            } else {
                s += ind + "workloadType\n" ;
            }
        }
        //      C# -> System.Int32? WorkloadsWithoutSnapshot
        // GraphQL -> workloadsWithoutSnapshot: Int (scalar)
        if (this.WorkloadsWithoutSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadsWithoutSnapshot\n" ;
            } else {
                s += ind + "workloadsWithoutSnapshot\n" ;
            }
        }
        //      C# -> List<BulkRecoverySelectorStep>? SelectorSteps
        // GraphQL -> selectorSteps: [BulkRecoverySelectorStep!]! (type)
        if (this.SelectorSteps != null) {
            var fspec = this.SelectorSteps.AsFieldSpec(conf.Child("selectorSteps"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "selectorSteps" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> BulkRecoveryGroupWorkloadStatus? Status
        // GraphQL -> status: BulkRecoveryGroupWorkloadStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new BulkRecoveryGroupWorkloadStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> List<System.Single>? BytesThroughputQuantiles
        // GraphQL -> bytesThroughputQuantiles: [Float!]! (scalar)
        if (ec.Includes("bytesThroughputQuantiles",true))
        {
            if(this.BytesThroughputQuantiles == null) {

                this.BytesThroughputQuantiles = new List<System.Single>();

            } else {


            }
        }
        else if (this.BytesThroughputQuantiles != null && ec.Excludes("bytesThroughputQuantiles",true))
        {
            this.BytesThroughputQuantiles = null;
        }
        //      C# -> System.Int32? CanceledWorkloads
        // GraphQL -> canceledWorkloads: Int (scalar)
        if (ec.Includes("canceledWorkloads",true))
        {
            if(this.CanceledWorkloads == null) {

                this.CanceledWorkloads = Int32.MinValue;

            } else {


            }
        }
        else if (this.CanceledWorkloads != null && ec.Excludes("canceledWorkloads",true))
        {
            this.CanceledWorkloads = null;
        }
        //      C# -> List<System.Single>? ChildRecoveryStartLatencyQuantiles
        // GraphQL -> childRecoveryStartLatencyQuantiles: [Float!]! (scalar)
        if (ec.Includes("childRecoveryStartLatencyQuantiles",true))
        {
            if(this.ChildRecoveryStartLatencyQuantiles == null) {

                this.ChildRecoveryStartLatencyQuantiles = new List<System.Single>();

            } else {


            }
        }
        else if (this.ChildRecoveryStartLatencyQuantiles != null && ec.Excludes("childRecoveryStartLatencyQuantiles",true))
        {
            this.ChildRecoveryStartLatencyQuantiles = null;
        }
        //      C# -> List<System.Single>? ChildRecoveryTotalLatencyQuantiles
        // GraphQL -> childRecoveryTotalLatencyQuantiles: [Float!]! (scalar)
        if (ec.Includes("childRecoveryTotalLatencyQuantiles",true))
        {
            if(this.ChildRecoveryTotalLatencyQuantiles == null) {

                this.ChildRecoveryTotalLatencyQuantiles = new List<System.Single>();

            } else {


            }
        }
        else if (this.ChildRecoveryTotalLatencyQuantiles != null && ec.Excludes("childRecoveryTotalLatencyQuantiles",true))
        {
            this.ChildRecoveryTotalLatencyQuantiles = null;
        }
        //      C# -> System.Int64? CreateTime
        // GraphQL -> createTime: Long (scalar)
        if (ec.Includes("createTime",true))
        {
            if(this.CreateTime == null) {

                this.CreateTime = new System.Int64();

            } else {


            }
        }
        else if (this.CreateTime != null && ec.Excludes("createTime",true))
        {
            this.CreateTime = null;
        }
        //      C# -> System.Int64? ElapsedTime
        // GraphQL -> elapsedTime: Long! (scalar)
        if (ec.Includes("elapsedTime",true))
        {
            if(this.ElapsedTime == null) {

                this.ElapsedTime = new System.Int64();

            } else {


            }
        }
        else if (this.ElapsedTime != null && ec.Excludes("elapsedTime",true))
        {
            this.ElapsedTime = null;
        }
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = new System.Int64();

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
        }
        //      C# -> System.Int32? FailedWorkloads
        // GraphQL -> failedWorkloads: Int (scalar)
        if (ec.Includes("failedWorkloads",true))
        {
            if(this.FailedWorkloads == null) {

                this.FailedWorkloads = Int32.MinValue;

            } else {


            }
        }
        else if (this.FailedWorkloads != null && ec.Excludes("failedWorkloads",true))
        {
            this.FailedWorkloads = null;
        }
        //      C# -> System.Int32? InProgressWorkloads
        // GraphQL -> inProgressWorkloads: Int (scalar)
        if (ec.Includes("inProgressWorkloads",true))
        {
            if(this.InProgressWorkloads == null) {

                this.InProgressWorkloads = Int32.MinValue;

            } else {


            }
        }
        else if (this.InProgressWorkloads != null && ec.Excludes("inProgressWorkloads",true))
        {
            this.InProgressWorkloads = null;
        }
        //      C# -> List<System.Single>? ItemsThroughputQuantiles
        // GraphQL -> itemsThroughputQuantiles: [Float!]! (scalar)
        if (ec.Includes("itemsThroughputQuantiles",true))
        {
            if(this.ItemsThroughputQuantiles == null) {

                this.ItemsThroughputQuantiles = new List<System.Single>();

            } else {


            }
        }
        else if (this.ItemsThroughputQuantiles != null && ec.Excludes("itemsThroughputQuantiles",true))
        {
            this.ItemsThroughputQuantiles = null;
        }
        //      C# -> System.Int32? Seq
        // GraphQL -> seq: Int! (scalar)
        if (ec.Includes("seq",true))
        {
            if(this.Seq == null) {

                this.Seq = Int32.MinValue;

            } else {


            }
        }
        else if (this.Seq != null && ec.Excludes("seq",true))
        {
            this.Seq = null;
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long (scalar)
        if (ec.Includes("startTime",true))
        {
            if(this.StartTime == null) {

                this.StartTime = new System.Int64();

            } else {


            }
        }
        else if (this.StartTime != null && ec.Excludes("startTime",true))
        {
            this.StartTime = null;
        }
        //      C# -> System.Int32? SucceededWorkloads
        // GraphQL -> succeededWorkloads: Int (scalar)
        if (ec.Includes("succeededWorkloads",true))
        {
            if(this.SucceededWorkloads == null) {

                this.SucceededWorkloads = Int32.MinValue;

            } else {


            }
        }
        else if (this.SucceededWorkloads != null && ec.Excludes("succeededWorkloads",true))
        {
            this.SucceededWorkloads = null;
        }
        //      C# -> System.Int32? TotalWorkloads
        // GraphQL -> totalWorkloads: Int (scalar)
        if (ec.Includes("totalWorkloads",true))
        {
            if(this.TotalWorkloads == null) {

                this.TotalWorkloads = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalWorkloads != null && ec.Excludes("totalWorkloads",true))
        {
            this.TotalWorkloads = null;
        }
        //      C# -> System.String? WorkloadType
        // GraphQL -> workloadType: String! (scalar)
        if (ec.Includes("workloadType",true))
        {
            if(this.WorkloadType == null) {

                this.WorkloadType = "FETCH";

            } else {


            }
        }
        else if (this.WorkloadType != null && ec.Excludes("workloadType",true))
        {
            this.WorkloadType = null;
        }
        //      C# -> System.Int32? WorkloadsWithoutSnapshot
        // GraphQL -> workloadsWithoutSnapshot: Int (scalar)
        if (ec.Includes("workloadsWithoutSnapshot",true))
        {
            if(this.WorkloadsWithoutSnapshot == null) {

                this.WorkloadsWithoutSnapshot = Int32.MinValue;

            } else {


            }
        }
        else if (this.WorkloadsWithoutSnapshot != null && ec.Excludes("workloadsWithoutSnapshot",true))
        {
            this.WorkloadsWithoutSnapshot = null;
        }
        //      C# -> List<BulkRecoverySelectorStep>? SelectorSteps
        // GraphQL -> selectorSteps: [BulkRecoverySelectorStep!]! (type)
        if (ec.Includes("selectorSteps",false))
        {
            if(this.SelectorSteps == null) {

                this.SelectorSteps = new List<BulkRecoverySelectorStep>();
                this.SelectorSteps.ApplyExploratoryFieldSpec(ec.NewChild("selectorSteps"));

            } else {

                this.SelectorSteps.ApplyExploratoryFieldSpec(ec.NewChild("selectorSteps"));

            }
        }
        else if (this.SelectorSteps != null && ec.Excludes("selectorSteps",false))
        {
            this.SelectorSteps = null;
        }
    }


    #endregion

    } // class BulkRecoveryGroupWorkloadProgress
    
    #endregion

    public static class ListBulkRecoveryGroupWorkloadProgressExtensions
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
            this List<BulkRecoveryGroupWorkloadProgress> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BulkRecoveryGroupWorkloadProgress> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BulkRecoveryGroupWorkloadProgress> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BulkRecoveryGroupWorkloadProgress());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BulkRecoveryGroupWorkloadProgress> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types