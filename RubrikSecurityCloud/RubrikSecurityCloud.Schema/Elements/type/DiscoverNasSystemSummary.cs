// DiscoverNasSystemSummary.cs
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
    #region DiscoverNasSystemSummary
    public class DiscoverNasSystemSummary: IFragment
    {
        #region members
        //      C# -> System.String? NasSystemId
        // GraphQL -> nasSystemId: String! (scalar)
        [JsonProperty("nasSystemId")]
        public System.String? NasSystemId { get; set; }

        //      C# -> AsyncRequestStatus? NasDiscoverJobStatus
        // GraphQL -> nasDiscoverJobStatus: AsyncRequestStatus (type)
        [JsonProperty("nasDiscoverJobStatus")]
        public AsyncRequestStatus? NasDiscoverJobStatus { get; set; }

        #endregion

    #region methods

    public DiscoverNasSystemSummary Set(
        System.String? NasSystemId = null,
        AsyncRequestStatus? NasDiscoverJobStatus = null
    ) 
    {
        if ( NasSystemId != null ) {
            this.NasSystemId = NasSystemId;
        }
        if ( NasDiscoverJobStatus != null ) {
            this.NasDiscoverJobStatus = NasDiscoverJobStatus;
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
            //      C# -> System.String? NasSystemId
            // GraphQL -> nasSystemId: String! (scalar)
            if (this.NasSystemId != null)
            {
                 s += ind + "nasSystemId\n";

            }
            //      C# -> AsyncRequestStatus? NasDiscoverJobStatus
            // GraphQL -> nasDiscoverJobStatus: AsyncRequestStatus (type)
            if (this.NasDiscoverJobStatus != null)
            {
                 s += ind + "nasDiscoverJobStatus\n";

                 s += ind + "{\n" + 
                 this.NasDiscoverJobStatus.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? NasSystemId
            // GraphQL -> nasSystemId: String! (scalar)
            if (this.NasSystemId == null && Exploration.Includes(parent + ".nasSystemId$"))
            {
                this.NasSystemId = new System.String("FETCH");
            }
            //      C# -> AsyncRequestStatus? NasDiscoverJobStatus
            // GraphQL -> nasDiscoverJobStatus: AsyncRequestStatus (type)
            if (this.NasDiscoverJobStatus == null && Exploration.Includes(parent + ".nasDiscoverJobStatus"))
            {
                this.NasDiscoverJobStatus = new AsyncRequestStatus();
                this.NasDiscoverJobStatus.ApplyExploratoryFragment(parent + ".nasDiscoverJobStatus");
            }
        }


    #endregion

    } // class DiscoverNasSystemSummary
    #endregion

    public static class ListDiscoverNasSystemSummaryExtensions
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
            this List<DiscoverNasSystemSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<DiscoverNasSystemSummary> list, 
            String parent = "")
        {
            var item = new DiscoverNasSystemSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types