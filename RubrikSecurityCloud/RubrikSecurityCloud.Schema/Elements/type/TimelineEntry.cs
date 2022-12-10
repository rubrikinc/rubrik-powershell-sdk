// TimelineEntry.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:29.
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
    #region TimelineEntry
    public class TimelineEntry: IFragment
    {
        #region members
        //      C# -> System.String? Day
        // GraphQL -> day: String! (scalar)
        [JsonProperty("day")]
        public System.String? Day { get; set; }

        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        [JsonProperty("policyId")]
        public System.String? PolicyId { get; set; }

        //      C# -> Hits? Hits
        // GraphQL -> hits: Hits (type)
        [JsonProperty("hits")]
        public Hits? Hits { get; set; }

        #endregion

    #region methods

    public TimelineEntry Set(
        System.String? Day = null,
        System.String? PolicyId = null,
        Hits? Hits = null
    ) 
    {
        if ( Day != null ) {
            this.Day = Day;
        }
        if ( PolicyId != null ) {
            this.PolicyId = PolicyId;
        }
        if ( Hits != null ) {
            this.Hits = Hits;
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
            //      C# -> System.String? PolicyId
            // GraphQL -> policyId: String! (scalar)
            if (this.PolicyId != null)
            {
                 s += ind + "policyId\n";

            }
            //      C# -> Hits? Hits
            // GraphQL -> hits: Hits (type)
            if (this.Hits != null)
            {
                 s += ind + "hits\n";

                 s += ind + "{\n" + 
                 this.Hits.AsFragment(indent+1) + 
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
            //      C# -> System.String? PolicyId
            // GraphQL -> policyId: String! (scalar)
            if (this.PolicyId == null && Exploration.Includes(parent + ".policyId$"))
            {
                this.PolicyId = new System.String("FETCH");
            }
            //      C# -> Hits? Hits
            // GraphQL -> hits: Hits (type)
            if (this.Hits == null && Exploration.Includes(parent + ".hits"))
            {
                this.Hits = new Hits();
                this.Hits.ApplyExploratoryFragment(parent + ".hits");
            }
        }


    #endregion

    } // class TimelineEntry
    #endregion

    public static class ListTimelineEntryExtensions
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
            this List<TimelineEntry> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<TimelineEntry> list, 
            String parent = "")
        {
            var item = new TimelineEntry();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types