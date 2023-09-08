// KmsEncryptionKey.cs
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
    #region KmsEncryptionKey
    public class KmsEncryptionKey: BaseType
    {
        #region members

        //      C# -> List<System.String>? Aliases
        // GraphQL -> aliases: [String!]! (scalar)
        [JsonProperty("aliases")]
        public List<System.String>? Aliases { get; set; }

        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        [JsonProperty("arn")]
        public System.String? Arn { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "KmsEncryptionKey";
    }

    public KmsEncryptionKey Set(
        List<System.String>? Aliases = null,
        System.String? Arn = null,
        System.String? Id = null
    ) 
    {
        if ( Aliases != null ) {
            this.Aliases = Aliases;
        }
        if ( Arn != null ) {
            this.Arn = Arn;
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
        //      C# -> List<System.String>? Aliases
        // GraphQL -> aliases: [String!]! (scalar)
        if (this.Aliases != null) {
            s += ind + "aliases\n" ;
        }
        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        if (this.Arn != null) {
            s += ind + "arn\n" ;
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
        //      C# -> List<System.String>? Aliases
        // GraphQL -> aliases: [String!]! (scalar)
        if (this.Aliases == null && ec.Includes("aliases",true))
        {
            this.Aliases = new List<System.String>();
        }
        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        if (this.Arn == null && ec.Includes("arn",true))
        {
            this.Arn = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
    }


    #endregion

    } // class KmsEncryptionKey
    
    #endregion

    public static class ListKmsEncryptionKeyExtensions
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
            this List<KmsEncryptionKey> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<KmsEncryptionKey> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new KmsEncryptionKey());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<KmsEncryptionKey> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types