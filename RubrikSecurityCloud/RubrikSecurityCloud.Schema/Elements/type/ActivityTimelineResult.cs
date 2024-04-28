// ActivityTimelineResult.cs
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
    #region ActivityTimelineResult
    public class ActivityTimelineResult: BaseType
    {
        #region members

        //      C# -> System.String? Day
        // GraphQL -> day: String! (scalar)
        [JsonProperty("day")]
        public System.String? Day { get; set; }

        //      C# -> List<ActivityResult>? ActivityResults
        // GraphQL -> activityResults: [ActivityResult!]! (type)
        [JsonProperty("activityResults")]
        public List<ActivityResult>? ActivityResults { get; set; }

        //      C# -> List<FileAccessResult>? TopFiles
        // GraphQL -> topFiles: [FileAccessResult!]! (type)
        [JsonProperty("topFiles")]
        public List<FileAccessResult>? TopFiles { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActivityTimelineResult";
    }

    public ActivityTimelineResult Set(
        System.String? Day = null,
        List<ActivityResult>? ActivityResults = null,
        List<FileAccessResult>? TopFiles = null
    ) 
    {
        if ( Day != null ) {
            this.Day = Day;
        }
        if ( ActivityResults != null ) {
            this.ActivityResults = ActivityResults;
        }
        if ( TopFiles != null ) {
            this.TopFiles = TopFiles;
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
        //      C# -> System.String? Day
        // GraphQL -> day: String! (scalar)
        if (this.Day != null) {
            if (conf.Flat) {
                s += conf.Prefix + "day\n" ;
            } else {
                s += ind + "day\n" ;
            }
        }
        //      C# -> List<ActivityResult>? ActivityResults
        // GraphQL -> activityResults: [ActivityResult!]! (type)
        if (this.ActivityResults != null) {
            var fspec = this.ActivityResults.AsFieldSpec(conf.Child("activityResults"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "activityResults" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<FileAccessResult>? TopFiles
        // GraphQL -> topFiles: [FileAccessResult!]! (type)
        if (this.TopFiles != null) {
            var fspec = this.TopFiles.AsFieldSpec(conf.Child("topFiles"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "topFiles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Day
        // GraphQL -> day: String! (scalar)
        if (ec.Includes("day",true))
        {
            if(this.Day == null) {

                this.Day = "FETCH";

            } else {


            }
        }
        else if (this.Day != null && ec.Excludes("day",true))
        {
            this.Day = null;
        }
        //      C# -> List<ActivityResult>? ActivityResults
        // GraphQL -> activityResults: [ActivityResult!]! (type)
        if (ec.Includes("activityResults",false))
        {
            if(this.ActivityResults == null) {

                this.ActivityResults = new List<ActivityResult>();
                this.ActivityResults.ApplyExploratoryFieldSpec(ec.NewChild("activityResults"));

            } else {

                this.ActivityResults.ApplyExploratoryFieldSpec(ec.NewChild("activityResults"));

            }
        }
        else if (this.ActivityResults != null && ec.Excludes("activityResults",false))
        {
            this.ActivityResults = null;
        }
        //      C# -> List<FileAccessResult>? TopFiles
        // GraphQL -> topFiles: [FileAccessResult!]! (type)
        if (ec.Includes("topFiles",false))
        {
            if(this.TopFiles == null) {

                this.TopFiles = new List<FileAccessResult>();
                this.TopFiles.ApplyExploratoryFieldSpec(ec.NewChild("topFiles"));

            } else {

                this.TopFiles.ApplyExploratoryFieldSpec(ec.NewChild("topFiles"));

            }
        }
        else if (this.TopFiles != null && ec.Excludes("topFiles",false))
        {
            this.TopFiles = null;
        }
    }


    #endregion

    } // class ActivityTimelineResult
    
    #endregion

    public static class ListActivityTimelineResultExtensions
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
            this List<ActivityTimelineResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActivityTimelineResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActivityTimelineResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActivityTimelineResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActivityTimelineResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types