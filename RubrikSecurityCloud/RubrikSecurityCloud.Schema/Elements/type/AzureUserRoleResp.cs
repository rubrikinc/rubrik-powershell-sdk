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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> RoleStatus? GlobalAdministrator
        // GraphQL -> globalAdministrator: RoleStatus (type)
        if (this.GlobalAdministrator != null) {
            var fspec = this.GlobalAdministrator.AsFieldSpec(conf.Child("globalAdministrator"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "globalAdministrator" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RoleStatus? SubscriptionOwner
        // GraphQL -> subscriptionOwner: RoleStatus (type)
        if (this.SubscriptionOwner != null) {
            var fspec = this.SubscriptionOwner.AsFieldSpec(conf.Child("subscriptionOwner"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "subscriptionOwner" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RoleStatus? GlobalAdministrator
        // GraphQL -> globalAdministrator: RoleStatus (type)
        if (ec.Includes("globalAdministrator",false))
        {
            if(this.GlobalAdministrator == null) {

                this.GlobalAdministrator = new RoleStatus();
                this.GlobalAdministrator.ApplyExploratoryFieldSpec(ec.NewChild("globalAdministrator"));

            } else {

                this.GlobalAdministrator.ApplyExploratoryFieldSpec(ec.NewChild("globalAdministrator"));

            }
        }
        else if (this.GlobalAdministrator != null && ec.Excludes("globalAdministrator",false))
        {
            this.GlobalAdministrator = null;
        }
        //      C# -> RoleStatus? SubscriptionOwner
        // GraphQL -> subscriptionOwner: RoleStatus (type)
        if (ec.Includes("subscriptionOwner",false))
        {
            if(this.SubscriptionOwner == null) {

                this.SubscriptionOwner = new RoleStatus();
                this.SubscriptionOwner.ApplyExploratoryFieldSpec(ec.NewChild("subscriptionOwner"));

            } else {

                this.SubscriptionOwner.ApplyExploratoryFieldSpec(ec.NewChild("subscriptionOwner"));

            }
        }
        else if (this.SubscriptionOwner != null && ec.Excludes("subscriptionOwner",false))
        {
            this.SubscriptionOwner = null;
        }
    }


    #endregion

    } // class AzureUserRoleResp
    
    #endregion

    public static class ListAzureUserRoleRespExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AzureUserRoleResp> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureUserRoleResp> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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