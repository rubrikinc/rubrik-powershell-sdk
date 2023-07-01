// ValueInteger.cs
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
    #region ValueInteger
 
    public class ValueInteger: BaseType, Value
    {
        #region members

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
        return "ValueInteger";
    }

    public ValueInteger Set(
        System.String? SerializedValue = null,
        System.Int32? Value = null
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
        //      C# -> System.Int32? Value
        // GraphQL -> value: Int (scalar)
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
        //      C# -> System.Int32? Value
        // GraphQL -> value: Int (scalar)
        if (this.Value == null && Exploration.Includes(parent + ".value", true))
        {
            this.Value = Int32.MinValue;
        }
    }


    #endregion

    } // class ValueInteger
    
    #endregion

    public static class ListValueIntegerExtensions
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
            this List<ValueInteger> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ValueInteger> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ValueInteger());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types