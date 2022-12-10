// ObjectStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:28.
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
    #region ObjectStatus
    public class ObjectStatus: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> SnapshotResult? LatestSnapshotResult
        // GraphQL -> latestSnapshotResult: SnapshotResult (type)
        [JsonProperty("latestSnapshotResult")]
        public SnapshotResult? LatestSnapshotResult { get; set; }

        //      C# -> List<PolicyStatus>? PolicyStatuses
        // GraphQL -> policyStatuses: [PolicyStatus!]! (type)
        [JsonProperty("policyStatuses")]
        public List<PolicyStatus>? PolicyStatuses { get; set; }

        #endregion

    #region methods

    public ObjectStatus Set(
        System.String? Id = null,
        SnapshotResult? LatestSnapshotResult = null,
        List<PolicyStatus>? PolicyStatuses = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LatestSnapshotResult != null ) {
            this.LatestSnapshotResult = LatestSnapshotResult;
        }
        if ( PolicyStatuses != null ) {
            this.PolicyStatuses = PolicyStatuses;
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
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> SnapshotResult? LatestSnapshotResult
            // GraphQL -> latestSnapshotResult: SnapshotResult (type)
            if (this.LatestSnapshotResult != null)
            {
                 s += ind + "latestSnapshotResult\n";

                 s += ind + "{\n" + 
                 this.LatestSnapshotResult.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<PolicyStatus>? PolicyStatuses
            // GraphQL -> policyStatuses: [PolicyStatus!]! (type)
            if (this.PolicyStatuses != null)
            {
                 s += ind + "policyStatuses\n";

                 s += ind + "{\n" + 
                 this.PolicyStatuses.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> SnapshotResult? LatestSnapshotResult
            // GraphQL -> latestSnapshotResult: SnapshotResult (type)
            if (this.LatestSnapshotResult == null && Exploration.Includes(parent + ".latestSnapshotResult"))
            {
                this.LatestSnapshotResult = new SnapshotResult();
                this.LatestSnapshotResult.ApplyExploratoryFragment(parent + ".latestSnapshotResult");
            }
            //      C# -> List<PolicyStatus>? PolicyStatuses
            // GraphQL -> policyStatuses: [PolicyStatus!]! (type)
            if (this.PolicyStatuses == null && Exploration.Includes(parent + ".policyStatuses"))
            {
                this.PolicyStatuses = new List<PolicyStatus>();
                this.PolicyStatuses.ApplyExploratoryFragment(parent + ".policyStatuses");
            }
        }


    #endregion

    } // class ObjectStatus
    #endregion

    public static class ListObjectStatusExtensions
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
            this List<ObjectStatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ObjectStatus> list, 
            String parent = "")
        {
            var item = new ObjectStatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types