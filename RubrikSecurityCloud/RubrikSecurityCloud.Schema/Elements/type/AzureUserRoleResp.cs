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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
            s += ind + "globalAdministrator {\n" + this.GlobalAdministrator.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> RoleStatus? SubscriptionOwner
        // GraphQL -> subscriptionOwner: RoleStatus (type)
        if (this.SubscriptionOwner != null) {
            s += ind + "subscriptionOwner {\n" + this.SubscriptionOwner.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> RoleStatus? GlobalAdministrator
        // GraphQL -> globalAdministrator: RoleStatus (type)
        if (this.GlobalAdministrator == null && Exploration.Includes(parent + ".globalAdministrator"))
        {
            this.GlobalAdministrator = new RoleStatus();
            this.GlobalAdministrator.ApplyExploratoryFieldSpec(parent + ".globalAdministrator");
        }
        //      C# -> RoleStatus? SubscriptionOwner
        // GraphQL -> subscriptionOwner: RoleStatus (type)
        if (this.SubscriptionOwner == null && Exploration.Includes(parent + ".subscriptionOwner"))
        {
            this.SubscriptionOwner = new RoleStatus();
            this.SubscriptionOwner.ApplyExploratoryFieldSpec(parent + ".subscriptionOwner");
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureUserRoleResp> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureUserRoleResp());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types