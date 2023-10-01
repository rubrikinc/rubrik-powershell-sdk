// PolicyObjectUsage.cs
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
    #region PolicyObjectUsage
    public class PolicyObjectUsage: BaseType
    {
        #region members

        //      C# -> HierarchyObject? HierarchyObject
        // GraphQL -> hierarchyObject: HierarchyObject! (interface)
        [JsonProperty("hierarchyObject")]
        public HierarchyObject? HierarchyObject { get; set; }

        //      C# -> List<ClassificationPolicySummary>? Policies
        // GraphQL -> policies: [ClassificationPolicySummary!]! (type)
        [JsonProperty("policies")]
        public List<ClassificationPolicySummary>? Policies { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PolicyObjectUsage";
    }

    public PolicyObjectUsage Set(
        HierarchyObject? HierarchyObject = null,
        List<ClassificationPolicySummary>? Policies = null
    ) 
    {
        if ( HierarchyObject != null ) {
            this.HierarchyObject = HierarchyObject;
        }
        if ( Policies != null ) {
            this.Policies = Policies;
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
        //      C# -> HierarchyObject? HierarchyObject
        // GraphQL -> hierarchyObject: HierarchyObject! (interface)
        if (this.HierarchyObject != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.HierarchyObject).AsFieldSpec(conf.Child("hierarchyObject"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hierarchyObject {\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> List<ClassificationPolicySummary>? Policies
        // GraphQL -> policies: [ClassificationPolicySummary!]! (type)
        if (this.Policies != null) {
            var fspec = this.Policies.AsFieldSpec(conf.Child("policies"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "policies {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> HierarchyObject? HierarchyObject
        // GraphQL -> hierarchyObject: HierarchyObject! (interface)
        if (ec.Includes("hierarchyObject",false))
        {
            if(this.HierarchyObject == null) {

                var impls = new List<HierarchyObject>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("hierarchyObject"));
                this.HierarchyObject = (HierarchyObject)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<HierarchyObject>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("hierarchyObject"));
                this.HierarchyObject = (HierarchyObject)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.HierarchyObject != null && ec.Excludes("hierarchyObject",false))
        {
            this.HierarchyObject = null;
        }
        //      C# -> List<ClassificationPolicySummary>? Policies
        // GraphQL -> policies: [ClassificationPolicySummary!]! (type)
        if (ec.Includes("policies",false))
        {
            if(this.Policies == null) {

                this.Policies = new List<ClassificationPolicySummary>();
                this.Policies.ApplyExploratoryFieldSpec(ec.NewChild("policies"));

            } else {

                this.Policies.ApplyExploratoryFieldSpec(ec.NewChild("policies"));

            }
        }
        else if (this.Policies != null && ec.Excludes("policies",false))
        {
            this.Policies = null;
        }
    }


    #endregion

    } // class PolicyObjectUsage
    
    #endregion

    public static class ListPolicyObjectUsageExtensions
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
            this List<PolicyObjectUsage> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<PolicyObjectUsage> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PolicyObjectUsage> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolicyObjectUsage());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PolicyObjectUsage> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types