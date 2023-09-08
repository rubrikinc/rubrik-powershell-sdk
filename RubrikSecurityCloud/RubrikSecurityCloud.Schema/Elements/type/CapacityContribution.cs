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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region CapacityContribution
    public class CapacityContribution: BaseType
    {
        #region members

        //      C# -> Product? Product
        // GraphQL -> product: Product! (enum)
        [JsonProperty("product")]
        public Product? Product { get; set; }

        //      C# -> System.Single? RegisteredCapacityBytes
        // GraphQL -> registeredCapacityBytes: Float! (scalar)
        [JsonProperty("registeredCapacityBytes")]
        public System.Single? RegisteredCapacityBytes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CapacityContribution";
    }

    public CapacityContribution Set(
        Product? Product = null,
        System.Single? RegisteredCapacityBytes = null
    ) 
    {
        if ( Product != null ) {
            this.Product = Product;
        }
        if ( RegisteredCapacityBytes != null ) {
            this.RegisteredCapacityBytes = RegisteredCapacityBytes;
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
        //      C# -> System.Single? RegisteredCapacityBytes
        // GraphQL -> registeredCapacityBytes: Float! (scalar)
        if (this.RegisteredCapacityBytes != null) {
            s += ind + "registeredCapacityBytes\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Product? Product
        // GraphQL -> product: Product! (enum)
        if (this.Product == null && ec.Includes("product",true))
        {
            this.Product = new Product();
        }
        //      C# -> System.Single? RegisteredCapacityBytes
        // GraphQL -> registeredCapacityBytes: Float! (scalar)
        if (this.RegisteredCapacityBytes == null && ec.Includes("registeredCapacityBytes",true))
        {
            this.RegisteredCapacityBytes = new System.Single();
        }
    }


    #endregion

    } // class CapacityContribution
    
    #endregion

    public static class ListCapacityContributionExtensions
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
            this List<CapacityContribution> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CapacityContribution> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CapacityContribution());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<CapacityContribution> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types