// AzureUserRoleResp.cs
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
    #region AzureUserRoleResp
    public class AzureUserRoleResp: BaseType
    {
        #region members

        //      C# -> RoleStatus? GlobalAdministrator
        // GraphQL -> globalAdministrator: RoleStatus (type)
        [JsonProperty("globalAdministrator")]
        public RoleStatus? GlobalAdministrator { get; set; }

        //      C# -> RoleStatus? SubscriptionOwner
        // GraphQL -> subscriptionOwner: RoleStatus (type)
        [JsonProperty("subscriptionOwner")]
        public RoleStatus? SubscriptionOwner { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureUserRoleResp";
    }

    public AzureUserRoleResp Set(
        RoleStatus? GlobalAdministrator = null,
        RoleStatus? SubscriptionOwner = null
    ) 
    {
        if ( GlobalAdministrator != null ) {
            this.GlobalAdministrator = GlobalAdministrator;
        }
        if ( SubscriptionOwner != null ) {
            this.SubscriptionOwner = SubscriptionOwner;
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
        //      C# -> RoleStatus? GlobalAdministrator
        // GraphQL -> globalAdministrator: RoleStatus (type)
        if (this.GlobalAdministrator != null) {
            var fspec = this.GlobalAdministrator.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "globalAdministrator {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> RoleStatus? SubscriptionOwner
        // GraphQL -> subscriptionOwner: RoleStatus (type)
        if (this.SubscriptionOwner != null) {
            var fspec = this.SubscriptionOwner.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "subscriptionOwner {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RoleStatus? GlobalAdministrator
        // GraphQL -> globalAdministrator: RoleStatus (type)
        if (this.GlobalAdministrator == null && ec.Includes("globalAdministrator",false))
        {
            this.GlobalAdministrator = new RoleStatus();
            this.GlobalAdministrator.ApplyExploratoryFieldSpec(ec.NewChild("globalAdministrator"));
        }
        //      C# -> RoleStatus? SubscriptionOwner
        // GraphQL -> subscriptionOwner: RoleStatus (type)
        if (this.SubscriptionOwner == null && ec.Includes("subscriptionOwner",false))
        {
            this.SubscriptionOwner = new RoleStatus();
            this.SubscriptionOwner.ApplyExploratoryFieldSpec(ec.NewChild("subscriptionOwner"));
        }
    }


    #endregion

    } // class AzureUserRoleResp
    
    #endregion

    public static class ListAzureUserRoleRespExtensions
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
            this List<AzureUserRoleResp> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureUserRoleResp> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureUserRoleResp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureUserRoleResp> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types