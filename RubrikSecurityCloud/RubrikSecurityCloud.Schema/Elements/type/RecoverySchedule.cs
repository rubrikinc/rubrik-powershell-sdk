// RecoverySchedule.cs
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
    #region RecoverySchedule
    public class RecoverySchedule: BaseType
    {
        #region members

        //      C# -> DateTime? NextRunTime
        // GraphQL -> nextRunTime: DateTime (scalar)
        [JsonProperty("nextRunTime")]
        public DateTime? NextRunTime { get; set; }

        //      C# -> System.String? RecoveryPlanId
        // GraphQL -> recoveryPlanId: UUID! (scalar)
        [JsonProperty("recoveryPlanId")]
        public System.String? RecoveryPlanId { get; set; }

        //      C# -> System.Int64? ScheduleId
        // GraphQL -> scheduleId: Long! (scalar)
        [JsonProperty("scheduleId")]
        public System.Int64? ScheduleId { get; set; }

        //      C# -> ScheduleInfoV2Output? ScheduleInfo
        // GraphQL -> scheduleInfo: ScheduleInfoV2Output (type)
        [JsonProperty("scheduleInfo")]
        public ScheduleInfoV2Output? ScheduleInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecoverySchedule";
    }

    public RecoverySchedule Set(
        DateTime? NextRunTime = null,
        System.String? RecoveryPlanId = null,
        System.Int64? ScheduleId = null,
        ScheduleInfoV2Output? ScheduleInfo = null
    ) 
    {
        if ( NextRunTime != null ) {
            this.NextRunTime = NextRunTime;
        }
        if ( RecoveryPlanId != null ) {
            this.RecoveryPlanId = RecoveryPlanId;
        }
        if ( ScheduleId != null ) {
            this.ScheduleId = ScheduleId;
        }
        if ( ScheduleInfo != null ) {
            this.ScheduleInfo = ScheduleInfo;
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
        //      C# -> DateTime? NextRunTime
        // GraphQL -> nextRunTime: DateTime (scalar)
        if (this.NextRunTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nextRunTime\n" ;
            } else {
                s += ind + "nextRunTime\n" ;
            }
        }
        //      C# -> System.String? RecoveryPlanId
        // GraphQL -> recoveryPlanId: UUID! (scalar)
        if (this.RecoveryPlanId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPlanId\n" ;
            } else {
                s += ind + "recoveryPlanId\n" ;
            }
        }
        //      C# -> System.Int64? ScheduleId
        // GraphQL -> scheduleId: Long! (scalar)
        if (this.ScheduleId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scheduleId\n" ;
            } else {
                s += ind + "scheduleId\n" ;
            }
        }
        //      C# -> ScheduleInfoV2Output? ScheduleInfo
        // GraphQL -> scheduleInfo: ScheduleInfoV2Output (type)
        if (this.ScheduleInfo != null) {
            var fspec = this.ScheduleInfo.AsFieldSpec(conf.Child("scheduleInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "scheduleInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DateTime? NextRunTime
        // GraphQL -> nextRunTime: DateTime (scalar)
        if (ec.Includes("nextRunTime",true))
        {
            if(this.NextRunTime == null) {

                this.NextRunTime = new DateTime();

            } else {


            }
        }
        else if (this.NextRunTime != null && ec.Excludes("nextRunTime",true))
        {
            this.NextRunTime = null;
        }
        //      C# -> System.String? RecoveryPlanId
        // GraphQL -> recoveryPlanId: UUID! (scalar)
        if (ec.Includes("recoveryPlanId",true))
        {
            if(this.RecoveryPlanId == null) {

                this.RecoveryPlanId = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryPlanId != null && ec.Excludes("recoveryPlanId",true))
        {
            this.RecoveryPlanId = null;
        }
        //      C# -> System.Int64? ScheduleId
        // GraphQL -> scheduleId: Long! (scalar)
        if (ec.Includes("scheduleId",true))
        {
            if(this.ScheduleId == null) {

                this.ScheduleId = new System.Int64();

            } else {


            }
        }
        else if (this.ScheduleId != null && ec.Excludes("scheduleId",true))
        {
            this.ScheduleId = null;
        }
        //      C# -> ScheduleInfoV2Output? ScheduleInfo
        // GraphQL -> scheduleInfo: ScheduleInfoV2Output (type)
        if (ec.Includes("scheduleInfo",false))
        {
            if(this.ScheduleInfo == null) {

                this.ScheduleInfo = new ScheduleInfoV2Output();
                this.ScheduleInfo.ApplyExploratoryFieldSpec(ec.NewChild("scheduleInfo"));

            } else {

                this.ScheduleInfo.ApplyExploratoryFieldSpec(ec.NewChild("scheduleInfo"));

            }
        }
        else if (this.ScheduleInfo != null && ec.Excludes("scheduleInfo",false))
        {
            this.ScheduleInfo = null;
        }
    }


    #endregion

    } // class RecoverySchedule
    
    #endregion

    public static class ListRecoveryScheduleExtensions
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
            this List<RecoverySchedule> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RecoverySchedule> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RecoverySchedule> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoverySchedule());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RecoverySchedule> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types