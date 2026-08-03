// M365IntRangeFilter.cs
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
    #region M365IntRangeFilter
    public class M365IntRangeFilter: BaseType
    {
        #region members

        //      C# -> System.Int64? MaxValue
        // GraphQL -> maxValue: Long (scalar)
        [JsonProperty("maxValue")]
        public System.Int64? MaxValue { get; set; }

        //      C# -> System.Int64? MinValue
        // GraphQL -> minValue: Long (scalar)
        [JsonProperty("minValue")]
        public System.Int64? MinValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "M365IntRangeFilter";
    }

    public M365IntRangeFilter Set(
        System.Int64? MaxValue = null,
        System.Int64? MinValue = null
    ) 
    {
        if ( MaxValue != null ) {
            this.MaxValue = MaxValue;
        }
        if ( MinValue != null ) {
            this.MinValue = MinValue;
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
        //      C# -> System.Int64? MaxValue
        // GraphQL -> maxValue: Long (scalar)
        if (this.MaxValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxValue\n" ;
            } else {
                s += ind + "maxValue\n" ;
            }
        }
        //      C# -> System.Int64? MinValue
        // GraphQL -> minValue: Long (scalar)
        if (this.MinValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "minValue\n" ;
            } else {
                s += ind + "minValue\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? MaxValue
        // GraphQL -> maxValue: Long (scalar)
        if (ec.Includes("maxValue",true))
        {
            if(this.MaxValue == null) {

                this.MaxValue = new System.Int64();

            } else {


            }
        }
        else if (this.MaxValue != null && ec.Excludes("maxValue",true))
        {
            this.MaxValue = null;
        }
        //      C# -> System.Int64? MinValue
        // GraphQL -> minValue: Long (scalar)
        if (ec.Includes("minValue",true))
        {
            if(this.MinValue == null) {

                this.MinValue = new System.Int64();

            } else {


            }
        }
        else if (this.MinValue != null && ec.Excludes("minValue",true))
        {
            this.MinValue = null;
        }
    }


    #endregion

    } // class M365IntRangeFilter
    
    #endregion

    public static class ListM365IntRangeFilterExtensions
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
            this List<M365IntRangeFilter> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<M365IntRangeFilter> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<M365IntRangeFilter> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new M365IntRangeFilter());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<M365IntRangeFilter> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types