// AzureCloudAccountSubscription.cs
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
    #region AzureCloudAccountSubscription
    public class AzureCloudAccountSubscription: IFragment
    {
        #region members
        //      C# -> System.String? CustomerSubscriptionId
        // GraphQL -> customerSubscriptionId: String! (scalar)
        [JsonProperty("customerSubscriptionId")]
        public System.String? CustomerSubscriptionId { get; set; }

        //      C# -> System.String? CustomerTenantId
        // GraphQL -> customerTenantId: String! (scalar)
        [JsonProperty("customerTenantId")]
        public System.String? CustomerTenantId { get; set; }

        //      C# -> System.Boolean? IsAuthorized
        // GraphQL -> isAuthorized: Boolean! (scalar)
        [JsonProperty("isAuthorized")]
        public System.Boolean? IsAuthorized { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        [JsonProperty("nativeId")]
        public System.String? NativeId { get; set; }

        //      C# -> AzureCloudType? CloudType
        // GraphQL -> cloudType: AzureCloudType! (enum)
        [JsonProperty("cloudType")]
        public AzureCloudType? CloudType { get; set; }

        #endregion

    #region methods

    public AzureCloudAccountSubscription Set(
        System.String? CustomerSubscriptionId = null,
        System.String? CustomerTenantId = null,
        System.Boolean? IsAuthorized = null,
        System.String? Name = null,
        System.String? NativeId = null,
        AzureCloudType? CloudType = null
    ) 
    {
        if ( CustomerSubscriptionId != null ) {
            this.CustomerSubscriptionId = CustomerSubscriptionId;
        }
        if ( CustomerTenantId != null ) {
            this.CustomerTenantId = CustomerTenantId;
        }
        if ( IsAuthorized != null ) {
            this.IsAuthorized = IsAuthorized;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NativeId != null ) {
            this.NativeId = NativeId;
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
            //      C# -> System.String? CustomerSubscriptionId
            // GraphQL -> customerSubscriptionId: String! (scalar)
            if (this.CustomerSubscriptionId != null)
            {
                 s += ind + "customerSubscriptionId\n";

            }
            //      C# -> System.String? CustomerTenantId
            // GraphQL -> customerTenantId: String! (scalar)
            if (this.CustomerTenantId != null)
            {
                 s += ind + "customerTenantId\n";

            }
            //      C# -> System.Boolean? IsAuthorized
            // GraphQL -> isAuthorized: Boolean! (scalar)
            if (this.IsAuthorized != null)
            {
                 s += ind + "isAuthorized\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? NativeId
            // GraphQL -> nativeId: String! (scalar)
            if (this.NativeId != null)
            {
                 s += ind + "nativeId\n";

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
            //      C# -> System.String? CustomerSubscriptionId
            // GraphQL -> customerSubscriptionId: String! (scalar)
            if (this.CustomerSubscriptionId == null && Exploration.Includes(parent + ".customerSubscriptionId$"))
            {
                this.CustomerSubscriptionId = new System.String("FETCH");
            }
            //      C# -> System.String? CustomerTenantId
            // GraphQL -> customerTenantId: String! (scalar)
            if (this.CustomerTenantId == null && Exploration.Includes(parent + ".customerTenantId$"))
            {
                this.CustomerTenantId = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsAuthorized
            // GraphQL -> isAuthorized: Boolean! (scalar)
            if (this.IsAuthorized == null && Exploration.Includes(parent + ".isAuthorized$"))
            {
                this.IsAuthorized = new System.Boolean();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? NativeId
            // GraphQL -> nativeId: String! (scalar)
            if (this.NativeId == null && Exploration.Includes(parent + ".nativeId$"))
            {
                this.NativeId = new System.String("FETCH");
            }
            //      C# -> AzureCloudType? CloudType
            // GraphQL -> cloudType: AzureCloudType! (enum)
            if (this.CloudType == null && Exploration.Includes(parent + ".cloudType$"))
            {
                this.CloudType = new AzureCloudType();
            }
        }


    #endregion

    } // class AzureCloudAccountSubscription
    #endregion

    public static class ListAzureCloudAccountSubscriptionExtensions
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
            this List<AzureCloudAccountSubscription> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureCloudAccountSubscription> list, 
            String parent = "")
        {
            var item = new AzureCloudAccountSubscription();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types