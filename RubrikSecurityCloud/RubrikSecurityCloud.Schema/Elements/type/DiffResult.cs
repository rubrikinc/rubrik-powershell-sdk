// DiffResult.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:38.
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
    #region DiffResult
    public class DiffResult: IFragment
    {
        #region members
        //      C# -> System.Int64? PreviousSnapshotDate
        // GraphQL -> previousSnapshotDate: Long! (scalar)
        [JsonProperty("previousSnapshotDate")]
        public System.Int64? PreviousSnapshotDate { get; set; }

        //      C# -> System.String? PreviousSnapshotId
        // GraphQL -> previousSnapshotId: String! (scalar)
        [JsonProperty("previousSnapshotId")]
        public System.String? PreviousSnapshotId { get; set; }

        //      C# -> List<DiffData>? Data
        // GraphQL -> data: [DiffData!]! (type)
        [JsonProperty("data")]
        public List<DiffData>? Data { get; set; }

        #endregion

    #region methods

    public DiffResult Set(
        System.Int64? PreviousSnapshotDate = null,
        System.String? PreviousSnapshotId = null,
        List<DiffData>? Data = null
    ) 
    {
        if ( PreviousSnapshotDate != null ) {
            this.PreviousSnapshotDate = PreviousSnapshotDate;
        }
        if ( PreviousSnapshotId != null ) {
            this.PreviousSnapshotId = PreviousSnapshotId;
        }
        if ( Data != null ) {
            this.Data = Data;
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
            //      C# -> System.Int64? PreviousSnapshotDate
            // GraphQL -> previousSnapshotDate: Long! (scalar)
            if (this.PreviousSnapshotDate != null)
            {
                 s += ind + "previousSnapshotDate\n";

            }
            //      C# -> System.String? PreviousSnapshotId
            // GraphQL -> previousSnapshotId: String! (scalar)
            if (this.PreviousSnapshotId != null)
            {
                 s += ind + "previousSnapshotId\n";

            }
            //      C# -> List<DiffData>? Data
            // GraphQL -> data: [DiffData!]! (type)
            if (this.Data != null)
            {
                 s += ind + "data\n";

                 s += ind + "{\n" + 
                 this.Data.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? PreviousSnapshotDate
            // GraphQL -> previousSnapshotDate: Long! (scalar)
            if (this.PreviousSnapshotDate == null && Exploration.Includes(parent + ".previousSnapshotDate$"))
            {
                this.PreviousSnapshotDate = new System.Int64();
            }
            //      C# -> System.String? PreviousSnapshotId
            // GraphQL -> previousSnapshotId: String! (scalar)
            if (this.PreviousSnapshotId == null && Exploration.Includes(parent + ".previousSnapshotId$"))
            {
                this.PreviousSnapshotId = new System.String("FETCH");
            }
            //      C# -> List<DiffData>? Data
            // GraphQL -> data: [DiffData!]! (type)
            if (this.Data == null && Exploration.Includes(parent + ".data"))
            {
                this.Data = new List<DiffData>();
                this.Data.ApplyExploratoryFragment(parent + ".data");
            }
        }


    #endregion

    } // class DiffResult
    #endregion

    public static class ListDiffResultExtensions
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
            this List<DiffResult> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<DiffResult> list, 
            String parent = "")
        {
            var item = new DiffResult();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types