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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<System.String>? Aggregations
        // GraphQL -> aggregations: [String!]! (scalar)
        if (this.Aggregations != null) {
            s += ind + "aggregations\n" ;
        }
        //      C# -> System.String? GroupById
        // GraphQL -> groupById: String! (scalar)
        if (this.GroupById != null) {
            s += ind + "groupById\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? Aggregations
        // GraphQL -> aggregations: [String!]! (scalar)
        if (this.Aggregations == null && Exploration.Includes(parent + ".aggregations", true))
        {
            this.Aggregations = new List<System.String>();
        }
        //      C# -> System.String? GroupById
        // GraphQL -> groupById: String! (scalar)
        if (this.GroupById == null && Exploration.Includes(parent + ".groupById", true))
        {
            this.GroupById = "FETCH";
        }
    }


    #endregion

    } // class ConfigGroupBy
    
    #endregion

    public static class ListConfigGroupByExtensions
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
            this List<ConfigGroupBy> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ConfigGroupBy> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ConfigGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types