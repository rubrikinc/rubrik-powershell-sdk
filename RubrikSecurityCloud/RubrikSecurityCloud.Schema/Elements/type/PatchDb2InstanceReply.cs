// PatchDb2InstanceReply.cs
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
    #region PatchDb2InstanceReply
    public class PatchDb2InstanceReply: IFragment
    {
        #region members
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        [JsonProperty("asyncRequestStatus")]
        public AsyncRequestStatus? AsyncRequestStatus { get; set; }

        //      C# -> Db2InstanceSummary? Db2InstanceSummary
        // GraphQL -> db2InstanceSummary: Db2InstanceSummary (type)
        [JsonProperty("db2InstanceSummary")]
        public Db2InstanceSummary? Db2InstanceSummary { get; set; }

        #endregion

    #region methods

    public PatchDb2InstanceReply Set(
        AsyncRequestStatus? AsyncRequestStatus = null,
        Db2InstanceSummary? Db2InstanceSummary = null
    ) 
    {
        if ( AsyncRequestStatus != null ) {
            this.AsyncRequestStatus = AsyncRequestStatus;
        }
        if ( Db2InstanceSummary != null ) {
            this.Db2InstanceSummary = Db2InstanceSummary;
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
            //      C# -> Db2InstanceSummary? Db2InstanceSummary
            // GraphQL -> db2InstanceSummary: Db2InstanceSummary (type)
            if (this.Db2InstanceSummary != null)
            {
                 s += ind + "db2InstanceSummary\n";

                 s += ind + "{\n" + 
                 this.Db2InstanceSummary.AsFragment(indent+1) + 
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
            //      C# -> Db2InstanceSummary? Db2InstanceSummary
            // GraphQL -> db2InstanceSummary: Db2InstanceSummary (type)
            if (this.Db2InstanceSummary == null && Exploration.Includes(parent + ".db2InstanceSummary"))
            {
                this.Db2InstanceSummary = new Db2InstanceSummary();
                this.Db2InstanceSummary.ApplyExploratoryFragment(parent + ".db2InstanceSummary");
            }
        }


    #endregion

    } // class PatchDb2InstanceReply
    #endregion

    public static class ListPatchDb2InstanceReplyExtensions
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
            this List<PatchDb2InstanceReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PatchDb2InstanceReply> list, 
            String parent = "")
        {
            var item = new PatchDb2InstanceReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types