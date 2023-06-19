// ProductTypeInfo.cs
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
    #region ProductTypeInfo
    public class ProductTypeInfo: BaseType
    {
        #region members

        //      C# -> List<System.String>? BundleFeatures
        // GraphQL -> bundleFeatures: [String!]! (scalar)
        [JsonProperty("bundleFeatures")]
        public List<System.String>? BundleFeatures { get; set; }

        //      C# -> System.String? ProductType
        // GraphQL -> productType: String! (scalar)
        [JsonProperty("productType")]
        public System.String? ProductType { get; set; }

        //      C# -> List<License>? Licenses
        // GraphQL -> licenses: [License!]! (type)
        [JsonProperty("licenses")]
        public List<License>? Licenses { get; set; }


        #endregion

    #region methods

    public ProductTypeInfo Set(
        List<System.String>? BundleFeatures = null,
        System.String? ProductType = null,
        List<License>? Licenses = null
    ) 
    {
        if ( BundleFeatures != null ) {
            this.BundleFeatures = BundleFeatures;
        }
        if ( ProductType != null ) {
            this.ProductType = ProductType;
        }
        if ( Licenses != null ) {
            this.Licenses = Licenses;
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
        //      C# -> List<System.String>? BundleFeatures
        // GraphQL -> bundleFeatures: [String!]! (scalar)
        if (this.BundleFeatures != null) {
            s += ind + "bundleFeatures\n" ;
        }
        //      C# -> System.String? ProductType
        // GraphQL -> productType: String! (scalar)
        if (this.ProductType != null) {
            s += ind + "productType\n" ;
        }
        //      C# -> List<License>? Licenses
        // GraphQL -> licenses: [License!]! (type)
        if (this.Licenses != null) {
            var fspec = this.Licenses.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "licenses {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? BundleFeatures
        // GraphQL -> bundleFeatures: [String!]! (scalar)
        if (this.BundleFeatures == null && Exploration.Includes(parent + ".bundleFeatures", true))
        {
            this.BundleFeatures = new List<System.String>();
        }
        //      C# -> System.String? ProductType
        // GraphQL -> productType: String! (scalar)
        if (this.ProductType == null && Exploration.Includes(parent + ".productType", true))
        {
            this.ProductType = "FETCH";
        }
        //      C# -> List<License>? Licenses
        // GraphQL -> licenses: [License!]! (type)
        if (this.Licenses == null && Exploration.Includes(parent + ".licenses"))
        {
            this.Licenses = new List<License>();
            this.Licenses.ApplyExploratoryFieldSpec(parent + ".licenses");
        }
    }


    #endregion

    } // class ProductTypeInfo
    
    #endregion

    public static class ListProductTypeInfoExtensions
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
            this List<ProductTypeInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ProductTypeInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ProductTypeInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types