// Map.cs
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
    #region Map
    public class Map: BaseType
    {
        #region members

        //      C# -> List<System.String>? Keys
        // GraphQL -> keys: [String!]! (scalar)
        [JsonProperty("keys")]
        public List<System.String>? Keys { get; set; }

        //      C# -> List<RelatedObjectIdsType>? Values
        // GraphQL -> values: [RelatedObjectIdsType!]! (type)
        [JsonProperty("values")]
        public List<RelatedObjectIdsType>? Values { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Map";
    }

    public Map Set(
        List<System.String>? Keys = null,
        List<RelatedObjectIdsType>? Values = null
    ) 
    {
        if ( Keys != null ) {
            this.Keys = Keys;
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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<System.String>? Keys
        // GraphQL -> keys: [String!]! (scalar)
        if (this.Keys != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keys\n" ;
            } else {
                s += ind + "keys\n" ;
            }
        }
        //      C# -> List<RelatedObjectIdsType>? Values
        // GraphQL -> values: [RelatedObjectIdsType!]! (type)
        if (this.Values != null) {
            var fspec = this.Values.AsFieldSpec(conf.Child("values"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "values {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? Keys
        // GraphQL -> keys: [String!]! (scalar)
        if (ec.Includes("keys",true))
        {
            if(this.Keys == null) {

                this.Keys = new List<System.String>();

            } else {


            }
        }
        else if (this.Keys != null && ec.Excludes("keys",true))
        {
            this.Keys = null;
        }
        //      C# -> List<RelatedObjectIdsType>? Values
        // GraphQL -> values: [RelatedObjectIdsType!]! (type)
        if (ec.Includes("values",false))
        {
            if(this.Values == null) {

                this.Values = new List<RelatedObjectIdsType>();
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

    } // class Map
    
    #endregion

    public static class ListMapExtensions
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
            this List<Map> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Map> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Map> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Map());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Map> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types