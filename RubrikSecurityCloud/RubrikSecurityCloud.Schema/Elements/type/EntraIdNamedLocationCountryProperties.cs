// EntraIdNamedLocationCountryProperties.cs
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
    #region EntraIdNamedLocationCountryProperties
    public class EntraIdNamedLocationCountryProperties: BaseType
    {
        #region members

        //      C# -> EntraIdCountryLookupMethod? CountryLookupMethod
        // GraphQL -> countryLookupMethod: EntraIDCountryLookupMethod! (enum)
        [JsonProperty("countryLookupMethod")]
        public EntraIdCountryLookupMethod? CountryLookupMethod { get; set; }

        //      C# -> List<System.String>? CountriesAndRegions
        // GraphQL -> countriesAndRegions: [String!]! (scalar)
        [JsonProperty("countriesAndRegions")]
        public List<System.String>? CountriesAndRegions { get; set; }

        //      C# -> System.Boolean? IncludeUnknownCountriesAndRegions
        // GraphQL -> includeUnknownCountriesAndRegions: Boolean! (scalar)
        [JsonProperty("includeUnknownCountriesAndRegions")]
        public System.Boolean? IncludeUnknownCountriesAndRegions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EntraIDNamedLocationCountryProperties";
    }

    public EntraIdNamedLocationCountryProperties Set(
        EntraIdCountryLookupMethod? CountryLookupMethod = null,
        List<System.String>? CountriesAndRegions = null,
        System.Boolean? IncludeUnknownCountriesAndRegions = null
    ) 
    {
        if ( CountryLookupMethod != null ) {
            this.CountryLookupMethod = CountryLookupMethod;
        }
        if ( CountriesAndRegions != null ) {
            this.CountriesAndRegions = CountriesAndRegions;
        }
        if ( IncludeUnknownCountriesAndRegions != null ) {
            this.IncludeUnknownCountriesAndRegions = IncludeUnknownCountriesAndRegions;
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
        //      C# -> EntraIdCountryLookupMethod? CountryLookupMethod
        // GraphQL -> countryLookupMethod: EntraIDCountryLookupMethod! (enum)
        if (this.CountryLookupMethod != null) {
            if (conf.Flat) {
                s += conf.Prefix + "countryLookupMethod\n" ;
            } else {
                s += ind + "countryLookupMethod\n" ;
            }
        }
        //      C# -> List<System.String>? CountriesAndRegions
        // GraphQL -> countriesAndRegions: [String!]! (scalar)
        if (this.CountriesAndRegions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "countriesAndRegions\n" ;
            } else {
                s += ind + "countriesAndRegions\n" ;
            }
        }
        //      C# -> System.Boolean? IncludeUnknownCountriesAndRegions
        // GraphQL -> includeUnknownCountriesAndRegions: Boolean! (scalar)
        if (this.IncludeUnknownCountriesAndRegions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "includeUnknownCountriesAndRegions\n" ;
            } else {
                s += ind + "includeUnknownCountriesAndRegions\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> EntraIdCountryLookupMethod? CountryLookupMethod
        // GraphQL -> countryLookupMethod: EntraIDCountryLookupMethod! (enum)
        if (ec.Includes("countryLookupMethod",true))
        {
            if(this.CountryLookupMethod == null) {

                this.CountryLookupMethod = new EntraIdCountryLookupMethod();

            } else {


            }
        }
        else if (this.CountryLookupMethod != null && ec.Excludes("countryLookupMethod",true))
        {
            this.CountryLookupMethod = null;
        }
        //      C# -> List<System.String>? CountriesAndRegions
        // GraphQL -> countriesAndRegions: [String!]! (scalar)
        if (ec.Includes("countriesAndRegions",true))
        {
            if(this.CountriesAndRegions == null) {

                this.CountriesAndRegions = new List<System.String>();

            } else {


            }
        }
        else if (this.CountriesAndRegions != null && ec.Excludes("countriesAndRegions",true))
        {
            this.CountriesAndRegions = null;
        }
        //      C# -> System.Boolean? IncludeUnknownCountriesAndRegions
        // GraphQL -> includeUnknownCountriesAndRegions: Boolean! (scalar)
        if (ec.Includes("includeUnknownCountriesAndRegions",true))
        {
            if(this.IncludeUnknownCountriesAndRegions == null) {

                this.IncludeUnknownCountriesAndRegions = true;

            } else {


            }
        }
        else if (this.IncludeUnknownCountriesAndRegions != null && ec.Excludes("includeUnknownCountriesAndRegions",true))
        {
            this.IncludeUnknownCountriesAndRegions = null;
        }
    }


    #endregion

    } // class EntraIdNamedLocationCountryProperties
    
    #endregion

    public static class ListEntraIdNamedLocationCountryPropertiesExtensions
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
            this List<EntraIdNamedLocationCountryProperties> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<EntraIdNamedLocationCountryProperties> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<EntraIdNamedLocationCountryProperties> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EntraIdNamedLocationCountryProperties());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EntraIdNamedLocationCountryProperties> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types