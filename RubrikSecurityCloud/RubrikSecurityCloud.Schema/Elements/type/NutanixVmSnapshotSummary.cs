// NutanixVmSnapshotSummary.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:50.
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
    #region NutanixVmSnapshotSummary
    public class NutanixVmSnapshotSummary: IFragment
    {
        #region members
        //      C# -> System.Int32? NicsInSnapshot
        // GraphQL -> nicsInSnapshot: Int (scalar)
        [JsonProperty("nicsInSnapshot")]
        public System.Int32? NicsInSnapshot { get; set; }

        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        [JsonProperty("vmName")]
        public System.String? VmName { get; set; }

        //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
        // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
        [JsonProperty("baseSnapshotSummary")]
        public BaseSnapshotSummary? BaseSnapshotSummary { get; set; }

        #endregion

    #region methods

    public NutanixVmSnapshotSummary Set(
        System.Int32? NicsInSnapshot = null,
        System.String? VmName = null,
        BaseSnapshotSummary? BaseSnapshotSummary = null
    ) 
    {
        if ( NicsInSnapshot != null ) {
            this.NicsInSnapshot = NicsInSnapshot;
        }
        if ( VmName != null ) {
            this.VmName = VmName;
        }
        if ( BaseSnapshotSummary != null ) {
            this.BaseSnapshotSummary = BaseSnapshotSummary;
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
            //      C# -> System.Int32? NicsInSnapshot
            // GraphQL -> nicsInSnapshot: Int (scalar)
            if (this.NicsInSnapshot != null)
            {
                 s += ind + "nicsInSnapshot\n";

            }
            //      C# -> System.String? VmName
            // GraphQL -> vmName: String! (scalar)
            if (this.VmName != null)
            {
                 s += ind + "vmName\n";

            }
            //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
            // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
            if (this.BaseSnapshotSummary != null)
            {
                 s += ind + "baseSnapshotSummary\n";

                 s += ind + "{\n" + 
                 this.BaseSnapshotSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? NicsInSnapshot
            // GraphQL -> nicsInSnapshot: Int (scalar)
            if (this.NicsInSnapshot == null && Exploration.Includes(parent + ".nicsInSnapshot$"))
            {
                this.NicsInSnapshot = new System.Int32();
            }
            //      C# -> System.String? VmName
            // GraphQL -> vmName: String! (scalar)
            if (this.VmName == null && Exploration.Includes(parent + ".vmName$"))
            {
                this.VmName = new System.String("FETCH");
            }
            //      C# -> BaseSnapshotSummary? BaseSnapshotSummary
            // GraphQL -> baseSnapshotSummary: BaseSnapshotSummary (type)
            if (this.BaseSnapshotSummary == null && Exploration.Includes(parent + ".baseSnapshotSummary"))
            {
                this.BaseSnapshotSummary = new BaseSnapshotSummary();
                this.BaseSnapshotSummary.ApplyExploratoryFragment(parent + ".baseSnapshotSummary");
            }
        }


    #endregion

    } // class NutanixVmSnapshotSummary
    #endregion

    public static class ListNutanixVmSnapshotSummaryExtensions
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
            this List<NutanixVmSnapshotSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NutanixVmSnapshotSummary> list, 
            String parent = "")
        {
            var item = new NutanixVmSnapshotSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types