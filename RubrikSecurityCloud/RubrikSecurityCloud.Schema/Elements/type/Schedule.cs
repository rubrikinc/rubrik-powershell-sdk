// Schedule.cs
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
    #region Schedule
    public class Schedule: BaseType
    {
        #region members

        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: String! (scalar)
        [JsonProperty("blueprintId")]
        public System.String? BlueprintId { get; set; }

        //      C# -> DateTime? NextRunTime
        // GraphQL -> nextRunTime: DateTime (scalar)
        [JsonProperty("nextRunTime")]
        public DateTime? NextRunTime { get; set; }

        //      C# -> System.Int64? ScheduleId
        // GraphQL -> scheduleId: Long! (scalar)
        [JsonProperty("scheduleId")]
        public System.Int64? ScheduleId { get; set; }

        //      C# -> ScheduleInfo? Info
        // GraphQL -> info: ScheduleInfo (type)
        [JsonProperty("info")]
        public ScheduleInfo? Info { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Schedule";
    }

    public Schedule Set(
        System.String? BlueprintId = null,
        DateTime? NextRunTime = null,
        System.Int64? ScheduleId = null,
        ScheduleInfo? Info = null
    ) 
    {
        if ( BlueprintId != null ) {
            this.BlueprintId = BlueprintId;
        }
        if ( NextRunTime != null ) {
            this.NextRunTime = NextRunTime;
        }
        if ( ScheduleId != null ) {
            this.ScheduleId = ScheduleId;
        }
        if ( Info != null ) {
            this.Info = Info;
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
        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: String! (scalar)
        if (this.BlueprintId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "blueprintId\n" ;
            } else {
                s += ind + "blueprintId\n" ;
            }
        }
        //      C# -> DateTime? NextRunTime
        // GraphQL -> nextRunTime: DateTime (scalar)
        if (this.NextRunTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nextRunTime\n" ;
            } else {
                s += ind + "nextRunTime\n" ;
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
        //      C# -> ScheduleInfo? Info
        // GraphQL -> info: ScheduleInfo (type)
        if (this.Info != null) {
            var fspec = this.Info.AsFieldSpec(conf.Child("info"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "info" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: String! (scalar)
        if (ec.Includes("blueprintId",true))
        {
            if(this.BlueprintId == null) {

                this.BlueprintId = "FETCH";

            } else {


            }
        }
        else if (this.BlueprintId != null && ec.Excludes("blueprintId",true))
        {
            this.BlueprintId = null;
        }
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
        //      C# -> ScheduleInfo? Info
        // GraphQL -> info: ScheduleInfo (type)
        if (ec.Includes("info",false))
        {
            if(this.Info == null) {

                this.Info = new ScheduleInfo();
                this.Info.ApplyExploratoryFieldSpec(ec.NewChild("info"));

            } else {

                this.Info.ApplyExploratoryFieldSpec(ec.NewChild("info"));

            }
        }
        else if (this.Info != null && ec.Excludes("info",false))
        {
            this.Info = null;
        }
    }


    #endregion

    } // class Schedule
    
    #endregion

    public static class ListScheduleExtensions
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
            this List<Schedule> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Schedule> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Schedule> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Schedule());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Schedule> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types