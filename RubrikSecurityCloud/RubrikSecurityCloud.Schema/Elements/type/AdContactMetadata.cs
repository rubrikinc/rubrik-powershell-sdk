// AdContactMetadata.cs
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
    #region AdContactMetadata
 
    public class AdContactMetadata: BaseType, OnPremAdPrincipalTypeSpecificMetadata
    {
        #region members

        //      C# -> System.String? Company
        // GraphQL -> company: String! (scalar)
        [JsonProperty("company")]
        public System.String? Company { get; set; }

        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        [JsonProperty("email")]
        public System.String? Email { get; set; }

        //      C# -> System.String? Office
        // GraphQL -> office: String! (scalar)
        [JsonProperty("office")]
        public System.String? Office { get; set; }

        //      C# -> System.String? Organisation
        // GraphQL -> organisation: String! (scalar)
        [JsonProperty("organisation")]
        public System.String? Organisation { get; set; }

        //      C# -> System.String? Telephone
        // GraphQL -> telephone: String! (scalar)
        [JsonProperty("telephone")]
        public System.String? Telephone { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AdContactMetadata";
    }

    public AdContactMetadata Set(
        System.String? Company = null,
        System.String? Email = null,
        System.String? Office = null,
        System.String? Organisation = null,
        System.String? Telephone = null
    ) 
    {
        if ( Company != null ) {
            this.Company = Company;
        }
        if ( Email != null ) {
            this.Email = Email;
        }
        if ( Office != null ) {
            this.Office = Office;
        }
        if ( Organisation != null ) {
            this.Organisation = Organisation;
        }
        if ( Telephone != null ) {
            this.Telephone = Telephone;
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
        //      C# -> System.String? Company
        // GraphQL -> company: String! (scalar)
        if (this.Company != null) {
            if (conf.Flat) {
                s += conf.Prefix + "company\n" ;
            } else {
                s += ind + "company\n" ;
            }
        }
        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        if (this.Email != null) {
            if (conf.Flat) {
                s += conf.Prefix + "email\n" ;
            } else {
                s += ind + "email\n" ;
            }
        }
        //      C# -> System.String? Office
        // GraphQL -> office: String! (scalar)
        if (this.Office != null) {
            if (conf.Flat) {
                s += conf.Prefix + "office\n" ;
            } else {
                s += ind + "office\n" ;
            }
        }
        //      C# -> System.String? Organisation
        // GraphQL -> organisation: String! (scalar)
        if (this.Organisation != null) {
            if (conf.Flat) {
                s += conf.Prefix + "organisation\n" ;
            } else {
                s += ind + "organisation\n" ;
            }
        }
        //      C# -> System.String? Telephone
        // GraphQL -> telephone: String! (scalar)
        if (this.Telephone != null) {
            if (conf.Flat) {
                s += conf.Prefix + "telephone\n" ;
            } else {
                s += ind + "telephone\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Company
        // GraphQL -> company: String! (scalar)
        if (ec.Includes("company",true))
        {
            if(this.Company == null) {

                this.Company = "FETCH";

            } else {


            }
        }
        else if (this.Company != null && ec.Excludes("company",true))
        {
            this.Company = null;
        }
        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        if (ec.Includes("email",true))
        {
            if(this.Email == null) {

                this.Email = "FETCH";

            } else {


            }
        }
        else if (this.Email != null && ec.Excludes("email",true))
        {
            this.Email = null;
        }
        //      C# -> System.String? Office
        // GraphQL -> office: String! (scalar)
        if (ec.Includes("office",true))
        {
            if(this.Office == null) {

                this.Office = "FETCH";

            } else {


            }
        }
        else if (this.Office != null && ec.Excludes("office",true))
        {
            this.Office = null;
        }
        //      C# -> System.String? Organisation
        // GraphQL -> organisation: String! (scalar)
        if (ec.Includes("organisation",true))
        {
            if(this.Organisation == null) {

                this.Organisation = "FETCH";

            } else {


            }
        }
        else if (this.Organisation != null && ec.Excludes("organisation",true))
        {
            this.Organisation = null;
        }
        //      C# -> System.String? Telephone
        // GraphQL -> telephone: String! (scalar)
        if (ec.Includes("telephone",true))
        {
            if(this.Telephone == null) {

                this.Telephone = "FETCH";

            } else {


            }
        }
        else if (this.Telephone != null && ec.Excludes("telephone",true))
        {
            this.Telephone = null;
        }
    }


    #endregion

    } // class AdContactMetadata
    
    #endregion

    public static class ListAdContactMetadataExtensions
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
            this List<AdContactMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AdContactMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AdContactMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AdContactMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AdContactMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types