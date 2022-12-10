// O365SubscriptionAppTypeCounts.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:56.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region O365SubscriptionAppTypeCounts
    public class O365SubscriptionAppTypeCounts: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? SubscriptionId
            // GraphQL -> subscriptionId: UUID! (scalar)
            if (this.SubscriptionId != null)
            {
                 s += ind + "subscriptionId\n";

            }
            //      C# -> AuthCounts? ExchangeAppCounts
            // GraphQL -> exchangeAppCounts: AuthCounts! (type)
            if (this.ExchangeAppCounts != null)
            {
                 s += ind + "exchangeAppCounts\n";

                 s += ind + "{\n" + 
                 this.ExchangeAppCounts.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AuthCounts? OnedriveAppCounts
            // GraphQL -> onedriveAppCounts: AuthCounts! (type)
            if (this.OnedriveAppCounts != null)
            {
                 s += ind + "onedriveAppCounts\n";

                 s += ind + "{\n" + 
                 this.OnedriveAppCounts.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AuthCounts? SharepointAppCounts
            // GraphQL -> sharepointAppCounts: AuthCounts! (type)
            if (this.SharepointAppCounts != null)
            {
                 s += ind + "sharepointAppCounts\n";

                 s += ind + "{\n" + 
                 this.SharepointAppCounts.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AuthCounts? TeamsAppCounts
            // GraphQL -> teamsAppCounts: AuthCounts! (type)
            if (this.TeamsAppCounts != null)
            {
                 s += ind + "teamsAppCounts\n";

                 s += ind + "{\n" + 
                 this.TeamsAppCounts.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? SubscriptionId
            // GraphQL -> subscriptionId: UUID! (scalar)
            if (this.SubscriptionId == null && Exploration.Includes(parent + ".subscriptionId$"))
            {
                this.SubscriptionId = new System.String("FETCH");
            }
            //      C# -> AuthCounts? ExchangeAppCounts
            // GraphQL -> exchangeAppCounts: AuthCounts! (type)
            if (this.ExchangeAppCounts == null && Exploration.Includes(parent + ".exchangeAppCounts"))
            {
                this.ExchangeAppCounts = new AuthCounts();
                this.ExchangeAppCounts.ApplyExploratoryFragment(parent + ".exchangeAppCounts");
            }
            //      C# -> AuthCounts? OnedriveAppCounts
            // GraphQL -> onedriveAppCounts: AuthCounts! (type)
            if (this.OnedriveAppCounts == null && Exploration.Includes(parent + ".onedriveAppCounts"))
            {
                this.OnedriveAppCounts = new AuthCounts();
                this.OnedriveAppCounts.ApplyExploratoryFragment(parent + ".onedriveAppCounts");
            }
            //      C# -> AuthCounts? SharepointAppCounts
            // GraphQL -> sharepointAppCounts: AuthCounts! (type)
            if (this.SharepointAppCounts == null && Exploration.Includes(parent + ".sharepointAppCounts"))
            {
                this.SharepointAppCounts = new AuthCounts();
                this.SharepointAppCounts.ApplyExploratoryFragment(parent + ".sharepointAppCounts");
            }
            //      C# -> AuthCounts? TeamsAppCounts
            // GraphQL -> teamsAppCounts: AuthCounts! (type)
            if (this.TeamsAppCounts == null && Exploration.Includes(parent + ".teamsAppCounts"))
            {
                this.TeamsAppCounts = new AuthCounts();
                this.TeamsAppCounts.ApplyExploratoryFragment(parent + ".teamsAppCounts");
            }
        }


    #endregion

    } // class O365SubscriptionAppTypeCounts
    #endregion

    public static class ListO365SubscriptionAppTypeCountsExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<O365SubscriptionAppTypeCounts> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<O365SubscriptionAppTypeCounts> list, 
            String parent = "")
        {
            var item = new O365SubscriptionAppTypeCounts();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types