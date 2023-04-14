// InventorySubHierarchyRoot.cs
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
    #region InventorySubHierarchyRoot
    public class InventorySubHierarchyRoot: IFragment
    {
        #region members
        //      C# -> HierarchyObjectConnection? ChildConnection
        // GraphQL -> childConnection: HierarchyObjectConnection! (type)
        [JsonProperty("childConnection")]
        public HierarchyObjectConnection? ChildConnection { get; set; }

        //      C# -> HierarchyObjectConnection? DescendantConnection
        // GraphQL -> descendantConnection: HierarchyObjectConnection! (type)
        [JsonProperty("descendantConnection")]
        public HierarchyObjectConnection? DescendantConnection { get; set; }

        //      C# -> HierarchyObjectConnection? TopLevelDescendantConnection
        // GraphQL -> topLevelDescendantConnection: HierarchyObjectConnection! (type)
        [JsonProperty("topLevelDescendantConnection")]
        public HierarchyObjectConnection? TopLevelDescendantConnection { get; set; }

        //      C# -> InventorySubHierarchyRootEnum? RootEnum
        // GraphQL -> rootEnum: InventorySubHierarchyRootEnum! (enum)
        [JsonProperty("rootEnum")]
        public InventorySubHierarchyRootEnum? RootEnum { get; set; }

        #endregion

    #region methods

    public InventorySubHierarchyRoot Set(
        HierarchyObjectConnection? ChildConnection = null,
        HierarchyObjectConnection? DescendantConnection = null,
        HierarchyObjectConnection? TopLevelDescendantConnection = null,
        InventorySubHierarchyRootEnum? RootEnum = null
    ) 
    {
        if ( ChildConnection != null ) {
            this.ChildConnection = ChildConnection;
        }
        if ( DescendantConnection != null ) {
            this.DescendantConnection = DescendantConnection;
        }
        if ( TopLevelDescendantConnection != null ) {
            this.TopLevelDescendantConnection = TopLevelDescendantConnection;
        }
        if ( RootEnum != null ) {
            this.RootEnum = RootEnum;
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
            //      C# -> HierarchyObjectConnection? ChildConnection
            // GraphQL -> childConnection: HierarchyObjectConnection! (type)
            if (this.ChildConnection != null)
            {
                 s += ind + "childConnection\n";

                 s += ind + "{\n" + 
                 this.ChildConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> HierarchyObjectConnection? DescendantConnection
            // GraphQL -> descendantConnection: HierarchyObjectConnection! (type)
            if (this.DescendantConnection != null)
            {
                 s += ind + "descendantConnection\n";

                 s += ind + "{\n" + 
                 this.DescendantConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> HierarchyObjectConnection? TopLevelDescendantConnection
            // GraphQL -> topLevelDescendantConnection: HierarchyObjectConnection! (type)
            if (this.TopLevelDescendantConnection != null)
            {
                 s += ind + "topLevelDescendantConnection\n";

                 s += ind + "{\n" + 
                 this.TopLevelDescendantConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> InventorySubHierarchyRootEnum? RootEnum
            // GraphQL -> rootEnum: InventorySubHierarchyRootEnum! (enum)
            if (this.RootEnum != null)
            {
                 s += ind + "rootEnum\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> HierarchyObjectConnection? ChildConnection
            // GraphQL -> childConnection: HierarchyObjectConnection! (type)
            if (this.ChildConnection == null && Exploration.Includes(parent + ".childConnection"))
            {
                this.ChildConnection = new HierarchyObjectConnection();
                this.ChildConnection.ApplyExploratoryFragment(parent + ".childConnection");
            }
            //      C# -> HierarchyObjectConnection? DescendantConnection
            // GraphQL -> descendantConnection: HierarchyObjectConnection! (type)
            if (this.DescendantConnection == null && Exploration.Includes(parent + ".descendantConnection"))
            {
                this.DescendantConnection = new HierarchyObjectConnection();
                this.DescendantConnection.ApplyExploratoryFragment(parent + ".descendantConnection");
            }
            //      C# -> HierarchyObjectConnection? TopLevelDescendantConnection
            // GraphQL -> topLevelDescendantConnection: HierarchyObjectConnection! (type)
            if (this.TopLevelDescendantConnection == null && Exploration.Includes(parent + ".topLevelDescendantConnection"))
            {
                this.TopLevelDescendantConnection = new HierarchyObjectConnection();
                this.TopLevelDescendantConnection.ApplyExploratoryFragment(parent + ".topLevelDescendantConnection");
            }
            //      C# -> InventorySubHierarchyRootEnum? RootEnum
            // GraphQL -> rootEnum: InventorySubHierarchyRootEnum! (enum)
            if (this.RootEnum == null && Exploration.Includes(parent + ".rootEnum$"))
            {
                this.RootEnum = new InventorySubHierarchyRootEnum();
            }
        }


    #endregion

    } // class InventorySubHierarchyRoot
    #endregion

    public static class ListInventorySubHierarchyRootExtensions
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
            this List<InventorySubHierarchyRoot> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<InventorySubHierarchyRoot> list, 
            String parent = "")
        {
            var item = new InventorySubHierarchyRoot();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types