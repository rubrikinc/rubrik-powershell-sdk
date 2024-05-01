// DisplayableValueDateRange.cs
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
    #region DisplayableValueDateRange
 
    public class DisplayableValueDateRange: BaseType, DisplayableValue
    {
        #region members

        //      C# -> PastDurationEnum? Value
        // GraphQL -> value: PastDurationEnum (enum)
        [JsonProperty("value")]
        public PastDurationEnum? Value { get; set; }

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DisplayableValueDateRange";
    }

    public DisplayableValueDateRange Set(
        PastDurationEnum? Value = null,
        System.String? DisplayValue = null,
        System.String? ReportHeader = null,
        System.String? SerializedValue = null
    ) 
    {
        if ( Value != null ) {
            this.Value = Value;
        }
        if ( DisplayValue != null ) {
            this.DisplayValue = DisplayValue;
        }
        if ( ReportHeader != null ) {
            this.ReportHeader = ReportHeader;
        }
        if ( SerializedValue != null ) {
            this.SerializedValue = SerializedValue;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> PastDurationEnum? Value
        // GraphQL -> value: PastDurationEnum (enum)
        if (this.Value != null) {
            if (conf.Flat) {
                s += conf.Prefix + "value\n" ;
            } else {
                s += ind + "value\n" ;
            }
        }
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> PastDurationEnum? Value
        // GraphQL -> value: PastDurationEnum (enum)
        if (ec.Includes("value",true))
        {
            if(this.Value == null) {

                this.Value = new PastDurationEnum();

            } else {


            }
        }
        else if (this.Value != null && ec.Excludes("value",true))
        {
            this.Value = null;
        }
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
    }


    #endregion

    } // class DisplayableValueDateRange
    
    #endregion

    public static class ListDisplayableValueDateRangeExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<DisplayableValueDateRange> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DisplayableValueDateRange> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DisplayableValueDateRange> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DisplayableValueDateRange());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DisplayableValueDateRange> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types