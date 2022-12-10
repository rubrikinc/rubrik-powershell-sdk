// RegisterNasSystemReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:34.
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
    #region RegisterNasSystemReply
    public class RegisterNasSystemReply: IFragment
    {
        #region members
        //      C# -> AsyncRequestStatus? NasDiscoverJobStatus
        // GraphQL -> nasDiscoverJobStatus: AsyncRequestStatus (type)
        [JsonProperty("nasDiscoverJobStatus")]
        public AsyncRequestStatus? NasDiscoverJobStatus { get; set; }

        //      C# -> UpdateNasSystemReply? NasSystemSummary
        // GraphQL -> nasSystemSummary: UpdateNasSystemReply (type)
        [JsonProperty("nasSystemSummary")]
        public UpdateNasSystemReply? NasSystemSummary { get; set; }

        #endregion

    #region methods

    public RegisterNasSystemReply Set(
        AsyncRequestStatus? NasDiscoverJobStatus = null,
        UpdateNasSystemReply? NasSystemSummary = null
    ) 
    {
        if ( NasDiscoverJobStatus != null ) {
            this.NasDiscoverJobStatus = NasDiscoverJobStatus;
        }
        if ( NasSystemSummary != null ) {
            this.NasSystemSummary = NasSystemSummary;
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
            //      C# -> AsyncRequestStatus? NasDiscoverJobStatus
            // GraphQL -> nasDiscoverJobStatus: AsyncRequestStatus (type)
            if (this.NasDiscoverJobStatus != null)
            {
                 s += ind + "nasDiscoverJobStatus\n";

                 s += ind + "{\n" + 
                 this.NasDiscoverJobStatus.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> UpdateNasSystemReply? NasSystemSummary
            // GraphQL -> nasSystemSummary: UpdateNasSystemReply (type)
            if (this.NasSystemSummary != null)
            {
                 s += ind + "nasSystemSummary\n";

                 s += ind + "{\n" + 
                 this.NasSystemSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> AsyncRequestStatus? NasDiscoverJobStatus
            // GraphQL -> nasDiscoverJobStatus: AsyncRequestStatus (type)
            if (this.NasDiscoverJobStatus == null && Exploration.Includes(parent + ".nasDiscoverJobStatus"))
            {
                this.NasDiscoverJobStatus = new AsyncRequestStatus();
                this.NasDiscoverJobStatus.ApplyExploratoryFragment(parent + ".nasDiscoverJobStatus");
            }
            //      C# -> UpdateNasSystemReply? NasSystemSummary
            // GraphQL -> nasSystemSummary: UpdateNasSystemReply (type)
            if (this.NasSystemSummary == null && Exploration.Includes(parent + ".nasSystemSummary"))
            {
                this.NasSystemSummary = new UpdateNasSystemReply();
                this.NasSystemSummary.ApplyExploratoryFragment(parent + ".nasSystemSummary");
            }
        }


    #endregion

    } // class RegisterNasSystemReply
    #endregion

    public static class ListRegisterNasSystemReplyExtensions
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
            this List<RegisterNasSystemReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RegisterNasSystemReply> list, 
            String parent = "")
        {
            var item = new RegisterNasSystemReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types