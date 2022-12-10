// PatchSapHanaSystemReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:39.
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
    #region PatchSapHanaSystemReply
    public class PatchSapHanaSystemReply: IFragment
    {
        #region members
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        [JsonProperty("asyncRequestStatus")]
        public AsyncRequestStatus? AsyncRequestStatus { get; set; }

        //      C# -> SapHanaSystemSummary? SystemSummary
        // GraphQL -> systemSummary: SapHanaSystemSummary (type)
        [JsonProperty("systemSummary")]
        public SapHanaSystemSummary? SystemSummary { get; set; }

        #endregion

    #region methods

    public PatchSapHanaSystemReply Set(
        AsyncRequestStatus? AsyncRequestStatus = null,
        SapHanaSystemSummary? SystemSummary = null
    ) 
    {
        if ( AsyncRequestStatus != null ) {
            this.AsyncRequestStatus = AsyncRequestStatus;
        }
        if ( SystemSummary != null ) {
            this.SystemSummary = SystemSummary;
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
            //      C# -> AsyncRequestStatus? AsyncRequestStatus
            // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
            if (this.AsyncRequestStatus != null)
            {
                 s += ind + "asyncRequestStatus\n";

                 s += ind + "{\n" + 
                 this.AsyncRequestStatus.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SapHanaSystemSummary? SystemSummary
            // GraphQL -> systemSummary: SapHanaSystemSummary (type)
            if (this.SystemSummary != null)
            {
                 s += ind + "systemSummary\n";

                 s += ind + "{\n" + 
                 this.SystemSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> AsyncRequestStatus? AsyncRequestStatus
            // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
            if (this.AsyncRequestStatus == null && Exploration.Includes(parent + ".asyncRequestStatus"))
            {
                this.AsyncRequestStatus = new AsyncRequestStatus();
                this.AsyncRequestStatus.ApplyExploratoryFragment(parent + ".asyncRequestStatus");
            }
            //      C# -> SapHanaSystemSummary? SystemSummary
            // GraphQL -> systemSummary: SapHanaSystemSummary (type)
            if (this.SystemSummary == null && Exploration.Includes(parent + ".systemSummary"))
            {
                this.SystemSummary = new SapHanaSystemSummary();
                this.SystemSummary.ApplyExploratoryFragment(parent + ".systemSummary");
            }
        }


    #endregion

    } // class PatchSapHanaSystemReply
    #endregion

    public static class ListPatchSapHanaSystemReplyExtensions
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
            this List<PatchSapHanaSystemReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PatchSapHanaSystemReply> list, 
            String parent = "")
        {
            var item = new PatchSapHanaSystemReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types