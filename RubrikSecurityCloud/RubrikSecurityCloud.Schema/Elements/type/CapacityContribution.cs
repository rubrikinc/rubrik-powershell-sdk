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
        //      C# -> System.Single? RegisteredCapacityBytes
        // GraphQL -> registeredCapacityBytes: Float! (scalar)
        if (this.RegisteredCapacityBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "registeredCapacityBytes\n" ;
            } else {
                s += ind + "registeredCapacityBytes\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
    }


    #endregion

    } // class CapacityContribution
    
    #endregion

    public static class ListCapacityContributionExtensions
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
            this List<CapacityContribution> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CapacityContribution> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CapacityContribution> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CapacityContribution());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CapacityContribution> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types