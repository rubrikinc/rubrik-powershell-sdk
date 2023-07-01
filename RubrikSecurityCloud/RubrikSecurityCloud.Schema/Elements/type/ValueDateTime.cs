// ValueDateTime.cs
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
    #region ValueDateTime
 
    public class ValueDateTime: BaseType, Value
    {
        #region members

        //      C# -> System.String? SerializedValue
        // GraphQL -> serializedValue: String! (scalar)
        [JsonProperty("serializedValue")]
        public System.String? SerializedValue { get; set; }

        //      C# -> DateTime? Value
        // GraphQL -> value: DateTime (scalar)
        [JsonProperty("value")]
        public DateTime? Value { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ValueDateTime";
    }

    public ValueDateTime Set(
        System.String? SerializedValue = null,
        DateTime? Value = null
    ) 
    {
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? SerializedValue
        // GraphQL -> serializedValue: String! (scalar)
        if (this.SerializedValue != null) {
            s += ind + "serializedValue\n" ;
        }
        //      C# -> DateTime? Value
        // GraphQL -> value: DateTime (scalar)
        if (this.Value != null) {
            s += ind + "value\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? SerializedValue
        // GraphQL -> serializedValue: String! (scalar)
        if (this.SerializedValue == null && Exploration.Includes(parent + ".serializedValue", true))
        {
            this.SerializedValue = "FETCH";
        }
        //      C# -> DateTime? Value
        // GraphQL -> value: DateTime (scalar)
        if (this.Value == null && Exploration.Includes(parent + ".value", true))
        {
            this.Value = new DateTime();
        }
    }


    #endregion

    } // class ValueDateTime
    
    #endregion

    public static class ListValueDateTimeExtensions
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
            this List<ValueDateTime> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ValueDateTime> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ValueDateTime());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types