// Item.cs
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
    #region Item
    public class Item: BaseType
    {
        #region members

        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        [JsonProperty("appItemTypeToken")]
        public System.String? AppItemTypeToken { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Item";
    }

    public Item Set(
        System.String? AppItemTypeToken = null,
        System.String? Id = null
    ) 
    {
        if ( AppItemTypeToken != null ) {
            this.AppItemTypeToken = AppItemTypeToken;
        }
        if ( Id != null ) {
            this.Id = Id;
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
        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        if (this.AppItemTypeToken != null) {
            s += ind + "appItemTypeToken\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AppItemTypeToken
        // GraphQL -> appItemTypeToken: String! (scalar)
        if (this.AppItemTypeToken == null && ec.Includes("appItemTypeToken",true))
        {
            this.AppItemTypeToken = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
    }


    #endregion

    } // class Item
    
    #endregion

    public static class ListItemExtensions
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
            this List<Item> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Item> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Item());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<Item> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types