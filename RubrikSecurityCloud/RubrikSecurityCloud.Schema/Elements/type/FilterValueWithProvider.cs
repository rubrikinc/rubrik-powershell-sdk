// FilterValueWithProvider.cs
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
    #region FilterValueWithProvider
    public class FilterValueWithProvider: BaseType
    {
        #region members

        //      C# -> System.String? Provider
        // GraphQL -> provider: String! (scalar)
        [JsonProperty("provider")]
        public System.String? Provider { get; set; }

        //      C# -> FilterValue? FilterValue
        // GraphQL -> filterValue: FilterValue (type)
        [JsonProperty("filterValue")]
        public FilterValue? FilterValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FilterValueWithProvider";
    }

    public FilterValueWithProvider Set(
        System.String? Provider = null,
        FilterValue? FilterValue = null
    ) 
    {
        if ( Provider != null ) {
            this.Provider = Provider;
        }
        if ( FilterValue != null ) {
            this.FilterValue = FilterValue;
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
        //      C# -> System.String? Provider
        // GraphQL -> provider: String! (scalar)
        if (this.Provider != null) {
            if (conf.Flat) {
                s += conf.Prefix + "provider\n" ;
            } else {
                s += ind + "provider\n" ;
            }
        }
        //      C# -> FilterValue? FilterValue
        // GraphQL -> filterValue: FilterValue (type)
        if (this.FilterValue != null) {
            var fspec = this.FilterValue.AsFieldSpec(conf.Child("filterValue"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "filterValue" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Provider
        // GraphQL -> provider: String! (scalar)
        if (ec.Includes("provider",true))
        {
            if(this.Provider == null) {

                this.Provider = "FETCH";

            } else {


            }
        }
        else if (this.Provider != null && ec.Excludes("provider",true))
        {
            this.Provider = null;
        }
        //      C# -> FilterValue? FilterValue
        // GraphQL -> filterValue: FilterValue (type)
        if (ec.Includes("filterValue",false))
        {
            if(this.FilterValue == null) {

                this.FilterValue = new FilterValue();
                this.FilterValue.ApplyExploratoryFieldSpec(ec.NewChild("filterValue"));

            } else {

                this.FilterValue.ApplyExploratoryFieldSpec(ec.NewChild("filterValue"));

            }
        }
        else if (this.FilterValue != null && ec.Excludes("filterValue",false))
        {
            this.FilterValue = null;
        }
    }


    #endregion

    } // class FilterValueWithProvider
    
    #endregion

    public static class ListFilterValueWithProviderExtensions
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
            this List<FilterValueWithProvider> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FilterValueWithProvider> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FilterValueWithProvider> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FilterValueWithProvider());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FilterValueWithProvider> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types