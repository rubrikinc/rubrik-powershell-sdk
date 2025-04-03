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

        //      C# -> List<TprRulesByObjectType>? TprRulesByObjectType
        // GraphQL -> tprRulesByObjectType: [TprRulesByObjectType!]! (type)
        [JsonProperty("tprRulesByObjectType")]
        public List<TprRulesByObjectType>? TprRulesByObjectType { get; set; }


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
        List<TprRule>? SystemConfigurationGlobal = null,
        List<TprRulesByObjectType>? TprRulesByObjectType = null
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
        if ( TprRulesByObjectType != null ) {
            this.TprRulesByObjectType = TprRulesByObjectType;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<TprRule>? DataManagementByCluster
        // GraphQL -> dataManagementByCluster: [TprRule!]! (enum)
        if (this.DataManagementByCluster != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataManagementByCluster\n" ;
            } else {
                s += ind + "dataManagementByCluster\n" ;
            }
        }
        //      C# -> List<TprRule>? DataManagementByObject
        // GraphQL -> dataManagementByObject: [TprRule!]! (enum)
        if (this.DataManagementByObject != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataManagementByObject\n" ;
            } else {
                s += ind + "dataManagementByObject\n" ;
            }
        }
        //      C# -> List<InventorySubHierarchyRootEnum>? DataManagementByObjectWorkloads
        // GraphQL -> dataManagementByObjectWorkloads: [InventorySubHierarchyRootEnum!]! (enum)
        if (this.DataManagementByObjectWorkloads != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataManagementByObjectWorkloads\n" ;
            } else {
                s += ind + "dataManagementByObjectWorkloads\n" ;
            }
        }
        //      C# -> List<TprRule>? DataManagementBySlaDomain
        // GraphQL -> dataManagementBySlaDomain: [TprRule!]! (enum)
        if (this.DataManagementBySlaDomain != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataManagementBySlaDomain\n" ;
            } else {
                s += ind + "dataManagementBySlaDomain\n" ;
            }
        }
        //      C# -> List<TprRule>? SystemConfigurationCluster
        // GraphQL -> systemConfigurationCluster: [TprRule!]! (enum)
        if (this.SystemConfigurationCluster != null) {
            if (conf.Flat) {
                s += conf.Prefix + "systemConfigurationCluster\n" ;
            } else {
                s += ind + "systemConfigurationCluster\n" ;
            }
        }
        //      C# -> List<TprRule>? SystemConfigurationGlobal
        // GraphQL -> systemConfigurationGlobal: [TprRule!]! (enum)
        if (this.SystemConfigurationGlobal != null) {
            if (conf.Flat) {
                s += conf.Prefix + "systemConfigurationGlobal\n" ;
            } else {
                s += ind + "systemConfigurationGlobal\n" ;
            }
        }
        //      C# -> List<TprRulesByObjectType>? TprRulesByObjectType
        // GraphQL -> tprRulesByObjectType: [TprRulesByObjectType!]! (type)
        if (this.TprRulesByObjectType != null) {
            var fspec = this.TprRulesByObjectType.AsFieldSpec(conf.Child("tprRulesByObjectType"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "tprRulesByObjectType" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<TprRule>? DataManagementByCluster
        // GraphQL -> dataManagementByCluster: [TprRule!]! (enum)
        if (ec.Includes("dataManagementByCluster",true))
        {
            if(this.DataManagementByCluster == null) {

                this.DataManagementByCluster = new List<TprRule>();

            } else {


            }
        }
        else if (this.DataManagementByCluster != null && ec.Excludes("dataManagementByCluster",true))
        {
            this.DataManagementByCluster = null;
        }
        //      C# -> List<TprRule>? DataManagementByObject
        // GraphQL -> dataManagementByObject: [TprRule!]! (enum)
        if (ec.Includes("dataManagementByObject",true))
        {
            if(this.DataManagementByObject == null) {

                this.DataManagementByObject = new List<TprRule>();

            } else {


            }
        }
        else if (this.DataManagementByObject != null && ec.Excludes("dataManagementByObject",true))
        {
            this.DataManagementByObject = null;
        }
        //      C# -> List<InventorySubHierarchyRootEnum>? DataManagementByObjectWorkloads
        // GraphQL -> dataManagementByObjectWorkloads: [InventorySubHierarchyRootEnum!]! (enum)
        if (ec.Includes("dataManagementByObjectWorkloads",true))
        {
            if(this.DataManagementByObjectWorkloads == null) {

                this.DataManagementByObjectWorkloads = new List<InventorySubHierarchyRootEnum>();

            } else {


            }
        }
        else if (this.DataManagementByObjectWorkloads != null && ec.Excludes("dataManagementByObjectWorkloads",true))
        {
            this.DataManagementByObjectWorkloads = null;
        }
        //      C# -> List<TprRule>? DataManagementBySlaDomain
        // GraphQL -> dataManagementBySlaDomain: [TprRule!]! (enum)
        if (ec.Includes("dataManagementBySlaDomain",true))
        {
            if(this.DataManagementBySlaDomain == null) {

                this.DataManagementBySlaDomain = new List<TprRule>();

            } else {


            }
        }
        else if (this.DataManagementBySlaDomain != null && ec.Excludes("dataManagementBySlaDomain",true))
        {
            this.DataManagementBySlaDomain = null;
        }
        //      C# -> List<TprRule>? SystemConfigurationCluster
        // GraphQL -> systemConfigurationCluster: [TprRule!]! (enum)
        if (ec.Includes("systemConfigurationCluster",true))
        {
            if(this.SystemConfigurationCluster == null) {

                this.SystemConfigurationCluster = new List<TprRule>();

            } else {


            }
        }
        else if (this.SystemConfigurationCluster != null && ec.Excludes("systemConfigurationCluster",true))
        {
            this.SystemConfigurationCluster = null;
        }
        //      C# -> List<TprRule>? SystemConfigurationGlobal
        // GraphQL -> systemConfigurationGlobal: [TprRule!]! (enum)
        if (ec.Includes("systemConfigurationGlobal",true))
        {
            if(this.SystemConfigurationGlobal == null) {

                this.SystemConfigurationGlobal = new List<TprRule>();

            } else {


            }
        }
        else if (this.SystemConfigurationGlobal != null && ec.Excludes("systemConfigurationGlobal",true))
        {
            this.SystemConfigurationGlobal = null;
        }
        //      C# -> List<TprRulesByObjectType>? TprRulesByObjectType
        // GraphQL -> tprRulesByObjectType: [TprRulesByObjectType!]! (type)
        if (ec.Includes("tprRulesByObjectType",false))
        {
            if(this.TprRulesByObjectType == null) {

                this.TprRulesByObjectType = new List<TprRulesByObjectType>();
                this.TprRulesByObjectType.ApplyExploratoryFieldSpec(ec.NewChild("tprRulesByObjectType"));

            } else {

                this.TprRulesByObjectType.ApplyExploratoryFieldSpec(ec.NewChild("tprRulesByObjectType"));

            }
        }
        else if (this.TprRulesByObjectType != null && ec.Excludes("tprRulesByObjectType",false))
        {
            this.TprRulesByObjectType = null;
        }
    }


    #endregion

    } // class TprRulesMap
    
    #endregion

    public static class ListTprRulesMapExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<TprRulesMap> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TprRulesMap> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TprRulesMap> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TprRulesMap());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TprRulesMap> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types