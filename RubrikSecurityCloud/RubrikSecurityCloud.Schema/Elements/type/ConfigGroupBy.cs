// ConfigGroupBy.cs
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
    #region ConfigGroupBy
    public class ConfigGroupBy: BaseType
    {
        #region members

        //      C# -> List<System.String>? Aggregations
        // GraphQL -> aggregations: [String!]! (scalar)
        [JsonProperty("aggregations")]
        public List<System.String>? Aggregations { get; set; }

        //      C# -> System.String? GroupById
        // GraphQL -> groupById: String! (scalar)
        [JsonProperty("groupById")]
        public System.String? GroupById { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "configGroupBy";
    }

    public ConfigGroupBy Set(
        List<System.String>? Aggregations = null,
        System.String? GroupById = null
    ) 
    {
        if ( Aggregations != null ) {
            this.Aggregations = Aggregations;
        }
        if ( GroupById != null ) {
            this.GroupById = GroupById;
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
        //      C# -> List<System.String>? Aggregations
        // GraphQL -> aggregations: [String!]! (scalar)
        if (this.Aggregations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "aggregations\n" ;
            } else {
                s += ind + "aggregations\n" ;
            }
        }
        //      C# -> System.String? GroupById
        // GraphQL -> groupById: String! (scalar)
        if (this.GroupById != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupById\n" ;
            } else {
                s += ind + "groupById\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? Aggregations
        // GraphQL -> aggregations: [String!]! (scalar)
        if (ec.Includes("aggregations",true))
        {
            if(this.Aggregations == null) {

                this.Aggregations = new List<System.String>();

            } else {


            }
        }
        else if (this.Aggregations != null && ec.Excludes("aggregations",true))
        {
            this.Aggregations = null;
        }
        //      C# -> System.String? GroupById
        // GraphQL -> groupById: String! (scalar)
        if (ec.Includes("groupById",true))
        {
            if(this.GroupById == null) {

                this.GroupById = "FETCH";

            } else {


            }
        }
        else if (this.GroupById != null && ec.Excludes("groupById",true))
        {
            this.GroupById = null;
        }
    }


    #endregion

    } // class ConfigGroupBy
    
    #endregion

    public static class ListConfigGroupByExtensions
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
            this List<ConfigGroupBy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ConfigGroupBy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ConfigGroupBy> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ConfigGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ConfigGroupBy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types