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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region InventorySubHierarchyRoot
    public class InventorySubHierarchyRoot: BaseType
    {
        #region members

        //      C# -> InventorySubHierarchyRootEnum? RootEnum
        // GraphQL -> rootEnum: InventorySubHierarchyRootEnum! (enum)
        [JsonProperty("rootEnum")]
        public InventorySubHierarchyRootEnum? RootEnum { get; set; }

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "InventorySubHierarchyRoot";
    }

    public InventorySubHierarchyRoot Set(
        InventorySubHierarchyRootEnum? RootEnum = null,
        HierarchyObjectConnection? ChildConnection = null,
        HierarchyObjectConnection? DescendantConnection = null,
        HierarchyObjectConnection? TopLevelDescendantConnection = null
    ) 
    {
        if ( RootEnum != null ) {
            this.RootEnum = RootEnum;
        }
        if ( ChildConnection != null ) {
            this.ChildConnection = ChildConnection;
        }
        if ( DescendantConnection != null ) {
            this.DescendantConnection = DescendantConnection;
        }
        if ( TopLevelDescendantConnection != null ) {
            this.TopLevelDescendantConnection = TopLevelDescendantConnection;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> InventorySubHierarchyRootEnum? RootEnum
        // GraphQL -> rootEnum: InventorySubHierarchyRootEnum! (enum)
        if (this.RootEnum != null) {
            s += ind + "rootEnum\n" ;
        }
        //      C# -> HierarchyObjectConnection? ChildConnection
        // GraphQL -> childConnection: HierarchyObjectConnection! (type)
        if (this.ChildConnection != null) {
            var fspec = this.ChildConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "childConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> HierarchyObjectConnection? DescendantConnection
        // GraphQL -> descendantConnection: HierarchyObjectConnection! (type)
        if (this.DescendantConnection != null) {
            var fspec = this.DescendantConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "descendantConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> HierarchyObjectConnection? TopLevelDescendantConnection
        // GraphQL -> topLevelDescendantConnection: HierarchyObjectConnection! (type)
        if (this.TopLevelDescendantConnection != null) {
            var fspec = this.TopLevelDescendantConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "topLevelDescendantConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> InventorySubHierarchyRootEnum? RootEnum
        // GraphQL -> rootEnum: InventorySubHierarchyRootEnum! (enum)
        if (this.RootEnum == null && ec.Includes("rootEnum",true))
        {
            this.RootEnum = new InventorySubHierarchyRootEnum();
        }
        //      C# -> HierarchyObjectConnection? ChildConnection
        // GraphQL -> childConnection: HierarchyObjectConnection! (type)
        if (this.ChildConnection == null && ec.Includes("childConnection",false))
        {
            this.ChildConnection = new HierarchyObjectConnection();
            this.ChildConnection.ApplyExploratoryFieldSpec(ec.NewChild("childConnection"));
        }
        //      C# -> HierarchyObjectConnection? DescendantConnection
        // GraphQL -> descendantConnection: HierarchyObjectConnection! (type)
        if (this.DescendantConnection == null && ec.Includes("descendantConnection",false))
        {
            this.DescendantConnection = new HierarchyObjectConnection();
            this.DescendantConnection.ApplyExploratoryFieldSpec(ec.NewChild("descendantConnection"));
        }
        //      C# -> HierarchyObjectConnection? TopLevelDescendantConnection
        // GraphQL -> topLevelDescendantConnection: HierarchyObjectConnection! (type)
        if (this.TopLevelDescendantConnection == null && ec.Includes("topLevelDescendantConnection",false))
        {
            this.TopLevelDescendantConnection = new HierarchyObjectConnection();
            this.TopLevelDescendantConnection.ApplyExploratoryFieldSpec(ec.NewChild("topLevelDescendantConnection"));
        }
    }


    #endregion

    } // class InventorySubHierarchyRoot
    
    #endregion

    public static class ListInventorySubHierarchyRootExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<InventorySubHierarchyRoot> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<InventorySubHierarchyRoot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new InventorySubHierarchyRoot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<InventorySubHierarchyRoot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types