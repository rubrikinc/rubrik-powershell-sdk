// YaraMatchDetail.cs
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
    #region YaraMatchDetail
    public class YaraMatchDetail: BaseType
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<System.String>? Tags
        // GraphQL -> tags: [String!]! (scalar)
        [JsonProperty("tags")]
        public List<System.String>? Tags { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "YARAMatchDetail";
    }

    public YaraMatchDetail Set(
        System.String? Name = null,
        List<System.String>? Tags = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Tags != null ) {
            this.Tags = Tags;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> List<System.String>? Tags
        // GraphQL -> tags: [String!]! (scalar)
        if (this.Tags != null) {
            s += ind + "tags\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> List<System.String>? Tags
        // GraphQL -> tags: [String!]! (scalar)
        if (this.Tags == null && Exploration.Includes(parent + ".tags", true))
        {
            this.Tags = new List<System.String>();
        }
    }


    #endregion

    } // class YaraMatchDetail
    
    #endregion

    public static class ListYaraMatchDetailExtensions
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
            this List<YaraMatchDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<YaraMatchDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new YaraMatchDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types