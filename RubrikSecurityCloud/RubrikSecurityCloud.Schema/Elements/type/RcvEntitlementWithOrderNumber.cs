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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
                    s += ind + "entitlement" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
            this List<RcvEntitlementWithOrderNumber> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RcvEntitlementWithOrderNumber> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RcvEntitlementWithOrderNumber> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RcvEntitlementWithOrderNumber());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RcvEntitlementWithOrderNumber> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types