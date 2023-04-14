// TakeOnDemandSnapshotReply.cs
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
    #region TakeOnDemandSnapshotReply
    public class TakeOnDemandSnapshotReply: IFragment
    {
        #region members
        //      C# -> List<TakeOnDemandSnapshotError>? Errors
        // GraphQL -> errors: [TakeOnDemandSnapshotError!]! (type)
        [JsonProperty("errors")]
        public List<TakeOnDemandSnapshotError>? Errors { get; set; }

        //      C# -> List<TakeOnDemandSnapshotTaskchainUuid>? TaskchainUuids
        // GraphQL -> taskchainUuids: [TakeOnDemandSnapshotTaskchainUuid!]! (type)
        [JsonProperty("taskchainUuids")]
        public List<TakeOnDemandSnapshotTaskchainUuid>? TaskchainUuids { get; set; }

        #endregion

    #region methods

    public TakeOnDemandSnapshotReply Set(
        List<TakeOnDemandSnapshotError>? Errors = null,
        List<TakeOnDemandSnapshotTaskchainUuid>? TaskchainUuids = null
    ) 
    {
        if ( Errors != null ) {
            this.Errors = Errors;
        }
        if ( TaskchainUuids != null ) {
            this.TaskchainUuids = TaskchainUuids;
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
            //      C# -> List<TakeOnDemandSnapshotError>? Errors
            // GraphQL -> errors: [TakeOnDemandSnapshotError!]! (type)
            if (this.Errors != null)
            {
                 s += ind + "errors\n";

                 s += ind + "{\n" + 
                 this.Errors.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<TakeOnDemandSnapshotTaskchainUuid>? TaskchainUuids
            // GraphQL -> taskchainUuids: [TakeOnDemandSnapshotTaskchainUuid!]! (type)
            if (this.TaskchainUuids != null)
            {
                 s += ind + "taskchainUuids\n";

                 s += ind + "{\n" + 
                 this.TaskchainUuids.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<TakeOnDemandSnapshotError>? Errors
            // GraphQL -> errors: [TakeOnDemandSnapshotError!]! (type)
            if (this.Errors == null && Exploration.Includes(parent + ".errors"))
            {
                this.Errors = new List<TakeOnDemandSnapshotError>();
                this.Errors.ApplyExploratoryFragment(parent + ".errors");
            }
            //      C# -> List<TakeOnDemandSnapshotTaskchainUuid>? TaskchainUuids
            // GraphQL -> taskchainUuids: [TakeOnDemandSnapshotTaskchainUuid!]! (type)
            if (this.TaskchainUuids == null && Exploration.Includes(parent + ".taskchainUuids"))
            {
                this.TaskchainUuids = new List<TakeOnDemandSnapshotTaskchainUuid>();
                this.TaskchainUuids.ApplyExploratoryFragment(parent + ".taskchainUuids");
            }
        }


    #endregion

    } // class TakeOnDemandSnapshotReply
    #endregion

    public static class ListTakeOnDemandSnapshotReplyExtensions
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
            this List<TakeOnDemandSnapshotReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<TakeOnDemandSnapshotReply> list, 
            String parent = "")
        {
            var item = new TakeOnDemandSnapshotReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types