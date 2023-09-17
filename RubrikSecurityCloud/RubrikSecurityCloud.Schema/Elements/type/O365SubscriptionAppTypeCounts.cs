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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: UUID! (scalar)
        if (this.SubscriptionId != null) {
            s += ind + "subscriptionId\n" ;
        }
        //      C# -> AuthCounts? ExchangeAppCounts
        // GraphQL -> exchangeAppCounts: AuthCounts! (type)
        if (this.ExchangeAppCounts != null) {
            var fspec = this.ExchangeAppCounts.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "exchangeAppCounts {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AuthCounts? OnedriveAppCounts
        // GraphQL -> onedriveAppCounts: AuthCounts! (type)
        if (this.OnedriveAppCounts != null) {
            var fspec = this.OnedriveAppCounts.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "onedriveAppCounts {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AuthCounts? SharepointAppCounts
        // GraphQL -> sharepointAppCounts: AuthCounts! (type)
        if (this.SharepointAppCounts != null) {
            var fspec = this.SharepointAppCounts.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sharepointAppCounts {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AuthCounts? TeamsAppCounts
        // GraphQL -> teamsAppCounts: AuthCounts! (type)
        if (this.TeamsAppCounts != null) {
            var fspec = this.TeamsAppCounts.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "teamsAppCounts {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: UUID! (scalar)
        if (this.SubscriptionId == null && ec.Includes("subscriptionId",true))
        {
            this.SubscriptionId = "FETCH";
        }
        //      C# -> AuthCounts? ExchangeAppCounts
        // GraphQL -> exchangeAppCounts: AuthCounts! (type)
        if (this.ExchangeAppCounts == null && ec.Includes("exchangeAppCounts",false))
        {
            this.ExchangeAppCounts = new AuthCounts();
            this.ExchangeAppCounts.ApplyExploratoryFieldSpec(ec.NewChild("exchangeAppCounts"));
        }
        //      C# -> AuthCounts? OnedriveAppCounts
        // GraphQL -> onedriveAppCounts: AuthCounts! (type)
        if (this.OnedriveAppCounts == null && ec.Includes("onedriveAppCounts",false))
        {
            this.OnedriveAppCounts = new AuthCounts();
            this.OnedriveAppCounts.ApplyExploratoryFieldSpec(ec.NewChild("onedriveAppCounts"));
        }
        //      C# -> AuthCounts? SharepointAppCounts
        // GraphQL -> sharepointAppCounts: AuthCounts! (type)
        if (this.SharepointAppCounts == null && ec.Includes("sharepointAppCounts",false))
        {
            this.SharepointAppCounts = new AuthCounts();
            this.SharepointAppCounts.ApplyExploratoryFieldSpec(ec.NewChild("sharepointAppCounts"));
        }
        //      C# -> AuthCounts? TeamsAppCounts
        // GraphQL -> teamsAppCounts: AuthCounts! (type)
        if (this.TeamsAppCounts == null && ec.Includes("teamsAppCounts",false))
        {
            this.TeamsAppCounts = new AuthCounts();
            this.TeamsAppCounts.ApplyExploratoryFieldSpec(ec.NewChild("teamsAppCounts"));
        }
    }


    #endregion

    } // class O365SubscriptionAppTypeCounts
    
    #endregion

    public static class ListO365SubscriptionAppTypeCountsExtensions
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
            this List<O365SubscriptionAppTypeCounts> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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