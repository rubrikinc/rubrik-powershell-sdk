// License.cs
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
    #region License
    public class License: BaseType
    {
        #region members

        //      C# -> Product? Product
        // GraphQL -> product: Product! (enum)
        [JsonProperty("product")]
        public Product? Product { get; set; }

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


        #endregion

    #region methods

    public License Set(
        Product? Product = null,
        System.Single? Quantity = null,
        DateTime? TermEndDate = null,
        DateTime? TermStartDate = null
    ) 
    {
        if ( Product != null ) {
            this.Product = Product;
        }
        if ( Quantity != null ) {
            this.Quantity = Quantity;
        }
        if ( TermEndDate != null ) {
            this.TermEndDate = TermEndDate;
        }
        if ( TermStartDate != null ) {
            this.TermStartDate = TermStartDate;
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
        //      C# -> Product? Product
        // GraphQL -> product: Product! (enum)
        if (this.Product != null) {
            s += ind + "product\n" ;
        }
        //      C# -> System.Single? Quantity
        // GraphQL -> quantity: Float! (scalar)
        if (this.Quantity != null) {
            s += ind + "quantity\n" ;
        }
        //      C# -> DateTime? TermEndDate
        // GraphQL -> termEndDate: DateTime (scalar)
        if (this.TermEndDate != null) {
            s += ind + "termEndDate\n" ;
        }
        //      C# -> DateTime? TermStartDate
        // GraphQL -> termStartDate: DateTime (scalar)
        if (this.TermStartDate != null) {
            s += ind + "termStartDate\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> Product? Product
        // GraphQL -> product: Product! (enum)
        if (this.Product == null && Exploration.Includes(parent + ".product", true))
        {
            this.Product = new Product();
        }
        //      C# -> System.Single? Quantity
        // GraphQL -> quantity: Float! (scalar)
        if (this.Quantity == null && Exploration.Includes(parent + ".quantity", true))
        {
            this.Quantity = new System.Single();
        }
        //      C# -> DateTime? TermEndDate
        // GraphQL -> termEndDate: DateTime (scalar)
        if (this.TermEndDate == null && Exploration.Includes(parent + ".termEndDate", true))
        {
            this.TermEndDate = new DateTime();
        }
        //      C# -> DateTime? TermStartDate
        // GraphQL -> termStartDate: DateTime (scalar)
        if (this.TermStartDate == null && Exploration.Includes(parent + ".termStartDate", true))
        {
            this.TermStartDate = new DateTime();
        }
    }


    #endregion

    } // class License
    
    #endregion

    public static class ListLicenseExtensions
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
            this List<License> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<License> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new License());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types