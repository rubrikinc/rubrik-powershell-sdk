// AllRcvAccountEntitlements.cs
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
    #region AllRcvAccountEntitlements
    public class AllRcvAccountEntitlements: BaseType
    {
        #region members

        //      C# -> List<RcvEntitlementWithOrderNumber>? Entitlements
        // GraphQL -> entitlements: [RcvEntitlementWithOrderNumber!] (type)
        [JsonProperty("entitlements")]
        public List<RcvEntitlementWithOrderNumber>? Entitlements { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AllRcvAccountEntitlements";
    }

    public AllRcvAccountEntitlements Set(
        List<RcvEntitlementWithOrderNumber>? Entitlements = null
    ) 
    {
        if ( Entitlements != null ) {
            this.Entitlements = Entitlements;
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
        //      C# -> List<RcvEntitlementWithOrderNumber>? Entitlements
        // GraphQL -> entitlements: [RcvEntitlementWithOrderNumber!] (type)
        if (this.Entitlements != null) {
            var fspec = this.Entitlements.AsFieldSpec(conf.Child("entitlements"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "entitlements {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<RcvEntitlementWithOrderNumber>? Entitlements
        // GraphQL -> entitlements: [RcvEntitlementWithOrderNumber!] (type)
        if (ec.Includes("entitlements",false))
        {
            if(this.Entitlements == null) {

                this.Entitlements = new List<RcvEntitlementWithOrderNumber>();
                this.Entitlements.ApplyExploratoryFieldSpec(ec.NewChild("entitlements"));

            } else {

                this.Entitlements.ApplyExploratoryFieldSpec(ec.NewChild("entitlements"));

            }
        }
        else if (this.Entitlements != null && ec.Excludes("entitlements",false))
        {
            this.Entitlements = null;
        }
    }


    #endregion

    } // class AllRcvAccountEntitlements
    
    #endregion

    public static class ListAllRcvAccountEntitlementsExtensions
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
            this List<AllRcvAccountEntitlements> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AllRcvAccountEntitlements> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AllRcvAccountEntitlements> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AllRcvAccountEntitlements());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AllRcvAccountEntitlements> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types