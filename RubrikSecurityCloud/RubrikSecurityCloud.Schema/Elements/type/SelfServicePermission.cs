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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> InventorySubHierarchyRootEnum? InventoryRoot
        // GraphQL -> inventoryRoot: InventorySubHierarchyRootEnum! (enum)
        if (this.InventoryRoot == null && Exploration.Includes(parent + ".inventoryRoot", true))
        {
            this.InventoryRoot = new InventorySubHierarchyRootEnum();
        }
        //      C# -> WorkloadLevelHierarchy? InventoryWorkloadType
        // GraphQL -> inventoryWorkloadType: WorkloadLevelHierarchy! (enum)
        if (this.InventoryWorkloadType == null && Exploration.Includes(parent + ".inventoryWorkloadType", true))
        {
            this.InventoryWorkloadType = new WorkloadLevelHierarchy();
        }
        //      C# -> List<Operation>? Operations
        // GraphQL -> operations: [Operation!]! (enum)
        if (this.Operations == null && Exploration.Includes(parent + ".operations", true))
        {
            this.Operations = new List<Operation>();
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SelfServicePermission> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SelfServicePermission());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types