// TakeOnDemandSnapshotTaskchainUuid.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:43.
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
    #region TakeOnDemandSnapshotTaskchainUuid
    public class TakeOnDemandSnapshotTaskchainUuid: IFragment
    {
        #region members
        //      C# -> System.String? TaskchainUuid
        // GraphQL -> taskchainUuid: UUID! (scalar)
        [JsonProperty("taskchainUuid")]
        public System.String? TaskchainUuid { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        #endregion

    #region methods

    public TakeOnDemandSnapshotTaskchainUuid Set(
        System.String? TaskchainUuid = null,
        System.String? WorkloadId = null
    ) 
    {
        if ( TaskchainUuid != null ) {
            this.TaskchainUuid = TaskchainUuid;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
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
            //      C# -> System.String? TaskchainUuid
            // GraphQL -> taskchainUuid: UUID! (scalar)
            if (this.TaskchainUuid != null)
            {
                 s += ind + "taskchainUuid\n";

            }
            //      C# -> System.String? WorkloadId
            // GraphQL -> workloadId: UUID! (scalar)
            if (this.WorkloadId != null)
            {
                 s += ind + "workloadId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? TaskchainUuid
            // GraphQL -> taskchainUuid: UUID! (scalar)
            if (this.TaskchainUuid == null && Exploration.Includes(parent + ".taskchainUuid$"))
            {
                this.TaskchainUuid = new System.String("FETCH");
            }
            //      C# -> System.String? WorkloadId
            // GraphQL -> workloadId: UUID! (scalar)
            if (this.WorkloadId == null && Exploration.Includes(parent + ".workloadId$"))
            {
                this.WorkloadId = new System.String("FETCH");
            }
        }


    #endregion

    } // class TakeOnDemandSnapshotTaskchainUuid
    #endregion

    public static class ListTakeOnDemandSnapshotTaskchainUuidExtensions
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
            this List<TakeOnDemandSnapshotTaskchainUuid> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<TakeOnDemandSnapshotTaskchainUuid> list, 
            String parent = "")
        {
            var item = new TakeOnDemandSnapshotTaskchainUuid();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types