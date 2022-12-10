// UpdateHypervVirtualMachineSnapshotMountReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:27.
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
    #region UpdateHypervVirtualMachineSnapshotMountReply
    public class UpdateHypervVirtualMachineSnapshotMountReply: IFragment
    {
        #region members
        //      C# -> HypervVirtualMachineMountSummary? HypervVirtualMachineMountSummary
        // GraphQL -> hypervVirtualMachineMountSummary: HypervVirtualMachineMountSummary (type)
        [JsonProperty("hypervVirtualMachineMountSummary")]
        public HypervVirtualMachineMountSummary? HypervVirtualMachineMountSummary { get; set; }

        #endregion

    #region methods

    public UpdateHypervVirtualMachineSnapshotMountReply Set(
        HypervVirtualMachineMountSummary? HypervVirtualMachineMountSummary = null
    ) 
    {
        if ( HypervVirtualMachineMountSummary != null ) {
            this.HypervVirtualMachineMountSummary = HypervVirtualMachineMountSummary;
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
            //      C# -> HypervVirtualMachineMountSummary? HypervVirtualMachineMountSummary
            // GraphQL -> hypervVirtualMachineMountSummary: HypervVirtualMachineMountSummary (type)
            if (this.HypervVirtualMachineMountSummary != null)
            {
                 s += ind + "hypervVirtualMachineMountSummary\n";

                 s += ind + "{\n" + 
                 this.HypervVirtualMachineMountSummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> HypervVirtualMachineMountSummary? HypervVirtualMachineMountSummary
            // GraphQL -> hypervVirtualMachineMountSummary: HypervVirtualMachineMountSummary (type)
            if (this.HypervVirtualMachineMountSummary == null && Exploration.Includes(parent + ".hypervVirtualMachineMountSummary"))
            {
                this.HypervVirtualMachineMountSummary = new HypervVirtualMachineMountSummary();
                this.HypervVirtualMachineMountSummary.ApplyExploratoryFragment(parent + ".hypervVirtualMachineMountSummary");
            }
        }


    #endregion

    } // class UpdateHypervVirtualMachineSnapshotMountReply
    #endregion

    public static class ListUpdateHypervVirtualMachineSnapshotMountReplyExtensions
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
            this List<UpdateHypervVirtualMachineSnapshotMountReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UpdateHypervVirtualMachineSnapshotMountReply> list, 
            String parent = "")
        {
            var item = new UpdateHypervVirtualMachineSnapshotMountReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types