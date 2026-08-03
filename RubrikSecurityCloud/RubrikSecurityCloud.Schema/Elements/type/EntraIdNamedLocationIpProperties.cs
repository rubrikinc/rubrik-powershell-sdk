// EntraIdNamedLocationIpProperties.cs
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
    #region EntraIdNamedLocationIpProperties
    public class EntraIdNamedLocationIpProperties: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsTrusted
        // GraphQL -> isTrusted: Boolean! (scalar)
        [JsonProperty("isTrusted")]
        public System.Boolean? IsTrusted { get; set; }

        //      C# -> List<EntraIdipRange>? IpRanges
        // GraphQL -> ipRanges: [EntraIDIPRange!]! (type)
        [JsonProperty("ipRanges")]
        public List<EntraIdipRange>? IpRanges { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EntraIDNamedLocationIPProperties";
    }

    public EntraIdNamedLocationIpProperties Set(
        System.Boolean? IsTrusted = null,
        List<EntraIdipRange>? IpRanges = null
    ) 
    {
        if ( IsTrusted != null ) {
            this.IsTrusted = IsTrusted;
        }
        if ( IpRanges != null ) {
            this.IpRanges = IpRanges;
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
        //      C# -> System.Boolean? IsTrusted
        // GraphQL -> isTrusted: Boolean! (scalar)
        if (this.IsTrusted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isTrusted\n" ;
            } else {
                s += ind + "isTrusted\n" ;
            }
        }
        //      C# -> List<EntraIdipRange>? IpRanges
        // GraphQL -> ipRanges: [EntraIDIPRange!]! (type)
        if (this.IpRanges != null) {
            var fspec = this.IpRanges.AsFieldSpec(conf.Child("ipRanges"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ipRanges" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsTrusted
        // GraphQL -> isTrusted: Boolean! (scalar)
        if (ec.Includes("isTrusted",true))
        {
            if(this.IsTrusted == null) {

                this.IsTrusted = true;

            } else {


            }
        }
        else if (this.IsTrusted != null && ec.Excludes("isTrusted",true))
        {
            this.IsTrusted = null;
        }
        //      C# -> List<EntraIdipRange>? IpRanges
        // GraphQL -> ipRanges: [EntraIDIPRange!]! (type)
        if (ec.Includes("ipRanges",false))
        {
            if(this.IpRanges == null) {

                this.IpRanges = new List<EntraIdipRange>();
                this.IpRanges.ApplyExploratoryFieldSpec(ec.NewChild("ipRanges"));

            } else {

                this.IpRanges.ApplyExploratoryFieldSpec(ec.NewChild("ipRanges"));

            }
        }
        else if (this.IpRanges != null && ec.Excludes("ipRanges",false))
        {
            this.IpRanges = null;
        }
    }


    #endregion

    } // class EntraIdNamedLocationIpProperties
    
    #endregion

    public static class ListEntraIdNamedLocationIpPropertiesExtensions
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
            this List<EntraIdNamedLocationIpProperties> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<EntraIdNamedLocationIpProperties> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<EntraIdNamedLocationIpProperties> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EntraIdNamedLocationIpProperties());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EntraIdNamedLocationIpProperties> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types