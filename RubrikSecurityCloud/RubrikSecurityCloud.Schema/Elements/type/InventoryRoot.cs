// InventoryRoot.cs
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
    #region InventoryRoot
    public class InventoryRoot: BaseType
    {
        #region members

        //      C# -> HierarchyObjectConnection? DescendantConnection
        // GraphQL -> descendantConnection: HierarchyObjectConnection! (type)
        [JsonProperty("descendantConnection")]
        public HierarchyObjectConnection? DescendantConnection { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "InventoryRoot";
    }

    public InventoryRoot Set(
        HierarchyObjectConnection? DescendantConnection = null
    ) 
    {
        if ( DescendantConnection != null ) {
            this.DescendantConnection = DescendantConnection;
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
        //      C# -> HierarchyObjectConnection? DescendantConnection
        // GraphQL -> descendantConnection: HierarchyObjectConnection! (type)
        if (this.DescendantConnection != null) {
            var fspec = this.DescendantConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "descendantConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> HierarchyObjectConnection? DescendantConnection
        // GraphQL -> descendantConnection: HierarchyObjectConnection! (type)
        if (this.DescendantConnection == null && ec.Includes("descendantConnection",false))
        {
            this.DescendantConnection = new HierarchyObjectConnection();
            this.DescendantConnection.ApplyExploratoryFieldSpec(ec.NewChild("descendantConnection"));
        }
    }


    #endregion

    } // class InventoryRoot
    
    #endregion

    public static class ListInventoryRootExtensions
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
            this List<InventoryRoot> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<InventoryRoot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new InventoryRoot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<InventoryRoot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types