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

namespace Rubrik.SecurityCloud.Types
{
    #region ActivityTimelineResult
    public class ActivityTimelineResult: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? Day
            // GraphQL -> day: String! (scalar)
            if (this.Day != null)
            {
                 s += ind + "day\n";

            }
            //      C# -> List<ActivityResult>? ActivityResults
            // GraphQL -> activityResults: [ActivityResult!]! (type)
            if (this.ActivityResults != null)
            {
                 s += ind + "activityResults\n";

                 s += ind + "{\n" + 
                 this.ActivityResults.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<FileAccessResult>? TopFiles
            // GraphQL -> topFiles: [FileAccessResult!]! (type)
            if (this.TopFiles != null)
            {
                 s += ind + "topFiles\n";

                 s += ind + "{\n" + 
                 this.TopFiles.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Day
            // GraphQL -> day: String! (scalar)
            if (this.Day == null && Exploration.Includes(parent + ".day$"))
            {
                this.Day = new System.String("FETCH");
            }
            //      C# -> List<ActivityResult>? ActivityResults
            // GraphQL -> activityResults: [ActivityResult!]! (type)
            if (this.ActivityResults == null && Exploration.Includes(parent + ".activityResults"))
            {
                this.ActivityResults = new List<ActivityResult>();
                this.ActivityResults.ApplyExploratoryFragment(parent + ".activityResults");
            }
            //      C# -> List<FileAccessResult>? TopFiles
            // GraphQL -> topFiles: [FileAccessResult!]! (type)
            if (this.TopFiles == null && Exploration.Includes(parent + ".topFiles"))
            {
                this.TopFiles = new List<FileAccessResult>();
                this.TopFiles.ApplyExploratoryFragment(parent + ".topFiles");
            }
        }


    #endregion

    } // class ActivityTimelineResult
    #endregion

    public static class ListActivityTimelineResultExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<ActivityTimelineResult> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ActivityTimelineResult> list, 
            String parent = "")
        {
            var item = new ActivityTimelineResult();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types