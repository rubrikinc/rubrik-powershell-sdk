// WorkloadScanned.cs
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
    #region WorkloadScanned
    public class WorkloadScanned: IFragment
    {
        #region members
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        [JsonProperty("count")]
        public System.Int64? Count { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> System.String? WorkloadType
        // GraphQL -> workloadType: String! (scalar)
        [JsonProperty("workloadType")]
        public System.String? WorkloadType { get; set; }

        #endregion

    #region methods

    public WorkloadScanned Set(
        System.Int64? Count = null,
        System.String? WorkloadId = null,
        System.String? WorkloadType = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
        }
        if ( WorkloadType != null ) {
            this.WorkloadType = WorkloadType;
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
            //      C# -> System.Int64? Count
            // GraphQL -> count: Long! (scalar)
            if (this.Count != null)
            {
                 s += ind + "count\n";

            }
            //      C# -> System.String? WorkloadId
            // GraphQL -> workloadId: String! (scalar)
            if (this.WorkloadId != null)
            {
                 s += ind + "workloadId\n";

            }
            //      C# -> System.String? WorkloadType
            // GraphQL -> workloadType: String! (scalar)
            if (this.WorkloadType != null)
            {
                 s += ind + "workloadType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? Count
            // GraphQL -> count: Long! (scalar)
            if (this.Count == null && Exploration.Includes(parent + ".count$"))
            {
                this.Count = new System.Int64();
            }
            //      C# -> System.String? WorkloadId
            // GraphQL -> workloadId: String! (scalar)
            if (this.WorkloadId == null && Exploration.Includes(parent + ".workloadId$"))
            {
                this.WorkloadId = new System.String("FETCH");
            }
            //      C# -> System.String? WorkloadType
            // GraphQL -> workloadType: String! (scalar)
            if (this.WorkloadType == null && Exploration.Includes(parent + ".workloadType$"))
            {
                this.WorkloadType = new System.String("FETCH");
            }
        }


    #endregion

    } // class WorkloadScanned
    #endregion

    public static class ListWorkloadScannedExtensions
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
            this List<WorkloadScanned> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<WorkloadScanned> list, 
            String parent = "")
        {
            var item = new WorkloadScanned();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types