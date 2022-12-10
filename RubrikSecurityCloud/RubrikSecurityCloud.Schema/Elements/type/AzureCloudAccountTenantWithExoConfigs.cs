// AzureCloudAccountTenantWithExoConfigs.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:25.
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
    #region AzureCloudAccountTenantWithExoConfigs
    public class AzureCloudAccountTenantWithExoConfigs: IFragment
    {
        #region members
        //      C# -> System.String? AppName
        // GraphQL -> appName: String! (scalar)
        [JsonProperty("appName")]
        public System.String? AppName { get; set; }

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        [JsonProperty("domainName")]
        public System.String? DomainName { get; set; }

        //      C# -> System.Int32? SubscriptionCount
        // GraphQL -> subscriptionCount: Int! (scalar)
        [JsonProperty("subscriptionCount")]
        public System.Int32? SubscriptionCount { get; set; }

        //      C# -> List<AzureSubscriptionWithExoConfigs>? Subscriptions
        // GraphQL -> subscriptions: [AzureSubscriptionWithExoConfigs!]! (type)
        [JsonProperty("subscriptions")]
        public List<AzureSubscriptionWithExoConfigs>? Subscriptions { get; set; }

        //      C# -> AzureCloudType? CloudType
        // GraphQL -> cloudType: AzureCloudType! (enum)
        [JsonProperty("cloudType")]
        public AzureCloudType? CloudType { get; set; }

        #endregion

    #region methods

    public AzureCloudAccountTenantWithExoConfigs Set(
        System.String? AppName = null,
        System.String? ClientId = null,
        System.String? DomainName = null,
        System.Int32? SubscriptionCount = null,
        List<AzureSubscriptionWithExoConfigs>? Subscriptions = null,
        AzureCloudType? CloudType = null
    ) 
    {
        if ( AppName != null ) {
            this.AppName = AppName;
        }
        if ( ClientId != null ) {
            this.ClientId = ClientId;
        }
        if ( DomainName != null ) {
            this.DomainName = DomainName;
        }
        if ( SubscriptionCount != null ) {
            this.SubscriptionCount = SubscriptionCount;
        }
        if ( Subscriptions != null ) {
            this.Subscriptions = Subscriptions;
        }
        if ( CloudType != null ) {
            this.CloudType = CloudType;
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
            //      C# -> System.String? AppName
            // GraphQL -> appName: String! (scalar)
            if (this.AppName != null)
            {
                 s += ind + "appName\n";

            }
            //      C# -> System.String? ClientId
            // GraphQL -> clientId: String! (scalar)
            if (this.ClientId != null)
            {
                 s += ind + "clientId\n";

            }
            //      C# -> System.String? DomainName
            // GraphQL -> domainName: String! (scalar)
            if (this.DomainName != null)
            {
                 s += ind + "domainName\n";

            }
            //      C# -> System.Int32? SubscriptionCount
            // GraphQL -> subscriptionCount: Int! (scalar)
            if (this.SubscriptionCount != null)
            {
                 s += ind + "subscriptionCount\n";

            }
            //      C# -> List<AzureSubscriptionWithExoConfigs>? Subscriptions
            // GraphQL -> subscriptions: [AzureSubscriptionWithExoConfigs!]! (type)
            if (this.Subscriptions != null)
            {
                 s += ind + "subscriptions\n";

                 s += ind + "{\n" + 
                 this.Subscriptions.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AzureCloudType? CloudType
            // GraphQL -> cloudType: AzureCloudType! (enum)
            if (this.CloudType != null)
            {
                 s += ind + "cloudType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AppName
            // GraphQL -> appName: String! (scalar)
            if (this.AppName == null && Exploration.Includes(parent + ".appName$"))
            {
                this.AppName = new System.String("FETCH");
            }
            //      C# -> System.String? ClientId
            // GraphQL -> clientId: String! (scalar)
            if (this.ClientId == null && Exploration.Includes(parent + ".clientId$"))
            {
                this.ClientId = new System.String("FETCH");
            }
            //      C# -> System.String? DomainName
            // GraphQL -> domainName: String! (scalar)
            if (this.DomainName == null && Exploration.Includes(parent + ".domainName$"))
            {
                this.DomainName = new System.String("FETCH");
            }
            //      C# -> System.Int32? SubscriptionCount
            // GraphQL -> subscriptionCount: Int! (scalar)
            if (this.SubscriptionCount == null && Exploration.Includes(parent + ".subscriptionCount$"))
            {
                this.SubscriptionCount = new System.Int32();
            }
            //      C# -> List<AzureSubscriptionWithExoConfigs>? Subscriptions
            // GraphQL -> subscriptions: [AzureSubscriptionWithExoConfigs!]! (type)
            if (this.Subscriptions == null && Exploration.Includes(parent + ".subscriptions"))
            {
                this.Subscriptions = new List<AzureSubscriptionWithExoConfigs>();
                this.Subscriptions.ApplyExploratoryFragment(parent + ".subscriptions");
            }
            //      C# -> AzureCloudType? CloudType
            // GraphQL -> cloudType: AzureCloudType! (enum)
            if (this.CloudType == null && Exploration.Includes(parent + ".cloudType$"))
            {
                this.CloudType = new AzureCloudType();
            }
        }


    #endregion

    } // class AzureCloudAccountTenantWithExoConfigs
    #endregion

    public static class ListAzureCloudAccountTenantWithExoConfigsExtensions
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
            this List<AzureCloudAccountTenantWithExoConfigs> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureCloudAccountTenantWithExoConfigs> list, 
            String parent = "")
        {
            var item = new AzureCloudAccountTenantWithExoConfigs();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types