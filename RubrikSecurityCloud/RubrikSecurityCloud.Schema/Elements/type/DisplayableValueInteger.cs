// DisplayableValueInteger.cs
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
    #region DisplayableValueInteger
 
    public class DisplayableValueInteger: BaseType, DisplayableValue
    {
        #region members

        //      C# -> System.String? DisplayValue
        // GraphQL -> displayValue: String! (scalar)
        [JsonProperty("displayValue")]
        public System.String? DisplayValue { get; set; }

        //      C# -> System.String? ReportHeader
        // GraphQL -> reportHeader: String! (scalar)
        [JsonProperty("reportHeader")]
        public System.String? ReportHeader { get; set; }

        //      C# -> System.String? SerializedValue
        // GraphQL -> serializedValue: String! (scalar)
        [JsonProperty("serializedValue")]
        public System.String? SerializedValue { get; set; }

        //      C# -> System.Int32? Value
        // GraphQL -> value: Int (scalar)
        [JsonProperty("value")]
        public System.Int32? Value { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DisplayableValueInteger";
    }

    public DisplayableValueInteger Set(
        System.String? DisplayValue = null,
        System.String? ReportHeader = null,
        System.String? SerializedValue = null,
        System.Int32? Value = null
    ) 
    {
        if ( DisplayValue != null ) {
            this.DisplayValue = DisplayValue;
        }
        if ( ReportHeader != null ) {
            this.ReportHeader = ReportHeader;
        }
        if ( SerializedValue != null ) {
            this.SerializedValue = SerializedValue;
        }
        if ( Value != null ) {
            this.Value = Value;
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
        //      C# -> System.String? DisplayValue
        // GraphQL -> displayValue: String! (scalar)
        if (this.DisplayValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayValue\n" ;
            } else {
                s += ind + "displayValue\n" ;
            }
        }
        //      C# -> System.String? ReportHeader
        // GraphQL -> reportHeader: String! (scalar)
        if (this.ReportHeader != null) {
            if (conf.Flat) {
                s += conf.Prefix + "reportHeader\n" ;
            } else {
                s += ind + "reportHeader\n" ;
            }
        }
        //      C# -> System.String? SerializedValue
        // GraphQL -> serializedValue: String! (scalar)
        if (this.SerializedValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serializedValue\n" ;
            } else {
                s += ind + "serializedValue\n" ;
            }
        }
        //      C# -> System.Int32? Value
        // GraphQL -> value: Int (scalar)
        if (this.Value != null) {
            if (conf.Flat) {
                s += conf.Prefix + "value\n" ;
            } else {
                s += ind + "value\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? DisplayValue
        // GraphQL -> displayValue: String! (scalar)
        if (ec.Includes("displayValue",true))
        {
            if(this.DisplayValue == null) {

                this.DisplayValue = "FETCH";

            } else {


            }
        }
        else if (this.DisplayValue != null && ec.Excludes("displayValue",true))
        {
            this.DisplayValue = null;
        }
        //      C# -> System.String? ReportHeader
        // GraphQL -> reportHeader: String! (scalar)
        if (ec.Includes("reportHeader",true))
        {
            if(this.ReportHeader == null) {

                this.ReportHeader = "FETCH";

            } else {


            }
        }
        else if (this.ReportHeader != null && ec.Excludes("reportHeader",true))
        {
            this.ReportHeader = null;
        }
        //      C# -> System.String? SerializedValue
        // GraphQL -> serializedValue: String! (scalar)
        if (ec.Includes("serializedValue",true))
        {
            if(this.SerializedValue == null) {

                this.SerializedValue = "FETCH";

            } else {


            }
        }
        else if (this.SerializedValue != null && ec.Excludes("serializedValue",true))
        {
            this.SerializedValue = null;
        }
        //      C# -> System.Int32? Value
        // GraphQL -> value: Int (scalar)
        if (ec.Includes("value",true))
        {
            if(this.Value == null) {

                this.Value = Int32.MinValue;

            } else {


            }
        }
        else if (this.Value != null && ec.Excludes("value",true))
        {
            this.Value = null;
        }
    }


    #endregion

    } // class DisplayableValueInteger
    
    #endregion

    public static class ListDisplayableValueIntegerExtensions
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
            this List<DisplayableValueInteger> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DisplayableValueInteger> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DisplayableValueInteger> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DisplayableValueInteger());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DisplayableValueInteger> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types