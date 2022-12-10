// ProductTypeInfo.cs
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
    #region ProductTypeInfo
    public class ProductTypeInfo: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> List<System.String>? BundleFeatures
            // GraphQL -> bundleFeatures: [String!]! (scalar)
            if (this.BundleFeatures != null)
            {
                 s += ind + "bundleFeatures\n";

            }
            //      C# -> System.String? ProductType
            // GraphQL -> productType: String! (scalar)
            if (this.ProductType != null)
            {
                 s += ind + "productType\n";

            }
            //      C# -> List<License>? Licenses
            // GraphQL -> licenses: [License!]! (type)
            if (this.Licenses != null)
            {
                 s += ind + "licenses\n";

                 s += ind + "{\n" + 
                 this.Licenses.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? BundleFeatures
            // GraphQL -> bundleFeatures: [String!]! (scalar)
            if (this.BundleFeatures == null && Exploration.Includes(parent + ".bundleFeatures$"))
            {
                this.BundleFeatures = new List<System.String>();
            }
            //      C# -> System.String? ProductType
            // GraphQL -> productType: String! (scalar)
            if (this.ProductType == null && Exploration.Includes(parent + ".productType$"))
            {
                this.ProductType = new System.String("FETCH");
            }
            //      C# -> List<License>? Licenses
            // GraphQL -> licenses: [License!]! (type)
            if (this.Licenses == null && Exploration.Includes(parent + ".licenses"))
            {
                this.Licenses = new List<License>();
                this.Licenses.ApplyExploratoryFragment(parent + ".licenses");
            }
        }


    #endregion

    } // class ProductTypeInfo
    #endregion

    public static class ListProductTypeInfoExtensions
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
            this List<ProductTypeInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ProductTypeInfo> list, 
            String parent = "")
        {
            var item = new ProductTypeInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types