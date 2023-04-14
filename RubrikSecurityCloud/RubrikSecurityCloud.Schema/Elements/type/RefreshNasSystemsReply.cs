// RefreshNasSystemsReply.cs
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
    #region RefreshNasSystemsReply
    public class RefreshNasSystemsReply: IFragment
    {
        #region members
        //      C# -> List<DiscoverNasSystemSummary>? DiscoverNasSystemSummaries
        // GraphQL -> discoverNasSystemSummaries: [DiscoverNasSystemSummary!]! (type)
        [JsonProperty("discoverNasSystemSummaries")]
        public List<DiscoverNasSystemSummary>? DiscoverNasSystemSummaries { get; set; }

        #endregion

    #region methods

    public RefreshNasSystemsReply Set(
        List<DiscoverNasSystemSummary>? DiscoverNasSystemSummaries = null
    ) 
    {
        if ( DiscoverNasSystemSummaries != null ) {
            this.DiscoverNasSystemSummaries = DiscoverNasSystemSummaries;
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
            //      C# -> List<DiscoverNasSystemSummary>? DiscoverNasSystemSummaries
            // GraphQL -> discoverNasSystemSummaries: [DiscoverNasSystemSummary!]! (type)
            if (this.DiscoverNasSystemSummaries != null)
            {
                 s += ind + "discoverNasSystemSummaries\n";

                 s += ind + "{\n" + 
                 this.DiscoverNasSystemSummaries.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<DiscoverNasSystemSummary>? DiscoverNasSystemSummaries
            // GraphQL -> discoverNasSystemSummaries: [DiscoverNasSystemSummary!]! (type)
            if (this.DiscoverNasSystemSummaries == null && Exploration.Includes(parent + ".discoverNasSystemSummaries"))
            {
                this.DiscoverNasSystemSummaries = new List<DiscoverNasSystemSummary>();
                this.DiscoverNasSystemSummaries.ApplyExploratoryFragment(parent + ".discoverNasSystemSummaries");
            }
        }


    #endregion

    } // class RefreshNasSystemsReply
    #endregion

    public static class ListRefreshNasSystemsReplyExtensions
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
            this List<RefreshNasSystemsReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RefreshNasSystemsReply> list, 
            String parent = "")
        {
            var item = new RefreshNasSystemsReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types