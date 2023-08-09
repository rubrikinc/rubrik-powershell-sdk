// TprRulesMap.cs
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
    #region TprRulesMap
    public class TprRulesMap: BaseType
    {
        #region members

        //      C# -> List<TprRule>? DataManagementByCluster
        // GraphQL -> dataManagementByCluster: [TprRule!]! (enum)
        [JsonProperty("dataManagementByCluster")]
        public List<TprRule>? DataManagementByCluster { get; set; }

        //      C# -> List<TprRule>? DataManagementByObject
        // GraphQL -> dataManagementByObject: [TprRule!]! (enum)
        [JsonProperty("dataManagementByObject")]
        public List<TprRule>? DataManagementByObject { get; set; }

        //      C# -> List<InventorySubHierarchyRootEnum>? DataManagementByObjectWorkloads
        // GraphQL -> dataManagementByObjectWorkloads: [InventorySubHierarchyRootEnum!]! (enum)
        [JsonProperty("dataManagementByObjectWorkloads")]
        public List<InventorySubHierarchyRootEnum>? DataManagementByObjectWorkloads { get; set; }

        //      C# -> List<TprRule>? DataManagementBySlaDomain
        // GraphQL -> dataManagementBySlaDomain: [TprRule!]! (enum)
        [JsonProperty("dataManagementBySlaDomain")]
        public List<TprRule>? DataManagementBySlaDomain { get; set; }

        //      C# -> List<TprRule>? SystemConfigurationCluster
        // GraphQL -> systemConfigurationCluster: [TprRule!]! (enum)
        [JsonProperty("systemConfigurationCluster")]
        public List<TprRule>? SystemConfigurationCluster { get; set; }

        //      C# -> List<TprRule>? SystemConfigurationGlobal
        // GraphQL -> systemConfigurationGlobal: [TprRule!]! (enum)
        [JsonProperty("systemConfigurationGlobal")]
        public List<TprRule>? SystemConfigurationGlobal { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprRulesMap";
    }

    public TprRulesMap Set(
        List<TprRule>? DataManagementByCluster = null,
        List<TprRule>? DataManagementByObject = null,
        List<InventorySubHierarchyRootEnum>? DataManagementByObjectWorkloads = null,
        List<TprRule>? DataManagementBySlaDomain = null,
        List<TprRule>? SystemConfigurationCluster = null,
        List<TprRule>? SystemConfigurationGlobal = null
    ) 
    {
        if ( DataManagementByCluster != null ) {
            this.DataManagementByCluster = DataManagementByCluster;
        }
        if ( DataManagementByObject != null ) {
            this.DataManagementByObject = DataManagementByObject;
        }
        if ( DataManagementByObjectWorkloads != null ) {
            this.DataManagementByObjectWorkloads = DataManagementByObjectWorkloads;
        }
        if ( DataManagementBySlaDomain != null ) {
            this.DataManagementBySlaDomain = DataManagementBySlaDomain;
        }
        if ( SystemConfigurationCluster != null ) {
            this.SystemConfigurationCluster = SystemConfigurationCluster;
        }
        if ( SystemConfigurationGlobal != null ) {
            this.SystemConfigurationGlobal = SystemConfigurationGlobal;
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
        //      C# -> List<TprRule>? DataManagementByCluster
        // GraphQL -> dataManagementByCluster: [TprRule!]! (enum)
        if (this.DataManagementByCluster != null) {
            s += ind + "dataManagementByCluster\n" ;
        }
        //      C# -> List<TprRule>? DataManagementByObject
        // GraphQL -> dataManagementByObject: [TprRule!]! (enum)
        if (this.DataManagementByObject != null) {
            s += ind + "dataManagementByObject\n" ;
        }
        //      C# -> List<InventorySubHierarchyRootEnum>? DataManagementByObjectWorkloads
        // GraphQL -> dataManagementByObjectWorkloads: [InventorySubHierarchyRootEnum!]! (enum)
        if (this.DataManagementByObjectWorkloads != null) {
            s += ind + "dataManagementByObjectWorkloads\n" ;
        }
        //      C# -> List<TprRule>? DataManagementBySlaDomain
        // GraphQL -> dataManagementBySlaDomain: [TprRule!]! (enum)
        if (this.DataManagementBySlaDomain != null) {
            s += ind + "dataManagementBySlaDomain\n" ;
        }
        //      C# -> List<TprRule>? SystemConfigurationCluster
        // GraphQL -> systemConfigurationCluster: [TprRule!]! (enum)
        if (this.SystemConfigurationCluster != null) {
            s += ind + "systemConfigurationCluster\n" ;
        }
        //      C# -> List<TprRule>? SystemConfigurationGlobal
        // GraphQL -> systemConfigurationGlobal: [TprRule!]! (enum)
        if (this.SystemConfigurationGlobal != null) {
            s += ind + "systemConfigurationGlobal\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<TprRule>? DataManagementByCluster
        // GraphQL -> dataManagementByCluster: [TprRule!]! (enum)
        if (this.DataManagementByCluster == null && Exploration.Includes(parent + ".dataManagementByCluster", true))
        {
            this.DataManagementByCluster = new List<TprRule>();
        }
        //      C# -> List<TprRule>? DataManagementByObject
        // GraphQL -> dataManagementByObject: [TprRule!]! (enum)
        if (this.DataManagementByObject == null && Exploration.Includes(parent + ".dataManagementByObject", true))
        {
            this.DataManagementByObject = new List<TprRule>();
        }
        //      C# -> List<InventorySubHierarchyRootEnum>? DataManagementByObjectWorkloads
        // GraphQL -> dataManagementByObjectWorkloads: [InventorySubHierarchyRootEnum!]! (enum)
        if (this.DataManagementByObjectWorkloads == null && Exploration.Includes(parent + ".dataManagementByObjectWorkloads", true))
        {
            this.DataManagementByObjectWorkloads = new List<InventorySubHierarchyRootEnum>();
        }
        //      C# -> List<TprRule>? DataManagementBySlaDomain
        // GraphQL -> dataManagementBySlaDomain: [TprRule!]! (enum)
        if (this.DataManagementBySlaDomain == null && Exploration.Includes(parent + ".dataManagementBySlaDomain", true))
        {
            this.DataManagementBySlaDomain = new List<TprRule>();
        }
        //      C# -> List<TprRule>? SystemConfigurationCluster
        // GraphQL -> systemConfigurationCluster: [TprRule!]! (enum)
        if (this.SystemConfigurationCluster == null && Exploration.Includes(parent + ".systemConfigurationCluster", true))
        {
            this.SystemConfigurationCluster = new List<TprRule>();
        }
        //      C# -> List<TprRule>? SystemConfigurationGlobal
        // GraphQL -> systemConfigurationGlobal: [TprRule!]! (enum)
        if (this.SystemConfigurationGlobal == null && Exploration.Includes(parent + ".systemConfigurationGlobal", true))
        {
            this.SystemConfigurationGlobal = new List<TprRule>();
        }
    }


    #endregion

    } // class TprRulesMap
    
    #endregion

    public static class ListTprRulesMapExtensions
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
            this List<TprRulesMap> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TprRulesMap> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new TprRulesMap());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types