// AspValue.cs
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
    #region AspValue
    public class AspValue: BaseType
    {
        #region members

        //      C# -> System.String? Value
        // GraphQL -> value: String! (scalar)
        [JsonProperty("value")]
        public System.String? Value { get; set; }

        //      C# -> AspKey? Key
        // GraphQL -> key: ASPKey (type)
        [JsonProperty("key")]
        public AspKey? Key { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ASPValue";
    }

    public AspValue Set(
        System.String? Value = null,
        AspKey? Key = null
    ) 
    {
        if ( Value != null ) {
            this.Value = Value;
        }
        if ( Key != null ) {
            this.Key = Key;
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
        //      C# -> System.String? Value
        // GraphQL -> value: String! (scalar)
        if (this.Value != null) {
            s += ind + "value\n" ;
        }
        //      C# -> AspKey? Key
        // GraphQL -> key: ASPKey (type)
        if (this.Key != null) {
            var fspec = this.Key.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "key {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Value
        // GraphQL -> value: String! (scalar)
        if (this.Value == null && ec.Includes("value",true))
        {
            this.Value = "FETCH";
        }
        //      C# -> AspKey? Key
        // GraphQL -> key: ASPKey (type)
        if (this.Key == null && ec.Includes("key",false))
        {
            this.Key = new AspKey();
            this.Key.ApplyExploratoryFieldSpec(ec.NewChild("key"));
        }
    }


    #endregion

    } // class AspValue
    
    #endregion

    public static class ListAspValueExtensions
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
            this List<AspValue> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AspValue> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AspValue());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AspValue> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types