// Metadata.cs
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
    #region Metadata
    public class Metadata: BaseType
    {
        #region members

        //      C# -> Value? Value
        // GraphQL -> value: Value (interface)
        [JsonProperty("value")]
        public Value? Value { get; set; }

        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Metadata";
    }

    public Metadata Set(
        Value? Value = null,
        System.String? Key = null
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
        //      C# -> Value? Value
        // GraphQL -> value: Value (interface)
        if (this.Value != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.Value).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "value {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key != null) {
            s += ind + "key\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> Value? Value
        // GraphQL -> value: Value (interface)
        if (this.Value == null && Exploration.Includes(parent + ".value"))
        {
            var impls = new List<Value>();
            impls.ApplyExploratoryFieldSpec(parent + ".value");
            this.Value = (Value)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key == null && Exploration.Includes(parent + ".key", true))
        {
            this.Key = "FETCH";
        }
    }


    #endregion

    } // class Metadata
    
    #endregion

    public static class ListMetadataExtensions
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
            this List<Metadata> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Metadata> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Metadata());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types