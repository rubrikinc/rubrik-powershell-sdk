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

    public override string GetGqlTypeName() {
        return "ProductTypeInfo";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<System.String>? BundleFeatures
        // GraphQL -> bundleFeatures: [String!]! (scalar)
        if (this.BundleFeatures != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bundleFeatures\n" ;
            } else {
                s += ind + "bundleFeatures\n" ;
            }
        }
        //      C# -> System.String? ProductType
        // GraphQL -> productType: String! (scalar)
        if (this.ProductType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "productType\n" ;
            } else {
                s += ind + "productType\n" ;
            }
        }
        //      C# -> List<License>? Licenses
        // GraphQL -> licenses: [License!]! (type)
        if (this.Licenses != null) {
            var fspec = this.Licenses.AsFieldSpec(conf.Child("licenses"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "licenses" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? BundleFeatures
        // GraphQL -> bundleFeatures: [String!]! (scalar)
        if (ec.Includes("bundleFeatures",true))
        {
            if(this.BundleFeatures == null) {

                this.BundleFeatures = new List<System.String>();

            } else {


            }
        }
        else if (this.BundleFeatures != null && ec.Excludes("bundleFeatures",true))
        {
            this.BundleFeatures = null;
        }
        //      C# -> System.String? ProductType
        // GraphQL -> productType: String! (scalar)
        if (ec.Includes("productType",true))
        {
            if(this.ProductType == null) {

                this.ProductType = "FETCH";

            } else {


            }
        }
        else if (this.ProductType != null && ec.Excludes("productType",true))
        {
            this.ProductType = null;
        }
        //      C# -> List<License>? Licenses
        // GraphQL -> licenses: [License!]! (type)
        if (ec.Includes("licenses",false))
        {
            if(this.Licenses == null) {

                this.Licenses = new List<License>();
                this.Licenses.ApplyExploratoryFieldSpec(ec.NewChild("licenses"));

            } else {

                this.Licenses.ApplyExploratoryFieldSpec(ec.NewChild("licenses"));

            }
        }
        else if (this.Licenses != null && ec.Excludes("licenses",false))
        {
            this.Licenses = null;
        }
    }


    #endregion

    } // class ProductTypeInfo
    
    #endregion

    public static class ListProductTypeInfoExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ProductTypeInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ProductTypeInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ProductTypeInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ProductTypeInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ProductTypeInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types