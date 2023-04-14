// WorkloadIdToSnapshotIds.cs
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
    #region WorkloadIdToSnapshotIds
    public class WorkloadIdToSnapshotIds: IFragment
    {
        #region members
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> List<System.String>? SnapshotIds
        // GraphQL -> snapshotIds: [String!]! (scalar)
        [JsonProperty("snapshotIds")]
        public List<System.String>? SnapshotIds { get; set; }

        //      C# -> List<DateTime>? SnapshotTimestamps
        // GraphQL -> snapshotTimestamps: [DateTime!]! (scalar)
        [JsonProperty("snapshotTimestamps")]
        public List<DateTime>? SnapshotTimestamps { get; set; }

        #endregion

    #region methods

    public WorkloadIdToSnapshotIds Set(
        System.String? ObjectId = null,
        List<System.String>? SnapshotIds = null,
        List<DateTime>? SnapshotTimestamps = null
    ) 
    {
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
        }
        if ( SnapshotIds != null ) {
            this.SnapshotIds = SnapshotIds;
        }
        if ( SnapshotTimestamps != null ) {
            this.SnapshotTimestamps = SnapshotTimestamps;
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
            //      C# -> System.String? ObjectId
            // GraphQL -> objectId: String! (scalar)
            if (this.ObjectId != null)
            {
                 s += ind + "objectId\n";

            }
            //      C# -> List<System.String>? SnapshotIds
            // GraphQL -> snapshotIds: [String!]! (scalar)
            if (this.SnapshotIds != null)
            {
                 s += ind + "snapshotIds\n";

            }
            //      C# -> List<DateTime>? SnapshotTimestamps
            // GraphQL -> snapshotTimestamps: [DateTime!]! (scalar)
            if (this.SnapshotTimestamps != null)
            {
                 s += ind + "snapshotTimestamps\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ObjectId
            // GraphQL -> objectId: String! (scalar)
            if (this.ObjectId == null && Exploration.Includes(parent + ".objectId$"))
            {
                this.ObjectId = new System.String("FETCH");
            }
            //      C# -> List<System.String>? SnapshotIds
            // GraphQL -> snapshotIds: [String!]! (scalar)
            if (this.SnapshotIds == null && Exploration.Includes(parent + ".snapshotIds$"))
            {
                this.SnapshotIds = new List<System.String>();
            }
            //      C# -> List<DateTime>? SnapshotTimestamps
            // GraphQL -> snapshotTimestamps: [DateTime!]! (scalar)
            if (this.SnapshotTimestamps == null && Exploration.Includes(parent + ".snapshotTimestamps$"))
            {
                this.SnapshotTimestamps = new List<DateTime>();
            }
        }


    #endregion

    } // class WorkloadIdToSnapshotIds
    #endregion

    public static class ListWorkloadIdToSnapshotIdsExtensions
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
            this List<WorkloadIdToSnapshotIds> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<WorkloadIdToSnapshotIds> list, 
            String parent = "")
        {
            var item = new WorkloadIdToSnapshotIds();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types