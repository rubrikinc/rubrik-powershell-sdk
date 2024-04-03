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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
                    s += ind + "entitlement" + " " + "{\n" + fspec + ind + "}\n" ;
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
            this List<RcvEntitlementsUsageDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
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