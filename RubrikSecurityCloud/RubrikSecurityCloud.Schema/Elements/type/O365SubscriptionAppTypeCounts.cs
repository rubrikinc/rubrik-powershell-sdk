// O365SubscriptionAppTypeCounts.cs
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
    #region O365SubscriptionAppTypeCounts
    public class O365SubscriptionAppTypeCounts: BaseType
    {
        #region members

        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: UUID! (scalar)
        [JsonProperty("subscriptionId")]
        public System.String? SubscriptionId { get; set; }

        //      C# -> AuthCounts? ExchangeAppCounts
        // GraphQL -> exchangeAppCounts: AuthCounts! (type)
        [JsonProperty("exchangeAppCounts")]
        public AuthCounts? ExchangeAppCounts { get; set; }

        //      C# -> AuthCounts? OnedriveAppCounts
        // GraphQL -> onedriveAppCounts: AuthCounts! (type)
        [JsonProperty("onedriveAppCounts")]
        public AuthCounts? OnedriveAppCounts { get; set; }

        //      C# -> AuthCounts? SharepointAppCounts
        // GraphQL -> sharepointAppCounts: AuthCounts! (type)
        [JsonProperty("sharepointAppCounts")]
        public AuthCounts? SharepointAppCounts { get; set; }

        //      C# -> AuthCounts? TeamsAppCounts
        // GraphQL -> teamsAppCounts: AuthCounts! (type)
        [JsonProperty("teamsAppCounts")]
        public AuthCounts? TeamsAppCounts { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365SubscriptionAppTypeCounts";
    }

    public O365SubscriptionAppTypeCounts Set(
        System.String? SubscriptionId = null,
        AuthCounts? ExchangeAppCounts = null,
        AuthCounts? OnedriveAppCounts = null,
        AuthCounts? SharepointAppCounts = null,
        AuthCounts? TeamsAppCounts = null
    ) 
    {
        if ( SubscriptionId != null ) {
            this.SubscriptionId = SubscriptionId;
        }
        if ( ExchangeAppCounts != null ) {
            this.ExchangeAppCounts = ExchangeAppCounts;
        }
        if ( OnedriveAppCounts != null ) {
            this.OnedriveAppCounts = OnedriveAppCounts;
        }
        if ( SharepointAppCounts != null ) {
            this.SharepointAppCounts = SharepointAppCounts;
        }
        if ( TeamsAppCounts != null ) {
            this.TeamsAppCounts = TeamsAppCounts;
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
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: UUID! (scalar)
        if (this.SubscriptionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subscriptionId\n" ;
            } else {
                s += ind + "subscriptionId\n" ;
            }
        }
        //      C# -> AuthCounts? ExchangeAppCounts
        // GraphQL -> exchangeAppCounts: AuthCounts! (type)
        if (this.ExchangeAppCounts != null) {
            var fspec = this.ExchangeAppCounts.AsFieldSpec(conf.Child("exchangeAppCounts"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "exchangeAppCounts" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AuthCounts? OnedriveAppCounts
        // GraphQL -> onedriveAppCounts: AuthCounts! (type)
        if (this.OnedriveAppCounts != null) {
            var fspec = this.OnedriveAppCounts.AsFieldSpec(conf.Child("onedriveAppCounts"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "onedriveAppCounts" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AuthCounts? SharepointAppCounts
        // GraphQL -> sharepointAppCounts: AuthCounts! (type)
        if (this.SharepointAppCounts != null) {
            var fspec = this.SharepointAppCounts.AsFieldSpec(conf.Child("sharepointAppCounts"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sharepointAppCounts" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AuthCounts? TeamsAppCounts
        // GraphQL -> teamsAppCounts: AuthCounts! (type)
        if (this.TeamsAppCounts != null) {
            var fspec = this.TeamsAppCounts.AsFieldSpec(conf.Child("teamsAppCounts"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "teamsAppCounts" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: UUID! (scalar)
        if (ec.Includes("subscriptionId",true))
        {
            if(this.SubscriptionId == null) {

                this.SubscriptionId = "FETCH";

            } else {


            }
        }
        else if (this.SubscriptionId != null && ec.Excludes("subscriptionId",true))
        {
            this.SubscriptionId = null;
        }
        //      C# -> AuthCounts? ExchangeAppCounts
        // GraphQL -> exchangeAppCounts: AuthCounts! (type)
        if (ec.Includes("exchangeAppCounts",false))
        {
            if(this.ExchangeAppCounts == null) {

                this.ExchangeAppCounts = new AuthCounts();
                this.ExchangeAppCounts.ApplyExploratoryFieldSpec(ec.NewChild("exchangeAppCounts"));

            } else {

                this.ExchangeAppCounts.ApplyExploratoryFieldSpec(ec.NewChild("exchangeAppCounts"));

            }
        }
        else if (this.ExchangeAppCounts != null && ec.Excludes("exchangeAppCounts",false))
        {
            this.ExchangeAppCounts = null;
        }
        //      C# -> AuthCounts? OnedriveAppCounts
        // GraphQL -> onedriveAppCounts: AuthCounts! (type)
        if (ec.Includes("onedriveAppCounts",false))
        {
            if(this.OnedriveAppCounts == null) {

                this.OnedriveAppCounts = new AuthCounts();
                this.OnedriveAppCounts.ApplyExploratoryFieldSpec(ec.NewChild("onedriveAppCounts"));

            } else {

                this.OnedriveAppCounts.ApplyExploratoryFieldSpec(ec.NewChild("onedriveAppCounts"));

            }
        }
        else if (this.OnedriveAppCounts != null && ec.Excludes("onedriveAppCounts",false))
        {
            this.OnedriveAppCounts = null;
        }
        //      C# -> AuthCounts? SharepointAppCounts
        // GraphQL -> sharepointAppCounts: AuthCounts! (type)
        if (ec.Includes("sharepointAppCounts",false))
        {
            if(this.SharepointAppCounts == null) {

                this.SharepointAppCounts = new AuthCounts();
                this.SharepointAppCounts.ApplyExploratoryFieldSpec(ec.NewChild("sharepointAppCounts"));

            } else {

                this.SharepointAppCounts.ApplyExploratoryFieldSpec(ec.NewChild("sharepointAppCounts"));

            }
        }
        else if (this.SharepointAppCounts != null && ec.Excludes("sharepointAppCounts",false))
        {
            this.SharepointAppCounts = null;
        }
        //      C# -> AuthCounts? TeamsAppCounts
        // GraphQL -> teamsAppCounts: AuthCounts! (type)
        if (ec.Includes("teamsAppCounts",false))
        {
            if(this.TeamsAppCounts == null) {

                this.TeamsAppCounts = new AuthCounts();
                this.TeamsAppCounts.ApplyExploratoryFieldSpec(ec.NewChild("teamsAppCounts"));

            } else {

                this.TeamsAppCounts.ApplyExploratoryFieldSpec(ec.NewChild("teamsAppCounts"));

            }
        }
        else if (this.TeamsAppCounts != null && ec.Excludes("teamsAppCounts",false))
        {
            this.TeamsAppCounts = null;
        }
    }


    #endregion

    } // class O365SubscriptionAppTypeCounts
    
    #endregion

    public static class ListO365SubscriptionAppTypeCountsExtensions
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
            this List<O365SubscriptionAppTypeCounts> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365SubscriptionAppTypeCounts> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365SubscriptionAppTypeCounts> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365SubscriptionAppTypeCounts());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365SubscriptionAppTypeCounts> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types