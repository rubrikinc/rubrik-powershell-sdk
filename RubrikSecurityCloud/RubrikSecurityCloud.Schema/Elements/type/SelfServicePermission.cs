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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> InventorySubHierarchyRootEnum? InventoryRoot
        // GraphQL -> inventoryRoot: InventorySubHierarchyRootEnum! (enum)
        if (this.InventoryRoot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "inventoryRoot\n" ;
            } else {
                s += ind + "inventoryRoot\n" ;
            }
        }
        //      C# -> WorkloadLevelHierarchy? InventoryWorkloadType
        // GraphQL -> inventoryWorkloadType: WorkloadLevelHierarchy! (enum)
        if (this.InventoryWorkloadType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "inventoryWorkloadType\n" ;
            } else {
                s += ind + "inventoryWorkloadType\n" ;
            }
        }
        //      C# -> List<Operation>? Operations
        // GraphQL -> operations: [Operation!]! (enum)
        if (this.Operations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "operations\n" ;
            } else {
                s += ind + "operations\n" ;
            }
        }
        //      C# -> System.String? HierarchyRoot
        // GraphQL -> hierarchyRoot: String! (scalar)
        if (this.HierarchyRoot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hierarchyRoot\n" ;
            } else {
                s += ind + "hierarchyRoot\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> InventorySubHierarchyRootEnum? InventoryRoot
        // GraphQL -> inventoryRoot: InventorySubHierarchyRootEnum! (enum)
        if (ec.Includes("inventoryRoot",true))
        {
            if(this.InventoryRoot == null) {

                this.InventoryRoot = new InventorySubHierarchyRootEnum();

            } else {


            }
        }
        else if (this.InventoryRoot != null && ec.Excludes("inventoryRoot",true))
        {
            this.InventoryRoot = null;
        }
        //      C# -> WorkloadLevelHierarchy? InventoryWorkloadType
        // GraphQL -> inventoryWorkloadType: WorkloadLevelHierarchy! (enum)
        if (ec.Includes("inventoryWorkloadType",true))
        {
            if(this.InventoryWorkloadType == null) {

                this.InventoryWorkloadType = new WorkloadLevelHierarchy();

            } else {


            }
        }
        else if (this.InventoryWorkloadType != null && ec.Excludes("inventoryWorkloadType",true))
        {
            this.InventoryWorkloadType = null;
        }
        //      C# -> List<Operation>? Operations
        // GraphQL -> operations: [Operation!]! (enum)
        if (ec.Includes("operations",true))
        {
            if(this.Operations == null) {

                this.Operations = new List<Operation>();

            } else {


            }
        }
        else if (this.Operations != null && ec.Excludes("operations",true))
        {
            this.Operations = null;
        }
        //      C# -> System.String? HierarchyRoot
        // GraphQL -> hierarchyRoot: String! (scalar)
        if (ec.Includes("hierarchyRoot",true))
        {
            if(this.HierarchyRoot == null) {

                this.HierarchyRoot = "FETCH";

            } else {


            }
        }
        else if (this.HierarchyRoot != null && ec.Excludes("hierarchyRoot",true))
        {
            this.HierarchyRoot = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<SelfServicePermission> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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