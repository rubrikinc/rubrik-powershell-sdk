// Microsoft365RansomwareInvestigationEnablement.cs
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
    #region Microsoft365RansomwareInvestigationEnablement
    public class Microsoft365RansomwareInvestigationEnablement: BaseType
    {
        #region members

        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        [JsonProperty("enabled")]
        public System.Boolean? Enabled { get; set; }

        //      C# -> HierarchyObjectCommon? Subscription
        // GraphQL -> subscription: HierarchyObjectCommon! (type)
        [JsonProperty("subscription")]
        public HierarchyObjectCommon? Subscription { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Microsoft365RansomwareInvestigationEnablement";
    }

    public Microsoft365RansomwareInvestigationEnablement Set(
        System.Boolean? Enabled = null,
        HierarchyObjectCommon? Subscription = null
    ) 
    {
        if ( Enabled != null ) {
            this.Enabled = Enabled;
        }
        if ( Subscription != null ) {
            this.Subscription = Subscription;
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
        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        if (this.Enabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enabled\n" ;
            } else {
                s += ind + "enabled\n" ;
            }
        }
        //      C# -> HierarchyObjectCommon? Subscription
        // GraphQL -> subscription: HierarchyObjectCommon! (type)
        if (this.Subscription != null) {
            var fspec = this.Subscription.AsFieldSpec(conf.Child("subscription"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "subscription {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        if (ec.Includes("enabled",true))
        {
            if(this.Enabled == null) {

                this.Enabled = true;

            } else {


            }
        }
        else if (this.Enabled != null && ec.Excludes("enabled",true))
        {
            this.Enabled = null;
        }
        //      C# -> HierarchyObjectCommon? Subscription
        // GraphQL -> subscription: HierarchyObjectCommon! (type)
        if (ec.Includes("subscription",false))
        {
            if(this.Subscription == null) {

                this.Subscription = new HierarchyObjectCommon();
                this.Subscription.ApplyExploratoryFieldSpec(ec.NewChild("subscription"));

            } else {

                this.Subscription.ApplyExploratoryFieldSpec(ec.NewChild("subscription"));

            }
        }
        else if (this.Subscription != null && ec.Excludes("subscription",false))
        {
            this.Subscription = null;
        }
    }


    #endregion

    } // class Microsoft365RansomwareInvestigationEnablement
    
    #endregion

    public static class ListMicrosoft365RansomwareInvestigationEnablementExtensions
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
            this List<Microsoft365RansomwareInvestigationEnablement> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<Microsoft365RansomwareInvestigationEnablement> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Microsoft365RansomwareInvestigationEnablement> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Microsoft365RansomwareInvestigationEnablement());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Microsoft365RansomwareInvestigationEnablement> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types