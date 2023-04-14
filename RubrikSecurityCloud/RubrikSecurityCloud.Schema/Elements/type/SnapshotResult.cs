// SnapshotResult.cs
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
    #region SnapshotResult
    public class SnapshotResult: IFragment
    {
        #region members
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> System.Int64? SnapshotTime
        // GraphQL -> snapshotTime: Long! (scalar)
        [JsonProperty("snapshotTime")]
        public System.Int64? SnapshotTime { get; set; }

        #endregion

    #region methods

    public SnapshotResult Set(
        System.String? SnapshotFid = null,
        System.Int64? SnapshotTime = null
    ) 
    {
        if ( SnapshotFid != null ) {
            this.SnapshotFid = SnapshotFid;
        }
        if ( SnapshotTime != null ) {
            this.SnapshotTime = SnapshotTime;
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
            //      C# -> System.String? SnapshotFid
            // GraphQL -> snapshotFid: String! (scalar)
            if (this.SnapshotFid != null)
            {
                 s += ind + "snapshotFid\n";

            }
            //      C# -> System.Int64? SnapshotTime
            // GraphQL -> snapshotTime: Long! (scalar)
            if (this.SnapshotTime != null)
            {
                 s += ind + "snapshotTime\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? SnapshotFid
            // GraphQL -> snapshotFid: String! (scalar)
            if (this.SnapshotFid == null && Exploration.Includes(parent + ".snapshotFid$"))
            {
                this.SnapshotFid = new System.String("FETCH");
            }
            //      C# -> System.Int64? SnapshotTime
            // GraphQL -> snapshotTime: Long! (scalar)
            if (this.SnapshotTime == null && Exploration.Includes(parent + ".snapshotTime$"))
            {
                this.SnapshotTime = new System.Int64();
            }
        }


    #endregion

    } // class SnapshotResult
    #endregion

    public static class ListSnapshotResultExtensions
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
            this List<SnapshotResult> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SnapshotResult> list, 
            String parent = "")
        {
            var item = new SnapshotResult();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types