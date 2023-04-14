// BeginManagedVolumeSnapshotReply.cs
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
    #region BeginManagedVolumeSnapshotReply
    public class BeginManagedVolumeSnapshotReply: IFragment
    {
        #region members
        //      C# -> System.String? OwnerId
        // GraphQL -> ownerId: String (scalar)
        [JsonProperty("ownerId")]
        public System.String? OwnerId { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        [JsonProperty("asyncRequestStatus")]
        public AsyncRequestStatus? AsyncRequestStatus { get; set; }

        #endregion

    #region methods

    public BeginManagedVolumeSnapshotReply Set(
        System.String? OwnerId = null,
        System.String? SnapshotId = null,
        AsyncRequestStatus? AsyncRequestStatus = null
    ) 
    {
        if ( OwnerId != null ) {
            this.OwnerId = OwnerId;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( AsyncRequestStatus != null ) {
            this.AsyncRequestStatus = AsyncRequestStatus;
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
            //      C# -> System.String? OwnerId
            // GraphQL -> ownerId: String (scalar)
            if (this.OwnerId != null)
            {
                 s += ind + "ownerId\n";

            }
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: String! (scalar)
            if (this.SnapshotId != null)
            {
                 s += ind + "snapshotId\n";

            }
            //      C# -> AsyncRequestStatus? AsyncRequestStatus
            // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
            if (this.AsyncRequestStatus != null)
            {
                 s += ind + "asyncRequestStatus\n";

                 s += ind + "{\n" + 
                 this.AsyncRequestStatus.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? OwnerId
            // GraphQL -> ownerId: String (scalar)
            if (this.OwnerId == null && Exploration.Includes(parent + ".ownerId$"))
            {
                this.OwnerId = new System.String("FETCH");
            }
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: String! (scalar)
            if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId$"))
            {
                this.SnapshotId = new System.String("FETCH");
            }
            //      C# -> AsyncRequestStatus? AsyncRequestStatus
            // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
            if (this.AsyncRequestStatus == null && Exploration.Includes(parent + ".asyncRequestStatus"))
            {
                this.AsyncRequestStatus = new AsyncRequestStatus();
                this.AsyncRequestStatus.ApplyExploratoryFragment(parent + ".asyncRequestStatus");
            }
        }


    #endregion

    } // class BeginManagedVolumeSnapshotReply
    #endregion

    public static class ListBeginManagedVolumeSnapshotReplyExtensions
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
            this List<BeginManagedVolumeSnapshotReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<BeginManagedVolumeSnapshotReply> list, 
            String parent = "")
        {
            var item = new BeginManagedVolumeSnapshotReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types