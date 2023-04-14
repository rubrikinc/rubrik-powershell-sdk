// PolarisSpecificSnapshot.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region PolarisSpecificSnapshot
    public interface PolarisSpecificSnapshot: IFragment
    {
        #region members
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [JsonProperty("snapshotId")]
        System.String? SnapshotId { get; set; }

        #endregion

    } // class PolarisSpecificSnapshot
    #endregion

    public static class ListPolarisSpecificSnapshotExtensions
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
            this List<PolarisSpecificSnapshot> list,
            int indent=0)
        {
            string fragments = "";
            foreach (PolarisSpecificSnapshot item in list) 
            {
                string typename = item.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);

                fragments += String.Format("... on {0}\n", typename);

                fragments += "{\n" +
                item.AsFragment(indent+1) +
                "}\n";
            }
            return fragments;
        }

        public static void ApplyExploratoryFragment(
            this List<PolarisSpecificSnapshot> list, 
            String parent = "")
        {
            var item = (PolarisSpecificSnapshot)InterfaceHelper.CreateInstanceOfFirstType(typeof(PolarisSpecificSnapshot));
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types