// WorkloadFields.cs
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
    #region WorkloadFields
    public class WorkloadFields: IFragment
    {
        #region members
        //      C# -> O365SnapshotItemInfo? O365Item
        // GraphQL -> o365Item: O365SnapshotItemInfo (type)
        [JsonProperty("o365Item")]
        public O365SnapshotItemInfo? O365Item { get; set; }

        #endregion

    #region methods

    public WorkloadFields Set(
        O365SnapshotItemInfo? O365Item = null
    ) 
    {
        if ( O365Item != null ) {
            this.O365Item = O365Item;
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
            //      C# -> O365SnapshotItemInfo? O365Item
            // GraphQL -> o365Item: O365SnapshotItemInfo (type)
            if (this.O365Item != null)
            {
                 s += ind + "o365Item\n";

                 s += ind + "{\n" + 
                 this.O365Item.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> O365SnapshotItemInfo? O365Item
            // GraphQL -> o365Item: O365SnapshotItemInfo (type)
            if (this.O365Item == null && Exploration.Includes(parent + ".o365Item"))
            {
                this.O365Item = new O365SnapshotItemInfo();
                this.O365Item.ApplyExploratoryFragment(parent + ".o365Item");
            }
        }


    #endregion

    } // class WorkloadFields
    #endregion

    public static class ListWorkloadFieldsExtensions
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
            this List<WorkloadFields> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<WorkloadFields> list, 
            String parent = "")
        {
            var item = new WorkloadFields();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types