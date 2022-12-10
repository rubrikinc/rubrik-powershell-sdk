// HypervScvmmUpdateReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:26.
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
    #region HypervScvmmUpdateReply
    public class HypervScvmmUpdateReply: IFragment
    {
        #region members
        //      C# -> HypervScvmmSummary? HypervScvmmSummary
        // GraphQL -> hypervScvmmSummary: HypervScvmmSummary (type)
        [JsonProperty("hypervScvmmSummary")]
        public HypervScvmmSummary? HypervScvmmSummary { get; set; }

        //      C# -> HypervScvmmUpdate? HypervScvmmUpdate
        // GraphQL -> hypervScvmmUpdate: HypervScvmmUpdate (type)
        [JsonProperty("hypervScvmmUpdate")]
        public HypervScvmmUpdate? HypervScvmmUpdate { get; set; }

        #endregion

    #region methods

    public HypervScvmmUpdateReply Set(
        HypervScvmmSummary? HypervScvmmSummary = null,
        HypervScvmmUpdate? HypervScvmmUpdate = null
    ) 
    {
        if ( HypervScvmmSummary != null ) {
            this.HypervScvmmSummary = HypervScvmmSummary;
        }
        if ( HypervScvmmUpdate != null ) {
            this.HypervScvmmUpdate = HypervScvmmUpdate;
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
            //      C# -> HypervScvmmSummary? HypervScvmmSummary
            // GraphQL -> hypervScvmmSummary: HypervScvmmSummary (type)
            if (this.HypervScvmmSummary != null)
            {
                 s += ind + "hypervScvmmSummary\n";

                 s += ind + "{\n" + 
                 this.HypervScvmmSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> HypervScvmmUpdate? HypervScvmmUpdate
            // GraphQL -> hypervScvmmUpdate: HypervScvmmUpdate (type)
            if (this.HypervScvmmUpdate != null)
            {
                 s += ind + "hypervScvmmUpdate\n";

                 s += ind + "{\n" + 
                 this.HypervScvmmUpdate.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> HypervScvmmSummary? HypervScvmmSummary
            // GraphQL -> hypervScvmmSummary: HypervScvmmSummary (type)
            if (this.HypervScvmmSummary == null && Exploration.Includes(parent + ".hypervScvmmSummary"))
            {
                this.HypervScvmmSummary = new HypervScvmmSummary();
                this.HypervScvmmSummary.ApplyExploratoryFragment(parent + ".hypervScvmmSummary");
            }
            //      C# -> HypervScvmmUpdate? HypervScvmmUpdate
            // GraphQL -> hypervScvmmUpdate: HypervScvmmUpdate (type)
            if (this.HypervScvmmUpdate == null && Exploration.Includes(parent + ".hypervScvmmUpdate"))
            {
                this.HypervScvmmUpdate = new HypervScvmmUpdate();
                this.HypervScvmmUpdate.ApplyExploratoryFragment(parent + ".hypervScvmmUpdate");
            }
        }


    #endregion

    } // class HypervScvmmUpdateReply
    #endregion

    public static class ListHypervScvmmUpdateReplyExtensions
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
            this List<HypervScvmmUpdateReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<HypervScvmmUpdateReply> list, 
            String parent = "")
        {
            var item = new HypervScvmmUpdateReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types