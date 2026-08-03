// ChildRecoverySpecMapV2.cs
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
    #region ChildRecoverySpecMapV2
    public class ChildRecoverySpecMapV2: BaseType
    {
        #region members

        //      C# -> System.Int32? BootPriority
        // GraphQL -> bootPriority: Int! (scalar)
        [JsonProperty("bootPriority")]
        public System.Int32? BootPriority { get; set; }

        //      C# -> System.String? PostFailoverSlaId
        // GraphQL -> postFailoverSlaId: UUID (scalar)
        [JsonProperty("postFailoverSlaId")]
        public System.String? PostFailoverSlaId { get; set; }

        //      C# -> System.Int64? RecoveryPoint
        // GraphQL -> recoveryPoint: Long! (scalar)
        [JsonProperty("recoveryPoint")]
        public System.Int64? RecoveryPoint { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> WorkloadRecoverySpec? WorkloadRecoverySpec
        // GraphQL -> workloadRecoverySpec: WorkloadRecoverySpec (type)
        [JsonProperty("workloadRecoverySpec")]
        public WorkloadRecoverySpec? WorkloadRecoverySpec { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ChildRecoverySpecMapV2";
    }

    public ChildRecoverySpecMapV2 Set(
        System.Int32? BootPriority = null,
        System.String? PostFailoverSlaId = null,
        System.Int64? RecoveryPoint = null,
        System.String? SnapshotId = null,
        System.String? WorkloadId = null,
        WorkloadRecoverySpec? WorkloadRecoverySpec = null
    ) 
    {
        if ( BootPriority != null ) {
            this.BootPriority = BootPriority;
        }
        if ( PostFailoverSlaId != null ) {
            this.PostFailoverSlaId = PostFailoverSlaId;
        }
        if ( RecoveryPoint != null ) {
            this.RecoveryPoint = RecoveryPoint;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
        }
        if ( WorkloadRecoverySpec != null ) {
            this.WorkloadRecoverySpec = WorkloadRecoverySpec;
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
        //      C# -> System.Int32? BootPriority
        // GraphQL -> bootPriority: Int! (scalar)
        if (this.BootPriority != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bootPriority\n" ;
            } else {
                s += ind + "bootPriority\n" ;
            }
        }
        //      C# -> System.String? PostFailoverSlaId
        // GraphQL -> postFailoverSlaId: UUID (scalar)
        if (this.PostFailoverSlaId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "postFailoverSlaId\n" ;
            } else {
                s += ind + "postFailoverSlaId\n" ;
            }
        }
        //      C# -> System.Int64? RecoveryPoint
        // GraphQL -> recoveryPoint: Long! (scalar)
        if (this.RecoveryPoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPoint\n" ;
            } else {
                s += ind + "recoveryPoint\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (this.WorkloadId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadId\n" ;
            } else {
                s += ind + "workloadId\n" ;
            }
        }
        //      C# -> WorkloadRecoverySpec? WorkloadRecoverySpec
        // GraphQL -> workloadRecoverySpec: WorkloadRecoverySpec (type)
        if (this.WorkloadRecoverySpec != null) {
            var fspec = this.WorkloadRecoverySpec.AsFieldSpec(conf.Child("workloadRecoverySpec"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "workloadRecoverySpec" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? BootPriority
        // GraphQL -> bootPriority: Int! (scalar)
        if (ec.Includes("bootPriority",true))
        {
            if(this.BootPriority == null) {

                this.BootPriority = Int32.MinValue;

            } else {


            }
        }
        else if (this.BootPriority != null && ec.Excludes("bootPriority",true))
        {
            this.BootPriority = null;
        }
        //      C# -> System.String? PostFailoverSlaId
        // GraphQL -> postFailoverSlaId: UUID (scalar)
        if (ec.Includes("postFailoverSlaId",true))
        {
            if(this.PostFailoverSlaId == null) {

                this.PostFailoverSlaId = "FETCH";

            } else {


            }
        }
        else if (this.PostFailoverSlaId != null && ec.Excludes("postFailoverSlaId",true))
        {
            this.PostFailoverSlaId = null;
        }
        //      C# -> System.Int64? RecoveryPoint
        // GraphQL -> recoveryPoint: Long! (scalar)
        if (ec.Includes("recoveryPoint",true))
        {
            if(this.RecoveryPoint == null) {

                this.RecoveryPoint = new System.Int64();

            } else {


            }
        }
        else if (this.RecoveryPoint != null && ec.Excludes("recoveryPoint",true))
        {
            this.RecoveryPoint = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
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
        //      C# -> WorkloadRecoverySpec? WorkloadRecoverySpec
        // GraphQL -> workloadRecoverySpec: WorkloadRecoverySpec (type)
        if (ec.Includes("workloadRecoverySpec",false))
        {
            if(this.WorkloadRecoverySpec == null) {

                this.WorkloadRecoverySpec = new WorkloadRecoverySpec();
                this.WorkloadRecoverySpec.ApplyExploratoryFieldSpec(ec.NewChild("workloadRecoverySpec"));

            } else {

                this.WorkloadRecoverySpec.ApplyExploratoryFieldSpec(ec.NewChild("workloadRecoverySpec"));

            }
        }
        else if (this.WorkloadRecoverySpec != null && ec.Excludes("workloadRecoverySpec",false))
        {
            this.WorkloadRecoverySpec = null;
        }
    }


    #endregion

    } // class ChildRecoverySpecMapV2
    
    #endregion

    public static class ListChildRecoverySpecMapV2Extensions
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
            this List<ChildRecoverySpecMapV2> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ChildRecoverySpecMapV2> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ChildRecoverySpecMapV2> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ChildRecoverySpecMapV2());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ChildRecoverySpecMapV2> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types