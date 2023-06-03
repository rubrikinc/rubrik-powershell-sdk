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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? Day
        // GraphQL -> day: String! (scalar)
        if (this.Day != null) {
            s += ind + "day\n" ;
        }
        //      C# -> List<ActivityResult>? ActivityResults
        // GraphQL -> activityResults: [ActivityResult!]! (type)
        if (this.ActivityResults != null) {
            s += ind + "activityResults {\n" + this.ActivityResults.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<FileAccessResult>? TopFiles
        // GraphQL -> topFiles: [FileAccessResult!]! (type)
        if (this.TopFiles != null) {
            s += ind + "topFiles {\n" + this.TopFiles.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Day
        // GraphQL -> day: String! (scalar)
        if (this.Day == null && Exploration.Includes(parent + ".day", true))
        {
            this.Day = new System.String("FETCH");
        }
        //      C# -> List<ActivityResult>? ActivityResults
        // GraphQL -> activityResults: [ActivityResult!]! (type)
        if (this.ActivityResults == null && Exploration.Includes(parent + ".activityResults"))
        {
            this.ActivityResults = new List<ActivityResult>();
            this.ActivityResults.ApplyExploratoryFieldSpec(parent + ".activityResults");
        }
        //      C# -> List<FileAccessResult>? TopFiles
        // GraphQL -> topFiles: [FileAccessResult!]! (type)
        if (this.TopFiles == null && Exploration.Includes(parent + ".topFiles"))
        {
            this.TopFiles = new List<FileAccessResult>();
            this.TopFiles.ApplyExploratoryFieldSpec(parent + ".topFiles");
        }
    }


    #endregion

    } // class ActivityTimelineResult
    
    #endregion

    public static class ListActivityTimelineResultExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<ActivityTimelineResult> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ActivityTimelineResult> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ActivityTimelineResult());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types