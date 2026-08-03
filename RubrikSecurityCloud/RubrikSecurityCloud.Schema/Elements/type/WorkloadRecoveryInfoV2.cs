// WorkloadRecoveryInfoV2.cs
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
    #region WorkloadRecoveryInfoV2
    public class WorkloadRecoveryInfoV2: BaseType
    {
        #region members

        //      C# -> WorkloadRecoveryStatusV2? WorkloadRecoveryStatus
        // GraphQL -> workloadRecoveryStatus: WorkloadRecoveryStatusV2! (enum)
        [JsonProperty("workloadRecoveryStatus")]
        public WorkloadRecoveryStatusV2? WorkloadRecoveryStatus { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String! (scalar)
        [JsonProperty("workloadName")]
        public System.String? WorkloadName { get; set; }

        //      C# -> System.String? WorkloadRecoveryId
        // GraphQL -> workloadRecoveryId: String! (scalar)
        [JsonProperty("workloadRecoveryId")]
        public System.String? WorkloadRecoveryId { get; set; }

        //      C# -> System.Int64? WorkloadSizeInKbs
        // GraphQL -> workloadSizeInKbs: Long! (scalar)
        [JsonProperty("workloadSizeInKbs")]
        public System.Int64? WorkloadSizeInKbs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WorkloadRecoveryInfoV2";
    }

    public WorkloadRecoveryInfoV2 Set(
        WorkloadRecoveryStatusV2? WorkloadRecoveryStatus = null,
        System.String? WorkloadId = null,
        System.String? WorkloadName = null,
        System.String? WorkloadRecoveryId = null,
        System.Int64? WorkloadSizeInKbs = null
    ) 
    {
        if ( WorkloadRecoveryStatus != null ) {
            this.WorkloadRecoveryStatus = WorkloadRecoveryStatus;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
        }
        if ( WorkloadName != null ) {
            this.WorkloadName = WorkloadName;
        }
        if ( WorkloadRecoveryId != null ) {
            this.WorkloadRecoveryId = WorkloadRecoveryId;
        }
        if ( WorkloadSizeInKbs != null ) {
            this.WorkloadSizeInKbs = WorkloadSizeInKbs;
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
        //      C# -> WorkloadRecoveryStatusV2? WorkloadRecoveryStatus
        // GraphQL -> workloadRecoveryStatus: WorkloadRecoveryStatusV2! (enum)
        if (this.WorkloadRecoveryStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadRecoveryStatus\n" ;
            } else {
                s += ind + "workloadRecoveryStatus\n" ;
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
        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String! (scalar)
        if (this.WorkloadName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadName\n" ;
            } else {
                s += ind + "workloadName\n" ;
            }
        }
        //      C# -> System.String? WorkloadRecoveryId
        // GraphQL -> workloadRecoveryId: String! (scalar)
        if (this.WorkloadRecoveryId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadRecoveryId\n" ;
            } else {
                s += ind + "workloadRecoveryId\n" ;
            }
        }
        //      C# -> System.Int64? WorkloadSizeInKbs
        // GraphQL -> workloadSizeInKbs: Long! (scalar)
        if (this.WorkloadSizeInKbs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadSizeInKbs\n" ;
            } else {
                s += ind + "workloadSizeInKbs\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> WorkloadRecoveryStatusV2? WorkloadRecoveryStatus
        // GraphQL -> workloadRecoveryStatus: WorkloadRecoveryStatusV2! (enum)
        if (ec.Includes("workloadRecoveryStatus",true))
        {
            if(this.WorkloadRecoveryStatus == null) {

                this.WorkloadRecoveryStatus = new WorkloadRecoveryStatusV2();

            } else {


            }
        }
        else if (this.WorkloadRecoveryStatus != null && ec.Excludes("workloadRecoveryStatus",true))
        {
            this.WorkloadRecoveryStatus = null;
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
        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String! (scalar)
        if (ec.Includes("workloadName",true))
        {
            if(this.WorkloadName == null) {

                this.WorkloadName = "FETCH";

            } else {


            }
        }
        else if (this.WorkloadName != null && ec.Excludes("workloadName",true))
        {
            this.WorkloadName = null;
        }
        //      C# -> System.String? WorkloadRecoveryId
        // GraphQL -> workloadRecoveryId: String! (scalar)
        if (ec.Includes("workloadRecoveryId",true))
        {
            if(this.WorkloadRecoveryId == null) {

                this.WorkloadRecoveryId = "FETCH";

            } else {


            }
        }
        else if (this.WorkloadRecoveryId != null && ec.Excludes("workloadRecoveryId",true))
        {
            this.WorkloadRecoveryId = null;
        }
        //      C# -> System.Int64? WorkloadSizeInKbs
        // GraphQL -> workloadSizeInKbs: Long! (scalar)
        if (ec.Includes("workloadSizeInKbs",true))
        {
            if(this.WorkloadSizeInKbs == null) {

                this.WorkloadSizeInKbs = new System.Int64();

            } else {


            }
        }
        else if (this.WorkloadSizeInKbs != null && ec.Excludes("workloadSizeInKbs",true))
        {
            this.WorkloadSizeInKbs = null;
        }
    }


    #endregion

    } // class WorkloadRecoveryInfoV2
    
    #endregion

    public static class ListWorkloadRecoveryInfoV2Extensions
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
            this List<WorkloadRecoveryInfoV2> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<WorkloadRecoveryInfoV2> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadRecoveryInfoV2> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadRecoveryInfoV2());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WorkloadRecoveryInfoV2> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types