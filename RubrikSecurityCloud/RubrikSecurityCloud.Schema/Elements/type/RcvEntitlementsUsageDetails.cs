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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Single? UsedCapacity
        // GraphQL -> usedCapacity: Float! (scalar)
        if (this.UsedCapacity != null) {
            s += ind + "usedCapacity\n" ;
        }
        //      C# -> RcvEntitlement? Entitlement
        // GraphQL -> entitlement: RcvEntitlement (type)
        if (this.Entitlement != null) {
            var fspec = this.Entitlement.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "entitlement {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Single? UsedCapacity
        // GraphQL -> usedCapacity: Float! (scalar)
        if (this.UsedCapacity == null && Exploration.Includes(parent + ".usedCapacity", true))
        {
            this.UsedCapacity = new System.Single();
        }
        //      C# -> RcvEntitlement? Entitlement
        // GraphQL -> entitlement: RcvEntitlement (type)
        if (this.Entitlement == null && Exploration.Includes(parent + ".entitlement"))
        {
            this.Entitlement = new RcvEntitlement();
            this.Entitlement.ApplyExploratoryFieldSpec(parent + ".entitlement");
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RcvEntitlementsUsageDetails> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RcvEntitlementsUsageDetails());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types