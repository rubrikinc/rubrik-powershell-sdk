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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
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

    } // class ValueInteger
    
    #endregion

    public static class ListValueIntegerExtensions
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
            this List<ValueInteger> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ValueInteger> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ValueInteger> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ValueInteger());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ValueInteger> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types