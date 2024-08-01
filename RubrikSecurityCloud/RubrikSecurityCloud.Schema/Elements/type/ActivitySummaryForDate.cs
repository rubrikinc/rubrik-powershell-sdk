// ActivitySummaryForDate.cs
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
    #region ActivitySummaryForDate
    public class ActivitySummaryForDate: BaseType
    {
        #region members

        //      C# -> System.Single? DeleteActivityDeviationPercentage
        // GraphQL -> deleteActivityDeviationPercentage: Float! (scalar)
        [JsonProperty("deleteActivityDeviationPercentage")]
        public System.Single? DeleteActivityDeviationPercentage { get; set; }

        //      C# -> System.Single? ReadActivityDeviationPercentage
        // GraphQL -> readActivityDeviationPercentage: Float! (scalar)
        [JsonProperty("readActivityDeviationPercentage")]
        public System.Single? ReadActivityDeviationPercentage { get; set; }

        //      C# -> System.Int64? TimelineDate
        // GraphQL -> timelineDate: Long! (scalar)
        [JsonProperty("timelineDate")]
        public System.Int64? TimelineDate { get; set; }

        //      C# -> System.Single? WriteActivityDeviationPercentage
        // GraphQL -> writeActivityDeviationPercentage: Float! (scalar)
        [JsonProperty("writeActivityDeviationPercentage")]
        public System.Single? WriteActivityDeviationPercentage { get; set; }

        //      C# -> ActivitySummary? ActivitySummary
        // GraphQL -> activitySummary: ActivitySummary (type)
        [JsonProperty("activitySummary")]
        public ActivitySummary? ActivitySummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActivitySummaryForDate";
    }

    public ActivitySummaryForDate Set(
        System.Single? DeleteActivityDeviationPercentage = null,
        System.Single? ReadActivityDeviationPercentage = null,
        System.Int64? TimelineDate = null,
        System.Single? WriteActivityDeviationPercentage = null,
        ActivitySummary? ActivitySummary = null
    ) 
    {
        if ( DeleteActivityDeviationPercentage != null ) {
            this.DeleteActivityDeviationPercentage = DeleteActivityDeviationPercentage;
        }
        if ( ReadActivityDeviationPercentage != null ) {
            this.ReadActivityDeviationPercentage = ReadActivityDeviationPercentage;
        }
        if ( TimelineDate != null ) {
            this.TimelineDate = TimelineDate;
        }
        if ( WriteActivityDeviationPercentage != null ) {
            this.WriteActivityDeviationPercentage = WriteActivityDeviationPercentage;
        }
        if ( ActivitySummary != null ) {
            this.ActivitySummary = ActivitySummary;
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
        //      C# -> System.Single? DeleteActivityDeviationPercentage
        // GraphQL -> deleteActivityDeviationPercentage: Float! (scalar)
        if (this.DeleteActivityDeviationPercentage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deleteActivityDeviationPercentage\n" ;
            } else {
                s += ind + "deleteActivityDeviationPercentage\n" ;
            }
        }
        //      C# -> System.Single? ReadActivityDeviationPercentage
        // GraphQL -> readActivityDeviationPercentage: Float! (scalar)
        if (this.ReadActivityDeviationPercentage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "readActivityDeviationPercentage\n" ;
            } else {
                s += ind + "readActivityDeviationPercentage\n" ;
            }
        }
        //      C# -> System.Int64? TimelineDate
        // GraphQL -> timelineDate: Long! (scalar)
        if (this.TimelineDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timelineDate\n" ;
            } else {
                s += ind + "timelineDate\n" ;
            }
        }
        //      C# -> System.Single? WriteActivityDeviationPercentage
        // GraphQL -> writeActivityDeviationPercentage: Float! (scalar)
        if (this.WriteActivityDeviationPercentage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "writeActivityDeviationPercentage\n" ;
            } else {
                s += ind + "writeActivityDeviationPercentage\n" ;
            }
        }
        //      C# -> ActivitySummary? ActivitySummary
        // GraphQL -> activitySummary: ActivitySummary (type)
        if (this.ActivitySummary != null) {
            var fspec = this.ActivitySummary.AsFieldSpec(conf.Child("activitySummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "activitySummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Single? DeleteActivityDeviationPercentage
        // GraphQL -> deleteActivityDeviationPercentage: Float! (scalar)
        if (ec.Includes("deleteActivityDeviationPercentage",true))
        {
            if(this.DeleteActivityDeviationPercentage == null) {

                this.DeleteActivityDeviationPercentage = new System.Single();

            } else {


            }
        }
        else if (this.DeleteActivityDeviationPercentage != null && ec.Excludes("deleteActivityDeviationPercentage",true))
        {
            this.DeleteActivityDeviationPercentage = null;
        }
        //      C# -> System.Single? ReadActivityDeviationPercentage
        // GraphQL -> readActivityDeviationPercentage: Float! (scalar)
        if (ec.Includes("readActivityDeviationPercentage",true))
        {
            if(this.ReadActivityDeviationPercentage == null) {

                this.ReadActivityDeviationPercentage = new System.Single();

            } else {


            }
        }
        else if (this.ReadActivityDeviationPercentage != null && ec.Excludes("readActivityDeviationPercentage",true))
        {
            this.ReadActivityDeviationPercentage = null;
        }
        //      C# -> System.Int64? TimelineDate
        // GraphQL -> timelineDate: Long! (scalar)
        if (ec.Includes("timelineDate",true))
        {
            if(this.TimelineDate == null) {

                this.TimelineDate = new System.Int64();

            } else {


            }
        }
        else if (this.TimelineDate != null && ec.Excludes("timelineDate",true))
        {
            this.TimelineDate = null;
        }
        //      C# -> System.Single? WriteActivityDeviationPercentage
        // GraphQL -> writeActivityDeviationPercentage: Float! (scalar)
        if (ec.Includes("writeActivityDeviationPercentage",true))
        {
            if(this.WriteActivityDeviationPercentage == null) {

                this.WriteActivityDeviationPercentage = new System.Single();

            } else {


            }
        }
        else if (this.WriteActivityDeviationPercentage != null && ec.Excludes("writeActivityDeviationPercentage",true))
        {
            this.WriteActivityDeviationPercentage = null;
        }
        //      C# -> ActivitySummary? ActivitySummary
        // GraphQL -> activitySummary: ActivitySummary (type)
        if (ec.Includes("activitySummary",false))
        {
            if(this.ActivitySummary == null) {

                this.ActivitySummary = new ActivitySummary();
                this.ActivitySummary.ApplyExploratoryFieldSpec(ec.NewChild("activitySummary"));

            } else {

                this.ActivitySummary.ApplyExploratoryFieldSpec(ec.NewChild("activitySummary"));

            }
        }
        else if (this.ActivitySummary != null && ec.Excludes("activitySummary",false))
        {
            this.ActivitySummary = null;
        }
    }


    #endregion

    } // class ActivitySummaryForDate
    
    #endregion

    public static class ListActivitySummaryForDateExtensions
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
            this List<ActivitySummaryForDate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActivitySummaryForDate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActivitySummaryForDate> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActivitySummaryForDate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActivitySummaryForDate> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types