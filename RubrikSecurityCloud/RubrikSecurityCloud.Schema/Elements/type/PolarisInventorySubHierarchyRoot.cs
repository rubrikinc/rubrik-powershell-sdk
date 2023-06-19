// PolarisInventorySubHierarchyRoot.cs
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
    #region PolarisInventorySubHierarchyRoot
    public class PolarisInventorySubHierarchyRoot: BaseType
    {
        #region members

        //      C# -> InventorySubHierarchyRootEnum? RootEnum
        // GraphQL -> rootEnum: InventorySubHierarchyRootEnum! (enum)
        [JsonProperty("rootEnum")]
        public InventorySubHierarchyRootEnum? RootEnum { get; set; }

        //      C# -> PolarisHierarchyObjectConnection? ChildConnection
        // GraphQL -> childConnection: PolarisHierarchyObjectConnection! (type)
        [JsonProperty("childConnection")]
        public PolarisHierarchyObjectConnection? ChildConnection { get; set; }

        //      C# -> PolarisHierarchyObjectConnection? DescendantConnection
        // GraphQL -> descendantConnection: PolarisHierarchyObjectConnection! (type)
        [JsonProperty("descendantConnection")]
        public PolarisHierarchyObjectConnection? DescendantConnection { get; set; }

        //      C# -> PolarisHierarchyObjectConnection? TopLevelDescendantConnection
        // GraphQL -> topLevelDescendantConnection: PolarisHierarchyObjectConnection! (type)
        [JsonProperty("topLevelDescendantConnection")]
        public PolarisHierarchyObjectConnection? TopLevelDescendantConnection { get; set; }


        #endregion

    #region methods

    public PolarisInventorySubHierarchyRoot Set(
        InventorySubHierarchyRootEnum? RootEnum = null,
        PolarisHierarchyObjectConnection? ChildConnection = null,
        PolarisHierarchyObjectConnection? DescendantConnection = null,
        PolarisHierarchyObjectConnection? TopLevelDescendantConnection = null
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
        //      C# -> PolarisHierarchyObjectConnection? ChildConnection
        // GraphQL -> childConnection: PolarisHierarchyObjectConnection! (type)
        if (this.ChildConnection != null) {
            var fspec = this.ChildConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "childConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PolarisHierarchyObjectConnection? DescendantConnection
        // GraphQL -> descendantConnection: PolarisHierarchyObjectConnection! (type)
        if (this.DescendantConnection != null) {
            var fspec = this.DescendantConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "descendantConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PolarisHierarchyObjectConnection? TopLevelDescendantConnection
        // GraphQL -> topLevelDescendantConnection: PolarisHierarchyObjectConnection! (type)
        if (this.TopLevelDescendantConnection != null) {
            var fspec = this.TopLevelDescendantConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "topLevelDescendantConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> InventorySubHierarchyRootEnum? RootEnum
        // GraphQL -> rootEnum: InventorySubHierarchyRootEnum! (enum)
        if (this.RootEnum == null && Exploration.Includes(parent + ".rootEnum", true))
        {
            this.RootEnum = new InventorySubHierarchyRootEnum();
        }
        //      C# -> PolarisHierarchyObjectConnection? ChildConnection
        // GraphQL -> childConnection: PolarisHierarchyObjectConnection! (type)
        if (this.ChildConnection == null && Exploration.Includes(parent + ".childConnection"))
        {
            this.ChildConnection = new PolarisHierarchyObjectConnection();
            this.ChildConnection.ApplyExploratoryFieldSpec(parent + ".childConnection");
        }
        //      C# -> PolarisHierarchyObjectConnection? DescendantConnection
        // GraphQL -> descendantConnection: PolarisHierarchyObjectConnection! (type)
        if (this.DescendantConnection == null && Exploration.Includes(parent + ".descendantConnection"))
        {
            this.DescendantConnection = new PolarisHierarchyObjectConnection();
            this.DescendantConnection.ApplyExploratoryFieldSpec(parent + ".descendantConnection");
        }
        //      C# -> PolarisHierarchyObjectConnection? TopLevelDescendantConnection
        // GraphQL -> topLevelDescendantConnection: PolarisHierarchyObjectConnection! (type)
        if (this.TopLevelDescendantConnection == null && Exploration.Includes(parent + ".topLevelDescendantConnection"))
        {
            this.TopLevelDescendantConnection = new PolarisHierarchyObjectConnection();
            this.TopLevelDescendantConnection.ApplyExploratoryFieldSpec(parent + ".topLevelDescendantConnection");
        }
    }


    #endregion

    } // class PolarisInventorySubHierarchyRoot
    
    #endregion

    public static class ListPolarisInventorySubHierarchyRootExtensions
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
            this List<PolarisInventorySubHierarchyRoot> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PolarisInventorySubHierarchyRoot> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PolarisInventorySubHierarchyRoot());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types