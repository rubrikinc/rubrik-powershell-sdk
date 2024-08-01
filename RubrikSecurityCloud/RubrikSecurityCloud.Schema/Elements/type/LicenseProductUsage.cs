// LicenseProductUsage.cs
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
    #region LicenseProductUsage
    public class LicenseProductUsage: BaseType
    {
        #region members

        //      C# -> LicenseProduct? Product
        // GraphQL -> product: LicenseProduct! (enum)
        [JsonProperty("product")]
        public LicenseProduct? Product { get; set; }

        //      C# -> ProductUsage? ProductUsage
        // GraphQL -> productUsage: ProductUsage! (union)
        [JsonProperty("productUsage")]
        public ProductUsage? ProductUsage { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LicenseProductUsage";
    }

    public LicenseProductUsage Set(
        LicenseProduct? Product = null,
        ProductUsage? ProductUsage = null
    ) 
    {
        if ( Product != null ) {
            this.Product = Product;
        }
        if ( ProductUsage != null ) {
            this.ProductUsage = ProductUsage;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> LicenseProduct? Product
        // GraphQL -> product: LicenseProduct! (enum)
        if (this.Product != null) {
            if (conf.Flat) {
                s += conf.Prefix + "product\n" ;
            } else {
                s += ind + "product\n" ;
            }
        }
        //      C# -> ProductUsage? ProductUsage
        // GraphQL -> productUsage: ProductUsage! (union)
        if (this.ProductUsage != null) {
            var fspec = this.ProductUsage.AsFieldSpec(conf.Child("productUsage"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "productUsage" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> LicenseProduct? Product
        // GraphQL -> product: LicenseProduct! (enum)
        if (ec.Includes("product",true))
        {
            if(this.Product == null) {

                this.Product = new LicenseProduct();

            } else {


            }
        }
        else if (this.Product != null && ec.Excludes("product",true))
        {
            this.Product = null;
        }
        //      C# -> ProductUsage? ProductUsage
        // GraphQL -> productUsage: ProductUsage! (union)
        if (ec.Includes("productUsage",false))
        {
            if(this.ProductUsage == null) {

                var impls = new List<ProductUsage>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("productUsage"));
                this.ProductUsage = (ProductUsage)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<ProductUsage>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("productUsage"));
                this.ProductUsage = (ProductUsage)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.ProductUsage != null && ec.Excludes("productUsage",false))
        {
            this.ProductUsage = null;
        }
    }


    #endregion

    } // class LicenseProductUsage
    
    #endregion

    public static class ListLicenseProductUsageExtensions
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<LicenseProductUsage> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LicenseProductUsage> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LicenseProductUsage> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LicenseProductUsage());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LicenseProductUsage> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types