// WorkloadProtectionDetail.cs
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
    #region WorkloadProtectionDetail
    public class WorkloadProtectionDetail: BaseType
    {
        #region members

        //      C# -> System.Int64? TotalRecoveryCount
        // GraphQL -> totalRecoveryCount: Long! (scalar)
        [JsonProperty("totalRecoveryCount")]
        public System.Int64? TotalRecoveryCount { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> LastWorkloadRecoveryInfo? LastWorkloadRecoveryInfo
        // GraphQL -> lastWorkloadRecoveryInfo: LastWorkloadRecoveryInfo (type)
        [JsonProperty("lastWorkloadRecoveryInfo")]
        public LastWorkloadRecoveryInfo? LastWorkloadRecoveryInfo { get; set; }

        //      C# -> List<WorkloadRecoveryCount>? RecoveryCountsByType
        // GraphQL -> recoveryCountsByType: [WorkloadRecoveryCount!]! (type)
        [JsonProperty("recoveryCountsByType")]
        public List<WorkloadRecoveryCount>? RecoveryCountsByType { get; set; }

        //      C# -> List<RecoveryPlanStat>? RecoveryPlanStatsByType
        // GraphQL -> recoveryPlanStatsByType: [RecoveryPlanStat!]! (type)
        [JsonProperty("recoveryPlanStatsByType")]
        public List<RecoveryPlanStat>? RecoveryPlanStatsByType { get; set; }

        //      C# -> List<RecoveryPlanBasicInfo>? RecoveryPlans
        // GraphQL -> recoveryPlans: [RecoveryPlanBasicInfo!]! (type)
        [JsonProperty("recoveryPlans")]
        public List<RecoveryPlanBasicInfo>? RecoveryPlans { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WorkloadProtectionDetail";
    }

    public WorkloadProtectionDetail Set(
        System.Int64? TotalRecoveryCount = null,
        System.String? WorkloadId = null,
        LastWorkloadRecoveryInfo? LastWorkloadRecoveryInfo = null,
        List<WorkloadRecoveryCount>? RecoveryCountsByType = null,
        List<RecoveryPlanStat>? RecoveryPlanStatsByType = null,
        List<RecoveryPlanBasicInfo>? RecoveryPlans = null
    ) 
    {
        if ( TotalRecoveryCount != null ) {
            this.TotalRecoveryCount = TotalRecoveryCount;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
        }
        if ( LastWorkloadRecoveryInfo != null ) {
            this.LastWorkloadRecoveryInfo = LastWorkloadRecoveryInfo;
        }
        if ( RecoveryCountsByType != null ) {
            this.RecoveryCountsByType = RecoveryCountsByType;
        }
        if ( RecoveryPlanStatsByType != null ) {
            this.RecoveryPlanStatsByType = RecoveryPlanStatsByType;
        }
        if ( RecoveryPlans != null ) {
            this.RecoveryPlans = RecoveryPlans;
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
        //      C# -> System.Int64? TotalRecoveryCount
        // GraphQL -> totalRecoveryCount: Long! (scalar)
        if (this.TotalRecoveryCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalRecoveryCount\n" ;
            } else {
                s += ind + "totalRecoveryCount\n" ;
            }
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        if (this.WorkloadId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadId\n" ;
            } else {
                s += ind + "workloadId\n" ;
            }
        }
        //      C# -> LastWorkloadRecoveryInfo? LastWorkloadRecoveryInfo
        // GraphQL -> lastWorkloadRecoveryInfo: LastWorkloadRecoveryInfo (type)
        if (this.LastWorkloadRecoveryInfo != null) {
            var fspec = this.LastWorkloadRecoveryInfo.AsFieldSpec(conf.Child("lastWorkloadRecoveryInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lastWorkloadRecoveryInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<WorkloadRecoveryCount>? RecoveryCountsByType
        // GraphQL -> recoveryCountsByType: [WorkloadRecoveryCount!]! (type)
        if (this.RecoveryCountsByType != null) {
            var fspec = this.RecoveryCountsByType.AsFieldSpec(conf.Child("recoveryCountsByType"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoveryCountsByType" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RecoveryPlanStat>? RecoveryPlanStatsByType
        // GraphQL -> recoveryPlanStatsByType: [RecoveryPlanStat!]! (type)
        if (this.RecoveryPlanStatsByType != null) {
            var fspec = this.RecoveryPlanStatsByType.AsFieldSpec(conf.Child("recoveryPlanStatsByType"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoveryPlanStatsByType" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RecoveryPlanBasicInfo>? RecoveryPlans
        // GraphQL -> recoveryPlans: [RecoveryPlanBasicInfo!]! (type)
        if (this.RecoveryPlans != null) {
            var fspec = this.RecoveryPlans.AsFieldSpec(conf.Child("recoveryPlans"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoveryPlans" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? TotalRecoveryCount
        // GraphQL -> totalRecoveryCount: Long! (scalar)
        if (ec.Includes("totalRecoveryCount",true))
        {
            if(this.TotalRecoveryCount == null) {

                this.TotalRecoveryCount = new System.Int64();

            } else {


            }
        }
        else if (this.TotalRecoveryCount != null && ec.Excludes("totalRecoveryCount",true))
        {
            this.TotalRecoveryCount = null;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        if (ec.Includes("workloadId",true))
        {
            if(this.WorkloadId == null) {

                this.WorkloadId = "FETCH";

            } else {


            }
        }
        else if (this.WorkloadId != null && ec.Excludes("workloadId",true))
        {
            this.WorkloadId = null;
        }
        //      C# -> LastWorkloadRecoveryInfo? LastWorkloadRecoveryInfo
        // GraphQL -> lastWorkloadRecoveryInfo: LastWorkloadRecoveryInfo (type)
        if (ec.Includes("lastWorkloadRecoveryInfo",false))
        {
            if(this.LastWorkloadRecoveryInfo == null) {

                this.LastWorkloadRecoveryInfo = new LastWorkloadRecoveryInfo();
                this.LastWorkloadRecoveryInfo.ApplyExploratoryFieldSpec(ec.NewChild("lastWorkloadRecoveryInfo"));

            } else {

                this.LastWorkloadRecoveryInfo.ApplyExploratoryFieldSpec(ec.NewChild("lastWorkloadRecoveryInfo"));

            }
        }
        else if (this.LastWorkloadRecoveryInfo != null && ec.Excludes("lastWorkloadRecoveryInfo",false))
        {
            this.LastWorkloadRecoveryInfo = null;
        }
        //      C# -> List<WorkloadRecoveryCount>? RecoveryCountsByType
        // GraphQL -> recoveryCountsByType: [WorkloadRecoveryCount!]! (type)
        if (ec.Includes("recoveryCountsByType",false))
        {
            if(this.RecoveryCountsByType == null) {

                this.RecoveryCountsByType = new List<WorkloadRecoveryCount>();
                this.RecoveryCountsByType.ApplyExploratoryFieldSpec(ec.NewChild("recoveryCountsByType"));

            } else {

                this.RecoveryCountsByType.ApplyExploratoryFieldSpec(ec.NewChild("recoveryCountsByType"));

            }
        }
        else if (this.RecoveryCountsByType != null && ec.Excludes("recoveryCountsByType",false))
        {
            this.RecoveryCountsByType = null;
        }
        //      C# -> List<RecoveryPlanStat>? RecoveryPlanStatsByType
        // GraphQL -> recoveryPlanStatsByType: [RecoveryPlanStat!]! (type)
        if (ec.Includes("recoveryPlanStatsByType",false))
        {
            if(this.RecoveryPlanStatsByType == null) {

                this.RecoveryPlanStatsByType = new List<RecoveryPlanStat>();
                this.RecoveryPlanStatsByType.ApplyExploratoryFieldSpec(ec.NewChild("recoveryPlanStatsByType"));

            } else {

                this.RecoveryPlanStatsByType.ApplyExploratoryFieldSpec(ec.NewChild("recoveryPlanStatsByType"));

            }
        }
        else if (this.RecoveryPlanStatsByType != null && ec.Excludes("recoveryPlanStatsByType",false))
        {
            this.RecoveryPlanStatsByType = null;
        }
        //      C# -> List<RecoveryPlanBasicInfo>? RecoveryPlans
        // GraphQL -> recoveryPlans: [RecoveryPlanBasicInfo!]! (type)
        if (ec.Includes("recoveryPlans",false))
        {
            if(this.RecoveryPlans == null) {

                this.RecoveryPlans = new List<RecoveryPlanBasicInfo>();
                this.RecoveryPlans.ApplyExploratoryFieldSpec(ec.NewChild("recoveryPlans"));

            } else {

                this.RecoveryPlans.ApplyExploratoryFieldSpec(ec.NewChild("recoveryPlans"));

            }
        }
        else if (this.RecoveryPlans != null && ec.Excludes("recoveryPlans",false))
        {
            this.RecoveryPlans = null;
        }
    }


    #endregion

    } // class WorkloadProtectionDetail
    
    #endregion

    public static class ListWorkloadProtectionDetailExtensions
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
            this List<WorkloadProtectionDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<WorkloadProtectionDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadProtectionDetail> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadProtectionDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WorkloadProtectionDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types