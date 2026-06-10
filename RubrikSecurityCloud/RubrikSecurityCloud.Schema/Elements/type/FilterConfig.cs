// FilterConfig.cs
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
    #region FilterConfig
 
    public class FilterConfig: BaseType, NestedFilterConfig
    {
        #region members

        //      C# -> Relationship? Relationship
        // GraphQL -> relationship: Relationship! (enum)
        [JsonProperty("relationship")]
        public Relationship? Relationship { get; set; }

        //      C# -> FilterType? Type
        // GraphQL -> type: FilterType! (enum)
        [JsonProperty("type")]
        public FilterType? Type { get; set; }

        //      C# -> List<System.String>? Values
        // GraphQL -> values: [String!]! (scalar)
        [JsonProperty("values")]
        public List<System.String>? Values { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FilterConfig";
    }

    public FilterConfig Set(
        Relationship? Relationship = null,
        FilterType? Type = null,
        List<System.String>? Values = null
    ) 
    {
        if ( Relationship != null ) {
            this.Relationship = Relationship;
        }
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( Values != null ) {
            this.Values = Values;
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
        //      C# -> Relationship? Relationship
        // GraphQL -> relationship: Relationship! (enum)
        if (this.Relationship != null) {
            if (conf.Flat) {
                s += conf.Prefix + "relationship\n" ;
            } else {
                s += ind + "relationship\n" ;
            }
        }
        //      C# -> FilterType? Type
        // GraphQL -> type: FilterType! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> List<System.String>? Values
        // GraphQL -> values: [String!]! (scalar)
        if (this.Values != null) {
            if (conf.Flat) {
                s += conf.Prefix + "values\n" ;
            } else {
                s += ind + "values\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> Relationship? Relationship
        // GraphQL -> relationship: Relationship! (enum)
        if (ec.Includes("relationship",true))
        {
            if(this.Relationship == null) {

                this.Relationship = new Relationship();

            } else {


            }
        }
        else if (this.Relationship != null && ec.Excludes("relationship",true))
        {
            this.Relationship = null;
        }
        //      C# -> FilterType? Type
        // GraphQL -> type: FilterType! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new FilterType();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> List<System.String>? Values
        // GraphQL -> values: [String!]! (scalar)
        if (ec.Includes("values",true))
        {
            if(this.Values == null) {

                this.Values = new List<System.String>();

            } else {


            }
        }
        else if (this.Values != null && ec.Excludes("values",true))
        {
            this.Values = null;
        }
    }


    #endregion

    } // class FilterConfig
    
    #endregion

    public static class ListFilterConfigExtensions
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
            this List<FilterConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FilterConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FilterConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FilterConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FilterConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types