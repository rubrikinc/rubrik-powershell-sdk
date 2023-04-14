// CapacityContribution.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region CapacityContribution
    public class CapacityContribution: IFragment
    {
        #region members
        //      C# -> System.Single? RegisteredCapacityBytes
        // GraphQL -> registeredCapacityBytes: Float! (scalar)
        [JsonProperty("registeredCapacityBytes")]
        public System.Single? RegisteredCapacityBytes { get; set; }

        //      C# -> Product? Product
        // GraphQL -> product: Product! (enum)
        [JsonProperty("product")]
        public Product? Product { get; set; }

        #endregion

    #region methods

    public CapacityContribution Set(
        System.Single? RegisteredCapacityBytes = null,
        Product? Product = null
    ) 
    {
        if ( RegisteredCapacityBytes != null ) {
            this.RegisteredCapacityBytes = RegisteredCapacityBytes;
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
            //      C# -> System.Single? RegisteredCapacityBytes
            // GraphQL -> registeredCapacityBytes: Float! (scalar)
            if (this.RegisteredCapacityBytes != null)
            {
                 s += ind + "registeredCapacityBytes\n";

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
            //      C# -> System.Single? RegisteredCapacityBytes
            // GraphQL -> registeredCapacityBytes: Float! (scalar)
            if (this.RegisteredCapacityBytes == null && Exploration.Includes(parent + ".registeredCapacityBytes$"))
            {
                this.RegisteredCapacityBytes = new System.Single();
            }
            //      C# -> Product? Product
            // GraphQL -> product: Product! (enum)
            if (this.Product == null && Exploration.Includes(parent + ".product$"))
            {
                this.Product = new Product();
            }
        }


    #endregion

    } // class CapacityContribution
    #endregion

    public static class ListCapacityContributionExtensions
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
            this List<CapacityContribution> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CapacityContribution> list, 
            String parent = "")
        {
            var item = new CapacityContribution();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types