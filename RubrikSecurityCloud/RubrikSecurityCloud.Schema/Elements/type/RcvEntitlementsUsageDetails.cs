// RcvEntitlementsUsageDetails.cs
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
    #region RcvEntitlementsUsageDetails
    public class RcvEntitlementsUsageDetails: BaseType
    {
        #region members

        //      C# -> System.Single? UsedCapacity
        // GraphQL -> usedCapacity: Float! (scalar)
        [JsonProperty("usedCapacity")]
        public System.Single? UsedCapacity { get; set; }

        //      C# -> RcvEntitlement? Entitlement
        // GraphQL -> entitlement: RcvEntitlement (type)
        [JsonProperty("entitlement")]
        public RcvEntitlement? Entitlement { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RcvEntitlementsUsageDetails";
    }

    public RcvEntitlementsUsageDetails Set(
        System.Single? UsedCapacity = null,
        RcvEntitlement? Entitlement = null
    ) 
    {
        if ( UsedCapacity != null ) {
            this.UsedCapacity = UsedCapacity;
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
        //      C# -> System.Single? UsedCapacity
        // GraphQL -> usedCapacity: Float! (scalar)
        if (this.UsedCapacity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usedCapacity\n" ;
            } else {
                s += ind + "usedCapacity\n" ;
            }
        }
        //      C# -> RcvEntitlement? Entitlement
        // GraphQL -> entitlement: RcvEntitlement (type)
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
        //      C# -> System.Single? UsedCapacity
        // GraphQL -> usedCapacity: Float! (scalar)
        if (ec.Includes("usedCapacity",true))
        {
            if(this.UsedCapacity == null) {

                this.UsedCapacity = new System.Single();

            } else {


            }
        }
        else if (this.UsedCapacity != null && ec.Excludes("usedCapacity",true))
        {
            this.UsedCapacity = null;
        }
        //      C# -> RcvEntitlement? Entitlement
        // GraphQL -> entitlement: RcvEntitlement (type)
        if (ec.Includes("entitlement",false))
        {
            if(this.Entitlement == null) {

                this.Entitlement = new RcvEntitlement();
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

    } // class RcvEntitlementsUsageDetails
    
    #endregion

    public static class ListRcvEntitlementsUsageDetailsExtensions
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
            this List<RcvEntitlementsUsageDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<RcvEntitlementsUsageDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RcvEntitlementsUsageDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RcvEntitlementsUsageDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RcvEntitlementsUsageDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types