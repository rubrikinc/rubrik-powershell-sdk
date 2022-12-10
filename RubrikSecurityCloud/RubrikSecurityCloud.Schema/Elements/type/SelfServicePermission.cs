// SelfServicePermission.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:02.
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
    #region SelfServicePermission
    public class SelfServicePermission: IFragment
    {
        #region members
        //      C# -> InventorySubHierarchyRootEnum? InventoryRoot
        // GraphQL -> inventoryRoot: InventorySubHierarchyRootEnum! (enum)
        [JsonProperty("inventoryRoot")]
        public InventorySubHierarchyRootEnum? InventoryRoot { get; set; }

        //      C# -> WorkloadLevelHierarchy? InventoryWorkloadType
        // GraphQL -> inventoryWorkloadType: WorkloadLevelHierarchy! (enum)
        [JsonProperty("inventoryWorkloadType")]
        public WorkloadLevelHierarchy? InventoryWorkloadType { get; set; }

        //      C# -> List<Operation>? Operations
        // GraphQL -> operations: [Operation!]! (enum)
        [JsonProperty("operations")]
        public List<Operation>? Operations { get; set; }

        #endregion

    #region methods

    public SelfServicePermission Set(
        InventorySubHierarchyRootEnum? InventoryRoot = null,
        WorkloadLevelHierarchy? InventoryWorkloadType = null,
        List<Operation>? Operations = null
    ) 
    {
        if ( InventoryRoot != null ) {
            this.InventoryRoot = InventoryRoot;
        }
        if ( InventoryWorkloadType != null ) {
            this.InventoryWorkloadType = InventoryWorkloadType;
        }
        if ( Operations != null ) {
            this.Operations = Operations;
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
            //      C# -> InventorySubHierarchyRootEnum? InventoryRoot
            // GraphQL -> inventoryRoot: InventorySubHierarchyRootEnum! (enum)
            if (this.InventoryRoot != null)
            {
                 s += ind + "inventoryRoot\n";

            }
            //      C# -> WorkloadLevelHierarchy? InventoryWorkloadType
            // GraphQL -> inventoryWorkloadType: WorkloadLevelHierarchy! (enum)
            if (this.InventoryWorkloadType != null)
            {
                 s += ind + "inventoryWorkloadType\n";

            }
            //      C# -> List<Operation>? Operations
            // GraphQL -> operations: [Operation!]! (enum)
            if (this.Operations != null)
            {
                 s += ind + "operations\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> InventorySubHierarchyRootEnum? InventoryRoot
            // GraphQL -> inventoryRoot: InventorySubHierarchyRootEnum! (enum)
            if (this.InventoryRoot == null && Exploration.Includes(parent + ".inventoryRoot$"))
            {
                this.InventoryRoot = new InventorySubHierarchyRootEnum();
            }
            //      C# -> WorkloadLevelHierarchy? InventoryWorkloadType
            // GraphQL -> inventoryWorkloadType: WorkloadLevelHierarchy! (enum)
            if (this.InventoryWorkloadType == null && Exploration.Includes(parent + ".inventoryWorkloadType$"))
            {
                this.InventoryWorkloadType = new WorkloadLevelHierarchy();
            }
            //      C# -> List<Operation>? Operations
            // GraphQL -> operations: [Operation!]! (enum)
            if (this.Operations == null && Exploration.Includes(parent + ".operations$"))
            {
                this.Operations = new List<Operation>();
            }
        }


    #endregion

    } // class SelfServicePermission
    #endregion

    public static class ListSelfServicePermissionExtensions
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
            this List<SelfServicePermission> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SelfServicePermission> list, 
            String parent = "")
        {
            var item = new SelfServicePermission();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types