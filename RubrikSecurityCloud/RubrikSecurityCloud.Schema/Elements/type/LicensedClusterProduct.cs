// LicensedClusterProduct.cs
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
    #region LicensedClusterProduct
    public class LicensedClusterProduct: BaseType
    {
        #region members

        //      C# -> Product? Product
        // GraphQL -> product: Product! (enum)
        [JsonProperty("product")]
        public Product? Product { get; set; }

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LicensedClusterProduct";
    }

    public LicensedClusterProduct Set(
        Product? Product = null,
        System.Single? NextExpiringBytes = null,
        DateTime? NextExpiringTime = null,
        System.Int32? NumClusters = null,
        List<System.String>? ProductTypes = null,
        System.Single? PurchasedCapacityBytes = null,
        System.Single? RegisteredCapacityBytes = null,
        List<CapacityContribution>? Contributions = null
    ) 
    {
        if ( Product != null ) {
            this.Product = Product;
        }
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
        //      C# -> Product? Product
        // GraphQL -> product: Product! (enum)
        if (this.Product != null) {
            if (conf.Flat) {
                s += conf.Prefix + "product\n" ;
            } else {
                s += ind + "product\n" ;
            }
        }
        //      C# -> System.Single? NextExpiringBytes
        // GraphQL -> nextExpiringBytes: Float! (scalar)
        if (this.NextExpiringBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nextExpiringBytes\n" ;
            } else {
                s += ind + "nextExpiringBytes\n" ;
            }
        }
        //      C# -> DateTime? NextExpiringTime
        // GraphQL -> nextExpiringTime: DateTime (scalar)
        if (this.NextExpiringTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nextExpiringTime\n" ;
            } else {
                s += ind + "nextExpiringTime\n" ;
            }
        }
        //      C# -> System.Int32? NumClusters
        // GraphQL -> numClusters: Int! (scalar)
        if (this.NumClusters != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numClusters\n" ;
            } else {
                s += ind + "numClusters\n" ;
            }
        }
        //      C# -> List<System.String>? ProductTypes
        // GraphQL -> productTypes: [String!]! (scalar)
        if (this.ProductTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "productTypes\n" ;
            } else {
                s += ind + "productTypes\n" ;
            }
        }
        //      C# -> System.Single? PurchasedCapacityBytes
        // GraphQL -> purchasedCapacityBytes: Float! (scalar)
        if (this.PurchasedCapacityBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "purchasedCapacityBytes\n" ;
            } else {
                s += ind + "purchasedCapacityBytes\n" ;
            }
        }
        //      C# -> System.Single? RegisteredCapacityBytes
        // GraphQL -> registeredCapacityBytes: Float! (scalar)
        if (this.RegisteredCapacityBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "registeredCapacityBytes\n" ;
            } else {
                s += ind + "registeredCapacityBytes\n" ;
            }
        }
        //      C# -> List<CapacityContribution>? Contributions
        // GraphQL -> contributions: [CapacityContribution!]! (type)
        if (this.Contributions != null) {
            var fspec = this.Contributions.AsFieldSpec(conf.Child("contributions"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "contributions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
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
        //      C# -> System.Single? NextExpiringBytes
        // GraphQL -> nextExpiringBytes: Float! (scalar)
        if (ec.Includes("nextExpiringBytes",true))
        {
            if(this.NextExpiringBytes == null) {

                this.NextExpiringBytes = new System.Single();

            } else {


            }
        }
        else if (this.NextExpiringBytes != null && ec.Excludes("nextExpiringBytes",true))
        {
            this.NextExpiringBytes = null;
        }
        //      C# -> DateTime? NextExpiringTime
        // GraphQL -> nextExpiringTime: DateTime (scalar)
        if (ec.Includes("nextExpiringTime",true))
        {
            if(this.NextExpiringTime == null) {

                this.NextExpiringTime = new DateTime();

            } else {


            }
        }
        else if (this.NextExpiringTime != null && ec.Excludes("nextExpiringTime",true))
        {
            this.NextExpiringTime = null;
        }
        //      C# -> System.Int32? NumClusters
        // GraphQL -> numClusters: Int! (scalar)
        if (ec.Includes("numClusters",true))
        {
            if(this.NumClusters == null) {

                this.NumClusters = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumClusters != null && ec.Excludes("numClusters",true))
        {
            this.NumClusters = null;
        }
        //      C# -> List<System.String>? ProductTypes
        // GraphQL -> productTypes: [String!]! (scalar)
        if (ec.Includes("productTypes",true))
        {
            if(this.ProductTypes == null) {

                this.ProductTypes = new List<System.String>();

            } else {


            }
        }
        else if (this.ProductTypes != null && ec.Excludes("productTypes",true))
        {
            this.ProductTypes = null;
        }
        //      C# -> System.Single? PurchasedCapacityBytes
        // GraphQL -> purchasedCapacityBytes: Float! (scalar)
        if (ec.Includes("purchasedCapacityBytes",true))
        {
            if(this.PurchasedCapacityBytes == null) {

                this.PurchasedCapacityBytes = new System.Single();

            } else {


            }
        }
        else if (this.PurchasedCapacityBytes != null && ec.Excludes("purchasedCapacityBytes",true))
        {
            this.PurchasedCapacityBytes = null;
        }
        //      C# -> System.Single? RegisteredCapacityBytes
        // GraphQL -> registeredCapacityBytes: Float! (scalar)
        if (ec.Includes("registeredCapacityBytes",true))
        {
            if(this.RegisteredCapacityBytes == null) {

                this.RegisteredCapacityBytes = new System.Single();

            } else {


            }
        }
        else if (this.RegisteredCapacityBytes != null && ec.Excludes("registeredCapacityBytes",true))
        {
            this.RegisteredCapacityBytes = null;
        }
        //      C# -> List<CapacityContribution>? Contributions
        // GraphQL -> contributions: [CapacityContribution!]! (type)
        if (ec.Includes("contributions",false))
        {
            if(this.Contributions == null) {

                this.Contributions = new List<CapacityContribution>();
                this.Contributions.ApplyExploratoryFieldSpec(ec.NewChild("contributions"));

            } else {

                this.Contributions.ApplyExploratoryFieldSpec(ec.NewChild("contributions"));

            }
        }
        else if (this.Contributions != null && ec.Excludes("contributions",false))
        {
            this.Contributions = null;
        }
    }


    #endregion

    } // class LicensedClusterProduct
    
    #endregion

    public static class ListLicensedClusterProductExtensions
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
            this List<LicensedClusterProduct> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LicensedClusterProduct> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LicensedClusterProduct> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LicensedClusterProduct());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LicensedClusterProduct> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types