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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> PastDurationEnum? Value
        // GraphQL -> value: PastDurationEnum (enum)
        if (this.Value != null) {
            s += ind + "value\n" ;
        }
        //      C# -> System.String? DisplayValue
        // GraphQL -> displayValue: String! (scalar)
        if (this.DisplayValue != null) {
            s += ind + "displayValue\n" ;
        }
        //      C# -> System.String? ReportHeader
        // GraphQL -> reportHeader: String! (scalar)
        if (this.ReportHeader != null) {
            s += ind + "reportHeader\n" ;
        }
        //      C# -> System.String? SerializedValue
        // GraphQL -> serializedValue: String! (scalar)
        if (this.SerializedValue != null) {
            s += ind + "serializedValue\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> PastDurationEnum? Value
        // GraphQL -> value: PastDurationEnum (enum)
        if (this.Value == null && Exploration.Includes(parent + ".value", true))
        {
            this.Value = new PastDurationEnum();
        }
        //      C# -> System.String? DisplayValue
        // GraphQL -> displayValue: String! (scalar)
        if (this.DisplayValue == null && Exploration.Includes(parent + ".displayValue", true))
        {
            this.DisplayValue = "FETCH";
        }
        //      C# -> System.String? ReportHeader
        // GraphQL -> reportHeader: String! (scalar)
        if (this.ReportHeader == null && Exploration.Includes(parent + ".reportHeader", true))
        {
            this.ReportHeader = "FETCH";
        }
        //      C# -> System.String? SerializedValue
        // GraphQL -> serializedValue: String! (scalar)
        if (this.SerializedValue == null && Exploration.Includes(parent + ".serializedValue", true))
        {
            this.SerializedValue = "FETCH";
        }
    }


    #endregion

    } // class DisplayableValueDateRange
    
    #endregion

    public static class ListDisplayableValueDateRangeExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<DisplayableValueDateRange> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DisplayableValueDateRange> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DisplayableValueDateRange());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types