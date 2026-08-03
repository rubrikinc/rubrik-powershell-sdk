// WorkloadLastRecovery.cs
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
    #region WorkloadLastRecovery
    public class WorkloadLastRecovery: BaseType
    {
        #region members

        //      C# -> RecoveryOutcome? LastRecoveryOutcome
        // GraphQL -> lastRecoveryOutcome: RecoveryOutcome! (enum)
        [JsonProperty("lastRecoveryOutcome")]
        public RecoveryOutcome? LastRecoveryOutcome { get; set; }

        //      C# -> DateTime? LastRecoverySnapshotTime
        // GraphQL -> lastRecoverySnapshotTime: DateTime (scalar)
        [JsonProperty("lastRecoverySnapshotTime")]
        public DateTime? LastRecoverySnapshotTime { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WorkloadLastRecovery";
    }

    public WorkloadLastRecovery Set(
        RecoveryOutcome? LastRecoveryOutcome = null,
        DateTime? LastRecoverySnapshotTime = null,
        System.String? WorkloadId = null
    ) 
    {
        if ( LastRecoveryOutcome != null ) {
            this.LastRecoveryOutcome = LastRecoveryOutcome;
        }
        if ( LastRecoverySnapshotTime != null ) {
            this.LastRecoverySnapshotTime = LastRecoverySnapshotTime;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
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
        //      C# -> RecoveryOutcome? LastRecoveryOutcome
        // GraphQL -> lastRecoveryOutcome: RecoveryOutcome! (enum)
        if (this.LastRecoveryOutcome != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRecoveryOutcome\n" ;
            } else {
                s += ind + "lastRecoveryOutcome\n" ;
            }
        }
        //      C# -> DateTime? LastRecoverySnapshotTime
        // GraphQL -> lastRecoverySnapshotTime: DateTime (scalar)
        if (this.LastRecoverySnapshotTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRecoverySnapshotTime\n" ;
            } else {
                s += ind + "lastRecoverySnapshotTime\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RecoveryOutcome? LastRecoveryOutcome
        // GraphQL -> lastRecoveryOutcome: RecoveryOutcome! (enum)
        if (ec.Includes("lastRecoveryOutcome",true))
        {
            if(this.LastRecoveryOutcome == null) {

                this.LastRecoveryOutcome = new RecoveryOutcome();

            } else {


            }
        }
        else if (this.LastRecoveryOutcome != null && ec.Excludes("lastRecoveryOutcome",true))
        {
            this.LastRecoveryOutcome = null;
        }
        //      C# -> DateTime? LastRecoverySnapshotTime
        // GraphQL -> lastRecoverySnapshotTime: DateTime (scalar)
        if (ec.Includes("lastRecoverySnapshotTime",true))
        {
            if(this.LastRecoverySnapshotTime == null) {

                this.LastRecoverySnapshotTime = new DateTime();

            } else {


            }
        }
        else if (this.LastRecoverySnapshotTime != null && ec.Excludes("lastRecoverySnapshotTime",true))
        {
            this.LastRecoverySnapshotTime = null;
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
    }


    #endregion

    } // class WorkloadLastRecovery
    
    #endregion

    public static class ListWorkloadLastRecoveryExtensions
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
            this List<WorkloadLastRecovery> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<WorkloadLastRecovery> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadLastRecovery> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadLastRecovery());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WorkloadLastRecovery> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types