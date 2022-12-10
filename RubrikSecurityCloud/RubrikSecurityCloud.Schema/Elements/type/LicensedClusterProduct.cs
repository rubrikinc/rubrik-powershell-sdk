// LicensedClusterProduct.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:03.
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
    #region LicensedClusterProduct
    public class LicensedClusterProduct: IFragment
    {
        #region members
        //      C# -> System.Single? NextExpiringBytes
        // GraphQL -> nextExpiringBytes: Float! (scalar)
        [JsonProperty("nextExpiringBytes")]
        public System.Single? NextExpiringBytes { get; set; }

        //      C# -> DateTime? NextExpiringTime
        // GraphQL -> nextExpiringTime: DateTime (scalar)
        [JsonProperty("nextExpiringTime")]
        public DateTime? NextExpiringTime { get; set; }

        //      C# -> System.Int32? NumClusters
        // GraphQL -> numClusters: Int! (scalar)
        [JsonProperty("numClusters")]
        public System.Int32? NumClusters { get; set; }

        //      C# -> List<System.String>? ProductTypes
        // GraphQL -> productTypes: [String!]! (scalar)
        [JsonProperty("productTypes")]
        public List<System.String>? ProductTypes { get; set; }

        //      C# -> System.Single? PurchasedCapacityBytes
        // GraphQL -> purchasedCapacityBytes: Float! (scalar)
        [JsonProperty("purchasedCapacityBytes")]
        public System.Single? PurchasedCapacityBytes { get; set; }

        //      C# -> System.Single? RegisteredCapacityBytes
        // GraphQL -> registeredCapacityBytes: Float! (scalar)
        [JsonProperty("registeredCapacityBytes")]
        public System.Single? RegisteredCapacityBytes { get; set; }

        //      C# -> List<CapacityContribution>? Contributions
        // GraphQL -> contributions: [CapacityContribution!]! (type)
        [JsonProperty("contributions")]
        public List<CapacityContribution>? Contributions { get; set; }

        //      C# -> Product? Product
        // GraphQL -> product: Product! (enum)
        [JsonProperty("product")]
        public Product? Product { get; set; }

        #endregion

    #region methods

    public LicensedClusterProduct Set(
        System.Single? NextExpiringBytes = null,
        DateTime? NextExpiringTime = null,
        System.Int32? NumClusters = null,
        List<System.String>? ProductTypes = null,
        System.Single? PurchasedCapacityBytes = null,
        System.Single? RegisteredCapacityBytes = null,
        List<CapacityContribution>? Contributions = null,
        Product? Product = null
    ) 
    {
        if ( NextExpiringBytes != null ) {
            this.NextExpiringBytes = NextExpiringBytes;
        }
        if ( NextExpiringTime != null ) {
            this.NextExpiringTime = NextExpiringTime;
        }
        if ( NumClusters != null ) {
            this.NumClusters = NumClusters;
        }
        if ( ProductTypes != null ) {
            this.ProductTypes = ProductTypes;
        }
        if ( PurchasedCapacityBytes != null ) {
            this.PurchasedCapacityBytes = PurchasedCapacityBytes;
        }
        if ( RegisteredCapacityBytes != null ) {
            this.RegisteredCapacityBytes = RegisteredCapacityBytes;
        }
        if ( Contributions != null ) {
            this.Contributions = Contributions;
        }
        if ( Product != null ) {
            this.Product = Product;
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
            //      C# -> System.Single? NextExpiringBytes
            // GraphQL -> nextExpiringBytes: Float! (scalar)
            if (this.NextExpiringBytes != null)
            {
                 s += ind + "nextExpiringBytes\n";

            }
            //      C# -> DateTime? NextExpiringTime
            // GraphQL -> nextExpiringTime: DateTime (scalar)
            if (this.NextExpiringTime != null)
            {
                 s += ind + "nextExpiringTime\n";

            }
            //      C# -> System.Int32? NumClusters
            // GraphQL -> numClusters: Int! (scalar)
            if (this.NumClusters != null)
            {
                 s += ind + "numClusters\n";

            }
            //      C# -> List<System.String>? ProductTypes
            // GraphQL -> productTypes: [String!]! (scalar)
            if (this.ProductTypes != null)
            {
                 s += ind + "productTypes\n";

            }
            //      C# -> System.Single? PurchasedCapacityBytes
            // GraphQL -> purchasedCapacityBytes: Float! (scalar)
            if (this.PurchasedCapacityBytes != null)
            {
                 s += ind + "purchasedCapacityBytes\n";

            }
            //      C# -> System.Single? RegisteredCapacityBytes
            // GraphQL -> registeredCapacityBytes: Float! (scalar)
            if (this.RegisteredCapacityBytes != null)
            {
                 s += ind + "registeredCapacityBytes\n";

            }
            //      C# -> List<CapacityContribution>? Contributions
            // GraphQL -> contributions: [CapacityContribution!]! (type)
            if (this.Contributions != null)
            {
                 s += ind + "contributions\n";

                 s += ind + "{\n" + 
                 this.Contributions.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Product? Product
            // GraphQL -> product: Product! (enum)
            if (this.Product != null)
            {
                 s += ind + "product\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Single? NextExpiringBytes
            // GraphQL -> nextExpiringBytes: Float! (scalar)
            if (this.NextExpiringBytes == null && Exploration.Includes(parent + ".nextExpiringBytes$"))
            {
                this.NextExpiringBytes = new System.Single();
            }
            //      C# -> DateTime? NextExpiringTime
            // GraphQL -> nextExpiringTime: DateTime (scalar)
            if (this.NextExpiringTime == null && Exploration.Includes(parent + ".nextExpiringTime$"))
            {
                this.NextExpiringTime = new DateTime();
            }
            //      C# -> System.Int32? NumClusters
            // GraphQL -> numClusters: Int! (scalar)
            if (this.NumClusters == null && Exploration.Includes(parent + ".numClusters$"))
            {
                this.NumClusters = new System.Int32();
            }
            //      C# -> List<System.String>? ProductTypes
            // GraphQL -> productTypes: [String!]! (scalar)
            if (this.ProductTypes == null && Exploration.Includes(parent + ".productTypes$"))
            {
                this.ProductTypes = new List<System.String>();
            }
            //      C# -> System.Single? PurchasedCapacityBytes
            // GraphQL -> purchasedCapacityBytes: Float! (scalar)
            if (this.PurchasedCapacityBytes == null && Exploration.Includes(parent + ".purchasedCapacityBytes$"))
            {
                this.PurchasedCapacityBytes = new System.Single();
            }
            //      C# -> System.Single? RegisteredCapacityBytes
            // GraphQL -> registeredCapacityBytes: Float! (scalar)
            if (this.RegisteredCapacityBytes == null && Exploration.Includes(parent + ".registeredCapacityBytes$"))
            {
                this.RegisteredCapacityBytes = new System.Single();
            }
            //      C# -> List<CapacityContribution>? Contributions
            // GraphQL -> contributions: [CapacityContribution!]! (type)
            if (this.Contributions == null && Exploration.Includes(parent + ".contributions"))
            {
                this.Contributions = new List<CapacityContribution>();
                this.Contributions.ApplyExploratoryFragment(parent + ".contributions");
            }
            //      C# -> Product? Product
            // GraphQL -> product: Product! (enum)
            if (this.Product == null && Exploration.Includes(parent + ".product$"))
            {
                this.Product = new Product();
            }
        }


    #endregion

    } // class LicensedClusterProduct
    #endregion

    public static class ListLicensedClusterProductExtensions
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
            this List<LicensedClusterProduct> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<LicensedClusterProduct> list, 
            String parent = "")
        {
            var item = new LicensedClusterProduct();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types