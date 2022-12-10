// License.cs
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
    #region License
    public class License: IFragment
    {
        #region members
        //      C# -> System.Single? Quantity
        // GraphQL -> quantity: Float! (scalar)
        [JsonProperty("quantity")]
        public System.Single? Quantity { get; set; }

        //      C# -> DateTime? TermEndDate
        // GraphQL -> termEndDate: DateTime (scalar)
        [JsonProperty("termEndDate")]
        public DateTime? TermEndDate { get; set; }

        //      C# -> DateTime? TermStartDate
        // GraphQL -> termStartDate: DateTime (scalar)
        [JsonProperty("termStartDate")]
        public DateTime? TermStartDate { get; set; }

        //      C# -> Product? Product
        // GraphQL -> product: Product! (enum)
        [JsonProperty("product")]
        public Product? Product { get; set; }

        #endregion

    #region methods

    public License Set(
        System.Single? Quantity = null,
        DateTime? TermEndDate = null,
        DateTime? TermStartDate = null,
        Product? Product = null
    ) 
    {
        if ( Quantity != null ) {
            this.Quantity = Quantity;
        }
        if ( TermEndDate != null ) {
            this.TermEndDate = TermEndDate;
        }
        if ( TermStartDate != null ) {
            this.TermStartDate = TermStartDate;
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
            //      C# -> System.Single? Quantity
            // GraphQL -> quantity: Float! (scalar)
            if (this.Quantity != null)
            {
                 s += ind + "quantity\n";

            }
            //      C# -> DateTime? TermEndDate
            // GraphQL -> termEndDate: DateTime (scalar)
            if (this.TermEndDate != null)
            {
                 s += ind + "termEndDate\n";

            }
            //      C# -> DateTime? TermStartDate
            // GraphQL -> termStartDate: DateTime (scalar)
            if (this.TermStartDate != null)
            {
                 s += ind + "termStartDate\n";

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
            //      C# -> System.Single? Quantity
            // GraphQL -> quantity: Float! (scalar)
            if (this.Quantity == null && Exploration.Includes(parent + ".quantity$"))
            {
                this.Quantity = new System.Single();
            }
            //      C# -> DateTime? TermEndDate
            // GraphQL -> termEndDate: DateTime (scalar)
            if (this.TermEndDate == null && Exploration.Includes(parent + ".termEndDate$"))
            {
                this.TermEndDate = new DateTime();
            }
            //      C# -> DateTime? TermStartDate
            // GraphQL -> termStartDate: DateTime (scalar)
            if (this.TermStartDate == null && Exploration.Includes(parent + ".termStartDate$"))
            {
                this.TermStartDate = new DateTime();
            }
            //      C# -> Product? Product
            // GraphQL -> product: Product! (enum)
            if (this.Product == null && Exploration.Includes(parent + ".product$"))
            {
                this.Product = new Product();
            }
        }


    #endregion

    } // class License
    #endregion

    public static class ListLicenseExtensions
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
            this List<License> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<License> list, 
            String parent = "")
        {
            var item = new License();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types