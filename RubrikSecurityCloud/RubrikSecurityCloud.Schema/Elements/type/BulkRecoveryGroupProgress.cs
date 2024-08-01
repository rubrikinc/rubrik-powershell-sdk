// BulkRecoveryGroupProgress.cs
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
    #region BulkRecoveryGroupProgress
    public class BulkRecoveryGroupProgress: BaseType
    {
        #region members

        //      C# -> BulkRecoveryGroupStatus? Status
        // GraphQL -> status: BulkRecoveryGroupStatus! (enum)
        [JsonProperty("status")]
        public BulkRecoveryGroupStatus? Status { get; set; }

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

        //      C# -> System.String? GroupId
        // GraphQL -> groupId: UUID (scalar)
        [JsonProperty("groupId")]
        public System.String? GroupId { get; set; }

        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        [JsonProperty("groupName")]
        public System.String? GroupName { get; set; }

        //      C# -> System.String? GroupType
        // GraphQL -> groupType: String! (scalar)
        [JsonProperty("groupType")]
        public System.String? GroupType { get; set; }

        //      C# -> System.Int32? Seq
        // GraphQL -> seq: Int! (scalar)
        [JsonProperty("seq")]
        public System.Int32? Seq { get; set; }

        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long (scalar)
        [JsonProperty("startTime")]
        public System.Int64? StartTime { get; set; }

        //      C# -> List<BulkRecoveryGroupWorkloadProgress>? WorkloadProgresses
        // GraphQL -> workloadProgresses: [BulkRecoveryGroupWorkloadProgress!]! (type)
        [JsonProperty("workloadProgresses")]
        public List<BulkRecoveryGroupWorkloadProgress>? WorkloadProgresses { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BulkRecoveryGroupProgress";
    }

    public BulkRecoveryGroupProgress Set(
        BulkRecoveryGroupStatus? Status = null,
        System.Int64? CreateTime = null,
        System.Int64? ElapsedTime = null,
        System.Int64? EndTime = null,
        System.String? GroupId = null,
        System.String? GroupName = null,
        System.String? GroupType = null,
        System.Int32? Seq = null,
        System.Int64? StartTime = null,
        List<BulkRecoveryGroupWorkloadProgress>? WorkloadProgresses = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
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
        if ( GroupId != null ) {
            this.GroupId = GroupId;
        }
        if ( GroupName != null ) {
            this.GroupName = GroupName;
        }
        if ( GroupType != null ) {
            this.GroupType = GroupType;
        }
        if ( Seq != null ) {
            this.Seq = Seq;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( WorkloadProgresses != null ) {
            this.WorkloadProgresses = WorkloadProgresses;
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
        //      C# -> BulkRecoveryGroupStatus? Status
        // GraphQL -> status: BulkRecoveryGroupStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
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
        //      C# -> System.String? GroupId
        // GraphQL -> groupId: UUID (scalar)
        if (this.GroupId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupId\n" ;
            } else {
                s += ind + "groupId\n" ;
            }
        }
        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        if (this.GroupName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupName\n" ;
            } else {
                s += ind + "groupName\n" ;
            }
        }
        //      C# -> System.String? GroupType
        // GraphQL -> groupType: String! (scalar)
        if (this.GroupType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupType\n" ;
            } else {
                s += ind + "groupType\n" ;
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
        //      C# -> List<BulkRecoveryGroupWorkloadProgress>? WorkloadProgresses
        // GraphQL -> workloadProgresses: [BulkRecoveryGroupWorkloadProgress!]! (type)
        if (this.WorkloadProgresses != null) {
            var fspec = this.WorkloadProgresses.AsFieldSpec(conf.Child("workloadProgresses"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "workloadProgresses" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> BulkRecoveryGroupStatus? Status
        // GraphQL -> status: BulkRecoveryGroupStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new BulkRecoveryGroupStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
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
        //      C# -> System.String? GroupId
        // GraphQL -> groupId: UUID (scalar)
        if (ec.Includes("groupId",true))
        {
            if(this.GroupId == null) {

                this.GroupId = "FETCH";

            } else {


            }
        }
        else if (this.GroupId != null && ec.Excludes("groupId",true))
        {
            this.GroupId = null;
        }
        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        if (ec.Includes("groupName",true))
        {
            if(this.GroupName == null) {

                this.GroupName = "FETCH";

            } else {


            }
        }
        else if (this.GroupName != null && ec.Excludes("groupName",true))
        {
            this.GroupName = null;
        }
        //      C# -> System.String? GroupType
        // GraphQL -> groupType: String! (scalar)
        if (ec.Includes("groupType",true))
        {
            if(this.GroupType == null) {

                this.GroupType = "FETCH";

            } else {


            }
        }
        else if (this.GroupType != null && ec.Excludes("groupType",true))
        {
            this.GroupType = null;
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
        //      C# -> List<BulkRecoveryGroupWorkloadProgress>? WorkloadProgresses
        // GraphQL -> workloadProgresses: [BulkRecoveryGroupWorkloadProgress!]! (type)
        if (ec.Includes("workloadProgresses",false))
        {
            if(this.WorkloadProgresses == null) {

                this.WorkloadProgresses = new List<BulkRecoveryGroupWorkloadProgress>();
                this.WorkloadProgresses.ApplyExploratoryFieldSpec(ec.NewChild("workloadProgresses"));

            } else {

                this.WorkloadProgresses.ApplyExploratoryFieldSpec(ec.NewChild("workloadProgresses"));

            }
        }
        else if (this.WorkloadProgresses != null && ec.Excludes("workloadProgresses",false))
        {
            this.WorkloadProgresses = null;
        }
    }


    #endregion

    } // class BulkRecoveryGroupProgress
    
    #endregion

    public static class ListBulkRecoveryGroupProgressExtensions
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
            this List<BulkRecoveryGroupProgress> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BulkRecoveryGroupProgress> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BulkRecoveryGroupProgress> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BulkRecoveryGroupProgress());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BulkRecoveryGroupProgress> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types