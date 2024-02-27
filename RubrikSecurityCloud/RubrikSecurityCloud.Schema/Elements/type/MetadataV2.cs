// MetadataV2.cs
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
    #region MetadataV2
    public class MetadataV2: BaseType
    {
        #region members

        //      C# -> MetadataKey? Key
        // GraphQL -> key: MetadataKey! (enum)
        [JsonProperty("key")]
        public MetadataKey? Key { get; set; }

        //      C# -> List<Value>? Values
        // GraphQL -> values: [Value!]! (interface)
        [JsonProperty("values")]
        public List<Value>? Values { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MetadataV2";
    }

    public MetadataV2 Set(
        MetadataKey? Key = null,
        List<Value>? Values = null
    ) 
    {
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( Values != null ) {
            this.Values = Values;
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
        //      C# -> MetadataKey? Key
        // GraphQL -> key: MetadataKey! (enum)
        if (this.Key != null) {
            if (conf.Flat) {
                s += conf.Prefix + "key\n" ;
            } else {
                s += ind + "key\n" ;
            }
        }
        //      C# -> List<Value>? Values
        // GraphQL -> values: [Value!]! (interface)
        if (this.Values != null) {
                var fspec = this.Values.AsFieldSpec(conf.Child("values"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "values {\n" + fspec + ind + "}\n";
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> MetadataKey? Key
        // GraphQL -> key: MetadataKey! (enum)
        if (ec.Includes("key",true))
        {
            if(this.Key == null) {

                this.Key = new MetadataKey();

            } else {


            }
        }
        else if (this.Key != null && ec.Excludes("key",true))
        {
            this.Key = null;
        }
        //      C# -> List<Value>? Values
        // GraphQL -> values: [Value!]! (interface)
        if (ec.Includes("values",false))
        {
            if(this.Values == null) {

                this.Values = new List<Value>();
                this.Values.ApplyExploratoryFieldSpec(ec.NewChild("values"));

            } else {

                this.Values.ApplyExploratoryFieldSpec(ec.NewChild("values"));

            }
        }
        else if (this.Values != null && ec.Excludes("values",false))
        {
            this.Values = null;
        }
    }


    #endregion

    } // class MetadataV2
    
    #endregion

    public static class ListMetadataV2Extensions
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
            this List<MetadataV2> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<MetadataV2> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MetadataV2> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MetadataV2());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MetadataV2> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types