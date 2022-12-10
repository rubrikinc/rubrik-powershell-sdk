// StorageAccount.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:55.
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
    #region StorageAccount
    public class StorageAccount: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsVersioningEnabled
        // GraphQL -> isVersioningEnabled: Boolean! (scalar)
        [JsonProperty("isVersioningEnabled")]
        public System.Boolean? IsVersioningEnabled { get; set; }

        //      C# -> System.String? Kind
        // GraphQL -> kind: String! (scalar)
        [JsonProperty("kind")]
        public System.String? Kind { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? RegionName
        // GraphQL -> regionName: String! (scalar)
        [JsonProperty("regionName")]
        public System.String? RegionName { get; set; }

        //      C# -> NetworkRuleSet? NetworkRuleSet
        // GraphQL -> networkRuleSet: NetworkRuleSet (type)
        [JsonProperty("networkRuleSet")]
        public NetworkRuleSet? NetworkRuleSet { get; set; }

        //      C# -> ResourceGroup? ResourceGroup
        // GraphQL -> resourceGroup: ResourceGroup (type)
        [JsonProperty("resourceGroup")]
        public ResourceGroup? ResourceGroup { get; set; }

        //      C# -> StorageAccountTier? AccessTier
        // GraphQL -> accessTier: StorageAccountTier! (enum)
        [JsonProperty("accessTier")]
        public StorageAccountTier? AccessTier { get; set; }

        //      C# -> StorageAccountSku? Sku
        // GraphQL -> sku: StorageAccountSku! (enum)
        [JsonProperty("sku")]
        public StorageAccountSku? Sku { get; set; }

        #endregion

    #region methods

    public StorageAccount Set(
        System.String? Id = null,
        System.Boolean? IsVersioningEnabled = null,
        System.String? Kind = null,
        System.String? Name = null,
        System.String? RegionName = null,
        NetworkRuleSet? NetworkRuleSet = null,
        ResourceGroup? ResourceGroup = null,
        StorageAccountTier? AccessTier = null,
        StorageAccountSku? Sku = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsVersioningEnabled != null ) {
            this.IsVersioningEnabled = IsVersioningEnabled;
        }
        if ( Kind != null ) {
            this.Kind = Kind;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( RegionName != null ) {
            this.RegionName = RegionName;
        }
        if ( NetworkRuleSet != null ) {
            this.NetworkRuleSet = NetworkRuleSet;
        }
        if ( ResourceGroup != null ) {
            this.ResourceGroup = ResourceGroup;
        }
        if ( AccessTier != null ) {
            this.AccessTier = AccessTier;
        }
        if ( Sku != null ) {
            this.Sku = Sku;
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
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsVersioningEnabled
            // GraphQL -> isVersioningEnabled: Boolean! (scalar)
            if (this.IsVersioningEnabled != null)
            {
                 s += ind + "isVersioningEnabled\n";

            }
            //      C# -> System.String? Kind
            // GraphQL -> kind: String! (scalar)
            if (this.Kind != null)
            {
                 s += ind + "kind\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? RegionName
            // GraphQL -> regionName: String! (scalar)
            if (this.RegionName != null)
            {
                 s += ind + "regionName\n";

            }
            //      C# -> NetworkRuleSet? NetworkRuleSet
            // GraphQL -> networkRuleSet: NetworkRuleSet (type)
            if (this.NetworkRuleSet != null)
            {
                 s += ind + "networkRuleSet\n";

                 s += ind + "{\n" + 
                 this.NetworkRuleSet.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ResourceGroup? ResourceGroup
            // GraphQL -> resourceGroup: ResourceGroup (type)
            if (this.ResourceGroup != null)
            {
                 s += ind + "resourceGroup\n";

                 s += ind + "{\n" + 
                 this.ResourceGroup.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> StorageAccountTier? AccessTier
            // GraphQL -> accessTier: StorageAccountTier! (enum)
            if (this.AccessTier != null)
            {
                 s += ind + "accessTier\n";

            }
            //      C# -> StorageAccountSku? Sku
            // GraphQL -> sku: StorageAccountSku! (enum)
            if (this.Sku != null)
            {
                 s += ind + "sku\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsVersioningEnabled
            // GraphQL -> isVersioningEnabled: Boolean! (scalar)
            if (this.IsVersioningEnabled == null && Exploration.Includes(parent + ".isVersioningEnabled$"))
            {
                this.IsVersioningEnabled = new System.Boolean();
            }
            //      C# -> System.String? Kind
            // GraphQL -> kind: String! (scalar)
            if (this.Kind == null && Exploration.Includes(parent + ".kind$"))
            {
                this.Kind = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? RegionName
            // GraphQL -> regionName: String! (scalar)
            if (this.RegionName == null && Exploration.Includes(parent + ".regionName$"))
            {
                this.RegionName = new System.String("FETCH");
            }
            //      C# -> NetworkRuleSet? NetworkRuleSet
            // GraphQL -> networkRuleSet: NetworkRuleSet (type)
            if (this.NetworkRuleSet == null && Exploration.Includes(parent + ".networkRuleSet"))
            {
                this.NetworkRuleSet = new NetworkRuleSet();
                this.NetworkRuleSet.ApplyExploratoryFragment(parent + ".networkRuleSet");
            }
            //      C# -> ResourceGroup? ResourceGroup
            // GraphQL -> resourceGroup: ResourceGroup (type)
            if (this.ResourceGroup == null && Exploration.Includes(parent + ".resourceGroup"))
            {
                this.ResourceGroup = new ResourceGroup();
                this.ResourceGroup.ApplyExploratoryFragment(parent + ".resourceGroup");
            }
            //      C# -> StorageAccountTier? AccessTier
            // GraphQL -> accessTier: StorageAccountTier! (enum)
            if (this.AccessTier == null && Exploration.Includes(parent + ".accessTier$"))
            {
                this.AccessTier = new StorageAccountTier();
            }
            //      C# -> StorageAccountSku? Sku
            // GraphQL -> sku: StorageAccountSku! (enum)
            if (this.Sku == null && Exploration.Includes(parent + ".sku$"))
            {
                this.Sku = new StorageAccountSku();
            }
        }


    #endregion

    } // class StorageAccount
    #endregion

    public static class ListStorageAccountExtensions
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
            this List<StorageAccount> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<StorageAccount> list, 
            String parent = "")
        {
            var item = new StorageAccount();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types