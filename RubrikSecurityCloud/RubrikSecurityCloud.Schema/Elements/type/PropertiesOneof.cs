// PropertiesOneof.cs
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
    #region PropertiesOneof
    public class PropertiesOneof: BaseType
    {
        #region members

        //      C# -> EntraIdNamedLocationCountryProperties? CountryMetadata
        // GraphQL -> countryMetadata: EntraIDNamedLocationCountryProperties (type)
        [JsonProperty("countryMetadata")]
        public EntraIdNamedLocationCountryProperties? CountryMetadata { get; set; }

        //      C# -> EntraIdNamedLocationIpProperties? IpMetadata
        // GraphQL -> ipMetadata: EntraIDNamedLocationIPProperties (type)
        [JsonProperty("ipMetadata")]
        public EntraIdNamedLocationIpProperties? IpMetadata { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PropertiesOneof";
    }

    public PropertiesOneof Set(
        EntraIdNamedLocationCountryProperties? CountryMetadata = null,
        EntraIdNamedLocationIpProperties? IpMetadata = null
    ) 
    {
        if ( CountryMetadata != null ) {
            this.CountryMetadata = CountryMetadata;
        }
        if ( IpMetadata != null ) {
            this.IpMetadata = IpMetadata;
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
        //      C# -> EntraIdNamedLocationCountryProperties? CountryMetadata
        // GraphQL -> countryMetadata: EntraIDNamedLocationCountryProperties (type)
        if (this.CountryMetadata != null) {
            var fspec = this.CountryMetadata.AsFieldSpec(conf.Child("countryMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "countryMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> EntraIdNamedLocationIpProperties? IpMetadata
        // GraphQL -> ipMetadata: EntraIDNamedLocationIPProperties (type)
        if (this.IpMetadata != null) {
            var fspec = this.IpMetadata.AsFieldSpec(conf.Child("ipMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ipMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> EntraIdNamedLocationCountryProperties? CountryMetadata
        // GraphQL -> countryMetadata: EntraIDNamedLocationCountryProperties (type)
        if (ec.Includes("countryMetadata",false))
        {
            if(this.CountryMetadata == null) {

                this.CountryMetadata = new EntraIdNamedLocationCountryProperties();
                this.CountryMetadata.ApplyExploratoryFieldSpec(ec.NewChild("countryMetadata"));

            } else {

                this.CountryMetadata.ApplyExploratoryFieldSpec(ec.NewChild("countryMetadata"));

            }
        }
        else if (this.CountryMetadata != null && ec.Excludes("countryMetadata",false))
        {
            this.CountryMetadata = null;
        }
        //      C# -> EntraIdNamedLocationIpProperties? IpMetadata
        // GraphQL -> ipMetadata: EntraIDNamedLocationIPProperties (type)
        if (ec.Includes("ipMetadata",false))
        {
            if(this.IpMetadata == null) {

                this.IpMetadata = new EntraIdNamedLocationIpProperties();
                this.IpMetadata.ApplyExploratoryFieldSpec(ec.NewChild("ipMetadata"));

            } else {

                this.IpMetadata.ApplyExploratoryFieldSpec(ec.NewChild("ipMetadata"));

            }
        }
        else if (this.IpMetadata != null && ec.Excludes("ipMetadata",false))
        {
            this.IpMetadata = null;
        }
    }


    #endregion

    } // class PropertiesOneof
    
    #endregion

    public static class ListPropertiesOneofExtensions
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
            this List<PropertiesOneof> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PropertiesOneof> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PropertiesOneof> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PropertiesOneof());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PropertiesOneof> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types