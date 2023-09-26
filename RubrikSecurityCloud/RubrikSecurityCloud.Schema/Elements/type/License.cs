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

    public override string GetGqlTypeName() {
        return "License";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> Product? Product
        // GraphQL -> product: Product! (enum)
        if (this.Product != null) {
            if (conf.Flat) {
                s += conf.Prefix + "product\n" ;
            } else {
                s += ind + "product\n" ;
            }
        }
        //      C# -> System.Single? Quantity
        // GraphQL -> quantity: Float! (scalar)
        if (this.Quantity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "quantity\n" ;
            } else {
                s += ind + "quantity\n" ;
            }
        }
        //      C# -> DateTime? TermEndDate
        // GraphQL -> termEndDate: DateTime (scalar)
        if (this.TermEndDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "termEndDate\n" ;
            } else {
                s += ind + "termEndDate\n" ;
            }
        }
        //      C# -> DateTime? TermStartDate
        // GraphQL -> termStartDate: DateTime (scalar)
        if (this.TermStartDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "termStartDate\n" ;
            } else {
                s += ind + "termStartDate\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Product? Product
        // GraphQL -> product: Product! (enum)
        if (ec.Includes("product",true))
        {
            if(this.Product == null) {

                this.Product = new Product();

            } else {


            }
        }
        else if (this.Product != null && ec.Excludes("product",true))
        {
            this.Product = null;
        }
        //      C# -> System.Single? Quantity
        // GraphQL -> quantity: Float! (scalar)
        if (ec.Includes("quantity",true))
        {
            if(this.Quantity == null) {

                this.Quantity = new System.Single();

            } else {


            }
        }
        else if (this.Quantity != null && ec.Excludes("quantity",true))
        {
            this.Quantity = null;
        }
        //      C# -> DateTime? TermEndDate
        // GraphQL -> termEndDate: DateTime (scalar)
        if (ec.Includes("termEndDate",true))
        {
            if(this.TermEndDate == null) {

                this.TermEndDate = new DateTime();

            } else {


            }
        }
        else if (this.TermEndDate != null && ec.Excludes("termEndDate",true))
        {
            this.TermEndDate = null;
        }
        //      C# -> DateTime? TermStartDate
        // GraphQL -> termStartDate: DateTime (scalar)
        if (ec.Includes("termStartDate",true))
        {
            if(this.TermStartDate == null) {

                this.TermStartDate = new DateTime();

            } else {


            }
        }
        else if (this.TermStartDate != null && ec.Excludes("termStartDate",true))
        {
            this.TermStartDate = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<License> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new License());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<License> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types