// EndManagedVolumeSnapshotReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:29.
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
    #region EndManagedVolumeSnapshotReply
    public class EndManagedVolumeSnapshotReply: IFragment
    {
        #region members
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        [JsonProperty("asyncRequestStatus")]
        public AsyncRequestStatus? AsyncRequestStatus { get; set; }

        //      C# -> ManagedVolumeSnapshotSummary? ManagedVolumeSnapshotSummary
        // GraphQL -> managedVolumeSnapshotSummary: ManagedVolumeSnapshotSummary (type)
        [JsonProperty("managedVolumeSnapshotSummary")]
        public ManagedVolumeSnapshotSummary? ManagedVolumeSnapshotSummary { get; set; }

        #endregion

    #region methods

    public EndManagedVolumeSnapshotReply Set(
        AsyncRequestStatus? AsyncRequestStatus = null,
        ManagedVolumeSnapshotSummary? ManagedVolumeSnapshotSummary = null
    ) 
    {
        if ( AsyncRequestStatus != null ) {
            this.AsyncRequestStatus = AsyncRequestStatus;
        }
        if ( ManagedVolumeSnapshotSummary != null ) {
            this.ManagedVolumeSnapshotSummary = ManagedVolumeSnapshotSummary;
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
            //      C# -> ManagedVolumeSnapshotSummary? ManagedVolumeSnapshotSummary
            // GraphQL -> managedVolumeSnapshotSummary: ManagedVolumeSnapshotSummary (type)
            if (this.ManagedVolumeSnapshotSummary != null)
            {
                 s += ind + "managedVolumeSnapshotSummary\n";

                 s += ind + "{\n" + 
                 this.ManagedVolumeSnapshotSummary.AsFragment(indent+1) + 
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
            //      C# -> ManagedVolumeSnapshotSummary? ManagedVolumeSnapshotSummary
            // GraphQL -> managedVolumeSnapshotSummary: ManagedVolumeSnapshotSummary (type)
            if (this.ManagedVolumeSnapshotSummary == null && Exploration.Includes(parent + ".managedVolumeSnapshotSummary"))
            {
                this.ManagedVolumeSnapshotSummary = new ManagedVolumeSnapshotSummary();
                this.ManagedVolumeSnapshotSummary.ApplyExploratoryFragment(parent + ".managedVolumeSnapshotSummary");
            }
        }


    #endregion

    } // class EndManagedVolumeSnapshotReply
    #endregion

    public static class ListEndManagedVolumeSnapshotReplyExtensions
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
            this List<EndManagedVolumeSnapshotReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<EndManagedVolumeSnapshotReply> list, 
            String parent = "")
        {
            var item = new EndManagedVolumeSnapshotReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types