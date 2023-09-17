// SelfServicePermission.cs
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
    #region SelfServicePermission
    public class SelfServicePermission: BaseType
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

        //      C# -> System.String? HierarchyRoot
        // GraphQL -> hierarchyRoot: String! (scalar)
        [JsonProperty("hierarchyRoot")]
        public System.String? HierarchyRoot { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SelfServicePermission";
    }

    public SelfServicePermission Set(
        InventorySubHierarchyRootEnum? InventoryRoot = null,
        WorkloadLevelHierarchy? InventoryWorkloadType = null,
        List<Operation>? Operations = null,
        System.String? HierarchyRoot = null
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
        if ( HierarchyRoot != null ) {
            this.HierarchyRoot = HierarchyRoot;
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
        //      C# -> InventorySubHierarchyRootEnum? InventoryRoot
        // GraphQL -> inventoryRoot: InventorySubHierarchyRootEnum! (enum)
        if (this.InventoryRoot != null) {
            s += ind + "inventoryRoot\n" ;
        }
        //      C# -> WorkloadLevelHierarchy? InventoryWorkloadType
        // GraphQL -> inventoryWorkloadType: WorkloadLevelHierarchy! (enum)
        if (this.InventoryWorkloadType != null) {
            s += ind + "inventoryWorkloadType\n" ;
        }
        //      C# -> List<Operation>? Operations
        // GraphQL -> operations: [Operation!]! (enum)
        if (this.Operations != null) {
            s += ind + "operations\n" ;
        }
        //      C# -> System.String? HierarchyRoot
        // GraphQL -> hierarchyRoot: String! (scalar)
        if (this.HierarchyRoot != null) {
            s += ind + "hierarchyRoot\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> InventorySubHierarchyRootEnum? InventoryRoot
        // GraphQL -> inventoryRoot: InventorySubHierarchyRootEnum! (enum)
        if (this.InventoryRoot == null && ec.Includes("inventoryRoot",true))
        {
            this.InventoryRoot = new InventorySubHierarchyRootEnum();
        }
        //      C# -> WorkloadLevelHierarchy? InventoryWorkloadType
        // GraphQL -> inventoryWorkloadType: WorkloadLevelHierarchy! (enum)
        if (this.InventoryWorkloadType == null && ec.Includes("inventoryWorkloadType",true))
        {
            this.InventoryWorkloadType = new WorkloadLevelHierarchy();
        }
        //      C# -> List<Operation>? Operations
        // GraphQL -> operations: [Operation!]! (enum)
        if (this.Operations == null && ec.Includes("operations",true))
        {
            this.Operations = new List<Operation>();
        }
        //      C# -> System.String? HierarchyRoot
        // GraphQL -> hierarchyRoot: String! (scalar)
        if (this.HierarchyRoot == null && ec.Includes("hierarchyRoot",true))
        {
            this.HierarchyRoot = "FETCH";
        }
    }


    #endregion

    } // class SelfServicePermission
    
    #endregion

    public static class ListSelfServicePermissionExtensions
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
            this List<SelfServicePermission> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SelfServicePermission> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SelfServicePermission());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SelfServicePermission> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types