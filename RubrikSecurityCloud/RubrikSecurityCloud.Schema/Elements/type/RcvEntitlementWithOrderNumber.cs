// RcvEntitlementWithOrderNumber.cs
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
    #region RcvEntitlementWithOrderNumber
    public class RcvEntitlementWithOrderNumber: BaseType
    {
        #region members

        //      C# -> System.String? OrderNumber
        // GraphQL -> orderNumber: String! (scalar)
        [JsonProperty("orderNumber")]
        public System.String? OrderNumber { get; set; }

        //      C# -> RcvEntitlementWithExpirationDate? Entitlement
        // GraphQL -> entitlement: RcvEntitlementWithExpirationDate (type)
        [JsonProperty("entitlement")]
        public RcvEntitlementWithExpirationDate? Entitlement { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RcvEntitlementWithOrderNumber";
    }

    public RcvEntitlementWithOrderNumber Set(
        System.String? OrderNumber = null,
        RcvEntitlementWithExpirationDate? Entitlement = null
    ) 
    {
        if ( OrderNumber != null ) {
            this.OrderNumber = OrderNumber;
        }
        if ( Entitlement != null ) {
            this.Entitlement = Entitlement;
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
        //      C# -> System.String? OrderNumber
        // GraphQL -> orderNumber: String! (scalar)
        if (this.OrderNumber != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orderNumber\n" ;
            } else {
                s += ind + "orderNumber\n" ;
            }
        }
        //      C# -> RcvEntitlementWithExpirationDate? Entitlement
        // GraphQL -> entitlement: RcvEntitlementWithExpirationDate (type)
        if (this.Entitlement != null) {
            var fspec = this.Entitlement.AsFieldSpec(conf.Child("entitlement"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "entitlement {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? OrderNumber
        // GraphQL -> orderNumber: String! (scalar)
        if (ec.Includes("orderNumber",true))
        {
            if(this.OrderNumber == null) {

                this.OrderNumber = "FETCH";

            } else {


            }
        }
        else if (this.OrderNumber != null && ec.Excludes("orderNumber",true))
        {
            this.OrderNumber = null;
        }
        //      C# -> RcvEntitlementWithExpirationDate? Entitlement
        // GraphQL -> entitlement: RcvEntitlementWithExpirationDate (type)
        if (ec.Includes("entitlement",false))
        {
            if(this.Entitlement == null) {

                this.Entitlement = new RcvEntitlementWithExpirationDate();
                this.Entitlement.ApplyExploratoryFieldSpec(ec.NewChild("entitlement"));

            } else {

                this.Entitlement.ApplyExploratoryFieldSpec(ec.NewChild("entitlement"));

            }
        }
        else if (this.Entitlement != null && ec.Excludes("entitlement",false))
        {
            this.Entitlement = null;
        }
    }


    #endregion

    } // class RcvEntitlementWithOrderNumber
    
    #endregion

    public static class ListRcvEntitlementWithOrderNumberExtensions
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
            this List<RcvEntitlementWithOrderNumber> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<RcvEntitlementWithOrderNumber> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RcvEntitlementWithOrderNumber> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RcvEntitlementWithOrderNumber());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RcvEntitlementWithOrderNumber> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types