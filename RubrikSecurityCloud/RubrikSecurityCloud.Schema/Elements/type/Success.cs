// Success.cs
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
    #region Success
    public class Success: IFragment
    {
        #region members
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: String! (scalar)
        [JsonProperty("taskchainId")]
        public System.String? TaskchainId { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        #endregion

    #region methods

    public Success Set(
        System.String? TaskchainId = null,
        System.String? WorkloadId = null
    ) 
    {
        if ( TaskchainId != null ) {
            this.TaskchainId = TaskchainId;
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
            //      C# -> System.String? TaskchainId
            // GraphQL -> taskchainId: String! (scalar)
            if (this.TaskchainId != null)
            {
                 s += ind + "taskchainId\n";

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
            //      C# -> System.String? TaskchainId
            // GraphQL -> taskchainId: String! (scalar)
            if (this.TaskchainId == null && Exploration.Includes(parent + ".taskchainId$"))
            {
                this.TaskchainId = new System.String("FETCH");
            }
            //      C# -> System.String? WorkloadId
            // GraphQL -> workloadId: UUID! (scalar)
            if (this.WorkloadId == null && Exploration.Includes(parent + ".workloadId$"))
            {
                this.WorkloadId = new System.String("FETCH");
            }
        }


    #endregion

    } // class Success
    #endregion

    public static class ListSuccessExtensions
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
            this List<Success> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Success> list, 
            String parent = "")
        {
            var item = new Success();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types