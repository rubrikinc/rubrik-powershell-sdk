// HashDetail.cs
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
    #region HashDetail
    public class HashDetail: BaseType
    {
        #region members

        //      C# -> System.String? HashType
        // GraphQL -> hashType: String! (scalar)
        [JsonProperty("hashType")]
        public System.String? HashType { get; set; }

        //      C# -> System.String? HashValue
        // GraphQL -> hashValue: String! (scalar)
        [JsonProperty("hashValue")]
        public System.String? HashValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HashDetail";
    }

    public HashDetail Set(
        System.String? HashType = null,
        System.String? HashValue = null
    ) 
    {
        if ( HashType != null ) {
            this.HashType = HashType;
        }
        if ( HashValue != null ) {
            this.HashValue = HashValue;
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
        //      C# -> System.String? HashType
        // GraphQL -> hashType: String! (scalar)
        if (this.HashType != null) {
            s += ind + "hashType\n" ;
        }
        //      C# -> System.String? HashValue
        // GraphQL -> hashValue: String! (scalar)
        if (this.HashValue != null) {
            s += ind + "hashValue\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? HashType
        // GraphQL -> hashType: String! (scalar)
        if (this.HashType == null && ec.Includes("hashType",true))
        {
            this.HashType = "FETCH";
        }
        //      C# -> System.String? HashValue
        // GraphQL -> hashValue: String! (scalar)
        if (this.HashValue == null && ec.Includes("hashValue",true))
        {
            this.HashValue = "FETCH";
        }
    }


    #endregion

    } // class HashDetail
    
    #endregion

    public static class ListHashDetailExtensions
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
            this List<HashDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HashDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HashDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<HashDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types